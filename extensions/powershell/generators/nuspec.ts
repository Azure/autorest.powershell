/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';

export async function generateNuspec(project: Project) {
  const authors = project.azure ? 'Microsoft Corporation' : project.metadata.authors;
  const owners = project.azure ? 'Microsoft Corporation' : project.metadata.owners;
  const licenseUrl = project.azure ? `https://aka.ms/azps-license` : project.metadata.licenseUrl;
  const projectUrl = project.azure ? `https://github.com/Azure/azure-powershell` : project.metadata.projectUrl;
  const description = project.azure ? `Microsoft Azure PowerShell: ${project.serviceName} cmdlets` : project.metadata.description;
  const copyright = project.azure ? 'Microsoft Corporation. All rights reserved.' : project.metadata.copyright;
  const tags = project.azure ? 'Azure ResourceManager ARM AppConfiguration PSModule' : project.metadata.tags;
  const requireLicenseAcceptance = project.azure ? true : project.metadata.requireLicenseAcceptance;
  const dependencies = project.azure ? `
    <dependencies>
      <dependency id="Az.Accounts" version="${project.accountsVersionMinimum}" />
    </dependencies>` : '';

  project.state.writeFile(project.nuspec, `<?xml version="1.0" encoding="utf-8"?>
<package xmlns="http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd">
  <metadata>
    <id>${project.moduleName}</id>
    <version>${project.moduleVersion}</version>
    <authors>${authors}</authors>
    <owners>${owners}</owners>
    <requireLicenseAcceptance>${requireLicenseAcceptance}</requireLicenseAcceptance>
    <licenseUrl>${licenseUrl}</licenseUrl>
    <projectUrl>${projectUrl}</projectUrl>
    <description>${description}</description>
    <releaseNotes></releaseNotes>
    <copyright>${copyright}</copyright>
    <tags>${tags}</tags>${dependencies}
  </metadata>
  <files>
    <file src="${removeCd(project.formatPs1xml)}" />
    <file src="${removeCd(project.psd1)}" />
    <file src="${removeCd(project.psm1)}" />
    <!-- https://github.com/NuGet/Home/issues/3584 -->
    <file src="${removeCd(project.dll)}" target="${removeCd(project.binFolder)}" />
    <file src="${removeCd(project.binFolder)}/${project.dllName}.deps.json" target="${removeCd(project.binFolder)}" />
    <file src="${removeCd(project.internalFolder)}/**/*.*" exclude="${removeCd(project.internalFolder)}/readme.md" />
    <file src="${removeCd(project.customFolder)}/**/*.*" exclude="${removeCd(project.customFolder)}/readme.md;${removeCd(project.customFolder)}/**/*.cs" />
    <file src="${removeCd(project.docsFolder)}/**/*.md" exclude="${removeCd(project.docsFolder)}/readme.md" />
    <file src="${removeCd(project.exportsFolder)}/**/*.ps1" />
  </files>
</package>`, undefined, 'source-file-other');
}

function removeCd(path: string): string {
  return path.startsWith('./') ? path.replace('./', '') : path;
}