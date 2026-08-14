using System;

public sealed class InvertedFunctionTable32 : RemotePlatformStructure
{
	internal static int int_2;

	static InvertedFunctionTable32()
	{
		RemotePlatformStructure.smethod_6<InvertedFunctionTable32>(new RemotePlatformStructure.RemoteFieldLayout[]
		{
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_194(typeof(uint), InvertedFunctionTable32.int_2)
		});
	}

	public InvertedFunctionTable32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: true)
	{
		method_18(intptr_2);
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
