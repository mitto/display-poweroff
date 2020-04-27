using System;
using System.Windows.Forms;

namespace DisplayPowerOff
{
	/// <summary>
	/// 設定ダイアログクラス
	/// </summary>
	public partial class dlgSetting : Form
	{
		public dlgSetting()
		{
			InitializeComponent();

			this.Text = "設定";

			this.ControlBox = false;
			this.MinimizeBox = false;
			this.MaximizeBox = false;

			this.ShowInTaskbar = false;

			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

			//ボタンの設定
			btnOK.Text = "OK";

			btnCancel.Text = "キャンセル";

			btnReset.Text = "リセット";

			//
			lblCountdownTime.Text = "ディスプレイの電源を落とすまでの時間（秒）";
			lblTopMost.Text = "常に手前へ表示";

			updwnCountdownTime.TextAlign = HorizontalAlignment.Center;
			updwnCountdownTime.Minimum = 1;
			updwnCountdownTime.Maximum = 600;

		}

		private void dlgSetting_Load(object sender, EventArgs e)
		{
			//設定の読み込み
			LoadConfig();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SaveConfig();
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SaveConfig()
		{
			Properties.Settings.Default.countdownTime = (int)updwnCountdownTime.Value;
			Properties.Settings.Default.isTopMost = chkTopMost.Checked;
			Properties.Settings.Default.Save();
		}

		private void LoadConfig()
		{
			updwnCountdownTime.Value = Properties.Settings.Default.countdownTime;
			chkTopMost.Checked = Properties.Settings.Default.isTopMost;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			DialogResult isOK;

			isOK = MessageBox.Show("初期化すると元に戻せません。\nよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

			if (isOK == System.Windows.Forms.DialogResult.OK)
			{
				Properties.Settings.Default.Reset();
				LoadConfig();
			}
		}

		private void chkTopMost_CheckedChanged(object sender, EventArgs e)
		{
			this.Owner.TopMost = chkTopMost.Checked;
		}
	}
}
