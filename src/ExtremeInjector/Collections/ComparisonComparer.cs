using System;
using System.Collections.Generic;

public sealed class ComparisonComparer<T> : Comparer<T>
{
	internal readonly Comparison<T> comparison;

	public ComparisonComparer(Comparison<T> comparison2)
	{
		if (comparison2 == null)
		{
			throw new ArgumentNullException("comparison");
		}
		comparison = comparison2;
	}

	public override int Compare(T value, T value2)
	{
		return comparison(value, value2);
	}
}
