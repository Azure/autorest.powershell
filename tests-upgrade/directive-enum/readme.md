### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
  - $(this-folder)/swagger.json

directive:
  - where:
    enum-name: provisioningState
    enum-value-name: Upgrading
  set:
    enum-value-name: Update
```
