using System;
using System.Collections;
using System.Collections.Generic;

public sealed class DictionaryEnumeratorAdapter<T, U> : IDisposable, IEnumerator, IDictionaryEnumerator
{
	internal readonly IEnumerator<KeyValuePair<T, U>> enumerator;

	DictionaryEntry IDictionaryEnumerator.Entry
	{
		get
		{
			KeyValuePair<T, U> current = enumerator.Current;
			return new DictionaryEntry(current.Key, current.Value);
		}
	}

	object IDictionaryEnumerator.Key => enumerator.Current.Key;

	object IDictionaryEnumerator.Value => enumerator.Current.Value;

	object IEnumerator.Current => ((IDictionaryEnumerator)this).Entry;

	void IDisposable.Dispose()
	{
		enumerator.Dispose();
	}

	public DictionaryEnumeratorAdapter(IEnumerable<KeyValuePair<T, U>> items)
	{
		enumerator = items.GetEnumerator();
	}

	void IEnumerator.Reset()
	{
		enumerator.Reset();
	}

	bool IEnumerator.MoveNext()
	{
		return enumerator.MoveNext();
	}
}
