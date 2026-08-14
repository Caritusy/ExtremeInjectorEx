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
	public NativeTypes.Struct39 GetProcessRecord()
	{
		return struct39_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetProcessRecord(NativeTypes.Struct39 struct39_1)
	{
		struct39_0 = struct39_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<NativeTypes.Struct40> GetThreads()
	{
		return list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetThreads(List<NativeTypes.Struct40> list_1)
	{
		list_0 = list_1;
	}

	public NativeProcessInfo()
	{
		SetThreads(new List<NativeTypes.Struct40>());
	}
}
