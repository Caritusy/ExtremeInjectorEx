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
		ushort num5 = default(ushort);
		BaseRelocationBlock @class = default(BaseRelocationBlock);
		int num3 = default(int);
		uint num6 = default(uint);
		uint num7 = default(uint);
		uint num4 = default(uint);
		while (true)
		{
			int num = -73171738;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -121081396)) % 14)
				{
				case 13u:
					num5 = class5_0.ReadUInt16();
					num = -1902201657;
					continue;
				case 11u:
				{
					List<BaseRelocationEntry> list = @class.list_0;
					BaseRelocationEntry class2 = new BaseRelocationEntry();
					class2.method_1((uint)(num5 & 0xFFF));
					class2.method_3((BaseRelocationType)(num5 >> 12));
					list.Add(class2);
					num3++;
					num = ((int)num2 * -727828643) ^ -1558907608;
					continue;
				}
				case 10u:
					num6 = 0u;
					num7 = class154_0.method_6().method_3().imethod_49()[5].method_2();
					num = ((int)num2 * -1599751320) ^ -1520397118;
					continue;
				case 9u:
					num3 = 0;
					num = (int)(num2 * 374391501) ^ -265174047;
					continue;
				case 8u:
					list_0.Add(@class);
					num = ((int)num2 * -1973024639) ^ -1493228291;
					continue;
				case 7u:
				{
					BaseRelocationBlock class3 = new BaseRelocationBlock();
					class3.method_1(class5_0.ReadUInt32());
					class3.method_3(class5_0.ReadUInt32());
					@class = class3;
					num = -192910608;
					continue;
				}
				case 6u:
					num = ((int)num2 * -1358561075) ^ -2143286207;
					continue;
				case 5u:
					num4 = (@class.method_2() - 8) / 2;
					num = ((class5_0.BaseStream.Position + num4 * 2 >= class5_0.BaseStream.Length) ? (-1408135488) : (-93028423)) ^ ((int)num2 * -1308753918);
					continue;
				case 4u:
					num = ((num6 < num7) ? (-1966585975) : (-2092781190));
					continue;
				case 3u:
					num6 += @class.method_2();
					num = (int)((num2 * 629857798) ^ 0x7A21DBEC);
					continue;
				case 2u:
					num = ((@class.method_2() != 0) ? (-1363718071) : (-1212477662)) ^ ((int)num2 * -1598161782);
					continue;
				case 1u:
					num = ((num3 >= num4) ? (-947255480) : (-1452744895));
					continue;
				default:
					return;
				case 0u:
					break;
				case 12u:
					return;
				}
				break;
			}
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
