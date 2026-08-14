using System;

public sealed class InvertedFunctionTableEntry32 : RemotePlatformStructure
{
	static InvertedFunctionTableEntry32()
	{
		RemotePlatformStructure.Register32BitLayout<InvertedFunctionTableEntry32>(new RemoteFieldLayout[4]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint))
		});
	}

	public InvertedFunctionTableEntry32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: true)
	{
		SetAddress(intptr_2);
	}
}
