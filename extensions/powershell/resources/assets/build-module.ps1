param([Switch]$isolated, [Switch]$test, [Switch]$code)
Push-Location $PSScriptRoot
$ErrorActionPreference = "Stop"

if($PSVersionTable.PSVersion.Major -lt 6) {
    Pop-Location
    Write-Error "This script requires PowerShell Core (don't worry: generated cmdlets can work in PowerShell Core or Windows Powershell)" 
}

if(-not $isolated) {
    # this ensures that we can run the script repeatedly without worrying about locked files/folders
    Write-Host -Fore green "Spawning in isolated process." 
    $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
    & $pwsh -Command $MyInvocation.MyCommand.Path -Isolated

    if($lastExitCode -ne 0) {
        Pop-Location
        return;
    }

    if($test) {
        $mpath = $(( dir ./*.psd1)[0].fullname)
        $mname = $(( dir ./*.psd1)[0].basename)
        $testCommandExtra = ''
        if($code) {
            # add a .vscode/launch.json folder 
            $launch = "$PSScriptRoot/.vscode/launch.json"
            $null = New-Item -Type Directory -Path "$PSScriptRoot/.vscode" -ea 0
            set-content -path $launch -value '{ "version": "0.2.0", "configurations" : [{ "name" : "Attach to PowerShell", "type":"coreclr", "request":"attach", "processId":"#PID","justMyCode": false  }] }'
            $testCommandExtra = " set-content -path $launch -value ((get-content -path $launch -raw ) -replace '#PID',([System.Diagnostics.Process]::GetCurrentProcess().id)  )  ; code $PSScriptRoot ;"
        }
        & $pwsh -NoExit -Command "function prompt { `$ESC = [char]27 ; Write-host -nonewline -foregroundcolor green ('PS ' + `$(get-location) ) ;  Write-Host (' ['+ `$ESC +'[02;46m testing $mname '+ `$ESC +'[0m] >') -nonewline -foregroundcolor white ; Write-host -Fore white -nonewline '' ;  return ' ' } ;$testCommandExtra import-module '$mpath' "
    } else {
        Write-Host -Fore cyan "To test this module in a new powershell process, run `n"
        Write-Host -Fore white " & '$([System.Diagnostics.Process]::GetCurrentProcess().Path)' -NoExit -Command Import-Module '$( (dir ./*.psd1)[0].fullname )' "
        Write-Host -Fore cyan "`nor use -test with this script`n"
    }
    Pop-Location
    return
}

Write-Host -Fore green "Cleaning folders..."
@('./obj', './bin') |% { $null = Remove-Item -Recurse -ea 0 $_ }
$null = (Get-ChildItem -Path 'exports' -Recurse -Exclude 'readme.md' | Remove-Item -Recurse -ea 0)

if(Test-Path ./bin) {
    Pop-Location
    Write-Error "Unable to clean binary folder. (a process may have an open handle.)"
}

Write-Host -Fore green "Compiling private module code"
$null = dotnet publish --configuration Release --output bin
if( $lastExitCode -ne 0 ) {
    # if it fails, let's do it again so the output comes out nicely.
    dotnet publish --configuration Release --output bin
    Pop-Location
    Write-Error "Compilation failed"
}

@('./bin/Debug','./bin/Release') |% { $null = Remove-Item -Recurse -ea 0 $_ }
$dll = (Get-ChildItem bin\*.private.dll)[0]

if( -not (Test-Path $dll) ) {
    Pop-Location
    Write-Error "Unable to find output assembly."
}

$commands = Get-Command -Module (Import-Module $dll -PassThru)
Write-Host -Fore gray "Private Module loaded ($dll)."

# merge scripts into one file
$modulename = (Get-ChildItem *.psd1)[0].Name -replace ".psd1",""
$scriptmodule = $dll -replace ".private.",".scripts." -replace ".dll",".psm1"
$scriptfile = ""; 
Get-ChildItem -Recurse custom\*.ps1 |% { $scriptfile = $scriptfile +"`n`n# Included from: $(Resolve-Path -Relative $_)`n" + (Get-Content -raw $_) } ; 
Set-Content $scriptmodule -Value $scriptfile
if( $scriptfile -ne '' ) {
    $commands = $commands + (Get-Command -module (Import-Module $scriptmodule -PassThru))
    Write-Host -Fore gray "Private Scripts Module loaded ($scriptmodule)."
}

# No commands?
if( $commands.length -eq 0 ) {
    Pop-Location
    Write-Error "Unable get commands from private module."
}

$commands = $commands | Where-Object { $_.Name -ne 'New-ProxyCmdlet' -and $_.Name -ne 'New-TestStub'}

$exportPath = (Join-Path $PSScriptRoot 'exports')
$null = New-Item -ItemType Directory -Force -Path $exportPath
New-ProxyCmdlet -CommandInfo $commands -OutputFolder $exportPath

$testPath = (Join-Path $PSScriptRoot 'test')
$null = New-Item -ItemType Directory -Force -Path $testPath
New-TestStub -CommandInfo $commands -OutputFolder $testPath

Pop-Location
Write-Host -Fore green "Done."
Write-Host -Fore green "-------------------------------"