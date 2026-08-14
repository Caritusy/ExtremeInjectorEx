using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public sealed class ProcessSelectorForm : Form
{
	[CompilerGenerated]
	internal RemoteProcess gclass2_0;

	internal IContainer icontainer_0;

	internal DataGridView dataGridView_0;

	internal DataGridViewImageColumn dataGridViewImageColumn_0;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	internal Button button_0;

	internal Button button_1;

	internal Button button_2;

	internal Button button_3;

	[SpecialName]
	[CompilerGenerated]
	internal RemoteProcess method_0()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(RemoteProcess gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public ProcessSelectorForm()
	{
		Class171.smethod_334(this);
		Class171.smethod_25(this);
	}

	internal void method_2(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	internal void method_3(object sender, EventArgs e)
	{
		method_1((RemoteProcess)dataGridView_0.SelectedRows[0].Tag);
		while (true)
		{
			int num = 1639599028;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2F9F55B9)) % 4)
				{
				case 3u:
					Close();
					num = ((int)num2 * -986175172) ^ -505557011;
					continue;
				case 1u:
					base.DialogResult = DialogResult.OK;
					num = ((int)num2 * -1999319415) ^ 0x55997C23;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	internal void method_4(object sender, EventArgs e)
	{
		Class171.smethod_25(this);
	}

	internal void method_5(object sender, DataGridViewCellEventArgs e)
	{
		button_2.PerformClick();
	}

	internal void method_6(object sender, EventArgs e)
	{
		Class171.smethod_145(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			while (true)
			{
				int num = -2101637148;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1282380733)) % 4)
					{
					case 3u:
						num = ((icontainer_0 != null) ? (-1089892645) : (-1344030044)) ^ (int)(num2 * 1004543543);
						continue;
					case 1u:
						icontainer_0.Dispose();
						num = (int)(num2 * 1132356999) ^ -1045633910;
						continue;
					case 0u:
						break;
					default:
						goto end_IL_0067;
					}
					break;
				}
				continue;
				end_IL_0067:
				break;
			}
		}
		base.Dispose(disposing);
	}

	internal static void smethod_0(Form form_0, DialogResult dialogResult_0)
	{
		form_0.DialogResult = dialogResult_0;
	}

	internal static void smethod_1(Form form_0)
	{
		form_0.Close();
	}

	internal static DataGridViewSelectedRowCollection smethod_2(DataGridView dataGridView_1)
	{
		return dataGridView_1.SelectedRows;
	}

	internal static DataGridViewRow smethod_3(DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection_0, int int_0)
	{
		return dataGridViewSelectedRowCollection_0[int_0];
	}

	internal static object smethod_4(DataGridViewBand dataGridViewBand_0)
	{
		return dataGridViewBand_0.Tag;
	}

	internal static void smethod_5(Button button_4)
	{
		button_4.PerformClick();
	}

	internal static void smethod_6(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
