using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

internal static class UiText
{
	private const string EnglishResourceName = "ExtremeInjector.Localization.Strings.en";
	private const string ChineseResourceName = "ExtremeInjector.Localization.Strings.zh-CN";

	private static readonly ResourceManager EnglishResources =
		new ResourceManager(EnglishResourceName, Assembly.GetExecutingAssembly());

	private static readonly ResourceManager ChineseResources =
		new ResourceManager(ChineseResourceName, Assembly.GetExecutingAssembly());

	private static ResourceManager currentResources;
	private static CultureInfo currentUiCulture;

	public static LanguagePreference Preference { get; private set; }

	public static CultureInfo CurrentUiCulture => currentUiCulture;

	static UiText()
	{
		Configure(LanguagePreference.System);
	}

	public static void Configure(LanguagePreference preference)
	{
		Preference = Enum.IsDefined(typeof(LanguagePreference), preference)
			? preference
			: LanguagePreference.System;

		bool useChinese = Preference == LanguagePreference.SimplifiedChinese ||
			(Preference == LanguagePreference.System && IsChineseSystemLanguage());

		currentUiCulture = CultureInfo.GetCultureInfo(useChinese ? "zh-CN" : "en-US");
		currentResources = useChinese ? ChineseResources : EnglishResources;
		CultureInfo.DefaultThreadCurrentUICulture = currentUiCulture;
		Thread.CurrentThread.CurrentUICulture = currentUiCulture;
	}

	public static string Get(string key)
	{
		if (string.IsNullOrWhiteSpace(key))
		{
			throw new ArgumentException("A localization key is required.", nameof(key));
		}

		string value = currentResources.GetString(key, CultureInfo.InvariantCulture);
		if (value == null)
		{
			throw new MissingManifestResourceException(
				"The active language does not define the UI text key '" + key + "'.");
		}

		return value;
	}

	public static string Format(string key, params object[] arguments)
	{
		return string.Format(CultureInfo.CurrentCulture, Get(key), arguments);
	}

	private static bool IsChineseSystemLanguage()
	{
		CultureInfo culture = CultureInfo.InstalledUICulture;
		return culture.Name.StartsWith("zh", StringComparison.OrdinalIgnoreCase);
	}
}
