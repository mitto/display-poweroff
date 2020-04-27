namespace DisplayPowerOff
{
	partial class dlgSetting
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
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblCountdownTime = new System.Windows.Forms.Label();
			this.updwnCountdownTime = new System.Windows.Forms.NumericUpDown();
			this.btnReset = new System.Windows.Forms.Button();
			this.chkTopMost = new System.Windows.Forms.CheckBox();
			this.lblTopMost = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.updwnCountdownTime)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(142, 74);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "button1";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(223, 74);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "button2";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblCountdownTime
			// 
			this.lblCountdownTime.AutoSize = true;
			this.lblCountdownTime.Location = new System.Drawing.Point(12, 14);
			this.lblCountdownTime.Name = "lblCountdownTime";
			this.lblCountdownTime.Size = new System.Drawing.Size(35, 12);
			this.lblCountdownTime.TabIndex = 2;
			this.lblCountdownTime.Text = "label1";
			// 
			// updwnCountdownTime
			// 
			this.updwnCountdownTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.updwnCountdownTime.Location = new System.Drawing.Point(223, 12);
			this.updwnCountdownTime.Name = "updwnCountdownTime";
			this.updwnCountdownTime.Size = new System.Drawing.Size(69, 19);
			this.updwnCountdownTime.TabIndex = 3;
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnReset.Location = new System.Drawing.Point(12, 74);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "button3";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// chkTopMost
			// 
			this.chkTopMost.AutoSize = true;
			this.chkTopMost.Location = new System.Drawing.Point(250, 41);
			this.chkTopMost.Name = "chkTopMost";
			this.chkTopMost.Size = new System.Drawing.Size(15, 14);
			this.chkTopMost.TabIndex = 5;
			this.chkTopMost.UseVisualStyleBackColor = true;
			this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
			// 
			// lblTopMost
			// 
			this.lblTopMost.AutoSize = true;
			this.lblTopMost.Location = new System.Drawing.Point(12, 41);
			this.lblTopMost.Name = "lblTopMost";
			this.lblTopMost.Size = new System.Drawing.Size(35, 12);
			this.lblTopMost.TabIndex = 6;
			this.lblTopMost.Text = "label1";
			// 
			// dlgSetting
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(310, 109);
			this.Controls.Add(this.lblTopMost);
			this.Controls.Add(this.chkTopMost);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.updwnCountdownTime);
			this.Controls.Add(this.lblCountdownTime);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Name = "dlgSetting";
			this.Text = "dlgSetting";
			this.Load += new System.EventHandler(this.dlgSetting_Load);
			((System.ComponentModel.ISupportInitialize)(this.updwnCountdownTime)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblCountdownTime;
		private System.Windows.Forms.NumericUpDown updwnCountdownTime;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.CheckBox chkTopMost;
		private System.Windows.Forms.Label lblTopMost;
	}
}