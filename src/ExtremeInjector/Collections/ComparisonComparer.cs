using System;
using System.Collections.Generic;

public sealed class ComparisonComparer<T> : Comparer<T>
{
	internal readonly Comparison<T> comparison_0;

	public ComparisonComparer(Comparison<T> comparison_1)
	{
		if (comparison_1 == null)
		{
			throw new ArgumentNullException("comparison");
		}
		comparison_0 = comparison_1;
	}

	public override int Compare(T gparam_0, T gparam_1)
	{
		return comparison_0(gparam_0, gparam_1);
	}
}
