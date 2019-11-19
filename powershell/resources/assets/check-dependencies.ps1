param([switch]$Isolated, [switch]$Accounts, [switch]$Pester, [switch]$Resources)
$ErrorActionPreference = 'Stop'

if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NoExit -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

function DownloadModule ([bool]$predicate, [string]$path, [string]$moduleName, [string]$versionMinimum) {
  if($predicate) {
    $module = Get-Module -ListAvailable -Name $moduleName
    if((-not $module) -or ($versionMinimum -and ($module | ForEach-Object { $_.Version } | Where-Object { $_ -ge [System.Version]$versionMinimum } | Measure-Object).Count -eq 0)) {
      $null = New-Item -ItemType Directory -Force -Path $path
      Write-Host -ForegroundColor Green "Installing local $moduleName module into '$path'..."
      if($versionMinimum) {
        Find-Module -Name $moduleName -MinimumVersion $versionMinimum -Repository PSGallery | Save-Module -Path $path
      } else {
        Find-Module -Name $moduleName -Repository PSGallery | Save-Module -Path $path
      }
    }
  }
}

$ProgressPreference = 'SilentlyContinue'
$all = (@($Accounts.IsPresent, $Pester.IsPresent) | Select-Object -Unique | Measure-Object).Count -eq 1

$localModulesPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dependencyModuleFolder)}'
if(Test-Path -Path $localModulesPath) {
  $env:PSModulePath = "$localModulesPath$([IO.Path]::PathSeparator)$env:PSModulePath"
}

DownloadModule -predicate ($all -or $Accounts) -path $localModulesPath -moduleName 'Az.Accounts' -versionMinimum '${$project.accountsVersionMinimum}'
DownloadModule -predicate ($all -or $Pester) -path $localModulesPath -moduleName 'Pester' -versionMinimum ''

$tools = Join-Path $PSScriptRoot 'tools'
$resourceDir = Join-Path $tools 'Resources'
$resourceModule = Join-Path $HOME '.PSSharedModules\Resources\Az.Resources.TestSupport.psm1'

if ($Resources.IsPresent -and (-not (Test-Path -Path $resourceModule))) {
  Write-Host -ForegroundColor Green "Building local Resource module used for test..."
  Set-Location $resourceDir
  $null = autorest-beta .\readme.md --output-folder=$HOME/.PSSharedModules/Resources
  Set-Location $HOME/.PSSharedModules/Resources
  $null = .\build-module.ps1
  Set-Location $PSScriptRoot
}
