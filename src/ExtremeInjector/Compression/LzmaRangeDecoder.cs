using System.IO;

public class LzmaRangeDecoder
{
	public const uint uintValue = default(uint);

	public uint uintValue2;

	public uint uintValue3;

	public Stream stream;

	public void Initialize(Stream stream2)
	{
		stream = stream2;
		uintValue2 = 0u;
		uintValue3 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			uintValue2 = (uintValue2 << 8) | (byte)stream.ReadByte();
		}
	}

	public void ReleaseStream()
	{
		stream = null;
	}

	public uint DecodeDirectBits(int intValue)
	{
		uint num = uintValue3;
		uint num2 = uintValue2;
		uint num3 = 0u;
		for (int num4 = intValue; num4 > 0; num4--)
		{
			num >>= 1;
			uint num5 = num2 - num >> 31;
			num2 -= num & (num5 - 1);
			num3 = (num3 << 1) | (1 - num5);
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)stream.ReadByte();
				num <<= 8;
			}
		}
		uintValue3 = num;
		uintValue2 = num2;
		return num3;
	}
}
