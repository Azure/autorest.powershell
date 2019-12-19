$TestRecordingFile = Join-Path $PSScriptRoot 'Get-PrimitiveBool.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-PrimitiveBool' {
    It 'Get' {
      {
        $value = Get-PrimitiveBool 

        # ensure we got back a result
        $value | Should -not -be $null

        # and that the values are as expected
        $value.FieldFalse | Should -be $false
        $value.FieldTrue | Should -be $true
      } | Should -Not -Throw
    } 
}
