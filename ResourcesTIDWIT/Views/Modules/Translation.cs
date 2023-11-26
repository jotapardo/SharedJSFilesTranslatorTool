using Newtonsoft.Json;
using ResourcesTIDWIT.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourcesTIDWIT.Views.Modules
{
	public partial class Translation : Form
	{
		public Translation()
		{
			InitializeComponent();
			// Subscribe to the OperationCompleted event in FileUtils
			FileUtils.OperationCompleted += OnOperationCompleted;
		}
		private async void TranslateButton_Click(object sender, EventArgs e)
		{
			string textToTranslate = TextBoxTextoOriginal.Text;
			List<string> selectedLanguages = new List<string>();

			// Obtener los idiomas seleccionados
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
				// Iterates through each selected language and saves the translation to the file
				foreach (string targetLanguage in selectedLanguages)
				{
					ResultsRichTextBox.AppendText($"------------------- \n");
					ResultsRichTextBox.AppendText($"Translating to '{targetLanguage}' \n");

					// Guardar la traducción utilizando la función de FileUtils
					string identifier = StringFormattingUtils.ConvertToPascalCase(textToTranslate);
					string finalText = "";

					if (targetLanguage != "en")
					{
						// Traducir el texto utilizando la función de TranslationUtils
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

					FileUtils.SaveTranslationToFile(targetLanguage, identifier, finalText);

				}

				ResultsRichTextBox.AppendText("Done! \n");

				// Mostrar un mensaje de éxito o hacer otras acciones si es necesario
				MessageBox.Show("Translation completed and saved successfully!");
			}
			catch (Exception ex)
			{
				// Manejar errores si la traducción falla
				MessageBox.Show($"Translation failed. Error: {ex.Message}");
			}
		}
		private void OnOperationCompleted(object sender, string message)
		{
			// Show the message in ResultsRichTextBox
			ResultsRichTextBox.AppendText($"{message}\n");
		}
	}
}
