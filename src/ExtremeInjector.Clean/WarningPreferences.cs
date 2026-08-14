using System.Runtime.Serialization;

[DataContract(Name = "WarningPreferences", Namespace = "")]
public sealed class WarningPreferences
{
	[DataMember(Name = "LdrpLoadDll")]
	public bool LdrpLoadDllAcknowledged { get; set; }

	[DataMember(Name = "ManualMap")]
	public bool ManualMapAcknowledged { get; set; }

	[DataMember(Name = "Scramble")]
	public bool ScrambleAcknowledged { get; set; }
}
