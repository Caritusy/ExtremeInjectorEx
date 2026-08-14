using System.IO;
using System.Runtime.CompilerServices;

public sealed class DataDirectory
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[SpecialName]
	[CompilerGenerated]
	public uint method_0()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(uint uint_2)
	{
		uint_0 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_2()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(uint uint_2)
	{
		uint_1 = uint_2;
	}

	public DataDirectory()
	{
	}

	public DataDirectory(BinaryReader binaryReader_0)
	{
		while (true)
		{
			int num = 2090940269;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x248C4727)) % 3)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					method_3(binaryReader_0.ReadUInt32());
					return;
				}
				break;
				IL_0008:
				method_1(binaryReader_0.ReadUInt32());
				num = ((int)num2 * -364552290) ^ 0x3562F45B;
			}
		}
	}

	internal static uint smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}
}
