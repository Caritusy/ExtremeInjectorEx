using System;
using System.Runtime.CompilerServices;

public sealed class PebLdrData64 : RemotePebLdrData
{
	static PebLdrData64()
	{
		RemotePlatformStructure.Register64BitLayout<PebLdrData64>(new RemoteFieldLayout[7]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry64)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry64)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry64))
		});
	}

	internal PebLdrData64(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: false)
	{
		RecoveredRuntime.SetPebLdrDataAddress(intptr_2, this);
	}

	[SpecialName]
	public override RemoteLdrListEntry GetLoadOrderModuleList()
	{
		LdrListEntry64 @class = new LdrListEntry64(RecoveredRuntime.GetRemoteFieldAddress(this, 3), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}
}
