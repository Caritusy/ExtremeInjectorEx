using System;

public sealed class LdrListEntry64 : RemoteLdrListEntry
{
	static LdrListEntry64()
	{
		RemotePlatformStructure.smethod_7<LdrListEntry64>(new RemoteFieldLayout[2]
		{
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr))
		});
	}

	internal LdrListEntry64(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	public override RemoteLdrDataTableEntry method_07DF()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		LdrDataTableEntry64 @class = new LdrDataTableEntry64(vmethod_7(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	public override RemoteListEntry method_07D2()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		ListEntry64 @class = new ListEntry64(vmethod_7(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	public override RemoteListEntry method_07D3()
	{
		if (!(vmethod_9() != IntPtr.Zero))
		{
			return null;
		}
		ListEntry64 @class = new ListEntry64(vmethod_9(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
