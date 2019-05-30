/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';
import { PSScriptFile } from '../file-formats/psscript-file';
import { relative } from 'path';
import { getProfileExportScript } from './psm1'

export async function generatePsm1Internal(project: Project) {
  const psm1 = new PSScriptFile(await project.state.readFile(project.psm1Internal) || '');
  const dllPath = relative(project.internalFolder, project.dll);
  psm1.prepend('Generated', `
  # Load the private module dll
  $null = Import-Module -PassThru -Name (Join-Path $PSScriptRoot '${dllPath}')

  # Get the private module's instance
  $instance = [${project.serviceNamespace.moduleClass.declaration}]::Instance

  # Export nothing to clear implicit exports
  Export-ModuleMember
${getProfileExportScript('$PSScriptRoot')}`);
  psm1.trim();
  project.state.writeFile(project.psm1Internal, `${psm1}`, undefined, 'source-file-powershell');
}