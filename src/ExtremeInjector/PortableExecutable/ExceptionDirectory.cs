using System.Collections.Generic;
using System.IO;

public sealed class ExceptionDirectory
{
	public List<RuntimeFunctionEntry> items = new List<RuntimeFunctionEntry>();

	internal ExceptionDirectory(BoundsCheckedBinaryReader boundsCheckedBinaryReader, DataDirectory dataDirectory)
	{
		int num = 0;
		while ((long)num < (long)((ulong)(dataDirectory.GetSize() / 12u)))
		{
			List<RuntimeFunctionEntry> list = this.items;
			RuntimeFunctionEntry @class = new RuntimeFunctionEntry();
			@class.SetBeginAddress(boundsCheckedBinaryReader.ReadUInt32());
			@class.SetEndAddress(boundsCheckedBinaryReader.ReadUInt32());
			@class.SetUnwindInfoAddress(boundsCheckedBinaryReader.ReadUInt32());
			list.Add(@class);
			num++;
		}
	}
}
