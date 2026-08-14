using System.IO;
using System.Runtime.CompilerServices;

internal sealed class Class159
{
	[CompilerGenerated]
	private Enum40 enum40_0;

	[CompilerGenerated]
	private ushort ushort_0;

	[CompilerGenerated]
	private uint uint_0;

	[CompilerGenerated]
	private uint uint_1;

	[CompilerGenerated]
	private uint uint_2;

	[CompilerGenerated]
	private ushort ushort_1;

	[CompilerGenerated]
	private Enum36 enum36_0;

	[SpecialName]
	[CompilerGenerated]
	public Enum40 method_0()
	{
		return enum40_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(Enum40 enum40_1)
	{
		enum40_0 = enum40_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort method_2()
	{
		return ushort_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_4()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(uint uint_3)
	{
		uint_0 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_6()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(uint uint_3)
	{
		uint_1 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_8()
	{
		return uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(uint uint_3)
	{
		uint_2 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort method_10()
	{
		return ushort_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Enum36 method_12()
	{
		return enum36_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_13(Enum36 enum36_1)
	{
		enum36_0 = enum36_1;
	}

	public Class159()
	{
	}

	public Class159(BinaryReader binaryReader_0)
	{
		while (true)
		{
			int num = 1388187943;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x14173F55)) % 5)
				{
				case 4u:
					method_1((Enum40)binaryReader_0.ReadUInt16());
					method_3(binaryReader_0.ReadUInt16());
					num = (int)((num2 * 389654741) ^ 0x4503E34F);
					continue;
				case 2u:
					method_7(binaryReader_0.ReadUInt32());
					method_9(binaryReader_0.ReadUInt32());
					method_11(binaryReader_0.ReadUInt16());
					num = ((int)num2 * -862691565) ^ 0x7E421306;
					continue;
				case 0u:
					method_5(binaryReader_0.ReadUInt32());
					num = (int)((num2 * 221832006) ^ 0x2A730908);
					continue;
				case 3u:
					break;
				default:
					method_13((Enum36)binaryReader_0.ReadUInt16());
					return;
				}
				break;
			}
		}
	}
}
