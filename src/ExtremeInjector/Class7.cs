using System.IO;

internal sealed class Class7 : Class6
{
	private Class7(Stream stream_0, string string_0, bool bool_0, Enum39 enum39_0)
		: base(stream_0, string_0, bool_0, enum39_0)
	{
	}

	void Class6._202A_202C_202E_200F_202C_206C_200C_202D_202A_206E_200F_200C_202D_202C_202B_200C_206B_200D_206C_206F_206E_206D_206F_200D_200E_206A_202A_202B_202B_206B_200C_202D_202E_206D_202E_206E_200C_202E_200E_202E()
	{
		class154_0.method_11(Class171.smethod_24(class154_0, (Class5)this));
	}

	public static Class154 smethod_4(Stream stream_0, string string_0, bool bool_0 = false, Enum39 enum39_0 = Enum39.const_0)
	{
		Class7 @class = new Class7(stream_0, string_0, bool_0, enum39_0);
		if (!@class.vmethod_0())
		{
			return null;
		}
		return @class.class154_0;
	}
}
