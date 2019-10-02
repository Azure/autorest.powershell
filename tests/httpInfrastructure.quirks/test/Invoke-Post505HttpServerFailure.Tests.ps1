$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Post505HttpServerFailure.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Post505HttpServerFailure' {
    It 'Post505' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
