using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class NativeLibraryImage
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool DllEntryPoint(IntPtr address, uint uintValue, IntPtr address2);

	internal readonly PeImage exportAddress;

	internal byte[] bytes;

	internal DllEntryPoint dllEntryPoint;

	internal readonly List<DllEntryPoint> items = new List<DllEntryPoint>();

	internal readonly List<IntPtr> items2 = new List<IntPtr>();

	[CompilerGenerated]
	internal IntPtr moduleBase;

	internal static readonly NativeTypes.MemoryProtection[][][] memoryProtectionArrayArrayArray = new NativeTypes.MemoryProtection[2][][]
	{
		new NativeTypes.MemoryProtection[2][]
		{
			new NativeTypes.MemoryProtection[2]
			{
				NativeTypes.MemoryProtection.NoAccess,
				NativeTypes.MemoryProtection.WriteCopy
			},
			new NativeTypes.MemoryProtection[2]
			{
				NativeTypes.MemoryProtection.ReadOnly,
				NativeTypes.MemoryProtection.ReadWrite
			}
		},
		new NativeTypes.MemoryProtection[2][]
		{
			new NativeTypes.MemoryProtection[2]
			{
				NativeTypes.MemoryProtection.Execute,
				NativeTypes.MemoryProtection.ExecuteWriteCopy
			},
			new NativeTypes.MemoryProtection[2]
			{
				NativeTypes.MemoryProtection.ExecuteRead,
				NativeTypes.MemoryProtection.ExecuteReadWrite
			}
		}
	};

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetModuleBase()
	{
		return moduleBase;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetModuleBase(IntPtr address)
	{
		moduleBase = address;
	}

	public NativeLibraryImage(PeImage peImage, bool flag)
	{
		exportAddress = peImage;
		if (exportAddress == null)
		{
			throw new BadImageFormatException("The module bytes do not represent a valid portable executable image.");
		}
		if ((RecoveredRuntime.Is32BitImage(exportAddress) && IntPtr.Size != 4) || (!RecoveredRuntime.Is32BitImage(exportAddress) && IntPtr.Size != 8))
		{
			throw new BadImageFormatException("The image format of the module bytes does not match the process.");
		}
		InitializeImage(flag);
	}

	public NativeLibraryImage(byte[] bytes2, bool flag)
		: this(RecoveredRuntime.LoadPeImageFromBytes(bytes2, PeImageLayout.File), flag)
	{
		exportAddress.Dispose();
	}

	public IntPtr GetExportAddress(string text)
	{
		if (this.exportAddress.GetExports() != null && !(this.GetModuleBase() == IntPtr.Zero))
		{
			foreach (ExportedSymbol @class in this.exportAddress.GetExports().items2)
			{
				if (@class.GetHasName() && @class.GetName() == text)
				{
					return this.GetModuleBase().Add((long)((ulong)@class.GetAddressRva()));
				}
			}
			return IntPtr.Zero;
		}
		return IntPtr.Zero;
	}

	internal void InitializeImage(bool flag)
	{
		this.SetModuleBase(RecoveredRuntime.VirtualAlloc((IntPtr)((long)this.exportAddress.GetHeaders().GetOptionalHeader().GetImageBase()), (UIntPtr)this.exportAddress.GetHeaders().GetOptionalHeader().GetSizeOfImage(), NativeTypes.MemoryAllocationType.Commit | NativeTypes.MemoryAllocationType.Reserve, NativeTypes.MemoryProtection.ReadWrite));
		if (this.GetModuleBase() == IntPtr.Zero)
		{
			this.SetModuleBase(RecoveredRuntime.VirtualAlloc(IntPtr.Zero, (UIntPtr)this.exportAddress.GetHeaders().GetOptionalHeader().GetSizeOfImage(), NativeTypes.MemoryAllocationType.Commit | NativeTypes.MemoryAllocationType.Reserve, NativeTypes.MemoryProtection.ReadWrite));
		}
		if (flag)
		{
			int num = (int)(this.exportAddress.GetDosHeader().GetPeHeaderOffset() + this.exportAddress.GetHeaders().GetOptionalHeader().GetSizeOfHeaders());
			using (Stream stream = RecoveredRuntime.CopyImageRange(this.exportAddress, 0L, num))
			{
				byte[] array = new byte[num];
				stream.Read(array, 0, num);
				Marshal.Copy(array, 0, this.GetModuleBase(), array.Length);
			}
		}
		this.MapSections();
		if (this.exportAddress.GetBaseRelocations() != null)
		{
			IntPtr intPtr = this.GetModuleBase().Subtract((IntPtr)((long)this.exportAddress.GetHeaders().GetOptionalHeader().GetImageBase()));
			if (intPtr != IntPtr.Zero)
			{
				this.ApplyBaseRelocations(intPtr);
			}
		}
		this.ResolveImports(this.exportAddress.GetImports());
		if (this.exportAddress.GetDelayImports() != null)
		{
			this.ResolveImports(this.exportAddress.GetDelayImports());
		}
		this.ApplySectionProtections();
		if (this.exportAddress.GetTlsDirectory() != null)
		{
			foreach (ulong num2 in this.exportAddress.GetTlsDirectory().items)
			{
				long long_ = (long)(num2 - this.exportAddress.GetHeaders().GetOptionalHeader().GetImageBase());
				IntPtr ptr = this.GetModuleBase().Add(long_);
				NativeLibraryImage.DllEntryPoint @delegate = (NativeLibraryImage.DllEntryPoint)Marshal.GetDelegateForFunctionPointer(ptr, typeof(NativeLibraryImage.DllEntryPoint));
				if (!@delegate(this.GetModuleBase(), 1u, IntPtr.Zero))
				{
					throw new Exception(EncodedStringTable.DecodeString(9232) + ptr.ToString(EncodedStringTable.DecodeString(2077)) + EncodedStringTable.DecodeString(9277));
				}
				this.items.Add(@delegate);
			}
		}
		if (this.exportAddress.GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint() != 0u)
		{
			IntPtr ptr2 = this.GetModuleBase().Add((long)((ulong)this.exportAddress.GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint()));
			this.dllEntryPoint = (NativeLibraryImage.DllEntryPoint)Marshal.GetDelegateForFunctionPointer(ptr2, typeof(NativeLibraryImage.DllEntryPoint));
			if (!this.dllEntryPoint(this.GetModuleBase(), 1u, IntPtr.Zero))
			{
				throw new Exception(EncodedStringTable.DecodeString(9302));
			}
		}
	}

	internal void ApplySectionProtections()
	{
		foreach (PeSectionHeader section in exportAddress.GetSections())
		{
			IntPtr address = GetModuleBase().Add(section.GetVirtualAddress());
			SectionCharacteristics characteristics = section.GetCharacteristics();
			if ((characteristics & SectionCharacteristics.Discardable) != 0)
			{
				RecoveredRuntime.VirtualFree(address, (UIntPtr)section.GetVirtualSize(), NativeTypes.MemoryFreeType.Decommit);
				continue;
			}

			bool executable = (characteristics & SectionCharacteristics.Execute) != 0;
			bool readable = (characteristics & SectionCharacteristics.Read) != 0;
			bool writable = (characteristics & SectionCharacteristics.Write) != 0;
			NativeTypes.MemoryProtection protection = memoryProtectionArrayArrayArray[executable ? 1 : 0][readable ? 1 : 0][writable ? 1 : 0];
			if ((characteristics & SectionCharacteristics.NotCached) != 0)
			{
				protection |= NativeTypes.MemoryProtection.NoCache;
			}

			if (!RecoveredRuntime.VirtualProtect(address, (UIntPtr)section.GetVirtualSize(), protection, out _))
			{
				throw new AccessViolationException("Unable to change the protection of the section, '" + section.GetName() + "'.");
			}
		}
	}

	internal void ResolveImports(ImportDirectory importDirectory)
	{
		if (this.bytes == null)
		{
			this.bytes = this.ExtractManifestResource();
		}
		IntPtr value = NativeTypes.address;
		IntPtr zero = IntPtr.Zero;
		if (this.bytes != null)
		{
			string tempFileName = Path.GetTempFileName();
			File.WriteAllBytes(tempFileName, this.bytes);
			NativeTypes.ActivationContext @struct = default(NativeTypes.ActivationContext);
			@struct.intValue = Marshal.SizeOf(typeof(NativeTypes.ActivationContext));
			@struct.text = tempFileName;
			NativeTypes.ActivationContext struct2 = @struct;
			value = RecoveredRuntime.CreateActCtx(ref struct2);
			RecoveredRuntime.ActivateActCtx(value, out zero);
			File.Delete(tempFileName);
		}
		for (int i = 0; i < importDirectory.items.Count; i++)
		{
			ImportDescriptor @class = importDirectory.items[i];
			IntPtr ptr = this.GetModuleBase().Add((long)((ulong)@class.GetFirstThunk()));
			string text = @class.GetModuleName();
			IntPtr intPtr = RecoveredRuntime.LoadLibrary(text);
			if (intPtr == IntPtr.Zero)
			{
				throw new DllNotFoundException(EncodedStringTable.DecodeString(9433) + text + EncodedStringTable.DecodeString(9470));
			}
			this.items2.Add(intPtr);
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
		if (value != NativeTypes.address)
		{
			RecoveredRuntime.DeactivateActCtx(0, zero);
			RecoveredRuntime.ReleaseActCtx(value);
		}
	}

	internal byte[] ExtractManifestResource()
	{
		if (this.exportAddress.GetResources() == null)
		{
			return null;
		}
		foreach (ResourceDirectoryNode @class in this.exportAddress.GetResources().GetRoot().GetSubdirectories())
		{
			if (RecoveredRuntime.HasNumericResourceIdentifier(@class) && @class.GetId() == 24 && @class.GetSubdirectories().Count == 1 && @class.GetSubdirectories()[0].GetDataEntries().Count == 1)
			{
				ResourceDataEntry class2 = @class.GetSubdirectories()[0].GetDataEntries()[0];
				long num = RecoveredRuntime.MapRvaToFileOffset(this.exportAddress, class2.GetDataRva());
				if (num != -1L)
				{
					byte[] array = new byte[class2.GetSize()];
					using (Stream stream = RecoveredRuntime.CopyImageRange(this.exportAddress, num, (int)class2.GetSize()))
					{
						stream.Read(array, 0, array.Length);
					}
					return array;
				}
			}
		}
		return null;
	}

	internal void ApplyBaseRelocations(IntPtr address)
	{
		foreach (BaseRelocationBlock @class in this.exportAddress.GetBaseRelocations().items)
		{
			foreach (BaseRelocationEntry class2 in @class.items)
			{
				if (class2.GetRelocationType() == BaseRelocationType.Dir64 || class2.GetRelocationType() == BaseRelocationType.HighLow)
				{
					IntPtr ptr = this.GetModuleBase().Add((long)((ulong)(@class.GetPageRva() + class2.GetOffset())));
					IntPtr intPtr = Marshal.ReadIntPtr(ptr);
					Marshal.WriteIntPtr(ptr, intPtr.Add(address));
				}
			}
		}
	}

	internal void MapSections()
	{
		foreach (PeSectionHeader gclass in this.exportAddress.GetSections())
		{
			IntPtr intPtr;
			if (gclass.GetSizeOfRawData() != 0u)
			{
				IntPtr destination = RecoveredRuntime.VirtualAlloc(this.GetModuleBase().Add((long)((ulong)gclass.GetVirtualAddress())), (UIntPtr)gclass.GetSizeOfRawData(), NativeTypes.MemoryAllocationType.Commit, NativeTypes.MemoryProtection.ReadWrite);
				using (Stream stream = RecoveredRuntime.CopyImageRange(this.exportAddress, (long)((ulong)gclass.GetPointerToRawData()), (int)gclass.GetSizeOfRawData()))
				{
					byte[] array = new byte[gclass.GetSizeOfRawData()];
					stream.Read(array, 0, array.Length);
					Marshal.Copy(array, 0, destination, array.Length);
					continue;
				}
			}
			else
			{
				intPtr = RecoveredRuntime.VirtualAlloc(this.GetModuleBase().Add((long)((ulong)gclass.GetVirtualAddress())), (UIntPtr)gclass.GetVirtualSize(), NativeTypes.MemoryAllocationType.Commit, NativeTypes.MemoryProtection.ReadWrite);
			}
			long long_ = (long)((ulong)gclass.GetVirtualSize());
			RecoveredRuntime.ZeroMemory(long_, intPtr, 0);
		}
	}
}
