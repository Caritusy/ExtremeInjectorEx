using System;
using System.Drawing;
using System.Runtime.Serialization;
using ExtremeInjector;

[DataContract(Namespace = "")]
public sealed class Class14
{
	[DataMember(Name = "Method")]
	public int int_0;

	[DataMember(Name = "Advanced")]
	public Class13 class13_0;

	[DataMember(Name = "Scramble")]
	public InjectorScrambleOptions injectorScrambleOptions_0;

	[DataMember(Name = "AutoInject")]
	public bool bool_0;

	[DataMember(Name = "CloseOnInject")]
	public bool bool_1;

	[DataMember(Name = "StealthInject")]
	public bool bool_2;

	[DataMember(Name = "Delay")]
	public int int_1;

	[DataMember(Name = "DelayBetween")]
	public int int_2;

	[DataMember(Name = "ErasePE")]
	public bool bool_3;

	[DataMember(Name = "HideModule")]
	public bool bool_4;

	[DataMember(Name = "Background1")]
	public string string_0;

	[DataMember(Name = "Background2")]
	public string string_1;

	[DataMember(Name = "TextColor")]
	public string string_2;

	[IgnoreDataMember]
	public Enum4 Enum4_0
	{
		get
		{
			if (Enum.IsDefined(typeof(Enum4), int_0))
			{
				return (Enum4)int_0;
			}
			return Enum4.const_0;
		}
		set
		{
			int_0 = (int)value;
		}
	}

	[IgnoreDataMember]
	public Color Color_0
	{
		get
		{
			return ColorTranslator.FromHtml(string_0);
		}
		set
		{
			string_0 = ColorTranslator.ToHtml(value);
		}
	}

	[IgnoreDataMember]
	public Color Color_1
	{
		get
		{
			return ColorTranslator.FromHtml(string_1);
		}
		set
		{
			string_1 = ColorTranslator.ToHtml(value);
		}
	}

	[IgnoreDataMember]
	public Color Color_2
	{
		get
		{
			return ColorTranslator.FromHtml(string_2);
		}
		set
		{
			string_2 = ColorTranslator.ToHtml(value);
		}
	}

	public Class14()
	{
		while (true)
		{
			int num = -889608479;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -90773318)) % 5)
				{
				case 4u:
					injectorScrambleOptions_0 = new InjectorScrambleOptions();
					num = ((int)num2 * -1500403465) ^ -1349992961;
					continue;
				case 3u:
					Color_0 = Color.DodgerBlue;
					Color_1 = Color.DeepSkyBlue;
					num = (int)((num2 * 1134537874) ^ 0x7B76ACFF);
					continue;
				case 0u:
					Color_2 = Color.White;
					class13_0 = new Class13();
					num = ((int)num2 * -121073302) ^ 0x555FB6BD;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
