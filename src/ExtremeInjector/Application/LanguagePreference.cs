using System.Runtime.Serialization;

[DataContract(Name = "LanguagePreference", Namespace = "")]
public enum LanguagePreference
{
	[EnumMember]
	System = 0,

	[EnumMember]
	English = 1,

	[EnumMember]
	SimplifiedChinese = 2
}
