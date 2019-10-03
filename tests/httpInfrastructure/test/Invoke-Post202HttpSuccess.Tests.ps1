$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Post202HttpSuccess.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Post202HttpSuccess' {
    It 'Post202' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
