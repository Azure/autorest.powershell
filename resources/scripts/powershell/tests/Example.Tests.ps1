# Pull In Mocking Support 
. "$PSScriptRoot/HttpPipelineMocking.ps1"

# Run Some tests
# example:

<#

Describe 'Get-Operation Tests' {
    It "Make a call to get-operation" {
        
        # MAKE SUIRE YOU USE  -HttpPipelineAppend $mock with the cmdlet!
        (get-operation -HttpPipelineAppend $mock).length | Should -be 11 
        
    }
}

#>