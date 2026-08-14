using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace ExtremeInjector;

[DataContract(Namespace = "")]
public sealed class InjectorScrambleOptions
{
	[DataMember(Name = "ScrambleHeaderFields")]
	[ScramblePreset(ScramblePreset.Basic)]
	public bool ScrambleHeaderFields;

	[DataMember(Name = "RemoveUselessData")]
	[ScramblePreset(ScramblePreset.Basic)]
	public bool RemoveUselessData;

	[DataMember(Name = "InsertExtraSections")]
	[ScramblePreset(ScramblePreset.Extreme)]
	public bool InsertExtraSections;

	[DataMember(Name = "ShiftSectionData")]
	[ScramblePreset(ScramblePreset.Standard)]
	public bool ShiftSectionData;

	[DataMember(Name = "ModifyAssemblyCode")]
	[ScramblePreset(ScramblePreset.Standard)]
	public bool ModifyAssemblyCode;

	[DataMember(Name = "RenameSections")]
	[ScramblePreset(ScramblePreset.Standard)]
	public bool RenameSections;

	[DataMember(Name = "CreateNewEntryPoint")]
	[ScramblePreset(ScramblePreset.Extreme)]
	public bool CreateNewEntryPoint;

	[DataMember(Name = "ModifyImportTable")]
	[ScramblePreset(ScramblePreset.Basic)]
	public bool ModifyImportTable;

	[DataMember(Name = "RemoveDebugData")]
	[ScramblePreset(ScramblePreset.Basic)]
	public bool RemoveDebugData;

	[DataMember(Name = "MoveRelocationTable")]
	[ScramblePreset(ScramblePreset.Extreme)]
	public bool MoveRelocationTable;

	[DataMember(Name = "CreateFakeDebugDirectory")]
	[ScramblePreset(ScramblePreset.Extreme)]
	public bool CreateFakeDebugDirectory;

	[DataMember(Name = "StripSectionCharacteristics")]
	[ScramblePreset(ScramblePreset.Extreme)]
	public bool StripSectionCharacteristics;

	[DataMember(Name = "ShiftSectionMemory")]
	[ScramblePreset(ScramblePreset.Extreme)]
	public bool ShiftSectionMemory;

	public void ApplyPreset(ScramblePreset preset)
	{
		if (preset == ScramblePreset.Custom)
		{
			return;
		}

		foreach (var option in GetOptionFields())
		{
			var minimum = option.GetCustomAttribute<ScramblePresetAttribute>().MinimumPreset;
			option.SetValue(this, preset >= minimum);
		}
	}

	public ScramblePreset Detect()
	{
		var options = GetOptionFields();
		if (options.All(option => !(bool)option.GetValue(this)))
		{
			return ScramblePreset.None;
		}

		for (var preset = ScramblePreset.Basic; preset <= ScramblePreset.Extreme; preset++)
		{
			var matches = options.All(option =>
			{
				var minimum = option.GetCustomAttribute<ScramblePresetAttribute>().MinimumPreset;
				return (bool)option.GetValue(this) == (preset >= minimum);
			});
			if (matches)
			{
				return preset;
			}
		}

		return ScramblePreset.Custom;
	}

	private static FieldInfo[] GetOptionFields()
	{
		return typeof(InjectorScrambleOptions)
			.GetFields(BindingFlags.Instance | BindingFlags.Public)
			.Where(field => field.GetCustomAttribute<ScramblePresetAttribute>() != null)
			.ToArray();
	}
}
