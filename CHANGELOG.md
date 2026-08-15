# Changelog

Notable changes to Extreme Injector Ex are documented here.

## [Unreleased]

### Added

- Repository-wide editor and Git line-ending configuration.
- Automated tests for settings persistence, scrambling presets, localization parity, and PE image parsing.
- A shared `build.ps1` entry point with CLI smoke checks and artifact hashing.
- Windows CI for AnyCPU, x86, and x64 builds.
- Automated tag validation, release hashing, and build provenance attestation.
- Dependency update automation, pull request guidance, and issue templates.
- Contribution, security, compatibility, and release-maintenance documentation.

### Changed

- Clean builds are warning-free, and CI treats newly introduced compiler warnings as errors.
- Runtime type-layout and API-set caches now receive deterministic initialization.
- Updated `System.Resources.Extensions` to the current supported release while retaining .NET Framework 4.8 compatibility.
- Pinned the repository build toolchain to the .NET 10 SDK used by CI.
- Pinned GitHub Actions to reviewed immutable revisions and enabled automated action updates.
- Replaced the legacy DotNetZip extraction path with a bounded standard-library implementation that rejects archive path traversal.

### Fixed

- Prevented legacy dialogs from passing a null decoded resource name to `ComponentResourceManager`.
- Rebuilt the process selector with stable resources, localized text, safe empty-selection handling, and flicker-resistant rendering.
- Restored deterministic Windows capability initialization so process discovery and architecture checks no longer fall back to broken legacy paths.
- Integrated module enablement into the DLL-name cell so its checkbox remains visible without a separate narrow column.
- Replaced null decoded choice labels in module options and rebuilt both advanced-settings dialogs with complete localized controls.
- Removed the final live recovered-form initializers by rebuilding the process inspector and dependency installer with localized modern controls.
- Restored localized standalone scrambling, secure-mode, process-action, thread-action, and dependency-installation status paths.

## [3.7.4] - 2026-08-15

### Added

- Modern DPI-aware English and Simplified Chinese GUI.
- Complete `-c` / `--cli` interface with deterministic exit codes.
- Per-user GUI single-instance coordination and atomic settings persistence.
- Portable single-executable deployment with embedded package dependencies and localization.
- Process inspection, multiple-DLL workflows, and exported-routine invocation.

### Changed

- Reorganized recovered source into application, UI, injection, PE, runtime, and platform responsibilities.
- Restored semantic names across recovered types and members.
- Removed recovered control-flow obfuscation and decompiler-generated `goto` graphs.
- Hardened Manual Map module discovery, API-set handling, page protection, instruction-cache flushing, and remote execution timeouts.
- Rewrote English and Simplified Chinese project documentation.

[Unreleased]: https://github.com/Caritusy/ExtremeInjectorEx/compare/v3.7.4...HEAD
[3.7.4]: https://github.com/Caritusy/ExtremeInjectorEx/releases/tag/v3.7.4
