namespace ResourcesSharedFiles.Views.Modules
{
	partial class Translation
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.CheckBoxFRValidate = new System.Windows.Forms.CheckBox();
			this.CheckBoxDEValidate = new System.Windows.Forms.CheckBox();
			this.CheckBoxPTValidate = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CheckBoxESValidate = new System.Windows.Forms.CheckBox();
			this.PathFilesSharedJs = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ResultsRichTextBox = new System.Windows.Forms.RichTextBox();
			this.TranslateButton = new System.Windows.Forms.Button();
			this.CheckBoxFR = new System.Windows.Forms.CheckBox();
			this.CheckBoxDE = new System.Windows.Forms.CheckBox();
			this.CheckBoxPT = new System.Windows.Forms.CheckBox();
			this.CheckBoxEN = new System.Windows.Forms.CheckBox();
			this.CheckBoxES = new System.Windows.Forms.CheckBox();
			this.dataGridViewTranslations = new System.Windows.Forms.DataGridView();
			this.OriginalText = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TranslationKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CheckBoxCleanGrid = new System.Windows.Forms.CheckBox();
			this.dataGridViewResults = new System.Windows.Forms.DataGridView();
			this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.copyTranslationKey = new System.Windows.Forms.DataGridViewButtonColumn();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.labelMessage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranslations)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
			this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new System.Drawing.Point(12, 471);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(6);
			this.label6.Size = new System.Drawing.Size(67, 32);
			this.label6.TabIndex = 67;
			this.label6.Text = "Results";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new System.Drawing.Point(12, 320);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(157, 20);
			this.label5.TabIndex = 66;
			this.label5.Text = "Path for Shared.js files:";
			// 
			// CheckBoxFRValidate
			// 
			this.CheckBoxFRValidate.AutoSize = true;
			this.CheckBoxFRValidate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CheckBoxFRValidate.Location = new System.Drawing.Point(490, 291);
			this.CheckBoxFRValidate.Name = "CheckBoxFRValidate";
			this.CheckBoxFRValidate.Size = new System.Drawing.Size(101, 24);
			this.CheckBoxFRValidate.TabIndex = 65;
			this.CheckBoxFRValidate.Text = "validate FR";
			this.CheckBoxFRValidate.UseVisualStyleBackColor = true;
			// 
			// CheckBoxDEValidate
			// 
			this.CheckBoxDEValidate.AutoSize = true;
			this.CheckBoxDEValidate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CheckBoxDEValidate.Location = new System.Drawing.Point(369, 291);
			this.CheckBoxDEValidate.Name = "CheckBoxDEValidate";
			this.CheckBoxDEValidate.Size = new System.Drawing.Size(104, 24);
			this.CheckBoxDEValidate.TabIndex = 64;
			this.CheckBoxDEValidate.Text = "validate DE";
			this.CheckBoxDEValidate.UseVisualStyleBackColor = true;
			// 
			// CheckBoxPTValidate
			// 
			this.CheckBoxPTValidate.AutoSize = true;
			this.CheckBoxPTValidate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CheckBoxPTValidate.Location = new System.Drawing.Point(251, 291);
			this.CheckBoxPTValidate.Name = "CheckBoxPTValidate";
			this.CheckBoxPTValidate.Size = new System.Drawing.Size(101, 24);
			this.CheckBoxPTValidate.TabIndex = 63;
			this.CheckBoxPTValidate.Text = "validate PT";
			this.CheckBoxPTValidate.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new System.Drawing.Point(12, 221);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(192, 20);
			this.label3.TabIndex = 62;
			this.label3.Text = "Languages to be translated:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(12, 268);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 20);
			this.label2.TabIndex = 61;
			this.label2.Text = "Validate before update file:";
			// 
			// CheckBoxESValidate
			// 
			this.CheckBoxESValidate.AutoSize = true;
			this.CheckBoxESValidate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CheckBoxESValidate.Location = new System.Drawing.Point(133, 291);
			this.CheckBoxESValidate.Name = "CheckBoxESValidate";
			this.CheckBoxESValidate.Size = new System.Drawing.Size(101, 24);
			this.CheckBoxESValidate.TabIndex = 60;
			this.CheckBoxESValidate.Text = "validate ES";
			this.CheckBoxESValidate.UseVisualStyleBackColor = true;
			// 
			// PathFilesSharedJs
			// 
			this.PathFilesSharedJs.Enabled = false;
			this.PathFilesSharedJs.Location = new System.Drawing.Point(12, 343);
			this.PathFilesSharedJs.Name = "PathFilesSharedJs";
			this.PathFilesSharedJs.ReadOnly = true;
			this.PathFilesSharedJs.Size = new System.Drawing.Size(584, 27);
			this.PathFilesSharedJs.TabIndex = 59;
			this.PathFilesSharedJs.Text = "C:\\Development\\TIDWIT60\\C3\\C3.MicroServices\\C3.UI\\C3.UI\\src\\js\\i18n\\lang";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(552, 20);
			this.label1.TabIndex = 58;
			this.label1.Text = "Enter the text in ENGLISH to translate (It allows multiple lines for each transla" +
    "tion):";
			// 
			// ResultsRichTextBox
			// 
			this.ResultsRichTextBox.Location = new System.Drawing.Point(12, 509);
			this.ResultsRichTextBox.Name = "ResultsRichTextBox";
			this.ResultsRichTextBox.Size = new System.Drawing.Size(336, 101);
			this.ResultsRichTextBox.TabIndex = 57;
			this.ResultsRichTextBox.Text = "";
			// 
			// TranslateButton
			// 
			this.TranslateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(137)))), ((int)(((byte)(52)))));
			this.TranslateButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.TranslateButton.FlatAppearance.BorderSize = 0;
			this.TranslateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
			this.TranslateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(160)))), ((int)(((byte)(52)))));
			this.TranslateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TranslateButton.Font = new System.Drawing.Font("AvantGarde Bk BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TranslateButton.ForeColor = System.Drawing.Color.White;
			this.TranslateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TranslateButton.Location = new System.Drawing.Point(12, 406);
			this.TranslateButton.Name = "TranslateButton";
			this.TranslateButton.Size = new System.Drawing.Size(584, 51);
			this.TranslateButton.TabIndex = 56;
			this.TranslateButton.Text = "TRANSLATE";
			this.TranslateButton.UseVisualStyleBackColor = false;
			this.TranslateButton.Click += new System.EventHandler(this.TranslateButton_Click);
			// 
			// CheckBoxFR
			// 
			this.CheckBoxFR.AutoSize = true;
			this.CheckBoxFR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CheckBoxFR.Location = new System.Drawing.Point(490, 244);
			this.CheckBoxFR.Name = "CheckBoxFR";
			this.CheckBoxFR.Size = new System.Drawing.Size(44, 24);
			this.CheckBoxFR.TabIndex = 55;
			this.CheckBoxFR.Text = "FR";
			this.CheckBoxFR.UseVisualStyleBackColor = true;
			// 
			// CheckBoxDE
			// 
			this.CheckBoxDE.AutoSize = true;
			this.CheckBoxDE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CheckBoxDE.Location = new System.Drawing.Point(369, 244);
			this.CheckBoxDE.Name = "CheckBoxDE";
			this.CheckBoxDE.Size = new System.Drawing.Size(47, 24);
			this.CheckBoxDE.TabIndex = 54;
			this.CheckBoxDE.Text = "DE";
			this.CheckBoxDE.UseVisualStyleBackColor = true;
			// 
			// CheckBoxPT
			// 
			this.CheckBoxPT.AutoSize = true;
			this.CheckBoxPT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CheckBoxPT.Location = new System.Drawing.Point(251, 244);
			this.CheckBoxPT.Name = "CheckBoxPT";
			this.CheckBoxPT.Size = new System.Drawing.Size(44, 24);
			this.CheckBoxPT.TabIndex = 53;
			this.CheckBoxPT.Text = "PT";
			this.CheckBoxPT.UseVisualStyleBackColor = true;
			// 
			// CheckBoxEN
			// 
			this.CheckBoxEN.AutoSize = true;
			this.CheckBoxEN.Checked = true;
			this.CheckBoxEN.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxEN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CheckBoxEN.Location = new System.Drawing.Point(16, 241);
			this.CheckBoxEN.Name = "CheckBoxEN";
			this.CheckBoxEN.Size = new System.Drawing.Size(47, 24);
			this.CheckBoxEN.TabIndex = 52;
			this.CheckBoxEN.Text = "EN";
			this.CheckBoxEN.UseVisualStyleBackColor = true;
			// 
			// CheckBoxES
			// 
			this.CheckBoxES.AutoSize = true;
			this.CheckBoxES.Checked = true;
			this.CheckBoxES.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxES.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CheckBoxES.Location = new System.Drawing.Point(133, 244);
			this.CheckBoxES.Name = "CheckBoxES";
			this.CheckBoxES.Size = new System.Drawing.Size(44, 24);
			this.CheckBoxES.TabIndex = 51;
			this.CheckBoxES.Text = "ES";
			this.CheckBoxES.UseVisualStyleBackColor = true;
			// 
			// dataGridViewTranslations
			// 
			this.dataGridViewTranslations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewTranslations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewTranslations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
			this.dataGridViewTranslations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTranslations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalText,
            this.TranslationKey});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTranslations.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTranslations.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewTranslations.Location = new System.Drawing.Point(16, 34);
			this.dataGridViewTranslations.Name = "dataGridViewTranslations";
			this.dataGridViewTranslations.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
			this.dataGridViewTranslations.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
			this.dataGridViewTranslations.Size = new System.Drawing.Size(580, 184);
			this.dataGridViewTranslations.TabIndex = 68;
			this.dataGridViewTranslations.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTranslations_CellEndEdit);
			// 
			// OriginalText
			// 
			this.OriginalText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.OriginalText.DefaultCellStyle = dataGridViewCellStyle1;
			this.OriginalText.HeaderText = "Original Text";
			this.OriginalText.Name = "OriginalText";
			this.OriginalText.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.OriginalText.Width = 400;
			// 
			// TranslationKey
			// 
			this.TranslationKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.TranslationKey.DefaultCellStyle = dataGridViewCellStyle2;
			this.TranslationKey.HeaderText = "Translation Key";
			this.TranslationKey.Name = "TranslationKey";
			this.TranslationKey.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.TranslationKey.Width = 130;
			// 
			// CheckBoxCleanGrid
			// 
			this.CheckBoxCleanGrid.AutoSize = true;
			this.CheckBoxCleanGrid.Checked = true;
			this.CheckBoxCleanGrid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxCleanGrid.Location = new System.Drawing.Point(12, 376);
			this.CheckBoxCleanGrid.Name = "CheckBoxCleanGrid";
			this.CheckBoxCleanGrid.Size = new System.Drawing.Size(205, 24);
			this.CheckBoxCleanGrid.TabIndex = 69;
			this.CheckBoxCleanGrid.Text = "Clean grid after translation";
			this.CheckBoxCleanGrid.UseVisualStyleBackColor = true;
			// 
			// dataGridViewResults
			// 
			this.dataGridViewResults.AllowUserToAddRows = false;
			this.dataGridViewResults.AllowUserToDeleteRows = false;
			this.dataGridViewResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
			this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.copyTranslationKey});
			this.dataGridViewResults.Location = new System.Drawing.Point(369, 509);
			this.dataGridViewResults.Name = "dataGridViewResults";
			this.dataGridViewResults.ReadOnly = true;
			this.dataGridViewResults.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
			this.dataGridViewResults.ShowEditingIcon = false;
			this.dataGridViewResults.Size = new System.Drawing.Size(227, 113);
			this.dataGridViewResults.TabIndex = 70;
			this.dataGridViewResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResults_CellContentClick);
			// 
			// Key
			// 
			this.Key.HeaderText = "TranslationKey";
			this.Key.Name = "Key";
			this.Key.ReadOnly = true;
			this.Key.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Key.Width = 120;
			// 
			// copyTranslationKey
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			this.copyTranslationKey.DefaultCellStyle = dataGridViewCellStyle4;
			this.copyTranslationKey.HeaderText = "Copy";
			this.copyTranslationKey.Name = "copyTranslationKey";
			this.copyTranslationKey.ReadOnly = true;
			this.copyTranslationKey.Text = "Copy";
			this.copyTranslationKey.Width = 50;
			// 
			// timer1
			// 
			this.timer1.Interval = 2000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// labelMessage
			// 
			this.labelMessage.AutoSize = true;
			this.labelMessage.Location = new System.Drawing.Point(365, 483);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(0, 20);
			this.labelMessage.TabIndex = 71;
			// 
			// Translation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(610, 640);
			this.Controls.Add(this.labelMessage);
			this.Controls.Add(this.dataGridViewResults);
			this.Controls.Add(this.CheckBoxCleanGrid);
			this.Controls.Add(this.dataGridViewTranslations);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CheckBoxFRValidate);
			this.Controls.Add(this.CheckBoxDEValidate);
			this.Controls.Add(this.CheckBoxPTValidate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CheckBoxESValidate);
			this.Controls.Add(this.PathFilesSharedJs);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ResultsRichTextBox);
			this.Controls.Add(this.TranslateButton);
			this.Controls.Add(this.CheckBoxFR);
			this.Controls.Add(this.CheckBoxDE);
			this.Controls.Add(this.CheckBoxPT);
			this.Controls.Add(this.CheckBoxEN);
			this.Controls.Add(this.CheckBoxES);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Translation";
			this.Text = "Translation";
			this.Load += new System.EventHandler(this.Translation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranslations)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox CheckBoxFRValidate;
		private System.Windows.Forms.CheckBox CheckBoxDEValidate;
		private System.Windows.Forms.CheckBox CheckBoxPTValidate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox CheckBoxESValidate;
		private System.Windows.Forms.TextBox PathFilesSharedJs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox ResultsRichTextBox;
		private System.Windows.Forms.Button TranslateButton;
		private System.Windows.Forms.CheckBox CheckBoxFR;
		private System.Windows.Forms.CheckBox CheckBoxDE;
		private System.Windows.Forms.CheckBox CheckBoxPT;
		private System.Windows.Forms.CheckBox CheckBoxEN;
		private System.Windows.Forms.CheckBox CheckBoxES;
		private System.Windows.Forms.DataGridView dataGridViewTranslations;
		private System.Windows.Forms.DataGridViewTextBoxColumn OriginalText;
		private System.Windows.Forms.DataGridViewTextBoxColumn TranslationKey;
		private System.Windows.Forms.CheckBox CheckBoxCleanGrid;
		private System.Windows.Forms.DataGridView dataGridViewResults;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label labelMessage;
		private System.Windows.Forms.DataGridViewTextBoxColumn Key;
		private System.Windows.Forms.DataGridViewButtonColumn copyTranslationKey;
	}
}