using System.Collections.Generic;
using System.IO;

public sealed class ExceptionDirectory
{
	public List<RuntimeFunctionEntry> list_0 = new List<RuntimeFunctionEntry>();

	internal ExceptionDirectory(BoundsCheckedBinaryReader class5_0, DataDirectory class157_0)
	{
		int num = 0;
		while ((long)num < (long)((ulong)(class157_0.method_2() / 12u)))
		{
			List<RuntimeFunctionEntry> list = this.list_0;
			RuntimeFunctionEntry @class = new RuntimeFunctionEntry();
			@class.method_1(class5_0.ReadUInt32());
			@class.method_3(class5_0.ReadUInt32());
			@class.method_5(class5_0.ReadUInt32());
			list.Add(@class);
			num++;
		}
	}

	internal static uint smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}
}
