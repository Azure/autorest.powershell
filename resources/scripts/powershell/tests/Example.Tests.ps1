# Pull In Mocking Support 
. ./HttpPipelineMocking.ps1 

# Run Some tests
Describe 'Get-Operation Tests' {
    It "Make a call to get-operation" {
        # (get-azoperation -HttpPipelineAppend $mock).length | Should -be 11 
    }
}