using System;
using System.Collections;
using System.Collections.Generic;

public sealed class DictionaryEnumeratorAdapter<T, U> : IDisposable, IEnumerator, IDictionaryEnumerator
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
		ienumerator_0.Dispose();
	}

	public DictionaryEnumeratorAdapter(IEnumerable<KeyValuePair<T, U>> ienumerable_0)
	{
		ienumerator_0 = ienumerable_0.GetEnumerator();
	}

	void IEnumerator.Reset()
	{
		ienumerator_0.Reset();
	}

	bool IEnumerator.MoveNext()
	{
		return ienumerator_0.MoveNext();
	}
}
