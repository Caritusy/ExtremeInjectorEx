using System;
using System.Collections.Generic;

public sealed class FileDropEventArgs : EventArgs
{
	public IntPtr WindowHandle { get; internal set; }

	public List<string> Files { get; internal set; } = new List<string>();

	public int X { get; internal set; }

	public int Y { get; internal set; }
}
