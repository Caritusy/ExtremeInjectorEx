using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitImmediate : AsmJitOperand
{
	public AsmJitImmediate()
		: base(AsmJitRuntime.uninitializedOperandTag)
	{
		AsmJitOperand.LabelOperandData struct12_ = RecoveredRuntime.GetImmediateOperandData(this);
		struct12_.operandType = AsmJitOperandType.Immediate;
		struct12_.byteValue = 0;
		struct12_.flag = false;
		struct12_.byteValue2 = 0;
		struct12_.uintValue = AsmJitRuntime.uintValue;
		struct12_.address = IntPtr.Zero;
		RecoveredRuntime.SetImmediateOperandData(this, struct12_);
	}

	public AsmJitImmediate(IntPtr address)
		: base(AsmJitRuntime.uninitializedOperandTag)
	{
		AsmJitOperand.LabelOperandData struct12_ = RecoveredRuntime.GetImmediateOperandData(this);
		struct12_.operandType = AsmJitOperandType.Immediate;
		struct12_.byteValue = 0;
		struct12_.flag = false;
		struct12_.byteValue2 = 0;
		struct12_.uintValue = AsmJitRuntime.uintValue;
		struct12_.address = address;
		RecoveredRuntime.SetImmediateOperandData(this, struct12_);
	}

	public AsmJitImmediate(IntPtr address, bool flag)
		: base(AsmJitRuntime.uninitializedOperandTag)
	{
		AsmJitOperand.LabelOperandData struct12_ = RecoveredRuntime.GetImmediateOperandData(this);
		struct12_.operandType = AsmJitOperandType.Immediate;
		struct12_.byteValue = 0;
		struct12_.flag = flag;
		struct12_.byteValue2 = 0;
		struct12_.uintValue = AsmJitRuntime.uintValue;
		struct12_.address = address;
		RecoveredRuntime.SetImmediateOperandData(this, struct12_);
	}
}
