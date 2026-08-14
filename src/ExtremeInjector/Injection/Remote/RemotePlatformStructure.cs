using System;
using System.Collections.Generic;

public abstract class RemotePlatformStructure : RemoteStructure
{
	public sealed class RemoteFieldLayout
	{
		public int int_0;

		public bool bool_0;

		internal RemoteFieldLayout()
		{
		}
	}

	internal static Dictionary<Type, int[]> dictionary_0 = new Dictionary<Type, int[]>();

	internal static Dictionary<Type, int[]> dictionary_1;

	internal int[] int_1;

	internal bool bool_1;

	protected RemotePlatformStructure(int int_2, bool bool_2)
		: base(int_2)
	{
		this.bool_1 = bool_2;
		this.int_1 = (bool_2 ? RemotePlatformStructure.dictionary_0[base.GetType()] : RemotePlatformStructure.dictionary_1[base.GetType()]);
	}

	protected RemotePlatformStructure(IntPtr intptr_2, bool bool_2)
		: base(intptr_2)
	{
		bool_1 = bool_2;
		int_1 = (bool_2 ? dictionary_0[GetType()] : dictionary_1[GetType()]);
	}

	protected static void Register32BitLayout<T>(RemoteFieldLayout[] class168_0)
	{
		RegisterLayout<T>(bool_2: true, class168_0);
	}

	protected static void Register64BitLayout<T>(RemoteFieldLayout[] class168_0)
	{
		RegisterLayout<T>(bool_2: false, class168_0);
	}

	internal static void RegisterLayout<T>(bool bool_2, IList<RemoteFieldLayout> ilist_0)
	{
		int[] array = new int[ilist_0.Count + 1];
		int num = 0;
		for (int i = 0; i < ilist_0.Count + 1; i++)
		{
			if (i < ilist_0.Count && !ilist_0[i].bool_0)
			{
				int num2 = ilist_0[i].int_0;
				int num3 = bool_2 ? 4 : 8;
				if (num2 > num3)
				{
					num2 = num3;
				}
				int num4 = -num & num2 - 1;
				if (num4 > 0)
				{
					num += num4;
				}
			}
			array[i] = num;
			if (i < ilist_0.Count)
			{
				num += ilist_0[i].int_0;
			}
		}
		Dictionary<Type, int[]> dictionary = bool_2 ? RemotePlatformStructure.dictionary_0 : RemotePlatformStructure.dictionary_1;
		if (!dictionary.ContainsKey(typeof(T)))
		{
			dictionary.Add(typeof(T), array);
			return;
		}
		dictionary[typeof(T)] = array;
	}

	protected internal T ReadField<T>(int int_2)
	{
		int num = this.int_1[int_2];
		if (!this.bool_1 || typeof(T) != typeof(IntPtr))
		{
			return base.ReadFieldAtOffset<T>(num);
		}
		return (T)((object)((IntPtr)base.ReadFieldAtOffset<int>(num)));
	}

	protected void WriteField<T>(int int_2, T gparam_0)
	{
		int num = this.int_1[int_2];
		if (this.bool_1 && typeof(T) == typeof(IntPtr))
		{
			base.WriteFieldAtOffset<int>((int)((IntPtr)((object)gparam_0)), num);
			return;
		}
		base.WriteFieldAtOffset<T>(gparam_0, num);
	}

	static RemotePlatformStructure()
	{
		// Note: this type is marked as 'beforefieldinit'.
	}
}
