$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Post400HttpClientFailure.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Post400HttpClientFailure' {
    It 'Post400' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
