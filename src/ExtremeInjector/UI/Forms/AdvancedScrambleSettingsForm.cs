using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExtremeInjector;

public sealed class AdvancedScrambleSettingsForm : Form
{
	internal IContainer container;

	internal GroupBox groupBox;

	internal CheckBox checkBox;

	internal CheckBox checkBox2;

	internal GroupBox groupBox2;

	internal CheckBox checkBox3;

	internal CheckBox checkBox4;

	internal CheckBox checkBox5;

	internal CheckBox checkBox6;

	internal CheckBox checkBox7;

	internal GroupBox groupBox3;

	internal CheckBox checkBox8;

	internal CheckBox checkBox9;

	internal CheckBox checkBox10;

	internal CheckBox checkBox11;

	internal CheckBox checkBox12;

	internal CheckBox checkBox13;

	public AdvancedScrambleSettingsForm()
	{
		RecoveredRuntime.InitializeAdvancedScrambleSettingsForm(this);
		ModernUi.ApplyLegacyFormTheme(this);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		ShowInTaskbar = false;
		SizeGripStyle = SizeGripStyle.Hide;
		checkBox4.CheckedChanged += delegate
		{
			RecoveredRuntime.UpdateScrambleOptionAvailability(this);
		};
		BindOption(checkBox, options => options.ScrambleHeaderFields, (options, value) => options.ScrambleHeaderFields = value);
		BindOption(checkBox2, options => options.RemoveUselessData, (options, value) => options.RemoveUselessData = value);
		BindOption(checkBox4, options => options.InsertExtraSections, (options, value) => options.InsertExtraSections = value);
		BindOption(checkBox3, options => options.ShiftSectionData, (options, value) => options.ShiftSectionData = value);
		BindOption(checkBox5, options => options.ModifyAssemblyCode, (options, value) => options.ModifyAssemblyCode = value);
		BindOption(checkBox6, options => options.RenameSections, (options, value) => options.RenameSections = value);
		BindOption(checkBox7, options => options.CreateNewEntryPoint, (options, value) => options.CreateNewEntryPoint = value);
		BindOption(checkBox9, options => options.ModifyImportTable, (options, value) => options.ModifyImportTable = value);
		BindOption(checkBox11, options => options.RemoveDebugData, (options, value) => options.RemoveDebugData = value);
		BindOption(checkBox8, options => options.MoveRelocationTable, (options, value) => options.MoveRelocationTable = value);
		BindOption(checkBox10, options => options.CreateFakeDebugDirectory, (options, value) => options.CreateFakeDebugDirectory = value);
		BindOption(checkBox13, options => options.ShiftSectionMemory, (options, value) => options.ShiftSectionMemory = value);
		BindOption(checkBox12, options => options.StripSectionCharacteristics, (options, value) => options.StripSectionCharacteristics = value);
		RecoveredRuntime.UpdateScrambleOptionAvailability(this);
	}

	private static void BindOption(CheckBox checkBox, Func<InjectorScrambleOptions, bool> read, Action<InjectorScrambleOptions, bool> write)
	{
		InjectorScrambleOptions options = ApplicationSettings.Current.Options.Scramble;
		checkBox.Checked = read(options);
		checkBox.CheckedChanged += delegate
		{
			write(options, checkBox.Checked);
		};
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.container != null)
		{
			this.container.Dispose();
		}
		base.Dispose(disposing);
	}

	[CompilerGenerated]
	internal void checkBox_3_CheckedChanged(object sender, EventArgs e)
	{
		RecoveredRuntime.UpdateScrambleOptionAvailability(this);
	}
}
