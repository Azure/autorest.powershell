
[CmdletBinding()]
param (
    [Parameter()]
    [string[]]
    $swaggers,
    [switch]$Live, 
    [switch]$Record, 
    [switch]$Playback
)

if( $Live -or $Record ) {
  $testServer = get-command "$(resolve-path $PSScriptRoot/..)/powershell/node_modules/.bin/start-autorest-express"
  & $testServer pwsh $PSScriptRoot/run.ps1 $swaggers -Live:$Live -Record:$Record -Playback:$Playback
} else {
  & pwsh $PSScriptRoot/run.ps1 @PSBoundParameters
}