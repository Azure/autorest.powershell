﻿param([switch]$Generate,[string]$TestName,[switch]$SourceVersion,[switch]$TargetVersion,[switch]$AllowList,[switch]$BlackList)
#Need to use the right version of node.js
#nvs use 14.15.5
#Create folder to save Compare Results
if(!(Test-Path CompareResult))
{
    New-Item CompareResult -ItemType "directory"
}
#Define the success code names
$global:testNameStr
#Define the global param 'isError' to determine wheather throw the error
$global:isError = $false
#Import the Configuration Json 
$conf = (Get-Content 'Configuration.json') | ConvertFrom-Json
if($AllowList)
{
    #Get the whiteList from json
    $whiteList = $conf.WhiteList
}
if($BlackList)
{
    #Get the blackList from json
    $blackTestList = $conf.BlackList
}

#Determine whether the difference is command
function IsCommand([Object]$SourceFile , [Object]$TargetFile)
{
    $isCommandResult = $True
    $difference = Compare-Object $SourceFile $TargetFile
    foreach($line in $difference)
    {
        $lineInfo = $line.InputObject.Replace(' ','')
        $lineCompareResult =$lineInfo.Startswith('//')
        if(!$lineCompareResult)
        {
            $isCommandResult = $false
            break
        }
    }
    return $isCommandResult
}

#Determine the filefolder in BlackList
function IsInBlackList([Object]$JudgList,[Array]$BlackContent)
{
    $isInBlackListResult = $false
    foreach($BlackDetail in $BlackContent)
    {
        if((!((Get-Item $JudgList.PSPath) -is [System.IO.DirectoryInfo])) -or ($JudgList.Name.Startswith($BlackDetail)) -or ($JudgList.Name.Startswith('Compare')))
        {
            $isInBlackListResult = $True
            break
        }
    }
    return $isInBlackListResult
}

#Determine whether the file needs to be ignored
function IsNeedIgnore([string]$inputFileName , [Array]$ignoreArray)
{
    $Ignore = $false
    foreach($ignoreDetail in $ignoreArray)
    {
        if($inputFileName.Startswith($ignoreDetail))
        {
           $Ignore =$True
           break
        } elseif ($ignoreDetail.Contains("*.") -and $inputFileName.EndsWith($ignoreDetail.Split(".")[-1])) {
            $Ignore =$True
            break
        }
    }
    return $Ignore
}

#Code generation
function GenerateCode()
{
    $GenerateResult=$True
    #source and generate codes all need to be generated
    if((-not $SourceVersion) -and (-not $TargetVersion))
    {
        #generate source code
        Write-Host -ForegroundColor Green 'M3'
        $GenerateSourceResult = autorest --use:@autorest/powershell@2.1.400 --output-folder:.\generate\m3 --Debug | Out-string
        #generate target code
        Write-Host -ForegroundColor Green 'M4'
        $GenerateTargetResult = autorest --use:..\..\ --output-folder:.\generate\m4 --Debug | Out-string
        if(!$GenerateSourceResult.Contains('Generation Complete') -or !$GenerateTargetResult.Contains('Generation Complete'))
        {
            $GenerateResult = $false
        }
    }elseif($SourceVersion)
    {
        Write-Host -ForegroundColor Green 'M3'
        $GenerateSourceResult = autorest --use:@autorest/powershell@2.1.400 --output-folder:.\generate\m3 --Debug | Out-string
        if(!$GenerateSourceResult.Contains('Generation Complete'))
        {
            $GenerateResult = $false
        }
    }else
    {
        Write-Host -ForegroundColor Green 'M4'
        $GenerateTargetResult = autorest --use:..\..\ --output-folder:.\generate\m4 --Debug | Out-string
        if(!$GenerateTargetResult.Contains('Generation Complete'))
        {
            $GenerateResult = $false
        }
    }
    return $GenerateResult
}

#Compare the gap between the two versions
function CompareGeneratedCode([string]$inputSourcePath,[string]$inputTargetPath,[string]$testFileName)
{
    #to creare ecah dictionary (the struct is (string,obj))
    #the key is the path of each file,and the obj has two parameters(hashcodevalue,status)
    $initialDict =  @{}
    #in m3Path
    cd $inputSourcePath
    $initFileList = Get-ChildItem -Recurse -force
    $initIgnoreFileList = (($inputSourcePath+'\generated\modules'), ($inputSourcePath+'\utils'), ($inputSourcePath+'\*.nuspec'), ($inputSourcePath+'\.gitignore'),($inputSourcePath+'\tools\Resources\.gitignore'))
    $targetIgnoreFileList = (($inputTargetPath+'\generated\modules'), ($inputTargetPath+'\utils'),($inputTargetPath+'\*.nuspec'),($inputTargetPath+'\.gitignore'),($inputTargetPath+'\tools\Resources\.gitignore'))
    #foreach initFileList and get the hashcode of them
    foreach( $initFile in $initFileList)
    {
        $ignoreResult = IsNeedIgnore -inputFileName $initFile.FullName -ignoreArray $initIgnoreFileList
        if(!$ignoreResult)
        {
            #create an object with HashCode, Status
            $obj = New-Object psobject | Select-Object -Property HashCode, Status
            #if the file is not filefolder
            if(!((Get-Item $initFile.PSPath) -is [System.IO.DirectoryInfo]))
            {
                #get the hashcode of the file
                $hashTable = $initFile.PSPath.Replace('Microsoft.PowerShell.Core\FileSystem::','') | get-filehash
                # $hashTable
                $obj.HashCode = $hashTable.Hash
                #get the path of the file
                $detailPath = $hashTable.Path.Replace($inputSourcePath,'')
                $initialDict.Add($detailPath,$obj)
            }
        }
    }
    $targetDict =  @{}
    #in TargetPath
    cd $inputTargetPath
    $targetFileList = Get-ChildItem -Recurse -force
    #foreach initFileList and get the hashcode of them
    foreach( $targetFile in $targetFileList)
    {
        $ignoreResult = IsNeedIgnore -inputFileName $targetFile.FullName -ignoreArray $targetIgnoreFileList
        if(!$ignoreResult)
        {
            $obj = New-Object psobject | Select-Object -Property HashCode, Status
            #if the file is not filefolder
            if(!((Get-Item $targetFile.PSPath) -is [System.IO.DirectoryInfo]))
            {
                #get the hashcode of the file
                $hashTable = $targetFile.PSPath.Replace('Microsoft.PowerShell.Core\FileSystem::','') | get-filehash
                $obj.HashCode = $hashTable.Hash
                #get the path of the file
                $detailPath = $hashTable.path.Replace($inputTargetPath,'')
                $targetDict.Add($detailPath,$obj)
            }
        }
    }
    [object[]] $difArray=@()

    #search each dictDetail in targetDict
    #the status means: 0 this file do not exist in anouther filefolder
    #                   1 the hashcode of the file is the same as that in another filefolder
    #                   2 the hashcode of the file is different from that in another filefolder
    foreach($initDictDetail in $initialDict.Keys)
    {
        $difDetail = New-Object psobject | Select-Object -Property fileName,Path,fileFolderName,Status
        #if the file not exists in targetDict
        if($targetDict[$initDictDetail] -eq $null)
        {
            $difDetail.Path = $initDictDetail
            $difDetail.fileFolderName = 'M3'
            $splitStrings = $initDictDetail.Split('\')
            $difDetail.fileName = $splitStrings[$splitStrings.count-1]
            $difDetail.status = 'lack in M4'
            #sign up the status of the file
            $initialDict[$initDictDetail].status = 0
            $difArray+= $difDetail
        }elseif($targetDict[$initDictDetail].HashCode -ne $initialDict[$initDictDetail].HashCode)
        {
            $M3CompareFile = Get-Content ($inputSourcePath + $initDictDetail)
            $M4CompareFile = Get-Content ($inputTargetPath + $initDictDetail)
            $isCommandResult = IsCommand -SourceFile $M3CompareFile -TargetFile $M4CompareFile
            if( $isCommandResult -ne $True)
            {
                $difDetail.Path = $initDictDetail
                $difDetail.fileFolderName = 'M3'
                $splitStrings = $initDictDetail.Split('\')
                $difDetail.fileName = $splitStrings[$splitStrings.count-1]
                $difDetail.status = 'different'
                #sign up the status of the file
                $initialDict[$initDictDetail].status = 2
                $targetDict[$initDictDetail].status = 2
                $difArray+=$difDetail
            }else
            {
                $initialDict[$initDictDetail].status = 1
                $targetDict[$initDictDetail].status = 1
            }
        }else
        {
            $initialDict[$initDictDetail].status = 1
            $targetDict[$initDictDetail].status = 1
        }
    }
    #search those files which status is null 
    foreach($targetDetail in $targetDict.Keys)
    {
        $difDetail = New-Object psobject | Select-Object -Property fileName,Path,fileFolderName,Status
        if($targetDict[$targetDetail].Status -eq $null)
        {
            $difDetail.Path = $targetDetail
            $difDetail.fileFolderName = 'M4'
            $splitStrings = $targetDetail.Split('\')
            $difDetail.fileName = $splitStrings[$splitStrings.count-1]
            $difDetail.Status = 'lack in m3'
            $difArray+=$difDetail
        }
    }
    if($difArray.Count -gt 0)
    {
        $global:isError=$True
        $filename = Join-Path $PSScriptRoot 'CompareResult' ($testFileName + (get-date -format 'yyyyMMddhhmmss') + '.csv')
        $difArray | Select-Object -Property fileName,Path,fileFolderName,Status | Sort-Object -Property fileName | Export-CSV -path $filename
        Write-Warning ('There are ' + $difArray.Count + ' different files')
    }else
    {
        $global:testNameStr+= $testFileName +"`n"
    }
}

$currentPath = Get-Location
$fileList = Get-ChildItem
#if only one case
if($TestName -ne $null -and ($TestName -ne ''))
{
    cd ($PSScriptRoot+'\'+$TestName)
    try
    {
        $IsGenerateSuccess = GenerateCode
        if(-not $Generate -and $IsGenerateSuccess)
        {
            $sourceFilePath = Join-Path $PSScriptRoot $TestName 'generate\m3'
            $targetFilePath = Join-Path $PSScriptRoot $TestName 'generate\m4'
            CompareGeneratedCode -inputSourcePath $sourceFilePath -inputTargetPath $targetFilePath -testFileName $TestName
        }
    }
    catch
    {
        Write-Host -ForegroundColor yellow 'Generate error:' + $fileDetail.Name
    }
}elseif($AllowList)
{
    #get each testfolder in whiteList
    foreach($eachTest in $whiteList)
    {
        $eachTest
        cd (Join-Path $PSScriptRoot $eachTest)
        try
        {
            $IsGenerateSuccess = GenerateCode
            if(-not $Generate -and $IsGenerateSuccess)
            {
                $sourceFilePath = Join-Path $PSScriptRoot $eachTest 'generate\m3'
                $targetFilePath = Join-Path $PSScriptRoot $eachTest 'generate\m4'
                CompareGeneratedCode -inputSourcePath $sourceFilePath -inputTargetPath $targetFilePath -testFileName $eachTest
            }
        }
        catch
        {
            Write-Host -ForegroundColor yellow 'Generate error:' + $fileDetail.Name
        }
    }
}elseif($BlackList)
{
    #get each testfolder and except those tests in blacklist
    foreach($fileDetail in $fileList)
    {
        $InBlackListResult = IsInBlackList -JudgList $fileDetail -BlackContent $blackTestList
        if(!$InBlackListResult)
        {
            try
            {
                Write-Host $fileDetail.Name
                cd (Join-Path $PSScriptRoot $fileDetail.Name)
                $IsGenerateSuccess = GenerateCode
                if(-not $Generate -and $IsGenerateSuccess)
                {
                    $sourceFilePath = Join-Path $PSScriptRoot $fileDetail.Name 'generate\m3'
                    $targetFilePath = Join-Path $PSScriptRoot $fileDetail.Name 'generate\m4'
                    CompareGeneratedCode -inputSourcePath $sourceFilePath -inputTargetPath $targetFilePath -testFileName $fileDeatil.Name
                }
            }
            catch
            {
                Write-Host -ForegroundColor yellow 'Generate error:' + $fileDetail.Name
            }
        }
    }
}
else
{
    foreach($fileDetail in $fileList)
    {
        if(((Get-Item $fileDetail.PSPath) -is [System.IO.DirectoryInfo]) -and (!$fileDetail.Name.Startswith('Compare')))
        {
            $g1 = Join-Path $PSScriptRoot $fileDetail.Name
            cd ($PSScriptRoot +'\' +$fileDetail.Name)
            $deatilPath =Join-Path $PSScriptRoot $fileDetail.Name
            try
            {
                Write-Host -ForegroundColor Blue $fileDetail.Name
                $IsGenerateSuccess = GenerateCode
                if(-not $Generate -and $IsGenerateSuccess)
                {
                    $sourceFilePath = Join-Path $deatilPath 'generate\m3'
                    $targetFilePath = Join-Path $deatilPath 'generate\m4'
                    CompareGeneratedCode -inputSourcePath $sourceFilePath -inputTargetPath $targetFilePath -testFileName $fileDetail.Name
                }
            }
            catch
            {
                Write-Host -ForegroundColor yellow 'Generate error:' + $fileDetail.Name
            }
        }
    }
}
cd $PSScriptRoot
write-Host $global:testNameStr
$global:testNameStr | Out-File .\CompareResult\GenerateSuccessList.Txt
#Throw error if there are some different
if($global:isError)
{
    throw 'Error: The code generated by the target file is different from the code generated by the source file.'
}else
{
    Write-Host -ForegroundColor blue 'All generated codes are the same'
}
