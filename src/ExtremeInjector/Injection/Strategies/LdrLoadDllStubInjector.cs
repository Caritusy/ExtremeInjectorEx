using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public sealed class LdrLoadDllStubInjector : DllInjector
{
	public LdrLoadDllStubInjector(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
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
		if (!Path.IsPathRooted(string_0))
		{
			string_0 = Path.GetFullPath(string_0);
		}
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(28151) + string_0 + EncodedStringTable.DecodeString(3656));
		}
		if (!base.EnsureAttachedToProcess(base.GetRemoteProcess().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(12662));
		}
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(12731));
		}
		IntPtr intPtr = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(28220), false);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(28237));
		}
		IntPtr intptr_ = RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()) ? RecoveredRuntime.LocateLdrpLoadDll32(this, intPtr, gclass) : RecoveredRuntime.LocateLdrpLoadDll64(intPtr, this, gclass);
		int int_;
		int int_2;
		IntPtr intPtr2 = this.BuildLoaderStub(intptr_, string_0, out int_, out int_2);
		IntPtr intPtr3 = RecoveredRuntime.StartRemoteThread(this, intPtr2, IntPtr.Zero);
		if (intPtr3 == IntPtr.Zero)
		{
			this.ReleaseMemory(intPtr2);
			throw new AccessViolationException(EncodedStringTable.DecodeString(12914));
		}
		RecoveredRuntime.WaitForRemoteThread(this, intPtr3, -1);
		if (RecoveredRuntime.HasProcessExited(base.GetRemoteProcess()))
		{
			this.ReleaseMemory(intPtr2);
			throw new Exception(EncodedStringTable.DecodeString(28330));
		}
		uint num = base.Read<uint>(intPtr2.Add(int_2));
		if (num != 0u)
		{
			this.ReleaseMemory(intPtr2);
			throw new Exception(EncodedStringTable.DecodeString(28411) + num.ToString(EncodedStringTable.DecodeString(28492)) + EncodedStringTable.DecodeString(3656), RecoveredRuntime.CreateWin32ExceptionFromNtStatus(num, this));
		}
		IntPtr result = RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()) ? ((IntPtr)((long)((ulong)base.Read<uint>(intPtr2.Add(int_))))) : base.Read<IntPtr>(intPtr2.Add(int_));
		this.ReleaseMemory(intPtr2);
		RecoveredRuntime.CloseRemoteHandle(this, intPtr3);
		return result;
	}

	internal IntPtr BuildLoaderStub(IntPtr intptr_1, string string_0, out int int_1, out int int_2)
	{
		IntPtr intPtr = RecoveredRuntime.AllocateRemoteMemory(this, 4096L, NativeTypes.Enum34.flag_2);
		if (intPtr == IntPtr.Zero)
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(28497));
		}
		AsmJitAssembler @class = new AsmJitAssembler();
		RemoteAssembler class2 = new RemoteAssembler(@class, base.GetRemoteProcess());
		class2.SetRandomizeArgumentSetup(true);
		RemoteAssembler class47_ = class2;
		AsmJitLabel class58_ = RecoveredRuntime.CreateLabel(@class);
		AsmJitLabel class58_2 = RecoveredRuntime.CreateLabel(@class);
		AsmJitLabel class3 = RecoveredRuntime.CreateLabel(@class);
		AsmJitLabel class4 = RecoveredRuntime.CreateLabel(@class);
		AsmJitLabel class58_3 = RecoveredRuntime.CreateLabel(@class);
		AsmJitLabel class58_4 = RecoveredRuntime.CreateLabel(@class);
		RecoveredRuntime.EmitRemoteCallPrologue(class47_);
		if (!PlatformInfo.bool_7)
		{
			if (!PlatformInfo.bool_5)
			{
				if (!PlatformInfo.bool_2)
				{
					RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(intptr_1), CallingConvention.StdCall, new object[]
					{
						0,
						IntPtr.Zero,
						IntPtr.Zero,
						RecoveredRuntime.CreateLabelReference(class47_, class58_2),
						RecoveredRuntime.CreateLabelReference(class47_, class58_),
						1
					});
				}
				else
				{
					RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(intptr_1), CallingConvention.StdCall, new object[]
					{
						RecoveredRuntime.CreateLabelReference(class47_, class58_2),
						RecoveredRuntime.CreateLabelReference(class47_, class58_4),
						0,
						1,
						0,
						RecoveredRuntime.CreateLabelReference(class47_, class3)
					});
				}
			}
			else
			{
				CallingConvention callingConvention_ = PlatformInfo.bool_6 ? CallingConvention.FastCall : CallingConvention.StdCall;
				RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(intptr_1), callingConvention_, new object[]
				{
					RecoveredRuntime.CreateLabelReference(class47_, class58_2),
					RecoveredRuntime.CreateLabelReference(class47_, class58_4),
					0,
					1,
					RecoveredRuntime.CreateLabelReference(class47_, class3),
					RecoveredRuntime.CreateLabelReference(class47_, class4)
				});
			}
		}
		else
		{
			RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(intptr_1), CallingConvention.FastCall, new object[]
			{
				RecoveredRuntime.CreateLabelReference(class47_, class58_2),
				RecoveredRuntime.CreateLabelReference(class47_, class58_4),
				0,
				1,
				RecoveredRuntime.CreateLabelReference(class47_, class4)
			});
		}
		if (RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()))
		{
			AsmJitAssembler class5 = @class;
			class5.struct19_0.uint_2 = (class5.struct19_0.uint_2 | 8u);
		}
		RecoveredRuntime.EmitMoveRegisterToMemory(@class, RecoveredRuntime.CreateDwordLabelMemory(class58_3, 0L), AsmJitRuntime.class63_37);
		if (PlatformInfo.bool_2)
		{
			int num = RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()) ? 24 : 48;
			AsmJitGpRegister class63_ = RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()) ? AsmJitRuntime.class63_38 : AsmJitRuntime.class63_54;
			RecoveredRuntime.EmitMoveMemoryToRegister(@class, class63_, RecoveredRuntime.CreatePointerLabelMemory(class47_, PlatformInfo.bool_7 ? class4 : class3, 0L));
			RecoveredRuntime.EmitMoveMemoryToRegister(@class, class63_, RecoveredRuntime.CreatePointerBaseMemory(class63_, (long)num, class47_));
			RecoveredRuntime.EmitMoveRegisterToMemory(@class, RecoveredRuntime.CreatePointerLabelMemory(class47_, class58_, 0L), class63_);
		}
		RecoveredRuntime.EmitRemoteCallEpilogue(class47_, -1);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.BindLabel(@class, class58_);
		int_1 = RecoveredRuntime.GetAssemblerOffset(@class);
		RecoveredRuntime.EmbedNullPointer(class47_);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.BindLabel(@class, class58_3);
		int_2 = RecoveredRuntime.GetAssemblerOffset(@class);
		RecoveredRuntime.EmbedUInt32(@class, 0u);
		RecoveredRuntime.AlignRemoteData(class47_);
		IntPtr intptr_2 = intPtr.Add(RecoveredRuntime.GetAssemblerOffset(@class));
		byte[] bytes = Encoding.Unicode.GetBytes(string_0 + EncodedStringTable.DecodeString(12219));
		RecoveredRuntime.EmbedBytes(@class, bytes);
		RecoveredRuntime.AlignRemoteData(class47_);
		if (!PlatformInfo.bool_7)
		{
			if (PlatformInfo.bool_6)
			{
				RecoveredRuntime.BindLabel(@class, class58_4);
				RecoveredRuntime.EmbedNullPointer(class47_);
				RecoveredRuntime.EmbedNullPointer(class47_);
				RecoveredRuntime.EmbedNullPointer(class47_);
				RecoveredRuntime.EmbedPlatformPointer(class47_, intptr_2);
				RecoveredRuntime.EmbedNullPointer(class47_);
				RecoveredRuntime.EmbedNullPointer(class47_);
			}
			else if (PlatformInfo.bool_5)
			{
				RecoveredRuntime.BindLabel(@class, class58_4);
				RecoveredRuntime.EmbedNullPointer(class47_);
				RecoveredRuntime.EmbedPlatformPointer(class47_, intptr_2);
				RecoveredRuntime.EmbedUInt16(1, @class);
			}
			else if (PlatformInfo.bool_2)
			{
				string s = string.Concat(new string[]
				{
					Path.GetDirectoryName(base.GetRemoteProcess().FilePath),
					EncodedStringTable.DecodeString(28566),
					PlatformInfo.string_1,
					EncodedStringTable.DecodeString(28566),
					PlatformInfo.string_3,
					EncodedStringTable.DecodeString(28566),
					PlatformInfo.string_0,
					EncodedStringTable.DecodeString(12219)
				});
				RecoveredRuntime.AlignRemoteData(class47_);
				IntPtr intptr_3 = intPtr.Add(RecoveredRuntime.GetAssemblerOffset(@class));
				byte[] bytes2 = Encoding.Unicode.GetBytes(s);
				RecoveredRuntime.EmbedBytes(@class, bytes2);
				RecoveredRuntime.AlignRemoteData(class47_);
				RecoveredRuntime.BindLabel(@class, class58_4);
				RecoveredRuntime.EmbedUInt16(@class, (ushort)(bytes2.Length - 2));
				RecoveredRuntime.EmbedUInt16(@class, (ushort)bytes2.Length);
				RecoveredRuntime.AlignRemoteData(class47_);
				RecoveredRuntime.EmbedPlatformPointer(class47_, intptr_3);
			}
		}
		else if (PlatformInfo.bool_8)
		{
			RecoveredRuntime.BindLabel(@class, class58_4);
			RecoveredRuntime.BindLabel(@class, class58_4);
			RecoveredRuntime.EmbedNullPointer(class47_);
			RecoveredRuntime.EmbedNullPointer(class47_);
			RecoveredRuntime.EmbedNullPointer(class47_);
			RecoveredRuntime.EmbedNullPointer(class47_);
			RecoveredRuntime.EmbedPlatformPointer(class47_, intptr_2);
			for (int i = 0; i < 7; i++)
			{
				RecoveredRuntime.EmbedNullPointer(class47_);
			}
			for (int j = 0; j < 8; j++)
			{
				RecoveredRuntime.EmbedUInt32(@class, 0u);
			}
		}
		else
		{
			RecoveredRuntime.BindLabel(@class, class58_4);
			RecoveredRuntime.EmbedNullPointer(class47_);
			RecoveredRuntime.EmbedNullPointer(class47_);
			RecoveredRuntime.EmbedNullPointer(class47_);
			RecoveredRuntime.EmbedPlatformPointer(class47_, intptr_2);
			for (int k = 0; k < 7; k++)
			{
				RecoveredRuntime.EmbedNullPointer(class47_);
			}
			for (int l = 0; l < 8; l++)
			{
				RecoveredRuntime.EmbedUInt32(@class, 0u);
			}
		}
		if (PlatformInfo.bool_5)
		{
			RecoveredRuntime.AlignRemoteData(class47_);
			RecoveredRuntime.BindLabel(@class, class4);
			RecoveredRuntime.EmbedPlatformPointer(class47_, (IntPtr)1);
			if (PlatformInfo.bool_7)
			{
				for (int m = 0; m < 6; m++)
				{
					RecoveredRuntime.EmbedNullPointer(class47_);
				}
			}
		}
		RecoveredRuntime.AlignRemoteData(class47_);
		int int_3 = RecoveredRuntime.GetAssemblerOffset(@class);
		RecoveredRuntime.BindLabel(@class, class58_2);
		RecoveredRuntime.EmbedUInt16(@class, (ushort)(bytes.Length - 2));
		RecoveredRuntime.EmbedUInt16(@class, (ushort)bytes.Length);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.EmbedPlatformPointer(class47_, intptr_2);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.BindLabel(@class, class3);
		RecoveredRuntime.EmbedPlatformPointer(class47_, intPtr.Add(int_3));
		if (RecoveredRuntime.AssembleRemoteCode(intPtr, @class, this) == IntPtr.Zero)
		{
			this.ReleaseMemory(intPtr);
			throw new InvalidOperationException(EncodedStringTable.DecodeString(28571));
		}
		return intPtr;
	}
}
