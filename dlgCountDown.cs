using System;
using System.Drawing;
using System.Windows.Forms;

namespace mitto.DisplayPowerOff
{
	public partial class dlgCountDown : Form
	{
		private static string labelMessage = "ディスプレイの電源が切れるまで ： {0}秒";

		public dlgCountDown()
		{
			InitializeComponent();

			//フォームの設定
			this.ControlBox = false;
			//this.ShowIcon = false;
			this.Icon = Properties.Resources.cinema_display;
			//this.ShowInTaskbar = false;
			this.Text = "";
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.CancelButton = btnCancel;
			this.TopMost = Properties.Main.Default.isCountdownTopMost;

			//ボタンの設定
			btnCancel.Text = "キャンセル(&C)";

			//設定読み込み
			int second = Properties.Main.Default.countdownTime;


			//プログレスバーの設定
			//pbarCountDown.Step = 1;
			pbarCountDown.Step = -1;
			pbarCountDown.Maximum = second;
			pbarCountDown.Minimum = 0;
			pbarCountDown.Value = second;
			pbarCountDown.Style = ProgressBarStyle.Blocks;
	

			UpdateCountDownLabel();


			//タイマーの設定
			timerMain.Interval = 1000;
			timerMain.Enabled = true;
		}

		private void dlgCountDown_Load(object sender, EventArgs e)
		{
			//イベントハンドラの登録
			frmMain f = this.Owner as frmMain;
			if (f != null)
			{
				f.ForceRun += AlertForceRun;
			}

			f.Visible = false;

			//スクリーンサイズの取得
			int width = Screen.PrimaryScreen.Bounds.Width;
			int height = Screen.PrimaryScreen.Bounds.Height;

			width = width / 2 - this.Width / 2;
			height = height / 2 - this.Height;

			this.Location = new Point(width, height);

		}

		//タイマーのイベントハンドラ
		private void timerMain_Tick(object sender, EventArgs e)
		{

			//time = DateTime.Now;

			pbarCountDown.PerformStep();
			//pbarCountDown.Update();
			//pbarCountDown.Refresh();

			UpdateCountDownLabel();

			if (pbarCountDown.Value == 0)
			{
				
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
		}


		//キャンセルボタンのイベントハンドラ
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		//AlertForceRunのイベントハンドラ
		private void AlertForceRun()
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void dlgCountDown_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Visible = true;
		}

		private void UpdateCountDownLabel()
		{
			lblCountdown.Text = String.Format(labelMessage,pbarCountDown.Value);
		}

	}
}
