using System;
using System.Collections.Generic;

internal sealed class Class44<T> : Comparer<T>
{
	private readonly Comparison<T> comparison_0;

	public Class44(Comparison<T> comparison_1)
	{
		if (comparison_1 == null)
		{
			throw Class44<T>._200D_202D_202B_206C_206E_206D_200D_200D_206D_200F_200D_202C_206C_202A_202A_200B_206F_206A_200F_200B_206C_200E_200C_206F_206C_200C_202C_202E_206B_202B_202A_206E_200C_202E_206D_206F_202E_202B_200C_202E_202E(Class178.smethod_0(4439));
		}
		comparison_0 = comparison_1;
	}

	int Comparer<T>.Compare(T gparam_0, T gparam_1)
	{
		return comparison_0(gparam_0, gparam_1);
	}
}
