using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using ExtremeInjector;

public sealed partial class SettingsForm : Form
{
	internal RemoteProcess SelectedProcess { get; set; }

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
		RecoveredRuntime.LoadSettingsIntoForm(this);
		randomizeWindowTitleCheckBox.Checked = ApplicationSettings.Current.RandomizeWindowTitle;
		InitializeLanguageSelection();
	}

	internal void OnAutoInjectChanged(object sender, EventArgs e)
	{
		checkBox_1.Enabled = !checkBox_2.Checked;
	}

	internal void OnAdvancedScrambleSettingsClick(object sender, EventArgs e)
	{
		new AdvancedScrambleSettingsForm().ShowDialog();
		RecoveredRuntime.SelectCurrentScramblePreset(this);
	}

	internal void OnManualMapOptionsClick(object sender, EventArgs e)
	{
		new ManualMapOptionsForm().ShowDialog();
	}

	internal void ApplySelectedScramblePreset()
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

	internal void OnScramblePresetChanged(object sender, EventArgs e)
	{
		ApplySelectedScramblePreset();
	}

	internal void OnResetSettingsClick(object sender, EventArgs e)
	{
		if (MessageBox.Show(UiText.Get("Message.ResetSettings"), UiText.Get("App.Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return;
		}

		ApplicationSettings.Current = new ApplicationSettings();
		UiText.Configure(LanguagePreference.System);
		ApplicationSettings.Save();
		RecoveredRuntime.LoadSettingsIntoForm(this);
		randomizeWindowTitleCheckBox.Checked = ApplicationSettings.Current.RandomizeWindowTitle;
		SetLanguageSelection(LanguagePreference.System);
		ApplyLocalizedText();
		PerformLayout();
	}

	internal void OnCloseClick(object sender, EventArgs e)
	{
		Close();
	}

	internal void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		ApplicationSettings.Current.Language = GetSelectedLanguage();
		ApplicationSettings.Current.RandomizeWindowTitle = randomizeWindowTitleCheckBox.Checked;
		UiText.Configure(ApplicationSettings.Current.Language);
		RecoveredRuntime.SaveSettingsFromForm(this);
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

	internal void OnInspectProcessClick(object sender, EventArgs e)
	{
		RecoveredRuntime.ShowProcessInspector(SelectedProcess);
	}

	internal void OnScrambleDllClick(object sender, EventArgs e)
	{
		if (!ApplicationSettings.Current.Warnings.ScrambleAcknowledged)
		{
			ApplicationSettings.Current.Warnings.ScrambleAcknowledged = true;
			MessageBox.Show(EncodedStringTable.DecodeString(2930), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Filter = EncodedStringTable.DecodeString(497);
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (PeImage @class = RecoveredRuntime.LoadPeImageFromFile(PeImageLayout.const_0, openFileDialog.FileName))
					{
						if (@class != null && (@class.GetHeaders().GetCoffHeader().GetCharacteristics() & CoffCharacteristics.flag_12) != (CoffCharacteristics)0)
						{
							using (SaveFileDialog saveFileDialog = new SaveFileDialog())
							{
								saveFileDialog.Filter = openFileDialog.Filter;
								saveFileDialog.InitialDirectory = Path.GetDirectoryName(openFileDialog.FileName);
								saveFileDialog.FileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + EncodedStringTable.DecodeString(3096);
								if (saveFileDialog.ShowDialog() == DialogResult.OK)
								{
									InjectorScrambleOptions injectorScrambleOptions_ = ApplicationSettings.Current.Options.Scramble;
									PeScrambleOptions class2 = new PeScrambleOptions();
									class2.CreateNewEntryPoint = injectorScrambleOptions_.CreateNewEntryPoint;
									class2.InsertExtraSections = injectorScrambleOptions_.InsertExtraSections;
									class2.ModifyAssemblyCode = injectorScrambleOptions_.ModifyAssemblyCode;
									class2.ScrambleHeaderFields = injectorScrambleOptions_.ScrambleHeaderFields;
									class2.ModifyImportTable = injectorScrambleOptions_.ModifyImportTable;
									class2.RenameSections = injectorScrambleOptions_.RenameSections;
									class2.MoveRelocationTable = injectorScrambleOptions_.MoveRelocationTable;
									class2.RemoveDebugData = injectorScrambleOptions_.RemoveDebugData;
									class2.ShiftSectionData = injectorScrambleOptions_.ShiftSectionData;
									class2.RemoveUselessData = injectorScrambleOptions_.RemoveUselessData;
									class2.CreateFakeDebugDirectory = injectorScrambleOptions_.CreateFakeDebugDirectory;
									class2.ShiftSectionMemory = injectorScrambleOptions_.ShiftSectionMemory;
									class2.StripSectionCharacteristics = injectorScrambleOptions_.StripSectionCharacteristics;
									PeScrambleOptions class131_ = class2;
									using (PeScrambler gclass = new PeScrambler(@class, class131_))
									{
										RecoveredRuntime.ScramblePeImage(gclass);
										RecoveredRuntime.SaveScrambledImage(saveFileDialog.FileName, gclass);
										MessageBox.Show(EncodedStringTable.DecodeString(3117), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(EncodedStringTable.DecodeString(3186) + ex.Message, EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
	}

	internal void OnRestartSafeModeClick(object sender, EventArgs e)
	{
		using (PeImage @class = RecoveredRuntime.LoadPeImageFromFile(PeImageLayout.const_0, Assembly.GetExecutingAssembly().Location))
		{
			PeScrambleOptions class2 = new PeScrambleOptions();
			class2.ScrambleHeaderFields = true;
			class2.ModifyImportTable = true;
			class2.RemoveDebugData = true;
			class2.ShiftSectionData = true;
			class2.RemoveUselessData = true;
			PeScrambleOptions class131_ = class2;
			using (PeScrambler gclass = new PeScrambler(@class, class131_))
			{
				try
				{
					RecoveredRuntime.ScramblePeImage(gclass);
					string string_ = EncodedStringTable.DecodeString(3275);
					Encoding ascii = Encoding.ASCII;
					RecoveredRuntime.ReplaceStringWithRandomValue(ascii, gclass, string_);
					string_ = EncodedStringTable.DecodeString(3300);
					ascii = Encoding.ASCII;
					RecoveredRuntime.ReplaceStringWithRandomValue(ascii, gclass, string_);
					string string_2 = EncodedStringTable.DecodeString(3321);
					Encoding encoding_ = Encoding.ASCII;
					RecoveredRuntime.RemoveEncodedString(encoding_, gclass, string_2);
					string_2 = EncodedStringTable.DecodeString(3321);
					encoding_ = Encoding.Unicode;
					RecoveredRuntime.RemoveEncodedString(encoding_, gclass, string_2);
					string_2 = EncodedStringTable.DecodeString(3275);
					encoding_ = Encoding.Unicode;
					RecoveredRuntime.RemoveEncodedString(encoding_, gclass, string_2);
					string text = RecoveredRuntime.CreateUniqueTemporaryPath(EncodedStringTable.DecodeString(93));
					ApplicationSettings.Save();
					MemoryStream memoryStream = new MemoryStream();
					RecoveredRuntime.WriteScrambledImage(gclass, memoryStream);
					DynamicIlEmitter.BuildExecutable(memoryStream.ToArray(), text, PEFileKinds.WindowApplication);
					RecoveredRuntime.WriteIntegrityChecksum(text);
					Process.Start(text, RecoveredRuntime.GetEncodedSettingsPath());
					Environment.Exit(0);
				}
				catch (Exception ex)
				{
					MessageBox.Show(EncodedStringTable.DecodeString(3334) + ex.Message, EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
	}

	internal void OnTextColorClick(object sender, EventArgs e)
	{
		this.colorDialog_0.Color = ApplicationSettings.Current.Options.TextColor;
		if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
		{
			ApplicationSettings.Current.Options.TextColor = this.colorDialog_0.Color;
		}
		RecoveredRuntime.LoadSettingsIntoForm(this);
	}

	internal void OnPrimaryColorClick(object sender, EventArgs e)
	{
		this.colorDialog_0.Color = ApplicationSettings.Current.Options.BackgroundColor1;
		if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
		{
			ApplicationSettings.Current.Options.BackgroundColor1 = this.colorDialog_0.Color;
		}
		RecoveredRuntime.LoadSettingsIntoForm(this);
	}

	internal void OnSecondaryColorClick(object sender, EventArgs e)
	{
		this.colorDialog_0.Color = ApplicationSettings.Current.Options.BackgroundColor2;
		if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
		{
			ApplicationSettings.Current.Options.BackgroundColor2 = this.colorDialog_0.Color;
		}
		RecoveredRuntime.LoadSettingsIntoForm(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}
}
