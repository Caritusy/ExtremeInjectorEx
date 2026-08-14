using System;
using System.Runtime.CompilerServices;

public sealed class RemoteAssembler
{
	public sealed class Class48
	{
		[CompilerGenerated]
		internal AsmJitLabel class58_0;

		[SpecialName]
		[CompilerGenerated]
		public AsmJitLabel GetLabel()
		{
			return class58_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetLabel(AsmJitLabel class58_1)
		{
			class58_0 = class58_1;
		}

		public Class48(AsmJitLabel class58_1)
		{
			this.SetLabel(class58_1);
		}
	}

	public enum Enum6
	{
		const_0,
		const_1,
		const_2
	}

	internal AsmJitAssembler class53_0;

	internal bool bool_0;

	internal bool bool_1;

	internal AsmJitLabel class58_0;

	internal AsmJitLabel class58_1;

	internal int int_0;

	[CompilerGenerated]
	internal bool bool_2;

	[CompilerGenerated]
	internal int int_1;

	[SpecialName]
	[CompilerGenerated]
	public bool GetRandomizeArgumentSetup()
	{
		return bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetRandomizeArgumentSetup(bool bool_3)
	{
		bool_2 = bool_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public int GetResultOffset()
	{
		return int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetResultOffset(int int_2)
	{
		int_1 = int_2;
	}

	public RemoteAssembler(AsmJitAssembler class53_1, RemoteProcess gclass2_0)
	{
		class53_0 = class53_1;
		bool_0 = RecoveredRuntime.Is32BitProcess(gclass2_0);
		bool_1 = gclass2_0.bool_2;
	}

	public void CaptureReturnValue<T>()
	{
		this.class58_0 = RecoveredRuntime.CreateLabel(this.class53_0);
		this.int_0 = PlatformInfo.SizeOf<T>();
		if (typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr))
		{
			RecoveredRuntime.EmitMoveRegisterToMemory(this.class53_0, RecoveredRuntime.CreatePointerLabelMemory(this, this.class58_0, 0L), this.bool_0 ? AsmJitRuntime.class63_37 : AsmJitRuntime.class63_53);
			this.int_0 = (this.bool_0 ? 4 : 8);
			return;
		}
		if (this.int_0 == 4)
		{
			RecoveredRuntime.EmitMoveRegisterToMemory(this.class53_0, RecoveredRuntime.CreateDwordLabelMemoryForProcess(0L, this, this.class58_0), AsmJitRuntime.class63_37);
			return;
		}
		if (this.int_0 == 2)
		{
			RecoveredRuntime.EmitMoveRegisterToMemory(this.class53_0, RecoveredRuntime.CreateWordLabelMemoryForProcess(this.class58_0, 0L, this), AsmJitRuntime.class63_21);
			return;
		}
		if (this.int_0 == 1)
		{
			RecoveredRuntime.EmitMoveRegisterToMemory(this.class53_0, RecoveredRuntime.CreateByteLabelMemoryForProcess(this.class58_0, 0L, this), AsmJitRuntime.class63_37);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(4473));
	}
}
