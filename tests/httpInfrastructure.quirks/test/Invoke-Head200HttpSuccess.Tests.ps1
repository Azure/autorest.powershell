$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Head200HttpSuccess.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Head200HttpSuccess' {
    It 'Head200' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
