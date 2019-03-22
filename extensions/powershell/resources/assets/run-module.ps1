param([switch]$Isolated, [switch]$Code)
$ErrorActionPreference = 'Stop'

if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NoExit -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

$isAzure = $${$project.azure}
if($isAzure) {
  . (Join-Path $PSScriptRoot 'check-dependencies.ps1') -Isolated -Accounts
}

$localModulesPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dependencyModuleFolder)}'
if(Test-Path -Path $localModulesPath) {
  $env:PSModulePath = "$localModulesPath$([IO.Path]::PathSeparator)$env:PSModulePath"
}

$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot '${$project.psd1}')
$modulePath = $modulePsd1.FullName
$moduleName = $modulePsd1.BaseName

function Prompt {
  Write-Host -NoNewline -ForegroundColor Green "PS $(Get-Location)"
  Write-Host -NoNewline -ForegroundColor Gray ' ['
  Write-Host -NoNewline -ForegroundColor White -BackgroundColor DarkCyan $moduleName
  ']> '
}

if($Code) {
  $vscodeDirectory = New-Item -ItemType Directory -Force -Path (Join-Path $PSScriptRoot '.vscode')
  $launchJson = Join-Path $vscodeDirectory 'launch.json'
  $launchContent = '{ "version": "0.2.0", "configurations":[{ "name":"Attach to PowerShell", "type":"coreclr", "request":"attach", "processId":"' + ([System.Diagnostics.Process]::GetCurrentProcess().Id) + '", "justMyCode":false }] }'
  Set-Content -Path $launchJson -Value $launchContent
  code $PSScriptRoot
}

Import-Module -Name $modulePath