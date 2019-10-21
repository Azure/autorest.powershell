$TestRecordingFile = Join-Path $PSScriptRoot 'Get-BasicInvalid.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-BasicInvalid' {
    It 'Get' {
        { 
          $v = Get-BasicInvalid
          $v.id | should -be $null        # id is a string in the response body.
          $v.Name | should -be 'abc'

         } | Should -Not -Throw
    }
}
