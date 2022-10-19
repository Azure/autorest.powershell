# Load Remodeler

### Autorest plugin configuration
- Please don't edit this section unless you're re-configuring how the powershell extension plugs in to AutoRest
AutoRest needs the below config to pick this up as a plug-in - see https://github.com/Azure/autorest/blob/master/docs/developer/architecture/AutoRest-extension.md

> modelerfour configuration
``` yaml
modelerfour:
  emit-yaml-tags: false
  lenient-model-deduplication: true
  additional-checks: false
  always-create-content-type-parameter: false
  always-seal-x-ms-enums: true
  treat-type-object-as-anything: true
```

> if the modeler is loaded already, use that one, otherwise grab it.

``` yaml !isLoaded('@autorest/modelerfour')
use-extension:
  "@autorest/modelerfour": "4.23.1"

# will use highest 2.0.x 
```


> Multi-Api Mode
``` yaml
pipeline-model: v3
```

> Folders
``` yaml
use-namespace-folders: false
current-folder: .
module-folder: $(current-folder)/generated
cmdlet-folder: $(module-folder)/cmdlets
model-cmdlet-folder: $(custom-cmdlet-folder)/autogen-model-cmdlets
custom-cmdlet-folder: $(current-folder)/custom
utils-cmdlet-folder: $(current-folder)/utils
internal-cmdlet-folder: $(current-folder)/internal
test-folder: $(current-folder)/test
runtime-folder: $(module-folder)/runtime
api-folder: $(module-folder)/api
bin-folder: $(current-folder)/bin
obj-folder: $(current-folder)/obj
exports-folder: $(current-folder)/exports
docs-folder: $(current-folder)/docs
dependency-module-folder: $(module-folder)/modules
examples-folder: $(current-folder)/examples
resources-folder: $(current-folder)/resources
```


``` yaml
declare-directive:
  no-inline: >-
    (() => {
      return {
        from: "code-model-v3", 
        where: (Array.isArray($) ? $ : [$]).map( each => `$.schemas[?(/^${each}$/i.exec(@.details.default.name))]`),
        transform: "$.details.default['skip-inline'] = true;"
      };
    })()

```

# Pipeline Configuration
``` yaml
pipeline:
# --- extension powershell based on modelerfour

  csnamerSdk:
    input: modelerfour/identity 
  # Fix the code model gap between m3 and m4
  tweakSdkModelPlugin:
    input: csnamerSdk
 
  generate:
    input: tweakSdkModelPlugin

# --- extension llcsharp  --- 
  # generates c# files for http-operations
  text-transform:
    input: generate
    scope: scope-here

  emitter:
    input: text-transform
    scope: scope-here
    # output-artifact: source-file-csharp


scope-here:
  is-object: false
  output-artifact:
    - source-file-csharp
    - source-file-csproj
    - source-file-powershell
    - source-file-other
    - binary-file
    - preserved-files


# Specific Settings for cm emitting - selects the file types and format that cmv2-emitter will spit out.
code-model-emitter-settings:
  input-artifact: code-model-v4
  is-object: true
  output-uri-expr: |
    "code-model-v4"

# testing:  ask for the files we need
output-artifact:
  - source-file-csharp
  - source-file-csproj
  - source-file-powershell
  - source-file-other
  - binary-file
  - preserved-files  
  
directive: 
  - reason: FixFromXML
    from: source-file-csharp
    where: $
    transform: return $.replace( /FromXml/g , 'FromJson');


```

