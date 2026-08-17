using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtremeInjector.Tests;

[TestClass]
public sealed class RemoteExecutionSafetyTests
{
	[TestMethod]
	public void PointerResultsPreserveTheFullX64Value()
	{
		IntPtr value = RemoteCodeExecutorBase.NormalizeRemoteIntPtr(
			targetIs32Bit: false,
			lowValue: 0,
			pointerValue: new IntPtr(unchecked((long)0x1234567887654321UL)));

		Assert.AreEqual(unchecked((long)0x1234567887654321UL), value.ToInt64());
	}

	[TestMethod]
	public void PointerResultsUseTheUnsignedLowWordForX86()
	{
		IntPtr value = RemoteCodeExecutorBase.NormalizeRemoteIntPtr(
			targetIs32Bit: true,
			lowValue: 0xfedcba98,
			pointerValue: IntPtr.Zero);

		Assert.AreEqual(unchecked((long)0xfedcba98u), value.ToInt64());
	}

	[TestMethod]
	public void LdrLoaderRejectsPathsThatCannotFitInUnicodeString()
	{
		var process = new RemoteProcess(1);
		var injector = new LdrLoadDllInjector(process);
		string oversizedPath = new string('x', 32768);

		AssertArgumentException(() => injector.BuildLoaderStub(IntPtr.Zero, oversizedPath, out _, out _));
	}

	[TestMethod]
	public void LdrStubLoaderRejectsPathsThatCannotFitInUnicodeString()
	{
		var process = new RemoteProcess(1);
		var injector = new LdrLoadDllStubInjector(process);
		string oversizedPath = new string('x', 32768);

		AssertArgumentException(() => injector.BuildLoaderStub(IntPtr.Zero, oversizedPath, out _, out _));
	}

	private static void AssertArgumentException(Action action)
	{
		try
		{
			action();
		}
		catch (ArgumentException)
		{
			return;
		}

		Assert.Fail("Expected an ArgumentException.");
	}
}
