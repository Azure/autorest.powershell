param([Switch]$Isolated, [Switch]$Run, [Switch]$Test, [Switch]$Docs, [Switch]$Code, [Switch]$Release)
$ErrorActionPreference = 'Stop'

if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated

  if($LastExitCode -ne 0) {
    # Build failed. Don't attempt to run the module.
    return
  }

  if($Test) {
    . (Join-Path $PSScriptRoot 'test-module.ps1')
    if($LastExitCode -ne 0) {
      # Tests failed. Don't attempt to run the module.
      return
    }
  }

  if($Docs) {
    . (Join-Path $PSScriptRoot 'generate-help.ps1')
    if($LastExitCode -ne 0) {
      # Docs generation failed. Don't attempt to run the module.
      return
    }
  }

  if($Code) {
    . (Join-Path $PSScriptRoot 'run-module.ps1') -Code
  } elseif($Run) {
    . (Join-Path $PSScriptRoot 'run-module.ps1')
  } else {
    Write-Host -ForegroundColor Cyan 'To run this module in an isolated PowerShell session, run ''./run-module.ps1'' or provide the ''-Run'' parameter to this script.'
  }
  return
}

Write-Host -ForegroundColor Green 'Cleaning build folders...'
$binFolder = (Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.binFolder)}')
$objFolder = (Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.objFolder)}')
$null = Remove-Item -Recurse -ErrorAction SilentlyContinue -Path $binFolder, $objFolder
$exportPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.exportsFolder)}'
$null = Get-ChildItem -Path $exportPath -Recurse -Exclude 'readme.md' | Remove-Item -Recurse -ErrorAction SilentlyContinue

if((Test-Path $binFolder) -or (Test-Path $objFolder)) {
  Write-Error 'Unable to clean ''bin'' or ''obj'' folder. A process may have an open handle.'
}

Write-Host -ForegroundColor Green 'Compiling module...'
$buildConfig = 'Debug'
if($Release) {
  $buildConfig = 'Release'
}
dotnet publish $PSScriptRoot --verbosity quiet --configuration $buildConfig --output $binFolder /nologo
if($LastExitCode -ne 0) {
  Write-Error 'Compilation failed.'
}

$null = Remove-Item -Recurse -ErrorAction SilentlyContinue -Path (Join-Path $binFolder 'Debug'), (Join-Path $binFolder 'Release')
$dll = Get-Item -Path (Join-Path $binFolder '*.private.dll') | Select-Object -First 1

if(-not (Test-Path $dll)) {
  Write-Error "Unable to find output assembly in '$binFolder'."
}

$commands = Get-Command -Module (Import-Module $dll -PassThru)
Write-Host -ForegroundColor Green "Module DLL Loaded [$dll]"

$customFolder = (Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.customFolder)}')
$customPsm1 = Get-Item -Path (Join-Path $customFolder '*.custom.psm1') | Select-Object -First 1
if(Test-Path $customPsm1) {
  $commands += Get-Command -Module (Import-Module $customPsm1 -PassThru)
  Write-Host -ForegroundColor Green "Custom PSM1 Loaded [$customPsm1]"
}

if(($commands | Measure-Object).Count -eq 0) {
  Write-Error 'Unable to locate any cmdlets.'
}

$commands = $commands | Where-Object { $_.Name -ne 'New-ProxyCmdlet' -and $_.Name -ne 'New-TestStub'}

$null = New-Item -ItemType Directory -Force -Path $exportPath
New-ProxyCmdlet -CommandInfo $commands -OutputFolder $exportPath

$testPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.testFolder)}'
$null = New-Item -ItemType Directory -Force -Path $testPath
New-TestStub -CommandInfo $commands -OutputFolder $testPath

Write-Host -ForegroundColor Green '-------------Done-------------'