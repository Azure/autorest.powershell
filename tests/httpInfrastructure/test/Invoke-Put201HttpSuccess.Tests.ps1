$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Put201HttpSuccess.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Put201HttpSuccess' {
    It 'Put201' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
