param([switch]$Isolated, [switch]$Live, [switch]$Record, [switch]$Playback)
$ErrorActionPreference = 'Stop'

if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

$ProgressPreference = 'SilentlyContinue'
$baseName = $PSScriptRoot.BaseName
$requireResourceModule = (($baseName -ne "Resources") -and ($Record.IsPresent -or $Live.IsPresent))
. (Join-Path $PSScriptRoot 'check-dependencies.ps1') -Isolated -Accounts:$false -Pester -Resources:$requireResourceModule
. ("$PSScriptRoot\test\utils.ps1")

if ($requireResourceModule) {
  $resourceModulePSD = Get-Item -Path (Join-Path $HOME '.PSSharedModules\Resources\Az.Resources.TestSupport.psd1')
  Import-Module -Name $resourceModulePSD.FullName
}

$localModulesPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dependencyModuleFolder)}'
if(Test-Path -Path $localModulesPath) {
  $env:PSModulePath = "$localModulesPath$([IO.Path]::PathSeparator)$env:PSModulePath"
}

$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot '${$project.psd1}')
$modulePath = $modulePsd1.FullName
$moduleName = $modulePsd1.BaseName

Import-Module -Name Pester
Import-Module -Name $modulePath

$TestMode = 'playback'
if($Live) {
  $TestMode = 'live'
}
if($Record) {
  $TestMode = 'record'
}
try {
  if ($TestMode -ne 'playback') {
    setupEnv
  }
  $testFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.testFolder)}'
  Invoke-Pester -Script @{ Path = $testFolder } -EnableExit -OutputFile (Join-Path $testFolder "$moduleName-TestResults.xml")
}
Finally
{
  if ($TestMode -ne 'playback') {
    cleanupEnv
  }
}

Write-Host -ForegroundColor Green '-------------Done-------------'