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
			NativeTypes.NativeRect @struct = (NativeTypes.NativeRect)message_0.GetLParam(typeof(NativeTypes.NativeRect));
			@struct.Left -= 3;
			@struct.Right++;
			@struct.Top--;
			@struct.Bottom++;
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
