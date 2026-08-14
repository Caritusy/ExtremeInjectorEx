using System.Runtime.CompilerServices;

internal abstract class Class137
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private int int_0;

	[SpecialName]
	[CompilerGenerated]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void method_1(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_2()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void method_3(int int_1)
	{
		int_0 = int_1;
	}

	protected Class137(int int_1)
	{
		while (true)
		{
			int num = -700503343;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -607848980)) % 4)
				{
				case 1u:
					method_1(null);
					num = (int)(num2 * 923626857) ^ -1758856579;
					continue;
				case 0u:
					method_3(int_1);
					num = (int)((num2 * 2042707922) ^ 0x4EE9D967);
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	protected Class137(string string_1)
	{
		method_1(string_1);
		method_3(-1);
	}
}
