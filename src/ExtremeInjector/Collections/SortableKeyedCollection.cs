using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public sealed class SortableKeyedCollection<T, U> : KeyedCollection<T, U>
{
	internal const string string_0 = "Delegate passed cannot be null";

	internal readonly Func<U, T> func_0;

	public SortableKeyedCollection(Func<U, T> func_1)
	{
		if (func_1 != null)
		{
			this.func_0 = func_1;
			return;
		}
		throw new ArgumentNullException(EncodedStringTable.DecodeString(4398));
	}

	public SortableKeyedCollection(Func<U, T> func_1, IEqualityComparer<T> iequalityComparer_0)
		: base(iequalityComparer_0)
	{
		if (func_1 == null)
		{
			throw new ArgumentNullException("Delegate passed cannot be null");
		}
		func_0 = func_1;
	}

	protected override T GetKeyForItem(U item)
	{
		return func_0(item);
	}

	public void SortByKey()
	{
		Comparer<T> icomparer_ = Comparer<T>.Default;
		SortByKey(icomparer_);
	}

	public void SortByKey(IComparer<T> icomparer_0)
	{
		ComparisonComparer<U> icomparer_ = new ComparisonComparer<U>((U gparam_0, U gparam_1) => icomparer_0.Compare(this.GetKeyForItem(gparam_0), this.GetKeyForItem(gparam_1)));
		this.SortByValue(icomparer_);
	}

	public void SortByKey(Comparison<T> comparison_0)
	{
		ComparisonComparer<U> icomparer_ = new ComparisonComparer<U>((U gparam_0, U gparam_1) => comparison_0(this.GetKeyForItem(gparam_0), this.GetKeyForItem(gparam_1)));
		this.SortByValue(icomparer_);
	}

	public void SortByValue()
	{
		Comparer<U> icomparer_ = Comparer<U>.Default;
		SortByValue(icomparer_);
	}

	public void SortByValue(Comparison<U> comparison_0)
	{
		ComparisonComparer<U> icomparer_ = new ComparisonComparer<U>(comparison_0);
		this.SortByValue(icomparer_);
	}

	public void SortByValue(IComparer<U> icomparer_0)
	{
		List<U> list = base.Items as List<U>;
		if (list != null)
		{
			list.Sort(icomparer_0);
		}
	}
}
