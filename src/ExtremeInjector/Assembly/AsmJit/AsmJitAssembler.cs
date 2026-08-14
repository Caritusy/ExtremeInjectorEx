using System;
using System.Runtime.InteropServices;

public sealed class AsmJitAssembler : IDisposable
{
	internal AsmJitAssemblerState struct19_0;

	public bool Is32BitMode { get; set; }

	public AsmJitAssembler()
	{
		this.struct19_0 = default(AsmJitAssemblerState);
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate2_0(ref this.struct19_0, IntPtr.Zero);
			return;
		}
		AsmJitApi.delegate1_0(ref this.struct19_0, IntPtr.Zero);
	}

	~AsmJitAssembler()
	{
		((IDisposable)this).Dispose();
	}

	void IDisposable.Dispose()
	{
		RecoveredRuntime.DisposeAssemblerState(this);
	}

	public void EmbedData<T>(T gparam_0) where T : struct
	{
		RecoveredRuntime.EmbedData(Marshal.SizeOf(typeof(T)), gparam_0, this);
	}
}
