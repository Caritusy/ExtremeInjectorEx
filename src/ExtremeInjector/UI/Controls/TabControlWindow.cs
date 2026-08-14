using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class TabControlWindow : NativeWindow
{
	internal readonly TabControl tabControl_0;

	public TabControlWindow(TabControl tabControl_1)
	{
		this.tabControl_0 = tabControl_1;
		tabControl_1.HandleDestroyed += this.OnHandleDestroyed;
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

	internal void OnHandleDestroyed(object sender, EventArgs e)
	{
		tabControl_0.HandleDestroyed -= OnHandleDestroyed;
		ReleaseHandle();
	}
}
