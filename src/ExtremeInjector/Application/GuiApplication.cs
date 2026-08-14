using System.Windows.Forms;

internal static class GuiApplication
{
	internal static int Run(string[] args)
	{
		bool isGuiHost = GuiProcessLauncher.RemoveHostArgument(args, out string[] guiArguments);
		if (!isGuiHost && SingleInstanceCoordinator.TryActivateExisting())
		{
			return 0;
		}

		if (!isGuiHost && GuiProcessLauncher.TryStartHost(guiArguments))
		{
			return 0;
		}

		CliConsole.DetachForGui();
		if (SingleInstanceCoordinator.TryActivateExisting())
		{
			return 0;
		}

		if (!GuiProcessLauncher.IsAdministrator() && GuiProcessLauncher.TryRestartAsAdministrator(guiArguments))
		{
			return 0;
		}

		using (SingleInstanceCoordinator instance = SingleInstanceCoordinator.Acquire())
		{
			if (!instance.IsPrimary)
			{
				return 0;
			}

			ExternalSettingsLoader.LoadLegacyArgument(guiArguments);
			UiText.Configure(ApplicationSettings.Current.Language);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using (var mainForm = new MainForm())
			{
				instance.AttachMainWindow(mainForm);
				Application.Run(mainForm);
			}
		}

		return 0;
	}
}
