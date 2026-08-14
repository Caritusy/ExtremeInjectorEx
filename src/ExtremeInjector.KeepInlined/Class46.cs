using System;
using System.IO;

public static class Class46
{
	internal static readonly bool bool_0 = IntPtr.Size == 4;

	public static uint smethod_0(this Random random_0)
	{
		return (uint)random_0.Next();
	}

	public static uint smethod_1(this Random random_0, uint uint_0, uint uint_1)
	{
		int num3 = default(int);
		while (true)
		{
			int num = -1856762762;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)(num ^ -263073569)) % 4)
				{
				case 1u:
					num3 = (int)uint_1;
					num4 = ((num3 > (int)uint_0) ? 1470752606 : 800021205);
					goto IL_0020;
				case 2u:
					break;
				case 0u:
					return (uint)random_0.Next(num3, (int)uint_0);
				default:
					return (uint)random_0.Next((int)uint_0, num3);
				}
				break;
				IL_0020:
				num = num4 ^ (int)(num2 * 373355210);
			}
		}
	}

	public static ushort smethod_2(this Random random_0)
	{
		return (ushort)random_0.Next(0, 65536);
	}

	public static byte smethod_3(this Random random_0)
	{
		byte[] array = new byte[1];
		random_0.NextBytes(array);
		return array[0];
	}

	public static string smethod_4(this Stream stream_0)
	{
		FileStream fileStream = stream_0 as FileStream;
		while (true)
		{
			int num = 410239933;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x2A60E4D0)) % 4)
				{
				case 1u:
					num3 = ((fileStream == null) ? 2061718151 : 1290020894);
					goto IL_0022;
				case 0u:
					break;
				case 2u:
					return string.Empty;
				default:
					return Path.GetFullPath(fileStream.Name);
				}
				break;
				IL_0022:
				num = num3 ^ ((int)num2 * -1298918067);
			}
		}
	}

	public static void smethod_5(this Stream stream_0, Stream stream_1, int int_0)
	{
		byte[] array = new byte[int_0];
		int num = 0;
		int num4 = default(int);
		while (true)
		{
			int num2 = 650715372;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x30C5E50C)) % 9)
				{
				case 7u:
					num2 = ((num4 != 0) ? 1351935316 : 1068638417) ^ ((int)num3 * -1595063293);
					continue;
				case 6u:
					int_0 -= num4;
					num2 = ((int)num3 * -1644925591) ^ 0x23C6102F;
					continue;
				case 5u:
					num4 = stream_0.Read(array, num, int_0);
					num2 = 1471333986;
					continue;
				case 4u:
					num += num4;
					num2 = ((int)num3 * -1342494575) ^ -45845877;
					continue;
				case 3u:
					num2 = ((int_0 <= 0) ? 1461093019 : 716312336);
					continue;
				case 2u:
					num2 = (int)((num3 * 2023387537) ^ 0x69493DF2);
					continue;
				case 1u:
					stream_1.Write(array, 0, array.Length);
					num2 = 773438149;
					continue;
				default:
					return;
				case 8u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static void smethod_6(this Stream stream_0, Stream stream_1)
	{
		if (stream_1 == null)
		{
			goto IL_0068;
		}
		goto IL_019c;
		IL_0068:
		int num = -205116861;
		goto IL_0137;
		IL_0137:
		byte[] array = default(byte[]);
		int count = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1704030174)) % 17)
			{
			case 14u:
				num = (stream_0.CanWrite ? (-757720809) : (-260069994)) ^ (int)(num2 * 913383088);
				continue;
			case 11u:
				break;
			case 10u:
				goto end_IL_0137;
			case 9u:
				goto IL_0072;
			case 8u:
				goto IL_0096;
			case 5u:
				array = new byte[81920];
				num = -980872211;
				continue;
			case 4u:
				stream_1.Write(array, 0, count);
				num = -27641909;
				continue;
			case 2u:
				goto IL_00e0;
			case 1u:
				num = (int)(num2 * 1304610414) ^ -1794077895;
				continue;
			case 0u:
				num = (stream_1.CanWrite ? (-1708827674) : (-20465854)) ^ (int)(num2 * 1581688569);
				continue;
			default:
				return;
			case 3u:
				goto IL_019c;
			case 6u:
				throw new ObjectDisposedException(Class178.smethod_0(4456));
			case 7u:
				throw new NotSupportedException();
			case 12u:
				throw new ArgumentNullException(Class178.smethod_0(4456));
			case 13u:
				throw new ObjectDisposedException(null);
			case 16u:
				throw new NotSupportedException();
			case 15u:
				return;
			}
			num = (stream_1.CanWrite ? (-494346291) : (-1690601485));
			continue;
			IL_00e0:
			num = ((!stream_1.CanRead) ? (-1115020739) : (-1253178943));
			continue;
			IL_0072:
			num = ((!stream_0.CanRead) ? (-1414110935) : (-1948648809));
			continue;
			IL_0096:
			num = (((count = stream_0.Read(array, 0, array.Length)) != 0) ? (-2142299892) : (-14215918));
			continue;
			end_IL_0137:
			break;
		}
		goto IL_0068;
		IL_019c:
		num = ((!stream_0.CanRead) ? (-56000411) : (-187917369));
		goto IL_0137;
	}

	public static int smethod_7(this Type type_0)
	{
		return Class171.smethod_232(type_0);
	}

	public unsafe static IntPtr smethod_8(this IntPtr intptr_0, int int_0)
	{
		return (IntPtr)((byte*)(void*)intptr_0 + int_0);
	}

	public unsafe static IntPtr smethod_9(this IntPtr intptr_0, long long_0)
	{
		return (IntPtr)((byte*)(void*)intptr_0 + long_0);
	}

	public static IntPtr smethod_10(this IntPtr intptr_0, IntPtr intptr_1)
	{
		if (bool_0)
		{
			return (IntPtr)(intptr_0.ToInt32() + intptr_1.ToInt32());
		}
		return (IntPtr)(intptr_0.ToInt64() + intptr_1.ToInt64());
	}

	public static IntPtr smethod_11(this IntPtr intptr_0, IntPtr intptr_1)
	{
		if (bool_0)
		{
			return (IntPtr)(intptr_0.ToInt32() - intptr_1.ToInt32());
		}
		return (IntPtr)(intptr_0.ToInt64() - intptr_1.ToInt64());
	}

	internal static int smethod_12(Random random_0)
	{
		return random_0.Next();
	}

	internal static int smethod_13(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	internal static void smethod_14(Random random_0, byte[] byte_0)
	{
		random_0.NextBytes(byte_0);
	}

	internal static string smethod_15(FileStream fileStream_0)
	{
		return fileStream_0.Name;
	}

	internal static string smethod_16(string string_0)
	{
		return Path.GetFullPath(string_0);
	}

	internal static int smethod_17(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	internal static void smethod_18(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	internal static ArgumentNullException smethod_19(string string_0)
	{
		return new ArgumentNullException(string_0);
	}

	internal static bool smethod_20(Stream stream_0)
	{
		return stream_0.CanRead;
	}

	internal static bool smethod_21(Stream stream_0)
	{
		return stream_0.CanWrite;
	}

	internal static ObjectDisposedException smethod_22(string string_0)
	{
		return new ObjectDisposedException(string_0);
	}

	internal static NotSupportedException smethod_23()
	{
		return new NotSupportedException();
	}
}
