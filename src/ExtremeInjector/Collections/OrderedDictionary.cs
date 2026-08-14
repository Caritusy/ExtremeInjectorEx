using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;

public sealed class OrderedDictionary<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IOrderedDictionaryEx<T, U>, IEnumerable, IOrderedDictionary, IDictionary, ICollection
{
	[Serializable]
	[CompilerGenerated]
	public sealed class Class38
	{
		public static readonly Class38 _003C_003E9 = new Class38();

		public static Func<KeyValuePair<T, U>, T> _003C_003E9__10_0;

		public static Func<KeyValuePair<T, U>, U> _003C_003E9__12_0;

		public static Func<KeyValuePair<T, U>, T> _003C_003E9__21_0;

		public static Func<KeyValuePair<T, U>, T> _003C_003E9__21_1;

		internal T method_0(KeyValuePair<T, U> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		internal U method_1(KeyValuePair<T, U> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		internal T method_2(KeyValuePair<T, U> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		internal T method_3(KeyValuePair<T, U> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}
	}

	[CompilerGenerated]
	public sealed class Class39
	{
		public IComparer<U> icomparer_0;

		internal int method_0(KeyValuePair<T, U> keyValuePair_0, KeyValuePair<T, U> keyValuePair_1)
		{
			return icomparer_0.Compare(keyValuePair_0.Value, keyValuePair_1.Value);
		}
	}

	[CompilerGenerated]
	public sealed class Class40
	{
		public Comparison<U> comparison_0;

		internal int method_0(KeyValuePair<T, U> keyValuePair_0, KeyValuePair<T, U> keyValuePair_1)
		{
			return comparison_0(keyValuePair_0.Value, keyValuePair_1.Value);
		}
	}

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
			throw smethod_1(smethod_0("The index is outside the bounds of the dictionary: {0}", int_0));
		}
		set
		{
			if (int_0 >= 0 && int_0 < class41_0.Count)
			{
				class41_0[int_0] = new KeyValuePair<T, U>(class41_0[int_0].Key, value);
				return;
			}
			throw smethod_1(smethod_0("The index is outside the bounds of the dictionary: {0}", int_0));
		}
	}

	public U this[T key]
	{
		get
		{
			if (!class41_0.Contains(key))
			{
				throw smethod_1(smethod_0("The given key is not present in the dictionary: {0}", key));
			}
			return class41_0[key].Value;
		}
		set
		{
			KeyValuePair<T, U> keyValuePair = new KeyValuePair<T, U>(key, value);
			int num = imethod_3(key);
			if (num > -1)
			{
				class41_0[num] = keyValuePair;
				return;
			}
			class41_0.Add(keyValuePair);
		}
	}

	public int Int32_0 => class41_0.Count;

	public ICollection<T> Prop_0 => class41_0.Select((KeyValuePair<T, U> keyValuePair_0) => keyValuePair_0.Key).ToList();

	public ICollection<U> Prop_1 => class41_0.Select((KeyValuePair<T, U> keyValuePair_0) => keyValuePair_0.Value).ToList();

	public IEqualityComparer<T> IEqualityComparer_0
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

	public bool Boolean_0 => false;

	ICollection<T> IDictionary<T, U>.Keys => Prop_0;

	ICollection<U> IDictionary<T, U>.Values => Prop_1;

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

	ICollection IDictionary.Keys => (ICollection)Prop_0;

	ICollection IDictionary.Values => (ICollection)Prop_1;

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

	int ICollection.Count => smethod_5(class41_0);

	bool ICollection.IsSynchronized => smethod_6(class41_0);

	object ICollection.SyncRoot => smethod_7(class41_0);

	public OrderedDictionary()
	{
		method_0(null);
	}

	public OrderedDictionary(IEqualityComparer<T> iequalityComparer_1)
	{
		method_0(iequalityComparer_1);
	}

	public OrderedDictionary(IOrderedDictionaryEx<T, U> interface1_0)
	{
		this.method_0(null);
		IEnumerator<KeyValuePair<T, U>> enumerator = interface1_0.imethod_8();
		try
		{
			while (OrderedDictionary<T, U>.smethod_2(enumerator))
			{
				KeyValuePair<T, U> item = enumerator.Current;
				this.class41_0.Add(item);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				OrderedDictionary<T, U>.smethod_3(enumerator);
			}
		}
	}

	public OrderedDictionary(IOrderedDictionaryEx<T, U> interface1_0, IEqualityComparer<T> iequalityComparer_1)
	{
		method_0(iequalityComparer_1);
		IEnumerator<KeyValuePair<T, U>> enumerator = interface1_0.imethod_8();
		try
		{
			while (smethod_2(enumerator))
			{
				KeyValuePair<T, U> current = enumerator.Current;
				class41_0.Add(current);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				smethod_3(enumerator);
			}
		}
	}

	internal void method_0(IEqualityComparer<T> iequalityComparer_1)
	{
		IEqualityComparer_0 = iequalityComparer_1;
		class41_0 = ((iequalityComparer_1 != null) ? new SortableKeyedCollection<T, KeyValuePair<T, U>>((KeyValuePair<T, U> keyValuePair_0) => keyValuePair_0.Key, iequalityComparer_1) : new SortableKeyedCollection<T, KeyValuePair<T, U>>((KeyValuePair<T, U> keyValuePair_0) => keyValuePair_0.Key));
	}

	public void imethod_0(T key, U value)
	{
		class41_0.Add(new KeyValuePair<T, U>(key, value));
	}

	public void imethod_1()
	{
		class41_0.Clear();
	}

	public void imethod_2(int int_0, T gparam_0, U gparam_1)
	{
		class41_0.Insert(int_0, new KeyValuePair<T, U>(gparam_0, gparam_1));
	}

	public int imethod_3(T gparam_0)
	{
		if (class41_0.Contains(gparam_0))
		{
			return class41_0.IndexOf(class41_0[gparam_0]);
		}
		return -1;
	}

	public bool imethod_4(U gparam_0)
	{
		return Prop_1.Contains(gparam_0);
	}

	public bool imethod_5(U gparam_0, IEqualityComparer<U> iequalityComparer_1)
	{
		return Prop_1.Contains(gparam_0, iequalityComparer_1);
	}

	public bool imethod_6(T key)
	{
		return class41_0.Contains(key);
	}

	public KeyValuePair<T, U> imethod_7(int int_0)
	{
		if (int_0 >= 0 && int_0 < this.class41_0.Count)
		{
			return this.class41_0[int_0];
		}
		throw OrderedDictionary<T, U>.smethod_1(OrderedDictionary<T, U>.smethod_0(EncodedStringTable.smethod_0(4321), int_0));
	}

	public IEnumerator<KeyValuePair<T, U>> imethod_8()
	{
		return class41_0.GetEnumerator();
	}

	public bool imethod_9(T key)
	{
		return class41_0.Remove(key);
	}

	public void imethod_10(int index)
	{
		if (index < 0 || index >= this.class41_0.Count)
		{
			throw OrderedDictionary<T, U>.smethod_1(OrderedDictionary<T, U>.smethod_0(EncodedStringTable.smethod_0(4321), index));
		}
		this.class41_0.RemoveAt(index);
	}

	public bool imethod_11(T key, out U value)
	{
		if (class41_0.Contains(key))
		{
			value = class41_0[key].Value;
			return true;
		}
		value = default(U);
		return false;
	}

	public void method_1()
	{
		class41_0.method_0();
	}

	public void method_2(IComparer<T> icomparer_0)
	{
		class41_0.method_1(icomparer_0);
	}

	public void method_3(Comparison<T> comparison_0)
	{
		class41_0.method_2(comparison_0);
	}

	public void method_4()
	{
		Comparer<U> @default = Comparer<U>.Default;
		this.method_5(@default);
	}

	public void method_5(IComparer<U> icomparer_0)
	{
		class41_0.method_4((KeyValuePair<T, U> keyValuePair_0, KeyValuePair<T, U> keyValuePair_1) => icomparer_0.Compare(keyValuePair_0.Value, keyValuePair_1.Value));
	}

	public void method_6(Comparison<U> comparison_0)
	{
		class41_0.method_4((KeyValuePair<T, U> keyValuePair_0, KeyValuePair<T, U> keyValuePair_1) => comparison_0(keyValuePair_0.Value, keyValuePair_1.Value));
	}

	void IDictionary<T, U>.Add(T key, U value)
	{
		imethod_0(key, value);
	}

	bool IDictionary<T, U>.ContainsKey(T key)
	{
		return imethod_6(key);
	}

	bool IDictionary<T, U>.Remove(T key)
	{
		return imethod_9(key);
	}

	bool IDictionary<T, U>.TryGetValue(T key, out U value)
	{
		return imethod_11(key, out value);
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
		return imethod_8();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return imethod_8();
	}

	IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
	{
		return new DictionaryEnumeratorAdapter<T, U>(this);
	}

	void IOrderedDictionary.Insert(int index, object key, object value)
	{
		imethod_2(index, (T)key, (U)value);
	}

	void IOrderedDictionary.RemoveAt(int index)
	{
		imethod_10(index);
	}

	void IDictionary.Add(object key, object value)
	{
		imethod_0((T)key, (U)value);
	}

	void IDictionary.Clear()
	{
		imethod_1();
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
		imethod_9((T)key);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		smethod_4(class41_0, array, index);
	}

	internal static string smethod_0(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	internal static ArgumentException smethod_1(string string_0)
	{
		return new ArgumentException(string_0);
	}

	internal static bool smethod_2(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	internal static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static void smethod_4(ICollection icollection_0, Array array_0, int int_0)
	{
		icollection_0.CopyTo(array_0, int_0);
	}

	internal static int smethod_5(ICollection icollection_0)
	{
		return icollection_0.Count;
	}

	internal static bool smethod_6(ICollection icollection_0)
	{
		return icollection_0.IsSynchronized;
	}

	internal static object smethod_7(ICollection icollection_0)
	{
		return icollection_0.SyncRoot;
	}
}
