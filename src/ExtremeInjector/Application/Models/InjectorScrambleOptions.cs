using System;
using System.Runtime.Serialization;

namespace ExtremeInjector;

[DataContract(Namespace = "")]
public sealed class InjectorScrambleOptions
{
	private sealed class OptionBinding
	{
		internal ScramblePreset MinimumPreset { get; }
		internal Func<InjectorScrambleOptions, bool> Read { get; }
		internal Action<InjectorScrambleOptions, bool> Write { get; }

		internal OptionBinding(
			ScramblePreset minimumPreset,
			Func<InjectorScrambleOptions, bool> read,
			Action<InjectorScrambleOptions, bool> write)
		{
			MinimumPreset = minimumPreset;
			Read = read;
			Write = write;
		}
	}

	private static readonly OptionBinding[] OptionBindings =
	{
		new OptionBinding(ScramblePreset.Basic, options => options.ScrambleHeaderFields, (options, value) => options.ScrambleHeaderFields = value),
		new OptionBinding(ScramblePreset.Basic, options => options.RemoveUselessData, (options, value) => options.RemoveUselessData = value),
		new OptionBinding(ScramblePreset.Extreme, options => options.InsertExtraSections, (options, value) => options.InsertExtraSections = value),
		new OptionBinding(ScramblePreset.Standard, options => options.ShiftSectionData, (options, value) => options.ShiftSectionData = value),
		new OptionBinding(ScramblePreset.Standard, options => options.ModifyAssemblyCode, (options, value) => options.ModifyAssemblyCode = value),
		new OptionBinding(ScramblePreset.Standard, options => options.RenameSections, (options, value) => options.RenameSections = value),
		new OptionBinding(ScramblePreset.Extreme, options => options.CreateNewEntryPoint, (options, value) => options.CreateNewEntryPoint = value),
		new OptionBinding(ScramblePreset.Basic, options => options.ModifyImportTable, (options, value) => options.ModifyImportTable = value),
		new OptionBinding(ScramblePreset.Basic, options => options.RemoveDebugData, (options, value) => options.RemoveDebugData = value),
		new OptionBinding(ScramblePreset.Extreme, options => options.MoveRelocationTable, (options, value) => options.MoveRelocationTable = value),
		new OptionBinding(ScramblePreset.Extreme, options => options.CreateFakeDebugDirectory, (options, value) => options.CreateFakeDebugDirectory = value),
		new OptionBinding(ScramblePreset.Extreme, options => options.StripSectionCharacteristics, (options, value) => options.StripSectionCharacteristics = value),
		new OptionBinding(ScramblePreset.Extreme, options => options.ShiftSectionMemory, (options, value) => options.ShiftSectionMemory = value)
	};

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

		foreach (OptionBinding option in OptionBindings)
		{
			option.Write(this, preset >= option.MinimumPreset);
		}
	}

	public ScramblePreset Detect()
	{
		bool anyEnabled = false;
		foreach (OptionBinding option in OptionBindings)
		{
			anyEnabled |= option.Read(this);
		}

		if (!anyEnabled)
		{
			return ScramblePreset.None;
		}

		for (var preset = ScramblePreset.Basic; preset <= ScramblePreset.Extreme; preset++)
		{
			bool matches = true;
			foreach (OptionBinding option in OptionBindings)
			{
				if (option.Read(this) != (preset >= option.MinimumPreset))
				{
					matches = false;
					break;
				}
			}

			if (matches)
			{
				return preset;
			}
		}

		return ScramblePreset.Custom;
	}
}
