using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct BeaEngineArgument
{
	[StructLayout(LayoutKind.Sequential, Size = 64)]
	[UnsafeValueType]
	[CompilerGenerated]
	public struct Struct30
	{
		public sbyte sbyte_0;
	}

	public Struct30 struct30_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public uint uint_0;

	public BeaEngineMemoryOperand struct26_0;

	public uint uint_1;
}
