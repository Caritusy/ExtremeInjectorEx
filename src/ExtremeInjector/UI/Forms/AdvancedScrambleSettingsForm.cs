using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExtremeInjector;

public sealed class AdvancedScrambleSettingsForm : Form
{
	internal IContainer icontainer_0;

	internal GroupBox groupBox_0;

	internal CheckBox checkBox_0;

	internal CheckBox checkBox_1;

	internal GroupBox groupBox_1;

	internal CheckBox checkBox_2;

	internal CheckBox checkBox_3;

	internal CheckBox checkBox_4;

	internal CheckBox checkBox_5;

	internal CheckBox checkBox_6;

	internal GroupBox groupBox_2;

	internal CheckBox checkBox_7;

	internal CheckBox checkBox_8;

	internal CheckBox checkBox_9;

	internal CheckBox checkBox_10;

	internal CheckBox checkBox_11;

	internal CheckBox checkBox_12;

	public AdvancedScrambleSettingsForm()
	{
		RecoveredRuntime.smethod_234(this);
		checkBox_3.CheckedChanged += delegate
		{
			RecoveredRuntime.smethod_237(this);
		};
		BindOption(checkBox_0, options => options.ScrambleHeaderFields, (options, value) => options.ScrambleHeaderFields = value);
		BindOption(checkBox_1, options => options.RemoveUselessData, (options, value) => options.RemoveUselessData = value);
		BindOption(checkBox_3, options => options.InsertExtraSections, (options, value) => options.InsertExtraSections = value);
		BindOption(checkBox_2, options => options.ShiftSectionData, (options, value) => options.ShiftSectionData = value);
		BindOption(checkBox_4, options => options.ModifyAssemblyCode, (options, value) => options.ModifyAssemblyCode = value);
		BindOption(checkBox_5, options => options.RenameSections, (options, value) => options.RenameSections = value);
		BindOption(checkBox_6, options => options.CreateNewEntryPoint, (options, value) => options.CreateNewEntryPoint = value);
		BindOption(checkBox_8, options => options.ModifyImportTable, (options, value) => options.ModifyImportTable = value);
		BindOption(checkBox_10, options => options.RemoveDebugData, (options, value) => options.RemoveDebugData = value);
		BindOption(checkBox_7, options => options.MoveRelocationTable, (options, value) => options.MoveRelocationTable = value);
		BindOption(checkBox_9, options => options.CreateFakeDebugDirectory, (options, value) => options.CreateFakeDebugDirectory = value);
		BindOption(checkBox_12, options => options.ShiftSectionMemory, (options, value) => options.ShiftSectionMemory = value);
		BindOption(checkBox_11, options => options.StripSectionCharacteristics, (options, value) => options.StripSectionCharacteristics = value);
		RecoveredRuntime.smethod_237(this);
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
		if (disposing)
		{
			while (true)
			{
				int num = -819503620;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -468039133)) % 4)
					{
					case 3u:
						num = ((icontainer_0 != null) ? (-297161400) : (-624615149)) ^ (int)(num2 * 1811205811);
						continue;
					case 2u:
						icontainer_0.Dispose();
						num = ((int)num2 * -1637467239) ^ -1396314904;
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

	[CompilerGenerated]
	internal void checkBox_3_CheckedChanged(object sender, EventArgs e)
	{
		RecoveredRuntime.smethod_237(this);
	}

	internal static void smethod_0(CheckBox checkBox_13, EventHandler eventHandler_0)
	{
		checkBox_13.CheckedChanged += eventHandler_0;
	}

	internal static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
