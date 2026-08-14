using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitMemoryOperand : AsmJitOperand
{
	public AsmJitMemoryOperand()
		: base(AsmJitRuntime.uninitializedOperandTag)
	{
		AsmJitOperand.MemoryOperandData struct11_ = RecoveredRuntime.GetMemoryOperandData(this);
		struct11_.operandType = AsmJitOperandType.Memory;
		struct11_.byteValue = 0;
		struct11_.memoryType = AsmJitMemoryType.Native;
		struct11_.SetAddressingFlag(false);
		struct11_.SetScaleShift(0);
		struct11_.uintValue = AsmJitRuntime.uintValue;
		struct11_.uintValue2 = AsmJitRuntime.uintValue;
		struct11_.uintValue3 = AsmJitRuntime.uintValue;
		struct11_.address = IntPtr.Zero;
		struct11_.address2 = IntPtr.Zero;
		RecoveredRuntime.SetMemoryOperandData(struct11_, this);
	}

	public override bool Equals(object obj)
	{
		AsmJitMemoryOperand @class = obj as AsmJitMemoryOperand;
		if (RecoveredRuntime.MemoryOperandsEqual(@class, null))
		{
			return false;
		}
		AsmJitOperand.RawOperandData @struct = base.GetRawData();
		AsmJitOperand.RawOperandData struct2 = @class.GetRawData();
		return @struct.uintValueArray[0] == struct2.uintValueArray[0] && @struct.uintValueArray[1] == struct2.uintValueArray[1] && @struct.uintValueArray[2] == struct2.uintValueArray[2] && @struct.uintValueArray[3] == struct2.uintValueArray[3] && @struct.addresses[0] == struct2.addresses[0] && @struct.addresses[1] == struct2.addresses[1];
	}

	public override int GetHashCode()
	{
		RawOperandData @struct = GetRawData();
		return ((int)((((@struct.uintValueArray[0] * 397 + @struct.uintValueArray[1]) * 397 + @struct.uintValueArray[2]) * 397 + @struct.uintValueArray[3]) * 397) + (int)@struct.addresses[0]) * 397 + (int)@struct.addresses[1];
	}
}
