$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-Base64PathUrl.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-Base64PathUrl' {
    It 'Base64' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Base64ViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
