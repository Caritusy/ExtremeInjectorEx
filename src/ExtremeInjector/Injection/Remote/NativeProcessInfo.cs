using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class NativeProcessInfo
{
	[CompilerGenerated]
	internal NativeTypes.Struct39 struct39_0;

	[CompilerGenerated]
	internal List<NativeTypes.Struct40> list_0;

	[SpecialName]
	[CompilerGenerated]
	public NativeTypes.Struct39 method_0()
	{
		return struct39_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(NativeTypes.Struct39 struct39_1)
	{
		struct39_0 = struct39_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<NativeTypes.Struct40> method_2()
	{
		return list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(List<NativeTypes.Struct40> list_1)
	{
		list_0 = list_1;
	}

	public NativeProcessInfo()
	{
		method_3(new List<NativeTypes.Struct40>());
	}
}
