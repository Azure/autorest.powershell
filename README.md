
# Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.


### Autorest plugin configuration
- Please don't edit this section unless you're re-configuring how the powershell extension plugs in to AutoRest
AutoRest needs the below config to pick this up as a plug-in - see https://github.com/Azure/autorest/blob/master/docs/developer/architecture/AutoRest-extension.md


#### LLC#

``` yaml $(llcsharp)
enable-remodeler: true

pipeline:

  llcsharp/tweakcodemodel:
    scope: llcsharp
    input: remodeler
    output-artifact: code-model-v2

  llcsharp/csinferrer:
    scope: llcsharp
    input: tweakcodemodel
    output-artifact: code-model-v2

  llcsharp/csnamer:
    scope: llcsharp
    input: csinferrer
    output-artifact: code-model-v2

  llcsharp/generate:
    scope: llcsharp
    plugin: llcsharp
    input: csnamer
    output-artifact: source-file-csharp

  llcsharp/emitter:
    input: generate
    scope: scope-llcsharp/emitter

scope-llcsharp/emitter:
  input-artifact: source-file-csharp
  
output-artifact: 
  - source-file-csharp
  - code-model-v2.yaml

```

#### Remodeler

``` yaml  $(enable-remodeler)
  
pipeline: 
  remodeler:
    input: openapi-document/identity
    output-artifact: code-model-v2


  remodeler/emitter:
    input: remodeler
    scope: scope-remodeler/emitter

scope-remodeler/emitter:
  input-artifact: code-model-v2
  is-object: true
  
  output-uri-expr: | 
    "code-model-v2"
  
# output-artifact: code-model-v2.yaml
  

```

#### PowerShell


``` yaml $(powershell) 
api-folder: api
runtime-folder: runtime
cmdlet-folder: cmdlets/generated
custom-cmdlet-folder: cmdlets/custom
use-namespace-folders: false

pipeline: 

  # "Shake the tree", and normalize the model
  remodeler:
    input: openapi-document/identity   # the plugin where we get inputs from
  
  # Make some interpretations about what some things in the model mean
  tweakcodemodel:
    input: remodeler

  # Specific things for Azure 
  tweakcodemodelazure:
    input: tweakcodemodel

  # Choose names for everything in c#
  csnamer:
    input: tweakcodemodelazure

  # creates high-level commands
  create-commands: 
    input: csnamer # brings the code-model-v2 with it. 
      
  # creates powershell cmdlets for high-level commands. (leverages llc# code)
  powershell:
    input: 
      - create-commands # and the generated c# files
      - csnamer  # needs both the code model after the csnamer is done

  # generates c# files for http-operations
  llcsharp:
    input: csnamer

  # explicitly declare writing out the code model -- we want to be able to emit some files from this one (temporary)
  cmv2/emitter:
    input: tweakcodemodelazure
    scope: code-model-emitter-settings

  # the default emitter will emit everything (no processing) from the inputs listed here.
  default/emitter:
    input: 
     - llcsharp
     - powershell 
     - create-commands 
   

# Specific Settings for cm emitting - selects the file types and format that cmv2-emitter will spit out.  
code-model-emitter-settings:
  input-artifact: code-model-v2
  is-object: true
  output-uri-expr: | 
    "code-model-v2"

# testing:  ask for the files we need  
output-artifact: 
  - code-model-v2.yaml # this is filtered outby default. (remove before production)
  - source-file-csharp
  - source-file-other
  - source-file-csproj
  - source-file-powershell

```