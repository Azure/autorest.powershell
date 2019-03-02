param([Switch]$Isolated, [Switch]$Code)
Push-Location $PSScriptRoot
$ErrorActionPreference = 'Stop'

if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & $pwsh -NoExit -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  Pop-Location
  return
}

$modulePsd1 = Get-Item -Path *.psd1 | Select-Object -First 1
if(-not $modulePsd1) {
  Write-Error 'Module has not been built. Run ''./build-module.ps1'' to build the module.'
}
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