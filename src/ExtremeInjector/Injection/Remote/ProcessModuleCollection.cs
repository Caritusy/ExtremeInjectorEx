using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class ProcessModuleCollection : List<ProcessModuleInfo>
{
	[CompilerGenerated]
	public sealed class Class70
	{
		public string string_0;

		internal bool MatchesModuleName(ProcessModuleInfo gclass1_0)
		{
			return gclass1_0.GetModuleName().Equals(string_0, StringComparison.OrdinalIgnoreCase);
		}

		internal bool MatchesFilePath(ProcessModuleInfo gclass1_0)
		{
			return gclass1_0.GetFilePath().Equals(string_0, StringComparison.OrdinalIgnoreCase);
		}
	}

	[CompilerGenerated]
	public sealed class Class71
	{
		public IntPtr intptr_0;

		internal bool MatchesModuleBase(ProcessModuleInfo gclass1_0)
		{
			return gclass1_0.GetModuleBase() == intptr_0;
		}
	}

	[CompilerGenerated]
	public sealed class Class72
	{
		public string string_0;

		internal bool MatchesFilePath(ProcessModuleInfo gclass1_0)
		{
			return gclass1_0.GetFilePath().Equals(string_0, StringComparison.OrdinalIgnoreCase);
		}
	}

	internal RemoteProcess gclass2_0;

	public ProcessModuleInfo this[string string_0] => Find((ProcessModuleInfo gclass1_0) => gclass1_0.GetFilePath().Equals(string_0, StringComparison.OrdinalIgnoreCase));

	public ProcessModuleCollection(RemoteProcess gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public IntPtr GetModuleBase(string string_0)
	{
		int num;
		if (!Path.IsPathRooted(string_0))
		{
			num = base.FindIndex((ProcessModuleInfo gclass1_0) => gclass1_0.GetFilePath().Equals(string_0, StringComparison.OrdinalIgnoreCase));
		}
		else
		{
			num = base.FindIndex((ProcessModuleInfo gclass1_0) => gclass1_0.GetModuleName().Equals(string_0, StringComparison.OrdinalIgnoreCase));
		}
		if (num < 0)
		{
			return IntPtr.Zero;
		}
		return base[num].GetModuleBase();
	}
}
