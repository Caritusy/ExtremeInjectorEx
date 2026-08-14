using System.Collections.Generic;
using System.IO;

public sealed class BaseRelocationDirectory
{
	public List<BaseRelocationBlock> list_0 = new List<BaseRelocationBlock>();

	public BaseRelocationDirectory()
	{
		list_0 = new List<BaseRelocationBlock>();
	}

	public BaseRelocationDirectory(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		uint num = 0u;
		uint num2 = class154_0.method_6().method_3().imethod_49()[5].method_2();
		while (num < num2)
		{
			BaseRelocationBlock @class = new BaseRelocationBlock();
			@class.method_1(class5_0.ReadUInt32());
			@class.method_3(class5_0.ReadUInt32());
			BaseRelocationBlock class2 = @class;
			if (class2.method_2() == 0u)
			{
				break;
			}
			uint num3 = (class2.method_2() - 8u) / 2u;
			if (class5_0.BaseStream.Position + (long)((ulong)(num3 * 2u)) >= class5_0.BaseStream.Length)
			{
				break;
			}
			int num4 = 0;
			while ((long)num4 < (long)((ulong)num3))
			{
				ushort num5 = class5_0.ReadUInt16();
				List<BaseRelocationEntry> list = class2.list_0;
				BaseRelocationEntry class3 = new BaseRelocationEntry();
				class3.method_1((uint)(num5 & 4095));
				class3.method_3((BaseRelocationType)(num5 >> 12));
				list.Add(class3);
				num4++;
			}
			this.list_0.Add(class2);
			num += class2.method_2();
		}
	}

	internal static uint smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static Stream smethod_1(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static long smethod_2(Stream stream_0)
	{
		return stream_0.Position;
	}

	internal static long smethod_3(Stream stream_0)
	{
		return stream_0.Length;
	}

	internal static ushort smethod_4(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt16();
	}
}
