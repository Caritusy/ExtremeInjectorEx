using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class NativeLoaderHooks : RemoteCodeExecutorBase
{
	[Serializable]
	[CompilerGenerated]
	public sealed class Class81
	{
		public static readonly Class81 _003C_003E9 = new Class81();

		public static Func<PeSectionHeader, bool> _003C_003E9__14_0;

		internal bool IsTextSection(PeSectionHeader gclass5_0)
		{
			return gclass5_0.GetName() == ".text";
		}
	}

	[CompilerGenerated]
	internal IntPtr intptr_1;

	[CompilerGenerated]
	internal IntPtr intptr_2;

	[CompilerGenerated]
	internal IntPtr intptr_3;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetInsertInvertedFunctionTableAddress()
	{
		return intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetInsertInvertedFunctionTableAddress(IntPtr intptr_4)
	{
		intptr_1 = intptr_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetInvertedFunctionTableAddress()
	{
		return intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetInvertedFunctionTableAddress(IntPtr intptr_4)
	{
		intptr_2 = intptr_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetRemoveInvertedFunctionTableAddress()
	{
		return intptr_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetRemoveInvertedFunctionTableAddress(IntPtr intptr_4)
	{
		intptr_3 = intptr_4;
	}

	internal NativeLoaderHooks(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
		EnsureAttachedToProcess(gclass2_1.ProcessId);
		RecoveredRuntime.LocateNativeLoaderHooks(this);
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.GetProcessId()));
		}
	}

	public bool InsertInvertedFunctionTableEntry(IntPtr intptr_4, ulong ulong_0, out bool bool_2)
	{
		bool_2 = false;
		if (this.GetInsertInvertedFunctionTableAddress() == IntPtr.Zero || this.GetInvertedFunctionTableAddress() == IntPtr.Zero)
		{
			return false;
		}
		InvertedFunctionTable32 class112_ = new InvertedFunctionTable32(this.GetInvertedFunctionTableAddress(), base.GetProcessHandle());
		int num = 0;
		while ((long)num < (long)((ulong)RecoveredRuntime.GetInvertedFunctionTableCount(class112_)))
		{
			if (RecoveredRuntime.GetInvertedFunctionImageBase(RecoveredRuntime.ReadInvertedFunctionTableEntries(class112_)[num]) == intptr_4)
			{
				return true;
			}
			num++;
		}
		AsmJitAssembler @class = new AsmJitAssembler();
		RemoteAssembler class2 = new RemoteAssembler(@class, base.GetRemoteProcess());
		class2.SetRandomizeArgumentSetup(true);
		RemoteAssembler class3 = class2;
		RecoveredRuntime.EmitRemoteCallPrologue(class3);
		if (!PlatformInfo.bool_6)
		{
			if (PlatformInfo.bool_5)
			{
				RecoveredRuntime.EmitRemoteCall(class3, new AsmJitImmediate(this.GetInsertInvertedFunctionTableAddress()), CallingConvention.StdCall, new object[]
				{
					intptr_4,
					(IntPtr)((long)ulong_0)
				});
			}
			else
			{
				RecoveredRuntime.EmitRemoteCall(class3, new AsmJitImmediate(this.GetInsertInvertedFunctionTableAddress()), CallingConvention.StdCall, new object[]
				{
					this.GetInvertedFunctionTableAddress(),
					intptr_4,
					(IntPtr)((long)ulong_0)
				});
			}
		}
		else
		{
			RecoveredRuntime.EmitRemoteCall(class3, new AsmJitImmediate(this.GetInsertInvertedFunctionTableAddress()), CallingConvention.FastCall, new object[]
			{
				intptr_4,
				(IntPtr)((long)ulong_0)
			});
		}
		RecoveredRuntime.EmitRemoteCallEpilogue(class3, -1);
		if (RecoveredRuntime.ExecuteAssemblerThread(@class, this))
		{
			int num2 = 0;
			while ((long)num2 < (long)((ulong)RecoveredRuntime.GetInvertedFunctionTableCount(class112_)))
			{
				InvertedFunctionTableEntry32 class4 = RecoveredRuntime.ReadInvertedFunctionTableEntries(class112_)[num2];
				if (!(RecoveredRuntime.GetInvertedFunctionImageBase(class4) != intptr_4))
				{
					if (RecoveredRuntime.GetInvertedFunctionTableEntrySize(class4) != 0u)
					{
						bool_2 = true;
						return true;
					}
					IntPtr intPtr = RecoveredRuntime.AllocateRemoteMemory(this, 2048L, NativeTypes.Enum34.flag_6);
					if (intPtr == IntPtr.Zero)
					{
						return false;
					}
					RecoveredRuntime.DisposeAssemblerState(@class);
					RecoveredRuntime.EmitRemoteCallPrologue(class3);
					RecoveredRuntime.EmitRemoteCall(class3, new AsmJitImmediate(RecoveredRuntime.ResolveExportByName(RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)], EncodedStringTable.DecodeString(8562), false)), CallingConvention.StdCall, new object[]
					{
						intPtr
					});
					class3.CaptureReturnValue<IntPtr>();
					RecoveredRuntime.EmitRemoteCallEpilogue(class3, -1);
					IntPtr intPtr2 = base.Execute<IntPtr>(class3);
					NativeTypes.Enum34 enum34_;
					this.ProtectMemoryCore(class4.GetAddress(), (long)RecoveredRuntime.GetRemotePointerSize(base.GetRemoteProcess()), NativeTypes.Enum34.flag_2, out enum34_);
					bool result = base.Write<int>(class4.GetAddress(), intPtr2.ToInt32());
					this.ProtectMemoryCore(class4.GetAddress(), (long)RecoveredRuntime.GetRemotePointerSize(base.GetRemoteProcess()), enum34_, out enum34_);
					return result;
				}
				else
				{
					num2++;
				}
			}
			return false;
		}
		return false;
	}
}
