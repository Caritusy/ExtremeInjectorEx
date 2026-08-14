using System.Runtime.Serialization;

[DataContract(Name = "ExportParameter", Namespace = "")]
public sealed class ExportParameter
{
	[DataMember(Name = "Type")]
	public ExportParameterType Type { get; set; }

	[DataMember(Name = "Value")]
	public string Value { get; set; }
}
