# Code Generation Modifiers


## Scenarios:

### Models
#### P1:
- Model name change - cosmetic
     ```yaml
    - where-model: ^VirtualMachine(.*)
      set-value: "VM$1"
    ```
- Property name change - cosmetic
    ```yaml
    - where-property: Tags
      set-name: Tag
    ```
- Property aliasing - cosmetic
    ```yaml
    - where-property: ResourceGroupName
      set-alias: RGN # also [alias1, alias2]
    ```

#### P2:
- Model Supresion (OAI level) radical
- Property visibility change cosmetic
- Property default change/addition radical
- Formating of output --- Done with format files

### Commands

#### P1:
- Command suppresion - radical
    ```yaml
    - remove-command: Get-AzOperation.*
    ```
- Name change - cosmetic 
    - Noun change 
        ```yaml
        - where-noun: ^Compute(.*)
          set-value: "$1"
        ```
    - Verb change
        ```yaml
        - where-verb: Get
          set-value: Retrieve
        ```

#### P2:
- Supports Paging? 
- Supports ShouldProcess?
- Confirm Impact? 
- Output type --- collections to single stuff (nvm)
- Default parameter set - cosmetic

### Parameter Set 

#### P1:
- Parameter set suppresion - radical
     ```yaml
    - remove-parameter-set: 
        variant: ResourceGroupNameSku
    ```
- Name change - cosmetic 
     ```yaml
    - where-parameter-set: ResourceGroupNameSku
      set-value: Retrieve
    ```

#### P2:
- Parameter default value p2 - radical
- "Optionalization" of required parameter by giving a default - radical
- Parameters order (index) - cosmetic
    ```yaml
    - where-parameter-set: ResourceGroupNameSku
      set-index: 
        - ResourceGroupName
        - Sku
    ```
- Description - cosmetic
    ```yaml
    - where-parameter-set: ResourceGroupNameSku
      set-description: This is a description.
    ```

### Parameters

#### P1:
- Name change - cosmetic
    ```yaml
    - where-parameter: Tags
      set-name: Tag
      set-alias: Tag
    ```

- Aliasing (add attribute) - cosmetic

    ```yaml
    - where-parameter: ResourceGroupName
      set-alias: RGN # also ['alias1', 'alias2'] 
    ```

  NOTE: Being able to target NOT ALL commands but SPECIFIC commands. Cases haven't been found yet, but if cases are found, this pattern should be revised.

#### P2:
- Parameter Suppresion (OAI level) - radical

!~~~




NOTES:

```

- rename-operation: asdasdas
  to: asasddasd


get-Az(Compute)VMFoo ---> get-newAzVMFoo
get-Az(Compute)VMVar ---> get-newAzVMVar
get-Az(Compute)ResFoo ---> get-newAzResFoo


- where-command:  //(gets the collection of commands where noun starts with Computer)
    noun: ^Compute*  // wildcard or regex ^Compute*
    verb: Get
  rename-command:    // another idea rename: command
    match-noun: ^Compute      
    new-string: ''

- rename-command:    // another idea rename: command\
    where-noun: ^Compute*   
    set:  
        noun: 
            substring: 'Compute' // regexp: ^Compute
            new-substring: ''    // 
        verb: Retrieve



 - where-noun: ^DataLakeStore.*
   transform: return $.reverse();
   
 DataLakeStore ---> DLS

 - rename:
   - noun:
     from: 
     to: 
   - noun:
     from: 
     to: 
   - noun:
     from: 
     to: 

  

 - where-noun: ^Compute(.*)
   set: "$1"

 - rename-noun: 
   from: (^Compute) // smart detection of regexp 
   to: ""
 
 - rename-parameter: 
     from: Tags
     to: Tag




 - where-noun: ^Compute(.*)
   set-value: "$1"

 - where-parameter: Tags
   set-name: Tag
   set-alias: TT


- where-property: Tags
  set-name: Tag
  set-visibility: internal 
   
- remove-command: 
   verb: Get
   noun: Operations$     

-  where-parameter: ResourceGroupName
   alias: RG


          to: Tags
        - from: Foo
          to: Bar
    alias-parameter: 
        - from: ResourceGroupName
          to: rgn
 
- where-model: my-model
  rename-property: 
    from: myPROP
    to: myprop



    

- where:
    noun: ^Compute
  set: 
    

get-newAz(Compute)VMFoo ---> get-newAzVMFoo
get-newAz(Compute)VMVar ---> get-newAzVMVar
get-newAz(Compute)ResFoo ---> get-newAzResFoo



- where:    // another idea where: command
    noun: Compute*  // wildcard or regex ^Compute*
    verb: ...
    name: ... // cmdlet complete name for pwsh
  set:    // another idea rename: command
    noun: Compute    
    new-substring: ''
 rename-parameter:    // another idea rename: command
    substring: Tag      
    new-substring: Tags

get-newAz(Compute)VM ---> get-newAzVM
get-newAz(Compute)sdVM ---> get-newAzdsVM
    -Tags ---> Tag
    -PARAMETERS ---> parameters (lowercase)
get-AzDataLakeStoreFoo --> get-AzDLSFoo



- where-command:
    noun: DataLakeStore*  //regex or wildcard tbd
  rename-parameter:
    from: Tags
    to: Tag
  rename-command: 
    
    transform: $match) => (match).replace(/[^a-z]/g, ''); // DLS

- where-command:     // all the commands
    noun: *  //regex or wildcard tbd
  rename-parameter:
    from: Tags
    to: Tag

- from:
  rename-parameter:




