using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;

public sealed class OrderedDictionary<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IOrderedDictionaryEx<T, U>, IEnumerable, IOrderedDictionary, IDictionary, ICollection
{
	internal SortableKeyedCollection<T, KeyValuePair<T, U>> itemAt;

	[CompilerGenerated]
	internal IEqualityComparer<T> equalityComparer;

	public U this[int intValue]
	{
		get
		{
			if (intValue >= 0 && intValue < itemAt.Count)
			{
				return itemAt[intValue].Value;
			}
			throw new ArgumentException(string.Format("The index is outside the bounds of the dictionary: {0}", intValue));
		}
		set
		{
			if (intValue >= 0 && intValue < itemAt.Count)
			{
				itemAt[intValue] = new KeyValuePair<T, U>(itemAt[intValue].Key, value);
				return;
			}
			throw new ArgumentException(string.Format("The index is outside the bounds of the dictionary: {0}", intValue));
		}
	}

	public U this[T key]
	{
		get
		{
			if (!itemAt.Contains(key))
			{
				throw new ArgumentException(string.Format("The given key is not present in the dictionary: {0}", key));
			}
			return itemAt[key].Value;
		}
		set
		{
			KeyValuePair<T, U> keyValuePair = new KeyValuePair<T, U>(key, value);
			int num = IndexOfKey(key);
			if (num > -1)
			{
				itemAt[num] = keyValuePair;
				return;
			}
			itemAt.Add(keyValuePair);
		}
	}

	public int Count => itemAt.Count;

	public ICollection<T> Keys => itemAt.Select(pair => pair.Key).ToList();

	public ICollection<U> Values => itemAt.Select(pair => pair.Value).ToList();

	public IEqualityComparer<T> KeyComparer
	{
		[CompilerGenerated]
		get
		{
			return equalityComparer;
		}
		[CompilerGenerated]
		internal set
		{
			equalityComparer = value;
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

	int ICollection<KeyValuePair<T, U>>.Count => itemAt.Count;

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

	int ICollection.Count => itemAt.Count;

	bool ICollection.IsSynchronized => ((ICollection)itemAt).IsSynchronized;

	object ICollection.SyncRoot => ((ICollection)itemAt).SyncRoot;

	public OrderedDictionary()
	{
		Initialize(null);
	}

	public OrderedDictionary(IEqualityComparer<T> equalityComparer2)
	{
		Initialize(equalityComparer2);
	}

	public OrderedDictionary(IOrderedDictionaryEx<T, U> dictionary)
	{
		this.Initialize(null);
		foreach (KeyValuePair<T, U> item in dictionary)
		{
			this.itemAt.Add(item);
		}
	}

	public OrderedDictionary(IOrderedDictionaryEx<T, U> dictionary, IEqualityComparer<T> equalityComparer2)
	{
		Initialize(equalityComparer2);
		foreach (KeyValuePair<T, U> item in dictionary)
		{
			itemAt.Add(item);
		}
	}

	internal void Initialize(IEqualityComparer<T> equalityComparer2)
	{
		KeyComparer = equalityComparer2;
		itemAt = ((equalityComparer2 != null) ? new SortableKeyedCollection<T, KeyValuePair<T, U>>((KeyValuePair<T, U> keyValuePair) => keyValuePair.Key, equalityComparer2) : new SortableKeyedCollection<T, KeyValuePair<T, U>>((KeyValuePair<T, U> keyValuePair) => keyValuePair.Key));
	}

	public void Add(T key, U value)
	{
		itemAt.Add(new KeyValuePair<T, U>(key, value));
	}

	public void Clear()
	{
		itemAt.Clear();
	}

	public void Insert(int intValue, T value, U value2)
	{
		itemAt.Insert(intValue, new KeyValuePair<T, U>(value, value2));
	}

	public int IndexOfKey(T value)
	{
		if (itemAt.Contains(value))
		{
			return itemAt.IndexOf(itemAt[value]);
		}
		return -1;
	}

	public bool ContainsValue(U value)
	{
		return Values.Contains(value);
	}

	public bool ContainsValue(U value, IEqualityComparer<U> equalityComparer2)
	{
		return Values.Contains(value, equalityComparer2);
	}

	public bool ContainsKey(T key)
	{
		return itemAt.Contains(key);
	}

	public KeyValuePair<T, U> GetItemAt(int intValue)
	{
		if (intValue >= 0 && intValue < this.itemAt.Count)
		{
			return this.itemAt[intValue];
		}
		throw new ArgumentException(string.Format(EncodedStringTable.DecodeString(4321), intValue));
	}

	public IEnumerator<KeyValuePair<T, U>> GetEnumerator()
	{
		return itemAt.GetEnumerator();
	}

	public bool Remove(T key)
	{
		return itemAt.Remove(key);
	}

	public void RemoveAt(int index)
	{
		if (index < 0 || index >= this.itemAt.Count)
		{
			throw new ArgumentException(string.Format(EncodedStringTable.DecodeString(4321), index));
		}
		this.itemAt.RemoveAt(index);
	}

	public bool TryGetValue(T key, out U value)
	{
		if (itemAt.Contains(key))
		{
			value = itemAt[key].Value;
			return true;
		}
		value = default(U);
		return false;
	}

	public void SortByKey()
	{
		itemAt.SortByKey();
	}

	public void SortByKey(IComparer<T> comparer)
	{
		itemAt.SortByKey(comparer);
	}

	public void SortByKey(Comparison<T> comparison)
	{
		itemAt.SortByKey(comparison);
	}

	public void SortByValue()
	{
		Comparer<U> @default = Comparer<U>.Default;
		this.SortByValue(@default);
	}

	public void SortByValue(IComparer<U> comparer)
	{
		itemAt.SortByValue((KeyValuePair<T, U> keyValuePair, KeyValuePair<T, U> keyValuePair2) => comparer.Compare(keyValuePair.Value, keyValuePair2.Value));
	}

	public void SortByValue(Comparison<U> comparison)
	{
		itemAt.SortByValue((KeyValuePair<T, U> keyValuePair, KeyValuePair<T, U> keyValuePair2) => comparison(keyValuePair.Value, keyValuePair2.Value));
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
		itemAt.Add(item);
	}

	void ICollection<KeyValuePair<T, U>>.Clear()
	{
		itemAt.Clear();
	}

	bool ICollection<KeyValuePair<T, U>>.Contains(KeyValuePair<T, U> item)
	{
		return itemAt.Contains(item);
	}

	void ICollection<KeyValuePair<T, U>>.CopyTo(KeyValuePair<T, U>[] array, int arrayIndex)
	{
		itemAt.CopyTo(array, arrayIndex);
	}

	bool ICollection<KeyValuePair<T, U>>.Remove(KeyValuePair<T, U> item)
	{
		return itemAt.Remove(item);
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
		return itemAt.Contains((T)key);
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
		((ICollection)itemAt).CopyTo(array, index);
	}
}
