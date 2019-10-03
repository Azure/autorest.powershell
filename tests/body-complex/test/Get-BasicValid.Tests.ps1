$TestRecordingFile = Join-Path $PSScriptRoot 'Get-BasicValid.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-BasicValid' {
    It 'Get' {
        {
          $v = Get-BasicValid
          $v.Id | should -be 2
          $v.name | should -be 'abc'
          $v.Color | should -be ([Sample.API.Support.CmykColors]::Yellow)
        } | Should -Not -Throw
    }
}
