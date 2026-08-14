using System;
using System.Security.Cryptography;

public sealed class CryptoRandom<T> : Random where T : RandomNumberGenerator, new()
{
	internal RandomNumberGenerator randomNumberGenerator;

	public CryptoRandom()
	{
		randomNumberGenerator = new T();
	}

	public override int Next()
	{
		byte[] bytes = new byte[4];
		randomNumberGenerator.GetBytes(bytes);
		return BitConverter.ToInt32(bytes, 0) & 0x7FFFFFFF;
	}

	public override void NextBytes(byte[] buffer)
	{
		randomNumberGenerator.GetBytes(buffer);
	}

	public override int Next(int minValue, int maxValue)
	{
		if (maxValue < minValue)
		{
			throw new ArgumentOutOfRangeException(nameof(maxValue), "maxValue must be greater than or equal to minValue");
		}
		return minValue + Next(maxValue - minValue);
	}

	public override int Next(int maxValue)
	{
		if (maxValue < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(maxValue));
		}
		return maxValue == 0 ? 0 : Next() % maxValue;
	}
}
