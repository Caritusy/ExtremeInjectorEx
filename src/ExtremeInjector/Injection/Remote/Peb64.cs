using System;
using System.Runtime.CompilerServices;

public sealed class Peb64 : RemotePeb
{
	static Peb64()
	{
		RemotePlatformStructure.smethod_7<Peb64>(new RemoteFieldLayout[65]
		{
			RecoveredRuntime.smethod_316(typeof(byte)),
			RecoveredRuntime.smethod_316(typeof(byte)),
			RecoveredRuntime.smethod_316(typeof(byte)),
			RecoveredRuntime.smethod_187(typeof(byte), 4),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_194(typeof(uint), 2),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(long)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(ushort)),
			RecoveredRuntime.smethod_316(typeof(ushort)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_194(typeof(IntPtr), 30),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_194(typeof(uint), 32),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(ulong)),
			RecoveredRuntime.smethod_316(typeof(ulong)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(UnicodeString64)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr))
		});
	}

	public Peb64(RemoteProcess gclass2_1)
		: base(gclass2_1, bool_2: false)
	{
		method_04C6();
	}

	public Peb64(RemoteProcess gclass2_1, IntPtr intptr_2)
		: base(gclass2_1, bool_2: false)
	{
		method_3(intptr_2);
	}

	[SpecialName]
	public override IntPtr method_0821()
	{
		return method_21<IntPtr>(6);
	}

	[SpecialName]
	public override IntPtr method_0822()
	{
		return method_21<IntPtr>(17);
	}

	public override RemotePebLdrData method_0823()
	{
		if (!(method_0821() != IntPtr.Zero))
		{
			return null;
		}
		PebLdrData64 @class = new PebLdrData64(method_0821(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
