using System;

internal static class InjectorFactory
{
	internal static DllInjector Create(InjectionMethod method, RemoteProcess process)
	{
		if (process == null)
		{
			throw new ArgumentNullException(nameof(process));
		}

		switch (method)
		{
			case InjectionMethod.StandardInjection:
				return new LoadLibraryInjector(process);
			case InjectionMethod.LdrpLoadDll:
				return new LdrLoadDllInjector(process);
			case InjectionMethod.LdrpLoadDllStub:
				return new LdrLoadDllStubInjector(process);
			case InjectionMethod.ThreadHijacking:
				return new ThreadHijackInjector(process);
			case InjectionMethod.ManualMap:
				return new ManualMapInjector(process);
			default:
				throw new ArgumentOutOfRangeException(nameof(method), method, "Unsupported injection method.");
		}
	}
}
