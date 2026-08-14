using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ImportDescriptor
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal uint uint_2;

	[CompilerGenerated]
	internal uint uint_3;

	[CompilerGenerated]
	internal uint uint_4;

	[CompilerGenerated]
	internal List<ImportedSymbol> list_0;

	[CompilerGenerated]
	internal List<ImportedSymbol> list_1;

	[CompilerGenerated]
	internal string string_0;

	[SpecialName]
	[CompilerGenerated]
	public uint method_0()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(uint uint_5)
	{
		uint_0 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_2(uint uint_5)
	{
		uint_1 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(uint uint_5)
	{
		uint_2 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_4()
	{
		return uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(uint uint_5)
	{
		uint_3 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_6()
	{
		return uint_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(uint uint_5)
	{
		uint_4 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<ImportedSymbol> method_8()
	{
		return list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(List<ImportedSymbol> list_2)
	{
		list_0 = list_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<ImportedSymbol> method_10()
	{
		return list_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(List<ImportedSymbol> list_2)
	{
		list_1 = list_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_12()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_13(string string_1)
	{
		string_0 = string_1;
	}

	public ImportDescriptor()
	{
		while (true)
		{
			int num = 1299504858;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5AAD8739)) % 3)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				method_9(new List<ImportedSymbol>());
				method_11(new List<ImportedSymbol>());
				num = (int)((num2 * 1468486695) ^ 0x33FCD510);
			}
		}
	}
}
