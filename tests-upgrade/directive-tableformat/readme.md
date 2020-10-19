### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
  - $(this-folder)/swagger.json

directive:
  - where:
      model-name: VirtualMachine
    set:
      format-table:
        properties:
          - Name
          - ResourceGroup
        labels:
          ResourceGroup: Resource Group
        width:
          Name: 60
          ResourceGroup: 80
```
