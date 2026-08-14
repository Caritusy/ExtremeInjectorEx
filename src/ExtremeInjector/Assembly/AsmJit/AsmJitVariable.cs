using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public class AsmJitVariable : AsmJitOperand
{
	public AsmJitVariable()
		: base(AsmJitRuntime.struct20_0)
	{
		Struct14 struct14_ = RecoveredRuntime.smethod_403(this);
		struct14_.enum8_0 = AsmJitOperandType.flag_5;
		struct14_.byte_0 = 0;
		struct14_.uint_1 = AsmJitRuntime.uint_0;
		struct14_.enum11_0 = AsmJitVariableType.const_14;
		struct14_.uint_0 = AsmJitRuntime.uint_0;
		RecoveredRuntime.smethod_57(struct14_, this);
	}

	internal AsmJitVariable(AsmJitUninitializedOperandTag struct20_0)
		: base(struct20_0)
	{
	}
}
