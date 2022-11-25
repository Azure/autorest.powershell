# Overall

This directory contains the service clients of other services for Azure PowerShell Websites module.

## Run Generation

### Preparation

#### Build autorest.csharp

Following are details about how to build autorest.csharp with Visual Studio.

1. git clone --recurse-submodules https://github.com/Azure/autorest.csharp.git -b master
2. Open the solution and remove the project autorest.csharp.test
3. Comment out `new AutoRest.Simplify.CSharpSimplifier().Run(fs).ConfigureAwait(false).GetAwaiter().GetResult();` from the Program.cs to disable simplifier plugin
4. Build the solution

**If you run into any build errors, you probably need to install dotnet core 2.1 in Visual Studio**

### How to generate SDK with different generators

In this directory, run AutoRest.

To generate SDK with autorest.csharp

```
autorest --use:<path-to-autorest.csharp> --tag=basic-get.csharp
```

To generate SDK with autorest.powershell

```
autorest --use:<path-to-autorest.powershell> --tag=basic-get.powershell
```

### AutoRest Configuration

> see https://aka.ms/autorest

```yaml
clear-output-folder: true
reflect-api-versions: true
openapi-type: arm
azure-arm: true
license-header: MICROSOFT_MIT_NO_VERSION
#payload-flattening-threshold: 2
```

### Tag: provider-aks.csharp

```yaml $(tag) == 'provider-aks.csharp'
csharp: true
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/195cd610db0accd0422c3e00a72df739ab4de677/specification/containerservice/resource-manager/Microsoft.ContainerService/stable/2022-09-01/managedClusters.json

directive:
  - from: swagger-document
    where: $.definitions.Identity.properties.type["x-ms-enum"]
    transform: $.name = "ResourceIdentityTypeForCommonTypes"
  - from: swagger-document
    where: $.definitions.ManagedClusterAgentPoolProfileProperties.properties.orchestratorVersion
    transform: $["description"] = $["description"].replace(/</g, "(");
  - from: swagger-document
    where: $.definitions.ManagedClusterAgentPoolProfileProperties.properties.orchestratorVersion
    transform: $["description"] = $["description"].replace(/>/g, ")");
  - from: swagger-document
    where: $.definitions.ManagedClusterAgentPoolProfileProperties.properties.currentOrchestratorVersion
    transform: $["description"] = $["description"].replace(/</g, "(");
  - from: swagger-document
    where: $.definitions.ManagedClusterAgentPoolProfileProperties.properties.currentOrchestratorVersion
    transform: $["description"] = $["description"].replace(/>/g, ")");
  - from: swagger-document
    where: $.definitions.ManagedClusterProperties.properties.kubernetesVersion
    transform: $["description"] = $["description"].replace(/</g, "(");
  - from: swagger-document
    where: $.definitions.ManagedClusterProperties.properties.kubernetesVersion
    transform: $["description"] = $["description"].replace(/>/g, ")");
  - from: swagger-document
    where: $.definitions.ManagedClusterProperties.properties.currentKubernetesVersion
    transform: $["description"] = $["description"].replace(/</g, "(");
  - from: swagger-document
    where: $.definitions.ManagedClusterProperties.properties.currentKubernetesVersion
    transform: $["description"] = $["description"].replace(/>/g, ")");

namespace: Microsoft.Azure.Management.ContainerService
output-folder: provider-aks\csharp
```

### Tag: provider-aks.powershell

```yaml $(tag) == 'provider-aks.powershell'
isSdkGenerator: true
powershell: true
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/195cd610db0accd0422c3e00a72df739ab4de677/specification/containerservice/resource-manager/Microsoft.ContainerService/stable/2022-09-01/managedClusters.json

directive:
  - from: swagger-document
    where: $.definitions.Identity.properties.type["x-ms-enum"]
    transform: $.name = "ResourceIdentityTypeForCommonTypes"
  - from: swagger-document
    where: $.definitions.ManagedClusterAgentPoolProfileProperties.properties.orchestratorVersion
    transform: $["description"] = $["description"].replace(/</g, "(");
  - from: swagger-document
    where: $.definitions.ManagedClusterAgentPoolProfileProperties.properties.orchestratorVersion
    transform: $["description"] = $["description"].replace(/>/g, ")");
  - from: swagger-document
    where: $.definitions.ManagedClusterAgentPoolProfileProperties.properties.currentOrchestratorVersion
    transform: $["description"] = $["description"].replace(/</g, "(");
  - from: swagger-document
    where: $.definitions.ManagedClusterAgentPoolProfileProperties.properties.currentOrchestratorVersion
    transform: $["description"] = $["description"].replace(/>/g, ")");
  - from: swagger-document
    where: $.definitions.ManagedClusterProperties.properties.kubernetesVersion
    transform: $["description"] = $["description"].replace(/</g, "(");
  - from: swagger-document
    where: $.definitions.ManagedClusterProperties.properties.kubernetesVersion
    transform: $["description"] = $["description"].replace(/>/g, ")");
  - from: swagger-document
    where: $.definitions.ManagedClusterProperties.properties.currentKubernetesVersion
    transform: $["description"] = $["description"].replace(/</g, "(");
  - from: swagger-document
    where: $.definitions.ManagedClusterProperties.properties.currentKubernetesVersion
    transform: $["description"] = $["description"].replace(/>/g, ")");

namespace: Microsoft.Azure.Management.ContainerService
output-folder: provider-aks\powershell
```

### Tag: provider-containerRegistry.csharp

```yaml $(tag) == 'provider-containerRegistry.csharp'
csharp: true
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/5035a36bcd5b0543a9a65ee21f03bd12e301ea72/specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2019-05-01/containerregistry.json
  - https://github.com/Azure/azure-rest-api-specs/blob/5035a36bcd5b0543a9a65ee21f03bd12e301ea72/specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2019-04-01/containerregistry_build.json

directive:
# Discriminator must be a required property
  - from: swagger-document
    where: $.definitions.TaskStepProperties
    transform: $["required"] = ["type"]
  - from: swagger-document
    where: $.definitions.TaskStepUpdateParameters
    transform: $["required"] = ["type"]
  - from: swagger-document
    where: $.definitions.RunRequest
    transform: $["required"] = ["type"]
    
namespace: Microsoft.Azure.Management.ContainerRegistry
output-folder: provider-containerRegistry\csharp
```

### Tag: provider-containerRegistry.powershell

```yaml $(tag) == 'provider-containerRegistry.powershell'
isSdkGenerator: true
powershell: true
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/5035a36bcd5b0543a9a65ee21f03bd12e301ea72/specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2019-05-01/containerregistry.json
  - https://github.com/Azure/azure-rest-api-specs/blob/5035a36bcd5b0543a9a65ee21f03bd12e301ea72/specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2019-04-01/containerregistry_build.json

directive:
# Discriminator must be a required property
  - from: swagger-document
    where: $.definitions.TaskStepProperties
    transform: $["required"] = ["type"]
  - from: swagger-document
    where: $.definitions.TaskStepUpdateParameters
    transform: $["required"] = ["type"]
  - from: swagger-document
    where: $.definitions.RunRequest
    transform: $["required"] = ["type"]

namespace: Microsoft.Azure.Management.ContainerRegistry
output-folder: provider-containerRegistry\powershell
```

### Tag: provider-storage.csharp

```yaml $(tag) == 'provider-storage.csharp'
csharp: true
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/4e80dd0ac53f3e1694254e0a6966176e90ed38ff/specification/storage/resource-manager/Microsoft.Storage/stable/2022-05-01/storage.json
  - https://github.com/Azure/azure-rest-api-specs/blob/a98a48c6aced55dcf941778feb4f64c61a4599d2/specification/storage/resource-manager/Microsoft.Storage/stable/2022-05-01/blob.json
  - https://github.com/Azure/azure-rest-api-specs/blob/4e80dd0ac53f3e1694254e0a6966176e90ed38ff/specification/storage/resource-manager/Microsoft.Storage/stable/2022-05-01/file.json

namespace: Microsoft.Azure.Management.Storage
output-folder: provider-storage\csharp
```

### Tag: provider-storage.powershell

```yaml $(tag) == 'provider-storage.powershell'
isSdkGenerator: true
powershell: true
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/4e80dd0ac53f3e1694254e0a6966176e90ed38ff/specification/storage/resource-manager/Microsoft.Storage/stable/2022-05-01/storage.json
  - https://github.com/Azure/azure-rest-api-specs/blob/a98a48c6aced55dcf941778feb4f64c61a4599d2/specification/storage/resource-manager/Microsoft.Storage/stable/2022-05-01/blob.json
  - https://github.com/Azure/azure-rest-api-specs/blob/4e80dd0ac53f3e1694254e0a6966176e90ed38ff/specification/storage/resource-manager/Microsoft.Storage/stable/2022-05-01/file.json

namespace: Microsoft.Azure.Management.Storage
output-folder: provider-storage\powershell
```

### Tag: basic-disableazure-get.csharp
```yaml $(tag) == 'basic-disableazure-get.csharp'
csharp: true
input-file:
    - .\basic-disableazure-get\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-disableazure-get\csharp
```

### Tag: basic-disableazure-get.powershell

```yaml $(tag) == 'basic-disableazure-get.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-disableazure-get\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-disableazure-get\powershell
```
### Tag: basic-disableazure-response.csharp
```yaml $(tag) == 'basic-disableazure-response.csharp'
csharp: true
input-file:
    - .\basic-disableazure-response\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-disableazure-response\csharp
```

### Tag: basic-disableazure-response.powershell

```yaml $(tag) == 'basic-disableazure-response.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-disableazure-response\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-disableazure-response\powershell
```
### Tag: basic-get.csharp
```yaml $(tag) == 'basic-get.csharp'
csharp: true
input-file:
    - .\basic-get\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get\csharp
```

### Tag: basic-get.powershell

```yaml $(tag) == 'basic-get.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-get\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get\powershell
```
### Tag: basic-get-delete.csharp
```yaml $(tag) == 'basic-get-delete.csharp'
csharp: true
input-file:
    - .\basic-get-delete\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get-delete\csharp
```

### Tag: basic-get-delete.powershell

```yaml $(tag) == 'basic-get-delete.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-get-delete\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get-delete\powershell
```
### Tag: basic-get-delete-put-patch.csharp
```yaml $(tag) == 'basic-get-delete-put-patch.csharp'
csharp: true
input-file:
    - .\basic-get-delete-put-patch\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get-delete-put-patch\csharp
```

### Tag: basic-get-delete-put-patch.powershell

```yaml $(tag) == 'basic-get-delete-put-patch.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-get-delete-put-patch\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get-delete-put-patch\powershell
```
### Tag: basic-get-querystr.csharp
```yaml $(tag) == 'basic-get-querystr.csharp'
csharp: true
input-file:
    - .\basic-get-querystr\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get-querystr\csharp
```

### Tag: basic-get-querystr.powershell

```yaml $(tag) == 'basic-get-querystr.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-get-querystr\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get-querystr\powershell
```
### Tag: basic-get-response-operation.csharp
```yaml $(tag) == 'basic-get-response-operation.csharp'
csharp: true
input-file:
    - .\basic-get-response-operation\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get-response-operation\csharp
```

### Tag: basic-get-response-operation.powershell

```yaml $(tag) == 'basic-get-response-operation.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-get-response-operation\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get-response-operation\powershell
```
### Tag: basic-polymorphism.csharp
```yaml $(tag) == 'basic-polymorphism.csharp'
csharp: true
input-file:
    - .\basic-polymorphism\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-polymorphism\csharp
```

### Tag: basic-polymorphism.powershell

```yaml $(tag) == 'basic-polymorphism.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-polymorphism\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-polymorphism\powershell
```
### Tag: basic-request-methods.csharp
```yaml $(tag) == 'basic-request-methods.csharp'
csharp: true
input-file:
    - .\basic-request-methods\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-request-methods\csharp
```

### Tag: basic-request-methods.powershell

```yaml $(tag) == 'basic-request-methods.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-request-methods\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-request-methods\powershell
```
### Tag: basic-response-multioperation.csharp
```yaml $(tag) == 'basic-response-multioperation.csharp'
csharp: true
input-file:
    - .\basic-response-multioperation\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-response-multioperation\csharp
```

### Tag: basic-response-multioperation.powershell

```yaml $(tag) == 'basic-response-multioperation.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-response-multioperation\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-response-multioperation\powershell
```
### Tag: basic-spec-required.csharp
```yaml $(tag) == 'basic-spec-required.csharp'
csharp: true
input-file:
    - .\basic-spec-required\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-spec-required\csharp
```

### Tag: basic-spec-required.powershell

```yaml $(tag) == 'basic-spec-required.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-spec-required\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-spec-required\powershell
```
### Tag: basic-spec-root.csharp
```yaml $(tag) == 'basic-spec-root.csharp'
csharp: true
input-file:
    - .\basic-spec-root\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-spec-root\csharp
```

### Tag: basic-spec-root.powershell

```yaml $(tag) == 'basic-spec-root.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\basic-spec-root\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-spec-root\powershell
```
### Tag: component-definitions-combined.csharp
```yaml $(tag) == 'component-definitions-combined.csharp'
csharp: true
input-file:
    - .\component-definitions-combined\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-definitions-combined\csharp
```

### Tag: component-definitions-combined.powershell

```yaml $(tag) == 'component-definitions-combined.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-definitions-combined\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-definitions-combined\powershell
```
### Tag: component-definitions-local.csharp
```yaml $(tag) == 'component-definitions-local.csharp'
csharp: true
input-file:
    - .\component-definitions-local\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-definitions-local\csharp
```

### Tag: component-definitions-local.powershell

```yaml $(tag) == 'component-definitions-local.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-definitions-local\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-definitions-local\powershell
```
### Tag: component-definitions-remote.csharp
```yaml $(tag) == 'component-definitions-remote.csharp'
csharp: true
input-file:
    - .\component-definitions-remote\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-definitions-remote\csharp
```

### Tag: component-definitions-remote.powershell

```yaml $(tag) == 'component-definitions-remote.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-definitions-remote\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-definitions-remote\powershell
```
### Tag: component-definitions-url.csharp
```yaml $(tag) == 'component-definitions-url.csharp'
csharp: true
input-file:
    - .\component-definitions-url\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-definitions-url\csharp
```

### Tag: component-definitions-url.powershell

```yaml $(tag) == 'component-definitions-url.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-definitions-url\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-definitions-url\powershell
```
### Tag: component-multiparam.csharp
```yaml $(tag) == 'component-multiparam.csharp'
csharp: true
input-file:
    - .\component-multiparam\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-multiparam\csharp
```

### Tag: component-multiparam.powershell

```yaml $(tag) == 'component-multiparam.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-multiparam\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-multiparam\powershell
```
### Tag: component-param.csharp
```yaml $(tag) == 'component-param.csharp'
csharp: true
input-file:
    - .\component-param\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param\csharp
```

### Tag: component-param.powershell

```yaml $(tag) == 'component-param.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-param\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param\powershell
```
### Tag: component-param-additional.csharp
```yaml $(tag) == 'component-param-additional.csharp'
csharp: true
input-file:
    - .\component-param-additional\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-additional\csharp
```

### Tag: component-param-additional.powershell

```yaml $(tag) == 'component-param-additional.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-param-additional\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-additional\powershell
```
### Tag: component-param-grouping.csharp
```yaml $(tag) == 'component-param-grouping.csharp'
csharp: true
input-file:
    - .\component-param-grouping\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-grouping\csharp
```

### Tag: component-param-grouping.powershell

```yaml $(tag) == 'component-param-grouping.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-param-grouping\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-grouping\powershell
```
### Tag: component-param-inbody.csharp
```yaml $(tag) == 'component-param-inbody.csharp'
csharp: true
input-file:
    - .\component-param-inbody\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-inbody\csharp
```

### Tag: component-param-inbody.powershell

```yaml $(tag) == 'component-param-inbody.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-param-inbody\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-inbody\powershell
```
### Tag: component-param-localremote.csharp
```yaml $(tag) == 'component-param-localremote.csharp'
csharp: true
input-file:
    - .\component-param-localremote\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-localremote\csharp
```

### Tag: component-param-localremote.powershell

```yaml $(tag) == 'component-param-localremote.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-param-localremote\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-localremote\powershell
```
### Tag: component-param-remote.csharp
```yaml $(tag) == 'component-param-remote.csharp'
csharp: true
input-file:
    - .\component-param-remote\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-remote\csharp
```

### Tag: component-param-remote.powershell

```yaml $(tag) == 'component-param-remote.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-param-remote\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-remote\powershell
```
### Tag: component-param-resourceasarraay.csharp
```yaml $(tag) == 'component-param-resourceasarraay.csharp'
csharp: true
input-file:
    - .\component-param-resourceasarraay\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-resourceasarraay\csharp
```

### Tag: component-param-resourceasarraay.powershell

```yaml $(tag) == 'component-param-resourceasarraay.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-param-resourceasarraay\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-resourceasarraay\powershell
```
### Tag: component-param-specialproperties.csharp
```yaml $(tag) == 'component-param-specialproperties.csharp'
csharp: true
input-file:
    - .\component-param-specialproperties\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-specialproperties\csharp
```

### Tag: component-param-specialproperties.powershell

```yaml $(tag) == 'component-param-specialproperties.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\component-param-specialproperties\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: component-param-specialproperties\powershell
```
### Tag: datamodels-combineschema.csharp
```yaml $(tag) == 'datamodels-combineschema.csharp'
csharp: true
input-file:
    - .\datamodels-combineschema\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-combineschema\csharp
```

### Tag: datamodels-combineschema.powershell

```yaml $(tag) == 'datamodels-combineschema.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-combineschema\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-combineschema\powershell
```
### Tag: datamodels-datatypes-array.csharp
```yaml $(tag) == 'datamodels-datatypes-array.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-array\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-array\csharp
```

### Tag: datamodels-datatypes-array.powershell

```yaml $(tag) == 'datamodels-datatypes-array.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-array\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-array\powershell
```
### Tag: datamodels-datatypes-boolean.csharp
```yaml $(tag) == 'datamodels-datatypes-boolean.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-boolean\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-boolean\csharp
```

### Tag: datamodels-datatypes-boolean.powershell

```yaml $(tag) == 'datamodels-datatypes-boolean.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-boolean\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-boolean\powershell
```
### Tag: datamodels-datatypes-boolean-quirks.csharp
```yaml $(tag) == 'datamodels-datatypes-boolean-quirks.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-boolean-quirks\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-boolean-quirks\csharp
```

### Tag: datamodels-datatypes-boolean-quirks.powershell

```yaml $(tag) == 'datamodels-datatypes-boolean-quirks.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-boolean-quirks\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-boolean-quirks\powershell
```
### Tag: datamodels-datatypes-byte.csharp
```yaml $(tag) == 'datamodels-datatypes-byte.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-byte\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-byte\csharp
```

### Tag: datamodels-datatypes-byte.powershell

```yaml $(tag) == 'datamodels-datatypes-byte.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-byte\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-byte\powershell
```
### Tag: datamodels-datatypes-date.csharp
```yaml $(tag) == 'datamodels-datatypes-date.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-date\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-date\csharp
```

### Tag: datamodels-datatypes-date.powershell

```yaml $(tag) == 'datamodels-datatypes-date.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-date\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-date\powershell
```
### Tag: datamodels-datatypes-datetime.csharp
```yaml $(tag) == 'datamodels-datatypes-datetime.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-datetime\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-datetime\csharp
```

### Tag: datamodels-datatypes-datetime.powershell

```yaml $(tag) == 'datamodels-datatypes-datetime.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-datetime\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-datetime\powershell
```
### Tag: datamodels-datatypes-file.csharp
```yaml $(tag) == 'datamodels-datatypes-file.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-file\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-file\csharp
```

### Tag: datamodels-datatypes-file.powershell

```yaml $(tag) == 'datamodels-datatypes-file.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-file\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-file\powershell
```
### Tag: datamodels-datatypes-integer.csharp
```yaml $(tag) == 'datamodels-datatypes-integer.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-integer\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-integer\csharp
```

### Tag: datamodels-datatypes-integer.powershell

```yaml $(tag) == 'datamodels-datatypes-integer.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-integer\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-integer\powershell
```

### Tag: datamodels-datatypes-nullable.csharp
```yaml $(tag) == 'datamodels-datatypes-nullable.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-nullable\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-nullable\csharp
```

### Tag: datamodels-datatypes-nullable.powershell

```yaml $(tag) == 'datamodels-datatypes-nullable.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-nullable\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-nullable\powershell
```
### Tag: datamodels-datatypes-object.csharp
```yaml $(tag) == 'datamodels-datatypes-object.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-object\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-object\csharp
```

### Tag: datamodels-datatypes-object.powershell

```yaml $(tag) == 'datamodels-datatypes-object.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-object\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-object\powershell
```
### Tag: datamodels-datatypes-string.csharp
```yaml $(tag) == 'datamodels-datatypes-string.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-string\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-string\csharp
```

### Tag: datamodels-datatypes-string.powershell

```yaml $(tag) == 'datamodels-datatypes-string.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-string\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-string\powershell
```
### Tag: datamodels-datatypes-unixtime.csharp
```yaml $(tag) == 'datamodels-datatypes-unixtime.csharp'
csharp: true
input-file:
    - .\datamodels-datatypes-unixtime\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-unixtime\csharp
```

### Tag: datamodels-datatypes-unixtime.powershell

```yaml $(tag) == 'datamodels-datatypes-unixtime.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-datatypes-unixtime\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-datatypes-unixtime\powershell
```
### Tag: datamodels-enums.csharp
```yaml $(tag) == 'datamodels-enums.csharp'
csharp: true
input-file:
    - .\datamodels-enums\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-enums\csharp
```

### Tag: datamodels-enums.powershell

```yaml $(tag) == 'datamodels-enums.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\datamodels-enums\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: datamodels-enums\powershell
```
### Tag: extension-ms-azureresource.csharp
```yaml $(tag) == 'extension-ms-azureresource.csharp'
csharp: true
input-file:
    - .\extension-ms-azureresource\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-azureresource\csharp
```

### Tag: extension-ms-azureresource.powershell

```yaml $(tag) == 'extension-ms-azureresource.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\extension-ms-azureresource\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-azureresource\powershell
```
### Tag: extension-ms-clientflatten.csharp
```yaml $(tag) == 'extension-ms-clientflatten.csharp'
csharp: true
input-file:
    - .\extension-ms-clientflatten\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-clientflatten\csharp
```

### Tag: extension-ms-clientflatten.powershell

```yaml $(tag) == 'extension-ms-clientflatten.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\extension-ms-clientflatten\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-clientflatten\powershell
```
### Tag: extension-ms-clientname.csharp
```yaml $(tag) == 'extension-ms-clientname.csharp'
csharp: true
input-file:
    - .\extension-ms-clientname\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-clientname\csharp
```

### Tag: extension-ms-clientname.powershell

```yaml $(tag) == 'extension-ms-clientname.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\extension-ms-clientname\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-clientname\powershell
```
### Tag: extension-ms-discriminatorvalue.csharp
```yaml $(tag) == 'extension-ms-discriminatorvalue.csharp'
csharp: true
input-file:
    - .\extension-ms-discriminatorvalue\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-discriminatorvalue\csharp
```

### Tag: extension-ms-discriminatorvalue.powershell

```yaml $(tag) == 'extension-ms-discriminatorvalue.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\extension-ms-discriminatorvalue\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-discriminatorvalue\powershell
```
### Tag: extension-ms-enum.csharp
```yaml $(tag) == 'extension-ms-enum.csharp'
csharp: true
input-file:
    - .\extension-ms-enum\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-enum\csharp
```

### Tag: extension-ms-enum.powershell

```yaml $(tag) == 'extension-ms-enum.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\extension-ms-enum\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-enum\powershell
```
### Tag: extension-ms-examples.csharp
```yaml $(tag) == 'extension-ms-examples.csharp'
csharp: true
input-file:
    - .\extension-ms-examples\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-examples\csharp
```

### Tag: extension-ms-examples.powershell

```yaml $(tag) == 'extension-ms-examples.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\extension-ms-examples\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-examples\powershell
```
### Tag: extension-ms-longruningoperation.csharp
```yaml $(tag) == 'extension-ms-longruningoperation.csharp'
csharp: true
input-file:
    - .\extension-ms-longruningoperation\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-longruningoperation\csharp
```

### Tag: extension-ms-longruningoperation.powershell

```yaml $(tag) == 'extension-ms-longruningoperation.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\extension-ms-longruningoperation\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-longruningoperation\powershell
```
### Tag: extension-ms-mutability.csharp
```yaml $(tag) == 'extension-ms-mutability.csharp'
csharp: true
input-file:
    - .\extension-ms-mutability\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-mutability\csharp
```

### Tag: extension-ms-mutability.powershell

```yaml $(tag) == 'extension-ms-mutability.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\extension-ms-mutability\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-mutability\powershell
```
### Tag: extension-ms-pageable.csharp
```yaml $(tag) == 'extension-ms-pageable.csharp'
csharp: true
input-file:
    - .\extension-ms-pageable\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-pageable\csharp
```

### Tag: extension-ms-pageable.powershell

```yaml $(tag) == 'extension-ms-pageable.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\extension-ms-pageable\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-pageable\powershell
```
### Tag: extension-ms-paramlocation.csharp
```yaml $(tag) == 'extension-ms-paramlocation.csharp'
csharp: true
input-file:
    - .\extension-ms-paramlocation\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-paramlocation\csharp
```

### Tag: extension-ms-paramlocation.powershell

```yaml $(tag) == 'extension-ms-paramlocation.powershell'
isSdkGenerator: true
powershell: true
input-file:
    - .\extension-ms-paramlocation\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: extension-ms-paramlocation\powershell
```