namespace ResourcesSharedFiles
{
	partial class InputBoxForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblCurrentLanguage = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCurrentValue = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNewValue = new System.Windows.Forms.TextBox();
			this.btnChange = new System.Windows.Forms.Button();
			this.btnUndo = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Currently translating to:";
			// 
			// lblCurrentLanguage
			// 
			this.lblCurrentLanguage.AutoSize = true;
			this.lblCurrentLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentLanguage.Location = new System.Drawing.Point(15, 53);
			this.lblCurrentLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCurrentLanguage.Name = "lblCurrentLanguage";
			this.lblCurrentLanguage.Size = new System.Drawing.Size(128, 20);
			this.lblCurrentLanguage.TabIndex = 1;
			this.lblCurrentLanguage.Text = "<LANGUAGE>";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 92);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Current Value:";
			// 
			// lblCurrentValue
			// 
			this.lblCurrentValue.AutoSize = true;
			this.lblCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentValue.Location = new System.Drawing.Point(14, 128);
			this.lblCurrentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCurrentValue.Name = "lblCurrentValue";
			this.lblCurrentValue.Size = new System.Drawing.Size(112, 16);
			this.lblCurrentValue.TabIndex = 3;
			this.lblCurrentValue.Text = "<current value>";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 160);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "New value:";
			// 
			// txtNewValue
			// 
			this.txtNewValue.Location = new System.Drawing.Point(18, 196);
			this.txtNewValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNewValue.Name = "txtNewValue";
			this.txtNewValue.Size = new System.Drawing.Size(452, 25);
			this.txtNewValue.TabIndex = 5;
			// 
			// btnChange
			// 
			this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnChange.FlatAppearance.BorderSize = 0;
			this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChange.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChange.Location = new System.Drawing.Point(158, 265);
			this.btnChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(245, 60);
			this.btnChange.TabIndex = 6;
			this.btnChange.Text = "CHANGE";
			this.btnChange.UseVisualStyleBackColor = false;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// btnUndo
			// 
			this.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUndo.Location = new System.Drawing.Point(471, 196);
			this.btnUndo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnUndo.Name = "btnUndo";
			this.btnUndo.Size = new System.Drawing.Size(73, 25);
			this.btnUndo.TabIndex = 7;
			this.btnUndo.Text = "&RESET";
			this.toolTip1.SetToolTip(this.btnUndo, "UNDO");
			this.btnUndo.UseVisualStyleBackColor = true;
			this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
			// 
			// InputBoxForm
			// 
			this.AcceptButton = this.btnChange;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
			this.ClientSize = new System.Drawing.Size(560, 357);
			this.Controls.Add(this.btnUndo);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.txtNewValue);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblCurrentValue);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblCurrentLanguage);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "InputBoxForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "InputBoxForm";
			this.Load += new System.EventHandler(this.InputBoxForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCurrentLanguage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCurrentValue;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNewValue;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnUndo;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}