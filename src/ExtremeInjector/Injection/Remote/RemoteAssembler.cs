using System;
using System.Runtime.CompilerServices;

public sealed class RemoteAssembler
{
	public sealed class Class48
	{
		[CompilerGenerated]
		internal AsmJitLabel class58_0;

		[SpecialName]
		[CompilerGenerated]
		public AsmJitLabel method_0()
		{
			return class58_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(AsmJitLabel class58_1)
		{
			class58_0 = class58_1;
		}

		public Class48(AsmJitLabel class58_1)
		{
			this.method_1(class58_1);
		}
	}

	public enum Enum6
	{
		const_0,
		const_1,
		const_2
	}

	internal AsmJitAssembler class53_0;

	internal bool bool_0;

	internal bool bool_1;

	internal AsmJitLabel class58_0;

	internal AsmJitLabel class58_1;

	internal int int_0;

	[CompilerGenerated]
	internal bool bool_2;

	[CompilerGenerated]
	internal int int_1;

	[SpecialName]
	[CompilerGenerated]
	public bool method_0()
	{
		return bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(bool bool_3)
	{
		bool_2 = bool_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_2()
	{
		return int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(int int_2)
	{
		int_1 = int_2;
	}

	public RemoteAssembler(AsmJitAssembler class53_1, RemoteProcess gclass2_0)
	{
		class53_0 = class53_1;
		bool_0 = RecoveredRuntime.smethod_427(gclass2_0);
		bool_1 = gclass2_0.bool_2;
	}

	public void method_4<T>()
	{
		this.class58_0 = RecoveredRuntime.smethod_48(this.class53_0);
		this.int_0 = PlatformInfo.smethod_1<T>();
		if (typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr))
		{
			RecoveredRuntime.smethod_75(this.class53_0, RecoveredRuntime.smethod_221(this, this.class58_0, 0L), this.bool_0 ? AsmJitRuntime.class63_37 : AsmJitRuntime.class63_53);
			this.int_0 = (this.bool_0 ? 4 : 8);
			return;
		}
		if (this.int_0 == 4)
		{
			RecoveredRuntime.smethod_75(this.class53_0, RecoveredRuntime.smethod_80(0L, this, this.class58_0), AsmJitRuntime.class63_37);
			return;
		}
		if (this.int_0 == 2)
		{
			RecoveredRuntime.smethod_75(this.class53_0, RecoveredRuntime.smethod_116(this.class58_0, 0L, this), AsmJitRuntime.class63_21);
			return;
		}
		if (this.int_0 == 1)
		{
			RecoveredRuntime.smethod_75(this.class53_0, RecoveredRuntime.smethod_290(this.class58_0, 0L, this), AsmJitRuntime.class63_37);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.smethod_0(4473));
	}

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static InvalidOperationException smethod_1(string string_0)
	{
		return new InvalidOperationException(string_0);
	}
}
