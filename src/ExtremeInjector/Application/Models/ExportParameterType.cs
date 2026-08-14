using System.Runtime.Serialization;

[DataContract(Namespace = "")]
public enum ExportParameterType
{
	[EnumMember(Value = "LPCSTR")]
	AnsiString,
	[EnumMember(Value = "LPCWSTR")]
	UnicodeString,
	[EnumMember(Value = "BYTE")]
	Byte,
	[EnumMember(Value = "WORD")]
	UInt16,
	[EnumMember(Value = "DWORD")]
	UInt32,
	[EnumMember(Value = "QWORD")]
	UInt64,
	[EnumMember(Value = "FLOAT")]
	Single
}
