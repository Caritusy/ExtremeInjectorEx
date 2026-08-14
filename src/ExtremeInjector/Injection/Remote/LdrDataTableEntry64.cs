using System;
using System.Runtime.CompilerServices;

public sealed class LdrDataTableEntry64 : RemoteLdrDataTableEntry
{
	static LdrDataTableEntry64()
	{
		RemotePlatformStructure.Register64BitLayout<LdrDataTableEntry64>(new RemoteFieldLayout[16]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry64)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry64)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry64)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(UnicodeString64)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(UnicodeString64)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(short)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(short)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ListEntry64)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrDdagNode64))
		});
	}

	internal LdrDataTableEntry64(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	[SpecialName]
	public override RemoteLdrListEntry GetLoadOrderLinks()
	{
		LdrListEntry64 @class = new LdrListEntry64(RecoveredRuntime.GetRemoteFieldAddress(this, 0), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	[SpecialName]
	public override RemoteLdrListEntry GetMemoryOrderLinks()
	{
		LdrListEntry64 @class = new LdrListEntry64(RecoveredRuntime.GetRemoteFieldAddress(this, 1), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	[SpecialName]
	public override RemoteLdrListEntry GetInitializationOrderLinks()
	{
		LdrListEntry64 @class = new LdrListEntry64(RecoveredRuntime.GetRemoteFieldAddress(this, 2), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	[SpecialName]
	public override IntPtr GetModuleBase()
	{
		return ReadField<IntPtr>(3);
	}

	[SpecialName]
	public override short GetLoadCount()
	{
		return ReadField<short>(9);
	}

	[SpecialName]
	public override RemoteListEntry GetHashLinks()
	{
		ListEntry64 @class = new ListEntry64(RecoveredRuntime.GetRemoteFieldAddress(this, 11), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	[SpecialName]
	public override IntPtr GetDependencyNodeAddress()
	{
		return ReadField<IntPtr>(15);
	}

	public override RemoteLdrDdagNode GetDependencyNode()
	{
		LdrDdagNode64 @class = new LdrDdagNode64(GetDependencyNodeAddress(), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}
}
