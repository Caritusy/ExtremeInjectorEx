using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct BeaEngineDisasm
{
	[StructLayout(LayoutKind.Sequential, Size = 64)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct Struct32
	{
		public sbyte sbyte_0;
	}

	[StructLayout(LayoutKind.Sequential, Size = 160)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct Struct33
	{
		public uint uint_0;
	}

	public unsafe byte* pByte_0;

	public ulong ulong_0;

	public uint uint_0;

	public Struct32 struct32_0;

	public uint uint_1;

	public ulong ulong_1;

	public BeaEngineInstruction struct27_0;

	public BeaEngineArgument struct29_0;

	public BeaEngineArgument struct29_1;

	public BeaEngineArgument struct29_2;

	public BeaEnginePrefixInfo struct23_0;

	public Struct33 struct33_0;
}
