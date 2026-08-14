using System;

public sealed class InvertedFunctionTable32 : RemotePlatformStructure
{
	internal static int intValue = 0;

	static InvertedFunctionTable32()
	{
		RemotePlatformStructure.Register32BitLayout<InvertedFunctionTable32>(new RemotePlatformStructure.RemoteFieldLayout[]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteArrayFieldLayout(typeof(uint), InvertedFunctionTable32.intValue)
		});
	}

	public InvertedFunctionTable32(IntPtr address, IntPtr address2)
		: base(address2, flag2: true)
	{
		SetAddress(address);
	}
}
