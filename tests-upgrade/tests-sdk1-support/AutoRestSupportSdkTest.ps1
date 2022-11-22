param(
    [Parameter(Mandatory,
        ParameterSetName="SingleTestCase",
        HelpMessage="Specify single test case to run")]
    [string]
    $TestName,

    [Parameter(Mandatory,
        ParameterSetName="WhiteTestCase",
        HelpMessage="Load white test case list from configuration to run")]
    [switch]$AllowList,
    
    [Parameter(Mandatory,
        ParameterSetName="BlackTestCase",
        HelpMessage="Load all test cases in the current folder and remove test cases that exist in the blacklist")]
    [switch]$BlackList,

    [string]
    $AutoRestCsharp,

    [string]
    $AutoRestPowerShell,

    [switch]
    $SaveResult
)

enum GeneratedStatus {
    Failed
    Success
}

enum ComparedStatus {
    Equal
    NotEqual
}

class TestSdkModel {
    [string]$TestName
    [GeneratedStatus]$CsharpGeneratedStatus
    [GeneratedStatus]$PowerShellGeneratedStatus
    [ComparedStatus]$SdkComparedStatus
    [string]$CsharpSdkFolder
    [string]$PowerShellSdkFolder
    [string[]]$Result
    [string]$Comment
}

function GenerateAutorestCshapSdkCode {
    param (
        [TestSdkModel]
        $TestSdk
    )
    $result = (autorest --use:$script:AutoRestCsharp --tag=$($TestSdk.TestName).csharp) | Out-String
    Write-Debug "$($TestSdk.TestName) generated csharp debug information"
    Write-Debug $result
    if (($result -match 'error') -or ($result -match 'exception') -or ($result -match 'fatal') -or ($result -match 'fail')) {
        return $false
    } elseif(!(Test-Path -Path $TestSdk.CsharpSdkFolder)) {
        return $false
    } else {
        return $true
    }
}

function GenerateAutorestPowerShellSdkCode {
    param (
        [TestSdkModel]
        $TestSdk
    )
    $result = (autorest --use:$script:AutoRestPowerShell --tag=$($TestSdk.TestName).powershell) | Out-String
    Write-Debug "$($TestSdk.TestName) generated powershell debug information"
    Write-Debug $result

    if (($result -match 'error') -or ($result -match 'exception') -or ($result -match 'fatal') -or ($result -match 'fail')) {
        return $false
    } elseif(!(Test-Path -Path $TestSdk.PowerShellSdkFolder)) {
        return $false
    }else {
        return $true
    }
}

function  GenerateSdkCode {
    param (
        [TestSdkModel]
        $TestSdk
    )
    if ((GenerateAutorestCshapSdkCode -TestSdk $TestSdk)) {
        $TestSdk.CsharpGeneratedStatus = [GeneratedStatus]::Success
    } else {
        $TestSdk.CsharpGeneratedStatus = [GeneratedStatus]::Failed
        $TestSdk.Result += $TestSdk.CsharpGeneratedStatus ? $null : "Csharp sdk code failed generated"
    }
    
    if ((GenerateAutorestPowerShellSdkCode -TestSdk $TestSdk)) {
        $TestSdk.PowerShellGeneratedStatus = [GeneratedStatus]::Success
    } else {
        $TestSdk.PowerShellGeneratedStatus = [GeneratedStatus]::Failed
        $TestSdk.Result += $TestSdk.PowerShellGeneratedStatus ? $null : "PowerShell sdk code failed generated"
    }
}

function CompareSdkGenerateFileCount {
    param (
        [string[]]
        $CsharpSdkFileNames,

        [string[]]
        $PowerShellSdkFileNames
    )
    $result = @{"result" = $null; "files" = @()}

    foreach($csharpFileName in $CsharpSdkFileNames) {
        if ($PowerShellSdkFileNames -notcontains $csharpFileName) {
            $result["result"] += "$csharpFileName not extis" 
        } else {
            $result["files"] += $csharpFileName
        }
    }
    return $result
}

function CompareSingleSdkFile {
    param (
        [string]
        $CsharpFilePath,

        [string]
        $PowerShellFilePath
    )
    $fileName = Split-Path -Path $CsharpFilePath -Leaf
    $validCsharpContent = ((Get-Content -Path $CsharpFilePath) | ForEach-Object {($_ -replace "\s+", "")} `
        | Where-Object {(($_ -notlike "*//*") -and ($_ -ne "") -and ($_ -ne '{') -and ($_ -ne '}') -and ($_ -ne '};'))})

    $validPowerShellContent = ((Get-Content -Path $PowerShellFilePath)| ForEach-Object {($_ -replace "\s+", "")} `
        | Where-Object {(($_ -notlike "*//*") -and ($_ -ne "") -and ($_ -ne '{') -and ($_ -ne '}') -and ($_ -ne '};'))})
    
    if ($validCsharpContent.Length -ne $validPowerShellContent.Length) {
        return @{"compared" = $false; "result" = "$fileName - content different"}
    }
    foreach($csharpContent in $validCsharpContent) {
        if ($validPowerShellContent -notcontains $csharpContent)
        {
            return @{"compared" = $false; "result" = "$fileName - content different"}
        }
    }

    return @{"compared" = $true; "result" = $null}

}

function CompareTestSdkCode { 
    param (
        [TestSdkModel]
        $TestSdk,
        
        [string[]]
        $ignoreFiles
    )
    if (($TestSdk.PowerShellGeneratedStatus -eq [GeneratedStatus]::Failed) -or ($TestSdk.CsharpGeneratedStatus -eq [GeneratedStatus]::Failed)) {
        $TestSdk.SdkComparedStatus = [ComparedStatus]::NotEqual
        return
    } else {
        $csharpFiles = Get-ChildItem -Path $TestSdk.CsharpSdkFolder -Recurse -File -Exclude $ignoreFiles
        $powershellFiles = Get-ChildItem -Path $TestSdk.PowerShellSdkFolder -Recurse -File -Exclude $ignoreFiles
        $compareResult = (CompareSdkGenerateFileCount -CsharpSdkFileNames $csharpFiles.Name -PowerShellSdkFileNames $powershellFiles.Name)
        $isFileContentEqual = $true
        if ($null -ne $compareResult["result"]) {
            $TestSdk.Result +=  $compareResult["result"]
            $isFileContentEqual = $false
        }
        # Get files that exist in csharp and powershell
        $existCsharpFiles = $csharpFiles | Where-Object {$compareResult["files"] -contains $_.Name}

        foreach($existFile in $existCsharpFiles)
        {
            $powershellFile = $powershellFiles | Where-Object {$_.Name -eq $existFile.Name}
            $fileCompareResult = CompareSingleSdkFile -CsharpFilePath $existFile.FullName -PowerShellFilePath $powershellFile.FullName
            if (!$fileCompareResult["compared"]) {
                $TestSdk.Result +=  $fileCompareResult["result"]
                $isFileContentEqual = $false
            }
        }

        if ($isFileContentEqual) {
            $TestSdk.SdkComparedStatus = [ComparedStatus]::Equal
        } else {
            $TestSdk.SdkComparedStatus = [ComparedStatus]::NotEqual
        }
    } 
}

try 
{
    if ([System.String]::IsNullOrEmpty($AutoRestCsharp)) {
        $AutoRestCsharp = Join-Path $PSScriptRoot "..\..\..\..\autorest.csharp"
    }
    if ([System.String]::IsNullOrEmpty($AutoRestPowerShell)) {
        $AutoRestPowerShell = Join-Path $PSScriptRoot "..\..\..\..\autorest.powershell"
    }

    $configuration = (Get-Content -Path (Join-Path $PSScriptRoot "configuration.json") | ConvertFrom-Json)
    # Some folders are not test folders.
    $ignoreFolder =  $configuration.ignoreFolder
    # Skip no need compare file.
    $ignoreCompareFiles = $configuration.ignoreCompareFile
    $testSdkSummary = @()

    $compareResultFolder = Join-Path $PSScriptRoot "CompareResult"

    if(!(Test-Path -Path $compareResultFolder))
    {
        New-Item -Path $compareResultFolder -ItemType "directory"
    }
    if($TestName) {
        $testFolder = Join-Path $PSScriptRoot $TestName
        if ((Test-Path -Path $testFolder)) {
            $tests +=  (Get-Item -Path $testFolder)
        } else {
            Throw "$TestName folder not exist."
        }
    } 
    if($BlackList) {
        $blackTestList =  $configuration.blackTestList
        $tests = (Get-ChildItem -Path $PSScriptRoot -Directory -Exclude ($blackTestList + $ignoreFolder)) | Sort-Object {$_.Name}
    }
    if($AllowList) {
        $whiteTestList = $configuration.whiteTestList
        $tests = @()
        foreach($whiteTest in $whiteTestList) {
            $testFolder = Join-Path $PSScriptRoot $whiteTest
            if ((Test-Path -Path $testFolder)) {
                $tests +=  (Get-Item -Path $testFolder)
            } else {
                Throw "Test $whiteTest folder not exist."
            }
        }
    }

    foreach($test in $tests) {
        $testSdk = [TestSdkModel]::new()
        $testSdk.TestName = $test.Name
        $testSdk.CsharpGeneratedStatus = [GeneratedStatus]::Failed
        $testSdk.PowerShellGeneratedStatus = [GeneratedStatus]::Failed
        $testSdk.SdkComparedStatus = [ComparedStatus]::NotEqual
        $testSdk.CsharpSdkFolder = (Join-Path $test.FullName 'csharp')
        $testSdk.PowerShellSdkFolder = (Join-Path $test.FullName 'powershell')
        $testSdkSummary += $testSdk
    }
    
    foreach($testSdk in $testSdkSummary) {
        Write-Host "test $($testSdk.TestName) testing...."
        GenerateSdkCode -TestSdk $testSdk
        CompareTestSdkCode -TestSdk $testSdk -ignoreFiles $ignoreCompareFiles
        $testSdk.Comment = ($testSdk.Result | Out-String)
        $testSdk | Select-Object -Property TestName, CsharpGeneratedStatus, PowerShellGeneratedStatus, SdkComparedStatus, Comment | Format-Table
    }
    Write-Host "Summary results as following"
    # Show summary test result
    $testSdkSummary | Select-Object -Property TestName, CsharpGeneratedStatus, PowerShellGeneratedStatus, SdkComparedStatus, Comment | Format-Table

    if ($testSdkSummary.SdkComparedStatus -contains [ComparedStatus]::NotEqual) {
        throw 'The code generated by the autorest.powershell file is different from the code generated by the autorest.csharp.'
    } else
    {
        Write-Host 'All generated codes are the same'
    }
} catch {
    Write-Error "An error occurred"
    Write-Error ($_ | Out-String)
} finally {
    # Save test result to csv file
    if ($SaveResult) {
        $resultFilePath = Join-Path $compareResultFolder "autorest.powershell-sdk-compare-$((Get-Date).ToString('yyyyMMddHHmmss')).csv"
        Write-Host "The output result to the $resultFilePath"
        $testSdkSummary | Select-Object -Property TestName, CsharpGeneratedStatus, PowerShellGeneratedStatus, SdkComparedStatus, Comment | Export-Csv -Path  $resultFilePath -NoClobber
    }
}