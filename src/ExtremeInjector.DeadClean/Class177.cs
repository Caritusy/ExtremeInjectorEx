using System;
using System.Diagnostics;
using System.Reflection;

public sealed class Class177
{
	internal static Assembly assembly_0 = null;

	internal static string[] string_0 = new string[0];

	internal static void smethod_0()
	{
		try
		{
			AppDomain.CurrentDomain.ResourceResolve += smethod_1;
		}
		catch (Exception)
		{
		}
	}

	internal static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if ((object)assembly_0 == null)
		{
			lock (string_0)
			{
				assembly_0 = Assembly.Load(global::_003CModule_003E.smethod_2<string>(3928278315u));
				if ((object)assembly_0 != null)
				{
					while (true)
					{
						IL_0069:
						int num = -1797665539;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ -884579370)) % 3)
							{
							case 1u:
								goto IL_0030;
							default:
								goto end_IL_004c;
							case 0u:
								break;
							case 2u:
								goto end_IL_004c;
							}
							goto IL_0069;
							IL_0030:
							string_0 = assembly_0.GetManifestResourceNames();
							num = (int)(num2 * 841507988) ^ -430735997;
							continue;
							end_IL_004c:
							break;
						}
						break;
					}
				}
			}
		}
		string name = resolveEventArgs_0.Name;
		int num4 = default(int);
		while (true)
		{
			int num3 = -61456118;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num3 ^ -884579370)) % 9)
				{
				case 8u:
					num3 = ((num4 < string_0.Length) ? (-553916626) : (-53926138));
					continue;
				case 7u:
					num4++;
					num3 = -1382423722;
					continue;
				case 5u:
					num3 = ((string_0[num4] == name) ? (-152895505) : (-1477578753));
					continue;
				case 1u:
					num4 = 0;
					num3 = (int)(num2 * 1365554909) ^ -1774216006;
					continue;
				case 0u:
					num3 = ((!smethod_2()) ? 1179205842 : 622642022) ^ ((int)num2 * -193483257);
					continue;
				case 2u:
					break;
				case 3u:
					return null;
				case 4u:
					return assembly_0;
				default:
					return null;
				}
				break;
			}
		}
	}

	internal static bool smethod_2()
	{
		bool result = default(bool);
		try
		{
			StackFrame[] frames = new StackTrace().GetFrames();
			int num3 = default(int);
			StackFrame stackFrame = default(StackFrame);
			while (true)
			{
				IL_00d8:
				int num = 1563124308;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x2EB50487)) % 9)
					{
					case 7u:
						num = ((num3 < frames.Length) ? 18248723 : 1253927121);
						continue;
					case 6u:
						num = (((object)stackFrame.GetMethod().Module.Assembly == Assembly.GetExecutingAssembly()) ? (-665157452) : (-180389836)) ^ ((int)num2 * -345158562);
						continue;
					case 4u:
						num3 = 2;
						num = ((int)num2 * -233307481) ^ -1488453706;
						continue;
					case 2u:
						stackFrame = frames[num3];
						num = 1881685427;
						continue;
					case 1u:
						result = true;
						num = (int)(num2 * 1083496254) ^ -662546486;
						continue;
					case 0u:
						num3++;
						num = 1705854483;
						continue;
					case 5u:
						break;
					case 3u:
						goto end_IL_00a1;
					default:
						result = false;
						goto end_IL_00a1;
					}
					goto IL_00d8;
					continue;
					end_IL_00a1:
					break;
				}
				break;
			}
		}
		catch
		{
			result = true;
		}
		return result;
	}
}
