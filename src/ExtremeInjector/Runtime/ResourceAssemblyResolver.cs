using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

public sealed class ResourceAssemblyResolver
{
	private static readonly object syncRoot = new object();

	internal static Assembly assemblyValue = null;

	internal static string[] strings = new string[0];

	internal static void Initialize()
	{
		try
		{
			AppDomain.CurrentDomain.ResourceResolve += ResolveResourceAssembly;
		}
		catch (Exception)
		{
		}
	}

	internal static Assembly ResolveResourceAssembly(object sender, ResolveEventArgs eventArgs)
	{
		if (ResourceAssemblyResolver.assemblyValue == null)
		{
			lock (ResourceAssemblyResolver.syncRoot)
			{
				string assemblyName = _003CModule_003E.DecodeConstantWithKeyA<string>(3928278315u);
				ResourceAssemblyResolver.assemblyValue ??=
					RecoveredRuntime.ResolveEmbeddedAssembly(null, new ResolveEventArgs(assemblyName)) ??
					Assembly.Load(assemblyName);
				if (ResourceAssemblyResolver.assemblyValue != null)
				{
					ResourceAssemblyResolver.strings = ResourceAssemblyResolver.assemblyValue.GetManifestResourceNames();
				}
			}
		}
		string name = eventArgs.Name;
		int i = 0;
		while (i < ResourceAssemblyResolver.strings.Length)
		{
			if (!(ResourceAssemblyResolver.strings[i] == name))
			{
				i++;
			}
			else
			{
				if (ResourceAssemblyResolver.IsRequestFromExecutingAssembly())
				{
					return ResourceAssemblyResolver.assemblyValue;
				}
				return null;
			}
		}
		return null;
	}

	internal static bool IsRequestFromExecutingAssembly()
	{
		bool result;
		try
		{
			StackFrame[] frames = new StackTrace().GetFrames();
			for (int i = 2; i < frames.Length; i++)
			{
				StackFrame stackFrame = frames[i];
				if (stackFrame.GetMethod().Module.Assembly == Assembly.GetExecutingAssembly())
				{
					return true;
				}
			}
			result = false;
		}
		catch
		{
			result = true;
		}
		return result;
	}

}
