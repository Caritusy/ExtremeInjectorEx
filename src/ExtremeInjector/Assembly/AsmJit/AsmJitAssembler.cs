using System;
using System.Runtime.InteropServices;

public sealed class AsmJitAssembler : IDisposable
{
	internal AsmJitAssemblerState assemblerState;

	public bool Is32BitMode { get; set; }

	public AsmJitAssembler()
	{
		this.assemblerState = default(AsmJitAssemblerState);
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.destroyAssemblerCdecl(ref this.assemblerState, IntPtr.Zero);
			return;
		}
		AsmJitApi.destroyAssemblerThisCall(ref this.assemblerState, IntPtr.Zero);
	}

	~AsmJitAssembler()
	{
		((IDisposable)this).Dispose();
	}

	void IDisposable.Dispose()
	{
		RecoveredRuntime.DisposeAssemblerState(this);
	}

	public void EmbedData<T>(T value) where T : struct
	{
		RecoveredRuntime.EmbedData(Marshal.SizeOf(typeof(T)), value, this);
	}
}
