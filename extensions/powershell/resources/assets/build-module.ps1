param([switch]$Isolated, [switch]$Run, [switch]$Test, [switch]$Docs, [switch]$Pack, [switch]$Code, [switch]$Release)
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

  if($Pack) {
    . (Join-Path $PSScriptRoot 'pack-module.ps1')
    if($LastExitCode -ne 0) {
      # Packing failed. Don't attempt to run the module.
      return
    }
  }

  $runModuleRelative = '${$lib.path.relative($project.baseFolder, `run-module.ps1`)}'
  $runModulePath = Join-Path $PSScriptRoot $runModuleRelative
  if($Code) {
    . $runModulePath -Code
  } elseif($Run) {
    . $runModulePath
  } else {
    Write-Host -ForegroundColor Cyan "To run this module in an isolated PowerShell session, run '$runModuleRelative' or provide the '-Run' parameter to this script."
  }
  return
}

Write-Host -ForegroundColor Green 'Cleaning build folders...'
$binFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.binFolder)}'
$objFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.objFolder)}'
$null = Remove-Item -Recurse -ErrorAction SilentlyContinue -Path $binFolder, $objFolder

if((Test-Path $binFolder) -or (Test-Path $objFolder)) {
  Write-Host -ForegroundColor Cyan 'Did you forget to exit your isolated module session before rebuilding?'
  Write-Error 'Unable to clean ''bin'' or ''obj'' folder. A process may have an open handle.'
}

Write-Host -ForegroundColor Green 'Compiling module...'
$buildConfig = 'Debug'
if($Release) {
  $buildConfig = 'Release'
}
dotnet publish $PSScriptRoot --verbosity quiet --configuration $buildConfig /nologo
if($LastExitCode -ne 0) {
  Write-Error 'Compilation failed.'
}

$null = Remove-Item -Recurse -ErrorAction SilentlyContinue -Path (Join-Path $binFolder 'Debug'), (Join-Path $binFolder 'Release')
$dll = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dll)}'

if(-not (Test-Path $dll)) {
  Write-Error "Unable to find output assembly in '$binFolder'."
}

# Load DLL to use build-time cmdlets
$null = Import-Module -Name $dll

$modulePaths = $dll
$customPsm1 = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.psm1Custom)}'
if(Test-Path $customPsm1) {
  $modulePaths = @($dll, $customPsm1)
}

$exportsFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.exportsFolder)}'
if(Test-Path $exportsFolder) {
  $null = Get-ChildItem -Path $exportsFolder -Recurse -Exclude 'readme.md' | Remove-Item -Recurse -ErrorAction SilentlyContinue
}
$null = New-Item -ItemType Directory -Force -Path $exportsFolder

$internalFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.internalFolder)}'
if(Test-Path $internalFolder) {
  $null = Get-ChildItem -Path $internalFolder -Recurse -Exclude '*.psm1', 'readme.md' | Remove-Item -Recurse -ErrorAction SilentlyContinue
}
$null = New-Item -ItemType Directory -Force -Path $internalFolder

Export-ProxyCmdlet -ModulePath $modulePaths -ExportsFolder $exportsFolder -InternalFolder $internalFolder

$testFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.testFolder)}'
$null = New-Item -ItemType Directory -Force -Path $testFolder
Export-TestStub -ModulePath $modulePaths -OutputFolder $testFolder

$psd1 = Join-Path $PSScriptRoot '${$project.psd1}'
Set-Psd1Export -ExportsFolder $exportsFolder -Psd1Path $psd1

Write-Host -ForegroundColor Green '-------------Done-------------'