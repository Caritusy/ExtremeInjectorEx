using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class ManualMapInjector(RemoteProcess remoteProcess) : DllInjector(remoteProcess)
{
	[Flags]
	public enum ManualMapOptions
	{
		DisableSehValidation = 1,
		DisableExceptionSupport = 2,
		ErasePeHeaders = 4,
		ResolveImportsManually = 0x10,
		UseVectoredExceptionHandler = 0x20,
		SkipActivationContext = 0x40,
		SkipDelayImports = 0x80
	}

	public sealed class MappingContext
	{
		[CompilerGenerated]
		internal PeImage image;

		[CompilerGenerated]
		internal IntPtr moduleBase;

		[CompilerGenerated]
		internal string filePath;

		[CompilerGenerated]
		internal string fileName;

		[CompilerGenerated]
		internal ManualMapOptions options;

		[CompilerGenerated]
		internal IntPtr activationContextHandle;

		[CompilerGenerated]
		internal IntPtr remoteActivationContext;

		[CompilerGenerated]
		internal List<int> tlsCallbacks;

		[SpecialName]
		[CompilerGenerated]
		public PeImage GetImage()
		{
			return image;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetImage(PeImage peImage)
		{
			image = peImage;
		}

		[SpecialName]
		[CompilerGenerated]
		public IntPtr GetModuleBase()
		{
			return moduleBase;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetModuleBase(IntPtr address)
		{
			moduleBase = address;
		}

		[SpecialName]
		[CompilerGenerated]
		public string GetFilePath()
		{
			return filePath;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetFilePath(string text)
		{
			filePath = text;
		}

		[SpecialName]
		[CompilerGenerated]
		public string GetFileName()
		{
			return fileName;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetFileName(string text)
		{
			fileName = text;
		}

		[SpecialName]
		[CompilerGenerated]
		public ManualMapOptions GetOptions()
		{
			return options;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetOptions(ManualMapOptions manualMapOptions)
		{
			options = manualMapOptions;
		}

		[SpecialName]
		[CompilerGenerated]
		public IntPtr GetActivationContextHandle()
		{
			return activationContextHandle;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetActivationContextHandle(IntPtr address)
		{
			activationContextHandle = address;
		}

		[SpecialName]
		[CompilerGenerated]
		public IntPtr GetRemoteActivationContext()
		{
			return remoteActivationContext;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetRemoteActivationContext(IntPtr address)
		{
			remoteActivationContext = address;
		}

		[SpecialName]
		[CompilerGenerated]
		public List<int> GetTlsCallbacks()
		{
			return tlsCallbacks;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetTlsCallbacks(List<int> items)
		{
			tlsCallbacks = items;
		}

		public MappingContext()
		{
			IntPtr intptr_;
			SetRemoteActivationContext(intptr_ = NativeTypes.address);
			SetActivationContextHandle(intptr_);
			SetTlsCallbacks(new List<int>());
		}
	}

	[CompilerGenerated]
	internal bool disableExceptionSupport;

	[CompilerGenerated]
	internal bool erasePeHeaders;

	[CompilerGenerated]
	internal bool manualResolveImports;

	[CompilerGenerated]
	internal bool disableSehValidation;

	[CompilerGenerated]
	internal Exception lastException;

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

	internal List<MappingContext> items = new List<MappingContext>();

	[SpecialName]
	[CompilerGenerated]
	public bool GetDisableExceptionSupport()
	{
		return disableExceptionSupport;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDisableExceptionSupport(bool flag)
	{
		disableExceptionSupport = flag;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetErasePeHeaders()
	{
		return erasePeHeaders;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetErasePeHeaders(bool flag)
	{
		erasePeHeaders = flag;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetManualResolveImports()
	{
		return manualResolveImports;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetManualResolveImports(bool flag)
	{
		manualResolveImports = flag;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetDisableSehValidation()
	{
		return disableSehValidation;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDisableSehValidation(bool flag)
	{
		disableSehValidation = flag;
	}

	[SpecialName]
	[CompilerGenerated]
	public Exception GetLastException()
	{
		return lastException;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetLastException(Exception exception)
	{
		lastException = exception;
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.CreateThread | NativeTypes.ProcessAccessRights.VirtualMemoryOperation | NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.VirtualMemoryWrite | NativeTypes.ProcessAccessRights.QueryInformation, false, base.GetProcessId()));
		}
	}

	public override IntPtr Inject(string text)
	{
		this.SetLastException(null);
		if (!Path.IsPathRooted(text))
		{
			text = Path.GetFullPath(text);
		}
		ManualMapInjector.ManualMapOptions enum44_ = RecoveredRuntime.BuildManualMapOptions(this);
		return this.InjectModule(text, enum44_);
	}

	internal IntPtr InjectModule(string text, ManualMapOptions manualMapOptions)
	{
		if (!File.Exists(text))
		{
			RecoveredRuntime.ResetManualMapOptions(this);
			throw new FileNotFoundException(EncodedStringTable.DecodeString(28151) + text + EncodedStringTable.DecodeString(3656));
		}
		if (!base.EnsureAttachedToProcess(base.GetRemoteProcess().ProcessId))
		{
			RecoveredRuntime.ResetManualMapOptions(this);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(12662));
		}
		if (!base.GetRemoteProcess().IsDepEnabled)
		{
			manualMapOptions |= ManualMapInjector.ManualMapOptions.DisableExceptionSupport;
		}
		IntPtr intPtr = this.MapModule(text, manualMapOptions);
		if (!(intPtr == IntPtr.Zero))
		{
			foreach (ManualMapInjector.MappingContext @class in this.items)
			{
				if (!this.InvokeModuleEntryPoints(@class, 1u))
				{
					RecoveredRuntime.DisposeManualMapContext(@class);
					return IntPtr.Zero;
				}
				if (this.GetErasePeHeaders())
				{
					uint num = @class.GetImage().GetHeaders().GetOptionalHeader().GetSizeOfHeaders();
					if (!this.FreeMemory(@class.GetModuleBase(), (long)((ulong)num), NativeTypes.MemoryFreeType.Release))
					{
						base.ProtectMemory(@class.GetModuleBase(), (long)((ulong)num), NativeTypes.MemoryProtection.NoAccess);
					}
					RecoveredRuntime.DisposeManualMapContext(@class);
				}
				else
				{
					RecoveredRuntime.DisposeManualMapContext(@class);
				}
			}
			this.items.Clear();
			return intPtr;
		}
		RecoveredRuntime.ResetManualMapOptions(this);
		return IntPtr.Zero;
	}

	internal bool InvokeModuleEntryPoints(MappingContext mappingContext, uint uintValue)
	{
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
		if (gclass != null)
		{
			IntPtr intptr_ = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(29026), false);
			IntPtr address = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(29067), false);
			AsmJitAssembler @class = new AsmJitAssembler();
			RemoteAssembler class47_ = new RemoteAssembler(@class, base.GetRemoteProcess());
			AsmJitLabel class58_ = RecoveredRuntime.CreateLabel(@class);
			AsmJitGpRegister class2 = RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()) ? AsmJitRuntime.gpRegister38 : AsmJitRuntime.gpRegister54;
			RecoveredRuntime.EmitRemoteCallPrologue(class47_);
			if (mappingContext.GetRemoteActivationContext() != NativeTypes.address)
			{
				RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(intptr_), CallingConvention.StdCall, new object[]
				{
					IntPtr.Zero,
					mappingContext.GetRemoteActivationContext(),
					RecoveredRuntime.CreateLabelReference(class47_, class58_)
				});
			}
			uint num = mappingContext.GetImage().GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint();
			if (uintValue != 1u && uintValue != 2u)
			{
				if (num != 0u)
				{
					RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(mappingContext.GetModuleBase().Add((long)((ulong)num))), CallingConvention.StdCall, new object[]
					{
						mappingContext.GetModuleBase(),
						uintValue,
						IntPtr.Zero
					});
				}
				foreach (int callback in mappingContext.GetTlsCallbacks())
				{
					RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(mappingContext.GetModuleBase().Add(callback)), CallingConvention.StdCall, new object[]
					{
						mappingContext.GetModuleBase(),
						uintValue,
						IntPtr.Zero
					});
				}
			}
			else
			{
				foreach (int callback in mappingContext.GetTlsCallbacks())
				{
					RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(mappingContext.GetModuleBase().Add(callback)), CallingConvention.StdCall, new object[]
					{
						mappingContext.GetModuleBase(),
						uintValue,
						IntPtr.Zero
					});
				}
				if (num != 0u)
				{
					RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(mappingContext.GetModuleBase().Add((long)((ulong)num))), CallingConvention.StdCall, new object[]
					{
						mappingContext.GetModuleBase(),
						uintValue,
						IntPtr.Zero
					});
				}
			}
			if (mappingContext.GetRemoteActivationContext() != NativeTypes.address)
			{
				RecoveredRuntime.EmitMoveMemoryToRegister(@class, class2, RecoveredRuntime.CreatePointerLabelMemory(class47_, class58_, 0L));
				RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(address), CallingConvention.StdCall, new object[]
				{
					IntPtr.Zero,
					class2
				});
			}
			RecoveredRuntime.EmitRemoteCallEpilogue(class47_, -1);
			RecoveredRuntime.AlignRemoteData(class47_);
			RecoveredRuntime.BindLabel(@class, class58_);
			RecoveredRuntime.EmbedNullPointer(class47_);
			return RecoveredRuntime.ExecuteAssemblerThread(@class, this) || RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(29108)));
		}
		return RecoveredRuntime.FailManualMap(this, new FileNotFoundException(EncodedStringTable.DecodeString(12731)));
	}

	internal IntPtr MapModule(string text, ManualMapOptions manualMapOptions)
	{
		ManualMapInjector.MappingContext @class = new ManualMapInjector.MappingContext();
		@class.SetFilePath(text);
		@class.SetFileName(Path.GetFileName(text));
		@class.SetOptions(manualMapOptions);
		@class.SetModuleBase(RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess()).GetModuleBase(text));
		ManualMapInjector.MappingContext class2 = @class;
		if (class2.GetModuleBase() != IntPtr.Zero)
		{
			return class2.GetModuleBase();
		}
		try
		{
			class2.SetImage(RecoveredRuntime.LoadPeImageFromFile(PeImageLayout.File, text));
			if (class2.GetImage() == null)
			{
				return IntPtr.Zero;
			}
		}
		catch (Exception)
		{
			return IntPtr.Zero;
		}
		class2.SetModuleBase(base.AllocateMemory((IntPtr)((long)class2.GetImage().GetHeaders().GetOptionalHeader().GetImageBase()), (long)((ulong)class2.GetImage().GetHeaders().GetOptionalHeader().GetSizeOfImage()), NativeTypes.MemoryProtection.ExecuteReadWrite));
		if (class2.GetModuleBase() == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		PeImage class3 = class2.GetImage();
		IntPtr intptr_ = class2.GetModuleBase();
		RecoveredRuntime.CreateActivationContextFromManifest(this, class2);
		if ((manualMapOptions & ManualMapInjector.ManualMapOptions.SkipActivationContext) == (ManualMapInjector.ManualMapOptions)0 && !RecoveredRuntime.CreateRemoteActivationContext(this, class2))
		{
			RecoveredRuntime.DisposeManualMapContext(class2);
			this.ReleaseMemory(class2.GetModuleBase());
			return IntPtr.Zero;
		}
		if (!this.WriteImageToTarget(class2) || !this.ApplyBaseRelocations(class2))
		{
			RecoveredRuntime.DisposeManualMapContext(class2);
			this.ReleaseMemory(class2.GetModuleBase());
			return IntPtr.Zero;
		}
		RecoveredRuntime.RegisterManualMappedModule(RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess()), class3, intptr_, RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()));
		if (!this.ResolveImports(class2, class3.GetImports()))
		{
			RecoveredRuntime.RemoveManualMappedModuleRecord(intptr_, RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess()));
			RecoveredRuntime.DisposeManualMapContext(class2);
			this.ReleaseMemory(class2.GetModuleBase());
			return IntPtr.Zero;
		}
		if ((manualMapOptions & ManualMapInjector.ManualMapOptions.SkipDelayImports) == (ManualMapInjector.ManualMapOptions)0 && class3.GetDelayImports() != null && !this.ResolveImports(class2, class3.GetDelayImports()))
		{
			RecoveredRuntime.RemoveManualMappedModuleRecord(intptr_, RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess()));
			RecoveredRuntime.DisposeManualMapContext(class2);
			this.ReleaseMemory(class2.GetModuleBase());
			return IntPtr.Zero;
		}
		if (!this.ApplyImageProtections(class2))
		{
			RecoveredRuntime.RemoveManualMappedModuleRecord(intptr_, RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess()));
			RecoveredRuntime.DisposeManualMapContext(class2);
			this.ReleaseMemory(class2.GetModuleBase());
			return IntPtr.Zero;
		}
		if ((manualMapOptions & ManualMapInjector.ManualMapOptions.DisableExceptionSupport) != (ManualMapInjector.ManualMapOptions)0 || RecoveredRuntime.ConfigureExceptionSupport(this, class2))
		{
			this.CollectTlsCallbacks(class2);
			this.items.Add(class2);
			return class2.GetModuleBase();
		}
		RecoveredRuntime.RemoveManualMappedModuleRecord(intptr_, RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess()));
		RecoveredRuntime.DisposeManualMapContext(class2);
		this.ReleaseMemory(class2.GetModuleBase());
		return IntPtr.Zero;
	}

	internal void CollectTlsCallbacks(MappingContext mappingContext)
	{
		if (mappingContext.GetImage().GetTlsDirectory() == null)
		{
			return;
		}
		using (List<ulong>.Enumerator enumerator = mappingContext.GetImage().GetTlsDirectory().items.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				int item = (int)(enumerator.Current - mappingContext.GetImage().GetHeaders().GetOptionalHeader().GetImageBase());
				mappingContext.GetTlsCallbacks().Add(item);
			}
		}
	}

	internal bool PatchSehValidation()
	{
		if (!PlatformInfo.flag2)
		{
			return true;
		}
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
		if (gclass == null)
		{
			return RecoveredRuntime.FailManualMap(this, new FileNotFoundException(EncodedStringTable.DecodeString(12731)));
		}
		IntPtr intPtr = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(29169), false);
		if (intPtr == IntPtr.Zero)
		{
			return RecoveredRuntime.FailManualMap(this, new MissingMethodException(EncodedStringTable.DecodeString(29182)));
		}
		byte[] array = base.ReadArray<byte>(intPtr, 300);
		int num = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(29239), EncodedStringTable.DecodeString(29260), 0);
		if (num == -1)
		{
			return RecoveredRuntime.FailManualMap(this, new InvalidOperationException(EncodedStringTable.DecodeString(29277)));
		}
		num += 2;
		int num2 = base.Read<int>(intPtr.Add(num));
		IntPtr intPtr2 = intPtr.Add(num + num2 + 4);
		array = base.ReadArray<byte>(intPtr2, 2);
		if (!RecoveredRuntime.MatchesAsciiAt(EncodedStringTable.DecodeString(29350), 0, array))
		{
			return RecoveredRuntime.FailManualMap(this, new InvalidOperationException(EncodedStringTable.DecodeString(29359)));
		}
		array = base.ReadArray<byte>(intPtr2, 200);
		if ((num = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(29424), 0)) == -1)
		{
			return RecoveredRuntime.FailManualMap(this, new InvalidOperationException(EncodedStringTable.DecodeString(29359)));
		}
		if (num == 0)
		{
			return true;
		}
		array = base.ReadArray<byte>(intPtr2.Add(num), 50);
		if ((num = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(29429), EncodedStringTable.DecodeString(29438), 0)) == -1)
		{
			return RecoveredRuntime.FailManualMap(this, new InvalidOperationException(EncodedStringTable.DecodeString(29443)));
		}
		ushort value = BitConverter.ToUInt16(array, num + 1);
		NativeTypes.MemoryProtection @enum;
		if (!this.ProtectMemoryCore(intPtr2, 5L, NativeTypes.MemoryProtection.ExecuteReadWrite, out @enum))
		{
			return RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(29512)));
		}
		byte[] array2 = new byte[]
		{
			176,
			1,
			194,
			0,
			0
		};
		Array.Copy(BitConverter.GetBytes(value), 0, array2, 3, 2);
		bool flag = base.WriteArray<byte>(intPtr2, array2);
		return base.ProtectMemory(intPtr2, 5L, @enum) || !flag || RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(29589)));
	}

	internal bool ApplyImageProtections(MappingContext mappingContext)
	{
		try
		{
			ManualMapProtectionService.Apply(this, mappingContext);
			return true;
		}
		catch (Exception exception)
		{
			return RecoveredRuntime.FailManualMap(this, exception);
		}
	}

	internal bool ProtectMappedRange(IntPtr address, long length, NativeTypes.MemoryProtection protection)
	{
		return ProtectMemory(address, length, protection);
	}

	internal bool DecommitMappedRange(IntPtr address, long length)
	{
		return FreeMemory(address, length, NativeTypes.MemoryFreeType.Decommit);
	}

	internal bool FlushMappedImage(IntPtr imageBase, uint imageSize)
	{
		return RecoveredRuntime.FlushInstructionCache(GetProcessHandle(), imageBase, (UIntPtr)imageSize);
	}

	internal bool ResolveImports(MappingContext mappingContext, ImportDirectory importDirectory)
	{
		if (importDirectory == null)
		{
			return true;
		}
		int i = 0;
		while (i < importDirectory.items.Count)
		{
			ImportDescriptor @class = importDirectory.items[i];
			string text = @class.GetModuleName();
			IntPtr intPtr = RecoveredRuntime.ResolveOrLoadDependency(mappingContext, this, text);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			ProcessModuleInfo gclass = RecoveredRuntime.FindModuleByBaseAddress(RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess()), intPtr);
			if (gclass != null)
			{
				IntPtr intPtr2 = mappingContext.GetModuleBase().Add((long)((ulong)@class.GetFirstThunk()));
				foreach (ImportedSymbol class2 in @class.GetOriginalThunkSymbols())
				{
					IntPtr intPtr3 = class2.GetIsOrdinal() ? RecoveredRuntime.ResolveExportByOrdinal(gclass, class2.GetOrdinal(), false) : RecoveredRuntime.ResolveExportByName(gclass, class2.GetName(), false);
					if (intPtr3 == IntPtr.Zero)
					{
						return RecoveredRuntime.FailManualMap(this, new MissingMethodException(EncodedStringTable.DecodeString(29808) + (class2.GetIsOrdinal() ? class2.GetOrdinal().ToString() : class2.GetName()) + EncodedStringTable.DecodeString(29853) + text));
					}
					if (!(RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()) ? base.Write<uint>(intPtr2, (uint)((int)intPtr3)) : base.Write<IntPtr>(intPtr2, intPtr3)))
					{
						return RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(29882)));
					}
					intPtr2 = intPtr2.Add(RecoveredRuntime.GetRemotePointerSize(base.GetRemoteProcess()));
				}
				i++;
				continue;
			}
			return RecoveredRuntime.FailManualMap(this, new Exception(EncodedStringTable.DecodeString(29755) + text));
		}
		return true;
	}

	internal bool ApplyBaseRelocations(MappingContext mappingContext)
	{
		PeImage @class = mappingContext.GetImage();
		IntPtr intPtr = mappingContext.GetModuleBase();
		long num = intPtr.ToInt64() - (long)@class.GetHeaders().GetOptionalHeader().GetImageBase();
		if (num == 0L)
		{
			return true;
		}
		if (@class.GetBaseRelocations() == null && (IntPtr)((long)mappingContext.GetImage().GetHeaders().GetOptionalHeader().GetImageBase()) != intPtr)
		{
			return RecoveredRuntime.FailManualMap(this, new InvalidOperationException(EncodedStringTable.DecodeString(29963) + mappingContext.GetFileName()));
		}
		if (@class.GetBaseRelocations() != null)
		{
			foreach (BaseRelocationBlock class2 in @class.GetBaseRelocations().items)
			{
				foreach (BaseRelocationEntry class3 in class2.items)
				{
					if (class3.GetRelocationType() != BaseRelocationType.Absolute)
					{
						IntPtr intptr_ = intPtr.Add((long)((ulong)(class2.GetPageRva() + class3.GetOffset())));
						if (class3.GetRelocationType() != BaseRelocationType.HighLow)
						{
							if (class3.GetRelocationType() != BaseRelocationType.Dir64)
							{
								return RecoveredRuntime.FailManualMap(this, new InvalidOperationException(EncodedStringTable.DecodeString(30129) + class3.GetRelocationType()));
							}
							IntPtr address = base.Read<IntPtr>(intptr_);
							if (!base.Write<IntPtr>(intptr_, address.Add(num)))
							{
								return RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(30068)));
							}
						}
						else
						{
							uint num2 = base.Read<uint>(intptr_);
							if (!base.Write<uint>(intptr_, (uint)((ulong)num2 + (ulong)num)))
							{
								return RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(30068)));
							}
						}
					}
				}
			}
			return true;
		}
		return true;
	}

	internal bool WriteImageToTarget(MappingContext mappingContext)
	{
		IntPtr intPtr = mappingContext.GetModuleBase();
		PeImage @class = mappingContext.GetImage();
		if (!base.WriteArray<byte>(intPtr, RecoveredRuntime.ReadImageBytes((long)((ulong)@class.GetHeaders().GetOptionalHeader().GetSizeOfHeaders()), @class, 0L)))
		{
			return RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(30194)));
		}
		if (!base.ProtectMemory(intPtr, (long)((ulong)@class.GetHeaders().GetOptionalHeader().GetSizeOfHeaders()), NativeTypes.MemoryProtection.ReadOnly))
		{
			return RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(30255)));
		}
		foreach (PeSectionHeader gclass in @class.GetSections())
		{
			if ((gclass.GetCharacteristics() & (SectionCharacteristics)3758096384u) != (SectionCharacteristics)0u && (gclass.GetCharacteristics() & SectionCharacteristics.Discardable) == (SectionCharacteristics)0u)
			{
				IntPtr intptr_ = intPtr.Add((long)((ulong)gclass.GetVirtualAddress()));
				long long_ = (long)((ulong)gclass.GetPointerToRawData());
				long longValue = (long)((ulong)gclass.GetSizeOfRawData());
				if (!base.WriteArray<byte>(intptr_, RecoveredRuntime.ReadImageBytes(longValue, @class, long_)))
				{
					return RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(30316)));
				}
			}
		}
		return true;
	}

	internal static byte[] ExtractManifestResource(PeImage peImage)
	{
		if (peImage.GetResources() == null)
		{
			return null;
		}
		foreach (ResourceDirectoryNode @class in peImage.GetResources().GetRoot().GetSubdirectories())
		{
			if (RecoveredRuntime.HasNumericResourceIdentifier(@class) && @class.GetId() == 24 && @class.GetSubdirectories().Count == 1 && @class.GetSubdirectories()[0].GetDataEntries().Count == 1)
			{
				ResourceDataEntry class2 = @class.GetSubdirectories()[0].GetDataEntries()[0];
				long num = RecoveredRuntime.MapRvaToFileOffset(peImage, class2.GetDataRva());
				if (num != -1L)
				{
					byte[] array = new byte[class2.GetSize()];
					using (Stream stream = RecoveredRuntime.CopyImageRange(peImage, num, (int)class2.GetSize()))
					{
						stream.Read(array, 0, array.Length);
					}
					return array;
				}
			}
		}
		return null;
	}
}
