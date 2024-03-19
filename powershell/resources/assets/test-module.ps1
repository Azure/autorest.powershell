# ----------------------------------------------------------------------------------
${$project.pwshCommentHeader}
# ----------------------------------------------------------------------------------
param([switch]$NotIsolated, [switch]$Live, [switch]$Record, [switch]$Playback, [switch]$RegenerateSupportModule, [switch]$UsePreviousConfigForRecord, [string[]]$TestName)
$ErrorActionPreference = 'Stop'

if(-not $NotIsolated)
{
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  if ($PSBoundParameters.ContainsKey("TestName")) {
    $PSBoundParameters["TestName"] = $PSBoundParameters["TestName"] -join ","
  }
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -NotIsolated
  return
}

# This is a workaround, since for string array parameter, pwsh -File will only take the first element
if ($PSBoundParameters.ContainsKey("TestName") -and ($TestName.count -eq 1) -and ($TestName[0].Contains(','))) {
  $TestName = $TestName[0].Split(",")
}

$ProgressPreference = 'SilentlyContinue'
$baseName = $PSScriptRoot.BaseName
$requireResourceModule = (($baseName -ne "Resources") -and ($Record.IsPresent -or $Live.IsPresent))
. (Join-Path $PSScriptRoot 'check-dependencies.ps1') -NotIsolated -Accounts:$false -Pester -Resources:$requireResourceModule -RegenerateSupportModule:$RegenerateSupportModule
. ("$PSScriptRoot\test\utils.ps1")

if ($requireResourceModule)
{
  # Load the latest Az.Accounts installed
  Import-Module -Name Az.Accounts -RequiredVersion (Get-Module -Name Az.Accounts -ListAvailable | Sort-Object -Property Version -Descending)[0].Version
  $resourceModulePSD = Get-Item -Path (Join-Path $HOME '.PSSharedModules\Resources\Az.Resources.TestSupport.psd1')
  Import-Module -Name $resourceModulePSD.FullName
}

$localModulesPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dependencyModuleFolder)}'
if(Test-Path -Path $localModulesPath)
{
  $env:PSModulePath = "$localModulesPath$([IO.Path]::PathSeparator)$env:PSModulePath"
}

$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot '${$project.psd1}')
$modulePath = $modulePsd1.FullName
$moduleName = $modulePsd1.BaseName

Import-Module -Name Pester
Import-Module -Name $modulePath

$TestMode = 'playback'
$ExcludeTag = @("LiveOnly")
if($Live)
{
  $TestMode = 'live'
  $ExcludeTag = @()
}
if($Record)
{
  $TestMode = 'record'
}
try
{
  if ($TestMode -ne 'playback')
  {
    setupEnv
  } else {
    $env:AzPSAutorestTestPlaybackMode = $true
  }
  $testFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.testFolder)}'
  if ($null -ne $TestName)
  {
    Invoke-Pester -Script @{ Path = $testFolder } -TestName $TestName -ExcludeTag $ExcludeTag -EnableExit -OutputFile (Join-Path $testFolder "$moduleName-TestResults.xml")
  } else {
    Invoke-Pester -Script @{ Path = $testFolder } -ExcludeTag $ExcludeTag -EnableExit -OutputFile (Join-Path $testFolder "$moduleName-TestResults.xml")
  }
} Finally
{
  if ($TestMode -ne 'playback')
  {
    cleanupEnv
  }
  else {
    $env:AzPSAutorestTestPlaybackMode = $false
  }
}

Write-Host -ForegroundColor Green '-------------Done-------------'
