using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

public sealed class SortableKeyedCollection<T, U> : KeyedCollection<T, U>
{
	[CompilerGenerated]
	public sealed class Class42
	{
		public IComparer<T> icomparer_0;

		public SortableKeyedCollection<T, U> class41_0;

		internal int method_0(U gparam_0, U gparam_1)
		{
			return icomparer_0.Compare(class41_0.GetKeyForItem(gparam_0), class41_0.GetKeyForItem(gparam_1));
		}
	}

	[CompilerGenerated]
	public sealed class Class43
	{
		public Comparison<T> comparison_0;

		public SortableKeyedCollection<T, U> class41_0;

		internal int method_0(U gparam_0, U gparam_1)
		{
			return comparison_0(class41_0.GetKeyForItem(gparam_0), class41_0.GetKeyForItem(gparam_1));
		}
	}

	internal const string string_0 = "Delegate passed cannot be null";

	internal readonly Func<U, T> func_0;

	public SortableKeyedCollection(Func<U, T> func_1)
	{
		if (func_1 != null)
		{
			this.func_0 = func_1;
			return;
		}
		throw SortableKeyedCollection<T, U>.smethod_0(EncodedStringTable.smethod_0(4398));
	}

	public SortableKeyedCollection(Func<U, T> func_1, IEqualityComparer<T> iequalityComparer_0)
		: base(iequalityComparer_0)
	{
		if (func_1 == null)
		{
			throw smethod_0("Delegate passed cannot be null");
		}
		func_0 = func_1;
	}

	protected override T GetKeyForItem(U item)
	{
		return func_0(item);
	}

	public void method_0()
	{
		Comparer<T> icomparer_ = Comparer<T>.Default;
		method_1(icomparer_);
	}

	public void method_1(IComparer<T> icomparer_0)
	{
		ComparisonComparer<U> icomparer_ = new ComparisonComparer<U>((U gparam_0, U gparam_1) => icomparer_0.Compare(this.GetKeyForItem(gparam_0), this.GetKeyForItem(gparam_1)));
		this.method_5(icomparer_);
	}

	public void method_2(Comparison<T> comparison_0)
	{
		ComparisonComparer<U> icomparer_ = new ComparisonComparer<U>((U gparam_0, U gparam_1) => comparison_0(this.GetKeyForItem(gparam_0), this.GetKeyForItem(gparam_1)));
		this.method_5(icomparer_);
	}

	public void method_3()
	{
		Comparer<U> icomparer_ = Comparer<U>.Default;
		method_5(icomparer_);
	}

	public void method_4(Comparison<U> comparison_0)
	{
		ComparisonComparer<U> icomparer_ = new ComparisonComparer<U>(comparison_0);
		this.method_5(icomparer_);
	}

	public void method_5(IComparer<U> icomparer_0)
	{
		List<U> list = base.Items as List<U>;
		if (list != null)
		{
			list.Sort(icomparer_0);
		}
	}

	internal static ArgumentNullException smethod_0(string string_1)
	{
		return new ArgumentNullException(string_1);
	}
}
