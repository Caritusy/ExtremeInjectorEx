using System;
using System.IO;

public class LzmaDecoder
{
	public class LzmaLengthDecoder
	{
		internal LzmaBitDecoder bitDecoder;

		internal LzmaBitDecoder bitDecoder2;

		internal LzmaBitTreeDecoder bitTreeDecoder = new LzmaBitTreeDecoder(8);

		internal LzmaBitTreeDecoder[] bitTreeDecoderArray = new LzmaBitTreeDecoder[16];

		internal LzmaBitTreeDecoder[] bitTreeDecoderArray2 = new LzmaBitTreeDecoder[16];

		internal uint uintValue;

		public void Create(uint uintValue2)
		{
			for (uint num = uintValue; num < uintValue2; num++)
			{
				bitTreeDecoderArray[num] = new LzmaBitTreeDecoder(3);
				bitTreeDecoderArray2[num] = new LzmaBitTreeDecoder(3);
			}
			uintValue = uintValue2;
		}

		public void Initialize()
		{
			bitDecoder.Initialize();
			for (uint num = 0u; num < uintValue; num++)
			{
				bitTreeDecoderArray[num].Initialize();
				bitTreeDecoderArray2[num].Initialize();
			}
			bitDecoder2.Initialize();
			bitTreeDecoder.Initialize();
		}

		public uint Decode(LzmaRangeDecoder rangeDecoder, uint uintValue2)
		{
			if (bitDecoder.Decode(rangeDecoder) == 0)
			{
				return bitTreeDecoderArray[uintValue2].Decode(rangeDecoder);
			}
			uint num = 8u;
			if (bitDecoder2.Decode(rangeDecoder) == 0)
			{
				return num + bitTreeDecoderArray2[uintValue2].Decode(rangeDecoder);
			}
			num += 8;
			return num + bitTreeDecoder.Decode(rangeDecoder);
		}
	}

	public class LzmaLiteralDecoder
	{
		public struct LzmaLiteralSubdecoder
		{
			internal LzmaBitDecoder[] bitDecoderArray;

			public void Create()
			{
				bitDecoderArray = new LzmaBitDecoder[768];
			}

			public void Initialize()
			{
				for (int i = 0; i < 768; i++)
				{
					bitDecoderArray[i].Initialize();
				}
			}

			public byte DecodeNormal(LzmaRangeDecoder rangeDecoder)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | bitDecoderArray[num].Decode(rangeDecoder);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte DecodeWithMatchByte(LzmaRangeDecoder rangeDecoder, byte byteValue)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)((byteValue >> 7) & 1);
					byteValue <<= 1;
					uint num3 = bitDecoderArray[(1 + num2 << 8) + num].Decode(rangeDecoder);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | bitDecoderArray[num].Decode(rangeDecoder);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		internal LzmaLiteralSubdecoder[] literalSubdecoderArray;

		internal int intValue;

		internal int intValue2;

		internal uint uintValue;

		public void Create(int intValue3, int intValue4)
		{
			if (literalSubdecoderArray == null || intValue2 != intValue4 || intValue != intValue3)
			{
				intValue = intValue3;
				uintValue = (uint)((1 << intValue3) - 1);
				intValue2 = intValue4;
				uint num = (uint)(1 << intValue2 + intValue);
				literalSubdecoderArray = new LzmaLiteralSubdecoder[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					literalSubdecoderArray[num2].Create();
				}
			}
		}

		public void Initialize()
		{
			uint num = (uint)(1 << intValue2 + intValue);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				literalSubdecoderArray[num2].Initialize();
			}
		}

		internal uint GetDecoderIndex(uint uintValue2, byte byteValue)
		{
			return ((uintValue2 & uintValue) << intValue2) + (uint)(byteValue >> 8 - intValue2);
		}

		public byte DecodeNormal(LzmaRangeDecoder rangeDecoder, uint uintValue2, byte byteValue)
		{
			return literalSubdecoderArray[GetDecoderIndex(uintValue2, byteValue)].DecodeNormal(rangeDecoder);
		}

		public byte DecodeWithMatchByte(LzmaRangeDecoder rangeDecoder, uint uintValue2, byte byteValue, byte byteValue2)
		{
			return literalSubdecoderArray[GetDecoderIndex(uintValue2, byteValue)].DecodeWithMatchByte(rangeDecoder, byteValue2);
		}
	}

	internal const bool flag = default(bool);

	internal uint uintValue;

	internal uint uintValue2;

	internal LzmaBitDecoder[] bitDecoderArray = new LzmaBitDecoder[192];

	internal LzmaBitDecoder[] bitDecoderArray2 = new LzmaBitDecoder[192];

	internal LzmaBitDecoder[] bitDecoderArray3 = new LzmaBitDecoder[12];

	internal LzmaBitDecoder[] bitDecoderArray4 = new LzmaBitDecoder[12];

	internal LzmaBitDecoder[] bitDecoderArray5 = new LzmaBitDecoder[12];

	internal LzmaBitDecoder[] bitDecoderArray6 = new LzmaBitDecoder[12];

	internal LzmaLengthDecoder lengthDecoder = new LzmaLengthDecoder();

	internal LzmaLiteralDecoder literalProperties = new LzmaLiteralDecoder();

	internal LzmaOutputWindow outputWindow = new LzmaOutputWindow();

	internal LzmaBitTreeDecoder bitTreeDecoder = new LzmaBitTreeDecoder(4);

	internal LzmaBitDecoder[] bitDecoderArray7 = new LzmaBitDecoder[114];

	internal LzmaBitTreeDecoder[] bitTreeDecoderArray = new LzmaBitTreeDecoder[4];

	internal uint uintValue3;

	internal LzmaRangeDecoder rangeDecoder = new LzmaRangeDecoder();

	internal LzmaLengthDecoder lengthDecoder2 = new LzmaLengthDecoder();

	public LzmaDecoder()
	{
		uintValue = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			bitTreeDecoderArray[i] = new LzmaBitTreeDecoder(6);
		}
	}

	internal void SetDictionarySize(uint uintValue4)
	{
		if (uintValue != uintValue4)
		{
			uintValue = uintValue4;
			uintValue2 = Math.Max(uintValue, 1u);
			uint uintValue5 = Math.Max(uintValue2, 4096u);
			outputWindow.Create(uintValue5);
		}
	}

	internal void SetLiteralProperties(int intValue, int intValue2)
	{
		if (intValue > 8)
		{
			throw new LzmaInvalidParameterException();
		}
		if (intValue2 > 8)
		{
			throw new LzmaInvalidParameterException();
		}
		literalProperties.Create(intValue, intValue2);
	}

	internal void SetPositionBits(int intValue)
	{
		if (intValue > 4)
		{
			throw new LzmaInvalidParameterException();
		}
		uint num = (uint)(1 << intValue);
		lengthDecoder.Create(num);
		lengthDecoder2.Create(num);
		uintValue3 = num - 1;
	}

	internal void Initialize(Stream stream, Stream stream2)
	{
		rangeDecoder.Initialize(stream);
		outputWindow.SetStream(stream2, flag: false);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= uintValue3; num2++)
			{
				uint num3 = (num << 4) + num2;
				bitDecoderArray[num3].Initialize();
				bitDecoderArray2[num3].Initialize();
			}
			bitDecoderArray3[num].Initialize();
			bitDecoderArray4[num].Initialize();
			bitDecoderArray5[num].Initialize();
			bitDecoderArray6[num].Initialize();
		}
		literalProperties.Initialize();
		for (uint num = 0u; num < 4; num++)
		{
			bitTreeDecoderArray[num].Initialize();
		}
		for (uint num = 0u; num < 114; num++)
		{
			bitDecoderArray7[num].Initialize();
		}
		lengthDecoder.Initialize();
		lengthDecoder2.Initialize();
		bitTreeDecoder.Initialize();
	}

	public void Decode(Stream stream, Stream stream2, long longValue)
	{
		Initialize(stream, stream2);
		LzmaCodecConstants.LzmaState @struct = default(LzmaCodecConstants.LzmaState);
		@struct.Initialize();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)longValue)
		{
			if (bitDecoderArray[@struct.isLiteralState << 4].Decode(rangeDecoder) != 0)
			{
				throw new LzmaDataErrorException();
			}
			@struct.UpdateLiteral();
			byte byte_ = literalProperties.DecodeNormal(rangeDecoder, 0u, 0);
			outputWindow.PutByte(byte_);
			num5++;
		}
		while (num5 < (ulong)longValue)
		{
			uint num6 = (uint)(int)num5 & uintValue3;
			if (bitDecoderArray[(@struct.isLiteralState << 4) + num6].Decode(rangeDecoder) == 0)
			{
				byte byteValue = outputWindow.GetByte(0u);
				byte byteValue2 = (@struct.IsLiteralState() ? literalProperties.DecodeNormal(rangeDecoder, (uint)num5, byteValue) : literalProperties.DecodeWithMatchByte(rangeDecoder, (uint)num5, byteValue, outputWindow.GetByte(num)));
				outputWindow.PutByte(byteValue2);
				@struct.UpdateLiteral();
				num5++;
				continue;
			}
			uint num8;
			if (bitDecoderArray3[@struct.isLiteralState].Decode(rangeDecoder) == 1)
			{
				if (bitDecoderArray4[@struct.isLiteralState].Decode(rangeDecoder) == 0)
				{
					if (bitDecoderArray2[(@struct.isLiteralState << 4) + num6].Decode(rangeDecoder) == 0)
					{
						@struct.UpdateShortRepeatedMatch();
						outputWindow.PutByte(outputWindow.GetByte(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (bitDecoderArray5[@struct.isLiteralState].Decode(rangeDecoder) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (bitDecoderArray6[@struct.isLiteralState].Decode(rangeDecoder) == 0)
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
				num8 = lengthDecoder2.Decode(rangeDecoder, num6) + 2;
				@struct.UpdateRepeatedMatch();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + lengthDecoder.Decode(rangeDecoder, num6);
				@struct.UpdateMatch();
				uint num9 = bitTreeDecoderArray[LzmaCodecConstants.GetLengthToPositionState(num8)].Decode(rangeDecoder);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += LzmaBitTreeDecoder.ReverseDecode(bitDecoderArray7, num - num9 - 1, rangeDecoder, num10);
					}
					else
					{
						num += rangeDecoder.DecodeDirectBits(num10 - 4) << 4;
						num += bitTreeDecoder.ReverseDecode(rangeDecoder);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num < outputWindow.uintValue + num5 && num < uintValue2)
			{
				outputWindow.CopyBlock(num, num8);
				num5 += num8;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new LzmaDataErrorException();
		}
		outputWindow.Flush();
		outputWindow.ReleaseStream();
		rangeDecoder.ReleaseStream();
	}

	public void SetDecoderProperties(byte[] bytes)
	{
		if (bytes.Length < 5)
		{
			throw new LzmaInvalidParameterException();
		}
		int int_ = bytes[0] % 9;
		int num = bytes[0] / 9;
		int intValue = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new LzmaInvalidParameterException();
		}
		uint num3 = 0u;
		for (int i = 0; i < 4; i++)
		{
			num3 += (uint)(bytes[1 + i] << i * 8);
		}
		SetDictionarySize(num3);
		SetLiteralProperties(intValue, int_);
		SetPositionBits(num2);
	}
}
