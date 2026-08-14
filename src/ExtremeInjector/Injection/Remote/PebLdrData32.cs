using System;
using System.Runtime.CompilerServices;

public sealed class PebLdrData32 : RemotePebLdrData
{
	static PebLdrData32()
	{
		RemotePlatformStructure.smethod_6<PebLdrData32>(new RemoteFieldLayout[7]
		{
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(LdrListEntry32)),
			RecoveredRuntime.smethod_316(typeof(LdrListEntry32)),
			RecoveredRuntime.smethod_316(typeof(LdrListEntry32))
		});
	}

	internal PebLdrData32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: true)
	{
		RecoveredRuntime.smethod_400(intptr_2, this);
	}

	[SpecialName]
	public override RemoteLdrListEntry method_080D()
	{
		LdrListEntry32 @class = new LdrListEntry32(RecoveredRuntime.smethod_223(this, 3), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
