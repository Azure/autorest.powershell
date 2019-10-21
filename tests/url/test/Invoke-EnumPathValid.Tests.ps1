$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-EnumPathValid.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-EnumPathValid' {
    It 'Enum' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'EnumViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
