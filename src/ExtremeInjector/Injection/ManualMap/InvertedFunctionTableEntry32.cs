using System;

public sealed class InvertedFunctionTableEntry32 : RemotePlatformStructure
{
	static InvertedFunctionTableEntry32()
	{
		RemotePlatformStructure.smethod_6<InvertedFunctionTableEntry32>(new RemoteFieldLayout[4]
		{
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint))
		});
	}

	public InvertedFunctionTableEntry32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: true)
	{
		method_18(intptr_2);
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
