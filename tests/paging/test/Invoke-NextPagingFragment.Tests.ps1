$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-NextPagingFragment.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-NextPagingFragment' {
    It 'Next' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Next1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'NextViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'NextViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
