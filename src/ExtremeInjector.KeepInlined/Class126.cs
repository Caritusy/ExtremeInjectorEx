using System;
using System.Security.Cryptography;

public sealed class Class126<T> : Random where T : RandomNumberGenerator, new()
{
	internal RandomNumberGenerator randomNumberGenerator_0;

	public Class126()
	{
		randomNumberGenerator_0 = new T();
	}

	public override int Next()
	{
		byte[] byte_ = new byte[4];
		smethod_0(randomNumberGenerator_0, byte_);
		return smethod_1(byte_, 0) & 0x7FFFFFFF;
	}

	public override void NextBytes(byte[] buffer)
	{
		smethod_0(randomNumberGenerator_0, buffer);
	}

	public override int Next(int minValue, int maxValue)
	{
		if (maxValue < minValue)
		{
			throw smethod_2(Class178.smethod_0(9605));
		}
		return minValue + smethod_3(this, maxValue - minValue);
	}

	public override int Next(int maxValue)
	{
		return smethod_4(this) % maxValue;
	}

	internal static void smethod_0(RandomNumberGenerator randomNumberGenerator_1, byte[] byte_0)
	{
		randomNumberGenerator_1.GetBytes(byte_0);
	}

	internal static int smethod_1(byte[] byte_0, int int_0)
	{
		return BitConverter.ToInt32(byte_0, int_0);
	}

	internal static ArgumentOutOfRangeException smethod_2(string string_0)
	{
		return new ArgumentOutOfRangeException(string_0);
	}

	internal static int smethod_3(Random random_0, int int_0)
	{
		return random_0.Next(int_0);
	}

	internal static int smethod_4(Random random_0)
	{
		return random_0.Next();
	}
}
