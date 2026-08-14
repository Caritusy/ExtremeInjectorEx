using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

public sealed class ResourceAssemblyResolver
{
	internal static Assembly assembly_0 = null;

	internal static string[] string_0 = new string[0];

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
		if (ResourceAssemblyResolver.assembly_0 == null)
		{
			lock (ResourceAssemblyResolver.string_0)
			{
				ResourceAssemblyResolver.assembly_0 = Assembly.Load(_003CModule_003E.DecodeConstantWithKeyA<string>(3928278315u));
				if (ResourceAssemblyResolver.assembly_0 != null)
				{
					ResourceAssemblyResolver.string_0 = ResourceAssemblyResolver.assembly_0.GetManifestResourceNames();
				}
			}
		}
		string name = eventArgs.Name;
		int i = 0;
		while (i < ResourceAssemblyResolver.string_0.Length)
		{
			if (!(ResourceAssemblyResolver.string_0[i] == name))
			{
				i++;
			}
			else
			{
				if (ResourceAssemblyResolver.IsRequestFromExecutingAssembly())
				{
					return ResourceAssemblyResolver.assembly_0;
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
