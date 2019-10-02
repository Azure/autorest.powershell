$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Patch504HttpRetry.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Patch504HttpRetry' {
    It 'Patch504' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
