/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';
import { setIndentation, indent, guid, values } from '@microsoft.azure/codegen';
import { PsdFile } from '../file-formats/psd-file';

export async function generatePsd1(service: Host, project: Project) {
  setIndentation(2);
  const psd1 = new PsdFile(await service.ReadFile(project.psd1));

  if (!psd1.has('definition')) {
    psd1.append('definition', function* () {
      yield indent(`RootModule = '${project.psm1}'`);
      yield indent(`ModuleVersion = '${project.moduleVersion}'`);
      yield indent(`CompatiblePSEditions = 'Core', 'Desktop'`);
      yield indent(`GUID = '${guid()}'`);
      const author = project.azure ? 'Microsoft Corporation' : '';
      yield indent(`Author = '${author}'`);
      const companyName = project.azure ? 'Microsoft Corporation' : '';
      yield indent(`CompanyName = '${companyName}'`);
      const copyright = project.azure ? 'Microsoft Corporation. All rights reserved.' : '';
      yield indent(`Copyright = '${copyright}'`);
      const description = project.azure ? `Microsoft Azure PowerShell: ${project.serviceName} cmdlets` : '';
      yield indent(`Description = '${description}'`);
      yield indent(`PowerShellVersion = '5.1'`);
      yield indent(`DotNetFrameworkVersion = '4.7.2'`);
      yield indent(`RequiredAssemblies = '${project.dll}'`);
      yield indent(`FormatsToProcess = '${project.formatPs1xml}'`);
    });
  }

  if (!psd1.has('private data')) {
    psd1.append('private data', function* () {
      yield indent(`PrivateData = @{`);
      yield indent(`PSData = @{`, 2);

      const tags = project.azure ? `'Azure', 'ResourceManager', 'ARM', '${project.serviceName}'` : `''`;
      yield indent(`Tags = ${tags}`, 3);
      const licenseUri = project.azure ? `https://aka.ms/azps-license` : '';
      yield indent(`LicenseUri = '${licenseUri}'`, 3);
      const projectUri = project.azure ? `https://github.com/Azure/azure-powershell` : '';
      yield indent(`ProjectUri = '${projectUri}'`, 3);
      yield indent(`ReleaseNotes = ''`, 3);
      if (project.azure && project.profiles.length) {
        const profiles = values(project.profiles)
          .linq.select(p => `'${p}'`)
          .linq.toArray().join(', ');
        yield indent(`Profiles = ${profiles}`, 3);
      }

      yield indent(`}`, 2);
      yield indent(`}`);
    });
  }

  service.WriteFile(project.psd1, psd1.text, undefined, 'source-file-powershell');
}
