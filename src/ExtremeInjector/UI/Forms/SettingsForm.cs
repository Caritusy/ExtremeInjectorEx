using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ExtremeInjector;

public sealed partial class SettingsForm : Form
{
	[Serializable]
	[CompilerGenerated]
	public sealed class Class37
	{
		public static readonly Class37 _003C_003E9 = new Class37();

		public static Func<object, bool> _003C_003E9__11_0;

		internal bool method_0(object object_0)
		{
			return object_0.GetType() == typeof(ScramblePresetAttribute);
		}

		internal static Type smethod_0(object object_0)
		{
			return object_0.GetType();
		}

		internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static bool smethod_2(Type type_0, Type type_1)
		{
			return type_0 == type_1;
		}
	}

	[CompilerGenerated]
	internal RemoteProcess gclass2_0;

	internal IContainer icontainer_0;

	internal ModernCard groupBox_0;

	internal ComboBox comboBox_0;

	internal Button button_0;

	internal ModernCard groupBox_1;

	internal CheckBox checkBox_0;

	internal CheckBox checkBox_1;

	internal CheckBox checkBox_2;

	internal ModernCard groupBox_2;

	internal Button button_1;

	internal ComboBox comboBox_1;

	internal NumericUpDown numericUpDown_0;

	internal System.Windows.Forms.Label label_0;

	internal NumericUpDown numericUpDown_1;

	internal System.Windows.Forms.Label label_1;

	internal ModernCard groupBox_3;

	internal CheckBox checkBox_3;

	internal CheckBox checkBox_4;

	internal ModernCard groupBox_4;

	internal System.Windows.Forms.Label label_2;

	internal Panel panel_0;

	internal Panel panel_1;

	internal System.Windows.Forms.Label label_3;

	internal System.Windows.Forms.Label label_4;

	internal Panel panel_2;

	internal Button button_2;

	internal Button button_3;

	internal ModernCard groupBox_5;

	internal Button button_4;

	internal Button button_5;

	internal Button button_6;

	internal ColorDialog colorDialog_0;
	private bool updatingLanguageSelection;

	public SettingsForm()
	{
		InitializeModernSettingsForm();
		button_4.Enabled = !string.IsNullOrEmpty(Assembly.GetExecutingAssembly().Location);
		RecoveredRuntime.smethod_258(this);
		randomizeWindowTitleCheckBox.Checked = ApplicationSettings.Current.RandomizeWindowTitle;
		InitializeLanguageSelection();
	}

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

	internal void method_2(object sender, EventArgs e)
	{
		checkBox_1.Enabled = !checkBox_2.Checked;
	}

	internal void method_3(object sender, EventArgs e)
	{
		new AdvancedScrambleSettingsForm().ShowDialog();
		RecoveredRuntime.smethod_421(this);
	}

	internal void method_4(object sender, EventArgs e)
	{
		new ManualMapOptionsForm().ShowDialog();
	}

	internal void method_5()
	{
		var selectedPreset = comboBox_1.SelectedIndex switch
		{
			0 => ScramblePreset.None,
			1 => ScramblePreset.Basic,
			2 => ScramblePreset.Standard,
			3 => ScramblePreset.Extreme,
			_ => ScramblePreset.Custom
		};

		button_5.Enabled = selectedPreset == ScramblePreset.Custom;
		ApplicationSettings.Current.Options.Scramble.ApplyPreset(selectedPreset);
	}

	internal void method_6(object sender, EventArgs e)
	{
		method_5();
	}

	internal void method_7(object sender, EventArgs e)
	{
		if (MessageBox.Show(UiText.Get("Message.ResetSettings"), UiText.Get("App.Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return;
		}

		ApplicationSettings.Current = new ApplicationSettings();
		UiText.Configure(LanguagePreference.System);
		ApplicationSettings.Save();
		RecoveredRuntime.smethod_258(this);
		randomizeWindowTitleCheckBox.Checked = ApplicationSettings.Current.RandomizeWindowTitle;
		SetLanguageSelection(LanguagePreference.System);
		ApplyLocalizedText();
		PerformLayout();
	}

	internal void method_8(object sender, EventArgs e)
	{
		Close();
	}

	internal void method_9(object sender, FormClosingEventArgs e)
	{
		ApplicationSettings.Current.Language = GetSelectedLanguage();
		ApplicationSettings.Current.RandomizeWindowTitle = randomizeWindowTitleCheckBox.Checked;
		UiText.Configure(ApplicationSettings.Current.Language);
		RecoveredRuntime.smethod_330(this);
	}

	private void InitializeLanguageSelection()
	{
		SetLanguageSelection(ApplicationSettings.Current.Language);
		languageComboBox.SelectedIndexChanged += OnLanguageSelectionChanged;
	}

	private void OnLanguageSelectionChanged(object sender, EventArgs e)
	{
		if (updatingLanguageSelection)
		{
			return;
		}

		LanguagePreference preference = GetSelectedLanguage();
		ApplicationSettings.Current.Language = preference;
		UiText.Configure(preference);
		updatingLanguageSelection = true;
		try
		{
			ApplyLocalizedText();
			languageComboBox.SelectedIndex = (int)preference;
		}
		finally
		{
			updatingLanguageSelection = false;
		}

		PerformLayout();
	}

	private LanguagePreference GetSelectedLanguage()
	{
		int selectedIndex = languageComboBox.SelectedIndex;
		return Enum.IsDefined(typeof(LanguagePreference), selectedIndex)
			? (LanguagePreference)selectedIndex
			: LanguagePreference.System;
	}

	private void SetLanguageSelection(LanguagePreference preference)
	{
		updatingLanguageSelection = true;
		try
		{
			languageComboBox.SelectedIndex = Enum.IsDefined(typeof(LanguagePreference), preference)
				? (int)preference
				: (int)LanguagePreference.System;
		}
		finally
		{
			updatingLanguageSelection = false;
		}
	}

	internal void method_10(object sender, EventArgs e)
	{
		RecoveredRuntime.ShowProcessInspector(method_0());
	}

	internal void method_11(object sender, EventArgs e)
	{
		if (!ApplicationSettings.Current.Warnings.ScrambleAcknowledged)
		{
			ApplicationSettings.Current.Warnings.ScrambleAcknowledged = true;
			MessageBox.Show(EncodedStringTable.smethod_0(2930), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Filter = EncodedStringTable.smethod_0(497);
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (PeImage @class = RecoveredRuntime.smethod_81(PeImageLayout.const_0, openFileDialog.FileName))
					{
						if (@class != null && (@class.method_6().method_1().method_12() & CoffCharacteristics.flag_12) != (CoffCharacteristics)0)
						{
							using (SaveFileDialog saveFileDialog = new SaveFileDialog())
							{
								saveFileDialog.Filter = openFileDialog.Filter;
								saveFileDialog.InitialDirectory = Path.GetDirectoryName(openFileDialog.FileName);
								saveFileDialog.FileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + EncodedStringTable.smethod_0(3096);
								if (saveFileDialog.ShowDialog() == DialogResult.OK)
								{
									InjectorScrambleOptions injectorScrambleOptions_ = ApplicationSettings.Current.Options.Scramble;
									PeScrambleOptions class2 = new PeScrambleOptions();
									class2.method_21(injectorScrambleOptions_.CreateNewEntryPoint);
									class2.method_3(injectorScrambleOptions_.InsertExtraSections);
									class2.method_11(injectorScrambleOptions_.ModifyAssemblyCode);
									class2.method_1(injectorScrambleOptions_.ScrambleHeaderFields);
									class2.method_19(injectorScrambleOptions_.ModifyImportTable);
									class2.method_17(injectorScrambleOptions_.RenameSections);
									class2.method_15(injectorScrambleOptions_.MoveRelocationTable);
									class2.method_5(injectorScrambleOptions_.RemoveDebugData);
									class2.method_9(injectorScrambleOptions_.ShiftSectionData);
									class2.method_13(injectorScrambleOptions_.RemoveUselessData);
									class2.method_7(injectorScrambleOptions_.CreateFakeDebugDirectory);
									class2.method_24(injectorScrambleOptions_.ShiftSectionMemory);
									class2.method_26(injectorScrambleOptions_.StripSectionCharacteristics);
									PeScrambleOptions class131_ = class2;
									using (PeScrambler gclass = new PeScrambler(@class, class131_))
									{
										RecoveredRuntime.smethod_95(gclass);
										RecoveredRuntime.smethod_367(saveFileDialog.FileName, gclass);
										MessageBox.Show(EncodedStringTable.smethod_0(3117), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(EncodedStringTable.smethod_0(3186) + ex.Message, EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
	}

	internal void method_12(object sender, EventArgs e)
	{
		using (PeImage @class = RecoveredRuntime.smethod_81(PeImageLayout.const_0, Assembly.GetExecutingAssembly().Location))
		{
			PeScrambleOptions class2 = new PeScrambleOptions();
			class2.method_1(true);
			class2.method_19(true);
			class2.method_5(true);
			class2.method_9(true);
			class2.method_13(true);
			PeScrambleOptions class131_ = class2;
			using (PeScrambler gclass = new PeScrambler(@class, class131_))
			{
				try
				{
					RecoveredRuntime.smethod_95(gclass);
					string string_ = EncodedStringTable.smethod_0(3275);
					Encoding ascii = Encoding.ASCII;
					RecoveredRuntime.smethod_267(ascii, gclass, string_);
					string_ = EncodedStringTable.smethod_0(3300);
					ascii = Encoding.ASCII;
					RecoveredRuntime.smethod_267(ascii, gclass, string_);
					string string_2 = EncodedStringTable.smethod_0(3321);
					Encoding encoding_ = Encoding.ASCII;
					RecoveredRuntime.smethod_185(encoding_, gclass, string_2);
					string_2 = EncodedStringTable.smethod_0(3321);
					encoding_ = Encoding.Unicode;
					RecoveredRuntime.smethod_185(encoding_, gclass, string_2);
					string_2 = EncodedStringTable.smethod_0(3275);
					encoding_ = Encoding.Unicode;
					RecoveredRuntime.smethod_185(encoding_, gclass, string_2);
					string text = RecoveredRuntime.CreateUniqueTemporaryPath(EncodedStringTable.smethod_0(93));
					ApplicationSettings.Save();
					MemoryStream memoryStream = new MemoryStream();
					RecoveredRuntime.smethod_58(gclass, memoryStream);
					DynamicIlEmitter.smethod_3(memoryStream.ToArray(), text, PEFileKinds.WindowApplication);
					RecoveredRuntime.smethod_291(text);
					Process.Start(text, RecoveredRuntime.smethod_317());
					Environment.Exit(0);
				}
				catch (Exception ex)
				{
					MessageBox.Show(EncodedStringTable.smethod_0(3334) + ex.Message, EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
	}

	internal void method_13(object sender, EventArgs e)
	{
		this.colorDialog_0.Color = ApplicationSettings.Current.Options.TextColor;
		if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
		{
			ApplicationSettings.Current.Options.TextColor = this.colorDialog_0.Color;
		}
		RecoveredRuntime.smethod_258(this);
	}

	internal void method_14(object sender, EventArgs e)
	{
		this.colorDialog_0.Color = ApplicationSettings.Current.Options.BackgroundColor1;
		if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
		{
			ApplicationSettings.Current.Options.BackgroundColor1 = this.colorDialog_0.Color;
		}
		RecoveredRuntime.smethod_258(this);
	}

	internal void method_15(object sender, EventArgs e)
	{
		this.colorDialog_0.Color = ApplicationSettings.Current.Options.BackgroundColor2;
		if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
		{
			ApplicationSettings.Current.Options.BackgroundColor2 = this.colorDialog_0.Color;
		}
		RecoveredRuntime.smethod_258(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	internal static Assembly smethod_0()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static string smethod_1(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	internal static bool smethod_2(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	internal static void smethod_3(Control control_0, bool bool_0)
	{
		control_0.Enabled = bool_0;
	}

	internal static bool smethod_4(CheckBox checkBox_5)
	{
		return checkBox_5.Checked;
	}

	internal static DialogResult smethod_5(Form form_0)
	{
		return form_0.ShowDialog();
	}

	internal static Type smethod_6(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal FieldInfo[] method_16()
	{
		return ((Type)(object)this).GetFields();
	}

	internal static int smethod_7(ListControl listControl_0)
	{
		return listControl_0.SelectedIndex;
	}

	internal static void smethod_8(FieldInfo fieldInfo_0, object object_0, object object_1)
	{
		fieldInfo_0.SetValue(object_0, object_1);
	}

	internal static ComboBox.ObjectCollection smethod_9(ComboBox comboBox_2)
	{
		return comboBox_2.Items;
	}

	internal static int smethod_10(ComboBox.ObjectCollection objectCollection_0)
	{
		return objectCollection_0.Count;
	}

	internal static object[] smethod_11(MemberInfo memberInfo_0, bool bool_0)
	{
		return memberInfo_0.GetCustomAttributes(bool_0);
	}

	internal static DialogResult smethod_12(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static void smethod_13(Form form_0)
	{
		form_0.Close();
	}

	internal static OpenFileDialog smethod_14()
	{
		return new OpenFileDialog();
	}

	internal static void smethod_15(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.Filter = string_0;
	}

	internal static DialogResult smethod_16(CommonDialog commonDialog_0)
	{
		return commonDialog_0.ShowDialog();
	}

	internal static string smethod_17(FileDialog fileDialog_0)
	{
		return fileDialog_0.FileName;
	}

	internal static SaveFileDialog smethod_18()
	{
		return new SaveFileDialog();
	}

	internal static string smethod_19(FileDialog fileDialog_0)
	{
		return fileDialog_0.Filter;
	}

	internal static string smethod_20(string string_0)
	{
		return Path.GetDirectoryName(string_0);
	}

	internal static void smethod_21(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.InitialDirectory = string_0;
	}

	internal static string smethod_22(string string_0)
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	internal static string smethod_23(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static void smethod_24(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.FileName = string_0;
	}

	internal static void smethod_25(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static string smethod_26(Exception exception_0)
	{
		return exception_0.Message;
	}

	internal static Encoding smethod_27()
	{
		return Encoding.ASCII;
	}

	internal static Encoding smethod_28()
	{
		return Encoding.Unicode;
	}

	internal static MemoryStream smethod_29()
	{
		return new MemoryStream();
	}

	internal static byte[] smethod_30(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	internal static Process smethod_31(string string_0, string string_1)
	{
		return Process.Start(string_0, string_1);
	}

	internal static void smethod_32(int int_0)
	{
		Environment.Exit(int_0);
	}

	internal static void smethod_33(ColorDialog colorDialog_1, Color color_0)
	{
		colorDialog_1.Color = color_0;
	}

	internal static Color smethod_34(ColorDialog colorDialog_1)
	{
		return colorDialog_1.Color;
	}
}
