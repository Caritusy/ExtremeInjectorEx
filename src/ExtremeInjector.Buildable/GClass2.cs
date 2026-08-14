using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;

public sealed class GClass2
{
	public sealed class Class73 : WaitHandle
	{
		public Class73(IntPtr intptr_0)
		{
			base.SafeWaitHandle = new SafeWaitHandle(intptr_0, ownsHandle: true);
		}
	}

	[Serializable]
	[CompilerGenerated]
	public sealed class Class74
	{
		public static readonly Class74 field_051E = new Class74();

		public static Func<GClass1, bool> field_051F;

		public static Func<GClass1, bool> field_0520;

		internal bool method_0(GClass1 gclass1_0)
		{
			return gclass1_0.method_10();
		}

		internal bool method_1(GClass1 gclass1_0)
		{
			return Class171.smethod_109(gclass1_0);
		}
	}

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private IntPtr intptr_0;

	internal bool bool_2;

	internal bool bool_3 = true;

	internal bool bool_4;

	private List<Class82> list_0 = new List<Class82>();

	internal List<GClass1> list_1 = new List<GClass1>();

	internal Dictionary<GClass1, List<Class152>> dictionary_0 = new Dictionary<GClass1, List<Class152>>();

	internal GClass3 gclass3_0;

	internal static readonly bool bool_5 = Class171.GetProcAddress(Class171.GetModuleHandle(Class178.smethod_0(8503)), Class178.smethod_0(8520)) != IntPtr.Zero;

	[SpecialName]
	[CompilerGenerated]
	public int method_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(int int_1)
	{
		int_0 = int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_2()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(string string_2)
	{
		string_0 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_4()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_5(string string_2)
	{
		string_1 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_6()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_7(bool bool_6)
	{
		bool_0 = bool_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_8()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_9(bool bool_6)
	{
		bool_1 = bool_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_10()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_11(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	internal T method_12<T>(T gparam_0) where T : Class82
	{
		if (gparam_0.method_0() == Class171.GetCurrentProcessId())
		{
			goto IL_00c6;
		}
		goto IL_00fc;
		IL_00c6:
		int num = -1150288958;
		goto IL_00cb;
		IL_00cb:
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -715833404)) % 8)
			{
			case 7u:
				ThreadPool.RegisterWaitForSingleObject(new Class73(intPtr), method_13, null, -1, executeOnlyOnce: true);
				bool_4 = true;
				num = (int)(num2 * 1482154878) ^ -332174561;
				continue;
			case 4u:
			{
				int num5;
				int num6;
				if (!(intPtr != IntPtr.Zero))
				{
					num5 = -538959163;
					num6 = -538959163;
				}
				else
				{
					num5 = -105963693;
					num6 = -105963693;
				}
				num = num5 ^ (int)(num2 * 1935678654);
				continue;
			}
			case 3u:
				intPtr = Class171.smethod_244(this, Class124.Enum32.flag_11, false, method_0());
				num = (int)(num2 * 1428044550) ^ -1933279006;
				continue;
			case 2u:
			{
				int num3;
				int num4;
				if (bool_4)
				{
					num3 = -1240668609;
					num4 = -1240668609;
				}
				else
				{
					num3 = -1594543555;
					num4 = -1594543555;
				}
				num = num3 ^ ((int)num2 * -1490615507);
				continue;
			}
			case 0u:
				break;
			case 5u:
				goto IL_00fc;
			default:
				return gparam_0;
			case 6u:
				return gparam_0;
			}
			break;
		}
		goto IL_00c6;
		IL_00fc:
		list_0.Add(gparam_0);
		num = -1661037810;
		goto IL_00cb;
	}

	private void method_13(object object_0, bool bool_6)
	{
		using (List<Class82>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (true)
			{
				IL_0061:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 417077152;
					num2 = 417077152;
				}
				else
				{
					num = 290866710;
					num2 = 290866710;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x34D919FB)) % 4)
					{
					case 1u:
						Class171.smethod_382(enumerator.Current);
						num = 1360788853;
						continue;
					case 0u:
						num = 290866710;
						continue;
					default:
						goto end_IL_0034;
					case 2u:
						break;
					case 3u:
						goto end_IL_0034;
					}
					goto IL_0061;
					continue;
					end_IL_0034:
					break;
				}
				break;
			}
		}
		if (method_10() != IntPtr.Zero)
		{
			goto IL_00ab;
		}
		goto IL_0109;
		IL_0109:
		method_11(IntPtr.Zero);
		int num4 = 1832496080;
		goto IL_00e0;
		IL_00ab:
		num4 = 877558638;
		goto IL_00e0;
		IL_00e0:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num4 ^ 0x34D919FB)) % 6)
			{
			case 5u:
				Class171.CloseHandle(method_10());
				num4 = ((int)num3 * -1073462276) ^ 0x141869FB;
				continue;
			case 4u:
				break;
			case 3u:
				list_0.Clear();
				num4 = (int)((num3 * 814354597) ^ 0x34D7B300);
				continue;
			case 2u:
				bool_3 = false;
				num4 = (int)(num3 * 777115368) ^ -208245244;
				continue;
			default:
				return;
			case 0u:
				goto IL_0109;
			case 1u:
				return;
			}
			break;
		}
		goto IL_00ab;
	}

	internal GClass2(uint uint_0)
	{
		method_1((int)uint_0);
	}
}
