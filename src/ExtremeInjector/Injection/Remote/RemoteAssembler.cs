using System;
using System.Runtime.CompilerServices;

public sealed class RemoteAssembler
{
	public sealed class LabelReference
	{
		[CompilerGenerated]
		internal AsmJitLabel label;

		[SpecialName]
		[CompilerGenerated]
		public AsmJitLabel GetLabel()
		{
			return label;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetLabel(AsmJitLabel label2)
		{
			label = label2;
		}

		public LabelReference(AsmJitLabel label2)
		{
			this.SetLabel(label2);
		}
	}

	public enum X86ArgumentSlot
	{
		FirstStackArgument = 2
	}

	internal AsmJitAssembler assembler;

	internal bool flag;

	internal bool flag2;

	internal AsmJitLabel label;

	internal AsmJitLabel label2;

	internal int intValue;

	[CompilerGenerated]
	internal bool randomizeArgumentSetup;

	[CompilerGenerated]
	internal int resultOffset;

	[SpecialName]
	[CompilerGenerated]
	public bool GetRandomizeArgumentSetup()
	{
		return randomizeArgumentSetup;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetRandomizeArgumentSetup(bool flag3)
	{
		randomizeArgumentSetup = flag3;
	}

	[SpecialName]
	[CompilerGenerated]
	public int GetResultOffset()
	{
		return resultOffset;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetResultOffset(int intValue2)
	{
		resultOffset = intValue2;
	}

	public RemoteAssembler(AsmJitAssembler assembler2, RemoteProcess remoteProcess)
	{
		assembler = assembler2;
		flag = RecoveredRuntime.Is32BitProcess(remoteProcess);
		flag2 = remoteProcess.flag;
	}

	public void CaptureReturnValue<T>()
	{
		this.label = RecoveredRuntime.CreateLabel(this.assembler);
		this.intValue = PlatformInfo.SizeOf<T>();
		if (typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr))
		{
			RecoveredRuntime.EmitMoveRegisterToMemory(this.assembler, RecoveredRuntime.CreatePointerLabelMemory(this, this.label, 0L), this.flag ? AsmJitRuntime.gpRegister38 : AsmJitRuntime.gpRegister54);
			this.intValue = (this.flag ? 4 : 8);
			return;
		}
		if (this.intValue == 4)
		{
			RecoveredRuntime.EmitMoveRegisterToMemory(this.assembler, RecoveredRuntime.CreateDwordLabelMemoryForProcess(0L, this, this.label), AsmJitRuntime.gpRegister38);
			return;
		}
		if (this.intValue == 2)
		{
			RecoveredRuntime.EmitMoveRegisterToMemory(this.assembler, RecoveredRuntime.CreateWordLabelMemoryForProcess(this.label, 0L, this), AsmJitRuntime.gpRegister22);
			return;
		}
		if (this.intValue == 1)
		{
			RecoveredRuntime.EmitMoveRegisterToMemory(this.assembler, RecoveredRuntime.CreateByteLabelMemoryForProcess(this.label, 0L, this), AsmJitRuntime.gpRegister38);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(4473));
	}
}
