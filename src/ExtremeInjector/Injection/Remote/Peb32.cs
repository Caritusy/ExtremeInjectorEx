using System;
using System.Runtime.CompilerServices;

public sealed class Peb32 : RemotePeb
{
	static Peb32()
	{
		RemotePlatformStructure.smethod_6<Peb32>(new RemoteFieldLayout[65]
		{
			RecoveredRuntime.smethod_316(typeof(byte)),
			RecoveredRuntime.smethod_316(typeof(byte)),
			RecoveredRuntime.smethod_316(typeof(byte)),
			RecoveredRuntime.smethod_316(typeof(byte)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_194(typeof(uint), 2),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(ulong)),
			RecoveredRuntime.smethod_316(typeof(long)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(ushort)),
			RecoveredRuntime.smethod_316(typeof(ushort)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_194(typeof(uint), 34),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_194(typeof(uint), 32),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(ulong)),
			RecoveredRuntime.smethod_316(typeof(ulong)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(UnicodeString32)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint))
		});
	}

	public Peb32(RemoteProcess gclass2_1)
		: base(gclass2_1, bool_2: true)
	{
		while (true)
		{
			int num = 898515389;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x585DEA23)) % 3)
				{
				case 1u:
					goto IL_000a;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000a:
				method_04C6();
				num = ((int)num2 * -7703666) ^ -759674467;
			}
		}
	}

	public Peb32(RemoteProcess gclass2_1, IntPtr intptr_2)
		: base(gclass2_1, bool_2: true)
	{
		method_3(intptr_2);
	}

	[SpecialName]
	public override IntPtr method_0821()
	{
		return (IntPtr)method_21<uint>(6);
	}

	[SpecialName]
	public override IntPtr method_0822()
	{
		return (IntPtr)method_21<uint>(17);
	}

	public override RemotePebLdrData method_0823()
	{
		if (!(method_0821() != IntPtr.Zero))
		{
			return null;
		}
		PebLdrData32 @class = new PebLdrData32(method_0821(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
