using System;
using System.Collections.Generic;

public sealed class Class44<T> : Comparer<T>
{
	internal readonly Comparison<T> comparison_0;

	public Class44(Comparison<T> comparison_1)
	{
		if (comparison_1 == null)
		{
			throw smethod_0(Class178.smethod_0(4439));
		}
		comparison_0 = comparison_1;
	}

	public override int Compare(T gparam_0, T gparam_1)
	{
		return comparison_0(gparam_0, gparam_1);
	}

	internal static ArgumentNullException smethod_0(string string_0)
	{
		return new ArgumentNullException(string_0);
	}
}
