using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal static class CliConsole
{
	private const uint AttachParentProcess = 0xFFFFFFFF;

	internal static void Initialize()
	{
		if (GetConsoleWindow() == IntPtr.Zero && !AttachConsole(AttachParentProcess))
		{
			AllocConsole();
		}

		var utf8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
		Console.InputEncoding = utf8;
		Console.OutputEncoding = utf8;
		Console.SetOut(new StreamWriter(Console.OpenStandardOutput(), utf8) { AutoFlush = true });
		Console.SetError(new StreamWriter(Console.OpenStandardError(), utf8) { AutoFlush = true });
	}

	internal static void DetachForGui()
	{
		IntPtr consoleWindow = GetConsoleWindow();
		if (consoleWindow != IntPtr.Zero)
		{
			ShowWindow(consoleWindow, 0);
		}
		FreeConsole();
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool AttachConsole(uint processId);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool AllocConsole();

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool FreeConsole();

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool ShowWindow(IntPtr windowHandle, int command);
}
