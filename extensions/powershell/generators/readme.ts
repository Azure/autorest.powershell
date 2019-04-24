/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Project } from '../project';
import { MdFile } from '../file-formats/md-file';

export async function generateReadme(project: Project) {
  const md = new MdFile(await project.state.readFile(project.readme) || '');
  let azureInfo = ''
  if (project.azure) {
    azureInfo = `
## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version ${project.accountsVersionMinimum} or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.
`
  }

  md.append('Generated', `# ${project.moduleName}
This directory contains the PowerShell module for the ${project.serviceName} service.

---
## Status
[![${project.moduleName}](https://img.shields.io/powershellgallery/v/${project.moduleName}.svg?style=flat-square&label=${project.moduleName} "${project.moduleName}")](https://www.powershellgallery.com/packages/${project.moduleName}/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.
${azureInfo}
## Development
For information on how to develop for \`${project.moduleName}\`, see [how-to.md](how-to.md).`);
  md.trim();
  project.state.writeFile(project.readme, md.text, undefined, 'source-file-other');
}