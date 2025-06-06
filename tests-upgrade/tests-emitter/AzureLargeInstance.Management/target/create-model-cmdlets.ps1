# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

function CreateModelCmdlet {

    param([Hashtable[]]$Models)

    if ($Models.Count -eq 0)
    {
        return
    }

    $ModelCsPath = Join-Path (Join-Path $PSScriptRoot 'generated\api') 'Models'
    $OutputDir = Join-Path $PSScriptRoot 'custom\autogen-model-cmdlets'
    $null = New-Item -ItemType Directory -Force -Path $OutputDir
    if (''.length -gt 0) {
        $ModuleName = ''
    } else {
        $ModuleName = 'Az.AzureLargeInstance'
    }
    $CsFiles = Get-ChildItem -Path $ModelCsPath -Recurse -Filter *.cs
    $Content = ''
    $null = $CsFiles | ForEach-Object -Process { if ($_.Name.Split('.').count -eq 2 )
        { $Content += get-content $_.fullname -raw 
        } }

    $Tree = [Microsoft.CodeAnalysis.CSharp.SyntaxFactory]::ParseCompilationUnit($Content)
    $Nodes = $Tree.ChildNodes().ChildNodes()
    $classConstantMember = @{}
    foreach ($Model in $Models)
    {
        $ModelName = $Model.modelName
        $InterfaceNode = $Nodes | Where-Object { ($_.Keyword.value -eq 'interface') -and ($_.Identifier.value -eq "I$ModelName") }
        $ClassNode = $Nodes | Where-Object { ($_.Keyword.value -eq 'class') -and ($_.Identifier.value -eq "$ModelName") }
        $classConstantMember = @()
        foreach ($class in $ClassNode) {
            foreach ($member in $class.Members) {
                $isConstant = $false
                foreach ($attr in $member.AttributeLists) {
                    $memberName = $attr.Attributes.Name.ToString()
                    if ($memberName.EndsWith('.Constant')) {
                        $isConstant = $true
                        break
                    }
                }
                if (($member.Modifiers.ToString() -eq 'public') -and $isConstant) {
                    $classConstantMember += $member.Identifier.Value
                }
            }
        }
        if ($InterfaceNode.count -eq 0) {
            continue
        }
        # through a queue, we iterate all the parent models.
        $Queue = @($InterfaceNode)
        $visited = @("I$ModelName")
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
        $ObjectType = $ModelName
        $ObjectTypeWithNamespace = "${Namespace}.${ObjectType}"
        $Prefix = 'Az'
        # remove duplicated module name
        if ($ObjectType.StartsWith('AzureLargeInstance')) {
            $ModulePrefix = ''
        } else {
            $ModulePrefix = 'AzureLargeInstance'
        }
        $OutputPath = Join-Path -ChildPath "New-${Prefix}${ModulePrefix}${ObjectType}Object.ps1" -Path $OutputDir

        $ParameterDefineScriptList = New-Object System.Collections.Generic.List[string]
        $ParameterAssignScriptList = New-Object System.Collections.Generic.List[string]
        foreach ($Node in $AllInterfaceNodes)
        {
            foreach ($Member in $Node.Members)
            {
                if ($classConstantMember.Contains($Member.Identifier.Value)) {
                    # skip constant member
                    continue
                }
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
                $Type = $Member.Type.ToString().replace('?', '').Split("::")[-1]
                if ($Type.StartsWith("System.Collections.Generic.List"))
                {
                    # if the type is a list, we need to convert it to array
                    $matched = $Type -match '\<(?<Name>.+)\>$'
                    if ($matched)
                    {
                        $Type = $matches.Name + '[]';
                    }
                }
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
                if(IsEnumType($Member)){                    
                    $completer += GetCompleter($Member)
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

        $cmdletName = "New-${Prefix}${ModulePrefix}${ObjectType}Object"
        if ('' -ne $Model.cmdletName) {
            $cmdletName = $Model.cmdletName
        }
        $OutputPath = Join-Path -ChildPath "${cmdletName}.ps1" -Path $OutputDir
        $cmdletNameInLowerCase = $cmdletName.ToLower()
        $Script = "
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the ""License"");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an ""AS IS"" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for ${ObjectType}.
.Description
Create an in-memory object for ${ObjectType}.

.Outputs
${ObjectTypeWithNamespace}
.Link
https://learn.microsoft.com/powershell/module/${ModuleName}/${cmdletNameInLowerCase}
#>
function ${cmdletName} {
    [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.ModelCmdletAttribute()]
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

function IsEnumType {
    param (
        [Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax]$property
    )
    $isEnum = $false
    foreach ($attr in $property.AttributeLists) {
        $attributeName = $attr.Attributes.Name.ToString()
        if ($attributeName.Contains('ArgumentCompleter')) {
            $isEnum = $true
            break
        }
    }
    return $isEnum;
}

function GetCompleter {
    param (
        [Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax]$property
    )
    foreach ($attr in $property.AttributeLists) {
        $attributeName = $attr.Attributes.Name.ToString()
        if ($attributeName.Contains('ArgumentCompleter')) {
            $attributeName = $attributeName.Split("::")[-1]
            $possibleValues = [System.String]::Join(", ", $attr.Attributes.ArgumentList.Arguments)
            $completer += "`n        [${attributeName}(${possibleValues})]"
            return $completer
        }
    }
}
