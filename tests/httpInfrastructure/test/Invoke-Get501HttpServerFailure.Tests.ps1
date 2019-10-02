$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Get501HttpServerFailure.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Get501HttpServerFailure' {
    It 'Get501' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
