using System.IO;

public class BoundsCheckedBinaryReader : BinaryReader, ILengthValidator
{
	internal ILengthValidator interface0_0;

	public BoundsCheckedBinaryReader(Stream stream_0)
		: base(stream_0)
	{
		this.interface0_0 = (stream_0 as ILengthValidator);
	}

	public bool imethod_0(long long_0)
	{
		if (this.interface0_0 != null)
		{
			return this.interface0_0.imethod_0(long_0);
		}
		return long_0 > 0L && long_0 <= this.BaseStream.Length;
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
