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
	public partial class dlgHotKey : Form
	{
		private List<Keys> keyslist = new List<Keys>();
		private bool isRunNow;

		public dlgHotKey(bool isRunNow)
		{
			InitializeComponent();

			CreateKeyList();
			frmCreate(isRunNow);

			LoadConfig();
		}

		private void frmCreate(bool isRunNow)
		{
			this.isRunNow = isRunNow;

			//フォームの設定
			if (isRunNow)
			{
				this.Text = "「今すぐ実行」のホットキー作成";
			}
			else
			{
				this.Text = "「通常実行」のホットキー作成";
			}


			this.ShowInTaskbar = false;
			this.ControlBox = false;
			this.Icon = Properties.Resources.cinema_display;

			this.AcceptButton = btnOK;
			this.CancelButton = btnCancel;

			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximumSize = this.Size;

			//コンボボックスの設定
			cmbKeys.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbKeys.Enabled = false;
			cmbKeys.BackColor = Color.White;
			
			//ボタンの設定
			//btnOK.Enabled = false;

			//イベントハンドラの登録
			chkAlt.Click += new EventHandler(chk_Click);
			chkCtrl.Click += new EventHandler(chk_Click);
			chkShift.Click += new EventHandler(chk_Click);
			chkWin.Click += new EventHandler(chk_Click);
			
			btnOK.Click += new EventHandler(btnOK_Click);
			btnCancel.Click +=new EventHandler(btnCancel_Click);
		}

		private void CreateKeyList()
		{
			//キーリストの作成
			KeysConverter kc = new KeysConverter();
			Keys key;


			//AからZまでのキー追加
			for (char c = 'A'; c <= 'Z'; c++)
			{
				key = (Keys)kc.ConvertFrom(c.ToString());
				keyslist.Add(key);
			}

			//Functionキーの追加
			for (int i = 1; i <= 12; i++)
			{
				key = (Keys)kc.ConvertFrom("F" + i);
				keyslist.Add(key);
			}

			//数字キーの追加
			for (int i = 0; i <= 9; i++)
			{
				key = (Keys)kc.ConvertFrom(i.ToString());
				keyslist.Add(key);
			}

			/*
			keyslist.Add(Keys.Tab);
			keyslist.Add(Keys.CapsLock);
			keyslist.Add(Keys.Enter);
			keyslist.Add(Keys.Back);
			keyslist.Add(Keys.Insert);
			keyslist.Add(Keys.Delete);
			keyslist.Add(Keys.Home);
			keyslist.Add(Keys.End);
			keyslist.Add(Keys.PageUp);
			keyslist.Add(Keys.PageDown);
			keyslist.Add(Keys.PrintScreen);
			keyslist.Add(Keys.Scroll);

			keyslist.Sort();
			*/
		}

		private void InitializeComboBox()
		{
			cmbKeys.Items.Clear();
			cmbKeys.SelectedItem = null;
			/*
			foreach (Keys key in Enum.GetValues(typeof(Keys)))
			{
				ItemAdd(key);
			}
			*/

			using (HotKey hk = new HotKey())
			{
				//現在の設定できるキーを検索
				foreach (Keys key in keyslist)
				{
					//オーナーは自分でよさげなので変更
					if (hk.RegisterHotKey(this.GetHashCode().ToString(), this.Handle, GetModKey(), key))
					{
						hk.ReleseHotKey();
						cmbKeys.Items.Add(key.ToString());
					}
				}
			}

			cmbKeys.SelectedIndex = 0;

			cmbKeys.Enabled = true;
		}
	 
		private uint GetModKey()
		{
			uint modkey = 0;

			if (chkAlt.Checked)
			{
				modkey = modkey | (uint)MOD_KEY.ALT;
			}

			if (chkCtrl.Checked)
			{
				modkey = modkey | (uint)MOD_KEY.CONTROL;
			}

			if (chkShift.Checked)
			{
				modkey = modkey | (uint)MOD_KEY.SHIFT;
			}

			if (chkWin.Checked)
			{
				modkey = modkey | (uint)MOD_KEY.WIN;
			}

			return modkey;
		}

		private void ReverseConfig(uint set, string setkey)
		{
			if ((set & (uint)MOD_KEY.ALT) == (uint)MOD_KEY.ALT)
			{
				chkAlt.Checked = true;
			}

			if ((set & (uint)MOD_KEY.CONTROL) == (uint)MOD_KEY.CONTROL)
			{
				chkCtrl.Checked = true;
			}

			if ((set & (uint)MOD_KEY.SHIFT) == (uint)MOD_KEY.SHIFT)
			{
				chkShift.Checked = true;
			}

			if ((set & (uint)MOD_KEY.WIN) == (uint)MOD_KEY.WIN)
			{
				chkWin.Checked = true;
			}

			InitializeComboBox();

			cmbKeys.Text = setkey;

			btnOK.Enabled = true;
		}

		private void LoadConfig()
		{
			uint modkey;
			string key;
			if (isRunNow)
			{
				modkey = Properties.HotKey.Default.RunNowModKey;
				key = Properties.HotKey.Default.RunNowKeys;
				
			}
			else
			{
				modkey = Properties.HotKey.Default.RunModKey;
				key = Properties.HotKey.Default.RunKeys;
			}

			if ((modkey == 0) || (key == null) || (key == ""))
			{
#if DEBUG
				Console.WriteLine("読み込みエラー:いずれかの設定がされていない");
#endif
				//return;
			}
			else
			{
				ReverseConfig(modkey, key);
			}

			foreach (var item in cmbKeys.Items)
			{
				if (item.ToString() == key)
				{
					cmbKeys.SelectedText = key;
				}
			}

		}

		private void SaveConfig()
		{
			uint modkey = GetModKey();
			string keys = cmbKeys.Text;

#if DEBUG
			Console.WriteLine("modkey:{0}", modkey);
			Console.WriteLine("keys:{0}",keys);
#endif



			if (isRunNow)
			{
				if ((modkey == 0) || (keys == "") || (keys == null))
				{
					Properties.HotKey.Default.RunNowModKey = 0;
					Properties.HotKey.Default.RunNowKeys = null;
				}
				else
				{
					Properties.HotKey.Default.RunNowModKey = modkey;
					Properties.HotKey.Default.RunNowKeys = keys;
				}
			}
			else
			{
				if ((modkey == 0) || (keys == "") || (keys == null))
				{
					Properties.HotKey.Default.RunModKey = 0;
					Properties.HotKey.Default.RunKeys = null;
				}
				else
				{
					Properties.HotKey.Default.RunModKey = modkey;
					Properties.HotKey.Default.RunKeys = keys;
				}
			}

			Properties.HotKey.Default.Save();
		}

		private void chk_Click(object sender, EventArgs e)
		{
			if (chkAlt.Checked || chkCtrl.Checked || chkShift.Checked || chkWin.Checked)
			{
				InitializeComboBox();
				//btnOK.Enabled = true;
			}
			else
			{
				//btnOK.Enabled = false;
				cmbKeys.SelectedItem = null;
				cmbKeys.Enabled = false;
			}

		}

		private void dlgHotKey_Load(object sender, EventArgs e)
		{
			this.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2);
			this.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2);
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

	}
}
