using System.Collections.Generic;
using System.IO;

public sealed class ExceptionDirectory
{
	public List<RuntimeFunctionEntry> list_0 = new List<RuntimeFunctionEntry>();

	internal ExceptionDirectory(BoundsCheckedBinaryReader class5_0, DataDirectory class157_0)
	{
		int num = 0;
		while ((long)num < (long)((ulong)(class157_0.GetSize() / 12u)))
		{
			List<RuntimeFunctionEntry> list = this.list_0;
			RuntimeFunctionEntry @class = new RuntimeFunctionEntry();
			@class.SetBeginAddress(class5_0.ReadUInt32());
			@class.SetEndAddress(class5_0.ReadUInt32());
			@class.SetUnwindInfoAddress(class5_0.ReadUInt32());
			list.Add(@class);
			num++;
		}
	}
}
