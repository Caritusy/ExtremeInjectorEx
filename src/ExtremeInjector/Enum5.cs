using System.Runtime.Serialization;

[DataContract(Namespace = "")]
internal enum Enum5
{
	[EnumMember(Value = "LPCSTR")]
	LPCSTR,
	[EnumMember(Value = "LPCWSTR")]
	LPCWSTR,
	[EnumMember(Value = "BYTE")]
	BYTE,
	[EnumMember(Value = "WORD")]
	WORD,
	[EnumMember(Value = "DWORD")]
	DWORD,
	[EnumMember(Value = "QWORD")]
	QWORD,
	[EnumMember(Value = "FLOAT")]
	FLOAT
}
