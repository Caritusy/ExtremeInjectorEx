using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct BeaEngineDisasm
{
	[StructLayout(LayoutKind.Sequential, Size = 64)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct CompleteInstructionBuffer
	{
		public sbyte signedByteValue;
	}

	[StructLayout(LayoutKind.Sequential, Size = 160)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct ReservedDisassemblyData
	{
		public uint uintValue;
	}

	public unsafe byte* pointer;

	public ulong ulongValue;

	public uint uintValue;

	public CompleteInstructionBuffer completeInstructionBuffer;

	public uint uintValue2;

	public ulong ulongValue2;

	public BeaEngineInstruction instruction;

	public BeaEngineArgument argument;

	public BeaEngineArgument argument2;

	public BeaEngineArgument argument3;

	public BeaEnginePrefixInfo prefixInfo;

	public ReservedDisassemblyData reservedDisassemblyData;
}
