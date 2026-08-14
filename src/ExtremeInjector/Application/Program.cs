using System;

public static class Program
{
	[STAThread]
	internal static void Main(string[] args)
	{
		Environment.ExitCode = ApplicationHost.Run(args);
	}
}
