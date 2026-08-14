using System.Runtime.Serialization;

[DataContract(Name = "AdvancedInjectionOptions", Namespace = "")]
public sealed class AdvancedInjectionOptions
{
	[DataMember(Name = "HideFromDebugger")]
	public bool HideFromDebugger { get; set; }

	[DataMember(Name = "ManualResolveImports")]
	public bool ManualResolveImports { get; set; }

	[DataMember(Name = "DisableExceptionSupport")]
	public bool DisableExceptionSupport { get; set; }

	[DataMember(Name = "DisableSEHValidation")]
	public bool DisableSehValidation { get; set; }
}
