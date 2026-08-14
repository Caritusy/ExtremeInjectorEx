using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitMemoryOperand : AsmJitOperand
{
	public AsmJitMemoryOperand()
		: base(AsmJitRuntime.struct20_0)
	{
		AsmJitOperand.Struct11 struct11_ = RecoveredRuntime.GetMemoryOperandData(this);
		struct11_.enum8_0 = AsmJitOperandType.flag_2;
		struct11_.byte_0 = 0;
		struct11_.enum9_0 = AsmJitMemoryType.const_0;
		struct11_.SetAddressingFlag(false);
		struct11_.SetScaleShift(0);
		struct11_.uint_0 = AsmJitRuntime.uint_0;
		struct11_.uint_1 = AsmJitRuntime.uint_0;
		struct11_.uint_2 = AsmJitRuntime.uint_0;
		struct11_.intptr_0 = IntPtr.Zero;
		struct11_.intptr_1 = IntPtr.Zero;
		RecoveredRuntime.SetMemoryOperandData(struct11_, this);
	}

	public override bool Equals(object obj)
	{
		AsmJitMemoryOperand @class = obj as AsmJitMemoryOperand;
		if (RecoveredRuntime.MemoryOperandsEqual(@class, null))
		{
			return false;
		}
		AsmJitOperand.Struct7 @struct = base.GetRawData();
		AsmJitOperand.Struct7 struct2 = @class.GetRawData();
		return @struct.uint_0[0] == struct2.uint_0[0] && @struct.uint_0[1] == struct2.uint_0[1] && @struct.uint_0[2] == struct2.uint_0[2] && @struct.uint_0[3] == struct2.uint_0[3] && @struct.intptr_0[0] == struct2.intptr_0[0] && @struct.intptr_0[1] == struct2.intptr_0[1];
	}

	public override int GetHashCode()
	{
		Struct7 @struct = GetRawData();
		return ((int)((((@struct.uint_0[0] * 397 + @struct.uint_0[1]) * 397 + @struct.uint_0[2]) * 397 + @struct.uint_0[3]) * 397) + (int)@struct.intptr_0[0]) * 397 + (int)@struct.intptr_0[1];
	}
}
