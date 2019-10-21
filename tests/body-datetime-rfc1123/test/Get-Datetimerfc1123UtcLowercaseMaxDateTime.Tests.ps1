$TestRecordingFile = Join-Path $PSScriptRoot 'Get-Datetimerfc1123UtcLowercaseMaxDateTime.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-Datetimerfc1123UtcLowercaseMaxDateTime' {
    It 'Get' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
