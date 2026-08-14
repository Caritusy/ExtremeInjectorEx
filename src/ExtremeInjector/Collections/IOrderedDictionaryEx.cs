using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

public interface IOrderedDictionaryEx<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IEnumerable, IOrderedDictionary, IDictionary, ICollection
{
	new U this[int intValue] { get; set; }

	new U this[T key] { get; set; }

	int Count { get; }

	ICollection<T> Keys { get; }

	ICollection<U> Values { get; }

	bool IsReadOnly { get; }

	void Add(T key, U value);

	void Clear();

	void Insert(int intValue, T value, U value2);

	int IndexOfKey(T value);

	bool ContainsValue(U value);

	bool ContainsValue(U value, IEqualityComparer<U> equalityComparer);

	bool ContainsKey(T key);

	KeyValuePair<T, U> GetItemAt(int intValue);

	IEnumerator<KeyValuePair<T, U>> GetEnumerator();

	bool Remove(T key);

	void RemoveAt(int index);

	bool TryGetValue(T key, out U value);
}
