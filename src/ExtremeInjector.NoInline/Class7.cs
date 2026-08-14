using System.IO;

public sealed class Class7 : Class6
{
	internal Class7(Stream stream_0, string string_0, bool bool_0, Enum39 enum39_0)
		: base(stream_0, string_0, bool_0, enum39_0)
	{
	}

	protected override void method_0040()
	{
		class154_0.method_11(Class171.smethod_24(class154_0, this));
	}

	public static Class154 smethod_13(Stream stream_0, string string_0, bool bool_0, Enum39 enum39_0)
	{
		Class7 @class = new Class7(stream_0, string_0, bool_0, enum39_0);
		if (!@class.vmethod_0())
		{
			return null;
		}
		return @class.class154_0;
	}
}
