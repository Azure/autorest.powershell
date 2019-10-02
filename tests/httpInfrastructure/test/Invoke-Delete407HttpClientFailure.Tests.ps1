$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Delete407HttpClientFailure.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Delete407HttpClientFailure' {
    It 'Delete407' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
