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
$instance = [${$project.serviceNamespace.moduleClass.declaration}]::Instance
# Module info is shared per profile
$moduleInfo = Get-Module -Name $moduleName
$parameterSetsInfo = Get-Module -Name "$moduleName.private"

$buildinFunctions = @("Export-CmdletSurface", "Export-ExampleStub", "Export-FormatPs1xml", "Export-HelpMarkdown", "Export-ModelSurface", "Export-ProxyCmdlet", "Export-Psd1", "Export-TestStub", "Get-CommonParameter", "Get-ModuleGuid", "Get-ScriptCmdlet")

function Test-FunctionSupported()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [string]
        $FunctionName
    )

    If ($buildinfunctions.Contains($FunctionName)) {
        return $false
    }

    $cmdletName, $parameterSetName = $FunctionName.Split("_")
    If ($parameterSetName.Contains("List") -or $parameterSetName.Contains("ViaIdentity")) {
        return $false
    }
    If ($cmdletName.StartsWith("New") -or $cmdletName.StartsWith("Set") -or $cmdletName.StartsWith("Update")) {
        return $false
    }

    $parameterSetInfo = $parameterSetsInfo[$FunctionName]
    foreach ($parameterInfo in $parameterSetInfo.Parameters)
    {
        $category = (Get-ParameterAttribute -ParameterInfo $parameterInfo -AttributeName "CategoryAttribute").Categories
        $invalideCategory = @('Query', 'Body')
        if ($invalideCategory -contains $category)
        {
            return $false
        }
    }

    return $true
}

function Get-MappedCmdletFromFunctionName()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [string]
        $FunctionName
    )
    
    $cmdletName, $parameterSetName = $FunctionName.Split("_")

    return $cmdletName
}

function Get-ParameterAttribute()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.ParameterMetadata]
        $ParameterInfo,
        [Parameter()]
        [String]
        $AttributeName
    )
    return $ParameterInfo.Attributes | Where-Object { $_.TypeId.Name -eq $AttributeName }
}

function Get-CmdletAttribute()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.CommandInfo]
        $CmdletInfo,
        [Parameter()]
        [String]
        $AttributeName
    )

    return $CmdletInfo.ImplementingType.GetTypeInfo().GetCustomAttributes([System.object], $true) | Where-Object { $_.TypeId.Name -eq $AttributeName }
}

function Get-CmdletDescription()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [String]
        $CmdletName
    )
    $helpInfo = Get-Help $CmdletName -Full
    
    return $helpInfo.Description.Text
}

# Test whether the parameter is from swagger http path
function Test-ParameterFromSwagger()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.ParameterMetadata]
        $ParameterInfo
    )
    $category = (Get-ParameterAttribute -ParameterInfo $ParameterInfo -AttributeName "CategoryAttribute").Categories
    
    $valideCategory = @('Path')
    if ($valideCategory -contains $category)
    {
        return $true
    }
    return $false
}

function New-ExampleForParameterSet()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.CommandInfo]
        $ParameterSetInfo
    )
    $parameters = $ParameterSetInfo.Parameters.Values | Where-Object { Test-ParameterFromSwagger $_ }
    $result = @()
    foreach ($parameter in $parameters)
    {
        $category = (Get-ParameterAttribute -parameterInfo $parameter -AttributeName "CategoryAttribute").Categories
        $sourceName = (Get-ParameterAttribute -parameterInfo $parameter -AttributeName "InfoAttribute").SerializedName
        $name = $parameter.Name
        $result += @{
            name = "-$Name"
            value = "[$category.$sourceName]"
        }
    }

    return $result
}

function New-ParameterArrayInParameterSet()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.CommandInfo]
        $ParameterSetInfo
    )
    $parameters = $ParameterSetInfo.Parameters.Values | Where-Object { Test-ParameterFromSwagger $_ }
    $result = @()
    foreach ($parameter in $parameters)
    {
        $isMandatory = (Get-ParameterAttribute -parameterInfo $parameter -AttributeName "ParameterAttribute").Mandatory
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

function New-MetadataForParameterSet()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Management.Automation.CommandInfo]
        $ParameterSetInfo
    )
    $httpAttribute = Get-CmdletAttribute -CmdletInfo $ParameterSetInfo -AttributeName "HttpPathAttribute"
    $httpPath = $httpAttribute.Path
    $apiVersion = $httpAttribute.ApiVersion
    $provider = [System.Text.RegularExpressions.Regex]::New("/providers/([\w+\.]+)/").Match($httpPath).Groups[1].Value
    $resourcePath = "/" + $httpPath.Split("$provider/")[1]
    $resourceType = [System.Text.RegularExpressions.Regex]::New("/([\w]+)/\{\w+\}").Matches($resourcePath) | ForEach-Object {$_.groups[1].Value} | Join-String -Separator "/"
    $cmdletName = Get-MappedCmdletFromFunctionName $ParameterSetInfo.Name
    $description = (Get-CmdletAttribute -CmdletInfo $ParameterSetInfo -AttributeName "DescriptionAttribute").Description
    $example = New-ExampleForParameterSet $ParameterSetInfo
    $signature = New-ParameterArrayInParameterSet $ParameterSetInfo

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

function Merge-WithExistCmdletMetadata()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [System.Collections.Specialized.OrderedDictionary]
        $ExistedCmdletInfo,
        [Parameter()]
        [Hashtable]
        $ParameterSetMetadata
    )
    $ExistedCmdletInfo.help.parameterSets += $ParameterSetMetadata.Signature
    $ExistedCmdletInfo.examples += [ordered]@{
        description = $ParameterSetMetadata.Description
        parameters = $ParameterSetMetadata.Example
    }

    return $ExistedCmdletInfo
}

function New-MetadataForCmdlet()
{
    [CmdletBinding()]
    Param (
        [Parameter()]
        [Hashtable]
        $ParameterSetMetadata
    )
    $cmdletName = $ParameterSetMetadata.CmdletName
    $description = Get-CmdletDescription $cmdletName
    $result = [ordered]@{
        name = $cmdletName
        description = $description
        path = $ParameterSetMetadata.Path
        help = [ordered]@{
            learnMore = [ordered]@{
                url = "https://learn.microsoft.com/powershell/module/$moduleName/$cmdletName".ToLower()
            }
            parameterSets = @()
        }
        examples = @()
    }
    $result = Merge-WithExistCmdletMetadata -ExistedCmdletInfo $result -ParameterSetMetadata $ParameterSetMetadata
    return $result
}

$parameterSets = $parameterSetsInfo.ExportedCmdlets.Keys | Where-Object { Test-functionSupported($_) }
$resourceTypes = @{}
foreach ($parameterSetName in $parameterSets)
{
    $cmdletInfo = $parameterSetsInfo.ExportedCommands[$parameterSetName]
    $parameterSetMetadata = New-MetadataForParameterSet -ParameterSetInfo $cmdletInfo
    $cmdletName = $parameterSetMetadata.CmdletName
    if (-not ($moduleInfo.ExportedCommands.ContainsKey($cmdletName)))
    {
        continue
    }
    if ($resourceTypes.ContainsKey($parameterSetMetadata.ResourceType))
    {
        $ExistedCmdletInfo = $resourceTypes[$parameterSetMetadata.ResourceType].commands | Where-Object { $_.name -eq $cmdletName }
        if ($ExistedCmdletInfo)
        {
            $ExistedCmdletInfo = Merge-WithExistCmdletMetadata -ExistedCmdletInfo $ExistedCmdletInfo -ParameterSetMetadata $parameterSetMetadata
        }
        else
        {
            $cmdletInfo = New-MetadataForCmdlet -ParameterSetMetadata $parameterSetMetadata
            $resourceTypes[$parameterSetMetadata.ResourceType].commands += $cmdletInfo
        }
    }
    else
    {
        $cmdletInfo = New-MetadataForCmdlet -ParameterSetMetadata $parameterSetMetadata
        $resourceTypes[$parameterSetMetadata.ResourceType] = [ordered]@{
            resourceType = $parameterSetMetadata.ResourceType
            apiVersion = $parameterSetMetadata.ApiVersion
            learnMore = @{
                url = "https://learn.microsoft.com/powershell/module/$moduleName".ToLower()
            }
            commands = @($cmdletInfo)
            provider = $parameterSetMetadata.Provider
        }
    }
}

if (Test-Path "UX")
{
    Remove-Item -Path "UX" -Recurse
}
New-Item -ItemType Directory -Path "UX"

foreach ($resourceType in $resourceTypes.Keys)
{
    $resourceTypeFileName = $resourceType -replace "/", "-"
    $resourceTypeInfo = $resourceTypes[$resourceType]
    $provider = $resourceTypeInfo.provider
    $providerFolder = "UX/$provider"
    if (-not (Test-Path $providerFolder))
    {
        New-Item -ItemType Directory -Path $providerFolder
    }
    $resourceTypeInfo.Remove("provider")
    $resourceTypeInfo | ConvertTo-Json -Depth 10 | Out-File "$providerFolder/$resourceTypeFileName.json"
}
