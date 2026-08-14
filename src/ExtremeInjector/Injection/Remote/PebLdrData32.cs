using System;
using System.Runtime.CompilerServices;

public sealed class PebLdrData32 : RemotePebLdrData
{
	static PebLdrData32()
	{
		RemotePlatformStructure.Register32BitLayout<PebLdrData32>(new RemoteFieldLayout[7]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry32)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry32)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry32))
		});
	}

	internal PebLdrData32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: true)
	{
		RecoveredRuntime.SetPebLdrDataAddress(intptr_2, this);
	}

	[SpecialName]
	public override RemoteLdrListEntry GetLoadOrderModuleList()
	{
		LdrListEntry32 @class = new LdrListEntry32(RecoveredRuntime.GetRemoteFieldAddress(this, 3), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}
}
