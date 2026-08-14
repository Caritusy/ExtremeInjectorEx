[CmdletBinding()]
param(
	[ValidateSet('AnyCPU', 'x86', 'x64')]
	[string]$Platform = 'AnyCPU',

	[ValidateSet('Debug', 'Release')]
	[string]$Configuration = 'Release',

	[switch]$NoRestore,
	[switch]$SkipTests
)

$ErrorActionPreference = 'Stop'
$repositoryRoot = $PSScriptRoot
$solution = Join-Path $repositoryRoot 'ExtremeInjectorEx.sln'
$applicationProject = Join-Path $repositoryRoot 'src\ExtremeInjector\ExtremeInjector.csproj'
$testProject = Join-Path $repositoryRoot 'tests\ExtremeInjector.Tests\ExtremeInjector.Tests.csproj'
$executable = Join-Path $repositoryRoot "out\bin\ExtremeInjector\$Configuration\net48\Extreme Injector.exe"
$version = (Get-Content -LiteralPath (Join-Path $repositoryRoot 'version') -Raw).Trim()
$assemblyInfo = Get-Content -LiteralPath (Join-Path $repositoryRoot 'src\ExtremeInjector\Properties\AssemblyInfo.cs') -Raw

if ($assemblyInfo -notmatch [regex]::Escape("AssemblyFileVersion(`"$version.0`")") -or
	$assemblyInfo -notmatch [regex]::Escape("AssemblyVersion(`"$version.0`")")) {
	throw "The version file ($version) and AssemblyInfo.cs are inconsistent."
}

Push-Location $repositoryRoot
try {
	if (-not $NoRestore) {
		& dotnet restore $solution
		if ($LASTEXITCODE -ne 0) {
			throw "Dependency restore failed with exit code $LASTEXITCODE."
		}

		# The .NET SDK derives win-x86/win-x64 assets from PlatformTarget for
		# architecture-specific builds, so restore that target explicitly.
		if ($Platform -ne 'AnyCPU') {
			& dotnet restore $applicationProject "-p:PlatformTarget=$Platform"
			if ($LASTEXITCODE -ne 0) {
				throw "Architecture-specific restore failed with exit code $LASTEXITCODE."
			}
		}
	}

	# Rebuild avoids reusing an executable compiled for a different PlatformTarget
	# because all three targets intentionally share the portable output directory.
	& dotnet build $applicationProject -c $Configuration -t:Rebuild --no-restore "-p:PlatformTarget=$Platform"
	if ($LASTEXITCODE -ne 0) {
		throw "Application build failed with exit code $LASTEXITCODE."
	}

	if (-not $SkipTests) {
		if ($Platform -ne 'AnyCPU') {
			throw 'Tests must run with the AnyCPU platform. Use -SkipTests for architecture-only builds.'
		}

		& dotnet test $testProject -c $Configuration --no-restore
		if ($LASTEXITCODE -ne 0) {
			throw "Tests failed with exit code $LASTEXITCODE."
		}
	}

	if (-not (Test-Path -LiteralPath $executable)) {
		throw "Expected executable was not produced: $executable"
	}

	foreach ($language in @('en', 'zh-CN')) {
		& $executable --cli --language $language --help *> $null
		if ($LASTEXITCODE -ne 0) {
			throw "CLI smoke test failed for language '$language' with exit code $LASTEXITCODE."
		}
	}

	$artifact = Get-Item -LiteralPath $executable
	$digest = Get-FileHash -LiteralPath $executable -Algorithm SHA256
	Write-Host "Build completed: $($artifact.FullName)"
	Write-Host "Version: $version"
	Write-Host "Platform: $Platform"
	Write-Host "Size: $($artifact.Length) bytes"
	Write-Host "SHA-256: $($digest.Hash)"
}
finally {
	Pop-Location
}
