using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class NativeLoaderHooks : RemoteCodeExecutorBase
{
	[Serializable]
	[CompilerGenerated]
	public sealed class TextSectionPredicateCache
	{
		public static readonly TextSectionPredicateCache _003C_003E9 = new TextSectionPredicateCache();

		public static Func<PeSectionHeader, bool> _003C_003E9__14_0;

		internal bool IsTextSection(PeSectionHeader peSectionHeader)
		{
			return peSectionHeader.GetName() == ".text";
		}
	}

	[CompilerGenerated]
	internal IntPtr insertInvertedFunctionTableAddress;

	[CompilerGenerated]
	internal IntPtr invertedFunctionTableAddress;

	[CompilerGenerated]
	internal IntPtr removeInvertedFunctionTableAddress;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetInsertInvertedFunctionTableAddress()
	{
		return insertInvertedFunctionTableAddress;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetInsertInvertedFunctionTableAddress(IntPtr address)
	{
		insertInvertedFunctionTableAddress = address;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetInvertedFunctionTableAddress()
	{
		return invertedFunctionTableAddress;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetInvertedFunctionTableAddress(IntPtr address)
	{
		invertedFunctionTableAddress = address;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetRemoveInvertedFunctionTableAddress()
	{
		return removeInvertedFunctionTableAddress;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetRemoveInvertedFunctionTableAddress(IntPtr address)
	{
		removeInvertedFunctionTableAddress = address;
	}

	internal NativeLoaderHooks(RemoteProcess remoteProcess)
		: base(remoteProcess)
	{
		EnsureAttachedToProcess(remoteProcess.ProcessId);
		RecoveredRuntime.LocateNativeLoaderHooks(this);
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.CreateThread | NativeTypes.ProcessAccessRights.VirtualMemoryOperation | NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.VirtualMemoryWrite | NativeTypes.ProcessAccessRights.QueryInformation, false, base.GetProcessId()));
		}
	}

	public bool InsertInvertedFunctionTableEntry(IntPtr address, ulong ulongValue, out bool flag)
	{
		flag = false;
		if (this.GetInsertInvertedFunctionTableAddress() == IntPtr.Zero || this.GetInvertedFunctionTableAddress() == IntPtr.Zero)
		{
			return false;
		}
		InvertedFunctionTable32 class112_ = new InvertedFunctionTable32(this.GetInvertedFunctionTableAddress(), base.GetProcessHandle());
		int num = 0;
		while ((long)num < (long)((ulong)RecoveredRuntime.GetInvertedFunctionTableCount(class112_)))
		{
			if (RecoveredRuntime.GetInvertedFunctionImageBase(RecoveredRuntime.ReadInvertedFunctionTableEntries(class112_)[num]) == address)
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
		if (!PlatformInfo.flag7)
		{
			if (PlatformInfo.flag6)
			{
				RecoveredRuntime.EmitRemoteCall(class3, new AsmJitImmediate(this.GetInsertInvertedFunctionTableAddress()), CallingConvention.StdCall, new object[]
				{
					address,
					(IntPtr)((long)ulongValue)
				});
			}
			else
			{
				RecoveredRuntime.EmitRemoteCall(class3, new AsmJitImmediate(this.GetInsertInvertedFunctionTableAddress()), CallingConvention.StdCall, new object[]
				{
					this.GetInvertedFunctionTableAddress(),
					address,
					(IntPtr)((long)ulongValue)
				});
			}
		}
		else
		{
			RecoveredRuntime.EmitRemoteCall(class3, new AsmJitImmediate(this.GetInsertInvertedFunctionTableAddress()), CallingConvention.FastCall, new object[]
			{
				address,
				(IntPtr)((long)ulongValue)
			});
		}
		RecoveredRuntime.EmitRemoteCallEpilogue(class3, -1);
		if (RecoveredRuntime.ExecuteAssemblerThread(@class, this))
		{
			int num2 = 0;
			while ((long)num2 < (long)((ulong)RecoveredRuntime.GetInvertedFunctionTableCount(class112_)))
			{
				InvertedFunctionTableEntry32 class4 = RecoveredRuntime.ReadInvertedFunctionTableEntries(class112_)[num2];
				if (!(RecoveredRuntime.GetInvertedFunctionImageBase(class4) != address))
				{
					if (RecoveredRuntime.GetInvertedFunctionTableEntrySize(class4) != 0u)
					{
						flag = true;
						return true;
					}
					IntPtr intPtr = RecoveredRuntime.AllocateRemoteMemory(this, 2048L, NativeTypes.MemoryProtection.ReadWrite);
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
					NativeTypes.MemoryProtection enum34_;
					this.ProtectMemoryCore(class4.GetAddress(), (long)RecoveredRuntime.GetRemotePointerSize(base.GetRemoteProcess()), NativeTypes.MemoryProtection.ExecuteReadWrite, out enum34_);
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
