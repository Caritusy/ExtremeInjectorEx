public struct LzmaBitDecoder
{
	public const int int_0 = default(int);

	public const uint uint_0 = default(uint);

	internal const int int_1 = default(int);

	internal uint uint_1;

	public void Initialize()
	{
		uint_1 = 1024u;
	}

	public uint Decode(LzmaRangeDecoder class190_0)
	{
		uint num = (class190_0.uint_2 >> 11) * uint_1;
		if (class190_0.uint_1 < num)
		{
			class190_0.uint_2 = num;
			uint_1 += 2048 - uint_1 >> 5;
			if (class190_0.uint_2 < 16777216)
			{
				class190_0.uint_1 = (class190_0.uint_1 << 8) | (byte)class190_0.stream_0.ReadByte();
				class190_0.uint_2 <<= 8;
			}
			return 0u;
		}
		class190_0.uint_2 -= num;
		class190_0.uint_1 -= num;
		uint_1 -= uint_1 >> 5;
		if (class190_0.uint_2 < 16777216)
		{
			class190_0.uint_1 = (class190_0.uint_1 << 8) | (byte)class190_0.stream_0.ReadByte();
			class190_0.uint_2 <<= 8;
		}
		return 1u;
	}
}
