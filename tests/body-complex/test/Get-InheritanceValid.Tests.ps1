$TestRecordingFile = Join-Path $PSScriptRoot 'Get-InheritanceValid.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-InheritanceValid' {
    It 'Get' {
        { 
          $v = Get-InheritanceValid 
          $v.Name | should -be Siameeee 
          $v.id | should -be 2
          $v.Breed | should -be persian
          $v.Color | should -be green
        } | Should -Not -Throw
    }
}