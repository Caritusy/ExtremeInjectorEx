using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class WorkingSetTrimmer
{
	internal static WorkingSetTrimmer gclass6_0;

	internal long long_0 = DateTime.Now.Ticks;

	[DllImport("kernel32")]
	internal static extern int SetProcessWorkingSetSize(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	internal void TrimWorkingSet()
	{
		try
		{
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				WorkingSetTrimmer.SetProcessWorkingSetSize(currentProcess.Handle, new IntPtr(-1), new IntPtr(-1));
			}
		}
		catch
		{
		}
	}

	internal void OnApplicationIdle(object sender, EventArgs e)
	{
		try
		{
			long ticks = DateTime.Now.Ticks;
			if (ticks - this.long_0 > 10000000L)
			{
				this.long_0 = ticks;
				this.TrimWorkingSet();
			}
		}
		catch
		{
		}
	}

	internal WorkingSetTrimmer()
	{
		Application.Idle += this.OnApplicationIdle;
		this.TrimWorkingSet();
	}
}
