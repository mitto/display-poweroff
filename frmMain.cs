using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using mitto.Util;

namespace mitto.DisplayPowerOff
{
	//TODO:フィードバック集めつつもう少しコードをきれいにすること。
	//TODO:最前面表示の設定についてはアンケートしてみた方がよさげ


	/// <summary>
	/// メインフォームクラス
	/// </summary>
	public partial class frmMain : Form
	{
		//強制実行されたことを通知するデリゲート
		public delegate void ForceRunAlert();
		public event ForceRunAlert ForceRun;

		private static bool isRunning = false; //カウントダウンが動いてるかのフラグ
		private bool isMouseMove = false;

		private bool isSetting = false;

		//ホットキーによるカウントダウン用のフィールド
		private bool isHotKey = false;
		private bool isBeforeVisible;
		private FormWindowState beforeState;

		private Point mousePoint = new Point();

		private List<HotKey> hotkeylist = new List<HotKey>();

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public frmMain()
		{
			InitializeComponent();

			frmCreate();

			LoadConfig();
		}

		/// <summary>
		/// フォームの初期生成メソッド
		/// </summary>
		private void frmCreate()
		{
			//フォームの設定
			this.MinimumSize = new Size(150, 100);

			this.Text = Application.ProductName;

			//ボタンの生成
			Button btn = new Button();

			btn.Name = "btnPowerOff";
			btn.Text = "Display Off";
			btn.Size = new Size(75, 23);
			btn.Dock = DockStyle.Fill;
			btn.ContextMenuStrip = cMenuTray;
			
			btn.Font = mitto.DisplayPowerOff.Properties.Main.Default.buttonFont;

			//ボタンイベントハンドラの登録
			btn.Click += new EventHandler(btnPowerOff_Click);
			btn.MouseDown += new MouseEventHandler(btnPowerOff_MouseDown);
			btn.MouseMove += new MouseEventHandler(btnPowerOff_MouseMove);

			this.Controls.Add(btn);

			//通知領域アイコンの設定
			noIcon.Icon = this.Icon;
		}

		private void LoadConfig()
		{
			noIcon.Text = "DisplayPowerOff";

			this.Size = Properties.Main.Default.formSize;

			this.TopMost = Properties.Main.Default.isTopMost;

			cMenuTrayTopMost.Checked = Properties.Main.Default.isTopMost;

			this.Controls[0].Font = Properties.Main.Default.buttonFont;

			this.ShowInTaskbar = Properties.Main.Default.isShowInTaskbar;

			if (Properties.Main.Default.isButtonOnly)
			{
				this.Text = "";

				this.ControlBox = false;
			}
			else
			{
				this.Text = Application.ProductName;

				this.ControlBox = true;

				this.Icon = Properties.Resources.cinema_display;
				this.ShowIcon = true;
			}

			//ボタンのみ表示との変更でおかしくなるので調整用
			this.Height += 1;
			this.Height -= 1;

			foreach (HotKey hk in hotkeylist)
			{
				hk.Dispose();
			}

			hotkeylist.Clear();

			if (Properties.Main.Default.isGlobalHotKeyEnabled)
			{
				RegisterHotkey();
			}

		}

		private void RegisterHotkey()
		{
			uint modkey;
			string key;

			string mes = "";

			KeysConverter kc = new KeysConverter();


			if (Properties.HotKey.Default.isRunHotKey)
			{
				modkey = Properties.HotKey.Default.RunModKey;
				key = Properties.HotKey.Default.RunKeys;

				if ((modkey == 0) || (key == "") || (key == null))
				{
#if DEBUG
					Console.WriteLine("RunHotKey登録失敗");
#endif
				}
				else
				{
					HotKey runHotKey = new HotKey(this.GetHashCode().ToString(), this.Handle, modkey, (Keys)kc.ConvertFrom(key));
					mes += String.Format("通常実行ホットキー：{0}\n", runHotKey.HotkeyString);
					runHotKey.Name = "Run";
					hotkeylist.Add(runHotKey);
				}
			}

			if (Properties.HotKey.Default.isRunNowHotKey)
			{
				modkey = Properties.HotKey.Default.RunNowModKey;
				key = Properties.HotKey.Default.RunNowKeys;

				if ((modkey == 0) || (key == "") || (key == null))
				{
#if DEBUG
					Console.WriteLine("RunNowHotKey登録失敗");
#endif
				}
				else
				{
					HotKey runNowHotKey = new HotKey(this.GetHashCode().ToString(), this.Handle, modkey, (Keys)kc.ConvertFrom(key));
					mes += String.Format("今すぐ実行ホットキー：{0}", runNowHotKey.HotkeyString);
					runNowHotKey.Name = "RunNow";
					hotkeylist.Add(runNowHotKey);
				}

			}

			if (mes != "")
			{
				noIcon.ShowBalloonTip(3000, "ホットキー登録完了", mes, ToolTipIcon.Info);
				noIcon.Text = "DisplayPowerOff\n" + mes;
			}
		}

		private void SaveConfig()
		{
			//終了時のフォームサイズを取得し保存しておく
			Properties.Main.Default.formSize = this.Size;
			//終了時のフォームポジションを取得し保存しておく
			if (!(this.Left < -10000 || this.Top < -10000))
			{
				Properties.Main.Default.WindowPosition = this.Location;
			}

			Properties.Main.Default.Save();
		}

		/// <summary>
		/// ForceRunAlertイベントの発行メソッド
		/// </summary>
		private void OnForceRun()
		{
			if (ForceRun != null)
			{
				ForceRun();
			}
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveConfig();
		}

		private void frmMain_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Visible = Properties.Main.Default.isShowInTaskbar;
			}
			this.ShowInTaskbar = Properties.Main.Default.isShowInTaskbar;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			if (Properties.Main.Default.isSaveWindowPosition)
			{
				//this.Location = Properties.Main.Default.WindowPosition;
				this.Top = Properties.Main.Default.WindowPosition.Y;
				this.Left = Properties.Main.Default.WindowPosition.X;
#if DEBUG
				Console.WriteLine("ウィンドウ位置セット： X:{0} Y:{1}", this.Top, this.Left);
#endif
			}

		}

		/// <summary>
		/// PowerOffボタンのイベントハンドラ
		/// </summary>
		private void btnPowerOff_Click(object sender, EventArgs e)
		{
			//ドラッグ中なら処理終了
			if (isMouseMove)
			{
				return;
			}
			//また、カウントダウンが進行している間にイベントが発生した場合はキャンセルする
			else if (isRunning)
			{
				OnForceRun();
				return;
			}
			//設定で強制実行モードになっている場合は電源を切る
			else if (Properties.Main.Default.isForceRun)
			{
				PowerControl.DisplayPowerTo(DisplayPowerState.Off);
				return;
			}

			StartCountDown();
		}

		private void StartCountDown()
		{
			if (isRunning)
			{
				return;
			}

			isRunning = true;
			//カウントダウンフォームを生成し、表示
			using (dlgCountDown CountDown = new dlgCountDown())
			{


				UpdateTrayContextMenu(false);

				if (CountDown.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				{
#if DEBUG
				Console.WriteLine("ディスプレイ電源オフ：{0}", DateTime.Now);
#endif
					PowerControl.DisplayPowerTo(DisplayPowerState.Off);

					if (isHotKey)
					{
						this.Visible = isBeforeVisible;
						this.WindowState = beforeState;
					}
					else
					{
						System.Threading.Thread.Sleep(2000);
					}
				}
				else
				{
#if DEBUG
				Console.WriteLine("キャンセル：{0}", DateTime.Now);
#endif
				}

				isHotKey = false;
			}

			isRunning = false;
			UpdateTrayContextMenu(true);
		}

		private void btnPowerOff_MouseDown(object sender, MouseEventArgs e)
		{
			mousePoint.X = e.X;
			mousePoint.Y = e.Y;
			mousePoint = PointToScreen(mousePoint);

			isMouseMove = false;
		}

		private void btnPowerOff_MouseMove(object sender, MouseEventArgs e)
		{
			Point pt = new Point(e.X, e.Y);
			pt = PointToScreen(pt);

			if ((e.Button == System.Windows.Forms.MouseButtons.Left) && (mousePoint != pt))
			{

				this.Left = this.Left + pt.X - mousePoint.X;
				this.Top = this.Top + pt.Y - mousePoint.Y;
				mousePoint = pt;

				isMouseMove = true;

			}

		}

		/// <summary>
		/// タスクトレイアイコンのイベントハンドラ
		/// </summary>
		private void noIcon_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				if (isRunning || isSetting)
				{
					return;
				}
				if (this.Visible && (this.WindowState == FormWindowState.Minimized))
				{
					this.Visible = false;
				}
				else if (!this.Visible || (this.WindowState == FormWindowState.Minimized))
				{
					this.Visible = true;
					this.WindowState = FormWindowState.Normal;
#if DEBUG
					Console.WriteLine("Position:{0} {1}", this.Top, this.Left);
#endif
				}
				else
				{
					SaveConfig();
					this.WindowState = FormWindowState.Minimized;
					this.Visible = false;
#if DEBUG
					Console.WriteLine("Position:{0} {1}", this.Top, this.Left);
#endif
				}
			}
		}

		/// <summary>
		/// 終了メニューのイベントハンドラ
		/// </summary>
		private void cMenuTrayExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		/// <summary>
		/// 
		/// </summary>
		private void cMenuTraySetting_Click(object sender, EventArgs e)
		{
			//ウインドウサイズ保存のため
			SaveConfig();

			isSetting = true;

			using (dlgSetting setting = new dlgSetting())
			{
				UpdateTrayContextMenu(false);
				Properties.Main.Default.formSize = this.Size;

				setting.ShowDialog(this);
			}
			isSetting = false;

			UpdateTrayContextMenu(true);

			LoadConfig();
		}


		private void cMenuTrayRunNow_Click(object sender, EventArgs e)
		{
			OnForceRun();
			PowerControl.DisplayPowerTo(DisplayPowerState.Off);
		}


		/// <summary>
		/// タスクトレイのコンテキストメニュー表示更新メソッド
		/// </summary>
		/// <param name="isEnabled"></param>

		private void cMenuTrayTopMost_Click(object sender, EventArgs e)
		{
			Properties.Main.Default.isTopMost = !Properties.Main.Default.isTopMost;
			SaveConfig();
			LoadConfig();
		}

		private void cMenuTrayAbout_Click(object sender, EventArgs e)
		{
			string s;
			
			string softurl = "http://www.mittostar.info/";

			string icondesign = "McDo Design (Susumu Yoshida)";
			string iconurl = "http://findicons.com/icon/34085/cinema_display";

			s = String.Format("製品名：{0}\nバージョン：{1}\n作成者：{2}\n作者サイト：{3}\n\nアイコン取得元\nデザイナー：{4}\n{5}",
				Application.ProductName ,Application.ProductVersion, Application.CompanyName, softurl,icondesign, iconurl);
			MessageBox.Show(s, "About...", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void UpdateTrayContextMenu(bool isEnabled)
		{
			cMenuTraySetting.Enabled = isEnabled;
			//cMenuTrayRun.Enabled = isEnabled;
			//cMenuTrayRunNow.Enabled = isEnabled;
			cMenuTrayTopMost.Enabled = isEnabled;

			if (isRunning)
			{
				cMenuTrayRun.Text = "実行キャンセル";
			}
			else
			{
				cMenuTrayRun.Text = "通常実行";
			}
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == HotKey.WM_HOTKEY)
			{

				foreach (HotKey h in hotkeylist)
				{
					if (h.HotkeyId == (short)m.WParam)
					{
#if DEBUG
						Console.WriteLine(h.HotkeyString + "が押されました。");
#endif

						if (h.Name == "Run")
						{
							isHotKey = true;
							isBeforeVisible = this.Visible;
							beforeState = this.WindowState;
							StartCountDown();
						}

						if (h.Name == "RunNow")
						{
							cMenuTrayRunNow_Click(this, new EventArgs());
						}


						break;
					}
				}
			}
		}


	}
}
