param([switch]$Generate,[string]$TestName,[switch]$M3,[switch]$M4,[switch]$AllowList,[switch]$BlackList)
#need to use the right version of node.js
#nvs use 10.16.0
# #please use substring to select the compare path
#     $m3Path='.\generate\m3'
#     $m4Path='.\generate\m4'
$scriptPath = Get-Location
$global:isError = $false
$conf = (Get-Content 'Configuration.json') | ConvertFrom-Json
$conf
if($AllowList)
{
    # $configurationFileName = $scriptPath.path +'\AllowListConfiguration.csv'
    # $testList = import-Csv $configurationFileName
    $testList = $conf.WhiteList
}
if($BlackList)
{
    # $blackConfigurationFileName = $scriptPath.path +'\BlackListConfiguration.csv'
    # $blackTestList = import-Csv $blackConfigurationFileName
    $blackTestList = $conf.BlackList
}
function isCommand([Object]$Object1 , [Object]$Object2)
{
    $isCommandResult = $True
    $difference = Compare-Object $Object1 $Object2
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

function isNeedIgnore([string]$inputFileName , [Array]$ignoreArray)
{
    $Ignore = $false
    foreach($ignoreDetail in $ignoreArray)
    {
        if($inputFileName.Startswith($ignoreDetail))
        {
           $Ignore =$True
           break
        }
    }    
    return $Ignore
}

function Generate()
{
    ##m3 and m4 all need to be generated
    if((-not $M3) -and (-not $M4))
    {
        ##generate m3 code
        autorest-beta --use:@autorest/powershell@2.1.386 --output-folder:.\generate\m3 --Debug
        ##generate m4 code
        autorest-beta --use:..\..\ --output-folder:.\generate\m4 --Debug

    }elseif($M3)
    {
        autorest-beta --use:@autorest/powershell@2.1.386 --output-folder:.\generate\m3 --Debug
    }else
    {
        autorest-beta --use:..\..\ --output-folder:.\generate\m4 --Debug
    }
}

function CompareTest([string]$inputm3Path,[string]$inputm4Path,[string]$testFileName)
{
    $testFileName
    #to creare ecah dictionary (the struct is (string,obj))
    #the key is the path of each file,and the obj has two parameters(hashcodevalue,status)
    $initialDict =  @{}
    #in m3Path
    cd $inputm3Path
    $initFileList = Get-ChildItem -Recurse -force
    # $initIgnoreFileList = $inputm3Path + '\generated\modules'
    # $targetIgnoreFileList = $inputm4Path + '\generated\modules'
    $initIgnoreFileList = (($inputm3Path+'\generated\modules'), ($inputm3Path+'\.gitignore'),($inputm3Path+'\tools\Resources\.gitignore'))
    $targetIgnoreFileList = (($inputm4Path+'\generated\modules'), ($inputm4Path+'\.gitignore'),($inputm4Path+'\tools\Resources\.gitignore'))
    # $initFileList
    #foreach initFileList and get the hashcode of them
    foreach( $initFile in $initFileList)
    {
        $ignoreResult = isNeedIgnore -inputFileName $initFile.FullName -ignoreArray $initIgnoreFileList
        if(!$ignoreResult)
        {
            # if(!$initFile.FullName.Startswith($initIgnoreFileList)){
            $obj = "what" | Select-Object -Property HashCode, Status
            #if the file is not filefolder
            if($initFile.mode -eq '-a---')
            {
                #get the hashcode of the file
                $hashTable = $initFile.PSPath.Replace('Microsoft.PowerShell.Core\FileSystem::','') | get-filehash
                # $initFile.FullName
                # $hashTable
                $obj.HashCode = $hashTable.Hash
                #get the path of the file
                $detailPath = $hashTable.Path.Replace($inputm3Path,'')
                $initialDict.Add($detailPath,$obj)
            }
        }
    }
    $targetDict =  @{}
    #in m4Path
    cd $inputm4Path
    $targetFileList = Get-ChildItem -Recurse -force
    #foreach initFileList and get the hashcode of them
    foreach( $targetFile in $targetFileList)
    {
        $ignoreResult = isNeedIgnore -inputFileName $targetFile.FullName -ignoreArray $targetIgnoreFileList
        if(!$ignoreResult)
        {
            $obj = "waht2" | Select-Object -Property HashCode, Status
            #if the file is not filefolder
            if($targetFile.mode -eq '-a---')
            {
                #get the hashcode of the file
                $hashTable = $targetFile.PSPath.Replace('Microsoft.PowerShell.Core\FileSystem::','') | get-filehash
                $obj.HashCode = $hashTable.Hash
                #get the path of the file
                $detailPath = $hashTable.path.Replace($inputm4Path,'')
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
        $difDetail = "what"| Select-Object -Property fileName,Path,fileFolderName,Status
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
            $M3CompareFile = Get-Content ($inputm3Path + $initDictDetail)
            $M4CompareFile = Get-Content ($inputm4Path + $initDictDetail)
            $isCommandResult = isCommand -Object1 $M3CompareFile -Object2 $M4CompareFile
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
        $difDetail = "what"| Select-Object -Property fileName,Path,fileFolderName,Status
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
    }
    $filename = $scriptPath.Path + '\CompareResult\' + $testFileName + (get-date -format 'yyyyMMddhhmmss')+'.csv'
    $difArray | Select-Object -Property fileName,Path,fileFolderName,Status | Export-CSV -path $filename
}

$currentPath = Get-Location
$fileList = Get-ChildItem
#if only one case
if($TestName -ne $null -and ($TestName -ne ''))
{
    $currentDetailPath = Get-Location
    cd ($currentDetailPath.Path+'\'+$TestName)
    $deatilPath = $currentDetailPath.Path + 'generate'
    Generate
    if(-not $Generate)
    {
        $m3FilePath = $currentDetailPath.Path +'\'+$TestName + '\generate\m3'
        $m4FilePath =$currentDetailPath.Path +'\'+$TestName + '\generate\m4'
        CompareTest -inputm3Path $m3FilePath -inputm4Path $m4FilePath -testFileName $TestName
    }
}elseif($AllowList)
{
    $currentDetailPath = Get-Location
    #get each testfolder
    foreach($eachTest in $testList)
    {
        # Write-Host -ForegroundColor green $eachTest
        # if(($fileDeatil.Mode -eq 'd----') -and ($fileDeatil.Name -eq $TestName))
        # {
            cd ($currentDetailPath.Path+'\'+$eachTest)
            $deatilPath = $currentDetailPath.Path + 'generate'
            Generate
        # }
        if(-not $Generate)
        {
            $m3FilePath = $currentDetailPath.Path +'\'+$eachTest + '\generate\m3'
            $m4FilePath =$currentDetailPath.Path +'\'+$eachTest + '\generate\m4'
            CompareTest -inputm3Path $m3FilePath -inputm4Path $m4FilePath -testFileName $eachTest
        }
    }
}elseif($BlackList)
{
    $currentDetailPath = Get-Location
    $currentDetailPath
    #get each testfolder
    foreach($fileDetail in $fileList)
    {
        foreach($blackTestName in $blackTestList)
        {
            if(($fileDetail.Mode -eq 'd----') -and (!$fileDetail.Name.Startswith($blackTestName)))
            {
                cd ($currentDetailPath.Path+'\'+$fileDetail.Name)
                $deatilPath = $currentDetailPath.Path + 'generate'
                Generate
                if(-not $Generate)
                {
                    $m3FilePath = $currentDetailPath.Path +'\'+$fileDetail.Name + '\generate\m3'
                    $m4FilePath =$currentDetailPath.Path +'\'+$fileDetail.Name + '\generate\m4'
                    CompareTest -inputm3Path $m3FilePath -inputm4Path $m4FilePath -testFileName $fileDeatil.path
                }
            }
        }    
    }
}
else
{
    foreach($fileDetail in $fileList)
    {
        # $currentDetailPath = Get-Location
        if($fileDetail.Mode -eq 'd----' -and (!$fileDetail.Name.Startswith('Compare')))
        {
            $g1 = $scriptPath.Path +'\' +$fileDetail.Name
            cd ($scriptPath.Path +'\' +$fileDetail.Name)
            $deatilPath = $scriptPath.Path +'\' +$fileDetail.Name
            Generate
            if(-not $Generate)
            {
                $m3FilePath = $deatilPath + '\generate\m3'
                $m4FilePath = $deatilPath + '\generate\m4'
                CompareTest -inputm3Path $m3FilePath -inputm4Path $m4FilePath -testFileName $fileDetail.Name
                # CompareTest -inputm3Path (($currentDetailPath.Path +'\'+$fileDetail.Name+'\generate\m3') -inputm4Path ($currentDetailPath.Path +'\'+$fileDetail.Name+'\generate\m4')) -testFileName $fileDeatil.path
            }
        }
    }
}
cd $currentPath.Path
if($global:isError)
{
    throw 'Error: The code generated by the target file is different from the code generated by the source file.'
}else
{
    Write-Host -ForegroundColor blue 'All generated codes are the same'
}
