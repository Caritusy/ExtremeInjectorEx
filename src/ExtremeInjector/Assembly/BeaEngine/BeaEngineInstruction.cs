using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct BeaEngineInstruction
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct MnemonicBuffer
	{
		public sbyte signedByteValue;
	}

	public int intValue;

	public int intValue2;

	public MnemonicBuffer mnemonic;

	public int intValue3;

	public BeaEngineEFlags eFlags;

	public ulong ulongValue;

	public long longValue;

	public uint uintValue;

	[SpecialName]
	public unsafe string GetMnemonic()
	{
		fixed (sbyte* value = &mnemonic.signedByteValue)
		{
			return new string(value);
		}
	}
}
