
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


#### PowerShell
``` yaml

use-extension:
  "@microsoft.azure/autorest.remodeler": "beta"
  "@microsoft.azure/autorest.csharp-v2": "beta"
```


``` yaml $(powershell)
enable-multi-api: true

api-folder: private/api
api-extensions-folder: private/api-extensions
runtime-folder: private/runtime
cmdlet-folder: private/cmdlets/generated
custom-cmdlet-folder: private/custom
module-folder: private/
use-namespace-folders: false

pipeline:
# --- extension remodeler --- 

  # "Shake the tree", and normalize the model
  remodeler:
    input: openapi-document/multi-api/identity     # the plugin where we get inputs from

  # Make some interpretations about what some things in the model mean
  tweakcodemodel:
    input: remodeler

  # Specific things for Azure
  tweakcodemodelazure:
    input: tweakcodemodel

  add-apiversion-constant:
    input: tweakcodemodelazure

# --- extension powershell --- 

  # creates high-level commands
  create-commands:
    input: add-apiversion-constant # brings the code-model-v3 with it.

  # Choose names for everything in c#
  csnamer:
    input: create-commands # and the generated c# files

  # ensures that names/descriptions are properly set for powershell
  psnamer:
    input: csnamer 

  # creates powershell cmdlets for high-level commands. (leverages llc# code)
  powershell:
    input: psnamer # and the generated c# files

# --- extension llcsharp  --- 
  # generates c# files for http-operations
  llcsharp:
    input: psnamer

  # the default emitter will emit everything (no processing) from the inputs listed here.
  default/emitter:
    input:
     - llcsharp
     - powershell
     - create-commands


# Specific Settings for cm emitting - selects the file types and format that cmv2-emitter will spit out.
code-model-emitter-settings:
  input-artifact: code-model-v3
  is-object: true
  output-uri-expr: |
    "code-model-v3"

# testing:  ask for the files we need
output-artifact:
  - code-model-v3.yaml # this is filtered outby default. (remove before production)
  - source-file-csharp
  - source-file-csproj
  - source-file-powershell
  - source-file-other
```
