using System;
using System.Runtime.CompilerServices;

public sealed class PebLdrData64 : RemotePebLdrData
{
	static PebLdrData64()
	{
		RemotePlatformStructure.smethod_7<PebLdrData64>(new RemoteFieldLayout[7]
		{
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(LdrListEntry64)),
			RecoveredRuntime.smethod_316(typeof(LdrListEntry64)),
			RecoveredRuntime.smethod_316(typeof(LdrListEntry64))
		});
	}

	internal PebLdrData64(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: false)
	{
		RecoveredRuntime.smethod_400(intptr_2, this);
	}

	[SpecialName]
	public override RemoteLdrListEntry method_080D()
	{
		LdrListEntry64 @class = new LdrListEntry64(RecoveredRuntime.smethod_223(this, 3), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
