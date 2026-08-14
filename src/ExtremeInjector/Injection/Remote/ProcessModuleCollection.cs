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

		internal bool method_0(ProcessModuleInfo gclass1_0)
		{
			return gclass1_0.method_6().Equals(string_0, StringComparison.OrdinalIgnoreCase);
		}

		internal bool method_1(ProcessModuleInfo gclass1_0)
		{
			return gclass1_0.method_8().Equals(string_0, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool smethod_0(string string_1, string string_2, StringComparison stringComparison_0)
		{
			return string_1.Equals(string_2, stringComparison_0);
		}
	}

	[CompilerGenerated]
	public sealed class Class71
	{
		public IntPtr intptr_0;

		internal bool method_0(ProcessModuleInfo gclass1_0)
		{
			return gclass1_0.method_0() == intptr_0;
		}
	}

	[CompilerGenerated]
	public sealed class Class72
	{
		public string string_0;

		internal bool method_0(ProcessModuleInfo gclass1_0)
		{
			return gclass1_0.method_8().Equals(string_0, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool smethod_0(string string_1, string string_2, StringComparison stringComparison_0)
		{
			return string_1.Equals(string_2, stringComparison_0);
		}
	}

	internal RemoteProcess gclass2_0;

	public ProcessModuleInfo this[string string_0] => Find((ProcessModuleInfo gclass1_0) => gclass1_0.method_8().Equals(string_0, StringComparison.OrdinalIgnoreCase));

	public ProcessModuleCollection(RemoteProcess gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public IntPtr method_0(string string_0)
	{
		int num;
		if (!Path.IsPathRooted(string_0))
		{
			num = base.FindIndex((ProcessModuleInfo gclass1_0) => gclass1_0.method_8().Equals(string_0, StringComparison.OrdinalIgnoreCase));
		}
		else
		{
			num = base.FindIndex((ProcessModuleInfo gclass1_0) => gclass1_0.method_6().Equals(string_0, StringComparison.OrdinalIgnoreCase));
		}
		if (num < 0)
		{
			return IntPtr.Zero;
		}
		return base[num].method_0();
	}

	internal static bool smethod_0(string string_0)
	{
		return Path.IsPathRooted(string_0);
	}
}
