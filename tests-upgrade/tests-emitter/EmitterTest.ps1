param(
    [Parameter(Mandatory,
        ParameterSetName = "SingleTestCase",
        HelpMessage = "Specify single test case to run")]
    [string]
    $TestName,

    [Parameter(Mandatory,
        ParameterSetName = "WhiteTestCase",
        HelpMessage = "Load white test case list from configuration to run")]
    [switch]$AllowList,
    
    [Parameter(Mandatory,
        ParameterSetName = "BlackTestCase",
        HelpMessage = "Load all test cases in the current folder and remove test cases that exist in the blacklist")]
    [switch]$BlackList,


    [string]
    $PowerShellEmitter,

    [switch]
    $SaveResult
)

enum GeneratedStatus {
    Failed
    Success
    Skipped
}

enum ComparedStatus {
    Equal
    NotEqual
}

class TestEmitterModel {
    [string]$TestName
    [GeneratedStatus]$EmitterGeneratedStatus
    [ComparedStatus]$CodeComparedStatus
    [string]$GeneratedCodeFolder
    [string]$TargetCodeFolder
    [string[]]$Result
    [string]$Comment
}


function GenerateModuleWithEmitter {
    param (
        [TestEmitterModel]
        $TestEmitter
    )
    $result = (tsp compile ./ --emit $script:PowerShellEmitter) | Out-String
    Write-Debug "$($TestEmitter.TestName) generated powershell debug information"
    Write-Debug $result

    if ($LASTEXITCODE -ne 0) {
        return $false
    }
    elseif (!(Test-Path -Path $TestEmitter.TargetCodeFolder)) {
        return $false
    }
    else {
        return $true
    }
}

function  GenerateCodeWithEmitter {
    param (
        [TestEmitterModel]
        $TestEmitter
    )
    Set-Location (Join-Path $TestEmitter.GeneratedCodeFolder '..')
    if ((GenerateModuleWithEmitter -TestEmitter $TestEmitter)) {
        $TestEmitter.EmitterGeneratedStatus = [GeneratedStatus]::Success
    }
    else {
        $TestEmitter.EmitterGeneratedStatus = [GeneratedStatus]::Failed
        $TestEmitter.Result += $TestEmitter.EmitterGeneratedStatus ? $null : "PowerShell module failed to generate"
    }
    Set-Location $PSScriptRoot
}

function CompareGenerateFileCount {
    param (
        [string[]]
        $GeneratedFileNames,

        [string[]]
        $TargetFileNames
    )
    $result = @{"result" = $null; "files" = @() }
    $ignoreFiles = @(".gitignore")

    foreach ($GeneratedFileName in $GeneratedFileNames) {
        if ($ignoreFiles -contains $GeneratedFileName) {
            #skip ignored files
            continue
        }
        if ($TargetFileNames -notcontains $GeneratedFileName) {
            $result["result"] += "$GeneratedFileName not extis in target folder. " 
        }
        else {
            $result["files"] += $GeneratedFileName
        }
    }

    foreach ($TargetFileName in $TargetFileNames) {
        if ($ignoreFiles -contains $TargetFileName) {
            #skip ignored files
            continue
        }
        if ($GeneratedFileNames -notcontains $TargetFileName) {
            $result["result"] += "$TargetFileName not extis in generated folder. " 
        }
    }

    return $result
}

function CompareSingleGeneratedFile {
    param (
        [string]
        $GeneratedFilePath,

        [string]
        $TargetFilePath
    )
    $fileName = Split-Path -Path $GeneratedFilePath -Leaf

    $validGeneratedContent = ((Get-Content -Path $GeneratedFilePath) | ForEach-Object { ($_ -replace "\s+", "") } `
        | Where-Object { (($_ -notlike "*//*") -and ($_ -ne "") -and ($_ -ne '{') -and ($_ -ne '}') -and ($_ -ne '};')) })

    $validTargetContent = ((Get-Content -Path $TargetFilePath) | ForEach-Object { ($_ -replace "\s+", "") } `
        | Where-Object { (($_ -notlike "*//*") -and ($_ -ne "") -and ($_ -ne '{') -and ($_ -ne '}') -and ($_ -ne '};')) })
    
    if ($validGeneratedContent.Length -ne $validTargetContent.Length) {
        return @{"compared" = $false; "result" = "$fileName - content different" }
    }
    foreach ($generatedContent in $validGeneratedContent) {
        if ($validTargetContent -notcontains $generatedContent) {
            return @{"compared" = $false; "result" = "$fileName - content different" }
        }
    }

    return @{"compared" = $true; "result" = $null }

}

function CompareTestEmitterCode { 
    param (
        [TestEmitterModel]
        $TestEmitter,
        
        [string[]]
        $ignoreFiles
    )
    if ($TestEmitter.EmitterGeneratedStatus -eq [GeneratedStatus]::Failed) {
        $TestEmitter.CodeComparedStatus = [ComparedStatus]::NotEqual
        return
    }
    else {
        $generatedFiles = Get-ChildItem -Path $TestEmitter.GeneratedCodeFolder -Recurse -File | Where-Object {
            $exclude = $false
            foreach ($excludePath in $ignoreFiles) {
                if ($_.FullName -like "*$excludePath*") {
                    $exclude = $true
                    break
                }
            }
            -not $exclude
        }
        $targetFiles = Get-ChildItem -Path $TestEmitter.TargetCodeFolder -Recurse -File | Where-Object {
            $exclude = $false
            foreach ($excludePath in $ignoreFiles) {
                if ($_.FullName -like "*$excludePath*") {
                    $exclude = $true
                    break
                }
            }
            -not $exclude
        }
        $compareResult = (CompareGenerateFileCount -GeneratedFileNames $generatedFiles.Name -TargetFileNames $targetFiles.Name)
        $isFileContentEqual = $true
        if ($null -ne $compareResult["result"]) {
            $TestEmitter.Result += $compareResult["result"]
            $isFileContentEqual = $false
        }
        # Get files that exist in generated and target folder
        $existGeneratedFiles = $generatedFiles | Where-Object { $compareResult["files"] -contains $_.Name }

        foreach ($existFile in $existGeneratedFiles) {
            $targetFile = $targetFiles | Where-Object { $_.FullName.Replace([System.IO.Path]::DirectorySeparatorChar + 'target', [System.IO.Path]::DirectorySeparatorChar + 'generated') -eq $existFile.FullName }
            $fileCompareResult = CompareSingleGeneratedFile -GeneratedFilePath $existFile.FullName -TargetFilePath $targetFile.FullName
            if (!$fileCompareResult["compared"]) {
                $TestEmitter.Result += $fileCompareResult["result"]
                $isFileContentEqual = $false
            }
        }

        if ($isFileContentEqual) {
            $TestEmitter.CodeComparedStatus = [ComparedStatus]::Equal
        }
        else {
            $TestEmitter.CodeComparedStatus = [ComparedStatus]::NotEqual
        }
    } 
}

try {
    if ([System.String]::IsNullOrEmpty($PowerShellEmitter)) {
        $PowerShellEmitter = Join-Path $PSScriptRoot "..\..\packages\typespec-powershell"
    }

    $configuration = (Get-Content -Path (Join-Path $PSScriptRoot "configuration.json") | ConvertFrom-Json)
    # Some folders are not test folders.
    $ignoreFolder = $configuration.ignoreFolder
    # Skip no need compare file.
    $ignoreCompareFiles = $configuration.ignoreCompareFile
    $testEmitterSummary = @()

    $compareResultFolder = Join-Path $PSScriptRoot "CompareResult"

    if (!(Test-Path -Path $compareResultFolder)) {
        New-Item -Path $compareResultFolder -ItemType "directory"
    }
    if ($TestName) {
        $testFolder = Join-Path $PSScriptRoot $TestName
        if ((Test-Path -Path $testFolder)) {
            $tests += (Get-Item -Path $testFolder)
        }
        else {
            Throw "$TestName folder not exist."
        }
    } 
    if ($BlackList) {
        $blackTestList = $configuration.blackTestList
        $tests = (Get-ChildItem -Path $PSScriptRoot -Directory -Exclude ($blackTestList + $ignoreFolder)) | Sort-Object { $_.Name }
    }
    if ($AllowList) {
        $whiteTestList = $configuration.whiteTestList
        $tests = @()
        foreach ($whiteTest in $whiteTestList) {
            $testFolder = Join-Path $PSScriptRoot $whiteTest
            if ((Test-Path -Path $testFolder)) {
                $tests += (Get-Item -Path $testFolder)
            }
            else {
                Throw "Test $whiteTest folder not exist."
            }
        }
    }

    foreach ($test in $tests) {
        $testEmitter = [TestEmitterModel]::new()
        $testEmitter.TestName = $test.Name
        $testEmitter.EmitterGeneratedStatus = [GeneratedStatus]::Failed
        $testEmitter.CodeComparedStatus = [ComparedStatus]::NotEqual
        $testEmitter.GeneratedCodeFolder = (Join-Path $test.FullName 'generated')
        $testEmitter.TargetCodeFolder = (Join-Path $test.FullName 'target')
        $testEmitterSummary += $testEmitter
    }
    
    foreach ($testEmitter in $testEmitterSummary) {
        Write-Host "test $($testEmitter.TestName) testing...."
        GenerateCodeWithEmitter -TestEmitter $testEmitter
        CompareTestEmitterCode -TestEmitter $testEmitter -ignoreFiles $ignoreCompareFiles
        $testEmitter.Comment = ($testEmitter.Result | Out-String)
        $testEmitter | Select-Object -Property TestName, EmitterGeneratedStatus, CodeComparedStatus, Comment | Format-Table
    }
    if ($PSCmdlet.ParameterSetName -ne 'SingleTestCase' ) {
        Write-Host "Summary results as following"
        # Show summary test result
        $testEmitterSummary | Select-Object -Property TestName, EmitterGeneratedStatus, CodeComparedStatus, Comment | Format-Table
    }
    if ($testEmitterSummary.CodeComparedStatus -contains [ComparedStatus]::NotEqual) {
        throw 'The code generated by the typespec-powershell emitter is different from the target code.'
    }
    else {
        Write-Host 'All generated codes are as expected.'
    }
}
catch {
    Write-Error "An error occurred"
    Write-Error ($_ | Out-String)
}
finally {
    # Save test result to csv file
    if ($SaveResult) {
        $resultFilePath = Join-Path $compareResultFolder "typespec-powershell-generated-code-compare-$((Get-Date).ToString('yyyyMMddHHmmss')).csv"
        Write-Host "The output result to the $resultFilePath"
        $testEmitterSummary | Select-Object -Property TestName, EmitterGeneratedStatus, CodeComparedStatus, Comment | Export-Csv -Path  $resultFilePath -NoClobber
    }
}