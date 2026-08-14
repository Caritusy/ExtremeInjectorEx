using System;
using System.Reflection;

public static class ReflectionMethodLookup
{
	public static MethodInfo smethod_0(Type type_0, string string_0, Type[] type_1)
	{
		return type_0.GetMethod(string_0, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, type_1, null);
	}
}
