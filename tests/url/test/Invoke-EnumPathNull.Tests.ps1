$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-EnumPathNull.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-EnumPathNull' {
    It 'Enum' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'EnumViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
