using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Struct27
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct Struct28
	{
		public sbyte sbyte_0;
	}

	public int int_0;

	public int int_1;

	public Struct28 struct28_0;

	public int int_2;

	public Struct25 struct25_0;

	public ulong ulong_0;

	public long long_0;

	public uint uint_0;

	[SpecialName]
	public unsafe string method_0()
	{
		fixed (sbyte* pSbyte_ = &struct28_0.sbyte_0)
		{
			return smethod_0(pSbyte_);
		}
	}

	internal unsafe static string smethod_0(sbyte* pSbyte_0)
	{
		return new string(pSbyte_0);
	}
}
