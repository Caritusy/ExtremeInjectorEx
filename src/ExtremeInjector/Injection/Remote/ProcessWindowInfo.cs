using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ProcessWindowInfo
{
	[CompilerGenerated]
	public sealed class WindowCollector
	{
		public List<ProcessWindowInfo> items;

		internal bool CollectWindow(IntPtr address, IntPtr address2)
		{
			ProcessWindowInfo @class = new ProcessWindowInfo(address);
			if (RecoveredRuntime.PopulateWindowIdentifiers(@class))
			{
				this.items.Add(@class);
			}
			return true;
		}
	}

	[CompilerGenerated]
	internal IntPtr handle;

	[CompilerGenerated]
	internal int processId;

	[CompilerGenerated]
	internal int threadId;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetHandle()
	{
		return handle;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetHandle(IntPtr address)
	{
		handle = address;
	}

	[SpecialName]
	[CompilerGenerated]
	public int GetProcessId()
	{
		return processId;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetProcessId(int intValue)
	{
		processId = intValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetThreadId(int intValue)
	{
		threadId = intValue;
	}

	internal ProcessWindowInfo(IntPtr address)
	{
		SetHandle(address);
	}
}
