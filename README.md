# Extreme Injector Ex

[![Version](https://img.shields.io/badge/version-3.7.4-1677c8)](./version)
[![CI](https://github.com/Caritusy/ExtremeInjectorEx/actions/workflows/ci.yml/badge.svg)](https://github.com/Caritusy/ExtremeInjectorEx/actions/workflows/ci.yml)
[![Release](https://img.shields.io/github/v/release/Caritusy/ExtremeInjectorEx)](https://github.com/Caritusy/ExtremeInjectorEx/releases/latest)
![Platform](https://img.shields.io/badge/platform-Windows-0078d4)
![Framework](https://img.shields.io/badge/.NET_Framework-4.8-512bd4)

**English** | [简体中文](./README.zh-CN.md)

Extreme Injector Ex is a maintained evolution of Extreme Injector 3.7.3 for Windows. What began as source recovery is now a structured application with a modern bilingual GUI, a complete command-line interface, hardened injection and PE-processing paths, portable single-file deployment, and source that can be maintained without navigating decompiler control-flow noise.

This repository preserves compatibility where the recovered runtime still matters, but it no longer treats the recovered program layout as the architecture to follow. New work is organized around small application, presentation, injection, PE, localization, and platform services.

> [!WARNING]
> Use this software only with applications that you own or are explicitly authorized to test. Code injection can violate software licenses, security policies, or applicable law when used without permission.

## What the project provides

| Area | Current implementation |
| --- | --- |
| User experience | DPI-aware WinForms GUI, fixed application layouts, English and Simplified Chinese localization, and system-language detection |
| Automation | First-class CLI activated by `-c` or `--cli`, with deterministic exit codes and coverage for all persisted settings |
| Injection | Standard (`LoadLibrary`), thread hijacking, `LdrLoadDll`, `LdrLoadDll Stub`, and Manual Map backends |
| Manual Map | Import and API-set resolution, relocations, TLS callbacks, page-aware memory protection, instruction-cache flushing, and exception-support paths |
| PE processing | PE32/PE32+ headers, imports, exports, relocations, TLS, resources, CLR metadata directories, validation, and optional scrambling |
| Process tooling | Process selection, module snapshots, remote memory access, export invocation, and process inspection |
| Deployment | Runtime package assemblies and localization resources embedded into one movable executable |
| Reliability | Per-user GUI single instance, foreground activation on a second launch, atomic settings writes, and isolated CLI settings files |
| Maintainability | Thin composition root, separated GUI/CLI hosts, semantic type and member names, and structured control flow under `src` |

## Requirements

### To run

- Windows 10 or Windows 11.
- .NET Framework 4.8.
- Administrator privileges for operations that require access to another process.
- A DLL whose architecture matches the target process.

### To build

- Visual Studio 2022 or Build Tools 2022.
- .NET Framework 4.8 Developer Pack.
- .NET 10 SDK (the pinned build toolchain; the application still targets .NET Framework 4.8).

## Build

```powershell
git clone https://github.com/Caritusy/ExtremeInjectorEx.git
Set-Location .\ExtremeInjectorEx
.\build.ps1 -Platform AnyCPU -Configuration Release
```

The build entry point restores dependencies, builds the application, runs automated tests, checks English and Simplified Chinese CLI startup, and prints the executable SHA-256. Architecture-only validation is available with `-Platform x86` and `-Platform x64`; see [CONTRIBUTING.md](./CONTRIBUTING.md).

Release artifacts are written outside the source tree:

```text
out/bin/ExtremeInjector/Release/net48/
```

Intermediate files are written to `out/obj/`. The runtime-distributable artifact is `Extreme Injector.exe`; package dependencies and localization resources are embedded. The generated `.pdb` and `.config` files are not required for ordinary execution.

## Quality and releases

- Pull requests and `main` are validated on Windows through GitHub Actions.
- CI builds AnyCPU, x86, and x64 configurations and runs deterministic tests plus bilingual CLI smoke checks.
- Future `v*` tags must match the repository version, pass all gates, and produce a versioned executable, SHA-256 file, and build-provenance attestation.
- Compatibility claims use the evidence levels in [docs/COMPATIBILITY.md](./docs/COMPATIBILITY.md); a successful build is not presented as proof of every injection backend.
- Security-sensitive reports follow [SECURITY.md](./SECURITY.md), while release maintainers follow [docs/RELEASING.md](./docs/RELEASING.md).

## GUI usage

Start `Extreme Injector.exe` without CLI arguments:

1. Select the target process.
2. Add one or more DLLs.
3. Choose an injection method and optional behavior in **Settings**.
4. Select **Inject**.

The GUI is single-instance for each Windows user. Launching it again restores and foregrounds the existing window, which prevents concurrent writes to the same settings file. Window-title randomization is enabled by default and can be disabled in Settings.

The interface follows the Windows display language by default. English and Simplified Chinese can also be selected explicitly, and the change is applied immediately.

## Command-line usage

CLI mode is enabled only when `-c` or `--cli` is present. Ask the current build for its authoritative option list:

```powershell
& '.\Extreme Injector.exe' --cli --help
```

### Select by PID

```powershell
& '.\Extreme Injector.exe' --cli `
  --pid 1234 `
  --dll 'D:\Modules\Example.dll' `
  --method standard
```

### Wait for a named process and use Manual Map

```powershell
& '.\Extreme Injector.exe' -c `
  --process Game.exe `
  --auto-inject `
  --wait-timeout 60 `
  --dll 'D:\Modules\Example.dll' `
  --method manual-map
```

Process names may include or omit `.exe`. A name must identify exactly one running process. If several processes match, the command exits with code `3` and prints candidates in this form:

```text
[0] Window title (1234)
[1] Another window (5678)
```

Run the command again with the intended PID; the program never guesses between matching processes.

### Multiple DLLs and exported routines

Repeat `--dll` to add modules. Export options apply to the most recently declared DLL:

```powershell
& '.\Extreme Injector.exe' --cli --pid 1234 `
  --dll 'D:\Modules\First.dll' `
  --export Initialize `
  --calling-convention stdcall `
  --arg uint32:1 `
  --dll 'D:\Modules\Second.dll'
```

Calling conventions are `stdcall`, `fastcall`, and `cdecl`. Export argument types are `ansi`, `unicode`, `byte`, `uint16`, `uint32`, `uint64`, and `float`.

### Settings and non-interactive configuration

CLI switches cover injection behavior, Manual Map options, scrambling, delays, localization, interface colors, warning acknowledgements, title randomization, and the saved DLL list. Changes are in-memory for the current invocation unless `--save-settings` is supplied.

Use a separate settings file for scripts or isolated workflows:

```powershell
& '.\Extreme Injector.exe' --cli `
  --settings '.\automation.xml' `
  --reset-settings `
  --language en `
  --no-random-title `
  --save-settings
```

CLI injection can run while the GUI is open. A CLI command that writes the shared settings file uses the same per-user lock and exits with code `7` if another instance owns it.

### Exit codes

| Code | Meaning |
| ---: | --- |
| `0` | Completed successfully |
| `1` | Invalid command-line arguments |
| `2` | Target process not found or wait timed out |
| `3` | Process name matched multiple targets |
| `4` | Missing, invalid, or disabled DLL input |
| `5` | Administrator privileges required |
| `6` | Injection or an unexpected runtime operation failed |
| `7` | Settings are owned by another instance |
| `8` | Process waiting was canceled |

## Settings and localization

The default settings file is:

```text
%AppData%\ExtremeInjectorEx\settings.xml
```

Settings are written through a temporary file and atomically replaced. A legacy `settings.xml` beside the executable is migrated to the per-user location when no current settings file exists.

Application-owned GUI and CLI text is stored in matching resource sets:

```text
res/Localization/Strings.en.resx
res/Localization/Strings.zh-CN.resx
```

External values such as process names, paths, DLL names, export names, window titles, and operating-system error details are intentionally left unchanged.

## Architecture

```text
Program
  -> ApplicationHost
      -> GuiApplication / CliApplication
          -> presentation models and coordinators
              -> injection, PE, settings, localization, and platform services
                  -> Win32 interop and recovered compatibility adapters
```

The repository is organized by responsibility:

```text
src/ExtremeInjector/
  Application/          composition, GUI/CLI hosts, settings, and application models
  Assembly/             AsmJit and BeaEngine integration
  Collections/          internal collection implementations
  Compression/          embedded-resource decompression
  Injection/            injection backends, Manual Map, and remote-process services
  Interop/              Win32 contracts and native structures
  Localization/         culture selection and localized text access
  PortableExecutable/   PE models, readers, writers, and transformations
  Runtime/              startup support and recovered compatibility adapters
  UI/                   WinForms views and reusable controls
  Utilities/            focused shared helpers
res/                    application, form, embedded, and localization resources
tests/                  deterministic unit and parser regression tests
docs/                   compatibility and release-maintenance guides
.github/                CI, dependency updates, and contribution templates
out/                    local build output; never committed
```

See [ARCHITECTURE.md](./ARCHITECTURE.md) before changing startup, injection, Manual Map, PE parsing, or recovered compatibility code. `Program.Main` remains a composition root; forms remain views; injection and system behavior belong in focused services.

## Development status

- Recovered control-flow obfuscation and decompiler-generated `goto` graphs have been removed from maintained source.
- Numbered recovered types and ordinary members have been restored to semantic names. Binary-stub data and compatibility adapters remain specialized migration areas and should be changed only with a focused regression path.
- Normal application paths use typed construction. The compatibility runtime still uses dynamic IL, assembly loading, and metadata-token resolution where the original behavior requires them.
- Because of that runtime chain, trimming, NativeAOT, and WinFormsComInterop are not drop-in migrations. They require replacement of the dynamic compatibility layer and separate interop validation first.
- Settings, localization resources, scrambling presets, and PE parsing now have an initial automated regression suite; controlled injection fixtures remain the next validation milestone.
- `build.ps1` is shared by local development and CI. Changes to injection, PE parsing, embedded dependencies, settings, or localization must pass that gate.
- Project changes are recorded in [CHANGELOG.md](./CHANGELOG.md); contribution rules are in [CONTRIBUTING.md](./CONTRIBUTING.md).

## Project history

Extreme Injector was originally created by **master131**. Extreme Injector Ex 3.7.4 began from recoverable 3.7.3 program source and has since been reorganized and substantially rewritten for maintainability. It does not claim to reproduce lost private source, original identifiers, comments, or the original project structure.

## License

This repository currently has no standalone license file. Do not assume redistribution or reuse rights beyond those granted by the original project and individual contributors. Establish the applicable license terms before distributing derived builds.
