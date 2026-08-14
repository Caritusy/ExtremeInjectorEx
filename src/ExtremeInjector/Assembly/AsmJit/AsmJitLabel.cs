using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitLabel : AsmJitOperand
{
	public AsmJitLabel()
		: base(AsmJitRuntime.uninitializedOperandTag)
	{
		RegisterOperandData struct13_ = RecoveredRuntime.GetLabelOperandData(this);
		struct13_.operandType = AsmJitOperandType.Label;
		struct13_.byteValue = 0;
		struct13_.uintValue = AsmJitRuntime.uintValue;
		RecoveredRuntime.SetLabelOperandData(struct13_, this);
	}
}
