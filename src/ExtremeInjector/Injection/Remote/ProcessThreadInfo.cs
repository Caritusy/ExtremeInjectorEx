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
	public int method_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(int int_3)
	{
		int_0 = int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_2()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(IntPtr intptr_2)
	{
		intptr_0 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_4(int int_3)
	{
		int_1 = int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_5(int int_3)
	{
		int_2 = int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_6(IntPtr intptr_2)
	{
		intptr_1 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public ThreadPriorityLevel method_7()
	{
		return threadPriorityLevel_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_8(ThreadPriorityLevel threadPriorityLevel_1)
	{
		threadPriorityLevel_0 = threadPriorityLevel_1;
	}

	[SpecialName]
	public NativeThreadInfo method_9()
	{
		foreach (NativeProcessInfo @class in RecoveredRuntime.smethod_21())
		{
			if (@class.method_0().intptr_0.ToInt64() == this.gclass2_0.ProcessId)
			{
				foreach (NativeTypes.Struct40 @struct in @class.method_2())
				{
					IntPtr intPtr = @struct.struct48_0.intptr_1;
					if (intPtr.ToInt64() == (long)this.method_0())
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
		method_1(int_3);
	}
}
