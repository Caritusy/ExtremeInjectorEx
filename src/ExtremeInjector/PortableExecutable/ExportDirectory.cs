using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class ExportDirectory
{
	public List<string> list_0 = new List<string>();

	public List<ExportedSymbol> list_1 = new List<ExportedSymbol>();

	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal ushort ushort_0;

	[CompilerGenerated]
	internal ushort ushort_1;

	[CompilerGenerated]
	internal uint uint_2;

	[CompilerGenerated]
	internal uint uint_3;

	[CompilerGenerated]
	internal uint uint_4;

	[CompilerGenerated]
	internal uint uint_5;

	[CompilerGenerated]
	internal uint uint_6;

	[CompilerGenerated]
	internal uint uint_7;

	[CompilerGenerated]
	internal uint uint_8;

	[SpecialName]
	[CompilerGenerated]
	public void method_0(uint uint_9)
	{
		uint_0 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(uint uint_9)
	{
		uint_1 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_2(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_4(uint uint_9)
	{
		uint_2 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_5()
	{
		return uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_6(uint uint_9)
	{
		uint_3 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_7()
	{
		return uint_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_8(uint uint_9)
	{
		uint_4 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_9()
	{
		return uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_10(uint uint_9)
	{
		uint_5 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_11()
	{
		return uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_12(uint uint_9)
	{
		uint_6 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_13()
	{
		return uint_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_14(uint uint_9)
	{
		uint_7 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_15()
	{
		return uint_8;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_16(uint uint_9)
	{
		uint_8 = uint_9;
	}

	internal ExportDirectory(BoundsCheckedBinaryReader class5_0, PeImage class154_0, DataDirectory class157_0)
	{
		this.method_0(class5_0.ReadUInt32());
		this.method_1(class5_0.ReadUInt32());
		this.method_2(class5_0.ReadUInt16());
		this.method_3(class5_0.ReadUInt16());
		this.method_4(class5_0.ReadUInt32());
		this.method_6(class5_0.ReadUInt32());
		this.method_8(class5_0.ReadUInt32());
		this.method_10(class5_0.ReadUInt32());
		this.method_12(class5_0.ReadUInt32());
		this.method_14(class5_0.ReadUInt32());
		this.method_16(class5_0.ReadUInt32());
		long num = RecoveredRuntime.smethod_135(class154_0, this.method_13());
		long num2 = RecoveredRuntime.smethod_135(class154_0, this.method_15());
		long num3 = RecoveredRuntime.smethod_135(class154_0, this.method_11());
		if (num != -1L && num2 != -1L && num3 != -1L && class5_0.imethod_0(num) && class5_0.imethod_0(num2) && class5_0.imethod_0(num3))
		{
			RecoveredRuntime.smethod_157(class5_0, num);
			bool[] array = new bool[this.method_7()];
			for (uint num4 = 0u; num4 < this.method_9(); num4 += 1u)
			{
				RecoveredRuntime.smethod_157(class5_0, num + (long)((ulong)(num4 * 4u)));
				long num5 = RecoveredRuntime.smethod_135(class154_0, class5_0.ReadUInt32());
				if (num5 != -1L && class5_0.imethod_0(num5))
				{
					RecoveredRuntime.smethod_157(class5_0, num5);
					string text = RecoveredRuntime.smethod_404(class5_0);
					this.list_0.Add(text);
					RecoveredRuntime.smethod_157(class5_0, num2 + (long)((ulong)(num4 * 2u)));
					ushort num6 = class5_0.ReadUInt16();
					RecoveredRuntime.smethod_157(class5_0, num3 + (long)(num6 * 4));
					uint num7 = class5_0.ReadUInt32();
					ForwardedExport @class = null;
					long num8 = -1L;
					if (num7 >= class157_0.method_0() && num7 < class157_0.method_0() + class157_0.method_2())
					{
						num8 = class5_0.BaseStream.Position;
						long long_ = RecoveredRuntime.smethod_135(class154_0, num7);
						RecoveredRuntime.smethod_157(class5_0, long_);
						@class = new ForwardedExport();
						string text2 = RecoveredRuntime.smethod_404(class5_0);
						@class.method_1(text2.Substring(0, text2.LastIndexOf('.')) + EncodedStringTable.smethod_0(10075));
						int num9 = text2.LastIndexOf('.') + 1;
						string text3 = text2.Substring(num9, text2.Length - num9);
						if (text2.Contains(EncodedStringTable.smethod_0(10084)))
						{
							@class.method_5(ushort.Parse(text3.Substring(1)));
						}
						else
						{
							@class.method_7(text3);
							@class.method_3(true);
						}
					}
					if (num8 != -1L)
					{
						RecoveredRuntime.smethod_157(class5_0, num8);
					}
					array[(int)num6] = true;
					ExportedSymbol class2 = new ExportedSymbol();
					class2.method_1(true);
					class2.method_5(text);
					class2.method_3((ushort)((uint)num6 + this.method_5()));
					class2.method_7(num7);
					class2.method_9(@class);
					ExportedSymbol item = class2;
					this.list_1.Add(item);
				}
			}
			for (uint num10 = 0u; num10 < this.method_7(); num10 += 1u)
			{
				if (!array[(int)num10])
				{
					RecoveredRuntime.smethod_157(class5_0, num3 + (long)((ulong)(num10 * 4u)));
					uint num11 = class5_0.ReadUInt32();
					ExportedSymbol class3 = new ExportedSymbol();
					class3.method_3((ushort)(num10 + this.method_5()));
					class3.method_7(num11);
					ExportedSymbol item2 = class3;
					this.list_1.Add(item2);
				}
			}
			return;
		}
	}

	internal static uint smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static ushort smethod_1(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt16();
	}

	internal static Stream smethod_2(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static long smethod_3(Stream stream_0)
	{
		return stream_0.Position;
	}

	internal static int smethod_4(string string_0, char char_0)
	{
		return string_0.LastIndexOf(char_0);
	}

	internal static string smethod_5(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	internal static string smethod_6(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static int smethod_7(string string_0)
	{
		return string_0.Length;
	}

	internal static bool smethod_8(string string_0, string string_1)
	{
		return string_0.Contains(string_1);
	}

	internal static string smethod_9(string string_0, int int_0)
	{
		return string_0.Substring(int_0);
	}
}
