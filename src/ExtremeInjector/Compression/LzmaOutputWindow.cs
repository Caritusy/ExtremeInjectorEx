using System.IO;

public class LzmaOutputWindow
{
	public uint uintValue;

	internal byte[] bytes;

	internal uint uintValue2;

	internal Stream stream;

	internal uint uintValue3;

	internal uint uintValue4;

	public void Create(uint uintValue5)
	{
		if (uintValue4 != uintValue5)
		{
			bytes = new byte[uintValue5];
		}
		uintValue4 = uintValue5;
		uintValue2 = 0u;
		uintValue3 = 0u;
	}

	public void SetStream(Stream stream2, bool flag)
	{
		ReleaseStream();
		stream = stream2;
		if (!flag)
		{
			uintValue3 = 0u;
			uintValue2 = 0u;
			uintValue = 0u;
		}
	}

	public void ReleaseStream()
	{
		Flush();
		stream = null;
	}

	public void Flush()
	{
		uint num = uintValue2 - uintValue3;
		if (num != 0)
		{
			stream.Write(bytes, (int)uintValue3, (int)num);
			if (uintValue2 >= uintValue4)
			{
				uintValue2 = 0u;
			}
			uintValue3 = uintValue2;
		}
	}

	public void CopyBlock(uint uintValue5, uint uintValue6)
	{
		uint num = uintValue2 - uintValue5 - 1;
		if (num >= uintValue4)
		{
			num += uintValue4;
		}
		while (uintValue6 != 0)
		{
			if (num >= uintValue4)
			{
				num = 0u;
			}
			bytes[uintValue2++] = bytes[num++];
			if (uintValue2 >= uintValue4)
			{
				Flush();
			}
			uintValue6--;
		}
	}

	public void PutByte(byte byteValue)
	{
		bytes[uintValue2++] = byteValue;
		if (uintValue2 >= uintValue4)
		{
			Flush();
		}
	}

	public byte GetByte(uint uintValue5)
	{
		uint num = uintValue2 - uintValue5 - 1;
		if (num >= uintValue4)
		{
			num += uintValue4;
		}
		return bytes[num];
	}
}
