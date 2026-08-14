using System;

public sealed class InvertedFunctionTable32 : RemotePlatformStructure
{
	internal static int int_2;

	static InvertedFunctionTable32()
	{
		RemotePlatformStructure.Register32BitLayout<InvertedFunctionTable32>(new RemotePlatformStructure.RemoteFieldLayout[]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteArrayFieldLayout(typeof(uint), InvertedFunctionTable32.int_2)
		});
	}

	public InvertedFunctionTable32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: true)
	{
		SetAddress(intptr_2);
	}
}
