using System;
using System.Drawing;
using System.Windows.Forms;

namespace mitto.DisplayPowerOff
{
	/// <summary>
	/// 設定ダイアログクラス
	/// </summary>
	public partial class dlgSetting : Form
	{
		private Font font;

		public dlgSetting()
		{
			InitializeComponent();


			//フォームの設定
			this.Text = "設定";

			this.Icon = Properties.Resources.cinema_display;

			this.ControlBox = false;
			this.MinimizeBox = false;
			this.MaximizeBox = false;
			this.ShowInTaskbar = false;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

			this.AcceptButton = btnOK;
			this.CancelButton = btnCancel;

			//ボタンの設定
			btnOK.Text = "OK";
			btnCancel.Text = "キャンセル";
			btnReset.Text = "リセット";


			//ラベルの設定
			lblCountdownTime.Text = "カウントダウンの時間（秒）";
			lblTopMost.Text = "メインボタンを最前面に表示";
			lblButtonOnly.Text = "ボタンだけ表示";
			lblCountDownTopMost.Text = "カウントダウン画面を最前面に表示";
			lblForceRun.Text = "メインボタンの動作を今すぐ実行にする";
			lblShowInTaskBar.Text = "タスクバーにアイコンを表示する";
			lblChangeFont.Text = "ボタンのフォントを変更する";
			lblSaveWindowPosition.Text = "終了時のウインドウ位置を記憶する";
			lblGlobalHotKey.Text = "詳細設定";
			lblGlobalHotKeyEnable.Text = "ホットキーの有効化";

			btnChangeFont.Text = "変更";
			btnGlobalHotKey.Text = "設定";

			updwnCountdownTime.TextAlign = HorizontalAlignment.Center;
			updwnCountdownTime.Minimum = 1;
			updwnCountdownTime.Maximum = 3600;

			//イベントハンドラの登録
			btnChangeFont.Click += new EventHandler(btnChangeFont_Click);

		}

		private void dlgSetting_Load(object sender, EventArgs e)
		{
			//設定の読み込み
			LoadConfig();

			//ウインドウ位置の指定
			Point pt = new Point();
			Size sz　= new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

			pt.X = (sz.Width / 2) - (this.Size.Width / 2);
			pt.Y = (sz.Height / 2) - (this.Size.Height / 2);
			
			this.Location = pt;

		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SaveConfig();
			this.Close();
		}

		private void SaveConfig()
		{
			Properties.Main.Default.countdownTime = (int)updwnCountdownTime.Value;
			this.Owner.TopMost = chkTopMost.Checked;
			Properties.Main.Default.isTopMost = chkTopMost.Checked;
			Properties.Main.Default.isButtonOnly = chkButtonOnly.Checked;
			Properties.Main.Default.isCountdownTopMost = chkCountdownTopMost.Checked;
			Properties.Main.Default.isForceRun = chkForceRun.Checked;
			Properties.Main.Default.buttonFont = font;
			Properties.Main.Default.isShowInTaskbar = chkShowInTaskbar.Checked;
			Properties.Main.Default.isSaveWindowPosition = chkSaveWindowPositon.Checked;
			Properties.Main.Default.isGlobalHotKeyEnabled = chkGlobalHotKey.Checked;
			Properties.Main.Default.Save();
		}

		private void LoadConfig()
		{
			updwnCountdownTime.Value = Properties.Main.Default.countdownTime;
			chkTopMost.Checked = Properties.Main.Default.isTopMost;
			chkButtonOnly.Checked = Properties.Main.Default.isButtonOnly;
			chkCountdownTopMost.Checked = Properties.Main.Default.isCountdownTopMost;
			chkForceRun.Checked = Properties.Main.Default.isForceRun;
			font = Properties.Main.Default.buttonFont;
			chkShowInTaskbar.Checked = Properties.Main.Default.isShowInTaskbar;
			chkSaveWindowPositon.Checked = Properties.Main.Default.isSaveWindowPosition;
			chkGlobalHotKey.Checked = Properties.Main.Default.isGlobalHotKeyEnabled;
			lblGlobalHotKey.Enabled = Properties.Main.Default.isGlobalHotKeyEnabled;
			btnGlobalHotKey.Enabled = Properties.Main.Default.isGlobalHotKeyEnabled;
			//this.ShowInTaskbar = Properties.Main.Default.isShowInTaskbar;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			DialogResult isOK;

			isOK = MessageBox.Show("初期化すると元に戻せません。\nよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

			if (isOK == System.Windows.Forms.DialogResult.OK)
			{
				//ボタンサイズまでリセットされないようにした
				System.Drawing.Size size = Properties.Main.Default.formSize;
				Properties.Main.Default.Reset();
				Properties.Main.Default.formSize = size;
				LoadConfig();
			}
		}

		private void chkTopMost_CheckedChanged(object sender, EventArgs e)
		{
			this.Owner.TopMost = chkTopMost.Checked;
		}

		private void btnChangeFont_Click(object sender, EventArgs e)
		{
			FontDialog fdlg = new FontDialog();

			fdlg.Font = font;


			if (fdlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				font = fdlg.Font;
			}


		}

		private void btnGlobalHotKey_Click(object sender, EventArgs e)
		{
			using (dlgHotKeySetting dlghks = new dlgHotKeySetting())
			{
				dlghks.ShowDialog(this);
			}
		}

		private void chkGlobalHotKey_CheckedChanged(object sender, EventArgs e)
		{
			btnGlobalHotKey.Enabled = chkGlobalHotKey.Checked;
			lblGlobalHotKey.Enabled = chkGlobalHotKey.Checked;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
