
[CmdletBinding()]
param (
    [Parameter()]
    [string[]]
    $swaggers,
    [switch]$Live, 
    [switch]$Record, 
    [switch]$Playback
)
$root = ( resolve-path "$PSScriptRoot/..").Path
$outputRoot = ( resolve-path "$root/tests").Path

if (-not (Get-Module -ListAvailable -Name pester)) { 
  write-host -fore:red 'install pester module before running this script'
  write-host -fore:cyan 'install-module -scope currentuser -name pester -force'
  exit 1;
} 

. $PSScriptRoot/tests.ps1

if( $swaggers -ne $null) {
  $azureInputs = $azureInputs |% { if( $swaggers.indexOf( $_ ) -gt -1 )  { return $_ } }
  $inputs = $inputs |% { if( $swaggers.indexOf( $_ ) -gt -1 )  { return $_ } }
}
if( $Live -or $Record ) {
  & (get-command powershell/node_modules/.bin/start-autorest-testserver).Path
}

$total = 0
$errors = @{}
$success = @{}

function run-tests($src) {
  $name = $src
  $outputFolder = "$outputRoot/$name"
  
  write-host -fore GREEN "`n--------------------------------------------------------`nTesting Module [$name]`n--------------------------------------------------------`n"

  & $outputFolder/test-module.ps1 -Live:$Live -Record:$record -Playback:$playback
  

  $rc = [int]$LastExitCode
  $script:total = $script:total + [int]$rc

  if( $rc -gt 0 ) {
    write-host -fore RED "`n--------------------------------------------------------`nFAILED Test Execution [$name]`n--------------------------------------------------------`n"
    $errors[$name] = $rc
  } else {
    $success[$name] = $name
  }
}

$inputs |% {
  run-tests $_
}

$azureInputs |% {
  run-tests $_
}

if( $success.Keys.Count -gt 0 ) {
  $count = $success.Keys.Count 
  write-host "`n`n"
  write-host -fore:green "Modules passing: $count"  
  write-host -fore:green "--------------------------------------------------------"
  $success.Keys |% {
    write-host -fore GREEN $_  
  }
}


if( $total -ne 0) {
  $count = $errors.Keys.Count 

  write-host "`n`n"
  write-host -fore:red "Failing: `n  modules: " -nonewline
  write-host -fore:white $count -nonewline
  write-host -fore:red "`n  tests: " -nonewline
  write-host -fore:white $total
  write-host -fore:red "--------------------------------------------------------"
  $errors.Keys |% {
    write-host -fore:RED "  $_ : " -nonewline 
    write-host -fore:white $errors[$_] 
  }
  write-host "`n`n"
  write-error "Not Successful."
  exit $total
}
if( $Live -or $Record ) {
  & (get-command powershell/node_modules/.bin/stop-autorest-testserver).Path
}
