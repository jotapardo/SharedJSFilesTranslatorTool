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
using ResourcesTIDWIT.Configuration; // Make sure to add a reference to the Microsoft.WindowsAPICodePack NuGet package


namespace ResourcesTIDWIT.Views.Modules
{
	public partial class Configuration : Form
	{
		private string directoryPath = @"";

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
			PathFilesSharedJs.Text = directoryPath;
		}
	}
}
