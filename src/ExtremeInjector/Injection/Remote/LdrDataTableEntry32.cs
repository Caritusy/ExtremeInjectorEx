using System;
using System.Runtime.CompilerServices;

public sealed class LdrDataTableEntry32 : RemoteLdrDataTableEntry
{
	static LdrDataTableEntry32()
	{
		RemotePlatformStructure.smethod_6<LdrDataTableEntry32>(new RemoteFieldLayout[16]
		{
			RecoveredRuntime.smethod_316(typeof(LdrListEntry32)),
			RecoveredRuntime.smethod_316(typeof(LdrListEntry32)),
			RecoveredRuntime.smethod_316(typeof(LdrListEntry32)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(UnicodeString32)),
			RecoveredRuntime.smethod_316(typeof(UnicodeString32)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(short)),
			RecoveredRuntime.smethod_316(typeof(short)),
			RecoveredRuntime.smethod_316(typeof(ListEntry32)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(LdrDdagNode32))
		});
	}

	internal LdrDataTableEntry32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: true)
	{
	}

	[SpecialName]
	public override RemoteLdrListEntry method_07EE()
	{
		LdrListEntry32 @class = new LdrListEntry32(RecoveredRuntime.smethod_223(this, 0), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override RemoteLdrListEntry method_07EF()
	{
		LdrListEntry32 @class = new LdrListEntry32(RecoveredRuntime.smethod_223(this, 1), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override RemoteLdrListEntry method_07F0()
	{
		LdrListEntry32 @class = new LdrListEntry32(RecoveredRuntime.smethod_223(this, 2), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override IntPtr method_07F1()
	{
		return (IntPtr)method_21<uint>(3);
	}

	[SpecialName]
	public override short method_07F2()
	{
		return method_21<short>(9);
	}

	[SpecialName]
	public override RemoteListEntry method_07F3()
	{
		ListEntry32 @class = new ListEntry32(RecoveredRuntime.smethod_223(this, 11), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override IntPtr method_07F4()
	{
		return (IntPtr)method_21<uint>(15);
	}

	public override RemoteLdrDdagNode method_07F5()
	{
		LdrDdagNode32 @class = new LdrDdagNode32(method_07F4(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
