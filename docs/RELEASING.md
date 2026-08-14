# Release Process

Releases are generated from signed-off commits on `main`. The version is stored in `version` and must match `AssemblyVersion` and `AssemblyFileVersion` in `src/ExtremeInjector/Properties/AssemblyInfo.cs`.

## Before tagging

1. Update `version`, assembly versions, and `CHANGELOG.md`.
2. Run the complete local gate:

   ```powershell
   .\build.ps1 -Platform AnyCPU -Configuration Release
   .\build.ps1 -Platform x86 -Configuration Release -SkipTests
   .\build.ps1 -Platform x64 -Configuration Release -SkipTests
   ```

3. Confirm `main` is clean and synchronized with `origin/main`.
4. Confirm all CI checks pass.

## Tagging

Create an annotated `v<version>` tag. For example:

```powershell
git tag -a v3.7.5 -m 'Extreme Injector Ex 3.7.5'
git push origin v3.7.5
```

The CI workflow then:

1. Verifies the tag matches the `version` file.
2. Builds and tests AnyCPU, x86, and x64 configurations.
3. Runs English and Simplified Chinese CLI smoke tests.
4. Renames the portable executable with the release version.
5. Generates a SHA-256 checksum file.
6. Creates a GitHub build-provenance attestation.
7. Creates or updates the GitHub Release.

Do not replace a published binary with a different build under the same version. Publish a new patch version instead.
