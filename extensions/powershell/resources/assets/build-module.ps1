param([Switch]$Isolated, [Switch]$Run, [Switch]$Test, [Switch]$Code, [Switch]$Release)
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
$binFolder = (Join-Path $PSScriptRoot 'bin')
$objFolder = (Join-Path $PSScriptRoot 'obj')
$null = Remove-Item -Recurse -ErrorAction SilentlyContinue -Path $binFolder, $objFolder
$null = Get-ChildItem -Path 'exports' -Recurse -Exclude 'readme.md' | Remove-Item -Recurse -ErrorAction SilentlyContinue

if((Test-Path $binFolder) -or (Test-Path $objFolder)) {
  Write-Error 'Unable to clean ''bin'' or ''obj'' folder. A process may have an open handle.'
}

Write-Host -ForegroundColor Green 'Compiling module...'
$buildConfig = 'Debug'
if($Release) {
  $buildConfig = 'Release'
}
dotnet publish --configuration $buildConfig --output bin /nologo
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

# https://stackoverflow.com/a/40969712/294804
$currentFunctions = Get-ChildItem function:
$scriptsPath = Join-Path $PSScriptRoot 'custom' '*.ps1'
Get-ChildItem -Recurse $scriptsPath | ForEach-Object { . $_.FullName }
$scriptFunctions = Get-ChildItem function: | Where-Object { $currentFunctions -notcontains $_ }
if(($scriptFunctions | Measure-Object).Count -gt 0) {
  $commands = $commands + ($scriptFunctions | ForEach-Object { Get-Command -Name $_.Name })
  Write-Host -ForegroundColor Green 'Custom Scripts Loaded'
}

# merge scripts into one file
# $modulename = (Get-ChildItem *.psd1)[0].Name -replace ".psd1",""
# $scriptmodule = $dll -replace ".private.",".scripts." -replace ".dll",".psm1"
# $scriptfile = ""; 
# Get-ChildItem -Recurse custom\*.ps1 |% { $scriptfile = $scriptfile +"`n`n# Included from: $(Resolve-Path -Relative $_)`n" + (Get-Content -raw $_) } ; 
# Set-Content $scriptmodule -Value $scriptfile
# if( $scriptfile -ne '' ) {
#   $commands = $commands + (Get-Command -Module (Import-Module $scriptmodule -PassThru))
#   Write-Host -ForegroundColor Gray "Private Scripts Module loaded ($scriptmodule)."
# }

if(($commands | Measure-Object).Count -eq 0) {
  Write-Error 'Unable to locate any cmdlets.'
}

$commands = $commands | Where-Object { $_.Name -ne 'New-ProxyCmdlet' -and $_.Name -ne 'New-TestStub'}

$exportPath = Join-Path $PSScriptRoot 'exports'
$null = New-Item -ItemType Directory -Force -Path $exportPath
New-ProxyCmdlet -CommandInfo $commands -OutputFolder $exportPath

$testPath = Join-Path $PSScriptRoot 'test'
$null = New-Item -ItemType Directory -Force -Path $testPath
New-TestStub -CommandInfo $commands -OutputFolder $testPath

Write-Host -ForegroundColor Green '-------------Done-------------'