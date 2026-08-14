using System;

[Flags]
public enum CoffCharacteristics : ushort
{
	AggressiveWorkingSetTrim = 0x10,
	BytesReversedLow = 0x80,
	Dll = 0x2000,
	BytesReversedHigh = 0x8000
}
