using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using ResourcesSharedFiles.Configuration; // Make sure to add a reference to the Microsoft.WindowsAPICodePack NuGet package


namespace ResourcesSharedFiles.Views.Modules
{
	public partial class Configuration : Form
	{
		private string directoryPath = @"";
		private string serviceTranslation = @"";

		public Configuration()
		{
			InitializeComponent();
		}

		private void btnOpenLocation_Click(object sender, EventArgs e)
		{
			OpenExplorer(directoryPath);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OpenExplorer(string path)
		{
			try
			{
				Process.Start(path);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening location: " + ex.Message);
			}
		}

		private void btnChangeDirectory_Click(object sender, EventArgs e)
		{
			var folderDialog = new CommonOpenFileDialog
			{
				IsFolderPicker = true,
				Title = "Select a folder"
			};

			if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				directoryPath = folderDialog.FileName;
				PathFilesSharedJs.Text = directoryPath;
				// Guardar la ruta seleccionada en la configuración
				ConfigurationManager.WriteSetting("PathFilesSharedJs", directoryPath);
			}
		}

		private void Configuration_Load(object sender, EventArgs e)
		{
			directoryPath = ConfigurationManager.ReadSetting("PathFilesSharedJs");
			serviceTranslation = ConfigurationManager.ReadSetting("ServiceTranlation");

			PathFilesSharedJs.Text = directoryPath;

			if (serviceTranslation == "Azure")
			{
				RadioButtonServicesTranlationAzure.Checked = true;
				RadioButtonServicesTranlationGoogle.Checked = false;
			}

			if (serviceTranslation == "Google")
			{
				RadioButtonServicesTranlationAzure.Checked = false;
				RadioButtonServicesTranlationGoogle.Checked = true;
			}
		}

		private void RadioButtonServicesTranlationAzure_CheckedChanged(object sender, EventArgs e)
		{
			if(RadioButtonServicesTranlationAzure.Checked)
				ConfigurationManager.WriteSetting("ServiceTranlation", "Azure");
		}

		private void RadioButtonServicesTranlationGoogle_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioButtonServicesTranlationAzure.Checked)
				ConfigurationManager.WriteSetting("ServiceTranlation", "Google");
		}
	}
}
