using System;
using System.Collections;
using System.Collections.Generic;

public sealed class Class45<T, U> : IDisposable, IEnumerator, IDictionaryEnumerator
{
	internal readonly IEnumerator<KeyValuePair<T, U>> ienumerator_0;

	DictionaryEntry IDictionaryEnumerator.Entry
	{
		get
		{
			KeyValuePair<T, U> current = ienumerator_0.Current;
			return new DictionaryEntry(current.Key, current.Value);
		}
	}

	object IDictionaryEnumerator.Key => ienumerator_0.Current.Key;

	object IDictionaryEnumerator.Value => ienumerator_0.Current.Value;

	object IEnumerator.Current => ((IDictionaryEnumerator)this).Entry;

	void IDisposable.Dispose()
	{
		smethod_0(ienumerator_0);
	}

	public Class45(IEnumerable<KeyValuePair<T, U>> ienumerable_0)
	{
		ienumerator_0 = ienumerable_0.GetEnumerator();
	}

	void IEnumerator.Reset()
	{
		smethod_1(ienumerator_0);
	}

	bool IEnumerator.MoveNext()
	{
		return smethod_2(ienumerator_0);
	}

	internal static void smethod_0(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static void smethod_1(IEnumerator ienumerator_1)
	{
		ienumerator_1.Reset();
	}

	internal static bool smethod_2(IEnumerator ienumerator_1)
	{
		return ienumerator_1.MoveNext();
	}
}
