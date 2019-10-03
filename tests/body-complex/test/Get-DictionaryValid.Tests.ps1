$TestRecordingFile = Join-Path $PSScriptRoot 'Get-DictionaryValid.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-DictionaryValid' {
    It 'Get' {
        { 
          $d = Get-DictionaryValid
          $d.keys.Count | should -be 4
          $p = [Hashtable]$d.AdditionalProperties 
          $p['xls'] | should -be 'excel'
          $p['txt'] | should -be 'notepad'
          $p['exe'] | should -be ''
         } | Should -Not -Throw
    }
}
