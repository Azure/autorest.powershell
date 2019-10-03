$TestRecordingFile = Join-Path $PSScriptRoot 'Get-BasicNull.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-BasicNull' {
    It 'Get' {
        { 
          $v = Get-BasicNull
          $v.id | should -be $null
          $v.name | should -be $null
         } | Should -Not -Throw
    }
}
