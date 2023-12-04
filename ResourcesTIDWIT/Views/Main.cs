using Newtonsoft.Json;
using ResourcesSharedFiles.Utilities;
using ResourcesSharedFiles.Views.Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AzureCognitiveTranslator.Translator;
using System.Reflection;

namespace ResourcesSharedFiles.Views
{
	public partial class Main : Form
	{
		//private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com";
		//private static readonly string key = "01b1813872524527b45edbceb33bc1a9";
		//private static readonly string location = "centralus";// location, also known as region. // required if you're using a multi-service or regional (not global) resource. It can be found in the Azure portal on the Keys and Endpoint page.

		//for dragging
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();


		//for rounded corners
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // width of ellipse
			int nHeightEllipse // height of ellipse
		);
		public Main()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

			lblVersion.Text = $"Version: {Assembly.GetEntryAssembly().GetName().Version.ToString()}"; 
			
		}

		private void PboxClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private Form activeForm = null;
		private void OpenChildForm(Form childForm)
		{
			activeForm?.Hide();// Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			
		}

		private void pictureBoxConfig_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Modules.Configuration());
		}

		private void pictureBoxTranslation_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Translation());
		}

		private void pictureBoxConfiguration_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Sorting());
		}
	}
}