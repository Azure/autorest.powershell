# Built-In Metadata Properties

Here is a list of available metadata properties you may specify in `readme.md`. They will affect the generated PowerShell manifest file (`*.psd1`) and the NuGet package manifest file (`*.nupkg`);

## Sample

```yaml
metadata:
  authors: Microsoft Corporation
  owners: Microsoft Corporation
  description: 'Microsoft Azure PowerShell: $(service-name) cmdlets'
  copyright: Microsoft Corporation. All rights reserved.
  tags: Azure ResourceManager ARM PSModule $(service-name)
  companyName: Microsoft Corporation
  requireLicenseAcceptance: true
  licenseUri: https://aka.ms/azps-license
  projectUri: https://github.com/Azure/azure-powershell
  requiredModules:
    - name: Az.KeyVault
      version: 3.0.1
  requiredAssemblies:
    - ./custom/lib/third-party.dll
  nestedModules:
    - ./custom/my-custom.psm1
  formatsToProcess:
    - ./custom/my.formats.ps1xml
  typesToProcess:
    - ./custom/my.types.ps1xml
  scriptsToProcess:
    - ./custom/my.scripts.ps1xml
  functionsToExport:
    - Get-AzFunctionApp
    - New-AzFunctionApp
    - Remove-AzFunctionApp
    - Update-AzFunctionApp
  cmdletsToExport: []
  aliasesToExport: []
```

## Notes

- Your context will overwrite (rather than append) the default values.
- Use empty array `[]` if you want to overwrite default value with empty.