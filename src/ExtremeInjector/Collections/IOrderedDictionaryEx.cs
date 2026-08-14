using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

public interface IOrderedDictionaryEx<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IEnumerable, IOrderedDictionary, IDictionary, ICollection
{
	new U this[int int_0] { get; set; }

	new U this[T key] { get; set; }

	int Int32_0 { get; }

	ICollection<T> Prop_0 { get; }

	ICollection<U> Prop_1 { get; }

	bool Boolean_0 { get; }

	void imethod_0(T key, U value);

	void imethod_1();

	void imethod_2(int int_0, T gparam_0, U gparam_1);

	int imethod_3(T gparam_0);

	bool imethod_4(U gparam_0);

	bool imethod_5(U gparam_0, IEqualityComparer<U> iequalityComparer_0);

	bool imethod_6(T key);

	KeyValuePair<T, U> imethod_7(int int_0);

	IEnumerator<KeyValuePair<T, U>> imethod_8();

	bool imethod_9(T key);

	void imethod_10(int index);

	bool imethod_11(T key, out U value);
}
