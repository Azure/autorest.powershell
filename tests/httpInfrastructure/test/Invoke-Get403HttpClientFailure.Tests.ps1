$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Get403HttpClientFailure.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Get403HttpClientFailure' {
    It 'Get403' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
