using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

public interface Interface1<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IEnumerable, IOrderedDictionary, IDictionary, ICollection
{
	new U this[int int_0] { get; set; }

	new U this[T key] { get; set; }

	int Int32_0 { get; }

	ICollection<T> Prop_0 { get; }

	ICollection<U> Prop_1 { get; }

	bool Boolean_0 { get; }

	new void Add(T key, U value);

	void IDictionary<T, U>.Add(T key, U value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Add
		this.Add(key, value);
	}

	new void Clear();

	void ICollection<KeyValuePair<T, U>>.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clear
		this.Clear();
	}

	void IDictionary.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clear
		this.Clear();
	}

	void imethod_2(int int_0, T gparam_0, U gparam_1);

	int imethod_3(T gparam_0);

	bool imethod_4(U gparam_0);

	bool imethod_5(U gparam_0, IEqualityComparer<U> iequalityComparer_0);

	new bool ContainsKey(T key);

	bool IDictionary<T, U>.ContainsKey(T key)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ContainsKey
		return this.ContainsKey(key);
	}

	KeyValuePair<T, U> imethod_7(int int_0);

	new IEnumerator<KeyValuePair<T, U>> GetEnumerator();

	IEnumerator<KeyValuePair<T, U>> IEnumerable<KeyValuePair<T, U>>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
		return this.GetEnumerator();
	}

	new bool Remove(T key);

	bool IDictionary<T, U>.Remove(T key)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Remove
		return this.Remove(key);
	}

	new void RemoveAt(int index);

	void IOrderedDictionary.RemoveAt(int index)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RemoveAt
		this.RemoveAt(index);
	}

	new bool TryGetValue(T key, out U value);

	bool IDictionary<T, U>.TryGetValue(T key, out U value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TryGetValue
		return this.TryGetValue(key, out value);
	}
}
