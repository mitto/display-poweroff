namespace mitto.DisplayPowerOff
{
	partial class dlgHotKey
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
			this.chkAlt = new System.Windows.Forms.CheckBox();
			this.chkCtrl = new System.Windows.Forms.CheckBox();
			this.chkShift = new System.Windows.Forms.CheckBox();
			this.chkWin = new System.Windows.Forms.CheckBox();
			this.cmbKeys = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.grpHotKey = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblCaution = new System.Windows.Forms.Label();
			this.grpHotKey.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkAlt
			// 
			this.chkAlt.AutoSize = true;
			this.chkAlt.Location = new System.Drawing.Point(16, 29);
			this.chkAlt.Name = "chkAlt";
			this.chkAlt.Size = new System.Drawing.Size(39, 16);
			this.chkAlt.TabIndex = 0;
			this.chkAlt.Text = "Alt";
			this.chkAlt.UseVisualStyleBackColor = true;
			// 
			// chkCtrl
			// 
			this.chkCtrl.AutoSize = true;
			this.chkCtrl.Location = new System.Drawing.Point(61, 29);
			this.chkCtrl.Name = "chkCtrl";
			this.chkCtrl.Size = new System.Drawing.Size(43, 16);
			this.chkCtrl.TabIndex = 1;
			this.chkCtrl.Text = "Ctrl";
			this.chkCtrl.UseVisualStyleBackColor = true;
			// 
			// chkShift
			// 
			this.chkShift.AutoSize = true;
			this.chkShift.Location = new System.Drawing.Point(110, 29);
			this.chkShift.Name = "chkShift";
			this.chkShift.Size = new System.Drawing.Size(48, 16);
			this.chkShift.TabIndex = 2;
			this.chkShift.Text = "Shift";
			this.chkShift.UseVisualStyleBackColor = true;
			// 
			// chkWin
			// 
			this.chkWin.AutoSize = true;
			this.chkWin.Location = new System.Drawing.Point(164, 29);
			this.chkWin.Name = "chkWin";
			this.chkWin.Size = new System.Drawing.Size(42, 16);
			this.chkWin.TabIndex = 3;
			this.chkWin.Text = "Win";
			this.chkWin.UseVisualStyleBackColor = true;
			// 
			// cmbKeys
			// 
			this.cmbKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKeys.FormattingEnabled = true;
			this.cmbKeys.Location = new System.Drawing.Point(16, 51);
			this.cmbKeys.Name = "cmbKeys";
			this.cmbKeys.Size = new System.Drawing.Size(190, 20);
			this.cmbKeys.TabIndex = 4;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(212, 25);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// grpHotKey
			// 
			this.grpHotKey.Controls.Add(this.btnCancel);
			this.grpHotKey.Controls.Add(this.chkAlt);
			this.grpHotKey.Controls.Add(this.chkCtrl);
			this.grpHotKey.Controls.Add(this.btnOK);
			this.grpHotKey.Controls.Add(this.cmbKeys);
			this.grpHotKey.Controls.Add(this.chkShift);
			this.grpHotKey.Controls.Add(this.chkWin);
			this.grpHotKey.Location = new System.Drawing.Point(11, 83);
			this.grpHotKey.Name = "grpHotKey";
			this.grpHotKey.Size = new System.Drawing.Size(298, 84);
			this.grpHotKey.TabIndex = 6;
			this.grpHotKey.TabStop = false;
			this.grpHotKey.Text = "ホットキーの組み合わせ";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(212, 49);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "キャンセル";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblCaution
			// 
			this.lblCaution.AutoSize = true;
			this.lblCaution.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblCaution.ForeColor = System.Drawing.Color.Red;
			this.lblCaution.Location = new System.Drawing.Point(12, 9);
			this.lblCaution.Name = "lblCaution";
			this.lblCaution.Size = new System.Drawing.Size(300, 65);
			this.lblCaution.TabIndex = 7;
			this.lblCaution.Text = "注意！\r\nホットキーの組み合わせ次第では、\r\n他のアプリケーションショートカットが使えなくなります。\r\nまた、コンボボックス内の\r\n「D数字」というのは数字キーの" +
				"ことです。";
			// 
			// dlgHotKey
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 180);
			this.Controls.Add(this.lblCaution);
			this.Controls.Add(this.grpHotKey);
			this.Name = "dlgHotKey";
			this.Text = "dlgHotKey";
			this.Load += new System.EventHandler(this.dlgHotKey_Load);
			this.grpHotKey.ResumeLayout(false);
			this.grpHotKey.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkAlt;
		private System.Windows.Forms.CheckBox chkCtrl;
		private System.Windows.Forms.CheckBox chkShift;
		private System.Windows.Forms.CheckBox chkWin;
		private System.Windows.Forms.ComboBox cmbKeys;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.GroupBox grpHotKey;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblCaution;
	}
}