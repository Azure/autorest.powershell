### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
  - $(this-folder)/swagger.json

directive:
  - where:
      verb: Get
      subject: VirtualMachine
    set:
      subject: VM
  - where:
      subject: (^Configuration)(.*) 
    set:
      subject: Config$2
  - select: command
    where:
      verb: Get
      subject: Object
      parameter-name: Id
    set: 
      subject: obj
  - where:
      verb: Get
      subject: ResourceGroup
    set: 
      alias: Get-RG
  - where:
      verb: Get
      subject: MultipleAlias
    set:
      alias:
        - Get-MA1
        - Get-MA2
  - where:
      verb: patch
      subject: CmdletHide
    hide: true
  - where:
      subject: ConfigHide.*
    hide: true
  - where:
      verb: Get
      subject: Remove
    remove: true
  - where:
      subject: RegexRemove.*
    remove: true
```
