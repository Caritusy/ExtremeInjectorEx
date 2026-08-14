using System.IO;

public class BoundsCheckedBinaryReader : BinaryReader, ILengthValidator
{
	internal ILengthValidator interface0_0;

	public BoundsCheckedBinaryReader(Stream stream_0)
		: base(stream_0)
	{
		this.interface0_0 = (stream_0 as ILengthValidator);
	}

	public bool IsValidOffset(long long_0)
	{
		if (this.interface0_0 != null)
		{
			return this.interface0_0.IsValidOffset(long_0);
		}
		return long_0 > 0L && long_0 <= this.BaseStream.Length;
	}
}
