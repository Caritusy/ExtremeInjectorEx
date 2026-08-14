using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class Class11 : NativeWindow
{
	internal readonly TabControl tabControl_0;

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
					smethod_0(tabControl_1, method_0);
					smethod_2(this, smethod_1(tabControl_1));
					return;
				}
				break;
				IL_0008:
				tabControl_0 = tabControl_1;
				num = (int)((num2 * 889290799) ^ 0x7DDC06C4);
			}
		}
	}

	protected override void WndProc(ref Message message_0)
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

	internal void method_0(object sender, EventArgs e)
	{
		smethod_3(tabControl_0, method_0);
		smethod_4(this);
	}

	internal static void smethod_0(Control control_0, EventHandler eventHandler_0)
	{
		control_0.HandleDestroyed += eventHandler_0;
	}

	internal static IntPtr smethod_1(Control control_0)
	{
		return control_0.Handle;
	}

	internal static void smethod_2(NativeWindow nativeWindow_0, IntPtr intptr_0)
	{
		nativeWindow_0.AssignHandle(intptr_0);
	}

	internal static void smethod_3(Control control_0, EventHandler eventHandler_0)
	{
		control_0.HandleDestroyed -= eventHandler_0;
	}

	internal static void smethod_4(NativeWindow nativeWindow_0)
	{
		nativeWindow_0.ReleaseHandle();
	}
}
