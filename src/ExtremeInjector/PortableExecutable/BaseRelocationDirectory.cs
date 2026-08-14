using System.Collections.Generic;
using System.IO;

public sealed class BaseRelocationDirectory
{
	public List<BaseRelocationBlock> items = new List<BaseRelocationBlock>();

	public BaseRelocationDirectory()
	{
		items = new List<BaseRelocationBlock>();
	}

	public BaseRelocationDirectory(BoundsCheckedBinaryReader boundsCheckedBinaryReader, PeImage peImage)
	{
		uint num = 0u;
		uint num2 = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[5].GetSize();
		while (num < num2)
		{
			BaseRelocationBlock @class = new BaseRelocationBlock();
			@class.SetPageRva(boundsCheckedBinaryReader.ReadUInt32());
			@class.SetBlockSize(boundsCheckedBinaryReader.ReadUInt32());
			BaseRelocationBlock class2 = @class;
			if (class2.GetBlockSize() == 0u)
			{
				break;
			}
			uint num3 = (class2.GetBlockSize() - 8u) / 2u;
			if (boundsCheckedBinaryReader.BaseStream.Position + (long)((ulong)(num3 * 2u)) >= boundsCheckedBinaryReader.BaseStream.Length)
			{
				break;
			}
			int num4 = 0;
			while ((long)num4 < (long)((ulong)num3))
			{
				ushort num5 = boundsCheckedBinaryReader.ReadUInt16();
				List<BaseRelocationEntry> list = class2.items;
				BaseRelocationEntry class3 = new BaseRelocationEntry();
				class3.SetOffset((uint)(num5 & 4095));
				class3.SetType((BaseRelocationType)(num5 >> 12));
				list.Add(class3);
				num4++;
			}
			this.items.Add(class2);
			num += class2.GetBlockSize();
		}
	}
}
