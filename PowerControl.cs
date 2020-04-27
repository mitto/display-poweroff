using System;
using System.Runtime.InteropServices;

namespace DisplayPowerOff
{
	/// <summary>
	/// 電源関連の操作を行うstaticクラス
	/// </summary>
	public class PowerControl
	{
		private static readonly IntPtr WM_BROADCAST = new IntPtr(0xFFFF);
		private static readonly uint WM_SYSCOMMAND = 0x112;
		private static readonly IntPtr SC_MONITORPOWER = new IntPtr(0xF170);

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
		/// WindowsAPIのSendMessage
		/// </summary>
		/// <param name="hWnd">1 つのウィンドウのハンドルを指定します。このウィンドウのウィンドウプロシージャがメッセージを受信します。HWND_BROADCAST を指定すると、この関数は、システム内のすべてのトップレベルウィンドウ（親を持たないウィンドウ）へメッセージを送信します。無効になっている所有されていないウィンドウ、不可視の所有されていないウィンドウ、オーバーラップされた（手前にほかのウィンドウがあって覆い隠されている）ウィンドウ、ポップアップウィンドウも送信先になります。子ウィンドウへはメッセージを送信しません。</param>
		/// <param name="msg">送信するべきメッセージを指定します。</param>
		/// <param name="wp">メッセージ特有の追加情報を指定します。</param>
		/// <param name="lp">メッセージ特有の追加情報を指定します。</param>
		[DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

		/// <summary>
		/// ディスプレイの電源状態変更メソッド
		/// </summary>
		/// <param name="dp">変更する列挙帯を指定します</param>
		public static void DisplayPowerTo(DisplayPowerState dp)
		{
			SendMessage(WM_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, (IntPtr)dp);
		}

	}
}
