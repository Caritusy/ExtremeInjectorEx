using System.Runtime.Serialization;

[DataContract(Name = "ExportParameter", Namespace = "")]
public sealed class ExportParameter
{
	[DataMember(Name = "Type")]
	public Enum5 Type { get; set; }

	[DataMember(Name = "Value")]
	public string Value { get; set; }
}
