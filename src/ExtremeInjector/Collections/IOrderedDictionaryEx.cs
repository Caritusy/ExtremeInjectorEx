using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

public interface IOrderedDictionaryEx<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IEnumerable, IOrderedDictionary, IDictionary, ICollection
{
	new U this[int intValue] { get; set; }

	new U this[T key] { get; set; }

	new int Count { get; }

	new ICollection<T> Keys { get; }

	new ICollection<U> Values { get; }

	new bool IsReadOnly { get; }

	new void Add(T key, U value);

	new void Clear();

	void Insert(int intValue, T value, U value2);

	int IndexOfKey(T value);

	bool ContainsValue(U value);

	bool ContainsValue(U value, IEqualityComparer<U> equalityComparer);

	new bool ContainsKey(T key);

	KeyValuePair<T, U> GetItemAt(int intValue);

	new IEnumerator<KeyValuePair<T, U>> GetEnumerator();

	new bool Remove(T key);

	new void RemoveAt(int index);

	new bool TryGetValue(T key, out U value);
}
