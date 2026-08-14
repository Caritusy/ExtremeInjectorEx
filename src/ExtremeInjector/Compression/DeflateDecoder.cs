using System;
using System.IO;

public static class DeflateDecoder
{
	public sealed class Class180
	{
		internal static readonly int[] int_0 = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		internal static readonly int[] int_1 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		internal static readonly int[] int_2 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		internal static readonly int[] int_3 = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal bool bool_0;

		internal Class181 class181_0;

		internal Class182 class182_0;

		internal Class184 class184_0;

		internal Class183 class183_0;

		internal Class183 class183_1;

		public Class180(byte[] byte_0)
		{
			class181_0 = new Class181();
			class182_0 = new Class182();
			int_4 = 2;
			RecoveredRuntime.SetDeflateInput(byte_0.Length, byte_0, 0, class181_0);
		}

		static Class180()
		{
			// Note: this type is marked as 'beforefieldinit'.
		}
	}

	public sealed class Class181
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;
	}

	public sealed class Class182
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;
	}

	public sealed class Class183
	{
		internal short[] short_0;

		public static readonly Class183 class183_0;

		public static readonly Class183 class183_1;

		static Class183()
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
			DeflateDecoder.Class183.class183_0 = new DeflateDecoder.Class183(array);
			array = new byte[32];
			i = 0;
			while (i < 32)
			{
				array[i++] = 5;
			}
			DeflateDecoder.Class183.class183_1 = new DeflateDecoder.Class183(array);
		}

		public Class183(byte[] byte_0)
		{
			RecoveredRuntime.BuildDeflateHuffmanTree(byte_0, this);
		}
	}

	public sealed class Class184
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class183 class183_0;

		internal int int_2;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal byte byte_2;

		internal int int_8;

		internal static readonly int[] int_9 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};
	}

	public sealed class Class185
	{
		internal static readonly int[] int_0 = new int[17]
		{
			0, 1, 3, 7, 15, 31, 63, 127, 255,
			511, 1023, 2047, 4095, 8191, 16383, 32767, 65535
		};

		internal static readonly byte[] byte_0 = new byte[16]
		{
			0, 8, 4, 12, 2, 10, 6, 14,
			1, 9, 5, 13, 3, 11, 7, 15
		};

		internal static readonly short[] short_0 = new short[286];

		internal static readonly byte[] byte_1 = new byte[286];

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		static Class185()
		{
			int i = 0;
			while (i < 144)
			{
				DeflateDecoder.Class185.short_0[i] = RecoveredRuntime.ReverseDeflateBits(48 + i << 8);
				DeflateDecoder.Class185.byte_1[i++] = 8;
			}
			while (i < 256)
			{
				DeflateDecoder.Class185.short_0[i] = RecoveredRuntime.ReverseDeflateBits(256 + i << 7);
				DeflateDecoder.Class185.byte_1[i++] = 9;
			}
			while (i < 280)
			{
				DeflateDecoder.Class185.short_0[i] = RecoveredRuntime.ReverseDeflateBits(-256 + i << 9);
				DeflateDecoder.Class185.byte_1[i++] = 7;
			}
			while (i < 286)
			{
				DeflateDecoder.Class185.short_0[i] = RecoveredRuntime.ReverseDeflateBits(-88 + i << 8);
				DeflateDecoder.Class185.byte_1[i++] = 8;
			}
			DeflateDecoder.Class185.short_1 = new short[30];
			DeflateDecoder.Class185.byte_2 = new byte[30];
			for (i = 0; i < 30; i++)
			{
				DeflateDecoder.Class185.short_1[i] = RecoveredRuntime.ReverseDeflateBits(i << 11);
				DeflateDecoder.Class185.byte_2[i] = 5;
			}
		}
	}

	public sealed class Stream1 : MemoryStream
	{
		public Stream1(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}
	}
}
