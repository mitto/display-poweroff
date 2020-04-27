using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using mitto.Util;

namespace mitto.DisplayPowerOff
{
	public partial class dlgHotKeySetting : Form
	{
		public dlgHotKeySetting()
		{
			InitializeComponent();

			frmCreate();

			LoadConfig();
			LoadHotKey();
		}

		private void frmCreate()
		{
			//フォームの設定
			this.Text = "ホットキー設定";
			this.ControlBox = false;
			this.Icon = Properties.Resources.cinema_display;
			this.ShowInTaskbar = false;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximumSize = this.Size;

			this.AcceptButton = btnOK;
			this.CancelButton = btnCancel;

			//this.TopMost = true;
		
			//グループボックスの設定
			grpRunHotKey.Text = "「通常実行」のホットキー設定";
			grpRunNowHotKey.Text = "「今すぐ実行」ホットキー設定";

			//ラベルの設定
			lblRunEnable.Text = "有効化";
			lblRunSetting.Text = "組み合わせ：";

			lblRunNowEnable.Text = "有効化";
			lblRunNowSetting.Text = "組み合わせ：";

			//ボタンの準備
			btnRunSetting.Text = "組み合わせの作成";
			btnRunNowSetting.Text = "組み合わせの作成";

			//テキストボックスの設定
			txtRunSetting.ReadOnly = true;
			txtRunSetting.BackColor = Color.White;
			txtRunSetting.ShortcutsEnabled = false;

			txtRunNowSetting.ReadOnly = true;
			txtRunNowSetting.BackColor = Color.White;
			txtRunNowSetting.ShortcutsEnabled = false;

			//イベントハンドラの登録
			btnRunNowSetting.Click += new EventHandler(btnHotKeySetting_Click);
			btnRunSetting.Click += new EventHandler(btnHotKeySetting_Click);

			chkRunEnable.CheckedChanged += new EventHandler(chkRunEnable_CheckedChanged);
			chkRunNowEnable.CheckedChanged += new EventHandler(chkRunNowEnable_CheckedChanged);

		}

		private void LoadConfig()
		{
			chkRunEnable.Checked = Properties.HotKey.Default.isRunHotKey;
			//grpRunHotKey.Enabled = Properties.HotKey.Default.isRunGlobalHotKey;
			chkRunNowEnable.Checked = Properties.HotKey.Default.isRunNowHotKey;
			//grpRunNowHotKey.Enabled = Properties.HotKey.Default.isRunNowGlobalHotKey;


		}

		private void LoadHotKey()
		{
			KeysConverter kc = new KeysConverter();

#if DEBUG
			Console.WriteLine("LoadHotKey");
			Console.WriteLine("RunModKeys:{0}",Properties.HotKey.Default.RunModKey);
			Console.WriteLine("RunKeys:{0}",Properties.HotKey.Default.RunKeys);
#endif

			uint modkey = Properties.HotKey.Default.RunModKey;
			string runkey = Properties.HotKey.Default.RunKeys;

			if ((modkey != 0) && (runkey != "") && (runkey != null))
			{
				txtRunSetting.Text = HotKey.GetHotkeyMessage(modkey, (Keys)kc.ConvertFrom(runkey));
				chkRunEnable.Enabled = true;
			}
			else
			{
				txtRunSetting.Text = "設定なし";
				chkRunEnable.Enabled = false;
			}

#if DEBUG
			Console.WriteLine("RunNowModKeys:{0}", Properties.HotKey.Default.RunNowModKey);
			Console.WriteLine("RunNowKeys:{0}",Properties.HotKey.Default.RunNowKeys);
#endif

			modkey = Properties.HotKey.Default.RunNowModKey;
			runkey = Properties.HotKey.Default.RunNowKeys;

			if ((modkey != 0) && (runkey != "") && (runkey != null))
			{
				txtRunNowSetting.Text = HotKey.GetHotkeyMessage(Properties.HotKey.Default.RunNowModKey, (Keys)kc.ConvertFrom(Properties.HotKey.Default.RunNowKeys));
				chkRunNowEnable.Enabled = true;
			}
			else
			{
				txtRunNowSetting.Text = "設定なし";
				chkRunNowEnable.Enabled = false;
			}
		}

		private void SaveConfig()
		{
			Properties.HotKey.Default.isRunHotKey = chkRunEnable.Checked;
			Properties.HotKey.Default.isRunNowHotKey = chkRunNowEnable.Checked;
			Properties.HotKey.Default.Save();
		}

		private void dlgHotKeySetting_Load(object sender, EventArgs e)
		{
			this.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2);
			this.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2);
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			DialogResult dr;

			dr = MessageBox.Show("初期化すると元に戻せません。\nよろしいですか？", "ホットキー設定リセット確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

			if (dr == System.Windows.Forms.DialogResult.OK)
			{
				Properties.HotKey.Default.Reset();
				LoadConfig();
				LoadHotKey();
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SaveConfig();
			this.Close();
		}

		private void chkRunEnable_CheckedChanged(object sender, EventArgs e)
		{
			//grpRunHotKey.Enabled = chkRunEnable.Checked;
		}

		private void chkRunNowEnable_CheckedChanged(object sender, EventArgs e)
		{
			//grpRunNowHotKey.Enabled = chkRunNowEnable.Checked;
		}

		private void btnHotKeySetting_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			dlgHotKey dlghk = null;

			if (btn != null)
			{
				switch (btn.Name)
				{
					case "btnRunSetting":
						dlghk = new dlgHotKey(false);
						break;
					case "btnRunNowSetting":
						dlghk = new dlgHotKey(true);
						break;
					default:
						break;
				}
				using (dlghk)
				{
					if (dlghk != null)
					{
						dlghk.ShowDialog(this);
						LoadHotKey();

						switch (btn.Name)
						{
							case "btnRunSetting":
								if (txtRunSetting.Text != "設定なし")
								{
									chkRunEnable.Checked = true;
								}
								else
								{
									chkRunEnable.Checked = false;
								}
								break;
							case "btnRunNowSetting":
								if (txtRunNowSetting.Text != "設定なし")
								{
									chkRunNowEnable.Checked = true;
								}
								else
								{
									chkRunNowEnable.Checked = false;
								}
								break;
							default:
								break;
						}
					}
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
