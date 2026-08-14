using System;
using System.ComponentModel;
using System.Windows.Forms;

public sealed class ManualMapOptionsForm : Form
{
	internal IContainer icontainer_0;

	internal GroupBox groupBox_0;

	internal CheckBox checkBox_0;

	internal CheckBox checkBox_1;

	internal GroupBox groupBox_1;

	internal CheckBox checkBox_2;

	internal CheckBox checkBox_3;

	public ManualMapOptionsForm()
	{
		RecoveredRuntime.smethod_233(this);
		this.checkBox_2.Checked = ApplicationSettings.Current.Options.Advanced.HideFromDebugger;
		this.checkBox_1.Checked = ApplicationSettings.Current.Options.Advanced.ManualResolveImports;
		this.checkBox_0.Checked = ApplicationSettings.Current.Options.Advanced.DisableExceptionSupport;
		this.checkBox_3.Checked = ApplicationSettings.Current.Options.Advanced.DisableSehValidation;
	}

	internal void method_0(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		ApplicationSettings.Current.Options.Advanced.HideFromDebugger = this.checkBox_2.Checked;
	}

	internal void method_1(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		ApplicationSettings.Current.Options.Advanced.ManualResolveImports = this.checkBox_1.Checked;
	}

	internal void method_2(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		if (this.checkBox_0.Checked && MessageBox.Show(EncodedStringTable.smethod_0(1371), EncodedStringTable.smethod_0(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
		{
			this.checkBox_0.Checked = false;
		}
		ApplicationSettings.Current.Options.Advanced.DisableExceptionSupport = this.checkBox_0.Checked;
	}

	internal void method_3(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		if (this.checkBox_3.Checked && MessageBox.Show(EncodedStringTable.smethod_0(1541), EncodedStringTable.smethod_0(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
		{
			this.checkBox_3.Checked = false;
		}
		ApplicationSettings.Current.Options.Advanced.DisableSehValidation = this.checkBox_3.Checked;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	internal static void smethod_0(CheckBox checkBox_4, bool bool_0)
	{
		checkBox_4.Checked = bool_0;
	}

	internal static bool smethod_1(Control control_0)
	{
		return control_0.Visible;
	}

	internal static bool smethod_2(CheckBox checkBox_4)
	{
		return checkBox_4.Checked;
	}

	internal static DialogResult smethod_3(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static void smethod_4(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
