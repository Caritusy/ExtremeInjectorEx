public struct LzmaBitDecoder
{
	public const int intValue = default(int);

	public const uint uintValue = default(uint);

	internal const int intValue2 = default(int);

	internal uint uintValue2;

	public void Initialize()
	{
		uintValue2 = 1024u;
	}

	public uint Decode(LzmaRangeDecoder rangeDecoder)
	{
		uint num = (rangeDecoder.uintValue3 >> 11) * uintValue2;
		if (rangeDecoder.uintValue2 < num)
		{
			rangeDecoder.uintValue3 = num;
			uintValue2 += 2048 - uintValue2 >> 5;
			if (rangeDecoder.uintValue3 < 16777216)
			{
				rangeDecoder.uintValue2 = (rangeDecoder.uintValue2 << 8) | (byte)rangeDecoder.stream.ReadByte();
				rangeDecoder.uintValue3 <<= 8;
			}
			return 0u;
		}
		rangeDecoder.uintValue3 -= num;
		rangeDecoder.uintValue2 -= num;
		uintValue2 -= uintValue2 >> 5;
		if (rangeDecoder.uintValue3 < 16777216)
		{
			rangeDecoder.uintValue2 = (rangeDecoder.uintValue2 << 8) | (byte)rangeDecoder.stream.ReadByte();
			rangeDecoder.uintValue3 <<= 8;
		}
		return 1u;
	}
}
