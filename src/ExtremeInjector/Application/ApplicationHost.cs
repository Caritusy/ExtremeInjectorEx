internal static class ApplicationHost
{
	internal static int Run(string[] args)
	{
		SingleFileAssemblyResolver.Register();
		if (CliApplication.IsCliRequest(args))
		{
			CliConsole.Initialize();
			return CliApplication.Run(args);
		}

		return GuiApplication.Run(args);
	}
}
