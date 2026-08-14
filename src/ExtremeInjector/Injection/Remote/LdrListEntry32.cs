using System;

public sealed class LdrListEntry32 : RemoteLdrListEntry
{
	static LdrListEntry32()
	{
		RemotePlatformStructure.smethod_6<LdrListEntry32>(new RemoteFieldLayout[2]
		{
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint))
		});
	}

	internal LdrListEntry32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: true)
	{
	}

	public override RemoteLdrDataTableEntry method_07DF()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		LdrDataTableEntry32 @class = new LdrDataTableEntry32(vmethod_7(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	public override RemoteListEntry method_07D2()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		ListEntry32 @class = new ListEntry32(vmethod_7(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	public override RemoteListEntry method_07D3()
	{
		if (!(vmethod_9() != IntPtr.Zero))
		{
			return null;
		}
		ListEntry32 @class = new ListEntry32(vmethod_9(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
