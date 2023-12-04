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
	public partial class TranslationImport : Form
	{
		public TranslationImport()
		{
			InitializeComponent();
		}

		private void RichTextBoxOriginalText_TextChanged(object sender, EventArgs e)
		{
			// Clear the DataGridView before adding new translations
			//dataGridViewTranslations.Rows.Clear();

			// Separate text into lines
			string[] lines = RichTextBoxOriginalText.Text.Split('\n');

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
