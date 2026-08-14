using System;
using System.IO;
using System.Reflection;

namespace ns0;

public static class GClass7
{
	private static Delegate50 delegate50_0;

	public static void smethod_0()
	{
		try
		{
			using FileStream fileStream = new FileStream(string.IsNullOrEmpty(Assembly.GetExecutingAssembly().Location) ? Assembly.GetEntryAssembly().Location : Assembly.GetExecutingAssembly().Location, FileMode.Open, FileAccess.Read, FileShare.Read);
			using BinaryReader binaryReader_ = new BinaryReader(fileStream);
			smethod_1(fileStream, binaryReader_);
		}
		catch
		{
			Environment.FailFast(null);
		}
	}

	private static void smethod_1(FileStream fileStream_0, BinaryReader binaryReader_0)
	{
		if (delegate50_0 == null)
		{
			delegate50_0 = (Delegate50)Class187.smethod_2(0).CreateDelegate(typeof(Delegate50));
		}
		delegate50_0(fileStream_0, binaryReader_0);
	}
}
