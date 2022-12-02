### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
  - $(this-folder)/swagger.json

directive:
  - where:
      parameter-name: Sku
    set:
      parameter-name: SkuName
  - where:
      verb: Get
      subject: VirtualMachineSize_Get
      parameter-name: VirtualMachineSize
    set:
      parameter-name: VMSize
  - where:
      parameter-name: VirtualMachine
    set:
      alias:
        - VM
        - VMachine
  - where:
      parameter-name: ResourceGroup
    set:
      parameter-description: This is resource group name.
  - where:
      parameter-name: SubscriptionId
    set:
      default:
        name: SubscriptionId Default
        description: Gets the SubscriptionId from the current context.
        script: '(Get-AzContext).Subscription.Id'
```
