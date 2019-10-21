$TestRecordingFile = Join-Path $PSScriptRoot 'Get-DictionaryNotProvided.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-DictionaryNotProvided' {
    It 'Get' {
        {  
          $d = Get-DictionaryNotProvided
          $d.count | should -be 0
         } | Should -Not -Throw
    }
}
