using System;
using System.ComponentModel;
using System.Windows.Forms;

public sealed class Form2 : Form
{
	internal IContainer icontainer_0;

	internal GroupBox groupBox_0;

	internal CheckBox checkBox_0;

	internal CheckBox checkBox_1;

	internal GroupBox groupBox_1;

	internal CheckBox checkBox_2;

	internal CheckBox checkBox_3;

	public Form2()
	{
		while (true)
		{
			int num = -1196990105;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2015624418)) % 4)
				{
				case 1u:
					Class171.smethod_227(this);
					checkBox_2.Checked = Class12.class12_0.class14_0.class13_0.bool_0;
					checkBox_1.Checked = Class12.class12_0.class14_0.class13_0.bool_1;
					checkBox_0.Checked = Class12.class12_0.class14_0.class13_0.bool_2;
					num = ((int)num2 * -384148681) ^ 0x458527FD;
					continue;
				case 0u:
					checkBox_3.Checked = Class12.class12_0.class14_0.class13_0.bool_3;
					num = ((int)num2 * -631221181) ^ 0x1BFD9914;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal void method_0(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			goto IL_0008;
		}
		goto IL_002c;
		IL_0008:
		int num = 531731441;
		goto IL_000d;
		IL_000d:
		switch ((uint)(num ^ 0x3762F036) % 4u)
		{
		case 2u:
			break;
		default:
			return;
		case 0u:
			goto IL_002c;
		case 1u:
			return;
		case 3u:
			return;
		}
		goto IL_0008;
		IL_002c:
		Class12.class12_0.class14_0.class13_0.bool_0 = checkBox_2.Checked;
		num = 541304271;
		goto IL_000d;
	}

	internal void method_1(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			goto IL_0008;
		}
		goto IL_002c;
		IL_0008:
		int num = -345144920;
		goto IL_000d;
		IL_000d:
		switch ((uint)(num ^ -1263416521) % 4u)
		{
		case 2u:
			break;
		default:
			return;
		case 0u:
			goto IL_002c;
		case 1u:
			return;
		case 3u:
			return;
		}
		goto IL_0008;
		IL_002c:
		Class12.class12_0.class14_0.class13_0.bool_1 = checkBox_1.Checked;
		num = -1516801494;
		goto IL_000d;
	}

	internal void method_2(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			goto IL_00a1;
		}
		goto IL_00e2;
		IL_00a1:
		int num = -220632949;
		goto IL_00a6;
		IL_00a6:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -645960606)) % 7)
			{
			case 5u:
				checkBox_0.Checked = false;
				num = ((int)num2 * -44775183) ^ 0x7A65BD21;
				continue;
			case 4u:
				num = ((MessageBox.Show(Class178.smethod_0(1371), Class178.smethod_0(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) ? (-1116613047) : (-1888268518)) ^ ((int)num2 * -1675529366);
				continue;
			case 2u:
				Class12.class12_0.class14_0.class13_0.bool_2 = checkBox_0.Checked;
				num = -1866456628;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_00e2;
			case 1u:
				return;
			case 6u:
				return;
			}
			break;
		}
		goto IL_00a1;
		IL_00e2:
		num = (checkBox_0.Checked ? (-1126444424) : (-8049698));
		goto IL_00a6;
	}

	internal void method_3(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			goto IL_005d;
		}
		goto IL_00df;
		IL_005d:
		int num = 1337888670;
		goto IL_00a3;
		IL_00a3:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x48B8183A)) % 7)
			{
			case 5u:
				num = ((MessageBox.Show(Class178.smethod_0(1541), Class178.smethod_0(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.No) ? 756122273 : 75688510) ^ ((int)num2 * -387340463);
				continue;
			case 4u:
				break;
			case 2u:
				Class12.class12_0.class14_0.class13_0.bool_3 = checkBox_3.Checked;
				num = 1883006899;
				continue;
			case 0u:
				checkBox_3.Checked = false;
				num = (int)(num2 * 1076934160) ^ -180567296;
				continue;
			default:
				return;
			case 1u:
				goto IL_00df;
			case 3u:
				return;
			case 6u:
				return;
			}
			break;
		}
		goto IL_005d;
		IL_00df:
		num = ((!checkBox_3.Checked) ? 29482576 : 872491931);
		goto IL_00a3;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_001f;
		}
		goto IL_0072;
		IL_001f:
		int num = 1716631280;
		goto IL_004d;
		IL_004d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x35D2C519)) % 5)
			{
			case 4u:
				icontainer_0.Dispose();
				num = ((int)num2 * -319396022) ^ -1190673088;
				continue;
			case 3u:
				break;
			case 2u:
				num = ((icontainer_0 != null) ? 654530140 : 608657105) ^ ((int)num2 * -1642874431);
				continue;
			default:
				return;
			case 0u:
				goto IL_0072;
			case 1u:
				return;
			}
			break;
		}
		goto IL_001f;
		IL_0072:
		base.Dispose(disposing);
		num = 150875787;
		goto IL_004d;
	}
}
