using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class GClass6
{
	internal static GClass6 gclass6_0;

	private long long_0 = DateTime.Now.Ticks;

	[DllImport("kernel32")]
	private static extern int SetProcessWorkingSetSize(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	private void method_0()
	{
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			try
			{
				SetProcessWorkingSetSize(currentProcess.Handle, new IntPtr(-1), new IntPtr(-1));
			}
			finally
			{
				if (currentProcess != null)
				{
					while (true)
					{
						IL_0056:
						int num = 1020822574;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ 0x4ED53F2E)) % 3)
							{
							case 2u:
								goto IL_0026;
							default:
								goto end_IL_0039;
							case 0u:
								break;
							case 1u:
								goto end_IL_0039;
							}
							goto IL_0056;
							IL_0026:
							((IDisposable)currentProcess).Dispose();
							num = ((int)num2 * -238454007) ^ 0x2FA9F433;
							continue;
							end_IL_0039:
							break;
						}
						break;
					}
				}
			}
		}
		catch
		{
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		try
		{
			DateTime now = DateTime.Now;
			long ticks = default(long);
			while (true)
			{
				int num = 1458592250;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x5A2D52D4)) % 6)
					{
					case 5u:
						method_0();
						num = ((int)num2 * -1567642888) ^ -528889065;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (ticks - long_0 <= 10000000L)
						{
							num3 = 1818206141;
							num4 = 1818206141;
						}
						else
						{
							num3 = 415436325;
							num4 = 415436325;
						}
						num = num3 ^ (int)(num2 * 1151514469);
						continue;
					}
					case 2u:
						ticks = now.Ticks;
						num = ((int)num2 * -1102080687) ^ 0x39A4AE40;
						continue;
					case 1u:
						long_0 = ticks;
						num = (int)((num2 * 1984842549) ^ 0x25E58978);
						continue;
					default:
						return;
					case 0u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	internal GClass6()
	{
		while (true)
		{
			int num = 1982843409;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x342359F2)) % 3)
				{
				case 2u:
					goto IL_001b;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_001b:
				Application.Idle += method_1;
				method_0();
				num = ((int)num2 * -1099491764) ^ -1958239290;
			}
		}
	}
}
