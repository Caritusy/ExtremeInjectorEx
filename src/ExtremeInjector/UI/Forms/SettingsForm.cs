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

	internal IContainer container;

	internal ModernCard modernCard;

	internal ComboBox comboBox;

	internal Button button;

	internal ModernCard modernCard2;

	internal CheckBox checkBox;

	internal CheckBox checkBox2;

	internal CheckBox checkBox3;

	internal ModernCard modernCard3;

	internal Button button2;

	internal ComboBox comboBox2;

	internal NumericUpDown numericUpDown;

	internal System.Windows.Forms.Label label;

	internal NumericUpDown numericUpDown2;

	internal System.Windows.Forms.Label label2;

	internal ModernCard modernCard4;

	internal CheckBox checkBox4;

	internal CheckBox checkBox5;

	internal ModernCard modernCard5;

	internal System.Windows.Forms.Label label3;

	internal Panel panel;

	internal Panel panel2;

	internal System.Windows.Forms.Label label4;

	internal System.Windows.Forms.Label label5;

	internal Panel panel3;

	internal Button button3;

	internal Button button4;

	internal ModernCard modernCard6;

	internal Button button5;

	internal Button button6;

	internal Button button7;

	internal ColorDialog colorDialog;
	private bool updatingLanguageSelection;

	public SettingsForm()
	{
		InitializeModernSettingsForm();
		button5.Enabled = !string.IsNullOrEmpty(Assembly.GetExecutingAssembly().Location);
		RecoveredRuntime.LoadSettingsIntoForm(this);
		randomizeWindowTitleCheckBox.Checked = ApplicationSettings.Current.RandomizeWindowTitle;
		InitializeLanguageSelection();
	}

	internal void OnAutoInjectChanged(object sender, EventArgs e)
	{
		checkBox2.Enabled = !checkBox3.Checked;
	}

	internal void OnAdvancedScrambleSettingsClick(object sender, EventArgs e)
	{
		using (var form = new AdvancedScrambleSettingsForm())
		{
			form.ShowDialog(this);
		}
		RecoveredRuntime.SelectCurrentScramblePreset(this);
	}

	internal void OnManualMapOptionsClick(object sender, EventArgs e)
	{
		using (var form = new ManualMapOptionsForm())
		{
			form.ShowDialog(this);
		}
	}

	internal void ApplySelectedScramblePreset()
	{
		var selectedPreset = comboBox2.SelectedIndex switch
		{
			0 => ScramblePreset.None,
			1 => ScramblePreset.Basic,
			2 => ScramblePreset.Standard,
			3 => ScramblePreset.Extreme,
			_ => ScramblePreset.Custom
		};

		button6.Enabled = selectedPreset == ScramblePreset.Custom;
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
			MessageBox.Show(this, UiText.Get("Message.ScrambleStandaloneInfo"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Filter = UiText.Get("Dialog.DllFilter");
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				try
				{
					using (PeImage @class = RecoveredRuntime.LoadPeImageFromFile(PeImageLayout.File, openFileDialog.FileName))
					{
						if (@class != null && (@class.GetHeaders().GetCoffHeader().GetCharacteristics() & CoffCharacteristics.Dll) != (CoffCharacteristics)0)
						{
							using (SaveFileDialog saveFileDialog = new SaveFileDialog())
							{
								saveFileDialog.Filter = openFileDialog.Filter;
								saveFileDialog.InitialDirectory = Path.GetDirectoryName(openFileDialog.FileName);
								saveFileDialog.FileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + "_scrambled.dll";
								if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
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
										MessageBox.Show(this, UiText.Get("Message.ScrambleSuccess"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, UiText.Format("Message.ScrambleFailed", ex.Message), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
	}

	internal void OnRestartSafeModeClick(object sender, EventArgs e)
	{
		using (PeImage @class = RecoveredRuntime.LoadPeImageFromFile(PeImageLayout.File, Assembly.GetExecutingAssembly().Location))
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
					string[] identifyingText = { "Extreme Injector Ex", "Extreme Injector", "master131" };
					foreach (string value in identifyingText)
					{
						RecoveredRuntime.ReplaceStringWithRandomValue(Encoding.ASCII, gclass, value);
						RecoveredRuntime.ReplaceStringWithRandomValue(Encoding.Unicode, gclass, value);
					}
					string text = RecoveredRuntime.CreateUniqueTemporaryPath(".exe");
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
					MessageBox.Show(this, UiText.Format("Message.SecureModeFailed", ex.Message), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
	}

	internal void OnTextColorClick(object sender, EventArgs e)
	{
		this.colorDialog.Color = ApplicationSettings.Current.Options.TextColor;
		if (this.colorDialog.ShowDialog() == DialogResult.OK)
		{
			ApplicationSettings.Current.Options.TextColor = this.colorDialog.Color;
		}
		RecoveredRuntime.LoadSettingsIntoForm(this);
	}

	internal void OnPrimaryColorClick(object sender, EventArgs e)
	{
		this.colorDialog.Color = ApplicationSettings.Current.Options.BackgroundColor1;
		if (this.colorDialog.ShowDialog() == DialogResult.OK)
		{
			ApplicationSettings.Current.Options.BackgroundColor1 = this.colorDialog.Color;
		}
		RecoveredRuntime.LoadSettingsIntoForm(this);
	}

	internal void OnSecondaryColorClick(object sender, EventArgs e)
	{
		this.colorDialog.Color = ApplicationSettings.Current.Options.BackgroundColor2;
		if (this.colorDialog.ShowDialog() == DialogResult.OK)
		{
			ApplicationSettings.Current.Options.BackgroundColor2 = this.colorDialog.Color;
		}
		RecoveredRuntime.LoadSettingsIntoForm(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.container != null)
		{
			this.container.Dispose();
		}
		base.Dispose(disposing);
	}
}
