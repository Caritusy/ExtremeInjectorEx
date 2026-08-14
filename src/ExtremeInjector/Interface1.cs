using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

internal interface Interface1<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IEnumerable, IOrderedDictionary, IDictionary, ICollection
{
	new U this[int int_0] { get; set; }

	new U this[T key] { get; set; }

	int Int32_0 { get; }

	ICollection<T> Prop_0 { get; }

	ICollection<U> Prop_1 { get; }

	bool Boolean_0 { get; }

	void imethod_0(T key, U value);

	void IDictionary<T, U>.Add(T key, U value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in imethod_0
		this.imethod_0(key, value);
	}

	void imethod_1();

	void ICollection<KeyValuePair<T, U>>.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in imethod_1
		this.imethod_1();
	}

	void IDictionary.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in imethod_1
		this.imethod_1();
	}

	void imethod_2(int int_0, T gparam_0, U gparam_1);

	int imethod_3(T gparam_0);

	bool imethod_4(U gparam_0);

	bool imethod_5(U gparam_0, IEqualityComparer<U> iequalityComparer_0);

	bool imethod_6(T key);

	bool IDictionary<T, U>.ContainsKey(T key)
	{
		//ILSpy generated this explicit interface implementation from .override directive in imethod_6
		return this.imethod_6(key);
	}

	KeyValuePair<T, U> imethod_7(int int_0);

	IEnumerator<KeyValuePair<T, U>> imethod_8();

	IEnumerator<KeyValuePair<T, U>> IEnumerable<KeyValuePair<T, U>>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in imethod_8
		return this.imethod_8();
	}

	bool imethod_9(T key);

	bool IDictionary<T, U>.Remove(T key)
	{
		//ILSpy generated this explicit interface implementation from .override directive in imethod_9
		return this.imethod_9(key);
	}

	void imethod_10(int index);

	void IOrderedDictionary.RemoveAt(int index)
	{
		//ILSpy generated this explicit interface implementation from .override directive in imethod_10
		this.imethod_10(index);
	}

	bool imethod_11(T key, out U value);

	bool IDictionary<T, U>.TryGetValue(T key, out U value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in imethod_11
		return this.imethod_11(key, out value);
	}
}
