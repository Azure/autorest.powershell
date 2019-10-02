$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ArrayQueryStringCsvNull.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ArrayQueryStringCsvNull' {
    It 'Array' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
