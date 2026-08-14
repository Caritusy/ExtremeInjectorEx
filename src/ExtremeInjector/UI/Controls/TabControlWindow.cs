using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class TabControlWindow : NativeWindow
{
	internal readonly TabControl tabControl_0;

	public TabControlWindow(TabControl tabControl_1)
	{
		this.tabControl_0 = tabControl_1;
		tabControl_1.HandleDestroyed += this.method_0;
		base.AssignHandle(tabControl_1.Handle);
	}

	protected override void WndProc(ref Message message_0)
	{
		if (message_0.Msg == 4904)
		{
			NativeTypes.Struct37 @struct = (NativeTypes.Struct37)message_0.GetLParam(typeof(NativeTypes.Struct37));
			@struct.int_0 -= 3;
			@struct.int_2++;
			@struct.int_1--;
			@struct.int_3++;
			Marshal.StructureToPtr(@struct, message_0.LParam, true);
		}
		base.WndProc(ref message_0);
	}

	internal void method_0(object sender, EventArgs e)
	{
		tabControl_0.HandleDestroyed -= method_0;
		ReleaseHandle();
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
