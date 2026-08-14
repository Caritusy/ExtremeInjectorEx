using System;
using System.IO;

public static class BinaryExtensions
{
	internal static readonly bool bool_0 = IntPtr.Size == 4;

	public static uint smethod_0(this Random random_0)
	{
		return (uint)random_0.Next();
	}

	public static uint smethod_1(this Random random_0, uint uint_0, uint uint_1)
	{
		if (uint_1 <= uint_0)
		{
			return (uint)random_0.Next((int)uint_1, (int)uint_0);
		}
		return (uint)random_0.Next((int)uint_0, (int)uint_1);
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
		if (fileStream != null)
		{
			return Path.GetFullPath(fileStream.Name);
		}
		return string.Empty;
	}

	public static void smethod_5(this Stream stream_0, Stream stream_1, int int_0)
	{
		byte[] array = new byte[int_0];
		int num = 0;
		while (int_0 > 0)
		{
			int num2 = stream_0.Read(array, num, int_0);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			int_0 -= num2;
		}
		stream_1.Write(array, 0, array.Length);
	}

	public static void smethod_6(this Stream stream_0, Stream stream_1)
	{
		if (stream_1 == null)
		{
			throw new ArgumentNullException(EncodedStringTable.smethod_0(4456));
		}
		if (!stream_0.CanRead && !stream_0.CanWrite)
		{
			throw new ObjectDisposedException(null);
		}
		if (!stream_1.CanRead && !stream_1.CanWrite)
		{
			throw new ObjectDisposedException(EncodedStringTable.smethod_0(4456));
		}
		if (!stream_0.CanRead)
		{
			throw new NotSupportedException();
		}
		if (!stream_1.CanWrite)
		{
			throw new NotSupportedException();
		}
		byte[] array = new byte[81920];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	public static int smethod_7(this Type type_0)
	{
		return RecoveredRuntime.smethod_232(type_0);
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
