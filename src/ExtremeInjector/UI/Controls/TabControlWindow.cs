using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class TabControlWindow : NativeWindow
{
	internal readonly TabControl tabControl;

	public TabControlWindow(TabControl tabControl2)
	{
		this.tabControl = tabControl2;
		tabControl2.HandleDestroyed += this.OnHandleDestroyed;
		base.AssignHandle(tabControl2.Handle);
	}

	protected override void WndProc(ref Message message)
	{
		if (message.Msg == 4904)
		{
			NativeTypes.NativeRect @struct = (NativeTypes.NativeRect)message.GetLParam(typeof(NativeTypes.NativeRect));
			@struct.Left -= 3;
			@struct.Right++;
			@struct.Top--;
			@struct.Bottom++;
			Marshal.StructureToPtr(@struct, message.LParam, true);
		}
		base.WndProc(ref message);
	}

	internal void OnHandleDestroyed(object sender, EventArgs e)
	{
		tabControl.HandleDestroyed -= OnHandleDestroyed;
		ReleaseHandle();
	}
}
