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

	public InvertedFunctionTableEntry32(IntPtr address, IntPtr address2)
		: base(address2, flag2: true)
	{
		SetAddress(address);
	}
}
