using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct BeaEngineArgument
{
	[StructLayout(LayoutKind.Sequential, Size = 64)]
	[UnsafeValueType]
	[CompilerGenerated]
	public struct ArgumentTextBuffer
	{
		public sbyte signedByteValue;
	}

	public ArgumentTextBuffer argumentTextBuffer;

	public int intValue;

	public int intValue2;

	public int intValue3;

	public uint uintValue;

	public BeaEngineMemoryOperand memoryOperand;

	public uint uintValue2;
}
