using ResourcesSharedFiles.Configuration;
using ResourcesSharedFiles.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AzureCognitiveTranslator.Translator;

namespace ResourcesSharedFiles.Views.Modules
{
	public partial class Sorting : Form
	{
		public Sorting()
		{
			InitializeComponent();
			// Subscribe to the OperationCompleted event in FileUtils
			FileUtils.OperationCompleted += OnOperationCompleted;
		}
		private void OnOperationCompleted(object sender, string message)
		{
			try
			{
				// Show the message in ResultsRichTextBox
				ResultsRichTextBox.AppendText($"{message}\n");
				ResultsRichTextBox.SelectionStart = ResultsRichTextBox.Text.Length;
				ResultsRichTextBox.ScrollToCaret();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			
		}
		private void Sorting_Load(object sender, EventArgs e)
		{
			// Load available languages into the CheckedListBox
			checkedListBoxLanguages.CheckOnClick = true;

			string folderPath = ConfigurationManager.ReadSetting("PathFilesSharedJs");

			if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
			{
				string[] subFolders = Directory.GetDirectories(folderPath);

				// Add subfolder names to the CheckedListBox
				foreach (string subFolder in subFolders)
				{
					string language = new DirectoryInfo(subFolder).Name;
					checkedListBoxLanguages.Items.Add(language);
				}
			}
			else
			{
				MessageBox.Show("The shared files path is invalid.");
			}
		}

		private void buttonCheckUncheckAll_Click(object sender, EventArgs e)
		{
			bool allChecked = checkedListBoxLanguages.CheckedItems.Count == checkedListBoxLanguages.Items.Count;

			for (int i = 0; i < checkedListBoxLanguages.Items.Count; i++)
			{
				checkedListBoxLanguages.SetItemChecked(i, !allChecked);
			}

			checkedListBoxLanguages.ClearSelected();
		}

		private void SortButton_Click(object sender, EventArgs e)
		{
			string basePath = ConfigurationManager.ReadSetting("PathFilesSharedJs");
			Color originalBackColor;

			try
			{
				if (checkedListBoxLanguages.CheckedItems.Count == 0)
				{
					 
					MessageBox.Show($"Select at least one language before sorting.\n");
					return;
				}
					

				foreach (var language in checkedListBoxLanguages.CheckedItems)
				{
					string filePath = Path.Combine(basePath, language.ToString(), "Shared.js");

					if (File.Exists(filePath))
					{
						OnOperationCompleted(null, $"--------------------------------------------------------.\n");
						OnOperationCompleted(null,$"Sorting '{language.ToString()}' languaje.\n");
						FileUtils.SortSharedJSFile(filePath);
					}
					else
					{
						MessageBox.Show($"File '{language}/Shared.js' not found.\n");
					}
				}

				checkedListBoxLanguages.ClearSelected();

				// Change button appearance after sorting
				originalBackColor = SortButton.BackColor; // Store original color
				SortButton.Text = "SORTED";
				SortButton.BackColor = Color.DarkGray;

				// Start a timer to revert the button appearance after 2 seconds
				Timer timer = new Timer();
				timer.Interval = 2000; // 2 seconds
				timer.Tick += (s, args) =>
				{
					SortButton.Text = "SORT";
					SortButton.BackColor = originalBackColor; // Restore original color
					timer.Stop();
					timer.Dispose();
				};
				timer.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error sorting Shared.js files: {ex.Message}\n");
				
			}
		}
	}
}
