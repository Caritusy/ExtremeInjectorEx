using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class NativeLoaderHooks : RemoteCodeExecutorBase
{
	[Serializable]
	[CompilerGenerated]
	public sealed class Class81
	{
		public static readonly Class81 _003C_003E9 = new Class81();

		public static Func<PeSectionHeader, bool> _003C_003E9__14_0;

		internal bool method_0(PeSectionHeader gclass5_0)
		{
			return gclass5_0.method_0() == ".text";
		}

		internal static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}

	[CompilerGenerated]
	internal IntPtr intptr_1;

	[CompilerGenerated]
	internal IntPtr intptr_2;

	[CompilerGenerated]
	internal IntPtr intptr_3;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_24()
	{
		return intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_25(IntPtr intptr_4)
	{
		intptr_1 = intptr_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_26()
	{
		return intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_27(IntPtr intptr_4)
	{
		intptr_2 = intptr_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_28()
	{
		return intptr_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_29(IntPtr intptr_4)
	{
		intptr_3 = intptr_4;
	}

	internal NativeLoaderHooks(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
		method_8(gclass2_1.ProcessId);
		RecoveredRuntime.smethod_357(this);
	}

	protected override void method_04C6()
	{
		if (base.method_2() == IntPtr.Zero && base.method_0() != -1)
		{
			base.method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.method_0()));
		}
	}

	public bool method_30(IntPtr intptr_4, ulong ulong_0, out bool bool_2)
	{
		bool_2 = false;
		if (this.method_24() == IntPtr.Zero || this.method_26() == IntPtr.Zero)
		{
			return false;
		}
		InvertedFunctionTable32 class112_ = new InvertedFunctionTable32(this.method_26(), base.method_2());
		int num = 0;
		while ((long)num < (long)((ulong)RecoveredRuntime.smethod_366(class112_)))
		{
			if (RecoveredRuntime.smethod_323(RecoveredRuntime.smethod_165(class112_)[num]) == intptr_4)
			{
				return true;
			}
			num++;
		}
		AsmJitAssembler @class = new AsmJitAssembler();
		RemoteAssembler class2 = new RemoteAssembler(@class, base.method_19());
		class2.method_1(true);
		RemoteAssembler class3 = class2;
		RecoveredRuntime.smethod_15(class3);
		if (!PlatformInfo.bool_6)
		{
			if (PlatformInfo.bool_5)
			{
				RecoveredRuntime.smethod_54(class3, new AsmJitImmediate(this.method_24()), CallingConvention.StdCall, new object[]
				{
					intptr_4,
					(IntPtr)((long)ulong_0)
				});
			}
			else
			{
				RecoveredRuntime.smethod_54(class3, new AsmJitImmediate(this.method_24()), CallingConvention.StdCall, new object[]
				{
					this.method_26(),
					intptr_4,
					(IntPtr)((long)ulong_0)
				});
			}
		}
		else
		{
			RecoveredRuntime.smethod_54(class3, new AsmJitImmediate(this.method_24()), CallingConvention.FastCall, new object[]
			{
				intptr_4,
				(IntPtr)((long)ulong_0)
			});
		}
		RecoveredRuntime.smethod_226(class3, -1);
		if (RecoveredRuntime.smethod_239(@class, this))
		{
			int num2 = 0;
			while ((long)num2 < (long)((ulong)RecoveredRuntime.smethod_366(class112_)))
			{
				InvertedFunctionTableEntry32 class4 = RecoveredRuntime.smethod_165(class112_)[num2];
				if (!(RecoveredRuntime.smethod_323(class4) != intptr_4))
				{
					if (RecoveredRuntime.smethod_425(class4) != 0u)
					{
						bool_2 = true;
						return true;
					}
					IntPtr intPtr = RecoveredRuntime.smethod_175(this, 2048L, NativeTypes.Enum34.flag_6);
					if (intPtr == IntPtr.Zero)
					{
						return false;
					}
					RecoveredRuntime.smethod_115(@class);
					RecoveredRuntime.smethod_15(class3);
					RecoveredRuntime.smethod_54(class3, new AsmJitImmediate(RecoveredRuntime.smethod_225(RecoveredRuntime.smethod_42(base.method_19())[EncodedStringTable.smethod_0(8549)], EncodedStringTable.smethod_0(8562), false)), CallingConvention.StdCall, new object[]
					{
						intPtr
					});
					class3.method_4<IntPtr>();
					RecoveredRuntime.smethod_226(class3, -1);
					IntPtr intPtr2 = base.method_21<IntPtr>(class3);
					NativeTypes.Enum34 enum34_;
					this.vmethod_3(class4.method_17(), (long)RecoveredRuntime.smethod_73(base.method_19()), NativeTypes.Enum34.flag_2, out enum34_);
					bool result = base.method_13<int>(class4.method_17(), intPtr2.ToInt32());
					this.vmethod_3(class4.method_17(), (long)RecoveredRuntime.smethod_73(base.method_19()), enum34_, out enum34_);
					return result;
				}
				else
				{
					num2++;
				}
			}
			return false;
		}
		return false;
	}
}
