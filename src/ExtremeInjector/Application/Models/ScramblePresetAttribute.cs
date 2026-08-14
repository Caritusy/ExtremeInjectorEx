using System;

[AttributeUsage(AttributeTargets.Field)]
public sealed class ScramblePresetAttribute : Attribute
{
	public ScramblePreset MinimumPreset { get; }

	public ScramblePresetAttribute(ScramblePreset minimumPreset)
	{
		MinimumPreset = minimumPreset;
	}
}
