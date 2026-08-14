using System;
using System.IO;

public static class BinaryExtensions
{
	internal static readonly bool bool_0 = IntPtr.Size == 4;

	public static uint NextUInt32(this Random random_0)
	{
		return (uint)random_0.Next();
	}

	public static uint NextUInt32(this Random random_0, uint uint_0, uint uint_1)
	{
		if (uint_1 <= uint_0)
		{
			return (uint)random_0.Next((int)uint_1, (int)uint_0);
		}
		return (uint)random_0.Next((int)uint_0, (int)uint_1);
	}

	public static ushort NextUInt16(this Random random_0)
	{
		return (ushort)random_0.Next(0, 65536);
	}

	public static byte NextByte(this Random random_0)
	{
		byte[] array = new byte[1];
		random_0.NextBytes(array);
		return array[0];
	}

	public static string GetFilePath(this Stream stream_0)
	{
		FileStream fileStream = stream_0 as FileStream;
		if (fileStream != null)
		{
			return Path.GetFullPath(fileStream.Name);
		}
		return string.Empty;
	}

	public static void CopyBytesTo(this Stream stream_0, Stream stream_1, int int_0)
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
		stream_1.Write(array, 0, num);
	}

	public static void CopyTo(this Stream stream_0, Stream stream_1)
	{
		if (stream_1 == null)
		{
			throw new ArgumentNullException(EncodedStringTable.DecodeString(4456));
		}
		if (!stream_0.CanRead && !stream_0.CanWrite)
		{
			throw new ObjectDisposedException(null);
		}
		if (!stream_1.CanRead && !stream_1.CanWrite)
		{
			throw new ObjectDisposedException(EncodedStringTable.DecodeString(4456));
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

	public static int SizeOf(this Type type_0)
	{
		return RecoveredRuntime.GetCachedNativeTypeSize(type_0);
	}

	public unsafe static IntPtr Add(this IntPtr intptr_0, int int_0)
	{
		return (IntPtr)((byte*)(void*)intptr_0 + int_0);
	}

	public unsafe static IntPtr Add(this IntPtr intptr_0, long long_0)
	{
		return (IntPtr)((byte*)(void*)intptr_0 + long_0);
	}

	public static IntPtr Add(this IntPtr intptr_0, IntPtr intptr_1)
	{
		if (bool_0)
		{
			return (IntPtr)(intptr_0.ToInt32() + intptr_1.ToInt32());
		}
		return (IntPtr)(intptr_0.ToInt64() + intptr_1.ToInt64());
	}

	public static IntPtr Subtract(this IntPtr intptr_0, IntPtr intptr_1)
	{
		if (bool_0)
		{
			return (IntPtr)(intptr_0.ToInt32() - intptr_1.ToInt32());
		}
		return (IntPtr)(intptr_0.ToInt64() - intptr_1.ToInt64());
	}
}
