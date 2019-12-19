[CmdletBinding()]
param (
    [Parameter()]
    [string[]]
    $swaggers,

    [Parameter()]
    [string]
    [AllowEmptyString()]
    $outputRoot = '',

    [Parameter()]
    [string]
    $autorestVersion
)
$testServer = get-command "$(resolve-path $PSScriptRoot/..)/powershell/node_modules/.bin/start-autorest-express"
& $testServer --verbose --show-messages pwsh $PSScriptRoot/generate.ps1 @PSBoundParameters