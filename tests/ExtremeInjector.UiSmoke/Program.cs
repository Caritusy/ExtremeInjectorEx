using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Windows.Forms;

internal static class Program
{
	[STAThread]
	private static int Main()
	{
		try
		{
			VerifySettingsMigrationAndRoundTrip();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			VerifyMainFormLayout();
			VerifyAboutFormLayout();
			Console.WriteLine("UI and settings smoke checks passed.");
			return 0;
		}
		catch (Exception exception)
		{
			Console.Error.WriteLine(exception);
			return 1;
		}
	}

	private static void VerifySettingsMigrationAndRoundTrip()
	{
		string isolatedSettingsDirectory = Path.Combine(Environment.CurrentDirectory, "AppData", "ExtremeInjectorEx");
		AppDomain.CurrentDomain.SetData("ExtremeInjectorEx.SettingsDirectoryOverride", isolatedSettingsDirectory);
		string legacyPath = Path.Combine(Environment.CurrentDirectory, ApplicationSettings.DefaultFileName);
		var serializer = new DataContractSerializer(typeof(LegacySettingsFixture));
		using (var stream = File.Create(legacyPath))
		{
			serializer.WriteObject(stream, new LegacySettingsFixture { ProcessName = "legacy-process.exe" });
		}

		Assert(ApplicationSettings.Current.ProcessName == "legacy-process.exe", "Legacy settings were not loaded.");
		Assert(
			ApplicationSettings.DefaultSettingsDirectory == Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
				"ExtremeInjectorEx"),
			"The default settings path is not under roaming AppData.");
		Assert(ApplicationSettings.SettingsDirectory == isolatedSettingsDirectory, "The smoke-test settings directory is not isolated.");
		Assert(File.Exists(ApplicationSettings.DefaultPath), "Legacy settings were not migrated to AppData.");

		ApplicationSettings.Current.ProcessName = "round-trip.exe";
		ApplicationSettings.Save();
		ApplicationSettings loaded = ApplicationSettings.Load(ApplicationSettings.DefaultPath);
		Assert(loaded.ProcessName == "round-trip.exe", "Settings did not survive a save/load round trip.");
	}

	private static void VerifyMainFormLayout()
	{
		ConstructorInfo constructor = typeof(MainForm).GetConstructor(
			BindingFlags.Instance | BindingFlags.NonPublic,
			binder: null,
			types: new[] { typeof(bool) },
			modifiers: null);
		Assert(constructor != null, "The layout-only MainForm constructor is missing.");

		using (var form = (MainForm)constructor.Invoke(new object[] { false }))
		{
			CreateControls(form);
			ShowForLayout(form);
			SavePreview(form, "main-current-dpi.png");
			Console.WriteLine("MainForm DPI: " + form.DeviceDpi);
			Assert(form.ClientSize.Width <= ScaleAtCurrentDpi(form, 450), "The main form is no longer compact.");
			Assert(form.ClientSize.Height <= ScaleAtCurrentDpi(form, 330), "The main form is too tall for its content.");

			var grid = GetField<DataGridView>(form, "moduleGrid");
			Assert(grid.ColumnHeadersHeightSizeMode == DataGridViewColumnHeadersHeightSizeMode.DisableResizing, "DLL header height is not content-driven.");
			Assert(grid.AutoSizeRowsMode == DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders, "DLL row height is fixed.");
			int requiredHeaderHeight = grid.ColumnHeadersDefaultCellStyle.Font.Height
				+ grid.ColumnHeadersDefaultCellStyle.Padding.Vertical
				+ 2;
			Assert(grid.ColumnHeadersHeight >= requiredHeaderHeight, "DLL header text can be clipped.");

			int rowIndex = grid.Rows.Add(true, "high-dpi-sample.dll");
			grid.AutoResizeRow(rowIndex, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
			int requiredRowHeight = grid.DefaultCellStyle.Font.Height + grid.DefaultCellStyle.Padding.Vertical + 2;
			Assert(grid.Rows[rowIndex].Height >= requiredRowHeight, "DLL row text can be clipped.");
			int requiredOptionsWidth = TextRenderer.MeasureText("Options", grid.Font).Width
				+ grid.DefaultCellStyle.Padding.Horizontal
				+ 12;
			Assert(grid.Columns[2].Width >= requiredOptionsWidth, "The Options button text can be clipped.");

			var textFrame = GetField<Panel>(form, "processNameFrame");
			var processName = GetField<TextBox>(form, "processNameTextBox");
			Assert(textFrame.AutoSize, "The target process input still uses a fixed-height host.");
			Assert(
				textFrame.PreferredSize.Height >= processName.PreferredHeight + textFrame.Padding.Vertical,
				"The target process input does not reserve enough vertical space.");

			VerifyButtonsFit(form);
			VerifyImportantControlsAreVisible(form);
			VerifyModuleCommandsAreVisible(form);
			form.Scale(new SizeF(2f, 2f));
			form.PerformLayout();
			VerifyButtonsFit(form);
			VerifyImportantControlsAreVisible(form);
			VerifyModuleCommandsAreVisible(form);
		}
	}

	private static void VerifyAboutFormLayout()
	{
		using (var form = new AboutForm())
		{
			CreateControls(form);
			ShowForLayout(form);
			SavePreview(form, "about-current-dpi.png");
			Console.WriteLine("AboutForm DPI: " + form.DeviceDpi);
			Assert(form.ClientSize.Width <= ScaleAtCurrentDpi(form, 420), "The About form is no longer compact.");
			Assert(form.ClientSize.Height <= ScaleAtCurrentDpi(form, 250), "The About form is too tall for its content.");
			Assert(GetField<Label>(form, "label_0").Text == "3.7.4", "About version is incorrect.");
			Assert(GetField<Label>(form, "label_1").Text == "Extreme Injector Ex", "About product name is incorrect.");
			Assert(GetField<Label>(form, "label_2").Text == "T. R. L. S.", "About initials are incorrect.");
			Assert(
				GetField<Label>(form, "label_4").Text == "Extreme Injector Ex maintained by HaleonMaerion1337.",
				"About maintainer credit is incorrect.");
			VerifyCreditsDoNotOverlap(form);
			VerifyButtonsFit(form);

			form.Scale(new SizeF(2f, 2f));
			form.PerformLayout();
			VerifyCreditsDoNotOverlap(form);
			VerifyButtonsFit(form);
		}
	}

	private static void SavePreview(Form form, string fileName)
	{
		string outputDirectory = Environment.GetEnvironmentVariable("EXTREME_INJECTOR_UI_ARTIFACTS");
		if (string.IsNullOrWhiteSpace(outputDirectory))
		{
			return;
		}

		Directory.CreateDirectory(outputDirectory);
		using (var bitmap = new Bitmap(form.Width, form.Height))
		{
			form.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
			bitmap.Save(Path.Combine(outputDirectory, fileName));
		}
	}

	private static void ShowForLayout(Form form)
	{
		form.ShowInTaskbar = false;
		form.StartPosition = FormStartPosition.Manual;
		form.Location = new Point(-32000, -32000);
		form.Show();
		Application.DoEvents();
		form.PerformLayout();
	}

	private static void VerifyCreditsDoNotOverlap(Form form)
	{
		Rectangle originalCredit = GetBoundsRelativeTo(form, GetField<Label>(form, "label_3"));
		Rectangle exCredit = GetBoundsRelativeTo(form, GetField<Label>(form, "label_4"));
		Assert(originalCredit.Bottom <= exCredit.Top, "About credit lines overlap.");
	}

	private static void VerifyImportantControlsAreVisible(MainForm form)
	{
		Assert(GetField<DataGridView>(form, "moduleGrid").ClientSize.Height > 48, "The DLL list has no usable height.");
		Assert(GetField<Button>(form, "injectButton").ClientSize.Height > 0, "The Inject button is not visible.");
		Assert(GetField<Button>(form, "selectProcessButton").ClientSize.Width > 0, "The process selector is not visible.");
	}

	private static void VerifyModuleCommandsAreVisible(MainForm form)
	{
		foreach (string fieldName in new[] { "addDllButton", "toggleButton", "removeButton", "clearButton" })
		{
			Button button = GetField<Button>(form, fieldName);
			Rectangle bounds = GetBoundsRelativeTo(form, button);
			Assert(form.ClientRectangle.Contains(bounds), "DLL command is clipped: " + button.Text);
			Assert(button.Parent.ClientRectangle.Contains(button.Bounds), "DLL command is clipped by its command rail: " + button.Text);
		}
	}

	private static void VerifyButtonsFit(Control parent)
	{
		foreach (Control child in parent.Controls)
		{
			var button = child as Button;
			if (button != null && !string.IsNullOrEmpty(button.Text))
			{
				Size textSize = TextRenderer.MeasureText(button.Text, button.Font);
				Assert(
					textSize.Width + button.Padding.Horizontal <= button.ClientSize.Width + 2,
					"Button text is clipped: " + button.Text);
				Assert(
					textSize.Height + button.Padding.Vertical <= button.ClientSize.Height + 2,
					"Button height is too small: " + button.Text);
			}

			VerifyButtonsFit(child);
		}
	}

	private static void CreateControls(Control root)
	{
		root.CreateControl();
		foreach (Control child in root.Controls)
		{
			CreateControls(child);
		}
	}

	private static Rectangle GetBoundsRelativeTo(Control root, Control control)
	{
		Point location = root.PointToClient(control.Parent.PointToScreen(control.Location));
		return new Rectangle(location, control.Size);
	}

	private static int ScaleAtCurrentDpi(Control control, int logicalPixels)
	{
		return (int)Math.Ceiling(logicalPixels * Math.Max(1f, control.DeviceDpi / 96f));
	}

	private static T GetField<T>(object instance, string name) where T : class
	{
		FieldInfo field = instance.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic);
		Assert(field != null, "Missing field: " + name);
		var value = field.GetValue(instance) as T;
		Assert(value != null, "Unexpected field type: " + name);
		return value;
	}

	private static void Assert(bool condition, string message)
	{
		if (!condition)
		{
			throw new InvalidOperationException(message);
		}
	}

	[DataContract(Name = "ApplicationSettings", Namespace = "")]
	private sealed class LegacySettingsFixture
	{
		[DataMember(Name = "ProcessName")]
		public string ProcessName { get; set; }
	}
}
