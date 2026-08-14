using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitImmediate : AsmJitOperand
{
	public AsmJitImmediate()
		: base(AsmJitRuntime.struct20_0)
	{
		AsmJitOperand.Struct12 struct12_ = RecoveredRuntime.smethod_219(this);
		struct12_.enum8_0 = AsmJitOperandType.flag_3;
		struct12_.byte_0 = 0;
		struct12_.bool_0 = false;
		struct12_.byte_1 = 0;
		struct12_.uint_0 = AsmJitRuntime.uint_0;
		struct12_.intptr_0 = IntPtr.Zero;
		RecoveredRuntime.smethod_150(this, struct12_);
	}

	public AsmJitImmediate(IntPtr intptr_0)
		: base(AsmJitRuntime.struct20_0)
	{
		AsmJitOperand.Struct12 struct12_ = RecoveredRuntime.smethod_219(this);
		struct12_.enum8_0 = AsmJitOperandType.flag_3;
		struct12_.byte_0 = 0;
		struct12_.bool_0 = false;
		struct12_.byte_1 = 0;
		struct12_.uint_0 = AsmJitRuntime.uint_0;
		struct12_.intptr_0 = intptr_0;
		RecoveredRuntime.smethod_150(this, struct12_);
	}

	public AsmJitImmediate(IntPtr intptr_0, bool bool_0)
		: base(AsmJitRuntime.struct20_0)
	{
		AsmJitOperand.Struct12 struct12_ = RecoveredRuntime.smethod_219(this);
		struct12_.enum8_0 = AsmJitOperandType.flag_3;
		struct12_.byte_0 = 0;
		struct12_.bool_0 = bool_0;
		struct12_.byte_1 = 0;
		struct12_.uint_0 = AsmJitRuntime.uint_0;
		struct12_.intptr_0 = intptr_0;
		RecoveredRuntime.smethod_150(this, struct12_);
	}
}
