using System;
using System.Collections;
using System.Collections.Generic;

public sealed class Class45<T, U> : IEnumerator, IDictionaryEnumerator, IDisposable
{
	private readonly IEnumerator<KeyValuePair<T, U>> ienumerator_0;

	public DictionaryEntry Property0021
	{
		get
		{
			KeyValuePair<T, U> current = ienumerator_0.Current;
			return new DictionaryEntry(current.Key, current.Value);
		}
	}

	public object Property0022 => ienumerator_0.Current.Key;

	public object Property0023 => ienumerator_0.Current.Value;

	public object Property0024 => this.System_002ECollections_002EIDictionaryEnumerator_002Eget_Entry();

	public void Dispose()
	{
		Class45<T, U>._206F_206A_202B_206A_202B_200B_200B_206C_206D_206F_202B_202C_206E_206F_202B_202C_206C_206C_202C_200B_206C_202C_202E_200B_202D_200F_200D_200F_206D_200C_200C_202E_202B_200D_206A_206F_206A_200C_200E_206D_202E((IDisposable)ienumerator_0);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	public Class45(IEnumerable<KeyValuePair<T, U>> ienumerable_0)
	{
		ienumerator_0 = ienumerable_0.GetEnumerator();
	}

	public void Reset()
	{
		Class45<T, U>._200E_206F_206C_202B_200F_206D_202B_206A_202A_202D_200D_200F_200F_200C_206A_200E_200F_200C_202C_200B_206A_200E_200F_200F_206A_202C_202B_202A_202E_206F_202E_202A_202B_200B_202B_202E_200B_202B_202A_200E_202E((IEnumerator)ienumerator_0);
	}

	void IEnumerator.Reset()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Reset
		this.Reset();
	}

	public bool MoveNext()
	{
		return Class45<T, U>._206C_200C_206F_202D_202B_200B_202B_202C_200E_202E_202E_200D_206C_202A_200B_202E_206F_206E_206D_206F_200B_206D_202A_200C_206F_200B_202C_200B_200E_202B_202D_202A_206C_202B_202C_202B_200F_206B_206D_200E_202E((IEnumerator)ienumerator_0);
	}

	bool IEnumerator.MoveNext()
	{
		//ILSpy generated this explicit interface implementation from .override directive in MoveNext
		return this.MoveNext();
	}
}
