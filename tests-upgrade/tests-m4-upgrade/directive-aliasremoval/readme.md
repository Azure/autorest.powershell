### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
  - $(this-folder)/swagger.json

directive:
  - where:
      parameter-name: ResourceGroupName
    clear-alias: true
```
