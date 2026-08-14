using System;

public struct AsmJitAssemblerState
{
	// Populated by the native AsmJit API through the structure reference.
#pragma warning disable CS0649
	internal IntPtr address;
#pragma warning restore CS0649

	public AsmJitZone zone;

	public IntPtr address2;

	public IntPtr address3;

	public uint uintValue;

	public uint uintValue2;

	public uint uintValue3;

	public AsmJitCodeBuffer codeBuffer;

	public IntPtr address4;

	public IntPtr address5;

	public AsmJitDataBlock dataBlock;

	public AsmJitDataBlock dataBlock2;

	public IntPtr address6;
}
