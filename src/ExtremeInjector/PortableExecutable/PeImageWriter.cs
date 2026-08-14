using System.Collections.Generic;
using System.IO;
using System.Text;

public sealed class PeImageWriter
{
	internal PeImage class154_0;

	internal BinaryWriter binaryWriter_0;

	internal Stream stream_0;

	public PeImageWriter(PeImage class154_1)
	{
		this.class154_0 = class154_1;
	}

	internal void method_0()
	{
		foreach (PeSectionHeader gclass in this.class154_0.method_8())
		{
			this.binaryWriter_0.Write(Encoding.ASCII.GetBytes(gclass.method_0().PadRight(8, '\0')));
			this.binaryWriter_0.Write(gclass.method_2());
			this.binaryWriter_0.Write(gclass.method_4());
			this.binaryWriter_0.Write(gclass.method_6());
			this.binaryWriter_0.Write(gclass.method_8());
			this.binaryWriter_0.Write(gclass.method_10());
			this.binaryWriter_0.Write(gclass.method_12());
			this.binaryWriter_0.Write(gclass.method_14());
			this.binaryWriter_0.Write(gclass.method_16());
			this.binaryWriter_0.Write((uint)gclass.method_18());
		}
	}

	internal static Encoding smethod_0()
	{
		return Encoding.ASCII;
	}

	internal static string smethod_1(string string_0, int int_0, char char_0)
	{
		return string_0.PadRight(int_0, char_0);
	}

	internal static byte[] smethod_2(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	internal static void smethod_3(BinaryWriter binaryWriter_1, byte[] byte_0)
	{
		binaryWriter_1.Write(byte_0);
	}

	internal static void smethod_4(BinaryWriter binaryWriter_1, uint uint_0)
	{
		binaryWriter_1.Write(uint_0);
	}

	internal static void smethod_5(BinaryWriter binaryWriter_1, ushort ushort_0)
	{
		binaryWriter_1.Write(ushort_0);
	}
}
