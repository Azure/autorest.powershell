$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Post503HttpRetry.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Post503HttpRetry' {
    It 'Post503' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
