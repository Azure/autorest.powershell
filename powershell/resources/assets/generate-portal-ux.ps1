# ----------------------------------------------------------------------------------
${$project.pwshCommentHeader}
# ----------------------------------------------------------------------------------
param([switch]$Isolated)
$ErrorActionPreference = 'Stop'

$pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

$exportsFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.exportsFolder)}'
if(-not (Test-Path $exportsFolder)) {
  Write-Error "Exports folder '$exportsFolder' was not found."
}

$directories = Get-ChildItem -Directory -Path $exportsFolder
$hasProfiles = ($directories | Measure-Object).Count -gt 0
if(-not $hasProfiles) {
  $directories = Get-Item -Path $exportsFolder
}

$docsFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.docsFolder)}'
if(Test-Path $docsFolder) {
  $null = Get-ChildItem -Path $docsFolder -Recurse -Exclude 'README.md' | Remove-Item -Recurse -ErrorAction SilentlyContinue
}
$null = New-Item -ItemType Directory -Force -Path $docsFolder -ErrorAction SilentlyContinue
$examplesFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.examplesFolder)}'

$moduleName = '${$project.moduleName}'
$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot "./$moduleName.psd1")
$modulePath = $modulePsd1.FullName

# Load DLL to use build-time cmdlets
Import-Module -Name $modulePath
Import-Module -Name (Join-Path $PSScriptRoot "./bin/$moduleName.private.dll")
$instance = [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Module]::Instance
# Module info is shared per profile
$moduleInfo = Get-Module -Name $moduleName
$parameterSetsInfo = Get-Module -Name "$moduleName.private"

$buildinFunctions = @("Export-CmdletSurface", "Export-ExampleStub", "Export-FormatPs1xml", "Export-HelpMarkdown", "Export-ModelSurface", "Export-ProxyCmdlet", "Export-Psd1", "Export-TestStub", "Get-CommonParameter", "Get-ModuleGuid", "Get-ScriptCmdlet")

Function Test-FunctionSupported()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [string]
        $functionName
    )

    If ($buildinFunctions.Contains($functionName)) {
        return $false
    }

    $cmdletName, $parameterSetName = $functionName.Split("_")
    If ($parameterSetName.Contains("List") -or $parameterSetName.Contains("ViaIdentity")) {
        return $false
    }
    If ($cmdletName.StartsWith("New") -or $cmdletName.StartsWith("Set") -or $cmdletName.StartsWith("Update")) {
        return $false
    }

    return $true
}

Function Find-MappedCmdlet()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [string]
        $functionName
    )
    
    $cmdletName, $parameterSetName = $functionName.Split("_")

    return $cmdletName
}

Function Get-ParameterSetDescription()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.CommandInfo]
        $cmdletInfo
    )
    $descriptionAttribute = $cmdletInfo.ImplementingType.GetTypeInfo().GetCustomAttributes([System.object], $true) | Where { $_.TypeId.Name -eq 'DescriptionAttribute' }
    
    return $descriptionAttribute.Description
}

Function Test-ParameterFromPath()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.ParameterMetadata]
        $parameterInfo
    )
    $categoryAttributes = $parameterInfo.Attributes | Where { $_.TypeId.Name -eq 'CategoryAttribute' }
    
    return $categoryAttributes.Categories -eq 'Path'
}

Function Test-Parameter()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.ParameterMetadata]
        $parameterInfo
    )
    $categoryAttributes = $parameterInfo.Attributes | Where { $_.TypeId.Name -eq 'CategoryAttribute' }
    
    $valideCategory = @('Path', 'Query', 'Body')
    if ($valideCategory -contains $categoryAttributes.Categories)
    {
        return $true
    }
    return $false
}

Function Get-ParameterSourceName()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.ParameterMetadata]
        $parameterInfo
    )
    $infoAttribute = $parameterInfo.Attributes | Where { $_.TypeId.Name -eq 'InfoAttribute' }
    
    return $infoAttribute.SerializedName
}

Function Get-Example()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.CommandInfo]
        $cmdletInfo
    )
    $parameters = $cmdletInfo.Parameters.Values | Where { Test-ParameterFromPath $_ }
    $result = @()
    foreach ($parameter in $parameters)
    {
        $source = Get-ParameterSourceName $parameter
        $Name = $parameter.Name
        $result += @{
            Name = "-$Name"
            Value = "[path.$source]"
        }
    }

    return $result
}

Function Get-ParameterArray()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.CommandInfo]
        $cmdletInfo
    )
    $parameters = $cmdletInfo.Parameters.Values | Where { Test-ParameterFromPath $_ }
    $result = @()
    foreach ($parameter in $parameters)
    {
        $parameterAttribute = $parameter.Attributes | Where { $_.TypeId.Name -eq 'ParameterAttribute' }
        $isMandatory = $parameterAttribute.Mandatory
        $parameterName = $parameter.Name
        $parameterType = $parameter.ParameterType.ToString().Split('.')[1]
        if ($parameter.SwitchParameter)
        {
            $parameterSignature = "-$parameterName"
        }
        else
        {
            $parameterSignature = "-$parameterName <$parameterType>"
        }
        if ($parameterName -eq "SubscriptionId")
        {
            $isMandatory = $false
        }
        if (-not $isMandatory)
        {
            $parameterSignature = "[$parameterSignature]"
        }
        $result += $parameterSignature
    }

    return $result
}

Function Get-SwaggerInfo()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.CommandInfo]
        $cmdletInfo
    )
    $customAttributes = $cmdletInfo.ImplementingType.GetTypeInfo().GetCustomAttributes([System.object], $true) | Where { $_.TypeId.Name -eq 'HttpPathAttribute' }
    $httpPath = $customAttributes[0].Path
    $apiVersion = $customAttributes[0].ApiVersion
    $provider = $httpPath.Split("/providers/")[1].Split("/")[0]
    $resources = $httpPath.Split("$provider/")[1].Split("/") | Where { -not ($_.StartsWith("{") -and $_.EndsWith("}")) }
    $resourceType = $resources -join "/"
    $cmdletName = Find-MappedCmdlet $cmdletInfo.Name
    $description = Get-ParameterSetDescription -CmdletInfo $cmdletInfo
    $example = Get-Example $cmdletInfo
    $signature = Get-ParameterArray $cmdletInfo

    return @{
        Path = $httpPath
        Provider = $provider
        ResourceType = $resourceType
        ApiVersion = $apiVersion
        CmdletName = $cmdletName
        Description = $description
        Example = $example
        Signature = @{
            parameters = $signature
        }
    }
}

Function Merge-CmdletInfo()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [Hashtable]
        $existedCmdletInfo,
        [Parameter()]
        [Hashtable]
        $newCmdletInfo
    )
    $existedCmdletInfo.help.parameterSets += $newCmdletInfo.Signature
    $existedCmdletInfo.examples += @{
        description = $newCmdletInfo.Description
        parameters = $newCmdletInfo.Example
    }

    return $existedCmdletInfo
}

Function New-CmdletInfo()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [Hashtable]
        $newCmdletInfo
    )
    $cmdletName = $newCmdletInfo.CmdletName
    $publicCmdletInfo = $moduleInfo.ExportedCommands[$cmdletName]
    $result = [ordered]@{
        name = $cmdletName
        description = $newCmdletInfo.Description
        path = $newCmdletInfo.Path
        help = @{
            learnMore = @{
                url = "https://learn.microsoft.com/powershell/module/$moduleName/$CmdletName".ToLower()
            }
            parameterSets = @()
        }
        examples = @()
    }
    $result = Merge-CmdletInfo -ExistedCmdletInfo $result -NewCmdletInfo $newCmdletInfo
    return $result
}

$parameterSets = $parameterSetsInfo.ExportedCommands.Keys | Where { Test-FunctionSupported($_) }
$resourceTypes = @{}
foreach ($parameterSetName in $parameterSets)
{
    $cmdletInfo = $parameterSetsInfo.ExportedCommands[$parameterSetName]
    $swaggerInfo = Get-SwaggerInfo -CmdletInfo $cmdletInfo
    $cmdletName = $swaggerInfo.CmdletName
    if (-not ($moduleInfo.ExportedCommands.ContainsKey($cmdletName)))
    {
        continue
    }
    if ($resourceTypes.ContainsKey($swaggerInfo.ResourceType))
    {
        $existedCmdletInfo = $resourceTypes[$swaggerInfo.ResourceType].commands | Where { $_.name -eq $cmdletName }
        if ($existedCmdletInfo)
        {
            $existedCmdletInfo = Merge-CmdletInfo -ExistedCmdletInfo $existedCmdletInfo -NewCmdletInfo $swaggerInfo
        }
        else
        {
            $cmdletInfo = New-CmdletInfo -NewCmdletInfo $swaggerInfo
            $resourceTypes[$swaggerInfo.ResourceType].commands += $cmdletInfo
        }
    }
    else
    {
        $cmdletInfo = New-CmdletInfo -NewCmdletInfo $swaggerInfo
        $resourceTypes[$swaggerInfo.ResourceType] = [ordered]@{
            resourceType = $swaggerInfo.ResourceType
            apiVersion = $swaggerInfo.ApiVersion
            learnMore = @{
                url = "https://learn.microsoft.com/powershell/module/$moduleName".ToLower()
            }
            commands = @($cmdletInfo)
        }
    }
}

if (Test-Path "UX")
{
    Remove-Item -Path "UX" -Recurse
}
$_ = New-Item -ItemType Directory -Path "UX"
# Add-Type -AssemblyName System.Web.Extensions
foreach ($resourceType in $resourceTypes.Keys)
{
    $resourceTypeFileName = $resourceType -replace "/", "-"
    $resourceTypeInfo = $resourceTypes[$resourceType]
    # $serializer = New-Object System.Web.Script.Serialization.JavaScriptSerializer
    # $serializer.Serialize($resourceTypeInfo) | Out-File "UX/$resourceTypeFileName.json"
    $resourceTypeInfo | ConvertTo-Json -Depth 10 | Out-File "UX/$resourceTypeFileName.json"
}