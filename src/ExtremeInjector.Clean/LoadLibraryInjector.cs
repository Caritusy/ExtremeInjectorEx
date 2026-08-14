using System;
using System.IO;
using System.Text;

public sealed class LoadLibraryInjector : DllInjector
{
	private const Class124.Enum32 InjectionProcessAccess =
		Class124.Enum32.flag_2 |
		Class124.Enum32.flag_3 |
		Class124.Enum32.flag_4 |
		Class124.Enum32.flag_5 |
		Class124.Enum32.flag_9;

	public LoadLibraryInjector(RemoteProcess process)
		: base(process)
	{
	}

	protected override void method_04C6()
	{
		if (method_2() != IntPtr.Zero || method_0() == -1)
		{
			return;
		}

		method_3(Class171.OpenProcess(InjectionProcessAccess, bool_0: false, method_0()));
	}

	public override IntPtr Inject(string modulePath)
	{
		RemoteProcess process = method_19();
		if (!method_8(process.ProcessId))
		{
			throw new UnauthorizedAccessException("Unable to open the specified process for injection.");
		}

		GClass1 kernel32 = Class171.smethod_42(process)["kernel32.dll"]
			?? throw new FileNotFoundException("Unable to find kernel32.dll in the specified process.");
		IntPtr loadLibraryAddress = Class171.smethod_225(kernel32, "LoadLibraryW", bool_0: false);
		if (loadLibraryAddress == IntPtr.Zero)
		{
			throw new MissingMethodException("Unable to find the LoadLibraryW function inside the specified process.");
		}

		byte[] encodedPath = Encoding.Unicode.GetBytes(modulePath + "\0");
		IntPtr remotePath = Class171.smethod_175(this, encodedPath.Length, Class124.Enum34.flag_6);
		if (remotePath == IntPtr.Zero)
		{
			throw new AccessViolationException("Unable to allocate memory for the injection path.");
		}

		try
		{
			if (!method_16(remotePath, encodedPath))
			{
				throw new AccessViolationException("Unable to write memory for the injection path.");
			}

			IntPtr remoteThread = Class171.smethod_321(this, loadLibraryAddress, remotePath);
			if (remoteThread == IntPtr.Zero)
			{
				throw new AccessViolationException("Unable to create thread in the specified process.");
			}

			try
			{
				Class171.smethod_153(this, remoteThread, -1);
			}
			finally
			{
				Class171.smethod_108(this, remoteThread);
			}
		}
		finally
		{
			vmethod_6(remotePath);
		}

		return Class171.smethod_42(process).method_0(Path.GetFileName(modulePath));
	}
}
