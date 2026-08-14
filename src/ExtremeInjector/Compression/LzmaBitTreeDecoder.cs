public struct LzmaBitTreeDecoder(int int_1)
{
	internal LzmaBitDecoder[] struct86_0 = new LzmaBitDecoder[1 << int_1];

	internal int int_0 = int_1;

	public void Initialize()
	{
		for (uint num = 1u; num < 1 << int_0; num++)
		{
			struct86_0[num].Initialize();
		}
	}

	public uint Decode(LzmaRangeDecoder class190_0)
	{
		uint num = 1u;
		for (int num2 = int_0; num2 > 0; num2--)
		{
			num = (num << 1) + struct86_0[num].Decode(class190_0);
		}
		return num - (uint)(1 << int_0);
	}

	public uint ReverseDecode(LzmaRangeDecoder class190_0)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_0; i++)
		{
			uint num3 = struct86_0[num].Decode(class190_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint ReverseDecode(LzmaBitDecoder[] struct86_1, uint uint_0, LzmaRangeDecoder class190_0, int int_1)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_1; i++)
		{
			uint num3 = struct86_1[uint_0 + num].Decode(class190_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}
}
