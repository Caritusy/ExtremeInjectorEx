using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ExtremeInjector.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
public sealed class Settings : ApplicationSettingsBase
{
	internal static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());

	public static Settings Default => settings_0;

	internal static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
