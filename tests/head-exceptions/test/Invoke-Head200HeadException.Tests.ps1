$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Head200HeadException.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Head200HeadException' {
    It 'Head200' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
