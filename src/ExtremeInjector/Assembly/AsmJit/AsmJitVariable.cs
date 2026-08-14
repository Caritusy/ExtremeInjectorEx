using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public class AsmJitVariable : AsmJitOperand
{
	public AsmJitVariable()
		: base(AsmJitRuntime.uninitializedOperandTag)
	{
		VariableOperandData struct14_ = RecoveredRuntime.GetVariableOperandData(this);
		struct14_.operandType = AsmJitOperandType.Variable;
		struct14_.byteValue = 0;
		struct14_.uintValue2 = AsmJitRuntime.uintValue;
		struct14_.variableType = AsmJitVariableType.Invalid;
		struct14_.uintValue = AsmJitRuntime.uintValue;
		RecoveredRuntime.SetVariableOperandData(struct14_, this);
	}

	internal AsmJitVariable(AsmJitUninitializedOperandTag uninitializedOperandTag)
		: base(uninitializedOperandTag)
	{
	}
}
