using System;
using System.Drawing;
using System.Runtime.Serialization;
using ExtremeInjector;

[DataContract(Name = "InjectionOptions", Namespace = "")]
public sealed class InjectionOptions
{
	[DataMember(Name = "Method")]
	private int serializedMethod;

	[DataMember(Name = "Advanced")]
	public AdvancedInjectionOptions Advanced { get; set; }

	[DataMember(Name = "Scramble")]
	public InjectorScrambleOptions Scramble { get; set; }

	[DataMember(Name = "AutoInject")]
	public bool AutoInject { get; set; }

	[DataMember(Name = "CloseOnInject")]
	public bool CloseOnInject { get; set; }

	[DataMember(Name = "StealthInject")]
	public bool StealthInject { get; set; }

	[DataMember(Name = "Delay")]
	public int DelayBeforeInjection { get; set; }

	[DataMember(Name = "DelayBetween")]
	public int DelayBetweenModules { get; set; }

	[DataMember(Name = "ErasePE")]
	public bool ErasePeHeaders { get; set; }

	[DataMember(Name = "HideModule")]
	public bool HideModule { get; set; }

	[DataMember(Name = "Background1")]
	private string background1Html;

	[DataMember(Name = "Background2")]
	private string background2Html;

	[DataMember(Name = "TextColor")]
	private string textColorHtml;

	[IgnoreDataMember]
	public InjectionMethod Method
	{
		get => Enum.IsDefined(typeof(InjectionMethod), serializedMethod)
			? (InjectionMethod)serializedMethod
			: InjectionMethod.StandardInjection;
		set => serializedMethod = (int)value;
	}

	[IgnoreDataMember]
	public Color BackgroundColor1
	{
		get => ColorTranslator.FromHtml(background1Html);
		set => background1Html = ColorTranslator.ToHtml(value);
	}

	[IgnoreDataMember]
	public Color BackgroundColor2
	{
		get => ColorTranslator.FromHtml(background2Html);
		set => background2Html = ColorTranslator.ToHtml(value);
	}

	[IgnoreDataMember]
	public Color TextColor
	{
		get => ColorTranslator.FromHtml(textColorHtml);
		set => textColorHtml = ColorTranslator.ToHtml(value);
	}

	public InjectionOptions()
	{
		InitializeDefaults();
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext context)
	{
		InitializeDefaults();
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
		Advanced = Advanced ?? new AdvancedInjectionOptions();
		Scramble = Scramble ?? new InjectorScrambleOptions();
		background1Html = string.IsNullOrEmpty(background1Html) ? ColorTranslator.ToHtml(Color.DodgerBlue) : background1Html;
		background2Html = string.IsNullOrEmpty(background2Html) ? ColorTranslator.ToHtml(Color.DeepSkyBlue) : background2Html;
		textColorHtml = string.IsNullOrEmpty(textColorHtml) ? ColorTranslator.ToHtml(Color.White) : textColorHtml;
	}

	private void InitializeDefaults()
	{
		Advanced = new AdvancedInjectionOptions();
		Scramble = new InjectorScrambleOptions();
		BackgroundColor1 = Color.DodgerBlue;
		BackgroundColor2 = Color.DeepSkyBlue;
		TextColor = Color.White;
	}
}
