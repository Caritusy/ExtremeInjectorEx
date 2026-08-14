using System.IO;

public class BoundsCheckedBinaryReader : BinaryReader, ILengthValidator
{
	internal ILengthValidator isValidOffset;

	public BoundsCheckedBinaryReader(Stream stream)
		: base(stream)
	{
		this.isValidOffset = (stream as ILengthValidator);
	}

	public bool IsValidOffset(long longValue)
	{
		if (this.isValidOffset != null)
		{
			return this.isValidOffset.IsValidOffset(longValue);
		}
		return longValue > 0L && longValue <= this.BaseStream.Length;
	}
}
