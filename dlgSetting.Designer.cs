namespace mitto.DisplayPowerOff
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
			this.btnReset = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.tabCtrlSetting = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.chkSaveWindowPositon = new System.Windows.Forms.CheckBox();
			this.lblSaveWindowPosition = new System.Windows.Forms.Label();
			this.chkShowInTaskbar = new System.Windows.Forms.CheckBox();
			this.lblShowInTaskBar = new System.Windows.Forms.Label();
			this.chkCountdownTopMost = new System.Windows.Forms.CheckBox();
			this.lblCountDownTopMost = new System.Windows.Forms.Label();
			this.lblTopMost = new System.Windows.Forms.Label();
			this.chkTopMost = new System.Windows.Forms.CheckBox();
			this.tabOperation = new System.Windows.Forms.TabPage();
			this.grpGlobalHotKey = new System.Windows.Forms.GroupBox();
			this.chkGlobalHotKey = new System.Windows.Forms.CheckBox();
			this.lblGlobalHotKeyEnable = new System.Windows.Forms.Label();
			this.lblGlobalHotKey = new System.Windows.Forms.Label();
			this.btnGlobalHotKey = new System.Windows.Forms.Button();
			this.chkForceRun = new System.Windows.Forms.CheckBox();
			this.lblForceRun = new System.Windows.Forms.Label();
			this.updwnCountdownTime = new System.Windows.Forms.NumericUpDown();
			this.lblCountdownTime = new System.Windows.Forms.Label();
			this.tabDisplay = new System.Windows.Forms.TabPage();
			this.chkButtonOnly = new System.Windows.Forms.CheckBox();
			this.lblButtonOnly = new System.Windows.Forms.Label();
			this.btnChangeFont = new System.Windows.Forms.Button();
			this.lblChangeFont = new System.Windows.Forms.Label();
			this.tabCtrlSetting.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.tabOperation.SuspendLayout();
			this.grpGlobalHotKey.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.updwnCountdownTime)).BeginInit();
			this.tabDisplay.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnReset.Location = new System.Drawing.Point(12, 261);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 11;
			this.btnReset.Text = "btnReset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(223, 261);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "btnCancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(142, 261);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "btnOK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// tabCtrlSetting
			// 
			this.tabCtrlSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabCtrlSetting.Controls.Add(this.tabGeneral);
			this.tabCtrlSetting.Controls.Add(this.tabOperation);
			this.tabCtrlSetting.Controls.Add(this.tabDisplay);
			this.tabCtrlSetting.Location = new System.Drawing.Point(12, 12);
			this.tabCtrlSetting.Name = "tabCtrlSetting";
			this.tabCtrlSetting.SelectedIndex = 0;
			this.tabCtrlSetting.Size = new System.Drawing.Size(286, 243);
			this.tabCtrlSetting.TabIndex = 12;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.chkSaveWindowPositon);
			this.tabGeneral.Controls.Add(this.lblSaveWindowPosition);
			this.tabGeneral.Controls.Add(this.chkShowInTaskbar);
			this.tabGeneral.Controls.Add(this.lblShowInTaskBar);
			this.tabGeneral.Controls.Add(this.chkCountdownTopMost);
			this.tabGeneral.Controls.Add(this.lblCountDownTopMost);
			this.tabGeneral.Controls.Add(this.lblTopMost);
			this.tabGeneral.Controls.Add(this.chkTopMost);
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new System.Drawing.Size(278, 217);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "全般";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// chkSaveWindowPositon
			// 
			this.chkSaveWindowPositon.AutoSize = true;
			this.chkSaveWindowPositon.Location = new System.Drawing.Point(240, 120);
			this.chkSaveWindowPositon.Name = "chkSaveWindowPositon";
			this.chkSaveWindowPositon.Size = new System.Drawing.Size(15, 14);
			this.chkSaveWindowPositon.TabIndex = 39;
			this.chkSaveWindowPositon.UseVisualStyleBackColor = true;
			// 
			// lblSaveWindowPosition
			// 
			this.lblSaveWindowPosition.AutoSize = true;
			this.lblSaveWindowPosition.Location = new System.Drawing.Point(10, 120);
			this.lblSaveWindowPosition.Name = "lblSaveWindowPosition";
			this.lblSaveWindowPosition.Size = new System.Drawing.Size(121, 12);
			this.lblSaveWindowPosition.TabIndex = 38;
			this.lblSaveWindowPosition.Text = "lblSaveWindowPosition";
			// 
			// chkShowInTaskbar
			// 
			this.chkShowInTaskbar.AutoSize = true;
			this.chkShowInTaskbar.Location = new System.Drawing.Point(240, 85);
			this.chkShowInTaskbar.Name = "chkShowInTaskbar";
			this.chkShowInTaskbar.Size = new System.Drawing.Size(15, 14);
			this.chkShowInTaskbar.TabIndex = 37;
			this.chkShowInTaskbar.UseVisualStyleBackColor = true;
			// 
			// lblShowInTaskBar
			// 
			this.lblShowInTaskBar.AutoSize = true;
			this.lblShowInTaskBar.Location = new System.Drawing.Point(10, 85);
			this.lblShowInTaskBar.Name = "lblShowInTaskBar";
			this.lblShowInTaskBar.Size = new System.Drawing.Size(96, 12);
			this.lblShowInTaskBar.TabIndex = 36;
			this.lblShowInTaskBar.Text = "lblShowInTaskBar";
			// 
			// chkCountdownTopMost
			// 
			this.chkCountdownTopMost.AutoSize = true;
			this.chkCountdownTopMost.Location = new System.Drawing.Point(240, 50);
			this.chkCountdownTopMost.Name = "chkCountdownTopMost";
			this.chkCountdownTopMost.Size = new System.Drawing.Size(15, 14);
			this.chkCountdownTopMost.TabIndex = 31;
			this.chkCountdownTopMost.UseVisualStyleBackColor = true;
			// 
			// lblCountDownTopMost
			// 
			this.lblCountDownTopMost.AutoSize = true;
			this.lblCountDownTopMost.Location = new System.Drawing.Point(10, 50);
			this.lblCountDownTopMost.Name = "lblCountDownTopMost";
			this.lblCountDownTopMost.Size = new System.Drawing.Size(119, 12);
			this.lblCountDownTopMost.TabIndex = 30;
			this.lblCountDownTopMost.Text = "lblCountDownTopMost";
			// 
			// lblTopMost
			// 
			this.lblTopMost.AutoSize = true;
			this.lblTopMost.Location = new System.Drawing.Point(10, 15);
			this.lblTopMost.Name = "lblTopMost";
			this.lblTopMost.Size = new System.Drawing.Size(61, 12);
			this.lblTopMost.TabIndex = 27;
			this.lblTopMost.Text = "lblTopMost";
			// 
			// chkTopMost
			// 
			this.chkTopMost.AutoSize = true;
			this.chkTopMost.Location = new System.Drawing.Point(240, 15);
			this.chkTopMost.Name = "chkTopMost";
			this.chkTopMost.Size = new System.Drawing.Size(15, 14);
			this.chkTopMost.TabIndex = 26;
			this.chkTopMost.UseVisualStyleBackColor = true;
			// 
			// tabOperation
			// 
			this.tabOperation.Controls.Add(this.grpGlobalHotKey);
			this.tabOperation.Controls.Add(this.chkForceRun);
			this.tabOperation.Controls.Add(this.lblForceRun);
			this.tabOperation.Controls.Add(this.updwnCountdownTime);
			this.tabOperation.Controls.Add(this.lblCountdownTime);
			this.tabOperation.Location = new System.Drawing.Point(4, 22);
			this.tabOperation.Name = "tabOperation";
			this.tabOperation.Padding = new System.Windows.Forms.Padding(3);
			this.tabOperation.Size = new System.Drawing.Size(278, 217);
			this.tabOperation.TabIndex = 2;
			this.tabOperation.Text = "動作";
			this.tabOperation.UseVisualStyleBackColor = true;
			// 
			// grpGlobalHotKey
			// 
			this.grpGlobalHotKey.Controls.Add(this.chkGlobalHotKey);
			this.grpGlobalHotKey.Controls.Add(this.lblGlobalHotKeyEnable);
			this.grpGlobalHotKey.Controls.Add(this.lblGlobalHotKey);
			this.grpGlobalHotKey.Controls.Add(this.btnGlobalHotKey);
			this.grpGlobalHotKey.Location = new System.Drawing.Point(10, 117);
			this.grpGlobalHotKey.Name = "grpGlobalHotKey";
			this.grpGlobalHotKey.Size = new System.Drawing.Size(262, 92);
			this.grpGlobalHotKey.TabIndex = 38;
			this.grpGlobalHotKey.TabStop = false;
			this.grpGlobalHotKey.Text = "ホットキーの設定";
			// 
			// chkGlobalHotKey
			// 
			this.chkGlobalHotKey.AutoSize = true;
			this.chkGlobalHotKey.Location = new System.Drawing.Point(216, 25);
			this.chkGlobalHotKey.Name = "chkGlobalHotKey";
			this.chkGlobalHotKey.Size = new System.Drawing.Size(15, 14);
			this.chkGlobalHotKey.TabIndex = 39;
			this.chkGlobalHotKey.UseVisualStyleBackColor = true;
			this.chkGlobalHotKey.CheckedChanged += new System.EventHandler(this.chkGlobalHotKey_CheckedChanged);
			// 
			// lblGlobalHotKeyEnable
			// 
			this.lblGlobalHotKeyEnable.AutoSize = true;
			this.lblGlobalHotKeyEnable.Location = new System.Drawing.Point(6, 25);
			this.lblGlobalHotKeyEnable.Name = "lblGlobalHotKeyEnable";
			this.lblGlobalHotKeyEnable.Size = new System.Drawing.Size(120, 12);
			this.lblGlobalHotKeyEnable.TabIndex = 38;
			this.lblGlobalHotKeyEnable.Text = "lblGlobalHotKeyEnable";
			// 
			// lblGlobalHotKey
			// 
			this.lblGlobalHotKey.AutoSize = true;
			this.lblGlobalHotKey.Location = new System.Drawing.Point(6, 60);
			this.lblGlobalHotKey.Name = "lblGlobalHotKey";
			this.lblGlobalHotKey.Size = new System.Drawing.Size(86, 12);
			this.lblGlobalHotKey.TabIndex = 36;
			this.lblGlobalHotKey.Text = "lblGlobalHotKey";
			// 
			// btnGlobalHotKey
			// 
			this.btnGlobalHotKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGlobalHotKey.Location = new System.Drawing.Point(195, 55);
			this.btnGlobalHotKey.Name = "btnGlobalHotKey";
			this.btnGlobalHotKey.Size = new System.Drawing.Size(61, 23);
			this.btnGlobalHotKey.TabIndex = 37;
			this.btnGlobalHotKey.Text = "btnGlobalHotKey";
			this.btnGlobalHotKey.UseVisualStyleBackColor = true;
			this.btnGlobalHotKey.Click += new System.EventHandler(this.btnGlobalHotKey_Click);
			// 
			// chkForceRun
			// 
			this.chkForceRun.AutoSize = true;
			this.chkForceRun.Location = new System.Drawing.Point(226, 50);
			this.chkForceRun.Name = "chkForceRun";
			this.chkForceRun.Size = new System.Drawing.Size(15, 14);
			this.chkForceRun.TabIndex = 35;
			this.chkForceRun.UseVisualStyleBackColor = true;
			// 
			// lblForceRun
			// 
			this.lblForceRun.AutoSize = true;
			this.lblForceRun.Location = new System.Drawing.Point(10, 50);
			this.lblForceRun.Name = "lblForceRun";
			this.lblForceRun.Size = new System.Drawing.Size(66, 12);
			this.lblForceRun.TabIndex = 34;
			this.lblForceRun.Text = "lblForceRun";
			// 
			// updwnCountdownTime
			// 
			this.updwnCountdownTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.updwnCountdownTime.Location = new System.Drawing.Point(207, 13);
			this.updwnCountdownTime.Name = "updwnCountdownTime";
			this.updwnCountdownTime.Size = new System.Drawing.Size(59, 19);
			this.updwnCountdownTime.TabIndex = 27;
			// 
			// lblCountdownTime
			// 
			this.lblCountdownTime.AutoSize = true;
			this.lblCountdownTime.Location = new System.Drawing.Point(10, 15);
			this.lblCountdownTime.Name = "lblCountdownTime";
			this.lblCountdownTime.Size = new System.Drawing.Size(98, 12);
			this.lblCountdownTime.TabIndex = 26;
			this.lblCountdownTime.Text = "lblCountdownTime";
			// 
			// tabDisplay
			// 
			this.tabDisplay.Controls.Add(this.chkButtonOnly);
			this.tabDisplay.Controls.Add(this.lblButtonOnly);
			this.tabDisplay.Controls.Add(this.btnChangeFont);
			this.tabDisplay.Controls.Add(this.lblChangeFont);
			this.tabDisplay.Location = new System.Drawing.Point(4, 22);
			this.tabDisplay.Name = "tabDisplay";
			this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
			this.tabDisplay.Size = new System.Drawing.Size(278, 217);
			this.tabDisplay.TabIndex = 1;
			this.tabDisplay.Text = "表示";
			this.tabDisplay.UseVisualStyleBackColor = true;
			// 
			// chkButtonOnly
			// 
			this.chkButtonOnly.AutoSize = true;
			this.chkButtonOnly.Location = new System.Drawing.Point(240, 15);
			this.chkButtonOnly.Name = "chkButtonOnly";
			this.chkButtonOnly.Size = new System.Drawing.Size(15, 14);
			this.chkButtonOnly.TabIndex = 39;
			this.chkButtonOnly.UseVisualStyleBackColor = true;
			// 
			// lblButtonOnly
			// 
			this.lblButtonOnly.AutoSize = true;
			this.lblButtonOnly.Location = new System.Drawing.Point(10, 15);
			this.lblButtonOnly.Name = "lblButtonOnly";
			this.lblButtonOnly.Size = new System.Drawing.Size(74, 12);
			this.lblButtonOnly.TabIndex = 38;
			this.lblButtonOnly.Text = "lblButtonOnly";
			// 
			// btnChangeFont
			// 
			this.btnChangeFont.Location = new System.Drawing.Point(220, 45);
			this.btnChangeFont.Name = "btnChangeFont";
			this.btnChangeFont.Size = new System.Drawing.Size(52, 23);
			this.btnChangeFont.TabIndex = 37;
			this.btnChangeFont.Text = "btnChangeFont";
			this.btnChangeFont.UseVisualStyleBackColor = true;
			// 
			// lblChangeFont
			// 
			this.lblChangeFont.AutoSize = true;
			this.lblChangeFont.Location = new System.Drawing.Point(10, 50);
			this.lblChangeFont.Name = "lblChangeFont";
			this.lblChangeFont.Size = new System.Drawing.Size(78, 12);
			this.lblChangeFont.TabIndex = 36;
			this.lblChangeFont.Text = "lblChangeFont";
			// 
			// dlgSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 296);
			this.Controls.Add(this.tabCtrlSetting);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Name = "dlgSetting";
			this.Text = "dlgSetting";
			this.Load += new System.EventHandler(this.dlgSetting_Load);
			this.tabCtrlSetting.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tabGeneral.PerformLayout();
			this.tabOperation.ResumeLayout(false);
			this.tabOperation.PerformLayout();
			this.grpGlobalHotKey.ResumeLayout(false);
			this.grpGlobalHotKey.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.updwnCountdownTime)).EndInit();
			this.tabDisplay.ResumeLayout(false);
			this.tabDisplay.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TabControl tabCtrlSetting;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.CheckBox chkShowInTaskbar;
		private System.Windows.Forms.Label lblShowInTaskBar;
		private System.Windows.Forms.CheckBox chkCountdownTopMost;
		private System.Windows.Forms.Label lblCountDownTopMost;
		private System.Windows.Forms.Label lblTopMost;
		private System.Windows.Forms.CheckBox chkTopMost;
		private System.Windows.Forms.TabPage tabDisplay;
		private System.Windows.Forms.Button btnChangeFont;
		private System.Windows.Forms.Label lblChangeFont;
		private System.Windows.Forms.TabPage tabOperation;
		private System.Windows.Forms.NumericUpDown updwnCountdownTime;
		private System.Windows.Forms.Label lblCountdownTime;
		private System.Windows.Forms.CheckBox chkForceRun;
		private System.Windows.Forms.Label lblForceRun;
		private System.Windows.Forms.CheckBox chkButtonOnly;
		private System.Windows.Forms.Label lblButtonOnly;
		private System.Windows.Forms.CheckBox chkSaveWindowPositon;
		private System.Windows.Forms.Label lblSaveWindowPosition;
		private System.Windows.Forms.Button btnGlobalHotKey;
		private System.Windows.Forms.Label lblGlobalHotKey;
		private System.Windows.Forms.GroupBox grpGlobalHotKey;
		private System.Windows.Forms.CheckBox chkGlobalHotKey;
		private System.Windows.Forms.Label lblGlobalHotKeyEnable;

	}
}