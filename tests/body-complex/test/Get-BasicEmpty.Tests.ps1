$TestRecordingFile = Join-Path $PSScriptRoot 'Get-BasicEmpty.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-BasicEmpty' {
    It 'Get' {
        { 
          $v = Get-BasicEmpty
          $v.getType().name |should -be 'basic'
          $v.ToJsonString() | should -be "{$([System.Environment]::NewLine)}"   
         } | Should -Not -Throw
    }
}
