using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

[DataContract(Namespace = "")]
internal sealed class Class16
{
	[DataMember(Name = "Path")]
	public string string_0;

	[DataMember(Name = "Enable")]
	public bool bool_0;

	[DataMember(Name = "Export")]
	public string string_1;

	[DataMember(Name = "CallingConvention", EmitDefaultValue = false)]
	public CallingConvention callingConvention_0;

	[DataMember(Name = "Parameters")]
	public List<Class17> list_0;
}
