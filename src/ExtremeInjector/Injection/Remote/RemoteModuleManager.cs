using System;
using System.Runtime.CompilerServices;

public sealed class RemoteModuleManager : RemoteProcessComponent
{
	[CompilerGenerated]
	public sealed class ModuleMatchContext
	{
		public ProcessModuleInfo gclass1_0;

		internal bool method_0(ProcessModuleInfo gclass1_1)
		{
			if (gclass1_1.method_8().Equals("ntdll.dll", StringComparison.OrdinalIgnoreCase))
			{
				return gclass1_1.method_10() == gclass1_0.method_10();
			}
			return false;
		}

		internal bool method_1(ProcessModuleInfo gclass1_1)
		{
			return gclass1_1.method_0() != gclass1_0.method_0();
		}

		internal static bool smethod_0(string string_0, string string_1, StringComparison stringComparison_0)
		{
			return string_0.Equals(string_1, stringComparison_0);
		}
	}

	public RemoteModuleManager(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
	}

	protected override void method_04C6()
	{
		if (base.method_2() == IntPtr.Zero && base.method_0() != -1)
		{
			base.method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.method_0()));
		}
	}
}
