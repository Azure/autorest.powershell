
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
        $psd1 = GeneratePsd1('no-metadata.md.sample')
        $psd1.FunctionsToExport | Should -Be @('Get-AzPetStoreUser', '*')
        $psd1.FormatsToProcess | Should -Be './Az.PetStore.format.ps1xml'
    }

    It "Should generate empty value if user inputs empty array" {
        $psd1 = GeneratePsd1('empty-value.md.sample')
        $psd1.FunctionsToExport | Should -Be @()
    }

    It "Should generate PSD1 according to user's input" {
        $psd1 = GeneratePsd1('fully-customized.md.sample')
        $psd1.RequiredModules | Should -HaveCount 2
        $psd1.RequiredModules[0].ModuleName | Should -Be 'Az.KeyVault'
        $psd1.RequiredModules[1].ModuleVersion | Should -Be '1.0.0-preview'

        $psd1.RequiredAssemblies | Should -Be @('./custom/lib/third-party.dll')
        $psd1.NestedModules | Should -Be @('./custom/my-custom.psm1')
        $psd1.FormatsToProcess | Should -Be @('./generated/Az.Functions.formats.ps1xml', './custom/my.formats.ps1xml')
        $psd1.TypesToProcess | Should -Be @('./custom/my.types.ps1xml')
        $psd1.ScriptsToProcess | Should -Be @('./custom/my.scripts.ps1xml')
        $psd1.FunctionsToExport | Should -Be @('Get-AzFunctionApp', 'New-AzFunctionApp', 'Remove-AzFunctionApp', 'Update-AzFunctionApp')
        $psd1.AliasesToExport | Should -Be @('GAF', 'NAF')
        $psd1.CmdletsToExport | Should -Be @('Get-MyItem', 'Remove-MyItem')
    }
}

