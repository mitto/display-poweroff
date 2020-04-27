using System;
using System.Windows.Forms;

namespace DisplayPowerOff
{
	public partial class dlgCountDown : Form
	{
		private string labelMessage = "ディスプレイの電源が切れるまで ： {0}秒";

		public dlgCountDown()
		{
			InitializeComponent();

			//フォームの設定
			this.ControlBox = false;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;

			this.Text = " ";

			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

			//ボタンの設定
			btnCancel.Text = "キャンセル(&C)";

			//プログレスバーの設定
			pbarCountDown.Step = -1;
		}

		private void timerMain_Tick(object sender, EventArgs e)
		{
			pbarCountDown.PerformStep();
			lblCountdown.Text = String.Format(labelMessage, pbarCountDown.Value);

			if (pbarCountDown.Value == 0)
			{
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
		}

		public void StartCountDown(Form f,int countdownSecond)
		{
			if (countdownSecond <= 0)
			{
				throw new ArgumentException("カウントダウンの時間が正確ではありません。");
			}

			pbarCountDown.Maximum = countdownSecond;
			pbarCountDown.Value = countdownSecond;

			timerMain.Enabled = true;
			timerMain.Interval = 1000;

			lblCountdown.Text = String.Format(labelMessage, countdownSecond);

			//イベントハンドラーの登録
			frmMain parentForm = (frmMain)f;
			parentForm.ForceRun += this.AlertForceRun;

			this.ShowDialog(f);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void AlertForceRun()
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}
	}
}
