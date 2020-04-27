using System;
using System.Drawing;
using System.Windows.Forms;


namespace DisplayPowerOff
{
	/// <summary>
	/// メインフォームクラス
	/// </summary>
	public partial class frmMain : Form
	{
		//強制実行されたことを通知するデリゲート
		public delegate void ForceRunAlert();
		public event ForceRunAlert ForceRun;

		private FormWindowState saveWindowState = FormWindowState.Normal;

		private static bool isRunning = false;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public frmMain()
		{
			InitializeComponent();
			
			//
			//	今後設定の読み込みをメソッド化する方向で。
			//

			//フォームの設定
			this.Text = Application.ProductName;

			this.ShowInTaskbar = false;
			this.MinimizeBox = false;
			//this.MaximizeBox = false;

			this.MinimumSize = new Size(150, 100);
			this.Size = Properties.Settings.Default.formSize;

			this.TopMost = Properties.Settings.Default.isTopMost;

			//ボタンの設定
			this.btnPowerOff.Dock = DockStyle.Fill;
			this.btnPowerOff.Text = "Display Off";

			noIcon.Icon = this.Icon;
		}

		/// <summary>
		/// イベントの発行用メソッド
		/// </summary>
		private void OnForceRun()
		{
			if (ForceRun != null)
			{
				ForceRun();
			}
		}

		/// <summary>
		/// PowerOffボタンのイベントハンドラ
		/// </summary>
		private void btnPowerOff_Click(object sender, EventArgs e)
		{
			dlgCountDown CountDown = new dlgCountDown();
			UpdateTrayContextMenu(false);
			isRunning = true;
			CountDown.StartCountDown(this,Properties.Settings.Default.countdownTime);
			
			if (CountDown.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				PowerControl.DisplayPowerTo(PowerControl.DisplayPowerState.Off);
			}
			else
			{
				//MessageBox.Show("キャンセルされました。");
			}
			isRunning = false;
			UpdateTrayContextMenu(true);
		}

		/// <summary>
		/// 終了メニューのイベントハンドラ
		/// </summary>
		private void cMenuTrayExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// タスクトレイアイコンのイベントハンドラ
		/// </summary>
		private void noIcon_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				if (this.WindowState == FormWindowState.Minimized)
				{
					this.WindowState = saveWindowState;
				}
				else if (isRunning)
				{
					return;
				}
				else
				{
					saveWindowState = this.WindowState;
					this.WindowState = FormWindowState.Minimized;
				}
			}

		}

		/// <summary>
		/// 
		/// </summary>
		private void cMenuTraySetting_Click(object sender, EventArgs e)
		{
			dlgSetting setting = new dlgSetting();
			UpdateTrayContextMenu(false);
			setting.ShowDialog(this);
			UpdateTrayContextMenu(true);
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.formSize = this.Size;
			Properties.Settings.Default.Save();
		}

		private void cMenuTrayRunNow_Click(object sender, EventArgs e)
		{
			OnForceRun();
			PowerControl.DisplayPowerTo(PowerControl.DisplayPowerState.Off);	
		}


		/// <summary>
		/// タスクトレイのコンテキストメニュー表示更新メソッド
		/// </summary>
		/// <param name="isEnabled"></param>
		private void UpdateTrayContextMenu(bool isEnabled)
		{
			cMenuTraySetting.Enabled = isEnabled;
			cMenuTrayRun.Enabled = isEnabled;
			//cMenuTrayRunNow.Enabled = isEnabled;
		}
	}
}
