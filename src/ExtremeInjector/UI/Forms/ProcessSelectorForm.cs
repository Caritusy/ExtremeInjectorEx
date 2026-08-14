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
		RecoveredRuntime.smethod_334(this);
		ModernUi.ApplyLegacyFormTheme(this);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		ShowInTaskbar = false;
		ModernUi.StylePrimaryButton(
			button_2,
			ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1),
			ModernUi.HarmonizeInteractiveColor(
				ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1),
				ApplicationSettings.Current.Options.BackgroundColor2));
		button_2.AutoSize = false;
		button_2.MinimumSize = System.Drawing.Size.Empty;
		button_2.Padding = Padding.Empty;
		RecoveredRuntime.smethod_25(this);
	}

	internal void method_2(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	internal void method_3(object sender, EventArgs e)
	{
		this.method_1((RemoteProcess)this.dataGridView_0.SelectedRows[0].Tag);
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	internal void method_4(object sender, EventArgs e)
	{
		RecoveredRuntime.smethod_25(this);
	}

	internal void method_5(object sender, DataGridViewCellEventArgs e)
	{
		button_2.PerformClick();
	}

	internal void method_6(object sender, EventArgs e)
	{
		RecoveredRuntime.smethod_145(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
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
