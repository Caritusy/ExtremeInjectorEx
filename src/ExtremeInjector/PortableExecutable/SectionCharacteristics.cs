using System;

[Flags]
public enum SectionCharacteristics : uint
{
	Code = 0x20u,
	InitializedData = 0x40u,
	UninitializedData = 0x80u,
	Align1Byte = 0x100000u,
	Align2Bytes = 0x200000u,
	Align8Bytes = 0x400000u,
	Discardable = 0x2000000u,
	NotCached = 0x4000000u,
	Execute = 0x20000000u,
	Read = 0x40000000u,
	Write = 0x80000000u
}
