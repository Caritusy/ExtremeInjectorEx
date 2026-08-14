using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

[DataContract(Name = "ModuleEntry", Namespace = "")]
public sealed class ModuleEntry
{
	[DataMember(Name = "Path")]
	public string Path { get; set; }

	[DataMember(Name = "Enable")]
	public bool Enabled { get; set; }

	[DataMember(Name = "Export")]
	public string ExportName { get; set; }

	[DataMember(Name = "CallingConvention", EmitDefaultValue = false)]
	public CallingConvention CallingConvention { get; set; }

	[DataMember(Name = "Parameters")]
	public List<ExportParameter> Parameters { get; set; }
}
