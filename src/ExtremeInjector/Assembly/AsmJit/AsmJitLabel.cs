using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitLabel : AsmJitOperand
{
	public AsmJitLabel()
		: base(AsmJitRuntime.struct20_0)
	{
		Struct13 struct13_ = RecoveredRuntime.GetLabelOperandData(this);
		struct13_.enum8_0 = AsmJitOperandType.flag_4;
		struct13_.byte_0 = 0;
		struct13_.uint_0 = AsmJitRuntime.uint_0;
		RecoveredRuntime.SetLabelOperandData(struct13_, this);
	}
}
