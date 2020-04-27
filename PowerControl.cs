using System;
using System.Runtime.InteropServices;

namespace mitto.Util
{	
	/// <summary>
	/// ディスプレイ電源操作列挙体
	/// </summary>
	public enum DisplayPowerState
	{
		On = -1,
		Off = 2,
		Saving = 1
	}

	/// <summary>
	/// WindowsAPIのExitWindowsラッパー列挙体
	/// </summary>
	public enum ExitWindows : uint
	{
        EWX_LOGOFF = 0x0,
        EWX_SHUTDOWN = 0x1,
        EWX_REBOOT = 0x2,
        EWX_POWEROFF = 0x8,
        EWX_RESTARTAPPS = 0x40,
        EWX_FORCE = 0x4,
        EWX_FORCEIFHUNG = 0x10
	}

	/// <summary>
	/// 電源関連の操作を行うWindows APIラッパークラス
	/// </summary>
	public class PowerControl
	{
		private static readonly IntPtr WM_BROADCAST = new IntPtr(0xFFFF);
		private static readonly uint WM_SYSCOMMAND = 0x112;
		private static readonly IntPtr SC_MONITORPOWER = new IntPtr(0xF170);


		/// <summary>
		/// WindowsAPIのSendMessage
		/// </summary>
		/// <param name="hWnd">1 つのウィンドウのハンドルを指定します。このウィンドウのウィンドウプロシージャがメッセージを受信します。HWND_BROADCAST を指定すると、この関数は、システム内のすべてのトップレベルウィンドウ（親を持たないウィンドウ）へメッセージを送信します。無効になっている所有されていないウィンドウ、不可視の所有されていないウィンドウ、オーバーラップされた（手前にほかのウィンドウがあって覆い隠されている）ウィンドウ、ポップアップウィンドウも送信先になります。子ウィンドウへはメッセージを送信しません。</param>
		/// <param name="msg">送信するべきメッセージを指定します。</param>
		/// <param name="wp">メッセージ特有の追加情報を指定します。</param>
		/// <param name="lp">メッセージ特有の追加情報を指定します。</param>
		[DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", EntryPoint = "ExitWindowsEx", SetLastError = true)]
		private static extern bool ExitWindowsEx(uint uFlags, uint dwReserved);

		/// <summary>
		/// ディスプレイの電源状態変更メソッド
		/// </summary>
		/// <param name="dp">変更する列挙帯を指定します</param>
		public static void DisplayPowerTo(DisplayPowerState dp)
		{
			try
			{
				SendMessage(WM_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, (IntPtr)dp);
			}
			catch
			{
				Console.WriteLine("SendMessageに失敗しました。");
			}
		}

		public static void PowerStateTo(ExitWindows state, bool force)
		{
			uint power = (uint)state;
			if (force)
			{
				power = power & (uint)ExitWindows.EWX_FORCE;
			}

			try
			{
				ExitWindowsEx(power, 0);
			}
			catch
			{
				Console.WriteLine("SendMessageに失敗しました。");
			}
		}

	}
}
