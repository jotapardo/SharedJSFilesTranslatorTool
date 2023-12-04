namespace ResourcesSharedFiles.Views.Modules
{
	partial class Configuration
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
			this.btnOpenLocation = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.PathFilesSharedJs = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnChangeDirectory = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.RadioButtonServicesTranlationAzure = new System.Windows.Forms.RadioButton();
			this.RadioButtonServicesTranlationGoogle = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOpenLocation
			// 
			this.btnOpenLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(137)))), ((int)(((byte)(52)))));
			this.btnOpenLocation.FlatAppearance.BorderSize = 0;
			this.btnOpenLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenLocation.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenLocation.Location = new System.Drawing.Point(17, 122);
			this.btnOpenLocation.Margin = new System.Windows.Forms.Padding(4);
			this.btnOpenLocation.Name = "btnOpenLocation";
			this.btnOpenLocation.Size = new System.Drawing.Size(141, 30);
			this.btnOpenLocation.TabIndex = 0;
			this.btnOpenLocation.Text = "Open files location";
			this.btnOpenLocation.UseVisualStyleBackColor = false;
			this.btnOpenLocation.Click += new System.EventHandler(this.btnOpenLocation_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new System.Drawing.Point(14, 68);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 17);
			this.label5.TabIndex = 50;
			this.label5.Text = "Path for Shared.js files:";
			// 
			// PathFilesSharedJs
			// 
			this.PathFilesSharedJs.Location = new System.Drawing.Point(17, 89);
			this.PathFilesSharedJs.Margin = new System.Windows.Forms.Padding(4);
			this.PathFilesSharedJs.Name = "PathFilesSharedJs";
			this.PathFilesSharedJs.Size = new System.Drawing.Size(506, 25);
			this.PathFilesSharedJs.TabIndex = 49;
			this.PathFilesSharedJs.Text = "C:\\Development\\TIDWIT60\\C3\\C3.MicroServices\\C3.UI\\C3.UI\\src\\js\\i18n\\lang";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(137)))), ((int)(((byte)(52)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(17, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 29);
			this.button1.TabIndex = 51;
			this.button1.Text = "← BACK";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnChangeDirectory
			// 
			this.btnChangeDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(137)))), ((int)(((byte)(52)))));
			this.btnChangeDirectory.FlatAppearance.BorderSize = 0;
			this.btnChangeDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangeDirectory.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangeDirectory.Location = new System.Drawing.Point(166, 122);
			this.btnChangeDirectory.Margin = new System.Windows.Forms.Padding(4);
			this.btnChangeDirectory.Name = "btnChangeDirectory";
			this.btnChangeDirectory.Size = new System.Drawing.Size(141, 30);
			this.btnChangeDirectory.TabIndex = 52;
			this.btnChangeDirectory.Text = "Change Directory...";
			this.btnChangeDirectory.UseVisualStyleBackColor = false;
			this.btnChangeDirectory.Click += new System.EventHandler(this.btnChangeDirectory_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RadioButtonServicesTranlationGoogle);
			this.groupBox1.Controls.Add(this.RadioButtonServicesTranlationAzure);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(17, 180);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(611, 100);
			this.groupBox1.TabIndex = 53;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Service for translation:";
			// 
			// RadioButtonServicesTranlationAzure
			// 
			this.RadioButtonServicesTranlationAzure.AutoSize = true;
			this.RadioButtonServicesTranlationAzure.Checked = true;
			this.RadioButtonServicesTranlationAzure.Location = new System.Drawing.Point(19, 27);
			this.RadioButtonServicesTranlationAzure.Name = "RadioButtonServicesTranlationAzure";
			this.RadioButtonServicesTranlationAzure.Size = new System.Drawing.Size(172, 21);
			this.RadioButtonServicesTranlationAzure.TabIndex = 0;
			this.RadioButtonServicesTranlationAzure.TabStop = true;
			this.RadioButtonServicesTranlationAzure.Text = "Azure Translator Tool API";
			this.RadioButtonServicesTranlationAzure.UseVisualStyleBackColor = true;
			this.RadioButtonServicesTranlationAzure.CheckedChanged += new System.EventHandler(this.RadioButtonServicesTranlationAzure_CheckedChanged);
			// 
			// RadioButtonServicesTranlationGoogle
			// 
			this.RadioButtonServicesTranlationGoogle.AutoSize = true;
			this.RadioButtonServicesTranlationGoogle.Location = new System.Drawing.Point(19, 63);
			this.RadioButtonServicesTranlationGoogle.Name = "RadioButtonServicesTranlationGoogle";
			this.RadioButtonServicesTranlationGoogle.Size = new System.Drawing.Size(196, 21);
			this.RadioButtonServicesTranlationGoogle.TabIndex = 1;
			this.RadioButtonServicesTranlationGoogle.Text = "Google Cloud Translation API";
			this.RadioButtonServicesTranlationGoogle.UseVisualStyleBackColor = true;
			this.RadioButtonServicesTranlationGoogle.CheckedChanged += new System.EventHandler(this.RadioButtonServicesTranlationGoogle_CheckedChanged);
			// 
			// Configuration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(640, 588);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnChangeDirectory);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.PathFilesSharedJs);
			this.Controls.Add(this.btnOpenLocation);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Configuration";
			this.Text = "Tools";
			this.Load += new System.EventHandler(this.Configuration_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOpenLocation;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox PathFilesSharedJs;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnChangeDirectory;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton RadioButtonServicesTranlationAzure;
		private System.Windows.Forms.RadioButton RadioButtonServicesTranlationGoogle;
	}
}