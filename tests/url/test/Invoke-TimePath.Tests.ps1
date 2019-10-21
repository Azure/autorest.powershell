$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-TimePath.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-TimePath' {
    It 'Time' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'TimeViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
