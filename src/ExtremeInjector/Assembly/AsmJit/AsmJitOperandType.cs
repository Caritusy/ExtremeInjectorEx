using System;

[Flags]
public enum AsmJitOperandType : byte
{
	Register = 1,
	Memory = 2,
	Immediate = 4,
	Label = 8,
	Variable = 0x10
}
