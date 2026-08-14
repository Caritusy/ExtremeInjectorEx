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

	internal void method_0()
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

	internal void method_1(object sender, EventArgs e)
	{
		try
		{
			long ticks = DateTime.Now.Ticks;
			if (ticks - this.long_0 > 10000000L)
			{
				this.long_0 = ticks;
				this.method_0();
			}
		}
		catch
		{
		}
	}

	internal WorkingSetTrimmer()
	{
		Application.Idle += this.method_1;
		this.method_0();
	}

	internal static Process smethod_0()
	{
		return Process.GetCurrentProcess();
	}

	internal static IntPtr smethod_1(Process process_0)
	{
		return process_0.Handle;
	}
}
