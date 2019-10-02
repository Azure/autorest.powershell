$TestRecordingFile = Join-Path $PSScriptRoot 'Set-Datetimerfc1123UtcMaxDateTime.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-Datetimerfc1123UtcMaxDateTime' {
    It 'Put' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
