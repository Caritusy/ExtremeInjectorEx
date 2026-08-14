using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

public static class Class18
{
	internal static bool bool_0;

	[STAThread]
	private static void Main(string[] args)
	{
		Class171.smethod_353();
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
					if (!Class171.smethod_266())
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
							switch ((num2 = (uint)(num3 ^ 0x722AF2EC)) % 3)
							{
							case 2u:
								mainForm = new GForm0();
								if (args.Length == 1)
								{
									Class171.smethod_348(args);
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
}
