using System;
using System.Collections.Generic;
using System.IO;

public class PeImageReader : BoundsCheckedBinaryReader
{
	protected readonly PeImage class154_0;

	protected PeImageReader(Stream stream_0, bool bool_0, PeImageLayout enum39_0)
		: base(stream_0)
	{
		class154_0 = new PeImage(stream_0, bool_0, enum39_0);
	}

	protected PeImageReader(Stream stream_0, string string_0, bool bool_0, PeImageLayout enum39_0)
		: base(stream_0)
	{
		PeImage @class = new PeImage(stream_0, bool_0, enum39_0);
		@class.method_1(Path.GetFullPath(string_0));
		@class.method_3(Path.GetFileName(string_0));
		class154_0 = @class;
	}

	protected virtual bool vmethod_0()
	{
		if (vmethod_1())
		{
			while (true)
			{
				int num = -2078205236;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1144005282)) % 5)
					{
					case 3u:
						num = ((int)num2 * -1857402248) ^ 0x63DAD123;
						continue;
					case 1u:
						method_0040();
						num = ((int)num2 * -365603818) ^ 0x1613F04;
						continue;
					case 2u:
						break;
					default:
						return true;
					case 0u:
						goto end_IL_0051;
					}
					break;
				}
				continue;
				end_IL_0051:
				break;
			}
		}
		return false;
	}

	protected virtual bool vmethod_1()
	{
		long imageStart = BaseStream.Position;
		DosHeader dosHeader = null;
		if (!RecoveredRuntime.smethod_444(ref dosHeader, this))
		{
			return false;
		}

		class154_0.method_5(dosHeader);
		BaseStream.Position = imageStart + dosHeader.method_0();

		PeHeaders peHeaders = null;
		if (!RecoveredRuntime.smethod_271(ref peHeaders, this))
		{
			return false;
		}

		class154_0.method_7(peHeaders);
		var sections = new List<PeSectionHeader>(peHeaders.method_1().method_2());
		class154_0.method_9(sections);
		for (int index = 0; index < peHeaders.method_1().method_2(); index++)
		{
			sections.Add(new PeSectionHeader(this));
		}

		return true;
	}

	protected virtual void method_0040()
	{
		class154_0.method_11(RecoveredRuntime.smethod_24(class154_0, this));
		while (true)
		{
			int num = -1114270337;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -666036086)) % 6)
				{
				case 5u:
					class154_0.method_17(RecoveredRuntime.smethod_230(class154_0, this));
					class154_0.method_24(RecoveredRuntime.smethod_389(class154_0, this));
					num = ((int)num2 * -283194504) ^ -234416842;
					continue;
				case 4u:
					class154_0.method_19(RecoveredRuntime.smethod_3(class154_0, this));
					class154_0.method_21(RecoveredRuntime.smethod_160(class154_0, this));
					num = (int)(num2 * 179370146) ^ -1990977517;
					continue;
				case 3u:
					class154_0.method_22(RecoveredRuntime.smethod_92(this, class154_0));
					num = ((int)num2 * -1943216389) ^ 0x3F42EF79;
					continue;
				case 1u:
					class154_0.method_13(RecoveredRuntime.smethod_293(this, class154_0));
					class154_0.method_15(RecoveredRuntime.smethod_355(class154_0, this));
					num = (int)(num2 * 56922965) ^ -1121016948;
					continue;
				case 0u:
					break;
				default:
					class154_0.method_26(RecoveredRuntime.smethod_303(class154_0, this));
					class154_0.method_27(RecoveredRuntime.smethod_312(class154_0, this));
					return;
				}
				break;
			}
		}
	}

	public static PeImage smethod_4(Stream stream_0, bool bool_0, PeImageLayout enum39_0)
	{
		PeImageReader @class = new PeImageReader(stream_0, bool_0, enum39_0);
		if (!@class.vmethod_0())
		{
			return null;
		}
		return @class.class154_0;
	}

	public static PeImage smethod_5(Stream stream_0, string string_0, bool bool_0, PeImageLayout enum39_0)
	{
		PeImageReader @class = new PeImageReader(stream_0, string_0, bool_0, enum39_0);
		while (true)
		{
			int num = 897564176;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x265914B1)) % 4)
				{
				case 1u:
					num3 = (@class.vmethod_0() ? (-907521054) : (-993323525));
					goto IL_002a;
				case 0u:
					break;
				case 2u:
					return null;
				default:
					return @class.class154_0;
				}
				break;
				IL_002a:
				num = num3 ^ ((int)num2 * -1914426056);
			}
		}
	}

	internal static string smethod_6(string string_0)
	{
		return Path.GetFullPath(string_0);
	}

	internal static string smethod_7(string string_0)
	{
		return Path.GetFileName(string_0);
	}

	internal static Stream smethod_8(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static long smethod_9(Stream stream_0)
	{
		return stream_0.Position;
	}

	internal static void smethod_10(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

}
