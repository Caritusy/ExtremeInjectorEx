using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class NativeProcessInfo
{
	[CompilerGenerated]
	internal NativeTypes.SystemProcessInformation processRecord;

	[CompilerGenerated]
	internal List<NativeTypes.SystemThreadInformation> threads;

	[SpecialName]
	[CompilerGenerated]
	public NativeTypes.SystemProcessInformation GetProcessRecord()
	{
		return processRecord;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetProcessRecord(NativeTypes.SystemProcessInformation systemProcessInformation)
	{
		processRecord = systemProcessInformation;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<NativeTypes.SystemThreadInformation> GetThreads()
	{
		return threads;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetThreads(List<NativeTypes.SystemThreadInformation> items)
	{
		threads = items;
	}

	public NativeProcessInfo()
	{
		SetThreads(new List<NativeTypes.SystemThreadInformation>());
	}
}
