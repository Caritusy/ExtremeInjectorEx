using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class NativeLibraryImage
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate45(IntPtr intptr_0, uint uint_0, IntPtr intptr_1);

	internal readonly PeImage class154_0;

	internal byte[] byte_0;

	internal Delegate45 delegate45_0;

	internal readonly List<Delegate45> list_0 = new List<Delegate45>();

	internal readonly List<IntPtr> list_1 = new List<IntPtr>();

	[CompilerGenerated]
	internal IntPtr intptr_0;

	internal static readonly NativeTypes.Enum34[][][] enum34_0 = new NativeTypes.Enum34[2][][]
	{
		new NativeTypes.Enum34[2][]
		{
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_4,
				NativeTypes.Enum34.flag_7
			},
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_5,
				NativeTypes.Enum34.flag_6
			}
		},
		new NativeTypes.Enum34[2][]
		{
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_0,
				NativeTypes.Enum34.flag_3
			},
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_1,
				NativeTypes.Enum34.flag_2
			}
		}
	};

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetModuleBase()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetModuleBase(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	public NativeLibraryImage(PeImage class154_1, bool bool_0)
	{
		class154_0 = class154_1;
		if (class154_0 == null)
		{
			throw new BadImageFormatException("The module bytes do not represent a valid portable executable image.");
		}
		if ((RecoveredRuntime.Is32BitImage(class154_0) && IntPtr.Size != 4) || (!RecoveredRuntime.Is32BitImage(class154_0) && IntPtr.Size != 8))
		{
			throw new BadImageFormatException("The image format of the module bytes does not match the process.");
		}
		InitializeImage(bool_0);
	}

	public NativeLibraryImage(byte[] byte_1, bool bool_0)
		: this(RecoveredRuntime.LoadPeImageFromBytes(byte_1, PeImageLayout.const_0), bool_0)
	{
		class154_0.Dispose();
	}

	public IntPtr GetExportAddress(string string_0)
	{
		if (this.class154_0.GetExports() != null && !(this.GetModuleBase() == IntPtr.Zero))
		{
			foreach (ExportedSymbol @class in this.class154_0.GetExports().list_1)
			{
				if (@class.GetHasName() && @class.GetName() == string_0)
				{
					return this.GetModuleBase().Add((long)((ulong)@class.GetAddressRva()));
				}
			}
			return IntPtr.Zero;
		}
		return IntPtr.Zero;
	}

	internal void InitializeImage(bool bool_0)
	{
		this.SetModuleBase(RecoveredRuntime.VirtualAlloc((IntPtr)((long)this.class154_0.GetHeaders().GetOptionalHeader().GetImageBase()), (UIntPtr)this.class154_0.GetHeaders().GetOptionalHeader().GetSizeOfImage(), NativeTypes.Enum33.flag_0 | NativeTypes.Enum33.flag_1, NativeTypes.Enum34.flag_6));
		if (this.GetModuleBase() == IntPtr.Zero)
		{
			this.SetModuleBase(RecoveredRuntime.VirtualAlloc(IntPtr.Zero, (UIntPtr)this.class154_0.GetHeaders().GetOptionalHeader().GetSizeOfImage(), NativeTypes.Enum33.flag_0 | NativeTypes.Enum33.flag_1, NativeTypes.Enum34.flag_6));
		}
		if (bool_0)
		{
			int num = (int)(this.class154_0.GetDosHeader().GetPeHeaderOffset() + this.class154_0.GetHeaders().GetOptionalHeader().GetSizeOfHeaders());
			using (Stream stream = RecoveredRuntime.CopyImageRange(this.class154_0, 0L, num))
			{
				byte[] array = new byte[num];
				stream.Read(array, 0, num);
				Marshal.Copy(array, 0, this.GetModuleBase(), array.Length);
			}
		}
		this.MapSections();
		if (this.class154_0.GetBaseRelocations() != null)
		{
			IntPtr intPtr = this.GetModuleBase().Subtract((IntPtr)((long)this.class154_0.GetHeaders().GetOptionalHeader().GetImageBase()));
			if (intPtr != IntPtr.Zero)
			{
				this.ApplyBaseRelocations(intPtr);
			}
		}
		this.ResolveImports(this.class154_0.GetImports());
		if (this.class154_0.GetDelayImports() != null)
		{
			this.ResolveImports(this.class154_0.GetDelayImports());
		}
		this.ApplySectionProtections();
		if (this.class154_0.GetTlsDirectory() != null)
		{
			foreach (ulong num2 in this.class154_0.GetTlsDirectory().list_0)
			{
				long long_ = (long)(num2 - this.class154_0.GetHeaders().GetOptionalHeader().GetImageBase());
				IntPtr ptr = this.GetModuleBase().Add(long_);
				NativeLibraryImage.Delegate45 @delegate = (NativeLibraryImage.Delegate45)Marshal.GetDelegateForFunctionPointer(ptr, typeof(NativeLibraryImage.Delegate45));
				if (!@delegate(this.GetModuleBase(), 1u, IntPtr.Zero))
				{
					throw new Exception(EncodedStringTable.DecodeString(9232) + ptr.ToString(EncodedStringTable.DecodeString(2077)) + EncodedStringTable.DecodeString(9277));
				}
				this.list_0.Add(@delegate);
			}
		}
		if (this.class154_0.GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint() != 0u)
		{
			IntPtr ptr2 = this.GetModuleBase().Add((long)((ulong)this.class154_0.GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint()));
			this.delegate45_0 = (NativeLibraryImage.Delegate45)Marshal.GetDelegateForFunctionPointer(ptr2, typeof(NativeLibraryImage.Delegate45));
			if (!this.delegate45_0(this.GetModuleBase(), 1u, IntPtr.Zero))
			{
				throw new Exception(EncodedStringTable.DecodeString(9302));
			}
		}
	}

	internal void ApplySectionProtections()
	{
		foreach (PeSectionHeader section in class154_0.GetSections())
		{
			IntPtr address = GetModuleBase().Add(section.GetVirtualAddress());
			SectionCharacteristics characteristics = section.GetCharacteristics();
			if ((characteristics & SectionCharacteristics.flag_28) != 0)
			{
				RecoveredRuntime.VirtualFree(address, (UIntPtr)section.GetVirtualSize(), NativeTypes.Enum28.const_0);
				continue;
			}

			bool executable = (characteristics & SectionCharacteristics.flag_32) != 0;
			bool readable = (characteristics & SectionCharacteristics.flag_33) != 0;
			bool writable = (characteristics & SectionCharacteristics.flag_34) != 0;
			NativeTypes.Enum34 protection = enum34_0[executable ? 1 : 0][readable ? 1 : 0][writable ? 1 : 0];
			if ((characteristics & SectionCharacteristics.flag_29) != 0)
			{
				protection |= NativeTypes.Enum34.flag_9;
			}

			if (!RecoveredRuntime.VirtualProtect(address, (UIntPtr)section.GetVirtualSize(), protection, out _))
			{
				throw new AccessViolationException("Unable to change the protection of the section, '" + section.GetName() + "'.");
			}
		}
	}

	internal void ResolveImports(ImportDirectory class148_0)
	{
		if (this.byte_0 == null)
		{
			this.byte_0 = this.ExtractManifestResource();
		}
		IntPtr value = NativeTypes.intptr_0;
		IntPtr zero = IntPtr.Zero;
		if (this.byte_0 != null)
		{
			string tempFileName = Path.GetTempFileName();
			File.WriteAllBytes(tempFileName, this.byte_0);
			NativeTypes.Struct50 @struct = default(NativeTypes.Struct50);
			@struct.int_0 = Marshal.SizeOf(typeof(NativeTypes.Struct50));
			@struct.string_0 = tempFileName;
			NativeTypes.Struct50 struct2 = @struct;
			value = RecoveredRuntime.CreateActCtx(ref struct2);
			RecoveredRuntime.ActivateActCtx(value, out zero);
			File.Delete(tempFileName);
		}
		for (int i = 0; i < class148_0.list_0.Count; i++)
		{
			ImportDescriptor @class = class148_0.list_0[i];
			IntPtr ptr = this.GetModuleBase().Add((long)((ulong)@class.GetFirstThunk()));
			string text = @class.GetModuleName();
			IntPtr intPtr = RecoveredRuntime.LoadLibrary(text);
			if (intPtr == IntPtr.Zero)
			{
				throw new DllNotFoundException(EncodedStringTable.DecodeString(9433) + text + EncodedStringTable.DecodeString(9470));
			}
			this.list_1.Add(intPtr);
			foreach (ImportedSymbol class2 in @class.GetOriginalThunkSymbols())
			{
				string text2 = class2.GetIsOrdinal() ? ((char)class2.GetOrdinal()).ToString() : class2.GetName();
				IntPtr procAddress = RecoveredRuntime.GetProcAddress(intPtr, text2);
				if (procAddress == IntPtr.Zero && !class2.GetIsOrdinal())
				{
					throw new MissingMethodException(string.Concat(new string[]
					{
						EncodedStringTable.DecodeString(9531),
						text2,
						EncodedStringTable.DecodeString(9572),
						text,
						EncodedStringTable.DecodeString(9428)
					}));
				}
				Marshal.WriteIntPtr(ptr, procAddress);
				ptr = ptr.Add(IntPtr.Size);
			}
		}
		if (value != NativeTypes.intptr_0)
		{
			RecoveredRuntime.DeactivateActCtx(0, zero);
			RecoveredRuntime.ReleaseActCtx(value);
		}
	}

	internal byte[] ExtractManifestResource()
	{
		if (this.class154_0.GetResources() == null)
		{
			return null;
		}
		foreach (ResourceDirectoryNode @class in this.class154_0.GetResources().GetRoot().GetSubdirectories())
		{
			if (RecoveredRuntime.HasNumericResourceIdentifier(@class) && @class.GetId() == 24 && @class.GetSubdirectories().Count == 1 && @class.GetSubdirectories()[0].GetDataEntries().Count == 1)
			{
				ResourceDataEntry class2 = @class.GetSubdirectories()[0].GetDataEntries()[0];
				long num = RecoveredRuntime.MapRvaToFileOffset(this.class154_0, class2.GetDataRva());
				if (num != -1L)
				{
					byte[] array = new byte[class2.GetSize()];
					using (Stream stream = RecoveredRuntime.CopyImageRange(this.class154_0, num, (int)class2.GetSize()))
					{
						stream.Read(array, 0, array.Length);
					}
					return array;
				}
			}
		}
		return null;
	}

	internal void ApplyBaseRelocations(IntPtr intptr_1)
	{
		foreach (BaseRelocationBlock @class in this.class154_0.GetBaseRelocations().list_0)
		{
			foreach (BaseRelocationEntry class2 in @class.list_0)
			{
				if (class2.GetRelocationType() == BaseRelocationType.Dir64 || class2.GetRelocationType() == BaseRelocationType.HighLow)
				{
					IntPtr ptr = this.GetModuleBase().Add((long)((ulong)(@class.GetPageRva() + class2.GetOffset())));
					IntPtr intPtr = Marshal.ReadIntPtr(ptr);
					Marshal.WriteIntPtr(ptr, intPtr.Add(intptr_1));
				}
			}
		}
	}

	internal void MapSections()
	{
		foreach (PeSectionHeader gclass in this.class154_0.GetSections())
		{
			IntPtr intPtr;
			if (gclass.GetSizeOfRawData() != 0u)
			{
				IntPtr destination = RecoveredRuntime.VirtualAlloc(this.GetModuleBase().Add((long)((ulong)gclass.GetVirtualAddress())), (UIntPtr)gclass.GetSizeOfRawData(), NativeTypes.Enum33.flag_0, NativeTypes.Enum34.flag_6);
				using (Stream stream = RecoveredRuntime.CopyImageRange(this.class154_0, (long)((ulong)gclass.GetPointerToRawData()), (int)gclass.GetSizeOfRawData()))
				{
					byte[] array = new byte[gclass.GetSizeOfRawData()];
					stream.Read(array, 0, array.Length);
					Marshal.Copy(array, 0, destination, array.Length);
					continue;
				}
			}
			else
			{
				intPtr = RecoveredRuntime.VirtualAlloc(this.GetModuleBase().Add((long)((ulong)gclass.GetVirtualAddress())), (UIntPtr)gclass.GetVirtualSize(), NativeTypes.Enum33.flag_0, NativeTypes.Enum34.flag_6);
			}
			long long_ = (long)((ulong)gclass.GetVirtualSize());
			RecoveredRuntime.ZeroMemory(long_, intPtr, 0);
		}
	}
}
