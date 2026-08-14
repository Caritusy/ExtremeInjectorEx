using System;
using System.IO;

public static class DeflateDecoder
{
	public sealed class Inflater
	{
		internal static readonly int[] intValueArray = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		internal static readonly int[] intValueArray2 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		internal static readonly int[] intValueArray3 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		internal static readonly int[] intValueArray4 = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		internal int intValue;

		internal int intValue2;

		internal int intValue3;

		internal int intValue4;

		internal int intValue5;

		internal bool flag;

		internal DeflateInputBuffer deflateInputBuffer;

		internal DeflateOutputWindow deflateOutputWindow;

		internal DynamicHuffmanHeader dynamicHuffmanHeader;

		internal DeflateHuffmanTree deflateHuffmanTree;

		internal DeflateHuffmanTree deflateHuffmanTree2;

		public Inflater(byte[] bytes)
		{
			deflateInputBuffer = new DeflateInputBuffer();
			deflateOutputWindow = new DeflateOutputWindow();
			intValue = 2;
			RecoveredRuntime.SetDeflateInput(bytes.Length, bytes, 0, deflateInputBuffer);
		}

		static Inflater()
		{
			// Note: this type is marked as 'beforefieldinit'.
		}
	}

	public sealed class DeflateInputBuffer
	{
		internal byte[] bytes;

		internal int intValue;

		internal int intValue2;

		internal uint uintValue;

		internal int intValue3;
	}

	public sealed class DeflateOutputWindow
	{
		internal byte[] bytes = new byte[32768];

		internal int intValue;

		internal int intValue2;
	}

	public sealed class DeflateHuffmanTree
	{
		internal short[] shortValueArray;

		public static readonly DeflateHuffmanTree deflateHuffmanTree;

		public static readonly DeflateHuffmanTree deflateHuffmanTree2;

		static DeflateHuffmanTree()
		{
			byte[] array = new byte[288];
			int i = 0;
			while (i < 144)
			{
				array[i++] = 8;
			}
			while (i < 256)
			{
				array[i++] = 9;
			}
			while (i < 280)
			{
				array[i++] = 7;
			}
			while (i < 288)
			{
				array[i++] = 8;
			}
			DeflateDecoder.DeflateHuffmanTree.deflateHuffmanTree = new DeflateDecoder.DeflateHuffmanTree(array);
			array = new byte[32];
			i = 0;
			while (i < 32)
			{
				array[i++] = 5;
			}
			DeflateDecoder.DeflateHuffmanTree.deflateHuffmanTree2 = new DeflateDecoder.DeflateHuffmanTree(array);
		}

		public DeflateHuffmanTree(byte[] bytes)
		{
			RecoveredRuntime.BuildDeflateHuffmanTree(bytes, this);
		}
	}

	public sealed class DynamicHuffmanHeader
	{
		internal static readonly int[] intValueArray = new int[3] { 3, 3, 11 };

		internal static readonly int[] intValueArray2 = new int[3] { 2, 3, 7 };

		internal byte[] bytes;

		internal byte[] bytes2;

		internal DeflateHuffmanTree deflateHuffmanTree;

		internal int intValue;

		internal int intValue2;

		internal int intValue3;

		internal int intValue4;

		internal int intValue5;

		internal int intValue6;

		internal byte byteValue;

		internal int intValue7;

		internal static readonly int[] intValueArray3 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};
	}

	public sealed class DeflateHuffmanTables
	{
		internal static readonly int[] intValueArray = new int[17]
		{
			0, 1, 3, 7, 15, 31, 63, 127, 255,
			511, 1023, 2047, 4095, 8191, 16383, 32767, 65535
		};

		internal static readonly byte[] bytes = new byte[16]
		{
			0, 8, 4, 12, 2, 10, 6, 14,
			1, 9, 5, 13, 3, 11, 7, 15
		};

		internal static readonly short[] shortValueArray = new short[286];

		internal static readonly byte[] bytes2 = new byte[286];

		internal static readonly short[] shortValueArray2;

		internal static readonly byte[] bytes3;

		static DeflateHuffmanTables()
		{
			int i = 0;
			while (i < 144)
			{
				DeflateDecoder.DeflateHuffmanTables.shortValueArray[i] = RecoveredRuntime.ReverseDeflateBits(48 + i << 8);
				DeflateDecoder.DeflateHuffmanTables.bytes2[i++] = 8;
			}
			while (i < 256)
			{
				DeflateDecoder.DeflateHuffmanTables.shortValueArray[i] = RecoveredRuntime.ReverseDeflateBits(256 + i << 7);
				DeflateDecoder.DeflateHuffmanTables.bytes2[i++] = 9;
			}
			while (i < 280)
			{
				DeflateDecoder.DeflateHuffmanTables.shortValueArray[i] = RecoveredRuntime.ReverseDeflateBits(-256 + i << 9);
				DeflateDecoder.DeflateHuffmanTables.bytes2[i++] = 7;
			}
			while (i < 286)
			{
				DeflateDecoder.DeflateHuffmanTables.shortValueArray[i] = RecoveredRuntime.ReverseDeflateBits(-88 + i << 8);
				DeflateDecoder.DeflateHuffmanTables.bytes2[i++] = 8;
			}
			DeflateDecoder.DeflateHuffmanTables.shortValueArray2 = new short[30];
			DeflateDecoder.DeflateHuffmanTables.bytes3 = new byte[30];
			for (i = 0; i < 30; i++)
			{
				DeflateDecoder.DeflateHuffmanTables.shortValueArray2[i] = RecoveredRuntime.ReverseDeflateBits(i << 11);
				DeflateDecoder.DeflateHuffmanTables.bytes3[i] = 5;
			}
		}
	}

	public sealed class ReadOnlyMemoryStream : MemoryStream
	{
		public ReadOnlyMemoryStream(byte[] bytes)
			: base(bytes, writable: false)
		{
		}
	}
}
