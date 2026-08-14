using System;
using System.Runtime.CompilerServices;

public sealed class LdrDataTableEntry64 : RemoteLdrDataTableEntry
{
	static LdrDataTableEntry64()
	{
		RemotePlatformStructure.smethod_7<LdrDataTableEntry64>(new RemoteFieldLayout[16]
		{
			RecoveredRuntime.smethod_316(typeof(LdrListEntry64)),
			RecoveredRuntime.smethod_316(typeof(LdrListEntry64)),
			RecoveredRuntime.smethod_316(typeof(LdrListEntry64)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(UnicodeString64)),
			RecoveredRuntime.smethod_316(typeof(UnicodeString64)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(short)),
			RecoveredRuntime.smethod_316(typeof(short)),
			RecoveredRuntime.smethod_316(typeof(ListEntry64)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(LdrDdagNode64))
		});
	}

	internal LdrDataTableEntry64(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	[SpecialName]
	public override RemoteLdrListEntry method_07EE()
	{
		LdrListEntry64 @class = new LdrListEntry64(RecoveredRuntime.smethod_223(this, 0), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override RemoteLdrListEntry method_07EF()
	{
		LdrListEntry64 @class = new LdrListEntry64(RecoveredRuntime.smethod_223(this, 1), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override RemoteLdrListEntry method_07F0()
	{
		LdrListEntry64 @class = new LdrListEntry64(RecoveredRuntime.smethod_223(this, 2), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override IntPtr method_07F1()
	{
		return method_21<IntPtr>(3);
	}

	[SpecialName]
	public override short method_07F2()
	{
		return method_21<short>(9);
	}

	[SpecialName]
	public override RemoteListEntry method_07F3()
	{
		ListEntry64 @class = new ListEntry64(RecoveredRuntime.smethod_223(this, 11), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override IntPtr method_07F4()
	{
		return method_21<IntPtr>(15);
	}

	public override RemoteLdrDdagNode method_07F5()
	{
		LdrDdagNode64 @class = new LdrDdagNode64(method_07F4(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
