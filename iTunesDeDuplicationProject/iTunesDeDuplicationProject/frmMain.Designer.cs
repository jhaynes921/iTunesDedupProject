namespace iTunesDeDuplicationProject
{
	partial class frmMain
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
			this.tglDirOption = new JCS.ToggleSwitch();
			this.tbDirPath = new System.Windows.Forms.TextBox();
			this.dgvDisplay = new System.Windows.Forms.DataGridView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnTest = new System.Windows.Forms.Button();
			this.tbDisplay = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.toggleSwitch2 = new JCS.ToggleSwitch();
			this.label4 = new System.Windows.Forms.Label();
			this.lbDirOption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// tglDirOption
			// 
			this.tglDirOption.Location = new System.Drawing.Point(90, 83);
			this.tglDirOption.Name = "tglDirOption";
			this.tglDirOption.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tglDirOption.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tglDirOption.Size = new System.Drawing.Size(60, 30);
			this.tglDirOption.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
			this.tglDirOption.TabIndex = 0;
			this.tglDirOption.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.tglDirOption_CheckedChanged);
			// 
			// tbDirPath
			// 
			this.tbDirPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbDirPath.Location = new System.Drawing.Point(90, 17);
			this.tbDirPath.Name = "tbDirPath";
			this.tbDirPath.Size = new System.Drawing.Size(1400, 26);
			this.tbDirPath.TabIndex = 1;
			// 
			// dgvDisplay
			// 
			this.dgvDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisplay.Location = new System.Drawing.Point(12, 124);
			this.dgvDisplay.Name = "dgvDisplay";
			this.dgvDisplay.RowHeadersWidth = 62;
			this.dgvDisplay.RowTemplate.Height = 28;
			this.dgvDisplay.Size = new System.Drawing.Size(1654, 602);
			this.dgvDisplay.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(90, 49);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 28);
			this.comboBox1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Directory:";
			// 
			// btnTest
			// 
			this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTest.Location = new System.Drawing.Point(1516, 12);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(150, 35);
			this.btnTest.TabIndex = 5;
			this.btnTest.Text = "Test";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// tbDisplay
			// 
			this.tbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbDisplay.Location = new System.Drawing.Point(12, 732);
			this.tbDisplay.Multiline = true;
			this.tbDisplay.Name = "tbDisplay";
			this.tbDisplay.ReadOnly = true;
			this.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbDisplay.Size = new System.Drawing.Size(1654, 200);
			this.tbDisplay.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Option";
			// 
			// toggleSwitch2
			// 
			this.toggleSwitch2.Location = new System.Drawing.Point(1590, 83);
			this.toggleSwitch2.Name = "toggleSwitch2";
			this.toggleSwitch2.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toggleSwitch2.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toggleSwitch2.Size = new System.Drawing.Size(60, 30);
			this.toggleSwitch2.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
			this.toggleSwitch2.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1512, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "label3";
			// 
			// lbDirOption
			// 
			this.lbDirOption.AutoSize = true;
			this.lbDirOption.Location = new System.Drawing.Point(166, 89);
			this.lbDirOption.Name = "lbDirOption";
			this.lbDirOption.Size = new System.Drawing.Size(134, 20);
			this.lbDirOption.TabIndex = 7;
			this.lbDirOption.Text = "This directory only";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1678, 944);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbDirOption);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dgvDisplay);
			this.Controls.Add(this.tbDisplay);
			this.Controls.Add(this.toggleSwitch2);
			this.Controls.Add(this.tbDirPath);
			this.Controls.Add(this.tglDirOption);
			this.Name = "frmMain";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private JCS.ToggleSwitch tglDirOption;
		private System.Windows.Forms.TextBox tbDirPath;
		private System.Windows.Forms.DataGridView dgvDisplay;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.TextBox tbDisplay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private JCS.ToggleSwitch toggleSwitch2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbDirOption;
	}
}

