pushd $PSScriptRoot

 dotnet restore
 dotnet build
 
$dll = (dir bin\Debug\netstandard2.0\*.dll)[0]

$commands = get-command -module (ipmo $dll -passthru)

$outputs = @{}

$commands |% {
    $metadata  = New-Object System.Management.Automation.CommandMetaData($_)
    if( $metadata.Name.IndexOf("_") ) {
        $targetCmdlet = $metadata.Name.split("_")[0];
        $variant = $metadata.Name.split("_")[1];
    } else {
        $targetCmdlet = $metadata.Name
        $variant = "default"
    }
    

    if( -not ($outputs.ContainsKey($targetCmdlet))) {
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
    $newCmdlet.variants.add( $variant, [System.Management.Automation.ProxyCommand]::GetBegin( $metadata ) )

    # copy parameters across
    $metadata.Parameters.Keys |% {
        $name = $_;
        $p = $metadata.Parameters[$name]
        if( -not ($cmdlet.cmdlet.parameters.ContainsKey($name) ) ) {
            # add the parameter to the target
            $newParam = New-Object System.Management.Automation.ParameterMetadata($p);
            $newParam.ParameterSets.Clear()
            $newCmdlet.cmdlet.Parameters.add($name, $newParam)
        }
        $param = $newCmdlet.cmdlet.Parameters[$name];
        $param.ParameterSets.Add( $variant, $p.ParameterSets["__AllParameterSets"]);
    }
}

rmdir -recurse exported -ea 0  
mkdir exported -ea 0 

# Now, loop thru and spit out the proxies
$outputs.Keys |% {
    $cmdletname= $_
    $each = $outputs[$cmdletname]
    $cmd = [System.Management.Automation.ProxyCommand]::create($each.cmdlet)
    $b = [System.Management.Automation.ProxyCommand]::GetBegin($each.cmdlet)
    
    $newBegin = "`n"
    $newBegin = $newBegin + '  switch ($PsCmdlet.ParameterSetName) { ';
    $newBegin = $newBegin + "`n"
    
    $each.variants.Keys |% {
        $name = $_;
        $variant = $each.variants[$name];
        $t =  "`n  '$_' {`n"
        $t = $t + $variant
        $t = $t + "`n}`n"
        $newBegin = $newBegin  + $t;
    }

    # add a default case (choose the first?)
    $name = $each.variants.Keys[0]
    $variant = $each.variants[$name];
    $t =  "`n  default {`n"
    $t = $t + $variant
    $t = $t + "`n}`n"
    $newBegin = $newBegin  + $t;

    $newBegin = $newBegin + "`n}`n";
        
    $text = $cmd.replace( $b, $newBegin ) 
    $text = "function ${cmdletname} {`n$text`n}`n"
    set-content "exported/${cmdletname}.ps1" -value $text
}
  
  popd