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

### Tag: basic-get.csharp

```yaml $(tag) == 'basic-get.csharp'
csharp: true
input-file:
  - .\basic-get\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get\basic-get.csharp
```

### Tag: basic-get.powershell

```yaml $(tag) == 'basic-get.powershell'
isSdkGenerator: true
powershell: true
input-file:
  - .\basic-get\swagger.json

namespace: Microsoft.Azure.Sample
output-folder: basic-get\basic-get.powershell
```