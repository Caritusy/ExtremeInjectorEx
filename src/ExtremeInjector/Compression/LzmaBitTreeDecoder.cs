public struct LzmaBitTreeDecoder(int intValue2)
{
	internal LzmaBitDecoder[] bitDecoderArray = new LzmaBitDecoder[1 << intValue2];

	internal int intValue = intValue2;

	public void Initialize()
	{
		for (uint num = 1u; num < 1 << intValue; num++)
		{
			bitDecoderArray[num].Initialize();
		}
	}

	public uint Decode(LzmaRangeDecoder rangeDecoder)
	{
		uint num = 1u;
		for (int num2 = intValue; num2 > 0; num2--)
		{
			num = (num << 1) + bitDecoderArray[num].Decode(rangeDecoder);
		}
		return num - (uint)(1 << intValue);
	}

	public uint ReverseDecode(LzmaRangeDecoder rangeDecoder)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < intValue; i++)
		{
			uint num3 = bitDecoderArray[num].Decode(rangeDecoder);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint ReverseDecode(LzmaBitDecoder[] bitDecoderArray2, uint uintValue, LzmaRangeDecoder rangeDecoder, int intValue2)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < intValue2; i++)
		{
			uint num3 = bitDecoderArray2[uintValue + num].Decode(rangeDecoder);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}
}
