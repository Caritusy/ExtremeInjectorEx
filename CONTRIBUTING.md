# Contributing to Extreme Injector Ex

Thank you for helping maintain Extreme Injector Ex. Contributions must improve authorized development, compatibility testing, reliability, documentation, or maintainability. Do not submit features whose primary purpose is bypassing security controls or concealing unauthorized activity.

## Before starting

- Read [ARCHITECTURE.md](./ARCHITECTURE.md) and [docs/COMPATIBILITY.md](./docs/COMPATIBILITY.md).
- Search existing issues and pull requests.
- Open an issue before a large architectural change, runtime migration, new injection backend, or compatibility-breaking settings change.
- Never include third-party binaries, credentials, private symbols, or data that you are not permitted to redistribute.

## Build and test

Requirements are listed in [README.md](./README.md). Run the repository build entry point from Windows PowerShell:

```powershell
.\build.ps1 -Platform AnyCPU -Configuration Release
```

The command restores dependencies, builds the application, runs automated tests, verifies English and Simplified Chinese CLI startup, and prints the artifact SHA-256.

Architecture-only checks use:

```powershell
.\build.ps1 -Platform x86 -Configuration Release -SkipTests
.\build.ps1 -Platform x64 -Configuration Release -SkipTests
```

## Change expectations

- Keep `Program.Main` and application hosts limited to composition and dispatch.
- Put process, injection, PE, persistence, and platform behavior in focused services.
- Do not add recovered control-flow obfuscation, numbered APIs, or flattened state machines to maintained source.
- Add or update tests for behavior that can be validated without injecting into an unrelated process.
- Changes to Manual Map or another injection backend must describe a controlled integration-test fixture and the x86/x64 impact.
- Keep English and Simplified Chinese resource keys identical and provide reviewed text for both languages.
- Preserve the portable single-executable runtime contract unless the change explicitly documents a migration.
- Do not introduce reflection or dynamic code into ordinary application paths when a typed boundary is practical.

## Pull requests

A pull request should explain:

1. What changed and why.
2. User-visible and compatibility impact.
3. Validation performed.
4. Risks to PE parsing, remote process operations, settings, or packaging.
5. Any behavior that still requires manual verification.

Keep unrelated cleanup in separate commits or pull requests. CI must pass before merge.

## Security reports

Follow [SECURITY.md](./SECURITY.md). Do not disclose a suspected vulnerability in a public issue.

## Licensing status

The repository's licensing and recovered-source provenance are still under review. Submitting a contribution does not grant permission to redistribute existing repository code. Contributors must have the right to submit their work, and maintainers may defer substantive external code until the project license is resolved.
