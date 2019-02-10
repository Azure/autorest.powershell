param([Switch]$isolated,[Switch]$test, [Switch]$code)
Push-Location $PSScriptRoot
$ErrorActionPreference = "Stop"

if($PSVersionTable.PSVersion.Major -lt 6) {
    Pop-Location
    write-error "This script requires PowerShell Core (don't worry: generated cmdlets can work in PowerShell Core or Windows Powershell)" 
}

if(-not $isolated) {
    # this ensures that we can run the script repeatedly without worrying about locked files/folders
    Write-Host -fore green "Spawning in isolated process." 
    $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
    & $pwsh -command $MyInvocation.MyCommand.Path -isolated 

    if( $lastExitCode -ne 0) {
        Pop-Location
        return;
    }

    if($test) {
        $mpath = $(( dir ./*.psd1)[0].fullname)
        $mname = $(( dir ./*.psd1)[0].basename)

        if( $code)  {
          # add a .vscode/launch.json folder 
          $launch = "$PSScriptRoot/.vscode/launch.json"
          $shh = new-item -Type Directory -Path "$PSScriptRoot/.vscode" -ea 0
          set-content -path $launch -value '{ "version": "0.2.0", "configurations" : [{ "name" : "Attach to PowerShell", "type":"coreclr", "request":"attach", "processId":"#PID","justMyCode": false  }] }'

          & $pwsh -noexit -command  "function prompt { `$ESC = [char]27 ; Write-host -nonewline -foregroundcolor green ('PS ' + `$(get-location) ) ;  Write-Host (' ['+ `$ESC +'[02;46m testing $mname '+ `$ESC +'[0m] >') -nonewline -foregroundcolor white ; Write-host -fore white -nonewline '' ;  return ' ' } ; set-content -path $launch -value ((get-content -path $launch -raw ) -replace '#PID',([System.Diagnostics.Process]::GetCurrentProcess().id)  )  ; code $PSScriptRoot ;  import-module '$mpath' "
        } else {
          & $pwsh -noexit -command  "function prompt { `$ESC = [char]27 ; Write-host -nonewline -foregroundcolor green ('PS ' + `$(get-location) ) ;  Write-Host (' ['+ `$ESC +'[02;46m testing $mname '+ `$ESC +'[0m] >') -nonewline -foregroundcolor white ; Write-host -fore white -nonewline '' ;  return ' ' } ; import-module '$mpath' "
        }

        
        
    } else {
        Write-Host -fore cyan "To test this module in a new powershell process, run `n"
        Write-Host -fore white " & '$([System.Diagnostics.Process]::GetCurrentProcess().Path)' -noexit -command Import-Module '$( (dir ./*.psd1)[0].fullname )' "
        Write-Host -fore cyan "`nor use -test with this script`n"
    }
    Pop-Location
    return
}

Write-Host -fore green "Cleaning folders..."
@('./exports','./obj', './bin') |% { $shh = remove-item -recurse -ea 0 $_ }

if( Test-Path ./bin ) {
    Pop-Location
    write-error "Unable to clean binary folder. (a process may have an open handle.)"
}

Write-Host -fore green "Compiling private module code"
$shh = dotnet publish --configuration Release --output bin
if( $lastExitCode -ne 0 ) {
    # if it fails, let's do it again so the output comes out nicely.
    dotnet publish --configuration Release --output bin
    Pop-Location
    write-error "Compilation failed"
}

@('./bin/Debug','./bin/Release') |% { $shh = Remove-Item -recurse -ea 0 $_ }
$dll = (Get-ChildItem bin\*.private.dll)[0]

if( -not (Test-Path $dll) ) {
    Pop-Location
    write-error "Unable to find output assembly."
}

$commands = Get-Command -module (Import-Module $dll -passthru)
Write-Host -fore gray "Private Module loaded ($dll)."

# merge scripts into one file
$modulename = (Get-ChildItem *.psd1)[0].Name -replace ".psd1",""
$scriptmodule = $dll -replace ".private.",".scripts." -replace ".dll",".psm1"
$scriptfile = ""; 
Get-ChildItem -Recurse custom\*.ps1 |% { $scriptfile = $scriptfile +"`n`n# Included from: $(resolve-path -relative $_)`n" + (get-content -raw $_) } ; 
Set-Content $scriptmodule -Value $scriptfile
if( $scriptfile -ne '' ) {
    $commands = $commands + (Get-Command -module (Import-Module $scriptmodule -PassThru))
    Write-Host -fore gray "Private Scripts Module loaded ($scriptmodule)."
}

# No commands?
if( $commands.length -eq 0  ) {
    Pop-Location
    write-error "Unable get commands from private module."
}

$outputs = @{}
$argumentCompleters = @{}

Write-Host -fore green "Processing cmdlet variants"
$commands |% {

    $metadata = New-Object System.Management.Automation.CommandMetaData($_)
    if( $metadata.Name.IndexOf("_") -gt -1 ) {
        $targetCmdlet = $metadata.Name.split("_")[0];
        $variant = $metadata.Name.split("_")[1];
    } else {
        $targetCmdlet = $metadata.Name
        $variant = "default"
    }

    if(-not ($outputs.ContainsKey($targetCmdlet))) {
        $newCmdlet = @{
            cmdlet = New-Object System.Management.Automation.CommandMetaData($metadata)
            name = $targetCmdlet
            variants = @{}
        }
        # create the new target cmdlet 
        $newCmdlet.cmdlet.Parameters.Clear();
        $outputs[$targetCmdlet] = $newCmdlet;
    }

    $cmdlet = $outputs[$targetCmdlet]

    # add the variant
    $gb = [System.Management.Automation.ProxyCommand]::GetBegin($metadata)
    $ct = $metadata.Parameters.Keys.Count

    $outputType = ''
    if($_.OutputType) {
      $outputType = $_.OutputType.Type.ToString()
    }

    $cmdlet.variants.add($variant, @{method = $gb; pcount = $ct; name = $variant; outputType = $outputType} )

    # copy parameters across
    $metadata.Parameters.Keys |% {
        $name = $_;

        $p = $metadata.Parameters[$name]
        if( -not ($cmdlet.cmdlet.parameters.ContainsKey($name) ) ) {
            $argumentCompleter = $p.Attributes | Where-Object { $_.GetType().FullName -eq 'System.Management.Automation.ArgumentCompleterAttribute' } | Select-Object -First 1
            if($argumentCompleter) {
                if(-not ($argumentCompleters.ContainsKey($targetCmdlet))) {
                    $argumentCompleters[$targetCmdlet] = @{}
                }
                $argumentCompleters[$targetCmdlet][$name] = $argumentCompleter.Type
            }
            # add the parameter to the target
            $newParam = New-Object System.Management.Automation.ParameterMetadata($p)
            $newParam.ParameterSets.Clear()
            $cmdlet.cmdlet.Parameters.add($name, $newParam)
        }
        $param = $cmdlet.cmdlet.Parameters[$name];
        if( $p.ParameterSets["__AllParameterSets"] ) {
            $param.ParameterSets.Add( $variant, $p.ParameterSets["__AllParameterSets"]);
        }
    }
}

$shh = mkdir "./exports"

Write-Host -fore green "Generating unified cmdlet proxies"
# Now, loop thru and spit out the proxies

$outputs.Keys |% {

    $cmdletname= $_
    $each = $outputs[$cmdletname]
    $cmd = [System.Management.Automation.ProxyCommand]::Create($each.cmdlet)

    if( $each.variants.Count -eq 1 ) {
        if($cmd -match "GetCommand[^\\]*$" ) {
           $cmd = $cmd -replace ".InvokeCommand.GetCommand\('",".InvokeCommand.GetCommand('$modulename.scripts\"
        }

        $text = $cmd
    } else {
        $b = [System.Management.Automation.ProxyCommand]::GetBegin($each.cmdlet)
    
        $newBegin = "`n"
        $newBegin = $newBegin + '  switch ($PsCmdlet.ParameterSetName) { ';
        $newBegin = $newBegin + "`n"
        $pc = 100

        $each.variants.Keys |% {
            $name = $_;

            if ( $each.variants[$name].pcount -lt $pc ) {
                $pc = $each.variants[$name].pcount
                $defaultImpl = $each.variants[$name].method
                $defaultName = $name
            }

            $variant = $each.variants[$name].method;
            if($variant -match "GetCommand[^\\]*$" ) {
                $variant = $variant -replace ".InvokeCommand.GetCommand\('",".InvokeCommand.GetCommand('$modulename.scripts\"
            }

            $t =  "`n  '$_' {`n"
            $t = $t + $variant
            $t = $t + "`n}`n"
            $newBegin = $newBegin + $t;
        }

        # add a default case (choose the first?)
        $t =  "`n  default {`n"
        $t = $t + $defaultImpl
        $t = $t + "`n}`n"
        $newBegin = $newBegin  + $t;

        $newBegin = $newBegin + "`n}`n";

        $text = $cmd.replace( $b, $newBegin )
        $commaSpace = ''
        if($text -match '(.*CmdletBinding\()(.*)') {
          $textPart = $matches.2
          if(-not $textPart.StartsWith(')]')) {
            $commaSpace = ', '
          }
        }
        $text = $text.replace("[CmdletBinding(", "[CmdletBinding(DefaultParameterSetName='$defaultName'$commaSpace")
    }

    if($argumentCompleters.ContainsKey($cmdletname)) {
        $argumentCompleters[$cmdletname].Keys |% {
            $paramName = $_
            $completerType = $argumentCompleters[$cmdletname][$paramName]

            if($text -match "\r\n(\s*)\[(.*)]\r\n\s*\$`{$paramName}") {
                $spaces = $matches[1]
                $typeName = $matches[2]
                $text = $text -replace "\r\n$spaces\[$typeName]\r\n$spaces\$`{$paramName}", "`n$spaces[ArgumentCompleter([$completerType])]`n$spaces[$typeName]`n$spaces$`{$paramName}"
            }
        }
    }

    $outputType = ($each.variants.GetEnumerator() | Select-Object -First 1).Value.outputType
    $outputTypeAttribute = ''
    if($outputType) {
      $outputTypeAttribute = "[OutputType('$outputType')]`n"
    }
    $text = "function ${cmdletname} {`n$outputTypeAttribute$text`n}`n"
    $filename = $cmdletname -replace ".*[\\|/]","" -replace '\.ps1$',''

    set-content "exports/${filename}.ps1" -value $text
}
Pop-Location
Write-Host -fore green "Done."
Write-Host -fore green "-------------------------------"

