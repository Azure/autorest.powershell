
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


#### Remodeler

``` yaml 
# remodeler:
    
pipeline: 
  remodeler:
    input: openapi-document/identity
    output-artifact: code-model-v2

  remodeler/inferrer:
    scope: remodeler
    input: remodeler
    output-artifact: code-model-v2

  remodeler/emitter:
    input: inferrer
    scope: scope-remodeler/emitter

scope-remodeler/emitter:
  input-artifact: code-model-v2
  is-object: true
  
  output-uri-expr: | 
    "code-model-v2"
  
# output-artifact: code-model-v2.yaml
  

````



#### LLC#

``` yaml $(llcsharp)
pipeline:

  llcsharp/inferrer:
    scope: llcsharp
    input: remodeler
    output-artifact: code-model-v2

  llcsharp/csinferrer:
    scope: llcsharp
    input: inferrer
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

#### LLIA

#### IA

#### PowerShell