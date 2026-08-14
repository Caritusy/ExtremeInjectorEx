using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;

public sealed class GClass0<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, Interface1<T, U>, IEnumerable, IOrderedDictionary, IDictionary, ICollection
{
	[Serializable]
	[CompilerGenerated]
	public sealed class Class38
	{
		public static readonly Class38 field_0149;

		public static Func<KeyValuePair<T, U>, T> field_014A;

		public static Func<KeyValuePair<T, U>, U> field_014B;

		public static Func<KeyValuePair<T, U>, T> field_014C;

		public static Func<KeyValuePair<T, U>, T> field_014D;

		static Class38()
		{
			Class38._003C_003E9 = new Class38();
		}

		internal T method_0(KeyValuePair<T, U> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		internal U method_1(KeyValuePair<T, U> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		internal T method_2(KeyValuePair<T, U> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		internal T method_3(KeyValuePair<T, U> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}
	}

	[CompilerGenerated]
	public sealed class Class39
	{
		public IComparer<U> icomparer_0;

		internal int method_0(KeyValuePair<T, U> keyValuePair_0, KeyValuePair<T, U> keyValuePair_1)
		{
			return icomparer_0.Compare(keyValuePair_0.Value, keyValuePair_1.Value);
		}
	}

	[CompilerGenerated]
	public sealed class Class40
	{
		public Comparison<U> comparison_0;

		internal int method_0(KeyValuePair<T, U> keyValuePair_0, KeyValuePair<T, U> keyValuePair_1)
		{
			return comparison_0(keyValuePair_0.Value, keyValuePair_1.Value);
		}
	}

	private Class41<T, KeyValuePair<T, U>> class41_0;

	[CompilerGenerated]
	private IEqualityComparer<T> iequalityComparer_0;

	public U this[int int_0]
	{
		get
		{
			if (int_0 >= 0)
			{
				KeyValuePair<T, U> keyValuePair = default(KeyValuePair<T, U>);
				while (true)
				{
					int num = -1903626567;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -569182065)) % 5)
						{
						case 3u:
							keyValuePair = class41_0[int_0];
							num = -1146259231;
							continue;
						case 2u:
						{
							int num3;
							int num4;
							if (int_0 < class41_0.Count)
							{
								num3 = 1584990902;
								num4 = 1584990902;
							}
							else
							{
								num3 = 1320491480;
								num4 = 1320491480;
							}
							num = num3 ^ (int)(num2 * 1070056468);
							continue;
						}
						case 4u:
							break;
						case 1u:
							goto end_IL_006c;
						default:
							return keyValuePair.Value;
						}
						break;
					}
					continue;
					end_IL_006c:
					break;
				}
			}
			throw GClass0<T, U>._206D_206E_200E_200E_202B_206C_206E_202D_202E_202B_200F_202E_202A_200D_206F_200E_200C_202C_206D_200E_200C_206C_200F_206B_202C_206E_206B_206D_200C_202B_206E_202B_202E_202C_206C_206A_206C_206C_200D_206D_202E(GClass0<T, U>._202C_206D_200F_200F_202D_202C_200B_206B_200E_200F_206B_202A_200F_206B_200B_200E_200B_206B_202A_202D_206F_202E_200B_206C_206F_206B_206E_206C_202A_202A_202A_202B_206B_200C_206D_202E_202D_202B_202E_200F_202E(Class178.smethod_0(4179), (object)int_0));
		}
		set
		{
			if (int_0 >= 0)
			{
				KeyValuePair<T, U> value2 = default(KeyValuePair<T, U>);
				while (true)
				{
					int num = -185787422;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1196772839)) % 6)
						{
						case 4u:
							class41_0[int_0] = value2;
							num = (int)((num2 * 1966283937) ^ 0x4E0CEE0C);
							continue;
						case 3u:
						{
							int num3;
							int num4;
							if (int_0 >= class41_0.Count)
							{
								num3 = 2084389224;
								num4 = 2084389224;
							}
							else
							{
								num3 = 468629021;
								num4 = 468629021;
							}
							num = num3 ^ (int)(num2 * 585343483);
							continue;
						}
						case 1u:
							value2 = new KeyValuePair<T, U>(class41_0[int_0].Key, value);
							num = -228068843;
							continue;
						default:
							return;
						case 0u:
							break;
						case 2u:
							goto end_IL_00a1;
						case 5u:
							return;
						}
						break;
					}
					continue;
					end_IL_00a1:
					break;
				}
			}
			throw GClass0<T, U>._206D_206E_200E_200E_202B_206C_206E_202D_202E_202B_200F_202E_202A_200D_206F_200E_200C_202C_206D_200E_200C_206C_200F_206B_202C_206E_206B_206D_200C_202B_206E_202B_202E_202C_206C_206A_206C_206C_200D_206D_202E(GClass0<T, U>._202C_206D_200F_200F_202D_202C_200B_206B_200E_200F_206B_202A_200F_206B_200B_200E_200B_206B_202A_202D_206F_202E_200B_206C_206F_206B_206E_206C_202A_202A_202A_202B_206B_200C_206D_202E_202D_202B_202E_200F_202E(Class178.smethod_0(4179), (object)int_0));
		}
	}

	public U this[T key]
	{
		get
		{
			if (!class41_0.Contains(key))
			{
				throw GClass0<T, U>._206D_206E_200E_200E_202B_206C_206E_202D_202E_202B_200F_202E_202A_200D_206F_200E_200C_202C_206D_200E_200C_206C_200F_206B_202C_206E_206B_206D_200C_202B_206E_202B_202E_202C_206C_206A_206C_206C_200D_206D_202E(GClass0<T, U>._202C_206D_200F_200F_202D_202C_200B_206B_200E_200F_206B_202A_200F_206B_200B_200E_200B_206B_202A_202D_206F_202E_200B_206C_206F_206B_206E_206C_202A_202A_202A_202B_206B_200C_206D_202E_202D_202B_202E_200F_202E(Class178.smethod_0(4252), (object)key));
			}
			return class41_0[key].Value;
		}
		set
		{
			KeyValuePair<T, U> keyValuePair = new KeyValuePair<T, U>(key, value);
			int num = imethod_3(key);
			while (true)
			{
				int num2 = 856213008;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x480AD231)) % 6)
					{
					case 5u:
						class41_0[num] = keyValuePair;
						num2 = (int)((num3 * 1480371522) ^ 0x7220DF17);
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (num > -1)
						{
							num4 = -691802909;
							num5 = -691802909;
						}
						else
						{
							num4 = -1152417044;
							num5 = -1152417044;
						}
						num2 = num4 ^ (int)(num3 * 825531771);
						continue;
					}
					case 0u:
						class41_0.Add(keyValuePair);
						num2 = 1257289523;
						continue;
					default:
						return;
					case 3u:
						break;
					case 2u:
						return;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	public int Int32_0 => class41_0.Count;

	public ICollection<T> Prop_0 => class41_0.Select(Class38._003C_003E9__10_0 ?? (Class38._003C_003E9__10_0 = (KeyValuePair<T, U> keyValuePair_0) => keyValuePair_0.Key)).ToList();

	public ICollection<U> Prop_1 => class41_0.Select(Class38._003C_003E9__12_0 ?? (Class38._003C_003E9__12_0 = (KeyValuePair<T, U> keyValuePair_0) => keyValuePair_0.Value)).ToList();

	public IEqualityComparer<T> IEqualityComparer_0
	{
		[CompilerGenerated]
		get
		{
			return iequalityComparer_0;
		}
		[CompilerGenerated]
		private set
		{
			iequalityComparer_0 = value;
		}
	}

	public bool Boolean_0 => false;

	private ICollection<T> Property0013 => Prop_0;

	private ICollection<U> Property0014 => Prop_1;

	// C# has no syntax for parameterized property 'Property0015'.
	private U get_Item_014B(T key)
	{
		return this[key];
	}

	U IDictionary<T, U>.get_Item(T key)
	{
		//ILSpy generated this explicit interface implementation from .override directive in get_Item_014B
		return this.get_Item_014B(key);
	}

	private void set_Item_014C(T key, U value)
	{
		this[key] = value;
	}

	void IDictionary<T, U>.set_Item(T key, U value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in set_Item_014C
		this.set_Item_014C(key, value);
	}

	private int Property0016 => class41_0.Count;

	private bool Property0017 => false;

	// C# has no syntax for parameterized property 'Property0018'.
	private object get_Item_0159(int index)
	{
		return this[index];
	}

	object IOrderedDictionary.get_Item(int index)
	{
		//ILSpy generated this explicit interface implementation from .override directive in get_Item_0159
		return this.get_Item_0159(index);
	}

	private void set_Item(int index, object value)
	{
		this[index] = (U)value;
	}

	void IOrderedDictionary.set_Item(int index, object value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in set_Item
		this.set_Item(index, value);
	}

	private bool Property0019 => false;

	private bool Property001A => false;

	private ICollection Property001B => (ICollection)Prop_0;

	private ICollection Property001C => (ICollection)Prop_1;

	// C# has no syntax for parameterized property 'Property001D'.
	private object get_Item(object key)
	{
		return this[(T)key];
	}

	object IDictionary.get_Item(object key)
	{
		//ILSpy generated this explicit interface implementation from .override directive in get_Item
		return this.get_Item(key);
	}

	private void set_Item(object key, object value)
	{
		this[(T)key] = (U)value;
	}

	void IDictionary.set_Item(object key, object value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in set_Item
		this.set_Item(key, value);
	}

	private int Property001E => GClass0<T, U>._200B_202E_206D_200D_202E_206D_206F_200F_202A_200F_200F_202A_200B_202C_200E_200D_206C_200B_206C_200E_200E_202B_200F_202D_206F_200B_202C_202A_206B_200F_206C_206F_200F_206D_200D_206D_202C_206B_206A_206C_202E((ICollection)class41_0);

	private bool Property001F => GClass0<T, U>._206B_200F_200D_200F_202C_200E_200E_206D_202D_202B_206B_206B_206A_200D_200E_206B_202D_202D_202D_206D_202D_200B_206F_202E_200D_200C_206D_200E_206A_202B_206F_202C_206C_206D_200D_200B_206B_200F_200F_202E_202E((ICollection)class41_0);

	private object Property0020 => GClass0<T, U>._206A_206D_206B_206E_200F_202E_202B_202B_200C_206C_206A_206A_206E_202B_200B_200E_200B_206A_206B_206C_206D_200E_206D_206B_202C_206F_200D_200E_206E_202C_206F_202B_200C_202B_200E_202D_202C_202B_206D_206A_202E((ICollection)class41_0);

	public GClass0()
	{
		method_0(null);
	}

	public GClass0(IEqualityComparer<T> iequalityComparer_1)
	{
		method_0(iequalityComparer_1);
	}

	public GClass0(Interface1<T, U> interface1_0)
	{
		while (true)
		{
			int num = -1677717654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1074880585)) % 3)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					IEnumerator<KeyValuePair<T, U>> enumerator = interface1_0.imethod_8();
					try
					{
						while (GClass0<T, U>._206C_206B_206D_202A_206D_202B_200E_202E_202B_206B_206E_202D_206C_206A_206A_200F_206C_206E_202A_206E_200D_202D_206B_202D_202C_200C_202D_200E_200C_200C_206A_206F_202D_200C_200D_206A_202D_200B_206A_206E_202E((IEnumerator)enumerator))
						{
							KeyValuePair<T, U> current = enumerator.Current;
							class41_0.Add(current);
						}
						return;
					}
					finally
					{
						if (enumerator != null)
						{
							GClass0<T, U>._202D_206A_206B_200F_206F_200C_206A_200D_202C_206C_202C_206E_200B_206A_202E_202D_202C_202B_202D_206A_206D_202E_200C_206F_200C_206D_206D_206E_206D_202A_202E_200B_206B_202C_202C_200F_200D_200D_202D_200C_202E((IDisposable)enumerator);
						}
					}
				}
				}
				break;
				IL_0008:
				method_0(null);
				num = ((int)num2 * -307350283) ^ 0x3302A9F7;
			}
		}
	}

	public GClass0(Interface1<T, U> interface1_0, IEqualityComparer<T> iequalityComparer_1)
	{
		method_0(iequalityComparer_1);
		IEnumerator<KeyValuePair<T, U>> enumerator = interface1_0.imethod_8();
		try
		{
			while (GClass0<T, U>._206C_206B_206D_202A_206D_202B_200E_202E_202B_206B_206E_202D_206C_206A_206A_200F_206C_206E_202A_206E_200D_202D_206B_202D_202C_200C_202D_200E_200C_200C_206A_206F_202D_200C_200D_206A_202D_200B_206A_206E_202E((IEnumerator)enumerator))
			{
				KeyValuePair<T, U> current = enumerator.Current;
				class41_0.Add(current);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				GClass0<T, U>._202D_206A_206B_200F_206F_200C_206A_200D_202C_206C_202C_206E_200B_206A_202E_202D_202C_202B_202D_206A_206D_202E_200C_206F_200C_206D_206D_206E_206D_202A_202E_200B_206B_202C_202C_200F_200D_200D_202D_200C_202E((IDisposable)enumerator);
			}
		}
	}

	private void method_0(IEqualityComparer<T> iequalityComparer_1)
	{
		IEqualityComparer_0 = iequalityComparer_1;
		class41_0 = ((iequalityComparer_1 != null) ? new Class41<T, KeyValuePair<T, U>>(Class38._003C_003E9__21_0 ?? (Class38._003C_003E9__21_0 = (KeyValuePair<T, U> keyValuePair_0) => keyValuePair_0.Key), iequalityComparer_1) : new Class41<T, KeyValuePair<T, U>>(Class38._003C_003E9__21_1 ?? (Class38._003C_003E9__21_1 = (KeyValuePair<T, U> keyValuePair_0) => keyValuePair_0.Key)));
	}

	public void imethod_0(T key, U value)
	{
		class41_0.Add(new KeyValuePair<T, U>(key, value));
	}

	public void imethod_1()
	{
		class41_0.Clear();
	}

	public void imethod_2(int int_0, T gparam_0, U gparam_1)
	{
		class41_0.Insert(int_0, new KeyValuePair<T, U>(gparam_0, gparam_1));
	}

	public int imethod_3(T gparam_0)
	{
		if (class41_0.Contains(gparam_0))
		{
			return class41_0.IndexOf(class41_0[gparam_0]);
		}
		return -1;
	}

	public bool imethod_4(U gparam_0)
	{
		return Prop_1.Contains(gparam_0);
	}

	public bool imethod_5(U gparam_0, IEqualityComparer<U> iequalityComparer_1)
	{
		return Prop_1.Contains(gparam_0, iequalityComparer_1);
	}

	public bool imethod_6(T key)
	{
		return class41_0.Contains(key);
	}

	public KeyValuePair<T, U> imethod_7(int int_0)
	{
		if (int_0 >= 0)
		{
			while (true)
			{
				int num = 149602795;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x73E43D95)) % 4)
					{
					case 2u:
					{
						int num3;
						int num4;
						if (int_0 < class41_0.Count)
						{
							num3 = -1310218164;
							num4 = -1310218164;
						}
						else
						{
							num3 = -863561030;
							num4 = -863561030;
						}
						num = num3 ^ ((int)num2 * -1826660524);
						continue;
					}
					case 0u:
						break;
					case 3u:
						goto end_IL_0054;
					default:
						return class41_0[int_0];
					}
					break;
				}
				continue;
				end_IL_0054:
				break;
			}
		}
		throw GClass0<T, U>._206D_206E_200E_200E_202B_206C_206E_202D_202E_202B_200F_202E_202A_200D_206F_200E_200C_202C_206D_200E_200C_206C_200F_206B_202C_206E_206B_206D_200C_202B_206E_202B_202E_202C_206C_206A_206C_206C_200D_206D_202E(GClass0<T, U>._202C_206D_200F_200F_202D_202C_200B_206B_200E_200F_206B_202A_200F_206B_200B_200E_200B_206B_202A_202D_206F_202E_200B_206C_206F_206B_206E_206C_202A_202A_202A_202B_206B_200C_206D_202E_202D_202B_202E_200F_202E(Class178.smethod_0(4321), (object)int_0));
	}

	public IEnumerator<KeyValuePair<T, U>> imethod_8()
	{
		return class41_0.GetEnumerator();
	}

	public bool imethod_9(T key)
	{
		return class41_0.Remove(key);
	}

	public void imethod_10(int index)
	{
		if (index >= 0)
		{
			while (true)
			{
				int num = 1954811865;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x1A1F641B)) % 4)
					{
					case 2u:
					{
						int num3;
						int num4;
						if (index >= class41_0.Count)
						{
							num3 = 1978604860;
							num4 = 1978604860;
						}
						else
						{
							num3 = 915017582;
							num4 = 915017582;
						}
						num = num3 ^ (int)(num2 * 181349);
						continue;
					}
					case 0u:
						break;
					case 1u:
						goto end_IL_0054;
					default:
						class41_0.RemoveAt(index);
						return;
					}
					break;
				}
				continue;
				end_IL_0054:
				break;
			}
		}
		throw GClass0<T, U>._206D_206E_200E_200E_202B_206C_206E_202D_202E_202B_200F_202E_202A_200D_206F_200E_200C_202C_206D_200E_200C_206C_200F_206B_202C_206E_206B_206D_200C_202B_206E_202B_202E_202C_206C_206A_206C_206C_200D_206D_202E(GClass0<T, U>._202C_206D_200F_200F_202D_202C_200B_206B_200E_200F_206B_202A_200F_206B_200B_200E_200B_206B_202A_202D_206F_202E_200B_206C_206F_206B_206E_206C_202A_202A_202A_202B_206B_200C_206D_202E_202D_202B_202E_200F_202E(Class178.smethod_0(4321), (object)index));
	}

	public bool imethod_11(T key, out U value)
	{
		if (class41_0.Contains(key))
		{
			value = class41_0[key].Value;
			return true;
		}
		value = default(U);
		return false;
	}

	public void method_1()
	{
		class41_0.method_0();
	}

	public void method_2(IComparer<T> icomparer_0)
	{
		class41_0.method_1(icomparer_0);
	}

	public void method_3(Comparison<T> comparison_0)
	{
		class41_0.method_2(comparison_0);
	}

	public void method_4()
	{
		Comparer<U> icomparer_ = Comparer<U>.Default;
		while (true)
		{
			int num = 1957830221;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1AE74DEC)) % 3)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				method_5(icomparer_);
				num = (int)((num2 * 1369091714) ^ 0x20F68EA4);
			}
		}
	}

	public void method_5(IComparer<U> icomparer_0)
	{
		class41_0.method_4((KeyValuePair<T, U> keyValuePair_0, KeyValuePair<T, U> keyValuePair_1) => icomparer_0.Compare(keyValuePair_0.Value, keyValuePair_1.Value));
	}

	public void method_6(Comparison<U> comparison_0)
	{
		class41_0.method_4((KeyValuePair<T, U> keyValuePair_0, KeyValuePair<T, U> keyValuePair_1) => comparison_0(keyValuePair_0.Value, keyValuePair_1.Value));
	}

	private void Add(T key, U value)
	{
		imethod_0(key, value);
	}

	void IDictionary<T, U>.Add(T key, U value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Add
		this.Add(key, value);
	}

	private bool ContainsKey(T key)
	{
		return imethod_6(key);
	}

	bool IDictionary<T, U>.ContainsKey(T key)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ContainsKey
		return this.ContainsKey(key);
	}

	private bool Remove(T key)
	{
		return imethod_9(key);
	}

	bool IDictionary<T, U>.Remove(T key)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Remove
		return this.Remove(key);
	}

	private bool TryGetValue(T key, out U value)
	{
		return imethod_11(key, out value);
	}

	bool IDictionary<T, U>.TryGetValue(T key, out U value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TryGetValue
		return this.TryGetValue(key, out value);
	}

	private void Add(KeyValuePair<T, U> item)
	{
		class41_0.Add(item);
	}

	void ICollection<KeyValuePair<T, U>>.Add(KeyValuePair<T, U> item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Add
		this.Add(item);
	}

	private void Clear()
	{
		class41_0.Clear();
	}

	void ICollection<KeyValuePair<T, U>>.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clear
		this.Clear();
	}

	private bool Contains(KeyValuePair<T, U> item)
	{
		return class41_0.Contains(item);
	}

	bool ICollection<KeyValuePair<T, U>>.Contains(KeyValuePair<T, U> item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Contains
		return this.Contains(item);
	}

	private void CopyTo(KeyValuePair<T, U>[] array, int arrayIndex)
	{
		class41_0.CopyTo(array, arrayIndex);
	}

	void ICollection<KeyValuePair<T, U>>.CopyTo(KeyValuePair<T, U>[] array, int arrayIndex)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CopyTo
		this.CopyTo(array, arrayIndex);
	}

	private bool Remove(KeyValuePair<T, U> item)
	{
		return class41_0.Remove(item);
	}

	bool ICollection<KeyValuePair<T, U>>.Remove(KeyValuePair<T, U> item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Remove
		return this.Remove(item);
	}

	private IEnumerator<KeyValuePair<T, U>> GetEnumerator()
	{
		return imethod_8();
	}

	IEnumerator<KeyValuePair<T, U>> IEnumerable<KeyValuePair<T, U>>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
		return this.GetEnumerator();
	}

	private IEnumerator GetEnumerator_0155()
	{
		return imethod_8();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator_0155
		return this.GetEnumerator_0155();
	}

	private IDictionaryEnumerator GetEnumerator_0156()
	{
		return new Class45<T, U>(this);
	}

	IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator_0156
		return this.GetEnumerator_0156();
	}

	private void Insert(int index, object key, object value)
	{
		imethod_2(index, (T)key, (U)value);
	}

	void IOrderedDictionary.Insert(int index, object key, object value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		this.Insert(index, key, value);
	}

	private void RemoveAt(int index)
	{
		imethod_10(index);
	}

	void IOrderedDictionary.RemoveAt(int index)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RemoveAt
		this.RemoveAt(index);
	}

	private void Add(object key, object value)
	{
		imethod_0((T)key, (U)value);
	}

	void IDictionary.Add(object key, object value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Add
		this.Add(key, value);
	}

	private void Clear_015C()
	{
		imethod_1();
	}

	void IDictionary.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clear_015C
		this.Clear_015C();
	}

	private bool Contains(object key)
	{
		return class41_0.Contains((T)key);
	}

	bool IDictionary.Contains(object key)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Contains
		return this.Contains(key);
	}

	private IDictionaryEnumerator GetEnumerator_015E()
	{
		return new Class45<T, U>(this);
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator_015E
		return this.GetEnumerator_015E();
	}

	private void Remove(object key)
	{
		imethod_9((T)key);
	}

	void IDictionary.Remove(object key)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Remove
		this.Remove(key);
	}

	private void CopyTo(Array array, int index)
	{
		GClass0<T, U>._202C_202B_206C_202C_206D_206F_200C_200F_202B_206D_202A_206B_202E_202B_200F_200F_200F_206E_200C_200B_206A_206B_206B_202A_206F_202C_202A_206B_202D_200B_206A_200B_200C_202A_206B_202D_202A_206F_206E_200E_202E((ICollection)class41_0, array, index);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CopyTo
		this.CopyTo(array, index);
	}
}
