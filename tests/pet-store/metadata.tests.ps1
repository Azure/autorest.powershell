
# Generate, build, return an object represents content of PSD1 file
function GeneratePsd1()
{
    param (
        $readme
    )
    Copy-Item -Path "$PSScriptRoot\readme\$readme" -Destination "$PSScriptRoot\readme.md" -Force
    autorest.cmd "$PSScriptRoot\readme.md" "--use:$PSScriptRoot\..\.." --output-folder:"$PSScriptRoot\output"
    . "$PSScriptRoot\output\build-module.ps1"
    return Import-PowerShellDataFile "$PSScriptRoot\output\Az.PetStore.psd1"
}

Describe "Metadata support" {
    AfterEach {
        Remove-Item -Path "$PSScriptRoot\output\" -Force -Recurse -ErrorAction Ignore
    }

    It "Should generate default value if metadata is empty" {
        $psd1 = GeneratePsd1('no-metadata.md')
        $psd1.FunctionsToExport | Should -Be @('Get-AzPetStoreUser', '*')
        $psd1.FormatsToProcess | Should -Be './Az.PetStore.format.ps1xml'
    }

    It "Should generate empty value if user inputs empty array" {
        $psd1 = GeneratePsd1('empty-value.md')
        $psd1.FunctionsToExport | Should -Be @()
    }
}

