using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;

public sealed class OrderedDictionary<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IOrderedDictionaryEx<T, U>, IEnumerable, IOrderedDictionary, IDictionary, ICollection
{
	internal SortableKeyedCollection<T, KeyValuePair<T, U>> class41_0;

	[CompilerGenerated]
	internal IEqualityComparer<T> iequalityComparer_0;

	public U this[int int_0]
	{
		get
		{
			if (int_0 >= 0 && int_0 < class41_0.Count)
			{
				return class41_0[int_0].Value;
			}
			throw new ArgumentException(string.Format("The index is outside the bounds of the dictionary: {0}", int_0));
		}
		set
		{
			if (int_0 >= 0 && int_0 < class41_0.Count)
			{
				class41_0[int_0] = new KeyValuePair<T, U>(class41_0[int_0].Key, value);
				return;
			}
			throw new ArgumentException(string.Format("The index is outside the bounds of the dictionary: {0}", int_0));
		}
	}

	public U this[T key]
	{
		get
		{
			if (!class41_0.Contains(key))
			{
				throw new ArgumentException(string.Format("The given key is not present in the dictionary: {0}", key));
			}
			return class41_0[key].Value;
		}
		set
		{
			KeyValuePair<T, U> keyValuePair = new KeyValuePair<T, U>(key, value);
			int num = IndexOfKey(key);
			if (num > -1)
			{
				class41_0[num] = keyValuePair;
				return;
			}
			class41_0.Add(keyValuePair);
		}
	}

	public int Count => class41_0.Count;

	public ICollection<T> Keys => class41_0.Select(pair => pair.Key).ToList();

	public ICollection<U> Values => class41_0.Select(pair => pair.Value).ToList();

	public IEqualityComparer<T> KeyComparer
	{
		[CompilerGenerated]
		get
		{
			return iequalityComparer_0;
		}
		[CompilerGenerated]
		internal set
		{
			iequalityComparer_0 = value;
		}
	}

	public bool IsReadOnly => false;

	ICollection<T> IDictionary<T, U>.Keys => Keys;

	ICollection<U> IDictionary<T, U>.Values => Values;

	U IDictionary<T, U>.this[T key]
	{
		get
		{
			return this[key];
		}
		set
		{
			this[key] = value;
		}
	}

	int ICollection<KeyValuePair<T, U>>.Count => class41_0.Count;

	bool ICollection<KeyValuePair<T, U>>.IsReadOnly => false;

	object IOrderedDictionary.this[int index]
	{
		get
		{
			return this[index];
		}
		set
		{
			this[index] = (U)value;
		}
	}

	bool IDictionary.IsFixedSize => false;

	bool IDictionary.IsReadOnly => false;

	ICollection IDictionary.Keys => (ICollection)Keys;

	ICollection IDictionary.Values => (ICollection)Values;

	object IDictionary.this[object key]
	{
		get
		{
			return this[(T)key];
		}
		set
		{
			this[(T)key] = (U)value;
		}
	}

	int ICollection.Count => class41_0.Count;

	bool ICollection.IsSynchronized => ((ICollection)class41_0).IsSynchronized;

	object ICollection.SyncRoot => ((ICollection)class41_0).SyncRoot;

	public OrderedDictionary()
	{
		Initialize(null);
	}

	public OrderedDictionary(IEqualityComparer<T> iequalityComparer_1)
	{
		Initialize(iequalityComparer_1);
	}

	public OrderedDictionary(IOrderedDictionaryEx<T, U> interface1_0)
	{
		this.Initialize(null);
		foreach (KeyValuePair<T, U> item in interface1_0)
		{
			this.class41_0.Add(item);
		}
	}

	public OrderedDictionary(IOrderedDictionaryEx<T, U> interface1_0, IEqualityComparer<T> iequalityComparer_1)
	{
		Initialize(iequalityComparer_1);
		foreach (KeyValuePair<T, U> item in interface1_0)
		{
			class41_0.Add(item);
		}
	}

	internal void Initialize(IEqualityComparer<T> iequalityComparer_1)
	{
		KeyComparer = iequalityComparer_1;
		class41_0 = ((iequalityComparer_1 != null) ? new SortableKeyedCollection<T, KeyValuePair<T, U>>((KeyValuePair<T, U> keyValuePair_0) => keyValuePair_0.Key, iequalityComparer_1) : new SortableKeyedCollection<T, KeyValuePair<T, U>>((KeyValuePair<T, U> keyValuePair_0) => keyValuePair_0.Key));
	}

	public void Add(T key, U value)
	{
		class41_0.Add(new KeyValuePair<T, U>(key, value));
	}

	public void Clear()
	{
		class41_0.Clear();
	}

	public void Insert(int int_0, T gparam_0, U gparam_1)
	{
		class41_0.Insert(int_0, new KeyValuePair<T, U>(gparam_0, gparam_1));
	}

	public int IndexOfKey(T gparam_0)
	{
		if (class41_0.Contains(gparam_0))
		{
			return class41_0.IndexOf(class41_0[gparam_0]);
		}
		return -1;
	}

	public bool ContainsValue(U gparam_0)
	{
		return Values.Contains(gparam_0);
	}

	public bool ContainsValue(U gparam_0, IEqualityComparer<U> iequalityComparer_1)
	{
		return Values.Contains(gparam_0, iequalityComparer_1);
	}

	public bool ContainsKey(T key)
	{
		return class41_0.Contains(key);
	}

	public KeyValuePair<T, U> GetItemAt(int int_0)
	{
		if (int_0 >= 0 && int_0 < this.class41_0.Count)
		{
			return this.class41_0[int_0];
		}
		throw new ArgumentException(string.Format(EncodedStringTable.DecodeString(4321), int_0));
	}

	public IEnumerator<KeyValuePair<T, U>> GetEnumerator()
	{
		return class41_0.GetEnumerator();
	}

	public bool Remove(T key)
	{
		return class41_0.Remove(key);
	}

	public void RemoveAt(int index)
	{
		if (index < 0 || index >= this.class41_0.Count)
		{
			throw new ArgumentException(string.Format(EncodedStringTable.DecodeString(4321), index));
		}
		this.class41_0.RemoveAt(index);
	}

	public bool TryGetValue(T key, out U value)
	{
		if (class41_0.Contains(key))
		{
			value = class41_0[key].Value;
			return true;
		}
		value = default(U);
		return false;
	}

	public void SortByKey()
	{
		class41_0.SortByKey();
	}

	public void SortByKey(IComparer<T> icomparer_0)
	{
		class41_0.SortByKey(icomparer_0);
	}

	public void SortByKey(Comparison<T> comparison_0)
	{
		class41_0.SortByKey(comparison_0);
	}

	public void SortByValue()
	{
		Comparer<U> @default = Comparer<U>.Default;
		this.SortByValue(@default);
	}

	public void SortByValue(IComparer<U> icomparer_0)
	{
		class41_0.SortByValue((KeyValuePair<T, U> keyValuePair_0, KeyValuePair<T, U> keyValuePair_1) => icomparer_0.Compare(keyValuePair_0.Value, keyValuePair_1.Value));
	}

	public void SortByValue(Comparison<U> comparison_0)
	{
		class41_0.SortByValue((KeyValuePair<T, U> keyValuePair_0, KeyValuePair<T, U> keyValuePair_1) => comparison_0(keyValuePair_0.Value, keyValuePair_1.Value));
	}

	void IDictionary<T, U>.Add(T key, U value)
	{
		Add(key, value);
	}

	bool IDictionary<T, U>.ContainsKey(T key)
	{
		return ContainsKey(key);
	}

	bool IDictionary<T, U>.Remove(T key)
	{
		return Remove(key);
	}

	bool IDictionary<T, U>.TryGetValue(T key, out U value)
	{
		return TryGetValue(key, out value);
	}

	void ICollection<KeyValuePair<T, U>>.Add(KeyValuePair<T, U> item)
	{
		class41_0.Add(item);
	}

	void ICollection<KeyValuePair<T, U>>.Clear()
	{
		class41_0.Clear();
	}

	bool ICollection<KeyValuePair<T, U>>.Contains(KeyValuePair<T, U> item)
	{
		return class41_0.Contains(item);
	}

	void ICollection<KeyValuePair<T, U>>.CopyTo(KeyValuePair<T, U>[] array, int arrayIndex)
	{
		class41_0.CopyTo(array, arrayIndex);
	}

	bool ICollection<KeyValuePair<T, U>>.Remove(KeyValuePair<T, U> item)
	{
		return class41_0.Remove(item);
	}

	IEnumerator<KeyValuePair<T, U>> IEnumerable<KeyValuePair<T, U>>.GetEnumerator()
	{
		return GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
	{
		return new DictionaryEnumeratorAdapter<T, U>(this);
	}

	void IOrderedDictionary.Insert(int index, object key, object value)
	{
		Insert(index, (T)key, (U)value);
	}

	void IOrderedDictionary.RemoveAt(int index)
	{
		RemoveAt(index);
	}

	void IDictionary.Add(object key, object value)
	{
		Add((T)key, (U)value);
	}

	void IDictionary.Clear()
	{
		Clear();
	}

	bool IDictionary.Contains(object key)
	{
		return class41_0.Contains((T)key);
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return new DictionaryEnumeratorAdapter<T, U>(this);
	}

	void IDictionary.Remove(object key)
	{
		Remove((T)key);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		((ICollection)class41_0).CopyTo(array, index);
	}
}
