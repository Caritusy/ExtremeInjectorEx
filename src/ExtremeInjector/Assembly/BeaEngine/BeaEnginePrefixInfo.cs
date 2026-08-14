using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct BeaEnginePrefixInfo
{
	[StructLayout(LayoutKind.Sequential, Size = 2)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct PrefixBytes
	{
		public byte byteValue;
	}

	public int intValue;

	public int intValue2;

	public byte byteValue;

	public byte byteValue2;

	public byte byteValue3;

	public byte byteValue4;

	public byte byteValue5;

	public byte byteValue6;

	public byte byteValue7;

	public byte byteValue8;

	public byte byteValue9;

	public byte byteValue10;

	public byte byteValue11;

	public byte byteValue12;

	public byte byteValue13;

	public BeaEngineRexPrefix rexPrefix;

	public PrefixBytes prefixBytes;
}
