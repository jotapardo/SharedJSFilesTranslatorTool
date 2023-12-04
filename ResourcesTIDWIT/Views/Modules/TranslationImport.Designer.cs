namespace ResourcesSharedFiles.Views.Modules
{
	partial class TranslationImport
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.RichTextBoxOriginalText = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnChange = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RichTextBoxOriginalText
			// 
			this.RichTextBoxOriginalText.Location = new System.Drawing.Point(13, 92);
			this.RichTextBoxOriginalText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.RichTextBoxOriginalText.Name = "RichTextBoxOriginalText";
			this.RichTextBoxOriginalText.Size = new System.Drawing.Size(743, 233);
			this.RichTextBoxOriginalText.TabIndex = 73;
			this.RichTextBoxOriginalText.Text = "";
			this.RichTextBoxOriginalText.TextChanged += new System.EventHandler(this.RichTextBoxOriginalText_TextChanged);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(13, 46);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(744, 56);
			this.label4.TabIndex = 72;
			this.label4.Text = "Original Text";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(552, 20);
			this.label1.TabIndex = 71;
			this.label1.Text = "Enter the text in ENGLISH to translate (It allows multiple lines for each transla" +
    "tion):";
			// 
			// btnChange
			// 
			this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnChange.FlatAppearance.BorderSize = 0;
			this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChange.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChange.Location = new System.Drawing.Point(512, 334);
			this.btnChange.Margin = new System.Windows.Forms.Padding(4);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(245, 60);
			this.btnChange.TabIndex = 74;
			this.btnChange.Text = "IMPORT";
			this.btnChange.UseVisualStyleBackColor = false;
			// 
			// TranslationImport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(783, 410);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.RichTextBoxOriginalText);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "TranslationImport";
			this.Text = "TranslationImport";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox RichTextBoxOriginalText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnChange;
	}
}