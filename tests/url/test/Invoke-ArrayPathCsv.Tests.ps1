$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ArrayPathCsv.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ArrayPathCsv' {
    It 'Array' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ArrayViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
