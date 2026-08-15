using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ExtremeInjector;
using Microsoft.Win32;

public sealed partial class RecoveredRuntime
{

	internal static void ConfigureInstallerDownload(DependencyInstallerForm dependencyInstallerForm, string text, string text2, string text3)
	{
		dependencyInstallerForm.text = text;
		dependencyInstallerForm.text2 = text2;
		dependencyInstallerForm.text3 = text3;
		dependencyInstallerForm.flag = true;
	}

	internal static void ConfigureArchiveDownload(DependencyInstallerForm dependencyInstallerForm, string text, string text2)
	{
		dependencyInstallerForm.text = text;
		dependencyInstallerForm.text2 = text2;
		dependencyInstallerForm.flag = false;
	}

	internal static Bitmap CreateSmallIconBitmap(Icon icon)
	{
		Bitmap result;
		using (Bitmap bitmap = icon.ToBitmap())
		{
			Bitmap bitmap2 = new Bitmap(22, 22);
			using (Graphics graphics = Graphics.FromImage(bitmap2))
			{
				graphics.InterpolationMode = InterpolationMode.High;
				graphics.DrawImage(bitmap, 0, 0, bitmap2.Width, bitmap2.Height);
			}
			result = bitmap2;
		}
		return result;
	}

	internal static void ToggleModuleEnabled(MainForm mainForm, int intValue)
	{
		if (intValue < 0 || intValue >= mainForm.moduleGrid.Rows.Count)
		{
			return;
		}

		DataGridViewRow row = mainForm.moduleGrid.Rows[intValue];
		MainForm.ModuleRow module = (MainForm.ModuleRow)row.Tag;
		module.Entry.Enabled = !module.Entry.Enabled;
		mainForm.moduleGrid.InvalidateCell(mainForm.moduleColumn.Index, intValue);
		ApplicationSettings.Save();
	}

	internal static void InitializeDependencyInstallerForm(DependencyInstallerForm dependencyInstallerForm)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DependencyInstallerForm));
		dependencyInstallerForm.label = new System.Windows.Forms.Label();
		dependencyInstallerForm.progressBar = new ProgressBar();
		dependencyInstallerForm.SuspendLayout();
		dependencyInstallerForm.label.AutoSize = true;
		dependencyInstallerForm.label.Font = new Font(EncodedStringTable.DecodeString(11956), 8.75f);
		dependencyInstallerForm.label.Location = new Point(9, 9);
		dependencyInstallerForm.label.Name = EncodedStringTable.DecodeString(12983);
		dependencyInstallerForm.label.Size = new Size(170, 15);
		dependencyInstallerForm.label.TabIndex = 0;
		dependencyInstallerForm.label.Text = EncodedStringTable.DecodeString(13000);
		dependencyInstallerForm.progressBar.Location = new Point(12, 29);
		dependencyInstallerForm.progressBar.Name = EncodedStringTable.DecodeString(13041);
		dependencyInstallerForm.progressBar.Size = new Size(448, 23);
		dependencyInstallerForm.progressBar.TabIndex = 1;
		dependencyInstallerForm.AutoScaleDimensions = new SizeF(96f, 96f);
		dependencyInstallerForm.AutoScaleMode = AutoScaleMode.Dpi;
		dependencyInstallerForm.ClientSize = new Size(472, 64);
		dependencyInstallerForm.Controls.Add(dependencyInstallerForm.progressBar);
		dependencyInstallerForm.Controls.Add(dependencyInstallerForm.label);
		dependencyInstallerForm.Font = new Font(EncodedStringTable.DecodeString(11956), 8.25f);
		dependencyInstallerForm.FormBorderStyle = FormBorderStyle.FixedSingle;
		dependencyInstallerForm.Icon = componentResourceManager.GetObject("$this.Icon") as Icon;
		dependencyInstallerForm.MaximizeBox = false;
		dependencyInstallerForm.MinimizeBox = false;
		dependencyInstallerForm.Name = EncodedStringTable.DecodeString(13079);
		dependencyInstallerForm.Text = EncodedStringTable.DecodeString(13108);
		dependencyInstallerForm.FormClosing += dependencyInstallerForm.OnFormClosing;
		dependencyInstallerForm.Load += dependencyInstallerForm.OnFormLoad;
		dependencyInstallerForm.ResumeLayout(false);
		dependencyInstallerForm.PerformLayout();
	}

	internal static bool StripNumericPrefix(ref string text, [Out] ModuleOptionsForm moduleOptionsForm, string text2)
	{
		if (text2.StartsWith("0x", StringComparison.Ordinal) || text2.StartsWith("0X", StringComparison.Ordinal))
		{
			text = text2.Substring(2);
			return true;
		}
		text = text2;
		return false;
	}

	internal static MainForm.ModuleRow[] GetEnabledModuleRows(MainForm mainForm)
	{
		return mainForm.moduleGrid.Rows
			.Cast<DataGridViewRow>()
			.Select(row => (MainForm.ModuleRow)row.Tag)
			.Where(module => module.Entry.Enabled)
			.ToArray();
	}

	internal static void ShowInjectionError(MainForm mainForm, string message, Exception exception)
	{
		mainForm.Invoke((MethodInvoker)delegate
		{
			MessageBox.Show(
				mainForm,
				FormatExceptionChain(message, exception, flag: true),
				UiText.Get("App.Title"),
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
		});
	}

	internal static void ShowUnsupportedWindowsXpMessage(string text, MainForm mainForm, string text2)
	{
		MessageBox.Show(mainForm, UiText.Format("Message.Dependency.UnsupportedXp", text2, text), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	internal static void WaitWithStatus(MainForm mainForm, int intValue, string text)
	{
		for (int elapsedMilliseconds = 0; elapsedMilliseconds < intValue; elapsedMilliseconds += 100)
		{
			float remainingSeconds = (float)(intValue - elapsedMilliseconds) / 1000f;
			mainForm.BeginInvoke((Action)(() =>
			{
				mainForm.processDescriptionLabel.Text = string.Format(text, remainingSeconds);
			}));
			Thread.Sleep(100);
		}
	}

	internal static bool InjectModule(ref IntPtr moduleBase, MainForm mainForm, ScramblePreset scramblePreset, string sourceModulePath)
	{
		return InjectModule(
			ref moduleBase,
			mainForm.selectedProcess,
			ApplicationSettings.Current.Options,
			scramblePreset,
			sourceModulePath,
			message => mainForm.Invoke((MethodInvoker)delegate
			{
				MessageBox.Show(
					mainForm,
					message,
					UiText.Get("App.Title"),
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}),
			(message, exception) => ShowInjectionError(mainForm, message, exception));
	}

	internal static bool InjectModule(
		ref IntPtr moduleBase,
		RemoteProcess process,
		InjectionOptions options,
		ScramblePreset scramblePreset,
		string sourceModulePath,
		Action<string> reportMessage,
		Action<string, Exception> reportError)
	{
		moduleBase = IntPtr.Zero;
		string workingModulePath = sourceModulePath;

		try
		{
			if (!ModuleMatchesProcessArchitecture(process, sourceModulePath, out string mismatchMessage))
			{
				reportMessage?.Invoke(mismatchMessage);
				return false;
			}

			workingModulePath = PrepareModuleForInjection(sourceModulePath, options, scramblePreset);
			moduleBase = InjectWithConfiguredBackend(process, workingModulePath, sourceModulePath, options, reportError);
			if (moduleBase == IntPtr.Zero)
			{
				throw new InvalidOperationException(UiText.Get("Message.InjectionReturnedNull"));
			}

			return true;
		}
		catch (Exception exception)
		{
			string processName = process?.Name ?? UiText.Get("Common.UnknownProcess");
			reportError?.Invoke(UiText.Format("Message.InjectFailed", Path.GetFileName(sourceModulePath), processName), exception);
			return false;
		}
		finally
		{
			if (options.StealthInject && !string.Equals(workingModulePath, sourceModulePath, StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					if (File.Exists(workingModulePath))
					{
						File.Delete(workingModulePath);
					}
				}
				catch
				{
				}
			}
		}
	}

	internal static void UpdateScrambleOptionAvailability(AdvancedScrambleSettingsForm advancedScrambleSettingsForm)
	{
		bool enabled = advancedScrambleSettingsForm.checkBox4.Checked;
		advancedScrambleSettingsForm.checkBox10.Enabled = enabled;
		advancedScrambleSettingsForm.checkBox8.Enabled = enabled;
		advancedScrambleSettingsForm.checkBox7.Enabled = enabled;
	}

	internal static bool ConfirmDependencyInstallation(MainForm mainForm, string text, string text2, string text3, bool flag, string text4)
	{
		if (flag)
		{
			if (MessageBox.Show(mainForm, string.Concat(new string[]
			{
				EncodedStringTable.DecodeString(13250),
				text,
				EncodedStringTable.DecodeString(13291),
				text2,
				EncodedStringTable.DecodeString(23898),
				text3,
				EncodedStringTable.DecodeString(24068),
				text4,
				EncodedStringTable.DecodeString(24129),
				text4,
				EncodedStringTable.DecodeString(24174)
			}), EncodedStringTable.DecodeString(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
			{
				return false;
			}
		}
		else if (MessageBox.Show(mainForm, string.Concat(new string[]
		{
			EncodedStringTable.DecodeString(13250),
			text,
			EncodedStringTable.DecodeString(13291),
			text2,
			EncodedStringTable.DecodeString(24183),
			text4,
			EncodedStringTable.DecodeString(24341)
		}), EncodedStringTable.DecodeString(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return false;
		}
		return true;
	}

	internal static bool TryAddExportParameter(ModuleOptionsForm moduleOptionsForm, string text, ExportParameterType exportParameterType, bool flag)
	{
		string numericText = text;
		bool hexadecimal = StripNumericPrefix(ref numericText, moduleOptionsForm, numericText);
		NumberStyles numberStyle = hexadecimal ? NumberStyles.HexNumber : NumberStyles.Integer;
		bool valid;

		switch (exportParameterType)
		{
		case ExportParameterType.AnsiString:
		case ExportParameterType.UnicodeString:
			valid = true;
			break;
		case ExportParameterType.Byte:
			valid = byte.TryParse(numericText, numberStyle, CultureInfo.InvariantCulture, out _) ||
				(!hexadecimal && (sbyte.TryParse(numericText, NumberStyles.Integer, CultureInfo.InvariantCulture, out _) || char.TryParse(text, out _)));
			break;
		case ExportParameterType.UInt16:
			valid = ushort.TryParse(numericText, numberStyle, CultureInfo.InvariantCulture, out _) ||
				(!hexadecimal && (short.TryParse(numericText, NumberStyles.Integer, CultureInfo.InvariantCulture, out _) || char.TryParse(text, out _)));
			break;
		case ExportParameterType.UInt32:
			valid = uint.TryParse(numericText, numberStyle, CultureInfo.InvariantCulture, out _) ||
				(!hexadecimal && int.TryParse(numericText, NumberStyles.Integer, CultureInfo.InvariantCulture, out _));
			break;
		case ExportParameterType.UInt64:
			valid = ulong.TryParse(numericText, numberStyle, CultureInfo.InvariantCulture, out _) ||
				(!hexadecimal && long.TryParse(numericText, NumberStyles.Integer, CultureInfo.InvariantCulture, out _));
			break;
		case ExportParameterType.Single:
			valid = !hexadecimal && float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out _);
			break;
		default:
			valid = false;
			break;
		}

		if (!valid)
		{
			return false;
		}

		moduleOptionsForm.parametersGrid.Rows.Add(null, moduleOptionsForm.parameterTypeComboBox.Items[(int)exportParameterType].ToString(), text);
		if (flag)
		{
			if (moduleOptionsForm.Module.Parameters == null)
			{
				moduleOptionsForm.Module.Parameters = new List<ExportParameter>();
			}

			moduleOptionsForm.Module.Parameters.Add(new ExportParameter
			{
				Type = exportParameterType,
				Value = text
			});
		}

		return true;
	}

	internal static void CompleteInjection(bool flag, MainForm mainForm)
	{
		if (ApplicationSettings.Current.Options.CloseOnInject)
		{
			mainForm.Close();
			return;
		}

		if (flag)
		{
			MessageBox.Show(UiText.Get("Message.InjectionCompleted"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		if (mainForm.selectedProcess != null && HasProcessExited(mainForm.selectedProcess))
		{
			SetSelectedProcess(mainForm, null);
		}

		mainForm.settingsButton.Enabled = true;
		mainForm.injectButton.Enabled = mainForm.selectedProcess != null && !ApplicationSettings.Current.Options.AutoInject;
		mainForm.processRefreshTimer.Start();
	}

	internal static void PromptDependencyInstallation(string text, MainForm mainForm, string text2, string text3, string text4)
	{
		DialogResult dialogResult = MessageBox.Show(mainForm, string.Concat(new string[]
		{
			EncodedStringTable.DecodeString(13250),
			text,
			EncodedStringTable.DecodeString(13291),
			text4,
			EncodedStringTable.DecodeString(25673)
		}), EncodedStringTable.DecodeString(599), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
		if (dialogResult != DialogResult.Yes)
		{
			if (dialogResult == DialogResult.No)
			{
				MessageBox.Show(mainForm, EncodedStringTable.DecodeString(26205) + text2 + EncodedStringTable.DecodeString(26318), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Process.Start(text3);
			}
			return;
		}
		if (RecoveredRuntime.IsAdministrator())
		{
			DependencyInstallerForm form = new DependencyInstallerForm();
			RecoveredRuntime.ConfigureArchiveDownload(form, text3, text2);
			form.ShowDialog();
			return;
		}
		MessageBox.Show(mainForm, EncodedStringTable.DecodeString(26027), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	internal static void InitializeProcessInspectorForm(ProcessInspectorForm processInspectorForm)
	{
		processInspectorForm.container = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProcessInspectorForm));
		processInspectorForm.button2 = new Button();
		processInspectorForm.button = new Button();
		processInspectorForm.dataGridView = new DataGridView();
		processInspectorForm.dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		processInspectorForm.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		processInspectorForm.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		processInspectorForm.groupBox = new GroupBox();
		processInspectorForm.label = new System.Windows.Forms.Label();
		processInspectorForm.pictureBox = new PictureBox();
		processInspectorForm.timer = new System.Windows.Forms.Timer(processInspectorForm.container);
		processInspectorForm.button3 = new Button();
		processInspectorForm.tabControl = new TabControl();
		processInspectorForm.tabPage = new TabPage();
		processInspectorForm.tabPage2 = new TabPage();
		processInspectorForm.dataGridView2 = new DataGridView();
		processInspectorForm.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		processInspectorForm.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		processInspectorForm.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		processInspectorForm.button4 = new Button();
		processInspectorForm.button5 = new Button();
		((ISupportInitialize)processInspectorForm.dataGridView).BeginInit();
		processInspectorForm.groupBox.SuspendLayout();
		((ISupportInitialize)processInspectorForm.pictureBox).BeginInit();
		processInspectorForm.tabControl.SuspendLayout();
		processInspectorForm.tabPage.SuspendLayout();
		processInspectorForm.tabPage2.SuspendLayout();
		((ISupportInitialize)processInspectorForm.dataGridView2).BeginInit();
		processInspectorForm.SuspendLayout();
		processInspectorForm.button2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		processInspectorForm.button2.Enabled = false;
		processInspectorForm.button2.Location = new Point(279, 215);
		processInspectorForm.button2.Name = EncodedStringTable.DecodeString(26363);
		processInspectorForm.button2.Size = new Size(97, 22);
		processInspectorForm.button2.TabIndex = 14;
		processInspectorForm.button2.Text = EncodedStringTable.DecodeString(26380);
		processInspectorForm.button2.UseVisualStyleBackColor = true;
		processInspectorForm.button2.Click += processInspectorForm.OnUnloadModuleClick;
		processInspectorForm.button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		processInspectorForm.button.Location = new Point(199, 442);
		processInspectorForm.button.Name = EncodedStringTable.DecodeString(26401);
		processInspectorForm.button.Size = new Size(97, 22);
		processInspectorForm.button.TabIndex = 13;
		processInspectorForm.button.Text = EncodedStringTable.DecodeString(26418);
		processInspectorForm.button.UseVisualStyleBackColor = true;
		processInspectorForm.button.Click += processInspectorForm.OnTerminateProcessClick;
		processInspectorForm.dataGridView.AllowUserToAddRows = false;
		processInspectorForm.dataGridView.AllowUserToDeleteRows = false;
		processInspectorForm.dataGridView.AllowUserToResizeRows = false;
		processInspectorForm.dataGridView.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		processInspectorForm.dataGridView.BackgroundColor = Color.White;
		processInspectorForm.dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		processInspectorForm.dataGridView.Columns.AddRange(new DataGridViewColumn[]
		{
			processInspectorForm.dataGridViewTextBoxColumn,
			processInspectorForm.dataGridViewTextBoxColumn2,
			processInspectorForm.dataGridViewTextBoxColumn3
		});
		processInspectorForm.dataGridView.Location = new Point(0, 0);
		processInspectorForm.dataGridView.MultiSelect = false;
		processInspectorForm.dataGridView.Name = EncodedStringTable.DecodeString(26435);
		processInspectorForm.dataGridView.ReadOnly = true;
		processInspectorForm.dataGridView.RowHeadersVisible = false;
		processInspectorForm.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		processInspectorForm.dataGridView.Size = new Size(379, 209);
		processInspectorForm.dataGridView.TabIndex = 11;
		processInspectorForm.dataGridView.SelectionChanged += processInspectorForm.OnModuleSelectionChanged;
		processInspectorForm.dataGridView.SortCompare += processInspectorForm.OnGridSortCompare;
		processInspectorForm.dataGridViewTextBoxColumn.HeaderText = EncodedStringTable.DecodeString(26464);
		processInspectorForm.dataGridViewTextBoxColumn.Name = EncodedStringTable.DecodeString(26481);
		processInspectorForm.dataGridViewTextBoxColumn.ReadOnly = true;
		processInspectorForm.dataGridViewTextBoxColumn.Width = 150;
		processInspectorForm.dataGridViewTextBoxColumn2.HeaderText = EncodedStringTable.DecodeString(26506);
		processInspectorForm.dataGridViewTextBoxColumn2.Name = EncodedStringTable.DecodeString(26523);
		processInspectorForm.dataGridViewTextBoxColumn2.ReadOnly = true;
		processInspectorForm.dataGridViewTextBoxColumn2.Width = 120;
		processInspectorForm.dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		processInspectorForm.dataGridViewTextBoxColumn3.HeaderText = EncodedStringTable.DecodeString(26548);
		processInspectorForm.dataGridViewTextBoxColumn3.Name = EncodedStringTable.DecodeString(26565);
		processInspectorForm.dataGridViewTextBoxColumn3.ReadOnly = true;
		processInspectorForm.groupBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		processInspectorForm.groupBox.Controls.Add(processInspectorForm.label);
		processInspectorForm.groupBox.Controls.Add(processInspectorForm.pictureBox);
		processInspectorForm.groupBox.Location = new Point(12, 12);
		processInspectorForm.groupBox.Name = EncodedStringTable.DecodeString(26590);
		processInspectorForm.groupBox.Size = new Size(387, 154);
		processInspectorForm.groupBox.TabIndex = 10;
		processInspectorForm.groupBox.TabStop = false;
		processInspectorForm.groupBox.Text = EncodedStringTable.DecodeString(26611);
		processInspectorForm.label.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		processInspectorForm.label.Location = new Point(47, 21);
		processInspectorForm.label.Name = EncodedStringTable.DecodeString(26624);
		processInspectorForm.label.Size = new Size(334, 123);
		processInspectorForm.label.TabIndex = 5;
		processInspectorForm.label.Text = EncodedStringTable.DecodeString(26653);
		processInspectorForm.pictureBox.BackColor = Color.Transparent;
		processInspectorForm.pictureBox.Location = new Point(9, 21);
		processInspectorForm.pictureBox.Name = EncodedStringTable.DecodeString(26670);
		processInspectorForm.pictureBox.Size = new Size(32, 32);
		processInspectorForm.pictureBox.TabIndex = 4;
		processInspectorForm.pictureBox.TabStop = false;
		processInspectorForm.timer.Interval = 250;
		processInspectorForm.timer.Tick += processInspectorForm.OnProcessExitTimerTick;
		processInspectorForm.button3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		processInspectorForm.button3.Location = new Point(302, 442);
		processInspectorForm.button3.Name = EncodedStringTable.DecodeString(23701);
		processInspectorForm.button3.Size = new Size(97, 22);
		processInspectorForm.button3.TabIndex = 12;
		processInspectorForm.button3.Text = EncodedStringTable.DecodeString(23718);
		processInspectorForm.button3.UseVisualStyleBackColor = true;
		processInspectorForm.button3.Click += processInspectorForm.OnCloseClick;
		processInspectorForm.tabControl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		processInspectorForm.tabControl.Controls.Add(processInspectorForm.tabPage);
		processInspectorForm.tabControl.Controls.Add(processInspectorForm.tabPage2);
		processInspectorForm.tabControl.Location = new Point(12, 172);
		processInspectorForm.tabControl.Name = EncodedStringTable.DecodeString(26695);
		processInspectorForm.tabControl.SelectedIndex = 0;
		processInspectorForm.tabControl.Size = new Size(387, 266);
		processInspectorForm.tabControl.TabIndex = 15;
		processInspectorForm.tabPage.Controls.Add(processInspectorForm.dataGridView);
		processInspectorForm.tabPage.Controls.Add(processInspectorForm.button2);
		processInspectorForm.tabPage.Location = new Point(4, 22);
		processInspectorForm.tabPage.Name = EncodedStringTable.DecodeString(26716);
		processInspectorForm.tabPage.Size = new Size(379, 240);
		processInspectorForm.tabPage.TabIndex = 0;
		processInspectorForm.tabPage.Text = EncodedStringTable.DecodeString(26737);
		processInspectorForm.tabPage.UseVisualStyleBackColor = true;
		processInspectorForm.tabPage2.Controls.Add(processInspectorForm.button5);
		processInspectorForm.tabPage2.Controls.Add(processInspectorForm.button4);
		processInspectorForm.tabPage2.Controls.Add(processInspectorForm.dataGridView2);
		processInspectorForm.tabPage2.Location = new Point(4, 22);
		processInspectorForm.tabPage2.Name = EncodedStringTable.DecodeString(26750);
		processInspectorForm.tabPage2.Size = new Size(379, 240);
		processInspectorForm.tabPage2.TabIndex = 1;
		processInspectorForm.tabPage2.Text = EncodedStringTable.DecodeString(26771);
		processInspectorForm.tabPage2.UseVisualStyleBackColor = true;
		processInspectorForm.dataGridView2.AllowUserToAddRows = false;
		processInspectorForm.dataGridView2.AllowUserToDeleteRows = false;
		processInspectorForm.dataGridView2.AllowUserToResizeRows = false;
		processInspectorForm.dataGridView2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		processInspectorForm.dataGridView2.BackgroundColor = Color.White;
		processInspectorForm.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		processInspectorForm.dataGridView2.Columns.AddRange(new DataGridViewColumn[]
		{
			processInspectorForm.dataGridViewTextBoxColumn4,
			processInspectorForm.dataGridViewTextBoxColumn5,
			processInspectorForm.dataGridViewTextBoxColumn6
		});
		processInspectorForm.dataGridView2.Location = new Point(0, 0);
		processInspectorForm.dataGridView2.MultiSelect = false;
		processInspectorForm.dataGridView2.Name = EncodedStringTable.DecodeString(26784);
		processInspectorForm.dataGridView2.ReadOnly = true;
		processInspectorForm.dataGridView2.RowHeadersVisible = false;
		processInspectorForm.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		processInspectorForm.dataGridView2.Size = new Size(379, 209);
		processInspectorForm.dataGridView2.TabIndex = 12;
		processInspectorForm.dataGridView2.SelectionChanged += processInspectorForm.OnThreadSelectionChanged;
		processInspectorForm.dataGridView2.SortCompare += processInspectorForm.OnGridSortCompare;
		processInspectorForm.dataGridViewTextBoxColumn4.HeaderText = EncodedStringTable.DecodeString(26813);
		processInspectorForm.dataGridViewTextBoxColumn4.Name = EncodedStringTable.DecodeString(26826);
		processInspectorForm.dataGridViewTextBoxColumn4.ReadOnly = true;
		processInspectorForm.dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		processInspectorForm.dataGridViewTextBoxColumn5.HeaderText = EncodedStringTable.DecodeString(26847);
		processInspectorForm.dataGridViewTextBoxColumn5.Name = EncodedStringTable.DecodeString(26868);
		processInspectorForm.dataGridViewTextBoxColumn5.ReadOnly = true;
		processInspectorForm.dataGridViewTextBoxColumn6.HeaderText = EncodedStringTable.DecodeString(26901);
		processInspectorForm.dataGridViewTextBoxColumn6.Name = EncodedStringTable.DecodeString(26914);
		processInspectorForm.dataGridViewTextBoxColumn6.ReadOnly = true;
		processInspectorForm.button4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		processInspectorForm.button4.Enabled = false;
		processInspectorForm.button4.Location = new Point(279, 215);
		processInspectorForm.button4.Name = EncodedStringTable.DecodeString(26939);
		processInspectorForm.button4.Size = new Size(97, 22);
		processInspectorForm.button4.TabIndex = 15;
		processInspectorForm.button4.Text = EncodedStringTable.DecodeString(12632);
		processInspectorForm.button4.UseVisualStyleBackColor = true;
		processInspectorForm.button4.Click += processInspectorForm.OnToggleThreadSuspensionClick;
		processInspectorForm.button5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		processInspectorForm.button5.Enabled = false;
		processInspectorForm.button5.Location = new Point(176, 215);
		processInspectorForm.button5.Name = EncodedStringTable.DecodeString(26968);
		processInspectorForm.button5.Size = new Size(97, 22);
		processInspectorForm.button5.TabIndex = 16;
		processInspectorForm.button5.Text = EncodedStringTable.DecodeString(26993);
		processInspectorForm.button5.UseVisualStyleBackColor = true;
		processInspectorForm.button5.Click += processInspectorForm.OnTerminateThreadClick;
		processInspectorForm.AutoScaleDimensions = new SizeF(96f, 96f);
		processInspectorForm.AutoScaleMode = AutoScaleMode.Dpi;
		processInspectorForm.ClientSize = new Size(410, 469);
		processInspectorForm.Controls.Add(processInspectorForm.tabControl);
		processInspectorForm.Controls.Add(processInspectorForm.button);
		processInspectorForm.Controls.Add(processInspectorForm.button3);
		processInspectorForm.Controls.Add(processInspectorForm.groupBox);
		processInspectorForm.Font = new Font(EncodedStringTable.DecodeString(11956), 8.25f);
		processInspectorForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
		processInspectorForm.Icon = componentResourceManager.GetObject("$this.Icon") as Icon;
		processInspectorForm.MaximizeBox = false;
		processInspectorForm.MinimizeBox = false;
		processInspectorForm.Name = EncodedStringTable.DecodeString(27002);
		processInspectorForm.Text = EncodedStringTable.DecodeString(27023);
		processInspectorForm.Load += processInspectorForm.OnFormLoad;
		((ISupportInitialize)processInspectorForm.dataGridView).EndInit();
		processInspectorForm.groupBox.ResumeLayout(false);
		((ISupportInitialize)processInspectorForm.pictureBox).EndInit();
		processInspectorForm.tabControl.ResumeLayout(false);
		processInspectorForm.tabPage.ResumeLayout(false);
		processInspectorForm.tabPage2.ResumeLayout(false);
		((ISupportInitialize)processInspectorForm.dataGridView2).EndInit();
		processInspectorForm.ResumeLayout(false);
	}

	internal static void CheckForUpdatesAndNotify()
	{
		string str;
		if (!RecoveredRuntime.TryCheckForUpdate(out str))
		{
			return;
		}
		MessageBox.Show(EncodedStringTable.DecodeString(27052) + str + EncodedStringTable.DecodeString(27125), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	internal static void SelectCurrentScramblePreset(SettingsForm settingsForm)
	{
		ScramblePreset @enum = ApplicationSettings.Current.Options.Scramble.Detect();
		if (@enum == ScramblePreset.None)
		{
			settingsForm.comboBox2.SelectedIndex = 0;
			return;
		}
		if (@enum != ScramblePreset.Custom)
		{
			settingsForm.comboBox2.SelectedIndex = @enum - ScramblePreset.Custom;
			return;
		}
		settingsForm.comboBox2.SelectedIndex = settingsForm.comboBox2.Items.Count - 1;
	}
}
