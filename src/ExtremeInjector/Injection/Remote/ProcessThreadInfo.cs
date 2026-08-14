using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public sealed class ProcessThreadInfo
{
	[CompilerGenerated]
	internal int int_0;

	[CompilerGenerated]
	internal IntPtr intptr_0;

	[CompilerGenerated]
	internal int int_1;

	[CompilerGenerated]
	internal int int_2;

	[CompilerGenerated]
	internal IntPtr intptr_1;

	[CompilerGenerated]
	internal ThreadPriorityLevel threadPriorityLevel_0;

	internal RemoteProcess gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public int GetThreadId()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetThreadId(int int_3)
	{
		int_0 = int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetStartAddress()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetStartAddress(IntPtr intptr_2)
	{
		intptr_0 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetBasePriority(int int_3)
	{
		int_1 = int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetCurrentPriority(int int_3)
	{
		int_2 = int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetTebAddress(IntPtr intptr_2)
	{
		intptr_1 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public ThreadPriorityLevel GetPriorityLevel()
	{
		return threadPriorityLevel_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetPriorityLevel(ThreadPriorityLevel threadPriorityLevel_1)
	{
		threadPriorityLevel_0 = threadPriorityLevel_1;
	}

	[SpecialName]
	public NativeThreadInfo GetNativeInfo()
	{
		foreach (NativeProcessInfo @class in RecoveredRuntime.EnumerateSystemProcesses())
		{
			if (@class.GetProcessRecord().intptr_0.ToInt64() == this.gclass2_0.ProcessId)
			{
				foreach (NativeTypes.Struct40 @struct in @class.GetThreads())
				{
					IntPtr intPtr = @struct.struct48_0.intptr_1;
					if (intPtr.ToInt64() == (long)this.GetThreadId())
					{
						return new NativeThreadInfo(@struct);
					}
				}
			}
		}
		return null;
	}

	internal ProcessThreadInfo(RemoteProcess gclass2_1, int int_3)
	{
		gclass2_0 = gclass2_1;
		SetThreadId(int_3);
	}
}
