using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ProcessModuleInfo
{
	[CompilerGenerated]
	internal IntPtr intptr_0;

	[CompilerGenerated]
	internal IntPtr intptr_1;

	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	internal string string_1;

	[CompilerGenerated]
	internal bool bool_0;

	[CompilerGenerated]
	internal bool bool_1;

	internal List<ExportedSymbol> list_0;

	internal RemoteProcess gclass2_0;

	internal ProcessModuleCollection class69_0;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_0()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(IntPtr intptr_2)
	{
		intptr_0 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_2()
	{
		return intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(IntPtr intptr_2)
	{
		intptr_1 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_4()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_5(uint uint_1)
	{
		uint_0 = uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_6()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_7(string string_2)
	{
		string_0 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_8()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_9(string string_2)
	{
		string_1 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_10()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_11(bool bool_2)
	{
		bool_0 = bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_12()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_13(bool bool_2)
	{
		bool_1 = bool_2;
	}

	internal ProcessModuleInfo(RemoteProcess gclass2_1, ProcessModuleCollection class69_1, IntPtr intptr_2, bool bool_2)
		: this(gclass2_1, class69_1, intptr_2, bool_2, bool_3: false)
	{
	}

	internal ProcessModuleInfo(RemoteProcess gclass2_1, ProcessModuleCollection class69_1, IntPtr intptr_2, bool bool_2, bool bool_3)
	{
		method_1(intptr_2);
		method_11(bool_2);
		method_13(bool_3);
		gclass2_0 = gclass2_1;
		class69_0 = class69_1;
	}

	internal IntPtr method_14(object object_0, bool bool_2)
	{
		bool flag;
		ushort num = (!(flag = (object_0 is ushort))) ? (ushort)0 : ((ushort)object_0);
		string b = (object_0 is string) ? ((string)object_0) : null;
		if (this.list_0 == null)
		{
			foreach (KeyValuePair<ProcessModuleInfo, List<ExportedSymbol>> keyValuePair in this.gclass2_0.dictionary_0)
			{
				if (keyValuePair.Key.method_0() == this.method_0() && keyValuePair.Key.method_4() == this.method_4() && keyValuePair.Key.method_6() == this.method_6() && keyValuePair.Key.method_2() == this.method_2())
				{
					this.list_0 = keyValuePair.Value;
					break;
				}
			}
		}
		if (this.list_0 == null && RecoveredRuntime.smethod_131(this).Count == 0)
		{
			return IntPtr.Zero;
		}

		foreach (ExportedSymbol symbol in this.list_0)
		{
			if ((flag && symbol.method_2() != num) || (!flag && (!symbol.method_0() || symbol.method_4() != b)))
			{
				continue;
			}

			if (!RecoveredRuntime.smethod_85(symbol))
			{
				return this.method_0().smethod_9((long)((ulong)symbol.method_6()));
			}

			ProcessModuleCollection modules = this.class69_0 == null || !bool_2
				? RecoveredRuntime.smethod_42(this.gclass2_0)
				: this.class69_0;
			ProcessModuleInfo forwardedModule = modules[symbol.method_8().method_0()];
			if (forwardedModule == null)
			{
				if (symbol.method_8().method_0().IndexOf(EncodedStringTable.smethod_0(8498), StringComparison.OrdinalIgnoreCase) == -1)
				{
					forwardedModule = RecoveredRuntime.smethod_231(this, symbol.method_8().method_0());
					if (forwardedModule == null)
					{
						return IntPtr.Zero;
					}
					return RecoveredRuntime.smethod_225(forwardedModule, symbol.method_8().method_6(), false);
				}

				string resolvedPath = RecoveredRuntime.smethod_440(symbol.method_8().method_0(), this.method_8(), null, DependencySearchFlags.flag_1, 0, IntPtr.Zero);
				if (!string.IsNullOrEmpty(resolvedPath))
				{
					forwardedModule = modules[resolvedPath];
				}
				if (forwardedModule == null)
				{
					return IntPtr.Zero;
				}
			}

			return symbol.method_8().method_2()
				? RecoveredRuntime.smethod_225(forwardedModule, symbol.method_8().method_6(), false)
				: RecoveredRuntime.smethod_248(forwardedModule, symbol.method_8().method_4(), false);
		}

		return IntPtr.Zero;
	}

	internal static bool smethod_0(string string_2, string string_3)
	{
		return string_2 == string_3;
	}

	internal static bool smethod_1(string string_2, string string_3)
	{
		return string_2 != string_3;
	}

	internal static int smethod_2(string string_2, string string_3, StringComparison stringComparison_0)
	{
		return string_2.IndexOf(string_3, stringComparison_0);
	}

	internal static bool smethod_3(string string_2)
	{
		return string.IsNullOrEmpty(string_2);
	}
}
