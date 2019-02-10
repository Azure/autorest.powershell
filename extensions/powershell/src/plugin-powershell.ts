/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, processCodeModel } from '@microsoft.azure/autorest.codemodel-v3';
import { generateFormatPs1xml } from './generate-format-ps1xml';

import { PsdFile } from './file-formats/psd-file'
import { Text, TextWithRegions, deserialize, serialize, applyOverrides, copyResources, indent, setIndentation } from '@microsoft.azure/codegen';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { join } from 'path';
import { Project } from './project';
import { State } from './state';
import { PSScriptFile } from './file-formats/psscript-file';
const sourceFileCSharp = 'source-file-csharp';
const resources = `${__dirname}/../resources`;

export async function powershell(service: Host) {
  try {
    // Get the list of files
    const files = await service.ListInputs('code-model-v3');
    if (files.length === 0) {
      throw new Error('Inputs missing.');
    }

    const codemodel = files[0];

    // get the openapi document
    const codeModelText = await service.ReadFile(codemodel);
    const model = await deserialize<codemodel.Model>(codeModelText, codemodel);

    // generate some files
    const modelState = new State(service, model, codemodel);
    const project = await new Project(modelState).init();

    await project.writeFiles(async (filename, content) => service.WriteFile(filename, applyOverrides(content, project.overrides), undefined, sourceFileCSharp));

    await service.ProtectFiles(project.csproj);
    await service.ProtectFiles(project.customFolder);
    await service.ProtectFiles(project.testFolder);

    // wait for all the generation to be done
    await copyRuntime(service, project);
    await generateCsproj(service, project);
    await generateModule(service, project);
    await generateFormatPs1xml(service, model, project);

    // debug data
    service.WriteFile('code-model-v3.powershell.yaml', serialize(model), undefined, 'source-file-other');
  } catch (E) {
    console.error(E);
    console.error((<Error>E).stack);
  }
}

async function copyRuntime(service: Host, project: Project) {
  // PowerShell Scripts
  await copyResources(join(resources, 'scripts', 'powershell'), async (fname, content) => service.WriteFile(fname, content, undefined, sourceFileCSharp));

  // c# files
  await copyResources(join(resources, 'runtime', 'powershell'), async (fname, content) => service.WriteFile(join(project.runtimefolder, fname), content, undefined, sourceFileCSharp), project.overrides);
  if (project.azure) {
    await copyResources(join(resources, 'runtime', 'powershell.azure'), async (fname, content) => service.WriteFile(join(project.runtimefolder, fname), content, undefined, sourceFileCSharp), project.overrides);
  }
}

async function generateCsproj(service: Host, project: Project) {
  // write out the csproj file if it's not there.
  if (!await service.ReadFile(project.csproj)) {
    service.WriteFile(project.csproj, `<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <LangVersion>7.1</LangVersion>
    <OutputType>Library</OutputType>
     <TargetFramework>netstandard2.0</TargetFramework>
    <nowarn>1998</nowarn> <!-- some methods are marked async that don't have an await in them.-->
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="PowerShellStandard.Library" Version="5.1.0" />
    <PackageReference Include="Microsoft.CSharp" Version="4.4.1" />
    <PackageReference Include="System.Text.Encodings.Web" Version="4.3.0" />
  </ItemGroup>
</Project>
`, undefined, sourceFileCSharp);
  }
}

async function generateModule(service: Host, project: Project) {
  setIndentation(2);
  // write out the psd1 file if it's not there.

  const psd1 = new PsdFile(await service.ReadFile(project.psd1));

  // don't overwrite this section if it exists.
  if (!psd1.has('identity')) {
    psd1.append('identity', function* () {
      yield indent(`ModuleVersion="1.0"`);
      yield indent(`Description=""`);
      yield indent(`PowerShellVersion="3.0"`);
      if (project.azure) {
        yield indent(`Author="Microsoft Corporation"`);
        yield indent(`CompanyName="Microsoft Corporation"`);
        yield indent(`Copyright="Microsoft Corporation. All rights reserved."`);
      }
    });
  }

  if (!psd1.has('private data')) {
    psd1.append('private data', function* () {
      yield ``;
      yield indent(`PrivateData = @{`);
      yield indent(`# Package Metadata for PowerShellGet`, 2)
      yield indent(`PSData = @{`, 2);

      if (project.azure) {
        yield indent(`# Tags applied to this module.These help with module discovery in online galleries.`, 3);
        yield indent(`Tags = 'Azure', 'ServiceManagement'`, 3)
        yield ``;
        yield indent(`# A URL to the license for this module.`, 3)
        yield indent(`LicenseUri = 'https://aka.ms/azps-license'`, 3)
        yield ``;
        yield indent(`# A URL to the main website for this project.`, 3)
        yield indent(`ProjectUri = 'https://github.com/Azure/azure-powershell'`, 3)
        yield ``;
        yield indent(`# A URL to an icon representing this module.`, 3)
        yield indent(`# IconUri = ''`, 3)
        yield ``;
        yield indent(`# ReleaseNotes of this module`, 3)
        yield indent(`ReleaseNotes = ''`, 3)
        yield ``;
        yield indent(`# External dependent modules of this module`, 3)
        yield indent(`# ExternalModuleDependencies = ''`, 3)
        yield ``;
      } else {
        // non-azure cmdlets
        yield indent(`# Tags applied to this module.These help with module discovery in online galleries.`, 3);
        yield indent(`Tags = ''`, 3)
        yield ``;
        yield indent(`# A URL to the license for this module.`, 3)
        yield indent(`LicenseUri = ''`, 3)
        yield ``;
        yield indent(`# A URL to the main website for this project.`, 3)
        yield indent(`ProjectUri = ''`, 3)
        yield ``;
        yield indent(`# A URL to an icon representing this module.`, 3)
        yield indent(`# IconUri = ''`, 3)
        yield ``;
        yield indent(`# ReleaseNotes of this module`, 3)
        yield indent(`ReleaseNotes = ''`, 3)
        yield ``;
        yield indent(`# External dependent modules of this module`, 3)
        yield indent(`# ExternalModuleDependencies = ''`, 3)
      }
      yield indent(`} # End of PSData hashtable`, 2)

      yield indent(`} # End of PrivateData hashtable`)
      yield ``;
    });
  }

  // don't overwrite this section if it exists.
  if (!psd1.has('exports')) {
    psd1.append('exports', function* () {
      yield indent(`# don't export any actual cmdlets by default`);
      yield indent(`CmdletsToExport = ''`);
      yield ``;
      yield indent(`# export the functions that we loaded(these are the proxy cmdlets)`);
      yield indent(`FunctionsToExport = '*-*'`);
    });
  }

  // always overwrite this section
  psd1.append('modules', function* () {
    yield ``;
    yield indent(`# Warning: This region is code-generated and will get replaced upon regeneration.`);
    yield ``;
    yield indent(`NestedModules = @(`);
    yield indent(`"./bin/${project.moduleName}.private.dll"`, 2);
    yield indent(`"${project.psm1}"`, 2);
    yield indent(`)`);
    yield ``;
    if (project.azure) {
      yield indent(`RequiredModules = @(`);
      // add in reference to the profile module here.
      yield indent(`# @({ModuleName="Az.Accounts", ModuleVersion="2.0",Guid="00000000-0000-0000-0000-000000000000"})`, 2);
      yield indent(`)`);
      yield ``;
    }
    yield indent(`FormatsToProcess = @(`);
    yield indent(`"./${project.moduleName}.format.ps1xml"`, 2);
    yield indent(`)`);
  })

  service.WriteFile(project.psd1, psd1.text, undefined, 'source-file-powershell');

  // write out the psm1 file if it's not there.

  const psm1 = new PSScriptFile(await service.ReadFile(project.psm1) || '');

  if (project.azure) {
    psm1.prepend('AzureInitialization', `
    # from PSModulePath
    # (this must be the modified version of Az.Accounts)

    $module = Get-Module Az.Accounts 
    if ($module -ne $null -and $module.Version.ToString().CompareTo("0.4.0") -lt 0) 
    { 
        Write-Error "This module requires Az.Accounts version 0.4.0. An earlier version of Az.Accounts is imported in the current PowerShell session. Please open a new session before importing this module. This error could indicate that multiple incompatible versions of the Azure PowerShell cmdlets are installed on your system. Please see https://aka.ms/azps-version-error for troubleshooting information." -ErrorAction Stop 
    } 
    elseif ($module -eq $null) 
    { 
        $module = Import-Module Az.Accounts -MinimumVersion 0.4.0 -Scope Global -passthru
    }

    Write-Host "Loaded Common Module '$($module.Name)'"

    # ask for the table of functions we can call in the common module.
    $VTable = Register-AzModule

    # delegate responsibility to the common module for tweaking the pipeline at module load
    $instance.OnModuleLoad = $VTable.OnModuleLoad

    # and a chance to tweak the pipeline when we are about to make a call.
    $instance.OnNewRequest = $VTable.OnNewRequest

    # Need to get parameter values back from the common module
    $instance.GetParameterValue = $VTable.GetParameterValue

    # need to let the common module listen to events from this module
    $instance.EventListener = $VTable.EventListener

    # get argument completers from the common module
    $instance.ArgumentCompleter = $VTable.ArgumentCompleter
`);
  }

  psm1.prepend('Initialization', `
    # this module instance.
    $instance =  [${project.serviceNamespace.moduleClass.declaration}]::Instance

    # load nested script module if it exists
    if(Test-Path "$PSScriptRoot/bin/${project.moduleName}.scripts.psm1") {
      Import-Module "$PSScriptRoot/bin/${project.moduleName}.scripts.psm1"
    }

    $privatemodule = Import-Module -PassThru "$PSScriptRoot/bin/${project.moduleName}.private.dll"
    # export the 'exported' cmdlets
    Get-ChildItem "$PSScriptRoot/exported" -Recurse -Filter "*.ps1" -File | Sort-Object Name | ForEach-Object {
      Write-Verbose "Dot sourcing private script file: $($_.Name)"
      . $_.FullName
      # Explicity export the member
      Export-ModuleMember -Function $_.BaseName
    }`);

  psm1.append('Finalization', `
    # finish initialization of this module
    $instance.Init();
  `);

  psm1.trim();

  service.WriteFile(project.psm1, `${psm1}`, undefined, 'source-file-powershell');
}
