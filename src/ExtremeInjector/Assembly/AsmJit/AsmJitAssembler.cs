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
		this.struct19_0 = default(AsmJitAssemblerState);
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.smethod_2()(ref this.struct19_0, IntPtr.Zero);
			return;
		}
		AsmJitApi.smethod_0()(ref this.struct19_0, IntPtr.Zero);
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
