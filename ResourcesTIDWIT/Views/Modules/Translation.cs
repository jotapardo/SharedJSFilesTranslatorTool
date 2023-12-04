using Newtonsoft.Json;
using ResourcesSharedFiles.Configuration;
using ResourcesSharedFiles.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourcesSharedFiles.Views.Modules
{
	public partial class Translation : Form
	{
		public Translation()
		{
			InitializeComponent();
			// Subscribe to the OperationCompleted event in FileUtils
			FileUtils.OperationCompleted += OnOperationCompleted;
		}
		private void OnOperationCompleted(object sender, string message)
		{
			// Show the message in ResultsRichTextBox
			ResultsRichTextBox.AppendText($"{message}\n");
			ResultsRichTextBox.SelectionStart = ResultsRichTextBox.Text.Length;
			ResultsRichTextBox.ScrollToCaret();
		}
		private async void TranslateButton_Click(object sender, EventArgs e)
		{
			// Get selected languages
			List<string> selectedLanguages = new List<string>();

			
			if (CheckBoxEN.Checked) selectedLanguages.Add("en");
			if (CheckBoxES.Checked) selectedLanguages.Add("es");
			if (CheckBoxPT.Checked) selectedLanguages.Add("pt");
			if (CheckBoxDE.Checked) selectedLanguages.Add("de");
			if (CheckBoxFR.Checked) selectedLanguages.Add("fr");

			List<string> languagesToValidate = new List<string>();
			if (CheckBoxESValidate.Checked) languagesToValidate.Add("es");
			if (CheckBoxPTValidate.Checked) languagesToValidate.Add("pt");
			if (CheckBoxDEValidate.Checked) languagesToValidate.Add("de");
			if (CheckBoxFRValidate.Checked) languagesToValidate.Add("fr");

			// Check if at least one language is selected
			if (selectedLanguages.Count == 0)
			{
				MessageBox.Show("Select at least one language for translation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			ResultsRichTextBox.Clear();

			ResultsRichTextBox.AppendText($"Starting translations for {selectedLanguages.Count} languages...,\n");

			try
			{
				//Iterates through each line (Original Text)
				// Check if dataGridViewTranslations is empty or doesn't contain the expected column
				if (dataGridViewTranslations.Rows.Count == 0 || !dataGridViewTranslations.Columns.Contains("OriginalText"))
				{
					MessageBox.Show("Enter a text for translation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Get texts from the "OriginalText" column
				List<string> originalTexts = new List<string>();
				foreach (DataGridViewRow row in dataGridViewTranslations.Rows)
				{
					if (!row.IsNewRow && row.Cells["OriginalText"].Value != null)
					{
						string originalText = row.Cells["OriginalText"].Value.ToString();
						if (!string.IsNullOrWhiteSpace(originalText))
						{
							originalTexts.Add(originalText);
						}

						//Add row to DataGridView
						//dataGridViewTranslations.Rows.Add(StringFormattingUtils.ConvertToPascalCase(line)); // Generate key for translation

					}
				}

				// Check if there are texts for translation
				if (originalTexts.Count == 0)
				{
					MessageBox.Show("Enter a text for translation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				for (int i = 0; i < originalTexts.Count; i++)
				{
					string textToTranslate = originalTexts[i].Trim();

					// Iterates through each selected language and saves the translation to the file
					foreach (string targetLanguage in selectedLanguages)
					{
						ResultsRichTextBox.AppendText($"------------------- \n");
						ResultsRichTextBox.AppendText($"Text to translate: '{textToTranslate}' \n");
						ResultsRichTextBox.AppendText($"Translating to: '{targetLanguage}' \n");

						// Save the translation using the FileUtils function
						string identifier = dataGridViewTranslations.Rows[i].Cells[0].Value.ToString();


						string finalText = "";

						if (targetLanguage != "en")
						{
							// Translate the text using the Translation Utils function
							try
							{
								string translationResult = await TranslationUtils.Translate(textToTranslate, targetLanguage);

								if (translationResult != null)
								{
									dynamic result = JsonConvert.DeserializeObject(translationResult);
									finalText = result[0].translations[0].text;
								}
								
								//finalText = "test test test";
							}
							catch (Exception ex)
							{
								finalText = textToTranslate;
								MessageBox.Show("Error in translation service. Desc:" + ex.Message);
							}

							bool containsValue = languagesToValidate.Contains(targetLanguage);

							if (containsValue)
							{
								using (var inputBox = new InputBoxForm())
								{
									//inputBox.EnteredValue = finalText;
									inputBox.originalValue = finalText;
									inputBox.languageSource = targetLanguage;
									if (inputBox.ShowDialog() == DialogResult.OK)
									{
										string valorIngresado = inputBox.EnteredValue;
										finalText = valorIngresado;
										ResultsRichTextBox.AppendText($"New value: '{finalText}'\n");
									}
								}
							}

						}
						else
							finalText = textToTranslate;

						ResultsRichTextBox.AppendText($"Translated text: '{finalText}' \n");
						FileUtils.SaveTranslationToFile(targetLanguage, identifier, finalText);

					}

					ResultsRichTextBox.AppendText("Done! \n");

					// Show a success message or take other actions if necessary
					MessageBox.Show("Translation completed and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					if(CheckBoxCleanGrid.Checked)
					{
						if (dataGridViewTranslations.Rows.Count > 0)
						{
							// Clear the DataGridView after adding new translations
							dataGridViewTranslations.Rows.Clear();
						}
					}

				}//end for (int i = 0; i < lines.Length; i++)

			}
			catch (Exception ex)
			{
				// Handle errors if translation fails
				MessageBox.Show($"Translation failed. Error: {ex.Message}");
			}
		}
		private void Translation_Load(object sender, EventArgs e)
		{
			PathFilesSharedJs.Text = ConfigurationManager.ReadSetting("PathFilesSharedJs");
		}

		private void dataGridViewTranslations_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			// Check if the edited cell belongs to the "OriginalText" column
			if (e.ColumnIndex == dataGridViewTranslations.Columns["OriginalText"].Index &&
				e.RowIndex >= 0 && e.RowIndex < dataGridViewTranslations.Rows.Count)
			{
				DataGridViewRow editedRow = dataGridViewTranslations.Rows[e.RowIndex];
				string originalText = editedRow.Cells["OriginalText"].Value?.ToString();

				if (!string.IsNullOrWhiteSpace(originalText))
				{
					// Update the "TranslationKey" cell in the same row with the modified value
					string translationKey = StringFormattingUtils.ConvertToPascalCase(originalText);
					editedRow.Cells["TranslationKey"].Value = translationKey;
				}
			}

			if (e.ColumnIndex == dataGridViewTranslations.Columns["OriginalText"].Index ||
				e.ColumnIndex == dataGridViewTranslations.Columns["TranslationKey"].Index)
			{
				AreThereDuplicates();
			}
		}

		private bool AreThereDuplicates()
		{
			HashSet<string> uniquePairs = new HashSet<string>();

			for (int i = 0; i < dataGridViewTranslations.Rows.Count - 1; i++) // Exclude the new row placeholder
			{
				DataGridViewRow row = dataGridViewTranslations.Rows[i];

				string originalText = row.Cells["OriginalText"].Value?.ToString();
				string translationKey = row.Cells["TranslationKey"].Value?.ToString();

				if (!string.IsNullOrEmpty(originalText) && !string.IsNullOrEmpty(translationKey))
				{
					string pair = $"{originalText}_{translationKey}";

					if (uniquePairs.Contains(pair))
					{
						MessageBox.Show($"Duplicate pair found at row {i + 1}: OriginalText - '{originalText}', TranslationKey - '{translationKey}'.");
						return true;
					}

					uniquePairs.Add(pair);
				}
			}

			return false;
		}
	}
}
