namespace DisplayPowerOff
{
	partial class frmMain
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnPowerOff = new System.Windows.Forms.Button();
			this.cMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cMenuTraySetting = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cMenuTrayRunNow = new System.Windows.Forms.ToolStripMenuItem();
			this.cMenuTrayRun = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cMenuTrayExit = new System.Windows.Forms.ToolStripMenuItem();
			this.noIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.cMenuTray.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnPowerOff
			// 
			this.btnPowerOff.Location = new System.Drawing.Point(37, 79);
			this.btnPowerOff.Name = "btnPowerOff";
			this.btnPowerOff.Size = new System.Drawing.Size(75, 23);
			this.btnPowerOff.TabIndex = 0;
			this.btnPowerOff.Text = "button1";
			this.btnPowerOff.UseVisualStyleBackColor = true;
			this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
			// 
			// cMenuTray
			// 
			this.cMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuTraySetting,
            this.toolStripSeparator1,
            this.cMenuTrayRunNow,
            this.cMenuTrayRun,
            this.toolStripSeparator2,
            this.cMenuTrayExit});
			this.cMenuTray.Name = "cMenuTray";
			this.cMenuTray.Size = new System.Drawing.Size(153, 126);
			this.cMenuTray.Text = "hoge";
			// 
			// cMenuTraySetting
			// 
			this.cMenuTraySetting.Name = "cMenuTraySetting";
			this.cMenuTraySetting.Size = new System.Drawing.Size(152, 22);
			this.cMenuTraySetting.Text = "設定(&S)";
			this.cMenuTraySetting.Click += new System.EventHandler(this.cMenuTraySetting_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// cMenuTrayRunNow
			// 
			this.cMenuTrayRunNow.Name = "cMenuTrayRunNow";
			this.cMenuTrayRunNow.Size = new System.Drawing.Size(152, 22);
			this.cMenuTrayRunNow.Text = "今すぐ実行";
			this.cMenuTrayRunNow.Click += new System.EventHandler(this.cMenuTrayRunNow_Click);
			// 
			// cMenuTrayRun
			// 
			this.cMenuTrayRun.Name = "cMenuTrayRun";
			this.cMenuTrayRun.Size = new System.Drawing.Size(152, 22);
			this.cMenuTrayRun.Text = "通常実行";
			this.cMenuTrayRun.Click += new System.EventHandler(this.btnPowerOff_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
			// 
			// cMenuTrayExit
			// 
			this.cMenuTrayExit.Name = "cMenuTrayExit";
			this.cMenuTrayExit.Size = new System.Drawing.Size(152, 22);
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
			this.Controls.Add(this.btnPowerOff);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.cMenuTray.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPowerOff;
		private System.Windows.Forms.ContextMenuStrip cMenuTray;
		private System.Windows.Forms.ToolStripMenuItem cMenuTraySetting;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cMenuTrayExit;
		private System.Windows.Forms.NotifyIcon noIcon;
		private System.Windows.Forms.ToolStripMenuItem cMenuTrayRunNow;
		private System.Windows.Forms.ToolStripMenuItem cMenuTrayRun;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}

