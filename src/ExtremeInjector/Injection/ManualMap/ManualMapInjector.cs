using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class ManualMapInjector(RemoteProcess gclass2_1) : DllInjector(gclass2_1)
{
	[Flags]
	public enum Enum44
	{
		flag_0 = 1,
		flag_1 = 2,
		flag_2 = 4,
		flag_3 = 8,
		flag_4 = 0x10,
		flag_5 = 0x20,
		flag_6 = 0x40,
		flag_7 = 0x80
	}

	public sealed class Class172
	{
		[CompilerGenerated]
		internal PeImage class154_0;

		[CompilerGenerated]
		internal IntPtr intptr_0;

		[CompilerGenerated]
		internal string string_0;

		[CompilerGenerated]
		internal string string_1;

		[CompilerGenerated]
		internal Enum44 enum44_0;

		[CompilerGenerated]
		internal IntPtr intptr_1;

		[CompilerGenerated]
		internal IntPtr intptr_2;

		[CompilerGenerated]
		internal List<int> list_0;

		[SpecialName]
		[CompilerGenerated]
		public PeImage GetImage()
		{
			return class154_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetImage(PeImage class154_1)
		{
			class154_0 = class154_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public IntPtr GetModuleBase()
		{
			return intptr_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetModuleBase(IntPtr intptr_3)
		{
			intptr_0 = intptr_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public string GetFilePath()
		{
			return string_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetFilePath(string string_2)
		{
			string_0 = string_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public string GetFileName()
		{
			return string_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetFileName(string string_2)
		{
			string_1 = string_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public Enum44 GetOptions()
		{
			return enum44_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetOptions(Enum44 enum44_1)
		{
			enum44_0 = enum44_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public IntPtr GetActivationContextHandle()
		{
			return intptr_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetActivationContextHandle(IntPtr intptr_3)
		{
			intptr_1 = intptr_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public IntPtr GetRemoteActivationContext()
		{
			return intptr_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetRemoteActivationContext(IntPtr intptr_3)
		{
			intptr_2 = intptr_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public List<int> GetTlsCallbacks()
		{
			return list_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetTlsCallbacks(List<int> list_1)
		{
			list_0 = list_1;
		}

		public Class172()
		{
			IntPtr intptr_;
			SetRemoteActivationContext(intptr_ = NativeTypes.intptr_0);
			SetActivationContextHandle(intptr_);
			SetTlsCallbacks(new List<int>());
		}
	}

	[CompilerGenerated]
	internal bool bool_2;

	[CompilerGenerated]
	internal bool bool_3;

	[CompilerGenerated]
	internal bool bool_5;

	[CompilerGenerated]
	internal bool bool_6;

	[CompilerGenerated]
	internal Exception exception_0;

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

	internal List<Class172> list_0 = new List<Class172>();

	[SpecialName]
	[CompilerGenerated]
	public bool GetDisableExceptionSupport()
	{
		return bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDisableExceptionSupport(bool bool_7)
	{
		bool_2 = bool_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetErasePeHeaders()
	{
		return bool_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetErasePeHeaders(bool bool_7)
	{
		bool_3 = bool_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetManualResolveImports()
	{
		return bool_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetManualResolveImports(bool bool_7)
	{
		bool_5 = bool_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetDisableSehValidation()
	{
		return bool_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDisableSehValidation(bool bool_7)
	{
		bool_6 = bool_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public Exception GetLastException()
	{
		return exception_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetLastException(Exception exception_1)
	{
		exception_0 = exception_1;
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.GetProcessId()));
		}
	}

	public override IntPtr Inject(string string_0)
	{
		this.SetLastException(null);
		if (!Path.IsPathRooted(string_0))
		{
			string_0 = Path.GetFullPath(string_0);
		}
		ManualMapInjector.Enum44 enum44_ = RecoveredRuntime.BuildManualMapOptions(this);
		return this.InjectModule(string_0, enum44_);
	}

	internal IntPtr InjectModule(string string_0, Enum44 enum44_0)
	{
		if (!File.Exists(string_0))
		{
			RecoveredRuntime.ResetManualMapOptions(this);
			throw new FileNotFoundException(EncodedStringTable.DecodeString(28151) + string_0 + EncodedStringTable.DecodeString(3656));
		}
		if (!base.EnsureAttachedToProcess(base.GetRemoteProcess().ProcessId))
		{
			RecoveredRuntime.ResetManualMapOptions(this);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(12662));
		}
		if (!base.GetRemoteProcess().IsDepEnabled)
		{
			enum44_0 |= ManualMapInjector.Enum44.flag_1;
		}
		IntPtr intPtr = this.MapModule(string_0, enum44_0);
		if (!(intPtr == IntPtr.Zero))
		{
			foreach (ManualMapInjector.Class172 @class in this.list_0)
			{
				if (!this.InvokeModuleEntryPoints(@class, 1u))
				{
					RecoveredRuntime.DisposeManualMapContext(@class);
					return IntPtr.Zero;
				}
				if (this.GetErasePeHeaders())
				{
					uint num = @class.GetImage().GetHeaders().GetOptionalHeader().GetSizeOfHeaders();
					if (!this.FreeMemory(@class.GetModuleBase(), (long)((ulong)num), NativeTypes.Enum28.const_1))
					{
						base.ProtectMemory(@class.GetModuleBase(), (long)((ulong)num), NativeTypes.Enum34.flag_4);
					}
					RecoveredRuntime.DisposeManualMapContext(@class);
				}
				else
				{
					RecoveredRuntime.DisposeManualMapContext(@class);
				}
			}
			this.list_0.Clear();
			return intPtr;
		}
		RecoveredRuntime.ResetManualMapOptions(this);
		return IntPtr.Zero;
	}

	internal bool InvokeModuleEntryPoints(Class172 class172_0, uint uint_0)
	{
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
		if (gclass != null)
		{
			IntPtr intptr_ = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(29026), false);
			IntPtr intptr_2 = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(29067), false);
			AsmJitAssembler @class = new AsmJitAssembler();
			RemoteAssembler class47_ = new RemoteAssembler(@class, base.GetRemoteProcess());
			AsmJitLabel class58_ = RecoveredRuntime.CreateLabel(@class);
			AsmJitGpRegister class2 = RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()) ? AsmJitRuntime.class63_37 : AsmJitRuntime.class63_53;
			RecoveredRuntime.EmitRemoteCallPrologue(class47_);
			if (class172_0.GetRemoteActivationContext() != NativeTypes.intptr_0)
			{
				RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(intptr_), CallingConvention.StdCall, new object[]
				{
					IntPtr.Zero,
					class172_0.GetRemoteActivationContext(),
					RecoveredRuntime.CreateLabelReference(class47_, class58_)
				});
			}
			uint num = class172_0.GetImage().GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint();
			if (uint_0 != 1u && uint_0 != 2u)
			{
				if (num != 0u)
				{
					RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(class172_0.GetModuleBase().Add((long)((ulong)num))), CallingConvention.StdCall, new object[]
					{
						class172_0.GetModuleBase(),
						uint_0,
						IntPtr.Zero
					});
				}
				foreach (int callback in class172_0.GetTlsCallbacks())
				{
					RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(class172_0.GetModuleBase().Add(callback)), CallingConvention.StdCall, new object[]
					{
						class172_0.GetModuleBase(),
						uint_0,
						IntPtr.Zero
					});
				}
			}
			else
			{
				foreach (int callback in class172_0.GetTlsCallbacks())
				{
					RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(class172_0.GetModuleBase().Add(callback)), CallingConvention.StdCall, new object[]
					{
						class172_0.GetModuleBase(),
						uint_0,
						IntPtr.Zero
					});
				}
				if (num != 0u)
				{
					RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(class172_0.GetModuleBase().Add((long)((ulong)num))), CallingConvention.StdCall, new object[]
					{
						class172_0.GetModuleBase(),
						uint_0,
						IntPtr.Zero
					});
				}
			}
			if (class172_0.GetRemoteActivationContext() != NativeTypes.intptr_0)
			{
				RecoveredRuntime.EmitMoveMemoryToRegister(@class, class2, RecoveredRuntime.CreatePointerLabelMemory(class47_, class58_, 0L));
				RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(intptr_2), CallingConvention.StdCall, new object[]
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

	internal IntPtr MapModule(string string_0, Enum44 enum44_0)
	{
		ManualMapInjector.Class172 @class = new ManualMapInjector.Class172();
		@class.SetFilePath(string_0);
		@class.SetFileName(Path.GetFileName(string_0));
		@class.SetOptions(enum44_0);
		@class.SetModuleBase(RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess()).GetModuleBase(string_0));
		ManualMapInjector.Class172 class2 = @class;
		if (class2.GetModuleBase() != IntPtr.Zero)
		{
			return class2.GetModuleBase();
		}
		try
		{
			class2.SetImage(RecoveredRuntime.LoadPeImageFromFile(PeImageLayout.const_0, string_0));
			if (class2.GetImage() == null)
			{
				return IntPtr.Zero;
			}
		}
		catch (Exception)
		{
			return IntPtr.Zero;
		}
		class2.SetModuleBase(base.AllocateMemory((IntPtr)((long)class2.GetImage().GetHeaders().GetOptionalHeader().GetImageBase()), (long)((ulong)class2.GetImage().GetHeaders().GetOptionalHeader().GetSizeOfImage()), NativeTypes.Enum34.flag_2));
		if (class2.GetModuleBase() == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		PeImage class3 = class2.GetImage();
		IntPtr intptr_ = class2.GetModuleBase();
		RecoveredRuntime.CreateActivationContextFromManifest(this, class2);
		if ((enum44_0 & ManualMapInjector.Enum44.flag_6) == (ManualMapInjector.Enum44)0 && !RecoveredRuntime.CreateRemoteActivationContext(this, class2))
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
		if ((enum44_0 & ManualMapInjector.Enum44.flag_7) == (ManualMapInjector.Enum44)0 && class3.GetDelayImports() != null && !this.ResolveImports(class2, class3.GetDelayImports()))
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
		if ((enum44_0 & ManualMapInjector.Enum44.flag_1) != (ManualMapInjector.Enum44)0 || RecoveredRuntime.ConfigureExceptionSupport(this, class2))
		{
			this.CollectTlsCallbacks(class2);
			this.list_0.Add(class2);
			return class2.GetModuleBase();
		}
		RecoveredRuntime.RemoveManualMappedModuleRecord(intptr_, RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess()));
		RecoveredRuntime.DisposeManualMapContext(class2);
		this.ReleaseMemory(class2.GetModuleBase());
		return IntPtr.Zero;
	}

	internal void CollectTlsCallbacks(Class172 class172_0)
	{
		if (class172_0.GetImage().GetTlsDirectory() == null)
		{
			return;
		}
		using (List<ulong>.Enumerator enumerator = class172_0.GetImage().GetTlsDirectory().list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				int item = (int)(enumerator.Current - class172_0.GetImage().GetHeaders().GetOptionalHeader().GetImageBase());
				class172_0.GetTlsCallbacks().Add(item);
			}
		}
	}

	internal bool PatchSehValidation()
	{
		if (!PlatformInfo.bool_1)
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
		NativeTypes.Enum34 @enum;
		if (!this.ProtectMemoryCore(intPtr2, 5L, NativeTypes.Enum34.flag_2, out @enum))
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

	internal bool ApplyImageProtections(Class172 class172_0)
	{
		try
		{
			ManualMapProtectionService.Apply(this, class172_0);
			return true;
		}
		catch (Exception exception)
		{
			return RecoveredRuntime.FailManualMap(this, exception);
		}
	}

	internal bool ProtectMappedRange(IntPtr address, long length, NativeTypes.Enum34 protection)
	{
		return ProtectMemory(address, length, protection);
	}

	internal bool DecommitMappedRange(IntPtr address, long length)
	{
		return FreeMemory(address, length, NativeTypes.Enum28.const_0);
	}

	internal bool FlushMappedImage(IntPtr imageBase, uint imageSize)
	{
		return RecoveredRuntime.FlushInstructionCache(GetProcessHandle(), imageBase, (UIntPtr)imageSize);
	}

	internal bool ResolveImports(Class172 class172_0, ImportDirectory class148_0)
	{
		if (class148_0 == null)
		{
			return true;
		}
		int i = 0;
		while (i < class148_0.list_0.Count)
		{
			ImportDescriptor @class = class148_0.list_0[i];
			string text = @class.GetModuleName();
			IntPtr intPtr = RecoveredRuntime.ResolveOrLoadDependency(class172_0, this, text);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			ProcessModuleInfo gclass = RecoveredRuntime.FindModuleByBaseAddress(RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess()), intPtr);
			if (gclass != null)
			{
				IntPtr intPtr2 = class172_0.GetModuleBase().Add((long)((ulong)@class.GetFirstThunk()));
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

	internal bool ApplyBaseRelocations(Class172 class172_0)
	{
		PeImage @class = class172_0.GetImage();
		IntPtr intPtr = class172_0.GetModuleBase();
		long num = intPtr.ToInt64() - (long)@class.GetHeaders().GetOptionalHeader().GetImageBase();
		if (num == 0L)
		{
			return true;
		}
		if (@class.GetBaseRelocations() == null && (IntPtr)((long)class172_0.GetImage().GetHeaders().GetOptionalHeader().GetImageBase()) != intPtr)
		{
			return RecoveredRuntime.FailManualMap(this, new InvalidOperationException(EncodedStringTable.DecodeString(29963) + class172_0.GetFileName()));
		}
		if (@class.GetBaseRelocations() != null)
		{
			foreach (BaseRelocationBlock class2 in @class.GetBaseRelocations().list_0)
			{
				foreach (BaseRelocationEntry class3 in class2.list_0)
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
							IntPtr intptr_2 = base.Read<IntPtr>(intptr_);
							if (!base.Write<IntPtr>(intptr_, intptr_2.Add(num)))
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

	internal bool WriteImageToTarget(Class172 class172_0)
	{
		IntPtr intPtr = class172_0.GetModuleBase();
		PeImage @class = class172_0.GetImage();
		if (!base.WriteArray<byte>(intPtr, RecoveredRuntime.ReadImageBytes((long)((ulong)@class.GetHeaders().GetOptionalHeader().GetSizeOfHeaders()), @class, 0L)))
		{
			return RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(30194)));
		}
		if (!base.ProtectMemory(intPtr, (long)((ulong)@class.GetHeaders().GetOptionalHeader().GetSizeOfHeaders()), NativeTypes.Enum34.flag_5))
		{
			return RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(30255)));
		}
		foreach (PeSectionHeader gclass in @class.GetSections())
		{
			if ((gclass.GetCharacteristics() & (SectionCharacteristics)3758096384u) != (SectionCharacteristics)0u && (gclass.GetCharacteristics() & SectionCharacteristics.flag_28) == (SectionCharacteristics)0u)
			{
				IntPtr intptr_ = intPtr.Add((long)((ulong)gclass.GetVirtualAddress()));
				long long_ = (long)((ulong)gclass.GetPointerToRawData());
				long long_2 = (long)((ulong)gclass.GetSizeOfRawData());
				if (!base.WriteArray<byte>(intptr_, RecoveredRuntime.ReadImageBytes(long_2, @class, long_)))
				{
					return RecoveredRuntime.FailManualMap(this, new AccessViolationException(EncodedStringTable.DecodeString(30316)));
				}
			}
		}
		return true;
	}

	internal static byte[] ExtractManifestResource(PeImage class154_0)
	{
		if (class154_0.GetResources() == null)
		{
			return null;
		}
		foreach (ResourceDirectoryNode @class in class154_0.GetResources().GetRoot().GetSubdirectories())
		{
			if (RecoveredRuntime.HasNumericResourceIdentifier(@class) && @class.GetId() == 24 && @class.GetSubdirectories().Count == 1 && @class.GetSubdirectories()[0].GetDataEntries().Count == 1)
			{
				ResourceDataEntry class2 = @class.GetSubdirectories()[0].GetDataEntries()[0];
				long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, class2.GetDataRva());
				if (num != -1L)
				{
					byte[] array = new byte[class2.GetSize()];
					using (Stream stream = RecoveredRuntime.CopyImageRange(class154_0, num, (int)class2.GetSize()))
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
