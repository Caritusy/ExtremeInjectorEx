using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public class AsmJitRegister : AsmJitOperand
{
	public AsmJitRegister(uint uintValue, uint uintValue2)
		: base(AsmJitRuntime.uninitializedOperandTag)
	{
		AsmJitOperand.ImmediateOperandData struct9_ = RecoveredRuntime.GetRegisterOperandData(this);
		struct9_.operandType = AsmJitOperandType.Register;
		struct9_.byteValue = (byte)uintValue2;
		struct9_.uintValue = AsmJitRuntime.uintValue;
		struct9_.uintValue2 = uintValue;
		RecoveredRuntime.SetRegisterOperandData(this, struct9_);
	}

	public override bool Equals(object obj)
	{
		AsmJitRegister @class = obj as AsmJitRegister;
		return !RecoveredRuntime.RegistersEqual(null, @class) && RecoveredRuntime.GetRegisterId(this) == RecoveredRuntime.GetRegisterId(@class);
	}

	public override int GetHashCode()
	{
		return RecoveredRuntime.GetRegisterId(this).GetHashCode();
	}
}
