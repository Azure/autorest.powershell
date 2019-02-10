import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';
import { setIndentation, indent } from '@microsoft.azure/codegen';
import { PsdFile } from '../file-formats/psd-file';

export async function generatePsd1(service: Host, project: Project) {
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
}
