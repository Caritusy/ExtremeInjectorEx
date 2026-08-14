using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal sealed class Class11 : NativeWindow
{
	private readonly TabControl tabControl_0;

	public Class11(TabControl tabControl_1)
	{
		while (true)
		{
			int num = -1385563919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -315089379)) % 3)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					tabControl_1.HandleDestroyed += method_0;
					AssignHandle(tabControl_1.Handle);
					return;
				}
				break;
				IL_0008:
				tabControl_0 = tabControl_1;
				num = (int)((num2 * 889290799) ^ 0x7DDC06C4);
			}
		}
	}

	void NativeWindow.WndProc(ref Message message_0)
	{
		if (message_0.Msg == 4904)
		{
			goto IL_008b;
		}
		goto IL_00ee;
		IL_008b:
		int num = 1820758606;
		goto IL_00bd;
		IL_00bd:
		Class124.Struct37 @struct = default(Class124.Struct37);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x1A479132)) % 8)
			{
			case 7u:
				@struct.int_0 -= 3;
				num = (int)((num2 * 1687154831) ^ 0x67230D98);
				continue;
			case 5u:
				@struct.int_1--;
				num = (int)((num2 * 1590491792) ^ 0xACFCB03);
				continue;
			case 4u:
				@struct = (Class124.Struct37)message_0.GetLParam(typeof(Class124.Struct37));
				num = (int)(num2 * 1594782365) ^ -1189625175;
				continue;
			case 3u:
				@struct.int_2++;
				num = ((int)num2 * -1371927912) ^ -614484777;
				continue;
			case 2u:
				break;
			case 1u:
				@struct.int_3++;
				Marshal.StructureToPtr((object)@struct, message_0.LParam, true);
				num = ((int)num2 * -972060597) ^ -1306738727;
				continue;
			default:
				return;
			case 0u:
				goto IL_00ee;
			case 6u:
				return;
			}
			break;
		}
		goto IL_008b;
		IL_00ee:
		base.WndProc(ref message_0);
		num = 151842380;
		goto IL_00bd;
	}

	private void method_0(object sender, EventArgs e)
	{
		tabControl_0.HandleDestroyed -= method_0;
		ReleaseHandle();
	}
}
