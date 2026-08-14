using System.IO;

public class LzmaOutputWindow
{
	public uint uint_0;

	internal byte[] byte_0;

	internal uint uint_1;

	internal Stream stream_0;

	internal uint uint_2;

	internal uint uint_3;

	public void method_0(uint uint_4)
	{
		if (uint_3 != uint_4)
		{
			byte_0 = new byte[uint_4];
		}
		uint_3 = uint_4;
		uint_1 = 0u;
		uint_2 = 0u;
	}

	public void method_1(Stream stream_1, bool bool_0)
	{
		method_2();
		stream_0 = stream_1;
		if (!bool_0)
		{
			uint_2 = 0u;
			uint_1 = 0u;
			uint_0 = 0u;
		}
	}

	public void method_2()
	{
		method_3();
		stream_0 = null;
	}

	public void method_3()
	{
		uint num = uint_1 - uint_2;
		if (num != 0)
		{
			stream_0.Write(byte_0, (int)uint_2, (int)num);
			if (uint_1 >= uint_3)
			{
				uint_1 = 0u;
			}
			uint_2 = uint_1;
		}
	}

	public void method_4(uint uint_4, uint uint_5)
	{
		uint num = uint_1 - uint_4 - 1;
		if (num >= uint_3)
		{
			num += uint_3;
		}
		while (uint_5 != 0)
		{
			if (num >= uint_3)
			{
				num = 0u;
			}
			byte_0[uint_1++] = byte_0[num++];
			if (uint_1 >= uint_3)
			{
				method_3();
			}
			uint_5--;
		}
	}

	public void method_5(byte byte_1)
	{
		byte_0[uint_1++] = byte_1;
		if (uint_1 >= uint_3)
		{
			method_3();
		}
	}

	public byte method_6(uint uint_4)
	{
		uint num = uint_1 - uint_4 - 1;
		if (num >= uint_3)
		{
			num += uint_3;
		}
		return byte_0[num];
	}
}
