$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ModelMultipleResponse.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ModelMultipleResponse' {
    It 'Model' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Model9' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Model8' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Model7' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Model11' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Model10' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
