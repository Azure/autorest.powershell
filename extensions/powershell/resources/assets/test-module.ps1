param([switch]$Isolated)
$ErrorActionPreference = 'Stop'

if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

. (Join-Path $PSScriptRoot 'check-dependencies.ps1') -Isolated -Accounts:$${$project.azure} -Pester

$localModulesPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dependencyModuleFolder)}'
if(Test-Path -Path $localModulesPath) {
  $env:PSModulePath = "$localModulesPath$([IO.Path]::PathSeparator)$env:PSModulePath"
}

$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot '${$project.psd1}')
$modulePath = $modulePsd1.FullName
$moduleName = $modulePsd1.BaseName

Import-Module -Name Pester
Import-Module -Name $modulePath

$testFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.testFolder)}'
Invoke-Pester -Script @{ Path = $testFolder } -EnableExit -OutputFile (Join-Path $testFolder "$moduleName-TestResults.xml")