# This script is used to compare the SDK models generated by autorest.csharp and the SDK models generated by autorest.powershell.
# e.g. $diffList = compareModel -csModelPath .\aks\Models\ -ps C:\Users\{user}\source\azure-powershell\src\aks\Aks.Sdk\Generated\Models\
function CompareModel {

    param([string]$csModelPath, [string]$psModelPath)
    $res = @{}
    Write-Host "Load models from $csModelPath"
    $CsModelFiles = Get-ChildItem -Path $csModelPath -Recurse -Filter *.cs
    $CsContent = ''
    $null = $CsModelFiles | ForEach-Object -Process { $CsContent += get-content $_.fullname -raw }

    $CsTree = [Microsoft.CodeAnalysis.CSharp.SyntaxFactory]::ParseCompilationUnit($CsContent)
    $CsNodes = $CsTree.ChildNodes().ChildNodes() | Where-Object { ($_.Keyword.value -eq 'class')}

    Write-Host "Load models from $psModelPath"
    $PsModelFiles = Get-ChildItem -Path $psModelPath -Recurse -Filter *.cs
    $PsContent = ''
    $null = $PsModelFiles | ForEach-Object -Process { $PsContent += get-content $_.fullname -raw }

    $PsTree = [Microsoft.CodeAnalysis.CSharp.SyntaxFactory]::ParseCompilationUnit($PsContent)
    $PsNodes = $PsTree.ChildNodes().ChildNodes() | Where-Object { ($_.Keyword.value -eq 'class')}
    $PsNodesMap = @{}
    foreach ($PsNode in $PsNodes) {
        $PsNodesMap[$PsNode.Identifier.value] = $PsNode
    }

    foreach ($CsNode in $CsNodes)
    {
        $CsClassName = $CsNode.Identifier.value
        #Write-Host $CsClassName
        $PsNode = $PsNodesMap[$CsClassName]
        #$PsNode = $PsNodes | Where-Object { $_.Identifier.value -eq $CsClassName }
        if ($PsNode -eq $null) {
            $res[$CsClassName] = ''
        } else {
            $csMembers = $CsNode.Members | Where-Object { ($_.Kind() -eq 'PropertyDeclaration') -and ($_.Modifiers.ToString() -eq 'public') }
            $psMembers = $PsNode.Members | Where-Object { ($_.Kind() -eq 'PropertyDeclaration') -and ($_.Modifiers.ToString() -eq 'public') }
            foreach ($csMember in $csMembers) {
                $csMemberName = $csMember.Identifier.value
                $psMember = $psMembers | Where-Object { $_.Identifier.value -ceq $csMemberName }
                if ($psMember -eq $null) {
                    $res[$CsClassName] = $res[$CsClassName] -eq $null ? $csMemberName : $res[$CsClassName] + ',' + $csMemberName
                }
            }
        }
    }
    return $res
}

# List the models used in automapper
# e.g. $usedmodels = listUsedModels -mapFile C:\Users\{user}\source\azure-powershell\src\Network\Network\Common\NetworkResourceManagerProfile.cs
function listUsedModels {
    param([string]$mapFile)
    $res = @()
    $pattern = "cfg\.CreateMap<[^>]+,\s*[^>]+>"
    $content = get-content $mapFile -raw
    $matchedItems = [regex]::Matches($content, $pattern)
    foreach ($item in $matchedItems) {
        if ($item.Value -match 'cfg\.CreateMap<([^>]+), ([^>]+)>') {
            if ($matches[1].StartsWith('MNM.') -and !$res.Contains($matches[1].split('.')[1])) {
                $res += $matches[1].split('.')[1]
            }
            if ($matches[2].StartsWith('MNM.') -and !$res.Contains($matches[2].split('.')[1])) {
                $res += $matches[2].split('.')[1]
            }
        }
    }
    return $res
}