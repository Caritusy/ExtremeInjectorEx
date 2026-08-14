using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

public interface IOrderedDictionaryEx<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IEnumerable, IOrderedDictionary, IDictionary, ICollection
{
	new U this[int int_0] { get; set; }

	new U this[T key] { get; set; }

	int Count { get; }

	ICollection<T> Keys { get; }

	ICollection<U> Values { get; }

	bool IsReadOnly { get; }

	void Add(T key, U value);

	void Clear();

	void Insert(int int_0, T gparam_0, U gparam_1);

	int IndexOfKey(T gparam_0);

	bool ContainsValue(U gparam_0);

	bool ContainsValue(U gparam_0, IEqualityComparer<U> iequalityComparer_0);

	bool ContainsKey(T key);

	KeyValuePair<T, U> GetItemAt(int int_0);

	IEnumerator<KeyValuePair<T, U>> GetEnumerator();

	bool Remove(T key);

	void RemoveAt(int index);

	bool TryGetValue(T key, out U value);
}
