$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ValidationRedis.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ValidationRedis' {
    It 'Validation' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ValidationExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Validation1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ValidationViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ValidationViaIdentity1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ValidationViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
