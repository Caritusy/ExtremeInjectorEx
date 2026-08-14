using System;
using System.Collections;
using System.Collections.Generic;

internal sealed class Class45<T, U> : IEnumerator, IDictionaryEnumerator, IDisposable
{
	private readonly IEnumerator<KeyValuePair<T, U>> ienumerator_0;

	DictionaryEntry IDictionaryEnumerator.Entry
	{
		get
		{
			KeyValuePair<T, U> current = ienumerator_0.Current;
			return new DictionaryEntry(current.Key, current.Value);
		}
	}

	object IDictionaryEnumerator.Key => ienumerator_0.Current.Key;

	object IDictionaryEnumerator.Value => ienumerator_0.Current.Value;

	object IEnumerator.Current => ((IDictionaryEnumerator)this).Entry;

	void IDisposable.Dispose()
	{
		Class45<T, U>._206F_206A_202B_206A_202B_200B_200B_206C_206D_206F_202B_202C_206E_206F_202B_202C_206C_206C_202C_200B_206C_202C_202E_200B_202D_200F_200D_200F_206D_200C_200C_202E_202B_200D_206A_206F_206A_200C_200E_206D_202E((IDisposable)ienumerator_0);
	}

	public Class45(IEnumerable<KeyValuePair<T, U>> ienumerable_0)
	{
		ienumerator_0 = ienumerable_0.GetEnumerator();
	}

	void IEnumerator.Reset()
	{
		Class45<T, U>._200E_206F_206C_202B_200F_206D_202B_206A_202A_202D_200D_200F_200F_200C_206A_200E_200F_200C_202C_200B_206A_200E_200F_200F_206A_202C_202B_202A_202E_206F_202E_202A_202B_200B_202B_202E_200B_202B_202A_200E_202E((IEnumerator)ienumerator_0);
	}

	bool IEnumerator.MoveNext()
	{
		return Class45<T, U>._206C_200C_206F_202D_202B_200B_202B_202C_200E_202E_202E_200D_206C_202A_200B_202E_206F_206E_206D_206F_200B_206D_202A_200C_206F_200B_202C_200B_200E_202B_202D_202A_206C_202B_202C_202B_200F_206B_206D_200E_202E((IEnumerator)ienumerator_0);
	}
}
