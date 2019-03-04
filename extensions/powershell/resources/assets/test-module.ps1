param([Switch]$Isolated)
$ErrorActionPreference = 'Stop'

$pester = Get-Module -ListAvailable -Name Pester
if (-not $pester) {
  Write-Error 'Pester is required to run tests. Please run ''Install-Module -Name Pester'' to install Pester.'
}

if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot '*.psd1') | Select-Object -First 1
$modulePath = $modulePsd1.FullName
$moduleName = $modulePsd1.BaseName

Import-Module -Name Pester
Import-Module $modulePath

Invoke-Pester -Script @{ Path = (Join-Path $PSScriptRoot 'test') } -EnableExit