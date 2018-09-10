pushd $PSScriptRoot
$ErrorActionPreference = "Stop"

$pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path

if( $PSVersionTable.PSVersion.Major -lt 6 ) { 
    write-error "This script requires Core PowerShell (don't worry: generated cmdlets can work in Core PowerShell or Windows Powershell)" 
}

if( -not (get-module platyps -ea 0 )) {
     write-error "This script requires the 'platyps' module -- please install it (install-module platyps -scope currentuser) " 
}

if( -not (test-path ./help) ) {
    mkdir ./help -ea 0 
}

$mpath = $(( dir ./*.psd1)[0].fullname)
$mname = $(( dir ./*.psd1)[0].basename)

# generate help for the proxy'd cmdlets.
& $pwsh -command "`$warningpreference = 'silent' ; ipmo $mpath ; get-command -module $mname |% { platyps\new-MarkdownHelp -command `$_ -OutputFolder ./help -ea 0  } ; `$shh = platyps\update-markdownhelpmodule -path ./help -ea 0 -RefreshModulePage -AlphabeticParamsOrder -UseFullTypeName "

# makes sure external help file is set correctly. 
dir ./help/*.md |% { set-content -Path $_ ( (Get-Content -Path $_) -replace "external help file:.*", "external help file: $mname-help.xml" ) }

# generate the help file
platyps\New-ExternalHelp -Path ./help -OutputPath ./ -force