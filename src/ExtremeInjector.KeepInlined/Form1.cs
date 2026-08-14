using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

public sealed class Form1 : Form
{
	internal IContainer icontainer_0;

	internal Panel panel_0;

	internal Label label_0;

	internal Label label_1;

	internal Label label_2;

	internal Label label_3;

	internal PictureBox pictureBox_0;

	internal LinkLabel linkLabel_0;

	internal Label label_4;

	public Form1()
	{
		Version version = default(Version);
		while (true)
		{
			int num = -1945122371;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -535551437)) % 7)
				{
				case 5u:
					Class171.smethod_307(this);
					num = (int)((num2 * 1034738133) ^ 0x593CC78);
					continue;
				case 4u:
					label_0.Text = version.Major + Class178.smethod_0(952) + version.Minor;
					num = (int)(num2 * 559403448) ^ -60541410;
					continue;
				case 2u:
				{
					Label label = label_0;
					label.Text = label.Text + Class178.smethod_0(952) + version.Build;
					num = ((int)num2 * -1654178938) ^ 0x3DC30A5E;
					continue;
				}
				case 1u:
					version = Assembly.GetExecutingAssembly().GetName().Version;
					num = ((int)num2 * -416800423) ^ -1926742095;
					continue;
				case 0u:
					num = ((version.Build != 0) ? (-1753893004) : (-287880601)) ^ (int)(num2 * 411989617);
					continue;
				default:
					return;
				case 3u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	internal void method_0(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(Class178.smethod_0(957));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_002e;
		}
		goto IL_0072;
		IL_002e:
		int num = -379864415;
		goto IL_004d;
		IL_004d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1646498067)) % 5)
			{
			case 4u:
				num = ((icontainer_0 != null) ? 1001074097 : 1567159047) ^ (int)(num2 * 1733860542);
				continue;
			case 3u:
				break;
			case 1u:
				icontainer_0.Dispose();
				num = (int)((num2 * 1343688538) ^ 0x64FC7F27);
				continue;
			default:
				return;
			case 0u:
				goto IL_0072;
			case 2u:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_0072:
		base.Dispose(disposing);
		num = -1396247750;
		goto IL_004d;
	}

	internal static Assembly smethod_0()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static AssemblyName smethod_1(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	internal static Version smethod_2(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Version;
	}

	internal static int smethod_3(Version version_0)
	{
		return version_0.Major;
	}

	internal static int smethod_4(Version version_0)
	{
		return version_0.Minor;
	}

	internal static string smethod_5(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	internal static void smethod_6(Control control_0, string string_0)
	{
		control_0.Text = string_0;
	}

	internal static int smethod_7(Version version_0)
	{
		return version_0.Build;
	}

	internal static string smethod_8(Control control_0)
	{
		return control_0.Text;
	}

	internal static Process smethod_9(string string_0)
	{
		return Process.Start(string_0);
	}

	internal static void smethod_10(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
