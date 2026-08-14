using System;
using System.IO;

public class LzmaDecoder
{
	public class Class188
	{
		internal LzmaBitDecoder struct86_0;

		internal LzmaBitDecoder struct86_1;

		internal LzmaBitTreeDecoder struct87_0 = new LzmaBitTreeDecoder(8);

		internal LzmaBitTreeDecoder[] struct87_1 = new LzmaBitTreeDecoder[16];

		internal LzmaBitTreeDecoder[] struct87_2 = new LzmaBitTreeDecoder[16];

		internal uint uint_0;

		public void method_0(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				struct87_1[num] = new LzmaBitTreeDecoder(3);
				struct87_2[num] = new LzmaBitTreeDecoder(3);
			}
			uint_0 = uint_1;
		}

		public void method_1()
		{
			struct86_0.method_0();
			for (uint num = 0u; num < uint_0; num++)
			{
				struct87_1[num].method_0();
				struct87_2[num].method_0();
			}
			struct86_1.method_0();
			struct87_0.method_0();
		}

		public uint method_2(LzmaRangeDecoder class190_0, uint uint_1)
		{
			if (struct86_0.method_1(class190_0) == 0)
			{
				return struct87_1[uint_1].method_1(class190_0);
			}
			uint num = 8u;
			if (struct86_1.method_1(class190_0) == 0)
			{
				return num + struct87_2[uint_1].method_1(class190_0);
			}
			num += 8;
			return num + struct87_0.method_1(class190_0);
		}
	}

	public class Class189
	{
		public struct Struct85
		{
			internal LzmaBitDecoder[] struct86_0;

			public void method_0()
			{
				struct86_0 = new LzmaBitDecoder[768];
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					struct86_0[i].method_0();
				}
			}

			public byte method_2(LzmaRangeDecoder class190_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | struct86_0[num].method_1(class190_0);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte method_3(LzmaRangeDecoder class190_0, byte byte_0)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)((byte_0 >> 7) & 1);
					byte_0 <<= 1;
					uint num3 = struct86_0[(1 + num2 << 8) + num].method_1(class190_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | struct86_0[num].method_1(class190_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		internal Struct85[] struct85_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		public void method_0(int int_2, int int_3)
		{
			if (struct85_0 == null || int_1 != int_3 || int_0 != int_2)
			{
				int_0 = int_2;
				uint_0 = (uint)((1 << int_2) - 1);
				int_1 = int_3;
				uint num = (uint)(1 << int_1 + int_0);
				struct85_0 = new Struct85[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					struct85_0[num2].method_0();
				}
			}
		}

		public void method_1()
		{
			uint num = (uint)(1 << int_1 + int_0);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				struct85_0[num2].method_1();
			}
		}

		internal uint method_2(uint uint_1, byte byte_0)
		{
			return ((uint_1 & uint_0) << int_1) + (uint)(byte_0 >> 8 - int_1);
		}

		public byte method_3(LzmaRangeDecoder class190_0, uint uint_1, byte byte_0)
		{
			return struct85_0[method_2(uint_1, byte_0)].method_2(class190_0);
		}

		public byte method_4(LzmaRangeDecoder class190_0, uint uint_1, byte byte_0, byte byte_1)
		{
			return struct85_0[method_2(uint_1, byte_0)].method_3(class190_0, byte_1);
		}
	}

	internal const bool bool_0 = default(bool);

	internal uint uint_0;

	internal uint uint_1;

	internal LzmaBitDecoder[] struct86_0 = new LzmaBitDecoder[192];

	internal LzmaBitDecoder[] struct86_1 = new LzmaBitDecoder[192];

	internal LzmaBitDecoder[] struct86_2 = new LzmaBitDecoder[12];

	internal LzmaBitDecoder[] struct86_3 = new LzmaBitDecoder[12];

	internal LzmaBitDecoder[] struct86_4 = new LzmaBitDecoder[12];

	internal LzmaBitDecoder[] struct86_5 = new LzmaBitDecoder[12];

	internal Class188 class188_0 = new Class188();

	internal Class189 class189_0 = new Class189();

	internal LzmaOutputWindow gclass9_0 = new LzmaOutputWindow();

	internal LzmaBitTreeDecoder struct87_0 = new LzmaBitTreeDecoder(4);

	internal LzmaBitDecoder[] struct86_6 = new LzmaBitDecoder[114];

	internal LzmaBitTreeDecoder[] struct87_1 = new LzmaBitTreeDecoder[4];

	internal uint uint_2;

	internal LzmaRangeDecoder class190_0 = new LzmaRangeDecoder();

	internal Class188 class188_1 = new Class188();

	public LzmaDecoder()
	{
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			struct87_1[i] = new LzmaBitTreeDecoder(6);
		}
	}

	internal void method_0(uint uint_3)
	{
		if (uint_0 != uint_3)
		{
			uint_0 = uint_3;
			uint_1 = Math.Max(uint_0, 1u);
			uint uint_4 = Math.Max(uint_1, 4096u);
			gclass9_0.method_0(uint_4);
		}
	}

	internal void method_1(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new LzmaInvalidParameterException();
		}
		if (int_1 > 8)
		{
			throw new LzmaInvalidParameterException();
		}
		class189_0.method_0(int_0, int_1);
	}

	internal void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new LzmaInvalidParameterException();
		}
		uint num = (uint)(1 << int_0);
		class188_0.method_0(num);
		class188_1.method_0(num);
		uint_2 = num - 1;
	}

	internal void method_3(Stream stream_0, Stream stream_1)
	{
		class190_0.method_0(stream_0);
		gclass9_0.method_1(stream_1, bool_0: false);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= uint_2; num2++)
			{
				uint num3 = (num << 4) + num2;
				struct86_0[num3].method_0();
				struct86_1[num3].method_0();
			}
			struct86_2[num].method_0();
			struct86_3[num].method_0();
			struct86_4[num].method_0();
			struct86_5[num].method_0();
		}
		class189_0.method_1();
		for (uint num = 0u; num < 4; num++)
		{
			struct87_1[num].method_0();
		}
		for (uint num = 0u; num < 114; num++)
		{
			struct86_6[num].method_0();
		}
		class188_0.method_1();
		class188_1.method_1();
		struct87_0.method_0();
	}

	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
		method_3(stream_0, stream_1);
		LzmaCodecConstants.Struct88 @struct = default(LzmaCodecConstants.Struct88);
		@struct.method_0();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_0)
		{
			if (struct86_0[@struct.uint_0 << 4].method_1(class190_0) != 0)
			{
				throw new LzmaDataErrorException();
			}
			@struct.method_1();
			byte byte_ = class189_0.method_3(class190_0, 0u, 0);
			gclass9_0.method_5(byte_);
			num5++;
		}
		while (num5 < (ulong)long_0)
		{
			uint num6 = (uint)(int)num5 & uint_2;
			if (struct86_0[(@struct.uint_0 << 4) + num6].method_1(class190_0) == 0)
			{
				byte byte_2 = gclass9_0.method_6(0u);
				byte byte_3 = (@struct.method_5() ? class189_0.method_3(class190_0, (uint)num5, byte_2) : class189_0.method_4(class190_0, (uint)num5, byte_2, gclass9_0.method_6(num)));
				gclass9_0.method_5(byte_3);
				@struct.method_1();
				num5++;
				continue;
			}
			uint num8;
			if (struct86_2[@struct.uint_0].method_1(class190_0) == 1)
			{
				if (struct86_3[@struct.uint_0].method_1(class190_0) == 0)
				{
					if (struct86_1[(@struct.uint_0 << 4) + num6].method_1(class190_0) == 0)
					{
						@struct.method_4();
						gclass9_0.method_5(gclass9_0.method_6(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (struct86_4[@struct.uint_0].method_1(class190_0) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (struct86_5[@struct.uint_0].method_1(class190_0) == 0)
						{
							num7 = num3;
						}
						else
						{
							num7 = num4;
							num4 = num3;
						}
						num3 = num2;
					}
					num2 = num;
					num = num7;
				}
				num8 = class188_1.method_2(class190_0, num6) + 2;
				@struct.method_3();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + class188_0.method_2(class190_0, num6);
				@struct.method_2();
				uint num9 = struct87_1[LzmaCodecConstants.smethod_0(num8)].method_1(class190_0);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += LzmaBitTreeDecoder.smethod_0(struct86_6, num - num9 - 1, class190_0, num10);
					}
					else
					{
						num += class190_0.method_2(num10 - 4) << 4;
						num += struct87_0.method_2(class190_0);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num < gclass9_0.uint_0 + num5 && num < uint_1)
			{
				gclass9_0.method_4(num, num8);
				num5 += num8;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new LzmaDataErrorException();
		}
		gclass9_0.method_3();
		gclass9_0.method_2();
		class190_0.method_1();
	}

	public void method_5(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new LzmaInvalidParameterException();
		}
		int int_ = byte_0[0] % 9;
		int num = byte_0[0] / 9;
		int int_2 = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new LzmaInvalidParameterException();
		}
		uint num3 = 0u;
		for (int i = 0; i < 4; i++)
		{
			num3 += (uint)(byte_0[1 + i] << i * 8);
		}
		method_0(num3);
		method_1(int_2, int_);
		method_2(num2);
	}
}
