$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Put409HttpClientFailure.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Put409HttpClientFailure' {
    It 'Put409' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
