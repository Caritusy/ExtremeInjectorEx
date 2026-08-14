using System;
using System.Collections.Generic;

public abstract class RemotePlatformStructure : RemoteStructure
{
	public sealed class RemoteFieldLayout
	{
		public int intValue;

		public bool flag;

		internal RemoteFieldLayout()
		{
		}
	}

	internal static Dictionary<Type, int[]> dictionary = new Dictionary<Type, int[]>();

	internal static Dictionary<Type, int[]> dictionary2 = new Dictionary<Type, int[]>();

	internal int[] intValueArray;

	internal bool flag;

	protected RemotePlatformStructure(int intValue, bool flag2)
		: base(intValue)
	{
		this.flag = flag2;
		this.intValueArray = (flag2 ? RemotePlatformStructure.dictionary[base.GetType()] : RemotePlatformStructure.dictionary2[base.GetType()]);
	}

	protected RemotePlatformStructure(IntPtr address, bool flag2)
		: base(address)
	{
		flag = flag2;
		intValueArray = (flag2 ? dictionary[GetType()] : dictionary2[GetType()]);
	}

	protected static void Register32BitLayout<T>(RemoteFieldLayout[] remoteFieldLayoutArray)
	{
		RegisterLayout<T>(flag2: true, remoteFieldLayoutArray);
	}

	protected static void Register64BitLayout<T>(RemoteFieldLayout[] remoteFieldLayoutArray)
	{
		RegisterLayout<T>(flag2: false, remoteFieldLayoutArray);
	}

	internal static void RegisterLayout<T>(bool flag2, IList<RemoteFieldLayout> items)
	{
		int[] array = new int[items.Count + 1];
		int num = 0;
		for (int i = 0; i < items.Count + 1; i++)
		{
			if (i < items.Count && !items[i].flag)
			{
				int num2 = items[i].intValue;
				int num3 = flag2 ? 4 : 8;
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
			if (i < items.Count)
			{
				num += items[i].intValue;
			}
		}
		Dictionary<Type, int[]> dictionary = flag2 ? RemotePlatformStructure.dictionary : RemotePlatformStructure.dictionary2;
		if (!dictionary.ContainsKey(typeof(T)))
		{
			dictionary.Add(typeof(T), array);
			return;
		}
		dictionary[typeof(T)] = array;
	}

	protected internal T ReadField<T>(int intValue)
	{
		int num = this.intValueArray[intValue];
		if (!this.flag || typeof(T) != typeof(IntPtr))
		{
			return base.ReadFieldAtOffset<T>(num);
		}
		return (T)((object)((IntPtr)base.ReadFieldAtOffset<int>(num)));
	}

	protected void WriteField<T>(int intValue, T value)
	{
		int num = this.intValueArray[intValue];
		if (this.flag && typeof(T) == typeof(IntPtr))
		{
			base.WriteFieldAtOffset<int>((int)((IntPtr)((object)value)), num);
			return;
		}
		base.WriteFieldAtOffset<T>(value, num);
	}

	static RemotePlatformStructure()
	{
		// Note: this type is marked as 'beforefieldinit'.
	}
}
