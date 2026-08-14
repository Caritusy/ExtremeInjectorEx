using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class AsmJitAssembler : IDisposable
{
	internal AsmJitAssemblerState struct19_0;

	[CompilerGenerated]
	internal bool bool_0;

	[SpecialName]
	[CompilerGenerated]
	public bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public AsmJitAssembler()
	{
		while (true)
		{
			int num = -1595971014;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1301443688)) % 6)
				{
				case 5u:
					num = ((!AsmJitRuntime.bool_0) ? (-839802934) : (-1812750530)) ^ ((int)num2 * -784569684);
					continue;
				case 4u:
					struct19_0 = default(AsmJitAssemblerState);
					num = (int)((num2 * 1937383864) ^ 0x47133627);
					continue;
				case 2u:
					AsmJitApi.smethod_2()(ref struct19_0, IntPtr.Zero);
					num = (int)(num2 * 1754946619) ^ -212852007;
					continue;
				case 3u:
					break;
				default:
					AsmJitApi.smethod_0()(ref struct19_0, IntPtr.Zero);
					return;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	~AsmJitAssembler()
	{
		((IDisposable)this).Dispose();
	}

	void IDisposable.Dispose()
	{
		RecoveredRuntime.smethod_115(this);
	}

	public void method_2<T>(T gparam_0) where T : struct
	{
		RecoveredRuntime.smethod_308(Marshal.SizeOf(typeof(T)), gparam_0, this);
	}

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int smethod_1(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}
}
