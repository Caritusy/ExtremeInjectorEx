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
	public IntPtr GetModuleBase()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetModuleBase(IntPtr intptr_2)
	{
		intptr_0 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetEntryPoint()
	{
		return intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetEntryPoint(IntPtr intptr_2)
	{
		intptr_1 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetImageSize()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetImageSize(uint uint_1)
	{
		uint_0 = uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GetModuleName()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetModuleName(string string_2)
	{
		string_0 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GetFilePath()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetFilePath(string string_2)
	{
		string_1 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetIs32Bit()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetIs32Bit(bool bool_2)
	{
		bool_0 = bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetIsManualMapped()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetIsManualMapped(bool bool_2)
	{
		bool_1 = bool_2;
	}

	internal ProcessModuleInfo(RemoteProcess gclass2_1, ProcessModuleCollection class69_1, IntPtr intptr_2, bool bool_2)
		: this(gclass2_1, class69_1, intptr_2, bool_2, bool_3: false)
	{
	}

	internal ProcessModuleInfo(RemoteProcess gclass2_1, ProcessModuleCollection class69_1, IntPtr intptr_2, bool bool_2, bool bool_3)
	{
		SetModuleBase(intptr_2);
		SetIs32Bit(bool_2);
		SetIsManualMapped(bool_3);
		gclass2_0 = gclass2_1;
		class69_0 = class69_1;
	}

	internal IntPtr GetExportAddress(object object_0, bool bool_2)
	{
		bool flag;
		ushort num = (!(flag = (object_0 is ushort))) ? (ushort)0 : ((ushort)object_0);
		string b = (object_0 is string) ? ((string)object_0) : null;
		if (this.list_0 == null)
		{
			foreach (KeyValuePair<ProcessModuleInfo, List<ExportedSymbol>> keyValuePair in this.gclass2_0.dictionary_0)
			{
				if (keyValuePair.Key.GetModuleBase() == this.GetModuleBase() && keyValuePair.Key.GetImageSize() == this.GetImageSize() && keyValuePair.Key.GetModuleName() == this.GetModuleName() && keyValuePair.Key.GetEntryPoint() == this.GetEntryPoint())
				{
					this.list_0 = keyValuePair.Value;
					break;
				}
			}
		}
		if (this.list_0 == null && RecoveredRuntime.GetRemoteModuleExports(this).Count == 0)
		{
			return IntPtr.Zero;
		}

		foreach (ExportedSymbol symbol in this.list_0)
		{
			if ((flag && symbol.GetOrdinal() != num) || (!flag && (!symbol.GetHasName() || symbol.GetName() != b)))
			{
				continue;
			}

			if (!RecoveredRuntime.IsForwardedExport(symbol))
			{
				return this.GetModuleBase().Add((long)((ulong)symbol.GetAddressRva()));
			}

			ProcessModuleCollection modules = this.class69_0 == null || !bool_2
				? RecoveredRuntime.CaptureProcessModules(this.gclass2_0)
				: this.class69_0;
			ProcessModuleInfo forwardedModule = modules[symbol.GetForwarder().GetModuleName()];
			if (forwardedModule == null)
			{
				if (symbol.GetForwarder().GetModuleName().IndexOf(EncodedStringTable.DecodeString(8498), StringComparison.OrdinalIgnoreCase) == -1)
				{
					forwardedModule = RecoveredRuntime.LoadForwardedExportModule(this, symbol.GetForwarder().GetModuleName());
					if (forwardedModule == null)
					{
						return IntPtr.Zero;
					}
					return RecoveredRuntime.ResolveExportByName(forwardedModule, symbol.GetForwarder().GetName(), false);
				}

				string resolvedPath = RecoveredRuntime.ResolveDependencyPath(symbol.GetForwarder().GetModuleName(), this.GetFilePath(), null, DependencySearchFlags.flag_1, 0, IntPtr.Zero);
				if (!string.IsNullOrEmpty(resolvedPath))
				{
					forwardedModule = modules[resolvedPath];
				}
				if (forwardedModule == null)
				{
					return IntPtr.Zero;
				}
			}

			return symbol.GetForwarder().GetIsOrdinal()
				? RecoveredRuntime.ResolveExportByName(forwardedModule, symbol.GetForwarder().GetName(), false)
				: RecoveredRuntime.ResolveExportByOrdinal(forwardedModule, symbol.GetForwarder().GetOrdinal(), false);
		}

		return IntPtr.Zero;
	}
}
