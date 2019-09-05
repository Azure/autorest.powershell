/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@azure-tools/autorest-extension-base';
import { Project } from '../project';

function removeCd(path: string): string {
  return path.startsWith('./') ? path.replace('./', '') : path;
}
export async function generateNuspec(project: Project) {
  const dependencies = project.azure ? `
    <dependencies>
      <dependency id="Az.Accounts" version="${project.accountsVersionMinimum}" />
    </dependencies>` : '';

  project.state.writeFile(project.nuspec, `<?xml version="1.0" encoding="utf-8"?>
<package xmlns="http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd">
  <metadata>
    <id>${project.moduleName}</id>
    <version>${project.moduleVersion}</version>
    <authors>${project.metadata.authors}</authors>
    <owners>${project.metadata.owners}</owners>
    <requireLicenseAcceptance>${project.metadata.requireLicenseAcceptance}</requireLicenseAcceptance>
    <licenseUrl>${project.metadata.licenseUri}</licenseUrl>
    <projectUrl>${project.metadata.projectUri}</projectUrl>
    <description>${project.metadata.description}</description>
    <releaseNotes></releaseNotes>
    <copyright>${project.metadata.copyright}</copyright>
    <tags>${project.metadata.tags}</tags>${dependencies}
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

