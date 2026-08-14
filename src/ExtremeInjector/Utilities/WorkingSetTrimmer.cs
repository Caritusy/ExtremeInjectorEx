using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class WorkingSetTrimmer
{
	internal static WorkingSetTrimmer workingSetTrimmer = null;

	internal long longValue = DateTime.Now.Ticks;

	[DllImport("kernel32")]
	internal static extern int SetProcessWorkingSetSize(IntPtr address, IntPtr address2, IntPtr address3);

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
			if (ticks - this.longValue > 10000000L)
			{
				this.longValue = ticks;
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
