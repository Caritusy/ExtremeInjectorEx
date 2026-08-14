using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal sealed class Class75
{
	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private IntPtr intptr_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private IntPtr intptr_1;

	[CompilerGenerated]
	private ThreadPriorityLevel threadPriorityLevel_0;

	private GClass2 gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public int method_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(int int_3)
	{
		int_0 = int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_2()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(IntPtr intptr_2)
	{
		intptr_0 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_4(int int_3)
	{
		int_1 = int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_5(int int_3)
	{
		int_2 = int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_6(IntPtr intptr_2)
	{
		intptr_1 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public ThreadPriorityLevel method_7()
	{
		return threadPriorityLevel_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_8(ThreadPriorityLevel threadPriorityLevel_1)
	{
		threadPriorityLevel_0 = threadPriorityLevel_1;
	}

	[SpecialName]
	public Class76 method_9()
	{
		using (List<Class79>.Enumerator enumerator = Class171.smethod_21().GetEnumerator())
		{
			Class76 result = default(Class76);
			Class124.Struct40 current2 = default(Class124.Struct40);
			while (enumerator.MoveNext())
			{
				while (true)
				{
					Class79 current = enumerator.Current;
					int num = 780617579;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x5E082B33)) % 4)
						{
						case 2u:
							num = 469388930;
							continue;
						case 0u:
							break;
						case 1u:
							goto end_IL_004a;
						default:
							goto IL_007b;
						}
						if (current.method_0().intptr_0.ToInt64() != gclass2_0.method_0())
						{
							goto end_IL_006c;
						}
						num = ((int)num2 * -1692459396) ^ -1198049984;
						continue;
						IL_007b:
						using (List<Class124.Struct40>.Enumerator enumerator2 = current.method_2().GetEnumerator())
						{
							while (true)
							{
								IL_0145:
								int num3;
								int num4;
								if (!enumerator2.MoveNext())
								{
									num3 = 2125654612;
									num4 = 2125654612;
								}
								else
								{
									num3 = 1901714577;
									num4 = 1901714577;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x5E082B33)) % 7)
									{
									case 6u:
										result = new Class76(current2);
										num3 = ((int)num2 * -277804953) ^ 0x6D45C9BD;
										continue;
									case 2u:
									{
										int num5;
										int num6;
										if (current2.struct48_0.intptr_1.ToInt64() == method_0())
										{
											num5 = -1997841906;
											num6 = -1997841906;
										}
										else
										{
											num5 = -1436264980;
											num6 = -1436264980;
										}
										num3 = num5 ^ ((int)num2 * -1655082334);
										continue;
									}
									case 1u:
										current2 = enumerator2.Current;
										num3 = 1031407247;
										continue;
									case 0u:
										num3 = 1901714577;
										continue;
									default:
										goto end_IL_0108;
									case 3u:
										break;
									case 5u:
										goto end_IL_0108;
									case 4u:
										return result;
									}
									goto IL_0145;
									continue;
									end_IL_0108:
									break;
								}
								break;
							}
						}
						goto end_IL_006c;
						continue;
						end_IL_004a:
						break;
					}
					continue;
					end_IL_006c:
					break;
				}
			}
		}
		return null;
	}

	internal Class75(GClass2 gclass2_1, int int_3)
	{
		gclass2_0 = gclass2_1;
		method_1(int_3);
	}
}
