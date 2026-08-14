using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

public static class Class18
{
	internal static bool bool_0;

	[STAThread]
	internal static void Main(string[] args)
	{
		Class171.smethod_359();
		while (true)
		{
			int num = 1562872190;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x722AF2EC)) % 4)
				{
				case 3u:
					if (Class171.smethod_69())
					{
						num = ((int)num2 * -188678676) ^ 0x34E32895;
						continue;
					}
					goto IL_0092;
				case 2u:
					if (!Class171.smethod_272())
					{
						num = ((int)num2 * -2018629874) ^ -200221501;
						continue;
					}
					goto IL_0092;
				case 0u:
					break;
				default:
					{
						ProcessStartInfo startInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().Location)
						{
							Verb = Class178.smethod_0(119),
							UseShellExecute = true
						};
						try
						{
							Process.Start(startInfo);
							Environment.Exit(0);
						}
						catch (Exception)
						{
						}
						goto IL_0092;
					}
					IL_0092:
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(defaultValue: false);
					while (true)
					{
						int num3 = 536079906;
						while (true)
						{
							GForm0 mainForm;
							switch ((uint)(num3 ^ 0x722AF2EC) % 3u)
							{
							case 2u:
								mainForm = new GForm0();
								if (args.Length == 1)
								{
									Class171.smethod_354(args);
								}
								goto IL_00b0;
							default:
								return;
							case 0u:
								break;
							case 1u:
								return;
							}
							break;
							IL_00b0:
							Application.Run(mainForm);
							num3 = 27985943;
						}
					}
				}
				break;
			}
		}
	}

	internal static Assembly smethod_0()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static string smethod_1(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	internal static ProcessStartInfo smethod_2(string string_0)
	{
		return new ProcessStartInfo(string_0);
	}

	internal static void smethod_3(ProcessStartInfo processStartInfo_0, string string_0)
	{
		processStartInfo_0.Verb = string_0;
	}

	internal static void smethod_4(ProcessStartInfo processStartInfo_0, bool bool_1)
	{
		processStartInfo_0.UseShellExecute = bool_1;
	}

	internal static Process smethod_5(ProcessStartInfo processStartInfo_0)
	{
		return Process.Start(processStartInfo_0);
	}

	internal static void smethod_6(int int_0)
	{
		Environment.Exit(int_0);
	}

	internal static void smethod_7()
	{
		Application.EnableVisualStyles();
	}

	internal static void smethod_8(bool bool_1)
	{
		Application.SetCompatibleTextRenderingDefault(bool_1);
	}

	internal static void smethod_9(Form form_0)
	{
		Application.Run(form_0);
	}
}
