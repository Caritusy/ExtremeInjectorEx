using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public sealed class ProcessThreadInfo
{
	[CompilerGenerated]
	internal int threadId;

	[CompilerGenerated]
	internal IntPtr startAddress;

	[CompilerGenerated]
	internal int basePriority;

	[CompilerGenerated]
	internal int currentPriority;

	[CompilerGenerated]
	internal IntPtr tebAddress;

	[CompilerGenerated]
	internal ThreadPriorityLevel priorityLevel;

	internal RemoteProcess nativeInfo;

	[SpecialName]
	[CompilerGenerated]
	public int GetThreadId()
	{
		return threadId;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetThreadId(int intValue)
	{
		threadId = intValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetStartAddress()
	{
		return startAddress;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetStartAddress(IntPtr address)
	{
		startAddress = address;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetBasePriority(int intValue)
	{
		basePriority = intValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetCurrentPriority(int intValue)
	{
		currentPriority = intValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetTebAddress(IntPtr address)
	{
		tebAddress = address;
	}

	[SpecialName]
	[CompilerGenerated]
	public ThreadPriorityLevel GetPriorityLevel()
	{
		return priorityLevel;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetPriorityLevel(ThreadPriorityLevel threadPriorityLevel)
	{
		priorityLevel = threadPriorityLevel;
	}

	[SpecialName]
	public NativeThreadInfo GetNativeInfo()
	{
		foreach (NativeProcessInfo @class in RecoveredRuntime.EnumerateSystemProcesses())
		{
			if (@class.GetProcessRecord().address.ToInt64() == this.nativeInfo.ProcessId)
			{
				foreach (NativeTypes.SystemThreadInformation @struct in @class.GetThreads())
				{
					IntPtr intPtr = @struct.clientId.address2;
					if (intPtr.ToInt64() == (long)this.GetThreadId())
					{
						return new NativeThreadInfo(@struct);
					}
				}
			}
		}
		return null;
	}

	internal ProcessThreadInfo(RemoteProcess remoteProcess, int intValue)
	{
		nativeInfo = remoteProcess;
		SetThreadId(intValue);
	}
}
