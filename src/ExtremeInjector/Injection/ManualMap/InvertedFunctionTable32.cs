using System;

public sealed class InvertedFunctionTable32 : RemotePlatformStructure
{
	internal static int int_2;

	static InvertedFunctionTable32()
	{
		if (!PlatformInfo.bool_5)
		{
			goto IL_000a;
		}
		int num = 2;
		goto IL_002b;
		IL_002a:
		num = 1;
		goto IL_002b;
		IL_002b:
		int_2 = num;
		int num2 = 201796385;
		goto IL_000f;
		IL_000f:
		switch ((uint)(num2 ^ 0x5009204C) % 3u)
		{
		case 0u:
			break;
		case 2u:
			goto IL_002a;
		default:
			RemotePlatformStructure.smethod_6<InvertedFunctionTable32>(new RemoteFieldLayout[3]
			{
				RecoveredRuntime.smethod_316(typeof(uint)),
				RecoveredRuntime.smethod_316(typeof(uint)),
				RecoveredRuntime.smethod_194(typeof(uint), int_2)
			});
			return;
		}
		goto IL_000a;
		IL_000a:
		num2 = 2064503646;
		goto IL_000f;
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
