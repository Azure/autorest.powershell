$TestRecordingFile = Join-Path $PSScriptRoot 'Get-PrimitiveDateTimeRfc1123.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-PrimitiveDateTimeRfc1123' {
    It 'Get' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
