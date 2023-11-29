using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ResourcesSharedFiles
{
	public partial class InputBoxForm : Form
	{
		public string EnteredValue
		{
			get { return txtNewValue.Text; }
			set { txtNewValue.Text = value; }
		}

		public string originalValue { get; set; }
		public string languageSource { get; set; }

		public InputBoxForm()
		{
			InitializeComponent();
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void InputBoxForm_Load(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(originalValue))
			{
				txtNewValue.Text = originalValue;
				lblCurrentValue.Text = originalValue;
				lblCurrentLanguage.Text = languageSource;
			}
		}

		private void btnUndo_Click(object sender, EventArgs e)
		{
			txtNewValue.Text = originalValue;
		}
	}
}
