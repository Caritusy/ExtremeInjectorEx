using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

public sealed class ResourceAssemblyResolver
{
	internal static Assembly assembly_0 = null;

	internal static string[] string_0 = new string[0];

	internal static void smethod_0()
	{
		try
		{
			AppDomain.CurrentDomain.ResourceResolve += smethod_1;
		}
		catch (Exception)
		{
		}
	}

	internal static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (ResourceAssemblyResolver.assembly_0 == null)
		{
			lock (ResourceAssemblyResolver.string_0)
			{
				ResourceAssemblyResolver.assembly_0 = Assembly.Load(_003CModule_003E.smethod_2<string>(3928278315u));
				if (ResourceAssemblyResolver.assembly_0 != null)
				{
					ResourceAssemblyResolver.string_0 = ResourceAssemblyResolver.assembly_0.GetManifestResourceNames();
				}
			}
		}
		string name = resolveEventArgs_0.Name;
		int i = 0;
		while (i < ResourceAssemblyResolver.string_0.Length)
		{
			if (!(ResourceAssemblyResolver.string_0[i] == name))
			{
				i++;
			}
			else
			{
				if (ResourceAssemblyResolver.smethod_2())
				{
					return ResourceAssemblyResolver.assembly_0;
				}
				return null;
			}
		}
		return null;
	}

	internal static bool smethod_2()
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

	internal static AppDomain smethod_3()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void smethod_4(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0)
	{
		appDomain_0.ResourceResolve += resolveEventHandler_0;
	}

	internal static void smethod_5(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static Assembly smethod_6(string string_1)
	{
		return Assembly.Load(string_1);
	}

	internal static string[] smethod_7(Assembly assembly_1)
	{
		return assembly_1.GetManifestResourceNames();
	}

	internal static void smethod_8(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static string smethod_9(ResolveEventArgs resolveEventArgs_0)
	{
		return resolveEventArgs_0.Name;
	}

	internal static bool smethod_10(string string_1, string string_2)
	{
		return string_1 == string_2;
	}

	internal static StackTrace smethod_11()
	{
		return new StackTrace();
	}

	internal static StackFrame[] smethod_12(StackTrace stackTrace_0)
	{
		return stackTrace_0.GetFrames();
	}

	internal static MethodBase smethod_13(StackFrame stackFrame_0)
	{
		return stackFrame_0.GetMethod();
	}

	internal static Module smethod_14(MemberInfo memberInfo_0)
	{
		return memberInfo_0.Module;
	}

	internal static Assembly smethod_15(Module module_0)
	{
		return module_0.Assembly;
	}

	internal static Assembly smethod_16()
	{
		return Assembly.GetExecutingAssembly();
	}
}
