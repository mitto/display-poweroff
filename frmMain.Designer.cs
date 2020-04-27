namespace mitto.DisplayPowerOff
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.cMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cMenuTraySetting = new System.Windows.Forms.ToolStripMenuItem();
			this.cMenuTrayTopMost = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cMenuTrayRunNow = new System.Windows.Forms.ToolStripMenuItem();
			this.cMenuTrayRun = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cMenuTrayAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.cMenuTrayExit = new System.Windows.Forms.ToolStripMenuItem();
			this.noIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.cMenuTray.SuspendLayout();
			this.SuspendLayout();
			// 
			// cMenuTray
			// 
			this.cMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuTraySetting,
            this.cMenuTrayTopMost,
            this.toolStripSeparator1,
            this.cMenuTrayRunNow,
            this.cMenuTrayRun,
            this.toolStripSeparator2,
            this.cMenuTrayAbout,
            this.cMenuTrayExit});
			this.cMenuTray.Name = "cMenuTray";
			this.cMenuTray.Size = new System.Drawing.Size(215, 148);
			this.cMenuTray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noIcon_MouseDown);
			// 
			// cMenuTraySetting
			// 
			this.cMenuTraySetting.Name = "cMenuTraySetting";
			this.cMenuTraySetting.Size = new System.Drawing.Size(214, 22);
			this.cMenuTraySetting.Text = "設定(&S)";
			this.cMenuTraySetting.Click += new System.EventHandler(this.cMenuTraySetting_Click);
			// 
			// cMenuTrayTopMost
			// 
			this.cMenuTrayTopMost.Name = "cMenuTrayTopMost";
			this.cMenuTrayTopMost.Size = new System.Drawing.Size(214, 22);
			this.cMenuTrayTopMost.Text = "ボタンを最前面にする(&T)";
			this.cMenuTrayTopMost.Click += new System.EventHandler(this.cMenuTrayTopMost_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
			// 
			// cMenuTrayRunNow
			// 
			this.cMenuTrayRunNow.Name = "cMenuTrayRunNow";
			this.cMenuTrayRunNow.Size = new System.Drawing.Size(214, 22);
			this.cMenuTrayRunNow.Text = "今すぐ実行";
			this.cMenuTrayRunNow.Click += new System.EventHandler(this.cMenuTrayRunNow_Click);
			// 
			// cMenuTrayRun
			// 
			this.cMenuTrayRun.Name = "cMenuTrayRun";
			this.cMenuTrayRun.Size = new System.Drawing.Size(214, 22);
			this.cMenuTrayRun.Text = "通常実行";
			this.cMenuTrayRun.Click += new System.EventHandler(this.btnPowerOff_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
			// 
			// cMenuTrayAbout
			// 
			this.cMenuTrayAbout.Name = "cMenuTrayAbout";
			this.cMenuTrayAbout.Size = new System.Drawing.Size(214, 22);
			this.cMenuTrayAbout.Text = "About...";
			this.cMenuTrayAbout.Click += new System.EventHandler(this.cMenuTrayAbout_Click);
			// 
			// cMenuTrayExit
			// 
			this.cMenuTrayExit.Name = "cMenuTrayExit";
			this.cMenuTrayExit.Size = new System.Drawing.Size(214, 22);
			this.cMenuTrayExit.Text = "終了(&X)";
			this.cMenuTrayExit.Click += new System.EventHandler(this.cMenuTrayExit_Click);
			// 
			// noIcon
			// 
			this.noIcon.ContextMenuStrip = this.cMenuTray;
			this.noIcon.Visible = true;
			this.noIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noIcon_MouseDown);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Text = "frmMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			this.cMenuTray.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip cMenuTray;
		private System.Windows.Forms.ToolStripMenuItem cMenuTraySetting;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cMenuTrayRunNow;
		private System.Windows.Forms.ToolStripMenuItem cMenuTrayRun;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem cMenuTrayExit;
		private System.Windows.Forms.NotifyIcon noIcon;
		private System.Windows.Forms.ToolStripMenuItem cMenuTrayTopMost;
		private System.Windows.Forms.ToolStripMenuItem cMenuTrayAbout;
	}
}