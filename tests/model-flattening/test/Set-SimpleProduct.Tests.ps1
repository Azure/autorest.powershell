$TestRecordingFile = Join-Path $PSScriptRoot 'Set-SimpleProduct.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-SimpleProduct' {
    It 'PutExpanded1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PutExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Put' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PutViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PutViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Put1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
