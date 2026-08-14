using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public class AsmJitRegister : AsmJitOperand
{
	public AsmJitRegister(uint uint_0, uint uint_1)
		: base(AsmJitRuntime.struct20_0)
	{
		AsmJitOperand.Struct9 struct9_ = RecoveredRuntime.GetRegisterOperandData(this);
		struct9_.enum8_0 = AsmJitOperandType.flag_1;
		struct9_.byte_0 = (byte)uint_1;
		struct9_.uint_0 = AsmJitRuntime.uint_0;
		struct9_.uint_1 = uint_0;
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
