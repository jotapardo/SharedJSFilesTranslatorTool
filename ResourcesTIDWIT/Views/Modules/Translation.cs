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
				MessageBox.Show("Select at least one language for translation.");
				return;
			}

			ResultsRichTextBox.Clear();

			ResultsRichTextBox.AppendText($"Starting translations for {selectedLanguages.Count} languages...,\n");

			try
			{
				//Iterates through each line (Original Text)
				string[] lines = RichTextBoxOriginalText.Text.Split('\n');

				for (int i = 0; i < lines.Length; i++)
				{
					string textToTranslate = lines[i].Trim();

					// Iterates through each selected language and saves the translation to the file
					foreach (string targetLanguage in selectedLanguages)
					{
						ResultsRichTextBox.AppendText($"------------------- \n");
						ResultsRichTextBox.AppendText($"Text to translate: '{textToTranslate}' \n");
						ResultsRichTextBox.AppendText($"Translating to: '{targetLanguage}' \n");

						// Save the translation using the FileUtils function
						string identifier = dataGridViewTranslations.Rows[i].Cells[0].Value.ToString(); ;


						string finalText = "";

						if (targetLanguage != "en")
						{
							// Translate the text using the Translation Utils function
							try
							{
								string translationResult = await TranslationUtils.Translate(textToTranslate, targetLanguage);
								dynamic result = JsonConvert.DeserializeObject(translationResult);

								finalText = result[0].translations[0].text;
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
					MessageBox.Show("Translation completed and saved successfully!");

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

		private void RichTextBoxOriginalText_TextChanged(object sender, EventArgs e)
		{
			// Clear the DataGridView before adding new translations
			dataGridViewTranslations.Rows.Clear();

			// Separate text into lines
			string[] lines = RichTextBoxOriginalText.Text.Split('\n');

			// Add each line as a new translation to the DataGridView
			foreach (string line in lines)
			{
				//Add row to DataGridView
				dataGridViewTranslations.Rows.Add(StringFormattingUtils.ConvertToPascalCase(line)); // Generate key for translation
			}

			Color color1 = Color.LightGray; // Color de fondo para la línea par
			Color color2 = Color.White;     // Color de fondo para la línea impar
			
			// Save current selection start to reset it later
			int selectionStart = RichTextBoxOriginalText.SelectionStart;

			int startIndex = 0;

			// Applying background color to lines based on their index (odd/even)
			for (int i = 0; i < lines.Length; i++)
			{
				int length = lines[i].Length;
				RichTextBoxOriginalText.Select(startIndex, length);
				RichTextBoxOriginalText.SelectionBackColor = i % 2 == 0 ? color1 : color2;

				startIndex += length + 1; // +1 por el salto de línea
			}
			
			// Return caret to the original position
			RichTextBoxOriginalText.Select(selectionStart, 0);
			RichTextBoxOriginalText.SelectionBackColor = RichTextBoxOriginalText.BackColor;

		}
	}
}
