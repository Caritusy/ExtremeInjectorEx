using System;
using System.IO;

public static class BinaryExtensions
{
	internal static readonly bool flag = IntPtr.Size == 4;

	public static uint NextUInt32(this Random random)
	{
		return (uint)random.Next();
	}

	public static uint NextUInt32(this Random random, uint uintValue, uint uintValue2)
	{
		if (uintValue2 <= uintValue)
		{
			return (uint)random.Next((int)uintValue2, (int)uintValue);
		}
		return (uint)random.Next((int)uintValue, (int)uintValue2);
	}

	public static ushort NextUInt16(this Random random)
	{
		return (ushort)random.Next(0, 65536);
	}

	public static byte NextByte(this Random random)
	{
		byte[] array = new byte[1];
		random.NextBytes(array);
		return array[0];
	}

	public static string GetFilePath(this Stream stream)
	{
		FileStream fileStream = stream as FileStream;
		if (fileStream != null)
		{
			return Path.GetFullPath(fileStream.Name);
		}
		return string.Empty;
	}

	public static void CopyBytesTo(this Stream stream, Stream stream2, int intValue)
	{
		byte[] array = new byte[intValue];
		int num = 0;
		while (intValue > 0)
		{
			int num2 = stream.Read(array, num, intValue);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			intValue -= num2;
		}
		stream2.Write(array, 0, num);
	}

	public static void CopyTo(this Stream stream, Stream stream2)
	{
		if (stream2 == null)
		{
			throw new ArgumentNullException(EncodedStringTable.DecodeString(4456));
		}
		if (!stream.CanRead && !stream.CanWrite)
		{
			throw new ObjectDisposedException(null);
		}
		if (!stream2.CanRead && !stream2.CanWrite)
		{
			throw new ObjectDisposedException(EncodedStringTable.DecodeString(4456));
		}
		if (!stream.CanRead)
		{
			throw new NotSupportedException();
		}
		if (!stream2.CanWrite)
		{
			throw new NotSupportedException();
		}
		byte[] array = new byte[81920];
		int count;
		while ((count = stream.Read(array, 0, array.Length)) != 0)
		{
			stream2.Write(array, 0, count);
		}
	}

	public static int SizeOf(this Type typeValue)
	{
		return RecoveredRuntime.GetCachedNativeTypeSize(typeValue);
	}

	public unsafe static IntPtr Add(this IntPtr address, int intValue)
	{
		return (IntPtr)((byte*)(void*)address + intValue);
	}

	public unsafe static IntPtr Add(this IntPtr address, long longValue)
	{
		return (IntPtr)((byte*)(void*)address + longValue);
	}

	public static IntPtr Add(this IntPtr address, IntPtr address2)
	{
		if (flag)
		{
			return (IntPtr)(address.ToInt32() + address2.ToInt32());
		}
		return (IntPtr)(address.ToInt64() + address2.ToInt64());
	}

	public static IntPtr Subtract(this IntPtr address, IntPtr address2)
	{
		if (flag)
		{
			return (IntPtr)(address.ToInt32() - address2.ToInt32());
		}
		return (IntPtr)(address.ToInt64() - address2.ToInt64());
	}
}
