$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ModelMultipleResponse.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ModelMultipleResponse' {
    It 'Model' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Model9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Model8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Model7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Model11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Model10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
