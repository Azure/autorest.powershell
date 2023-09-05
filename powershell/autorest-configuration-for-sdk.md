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
  "@autorest/modelerfour": "~4.26.0"

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

``` yaml
directive:
  - from: swagger-document
    where: $..[?(@['x-ms-enum'])]
    transform: $['x-ms-model-as-string'] = !!$['x-ms-enum'].modelAsString
```

# Pipeline Configuration
``` yaml
pipeline:
  createSdkInlinedPropertiesPlugin:
    input: modelerfour/identity

  applyModelNameModifiersSdk:
    input: createSdkInlinedPropertiesPlugin

  csnamerSdk:
    input: applyModelNameModifiersSdk

  applyModifiersSdk:
    input: csnamerSdk

  tweakSdkModelPlugin:
    input: applyModifiersSdk
 
  generate:
    input: tweakSdkModelPlugin

  # simplifierPlugin:
  #   input: generate

  text-transform:
    input: generate
    scope: scope-here

  # output-artifact: source-file-csharp
  emitter:
    input: text-transform
    scope: scope-here


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
