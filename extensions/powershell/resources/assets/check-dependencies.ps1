param([switch]$Isolated, [switch]$Accounts, [switch]$PlatyPS, [switch]$Pester)
$ErrorActionPreference = 'Stop'

if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NoExit -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

$all = (@($Accounts.IsPresent, $PlatyPS.IsPresent, $Pester.IsPresent) | Select-Object -Unique | Measure-Object).Count -eq 1

$localModulesPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dependencyModuleFolder)}'
if(Test-Path -Path $localModulesPath) {
  $env:PSModulePath = "$localModulesPath$([IO.Path]::PathSeparator)$env:PSModulePath"
}

if($all -or $Accounts) {
  $accountsModule = Get-Module -ListAvailable -Name Az.Accounts
  if((-not $accountsModule) -or ($accountsModule | ForEach-Object { $_.Version } | Where-Object { $_ -ge [System.Version]'${$project.accountsVersionMinimum}' } | Measure-Object).Count -eq 0) {
    $null = New-Item -ItemType Directory -Force -Path $localModulesPath
    Write-Host -ForegroundColor Green "Installing local Az.Accounts module into '$localModulesPath'..."
    Find-Module -Name Az.Accounts -MinimumVersion '${$project.accountsVersionMinimum}' -Repository PSGallery | Save-Module -Path $localModulesPath
  }
}

if($all -or $PlatyPS) {
  $platyPSModule = Get-Module -ListAvailable -Name platyPS
  if((-not $platyPSModule) -or ($platyPSModule | ForEach-Object { $_.Version } | Where-Object { $_ -ge [System.Version]'${$project.platyPsVersionMinimum}' } | Measure-Object).Count -eq 0) {
    $null = New-Item -ItemType Directory -Force -Path $localModulesPath
    Write-Host -ForegroundColor Green "Installing local platyPS module into '$localModulesPath'..."
    Find-Module -Name platyPS -MinimumVersion '${$project.platyPsVersionMinimum}' -Repository PSGallery | Save-Module -Path $localModulesPath
  }
}

if($all -or $Pester) {
  $pesterModule = Get-Module -ListAvailable -Name Pester
  if(-not $pesterModule) {
    $null = New-Item -ItemType Directory -Force -Path $localModulesPath
    Write-Host -ForegroundColor Green "Installing local Pester module into '$localModulesPath'..."
    Find-Module -Name Pester -Repository PSGallery | Save-Module -Path $localModulesPath
  }
}