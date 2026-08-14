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
		uint num2 = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[5].GetSize();
		while (num < num2)
		{
			BaseRelocationBlock @class = new BaseRelocationBlock();
			@class.SetPageRva(class5_0.ReadUInt32());
			@class.SetBlockSize(class5_0.ReadUInt32());
			BaseRelocationBlock class2 = @class;
			if (class2.GetBlockSize() == 0u)
			{
				break;
			}
			uint num3 = (class2.GetBlockSize() - 8u) / 2u;
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
				class3.SetOffset((uint)(num5 & 4095));
				class3.SetType((BaseRelocationType)(num5 >> 12));
				list.Add(class3);
				num4++;
			}
			this.list_0.Add(class2);
			num += class2.GetBlockSize();
		}
	}
}
