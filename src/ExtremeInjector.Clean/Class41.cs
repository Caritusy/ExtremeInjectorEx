using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

public sealed class Class41<T, U> : KeyedCollection<T, U>
{
	[CompilerGenerated]
	public sealed class Class42
	{
		public IComparer<T> icomparer_0;

		public Class41<T, U> class41_0;

		internal int method_0(U gparam_0, U gparam_1)
		{
			return icomparer_0.Compare(class41_0.GetKeyForItem(gparam_0), class41_0.GetKeyForItem(gparam_1));
		}
	}

	[CompilerGenerated]
	public sealed class Class43
	{
		public Comparison<T> comparison_0;

		public Class41<T, U> class41_0;

		internal int method_0(U gparam_0, U gparam_1)
		{
			return comparison_0(class41_0.GetKeyForItem(gparam_0), class41_0.GetKeyForItem(gparam_1));
		}
	}

	internal const string string_0 = "Delegate passed cannot be null";

	internal readonly Func<U, T> func_0;

	public Class41(Func<U, T> func_1)
	{
		while (true)
		{
			int num = -126874242;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2004383140)) % 5)
				{
				case 3u:
					num = ((func_1 == null) ? 713054124 : 734701266) ^ (int)(num2 * 65584307);
					continue;
				case 1u:
					func_0 = func_1;
					num = -1716428505;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					throw smethod_0("Delegate passed cannot be null");
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public Class41(Func<U, T> func_1, IEqualityComparer<T> iequalityComparer_0)
		: base(iequalityComparer_0)
	{
		if (func_1 == null)
		{
			throw smethod_0("Delegate passed cannot be null");
		}
		func_0 = func_1;
	}

	protected override T GetKeyForItem(U item)
	{
		return func_0(item);
	}

	public void method_0()
	{
		Comparer<T> icomparer_ = Comparer<T>.Default;
		method_1(icomparer_);
	}

	public void method_1(IComparer<T> icomparer_0)
	{
		Class44<U> icomparer_1 = new Class44<U>((U gparam_0, U gparam_1) => icomparer_0.Compare(GetKeyForItem(gparam_0), GetKeyForItem(gparam_1)));
		while (true)
		{
			int num = -1976439927;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -996877530)) % 3)
				{
				case 1u:
					goto IL_0026;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0026:
				method_5(icomparer_1);
				num = ((int)num2 * -39520486) ^ 0x43D05C02;
			}
		}
	}

	public void method_2(Comparison<T> comparison_0)
	{
		Class44<U> icomparer_ = new Class44<U>((U gparam_0, U gparam_1) => comparison_0(GetKeyForItem(gparam_0), GetKeyForItem(gparam_1)));
		while (true)
		{
			int num = 635973468;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x32882B7F)) % 3)
				{
				case 2u:
					goto IL_0026;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0026:
				method_5(icomparer_);
				num = (int)(num2 * 1166292602) ^ -187062113;
			}
		}
	}

	public void method_3()
	{
		Comparer<U> icomparer_ = Comparer<U>.Default;
		method_5(icomparer_);
	}

	public void method_4(Comparison<U> comparison_0)
	{
		Class44<U> icomparer_ = new Class44<U>(comparison_0);
		while (true)
		{
			int num = -1714163073;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1678821669)) % 3)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				method_5(icomparer_);
				num = ((int)num2 * -373036248) ^ -133428155;
			}
		}
	}

	public void method_5(IComparer<U> icomparer_0)
	{
		List<U> list = base.Items as List<U>;
		while (true)
		{
			int num = 931145369;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x30DE67E)) % 4)
				{
				case 3u:
					num = ((list != null) ? (-1819889566) : (-313842527)) ^ (int)(num2 * 1055052206);
					continue;
				case 2u:
					list.Sort(icomparer_0);
					num = (int)(num2 * 600933619) ^ -1278440743;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	internal static ArgumentNullException smethod_0(string string_1)
	{
		return new ArgumentNullException(string_1);
	}
}
