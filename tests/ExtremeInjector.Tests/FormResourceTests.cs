using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtremeInjector.Tests;

[TestClass]
public sealed class FormResourceTests
{
	[TestMethod]
	public void LegacyFormIconsAreAvailableThroughTheStableResourceKey()
	{
		Type[] formTypes =
		{
			typeof(ProcessSelectorForm),
			typeof(ManualMapOptionsForm),
			typeof(AdvancedScrambleSettingsForm),
			typeof(DependencyInstallerForm),
			typeof(ProcessInspectorForm)
		};

		foreach (Type formType in formTypes)
		{
			var resources = new ComponentResourceManager(formType);
			Assert.IsInstanceOfType(
				resources.GetObject("$this.Icon"),
				typeof(Icon),
				$"{formType.Name} must expose its icon through the stable $this.Icon key.");
		}
	}

	[TestMethod]
	public void ProcessEnumerationIncludesTheCurrentProcess()
	{
		int currentProcessId = Process.GetCurrentProcess().Id;
		RemoteProcess[] processes = RecoveredRuntime.EnumerateRemoteProcesses();

		Assert.IsTrue(
			processes.Any(process => process.ProcessId == currentProcessId),
			"Process enumeration must not filter out every accessible process.");
	}

	[TestMethod]
	public void ProcessSelectorCanBeConstructedOnAnStaThread()
	{
		Exception failure = null;
		var thread = new Thread(() =>
		{
			try
			{
				UiText.Configure(LanguagePreference.English);
				using var form = new ProcessSelectorForm();
				Assert.AreEqual("Process list", form.Text);
				Assert.IsNotNull(form.Icon);
				Assert.IsNotNull(form.processGrid);
				Assert.IsTrue(form.processGrid.Rows.Count > 0);
				Assert.IsTrue(form.selectButton.Enabled);
				Assert.AreEqual("Cancel", form.cancelButton.Text);
			}
			catch (Exception exception)
			{
				failure = exception;
			}
		})
		{
			IsBackground = true
		};
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();

		Assert.IsTrue(thread.Join(TimeSpan.FromSeconds(30)), "Process selector construction timed out.");
		Assert.IsNull(failure, failure?.ToString());
	}

	[TestMethod]
	public void InteractiveDllAndAdvancedSettingsControlsAreComplete()
	{
		Exception failure = null;
		var thread = new Thread(() =>
		{
			try
			{
				UiText.Configure(LanguagePreference.English);
				using (var mainForm = new MainForm(initializeRuntime: false))
				{
					Assert.AreEqual(2, mainForm.moduleGrid.Columns.Count);
					Assert.AreSame(mainForm.moduleColumn, mainForm.moduleGrid.Columns[0]);
					Assert.AreSame(mainForm.exportOptionsColumn, mainForm.moduleGrid.Columns[1]);
					Assert.IsTrue(ModuleListCell.IsCheckBoxHit(mainForm.moduleGrid, 12));
				}

				using (var moduleOptions = new ModuleOptionsForm(attachRuntimeLoadHandler: false))
				{
					moduleOptions.PopulateChoiceLists();
					Assert.AreEqual(1, moduleOptions.exportRoutineComboBox.Items.Count);
					Assert.AreEqual(3, moduleOptions.callingConventionComboBox.Items.Count);
					Assert.AreEqual(7, moduleOptions.parameterTypeComboBox.Items.Count);
					Assert.IsFalse(moduleOptions.exportRoutineComboBox.Items.Cast<object>().Any(item => item == null));
				}

				using (var manualMapOptions = new ManualMapOptionsForm())
				{
					AssertVisibleText(manualMapOptions, manualMapOptions.checkBox, manualMapOptions.checkBox2, manualMapOptions.checkBox3, manualMapOptions.checkBox4);
				}

				using (var scrambleOptions = new AdvancedScrambleSettingsForm())
				{
					AssertVisibleText(
						scrambleOptions,
						scrambleOptions.checkBox,
						scrambleOptions.checkBox2,
						scrambleOptions.checkBox3,
						scrambleOptions.checkBox4,
						scrambleOptions.checkBox5,
						scrambleOptions.checkBox6,
						scrambleOptions.checkBox7,
						scrambleOptions.checkBox8,
						scrambleOptions.checkBox9,
						scrambleOptions.checkBox10,
						scrambleOptions.checkBox11,
						scrambleOptions.checkBox12,
							scrambleOptions.checkBox13);
				}

				using (var processInspector = new ProcessInspectorForm())
				{
					AssertVisibleText(
						processInspector,
						processInspector.groupBox,
						processInspector.tabPage,
						processInspector.tabPage2,
						processInspector.button,
						processInspector.button2,
						processInspector.button3,
						processInspector.button4,
						processInspector.button5);
					Assert.AreEqual(3, processInspector.dataGridView.Columns.Count);
					Assert.AreEqual(3, processInspector.dataGridView2.Columns.Count);
					Assert.IsTrue(processInspector.dataGridView.Columns.Cast<DataGridViewColumn>().All(column => !string.IsNullOrWhiteSpace(column.HeaderText)));
					Assert.IsTrue(processInspector.dataGridView2.Columns.Cast<DataGridViewColumn>().All(column => !string.IsNullOrWhiteSpace(column.HeaderText)));
				}

				using (var dependencyInstaller = new DependencyInstallerForm())
				{
					AssertVisibleText(dependencyInstaller, dependencyInstaller.label);
					Assert.IsNotNull(dependencyInstaller.progressBar);
				}
			}
			catch (Exception exception)
			{
				failure = exception;
			}
		})
		{
			IsBackground = true
		};
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();

		Assert.IsTrue(thread.Join(TimeSpan.FromSeconds(30)), "Interactive form construction timed out.");
		Assert.IsNull(failure, failure?.ToString());
	}

	private static void AssertVisibleText(Form form, params Control[] controls)
	{
		Assert.IsFalse(string.IsNullOrWhiteSpace(form.Text));
		Assert.IsTrue(controls.All(control => !string.IsNullOrWhiteSpace(control.Text)));
	}
}
