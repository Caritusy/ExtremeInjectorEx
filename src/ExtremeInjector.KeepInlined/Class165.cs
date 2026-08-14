using System.Collections.Generic;
using System.IO;
using System.Text;

public sealed class Class165
{
	internal Class154 class154_0;

	internal BinaryWriter binaryWriter_0;

	internal Stream stream_0;

	public Class165(Class154 class154_1)
	{
		while (true)
		{
			int num = 1372111580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x28424AD9)) % 3)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				class154_0 = class154_1;
				num = (int)((num2 * 1476897037) ^ 0x3A4807C7);
			}
		}
	}

	internal void method_0()
	{
		using List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator();
		GClass5 current = default(GClass5);
		while (true)
		{
			int num = (enumerator.MoveNext() ? (-15388780) : (-451879597));
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -611651257)) % 12)
				{
				case 11u:
					binaryWriter_0.Write(current.method_14());
					num = ((int)num2 * -338296386) ^ -2023601236;
					continue;
				case 10u:
					num = -15388780;
					continue;
				case 9u:
					binaryWriter_0.Write(current.method_16());
					num = ((int)num2 * -1700207910) ^ 0x3B3541DF;
					continue;
				case 8u:
					binaryWriter_0.Write(current.method_6());
					binaryWriter_0.Write(current.method_8());
					num = (int)(num2 * 789628138) ^ -694170929;
					continue;
				case 7u:
					current = enumerator.Current;
					binaryWriter_0.Write(Encoding.ASCII.GetBytes(current.method_0().PadRight(8, '\0')));
					num = -965724235;
					continue;
				case 6u:
					binaryWriter_0.Write((uint)current.method_18());
					num = (int)(num2 * 36254102) ^ -1542949198;
					continue;
				case 3u:
					binaryWriter_0.Write(current.method_12());
					num = (int)(num2 * 425567313) ^ -197825505;
					continue;
				case 2u:
					binaryWriter_0.Write(current.method_2());
					num = (int)((num2 * 451750893) ^ 0x3E17D33C);
					continue;
				case 1u:
					binaryWriter_0.Write(current.method_4());
					num = (int)((num2 * 1386163833) ^ 0x6951C04A);
					continue;
				case 0u:
					binaryWriter_0.Write(current.method_10());
					num = (int)((num2 * 876093767) ^ 0x6AE0B6A8);
					continue;
				default:
					return;
				case 5u:
					break;
				case 4u:
					return;
				}
				break;
			}
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
