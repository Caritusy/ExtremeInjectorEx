using System;

public abstract class DllInjector : RemoteCodeExecutorBase
{
	protected DllInjector(RemoteProcess process)
		: base(process)
	{
	}

	public abstract IntPtr Inject(string modulePath);
}
