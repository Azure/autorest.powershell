# ----------------------------------------------------------------------------------
${$project.pwshCommentHeader}
# ----------------------------------------------------------------------------------

function CreateModelCmdlet {

    param([string[]]$Models)

    if ($Models.Count -eq 0)
    {
        return
    }

    $ModelCsPath = Join-Path (Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.apiFolder)}') 'Models'
    $OutputDir = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.modelCmdletFolder)}'
    $null = New-Item -ItemType Directory -Force -Path $OutputDir
    if ('${$project.rootModuleName}'.length -gt 0) {
        $ModuleName = '${$project.rootModuleName}'
    } else {
        $ModuleName = '${$project.moduleName}'
    }
    $CsFiles = Get-ChildItem -Path $ModelCsPath -Recurse -Filter *.cs
    $Content = ''
    $null = $CsFiles | ForEach-Object -Process { if ($_.Name.Split('.').count -eq 2 )
        { $Content += get-content $_.fullname -raw 
        } }

    $Tree = [Microsoft.CodeAnalysis.CSharp.SyntaxFactory]::ParseCompilationUnit($Content)
    $Nodes = $Tree.ChildNodes().ChildNodes()
    foreach ($Model in $Models)
    {
        $InterfaceNode = $Nodes | Where-Object { ($_.Keyword.value -eq 'interface') -and ($_.Identifier.value -eq "I$Model") }
        if ($InterfaceNode.count -eq 0) {
            continue
        }
        # through a queue, we iterate all the parent models.
        $Queue = @($InterfaceNode)
        $visited = @("I$Model")
        $AllInterfaceNodes = @()
        while ($Queue.count -ne 0)
        {
            $AllInterfaceNodes += $Queue[0]
            # Baselist contains the direct parent models.
            foreach ($parent in $Queue[0].BaseList.Types)
            {
                if (($parent.Type.Right.Identifier.Value -ne 'IJsonSerializable') -and (-not $visited.Contains($parent.Type.Right.Identifier.Value)))
                {
                    $Queue = [Array]$Queue + ($Nodes | Where-Object { ($_.Keyword.value -eq 'interface') -and ($_.Identifier.value -eq $parent.Type.Right.Identifier.Value) })
                    $visited = [Array]$visited + $parent.Type.Right.Identifier.Value
                }
            }
            $first, $Queue = $Queue
        }

        $Namespace =  $InterfaceNode.Parent.Name
        $ObjectType = $Model
        $ObjectTypeWithNamespace = "${Namespace}.${ObjectType}"
        # remove duplicated module name
        if ($ObjectType.StartsWith('${$project.subjectPrefix}')) {
            $ModulePrefix = ''
        } else {
            $ModulePrefix = '${$project.subjectPrefix}'
        }
        $OutputPath = Join-Path -ChildPath "New-Az${ModulePrefix}${ObjectType}Object.ps1" -Path $OutputDir

        $ParameterDefineScriptList = New-Object System.Collections.Generic.List[string]
        $ParameterAssignScriptList = New-Object System.Collections.Generic.List[string]
        foreach ($Node in $AllInterfaceNodes)
        {
            foreach ($Member in $Node.Members)
            {
                $Arguments = $Member.AttributeLists.Attributes.ArgumentList.Arguments
                $Required = $false
                $Description = ""
                $Readonly = $False
                $mutability = @{Read = $true; Create = $true; Update = $true}
                foreach ($Argument in $Arguments)
                {
                    if ($Argument.NameEquals.Name.Identifier.Value -eq "Required")
                    {
                        $Required = $Argument.Expression.Token.Value
                    }
                    if ($Argument.NameEquals.Name.Identifier.Value -eq "Description")
                    {
                        $Description = $Argument.Expression.Token.Value.Trim('.').replace('"', '`"')
                    }
                    if ($Argument.NameEquals.Name.Identifier.Value -eq "Readonly")
                    {
                        $Readonly = $Argument.Expression.Token.Value
                    }
                    if ($Argument.NameEquals.Name.Identifier.Value -eq "Read")
                    {
                        $mutability.Read = $Argument.Expression.Token.Value
                    }
                    if ($Argument.NameEquals.Name.Identifier.Value -eq "Create")
                    {
                        $mutability.Create = $Argument.Expression.Token.Value
                    }
                    if ($Argument.NameEquals.Name.Identifier.Value -eq "Update")
                    {
                        $mutability.Update = $Argument.Expression.Token.Value
                    }
                }
                if ($Readonly)
                {
                    continue
                }
                $Identifier = $Member.Identifier.Value
                $Type = $Member.Type.ToString().replace('?', '').replace('<', '[').replace('>', ']').Split("::")[-1]
                $ParameterDefinePropertyList = New-Object System.Collections.Generic.List[string]
                if ($Required -and $mutability.Create -and $mutability.Update)
                {
                    $ParameterDefinePropertyList.Add("Mandatory")
                }
                if ($Description -ne "")
                {
                    $ParameterDefinePropertyList.Add("HelpMessage=`"${Description}.`"")
                }
                $ParameterDefineProperty = [System.String]::Join(", ", $ParameterDefinePropertyList)
                # check whether completer is needed
                $completer = '';
                if($Type.Split('.').Split('.')[-2] -eq 'Support') {
                    # If Type is an array, need to strip []
                    $strippedType = $Type.Replace('[]', '')
                    $completer += "`n        [ArgumentCompleter([${strippedType}])]"
                }
                $ParameterDefineScript = "
        [Parameter($ParameterDefineProperty)]${completer}
        [${Type}]
        `$${Identifier}"
                $ParameterDefineScriptList.Add($ParameterDefineScript)
                $ParameterAssignScriptList.Add("
        if (`$PSBoundParameters.ContainsKey('${Identifier}')) {
            `$Object.${Identifier} = `$${Identifier}
        }")
            }
        }
        $ParameterDefineScript = $ParameterDefineScriptList | Join-String -Separator ","
        $ParameterAssignScript = $ParameterAssignScriptList | Join-String -Separator ""

        $Script = "
# ----------------------------------------------------------------------------------
${$project.pwshCommentHeaderForCsharp}
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for ${ObjectType}.
.Description
Create an in-memory object for ${ObjectType}.

.Outputs
${ObjectTypeWithNamespace}
.Link
${$project.helpLinkPrefix}${ModuleName}/new-Az${ModulePrefix}${ObjectType}Object
#>
function New-Az${ModulePrefix}${ObjectType}Object {
    [OutputType('${ObjectTypeWithNamespace}')]
    [CmdletBinding(PositionalBinding=`$false)]
    Param(
${ParameterDefineScript}
    )

    process {
        `$Object = [${ObjectTypeWithNamespace}]::New()
${ParameterAssignScript}
        return `$Object
    }
}
"
        Set-Content -Path $OutputPath -Value $Script
    }
}
