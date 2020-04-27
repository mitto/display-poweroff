using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace mitto.Util
{
	public enum MOD_KEY : uint
	{
		ALT = 0x0001,
		CONTROL = 0x0002,
		SHIFT = 0x0004,
		WIN = 0x0008
	}


	public class HotKey : IDisposable
	{
		//Windowsのウインドウメッセージ
		public const int WM_HOTKEY = 0x0312;

		//作成元のハンドル
		private IntPtr handle;

		private bool disposed = false;
		private bool successGlobalAtom = false;
		private bool successRegisterHotKey = false;

		public HotKey()
		{
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="hash">ハッシュコード</param>
		/// <param name="handle">ウィンドウハンドル</param>
		/// <param name="modkey">MOD_KEY列挙体</param>
		/// <param name="key">セットする補助キー</param>
		public HotKey(string hash, IntPtr handle, uint modkey, Keys key)
		{
			RegisterHotKey(hash, handle, modkey, key);
		}

		//ホットキー組み合わせのメッセージ用文字列
		private string _HotkeyString;
		public string HotkeyString
		{
			get
			{
				return _HotkeyString;
			}
			private set
			{
				_HotkeyString = value;
			}
		}

		//ホットキーのハンドルID
		private short _HotkeyId;
		public short HotkeyId
		{
			get
			{
				return _HotkeyId;
			}
			private set
			{
				_HotkeyId = value;
			}
		}

		//private bool _SuccessHotKey = false;
		#region "Windows APIラッパー"

		[DllImport("user32.dll")]
		private extern static int RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		[DllImport("user32.dll")]
		private extern static int UnregisterHotKey(IntPtr hWnd, int id);

		[DllImport("kernel32.dll")]
		private extern static short GlobalAddAtom(string lpString);

		[DllImport("kernel32.dll")]
		private extern static short GlobalDeleteAtom(short nAtom);

		#endregion

		public static string GetHotkeyMessage(uint modkey, Keys key)
		{
			//表示用メッセージの作成
			string mes = "";

			if ((modkey & (uint)MOD_KEY.ALT) == (uint)MOD_KEY.ALT)
			{
				mes += "Alt + ";
			}

			if ((modkey & (uint)MOD_KEY.CONTROL) == (uint)MOD_KEY.CONTROL)
			{
				mes += "Control + ";
			}

			if ((modkey & (uint)MOD_KEY.SHIFT) == (uint)MOD_KEY.SHIFT)
			{
				mes += "Shift + ";
			}

			if ((modkey & (uint)MOD_KEY.WIN) == (uint)MOD_KEY.WIN)
			{
				mes += "Win + ";
			}

#if DEBUG
			Console.WriteLine(key.ToString());
#endif

			mes += key.ToString();

			return mes;

		}

		public bool ReleseHotKey()
		{
			//ホットキーの解除
			if (successRegisterHotKey)
			{
				if (UnregisterHotKey(handle, HotkeyId) == 0)
				{
#if DEBUG
					Console.WriteLine("ホットキーの解除に失敗しました");
#endif
					return false;
				}
			}

#if DEBUG
			Console.WriteLine("ホットキーの解除成功：{0}", HotkeyString);
#endif

			//Atomの削除
			if (successGlobalAtom)
			{
				if (GlobalDeleteAtom(HotkeyId) != 0)
				{
#if DEBUG
					Console.WriteLine("ATOMの削除に失敗しました");
#endif
					return false;
				}
			}
#if DEBUG
			Console.WriteLine("ATOMの削除成功：{0}", HotkeyString);
#endif

			return true;
		}

		public bool RegisterHotKey(string hash, IntPtr handle, uint modkey, Keys key)
		{
			this.handle = handle;

			HotkeyString = GetHotkeyMessage(modkey, key);

			this.HotkeyId = GlobalAddAtom(hash + HotkeyString);

			if (HotkeyId == 0)
			{
#if DEBUG
				Console.WriteLine("Atomの取得ができませんでした");
#endif
				return false;
			}

#if DEBUG
			Console.WriteLine("Atomの取得成功：{0}", HotkeyString);
#endif

			successGlobalAtom = true;

			if (RegisterHotKey(handle, HotkeyId, modkey, (uint)key) == 0)
			{
#if DEBUG
				Console.WriteLine("ホットキーの登録に失敗しました");
#endif
				return false;
			}

			successRegisterHotKey = true;

#if DEBUG
			Console.WriteLine("ホットキー登録成功：{0}", HotkeyString);
#endif

			return true;
		}

		public override string ToString()
		{
			return HotkeyString;
		}

		public string Name
		{
			get;
			set;
		}

		#region "IDispossable"

		public void Dispose()
		{
			Dispose(true);

			GC.SuppressFinalize(this);
		}


		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					//マネージリソースはここでDispose
				}

				ReleseHotKey();

				this.handle = IntPtr.Zero;

#if DEBUG
				Console.WriteLine("Dispose完了:{0}", HotkeyString);
#endif

				this.HotkeyString = null;
			}
			disposed = true;
		}

		~HotKey()
		{
			Dispose(false);
		}

		#endregion
	}
}
