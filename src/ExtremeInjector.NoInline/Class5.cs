using System.IO;

public class Class5 : BinaryReader, Interface0
{
	internal Interface0 interface0_0;

	public Class5(Stream stream_0)
		: base(stream_0)
	{
		while (true)
		{
			int num = 259667659;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1CF5A68C)) % 3)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				interface0_0 = stream_0 as Interface0;
				num = (int)(num2 * 1058010569) ^ -32902973;
			}
		}
	}

	public bool imethod_0(long long_0)
	{
		if (interface0_0 != null)
		{
			goto IL_0017;
		}
		goto IL_004b;
		IL_0017:
		int num = 877420216;
		goto IL_001c;
		IL_001c:
		switch ((uint)(num ^ 0x74ADA358) % 5u)
		{
		case 0u:
			break;
		case 3u:
			goto IL_004b;
		case 1u:
			return interface0_0.imethod_0(long_0);
		case 2u:
			return long_0 <= smethod_1(smethod_0(this));
		default:
			return false;
		}
		goto IL_0017;
		IL_004b:
		num = ((long_0 <= 0L) ? 1118593172 : 1911113395);
		goto IL_001c;
	}

	internal static Stream smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static long smethod_1(Stream stream_0)
	{
		return stream_0.Length;
	}
}
