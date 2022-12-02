### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
  - $(this-folder)/swagger.json

directive:
  - where:
      model-name: Resource
    set:
      model-name: AzureResource
  - where:
      model-name: ^KeyValue(.*)
    set:
      model-name: kv$1
  - where:
      model-name: VirtualMachine
      property-name: VirtualMachineName
    set:
      property-name: Name
  - where:
      property-name: (.*)Azure
    set:
      property-name: Az
```
