using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public sealed class SortableKeyedCollection<T, U> : KeyedCollection<T, U>
{
	internal const string text = "Delegate passed cannot be null";

	internal readonly Func<U, T> keyForItem;

	public SortableKeyedCollection(Func<U, T> callback)
	{
		if (callback != null)
		{
			this.keyForItem = callback;
			return;
		}
		throw new ArgumentNullException(EncodedStringTable.DecodeString(4398));
	}

	public SortableKeyedCollection(Func<U, T> callback, IEqualityComparer<T> equalityComparer)
		: base(equalityComparer)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("Delegate passed cannot be null");
		}
		keyForItem = callback;
	}

	protected override T GetKeyForItem(U item)
	{
		return keyForItem(item);
	}

	public void SortByKey()
	{
		Comparer<T> icomparer_ = Comparer<T>.Default;
		SortByKey(icomparer_);
	}

	public void SortByKey(IComparer<T> comparer)
	{
		ComparisonComparer<U> icomparer_ = new ComparisonComparer<U>((U value, U value2) => comparer.Compare(this.GetKeyForItem(value), this.GetKeyForItem(value2)));
		this.SortByValue(icomparer_);
	}

	public void SortByKey(Comparison<T> comparison)
	{
		ComparisonComparer<U> icomparer_ = new ComparisonComparer<U>((U value, U value2) => comparison(this.GetKeyForItem(value), this.GetKeyForItem(value2)));
		this.SortByValue(icomparer_);
	}

	public void SortByValue()
	{
		Comparer<U> icomparer_ = Comparer<U>.Default;
		SortByValue(icomparer_);
	}

	public void SortByValue(Comparison<U> comparison)
	{
		ComparisonComparer<U> icomparer_ = new ComparisonComparer<U>(comparison);
		this.SortByValue(icomparer_);
	}

	public void SortByValue(IComparer<U> comparer)
	{
		List<U> list = base.Items as List<U>;
		if (list != null)
		{
			list.Sort(comparer);
		}
	}
}
