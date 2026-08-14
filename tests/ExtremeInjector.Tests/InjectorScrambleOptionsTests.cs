using ExtremeInjector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtremeInjector.Tests;

[TestClass]
public sealed class InjectorScrambleOptionsTests
{
	[TestMethod]
	[DataRow(ScramblePreset.None)]
	[DataRow(ScramblePreset.Basic)]
	[DataRow(ScramblePreset.Standard)]
	[DataRow(ScramblePreset.Extreme)]
	public void PresetsRoundTrip(ScramblePreset preset)
	{
		var options = new InjectorScrambleOptions();

		options.ApplyPreset(preset);

		Assert.AreEqual(preset, options.Detect());
	}

	[TestMethod]
	public void IndependentOptionProducesCustomPreset()
	{
		var options = new InjectorScrambleOptions
		{
			RenameSections = true
		};

		Assert.AreEqual(ScramblePreset.Custom, options.Detect());
	}
}
