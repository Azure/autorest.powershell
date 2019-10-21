$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ValidationRedis.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ValidationRedis' {
    It 'Validation' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ValidationExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Validation1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ValidationViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ValidationViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ValidationViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
