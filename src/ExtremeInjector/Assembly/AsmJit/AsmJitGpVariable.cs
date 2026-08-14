using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitGpVariable : AsmJitVariable
{
	public AsmJitGpVariable()
		: base(AsmJitRuntime.struct20_0)
	{
		Struct14 struct14_ = RecoveredRuntime.GetVariableOperandData(this);
		struct14_.enum8_0 = AsmJitOperandType.flag_5;
		struct14_.byte_0 = 0;
		struct14_.uint_1 = AsmJitRuntime.uint_0;
		struct14_.enum11_0 = AsmJitVariableType.const_14;
		struct14_.uint_0 = AsmJitRuntime.uint_0;
		RecoveredRuntime.SetVariableOperandData(struct14_, this);
	}
}
