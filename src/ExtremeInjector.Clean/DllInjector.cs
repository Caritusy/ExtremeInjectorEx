using System;

public abstract class DllInjector : Class84
{
	protected DllInjector(RemoteProcess process)
		: base(process)
	{
	}

	public abstract IntPtr Inject(string modulePath);
}
