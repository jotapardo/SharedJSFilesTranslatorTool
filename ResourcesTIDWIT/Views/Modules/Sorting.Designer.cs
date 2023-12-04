namespace ResourcesSharedFiles.Views.Modules
{
	partial class Sorting
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
			this.checkedListBoxLanguages = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCheckUncheckAll = new System.Windows.Forms.Button();
			this.SortButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.ResultsRichTextBox = new System.Windows.Forms.RichTextBox();
			this.CheckBoxRemoveDuplicates = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// checkedListBoxLanguages
			// 
			this.checkedListBoxLanguages.FormattingEnabled = true;
			this.checkedListBoxLanguages.Location = new System.Drawing.Point(19, 81);
			this.checkedListBoxLanguages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.checkedListBoxLanguages.Name = "checkedListBoxLanguages";
			this.checkedListBoxLanguages.Size = new System.Drawing.Size(146, 136);
			this.checkedListBoxLanguages.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select the languages to sort:";
			// 
			// buttonCheckUncheckAll
			// 
			this.buttonCheckUncheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCheckUncheckAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCheckUncheckAll.Location = new System.Drawing.Point(19, 45);
			this.buttonCheckUncheckAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonCheckUncheckAll.Name = "buttonCheckUncheckAll";
			this.buttonCheckUncheckAll.Size = new System.Drawing.Size(111, 28);
			this.buttonCheckUncheckAll.TabIndex = 3;
			this.buttonCheckUncheckAll.Text = "Mark/ Unmark All";
			this.buttonCheckUncheckAll.UseVisualStyleBackColor = true;
			this.buttonCheckUncheckAll.Click += new System.EventHandler(this.buttonCheckUncheckAll_Click);
			// 
			// SortButton
			// 
			this.SortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(137)))), ((int)(((byte)(52)))));
			this.SortButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SortButton.FlatAppearance.BorderSize = 0;
			this.SortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
			this.SortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(160)))), ((int)(((byte)(52)))));
			this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SortButton.Font = new System.Drawing.Font("AvantGarde Bk BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SortButton.ForeColor = System.Drawing.Color.White;
			this.SortButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.SortButton.Location = new System.Drawing.Point(19, 264);
			this.SortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SortButton.Name = "SortButton";
			this.SortButton.Size = new System.Drawing.Size(584, 56);
			this.SortButton.TabIndex = 57;
			this.SortButton.Text = "SORT";
			this.SortButton.UseVisualStyleBackColor = false;
			this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
			this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new System.Drawing.Point(19, 327);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(6);
			this.label6.Size = new System.Drawing.Size(67, 32);
			this.label6.TabIndex = 69;
			this.label6.Text = "Results";
			// 
			// ResultsRichTextBox
			// 
			this.ResultsRichTextBox.Location = new System.Drawing.Point(92, 327);
			this.ResultsRichTextBox.Name = "ResultsRichTextBox";
			this.ResultsRichTextBox.Size = new System.Drawing.Size(511, 231);
			this.ResultsRichTextBox.TabIndex = 68;
			this.ResultsRichTextBox.Text = "";
			// 
			// CheckBoxRemoveDuplicates
			// 
			this.CheckBoxRemoveDuplicates.AutoSize = true;
			this.CheckBoxRemoveDuplicates.Location = new System.Drawing.Point(19, 233);
			this.CheckBoxRemoveDuplicates.Name = "CheckBoxRemoveDuplicates";
			this.CheckBoxRemoveDuplicates.Size = new System.Drawing.Size(252, 24);
			this.CheckBoxRemoveDuplicates.TabIndex = 70;
			this.CheckBoxRemoveDuplicates.Text = "Automatically Remove Duplicates";
			this.CheckBoxRemoveDuplicates.UseVisualStyleBackColor = true;
			// 
			// Sorting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(627, 692);
			this.Controls.Add(this.CheckBoxRemoveDuplicates);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ResultsRichTextBox);
			this.Controls.Add(this.SortButton);
			this.Controls.Add(this.buttonCheckUncheckAll);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkedListBoxLanguages);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Sorting";
			this.Text = "Sorting";
			this.Load += new System.EventHandler(this.Sorting_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckedListBox checkedListBoxLanguages;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonCheckUncheckAll;
		private System.Windows.Forms.Button SortButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox ResultsRichTextBox;
		private System.Windows.Forms.CheckBox CheckBoxRemoveDuplicates;
	}
}