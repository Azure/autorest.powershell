$TestRecordingFile = Join-Path $PSScriptRoot 'Get-ArrayValid.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-ArrayValid' {
    It 'Get'  {
        { 
          $a = Get-ArrayValid
          $a.length | should -be 5
          $a[2] | should -be $null
          $a[4].GetType() | should -be 'string' 
          $a[4] | should -be "The quick brown fox jumps over the lazy dog"
        } | Should -Not -Throw
    }
}
