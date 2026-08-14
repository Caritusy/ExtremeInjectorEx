# Extreme Injector 3.7.3 recovered source

This directory contains a buildable source recovery of the supplied Extreme Injector executable. The recovery was performed by static analysis only; the original executable was not launched.

## Current status

- Target: .NET Framework 4.8 Windows Forms application
- Recovered source: 217 C# files and 8 WinForms `.resx` files
- Recovered resources: application icon, manifest, managed resources, and embedded binary resources
- Build status: succeeds with 0 errors
- Detected protector: Goliath .NET Obfuscator 2.2.0
- Babel, Dotfuscator, and Xenocode strings in the assembly are decoy markers, not the active protector

Open `ExtremeInjector.Recovered.sln` in Visual Studio 2022, or build from a Developer PowerShell:

```powershell
dotnet restore .\ExtremeInjector.Recovered.sln
dotnet build .\ExtremeInjector.Recovered.sln -c Release
```

The recovered application project is:

```text
src\ExtremeInjector.KeepInlined\ExtremeInjector-3.7.3.keep-inlined.normalized.csproj
```

## Recovery layout

- `src\ExtremeInjector.KeepInlined`: selected, repaired, buildable C# source tree
- `artifacts\original`: byte-for-byte preserved input and extracted embedded assemblies
- `artifacts\deobfuscated`: de4dot variants and normalized managed assemblies
- `tools\MetadataNormalizer`: reproducible dnlib metadata repair tool
- `analysis`: compiler logs retained during recovery

The preserved original has this SHA-256 hash:

```text
B65F40618F584303CA0BCF9B5F88C233CC4237699C0C4BF40BA8FACBE8195A46
```

The selected normalized assembly is:

```text
artifacts\deobfuscated\ExtremeInjector-3.7.3.keep-inlined.normalized.dll
```

## What was repaired

The metadata normalizer removes fake obfuscator attributes and invalid `MethodImpl` mappings, restores usable member visibility, and assigns stable names to invalid virtual methods and their overrides. The keep-inlined de4dot variant was selected because it preserved required definitions while producing fewer invalid decompiler constructs than the other variants.

Several pointer-heavy methods were decompiled into illegal C# because control-flow jumps crossed pinned regions. Their raw ILSpy bodies remain in the source under `#if false`, while equivalent readable implementations are active for byte-pattern search, masked-pattern search, array marshalling, and process-memory stream reads/writes. This keeps the recovery evidence without preventing compilation.

## Recovery limits

This is not the exact original project. Obfuscation permanently removed original private type/member names, comments, local names, formatting, and the original solution layout. Names such as `Class171` are stable recovered names, not the authors' original identifiers. Optimized implementations reconstructed from behavior may also differ structurally from the original source while preserving the observed contract.

The rebuilt executable is a recovered development artifact, not a byte-identical reproduction of the supplied executable. Runtime behavior has not been exercised as part of this static recovery.
