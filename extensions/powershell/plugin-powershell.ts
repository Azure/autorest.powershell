/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel } from '@microsoft.azure/autorest.codemodel-v3';
import { deserialize, applyOverrides, copyResources, copyBinaryResources, safeEval } from '@microsoft.azure/codegen';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { join } from 'path';
import { Project } from './project';
import { State } from './state';
import { generatePsd1 } from './generators/psd1';
import { generatePsm1 } from './generators/psm1';
import { generateCsproj } from './generators/csproj';
import { generatePsm1Custom } from './generators/psm1.custom';
import { generatePsm1Internal } from './generators/psm1.internal';
import { generateNuspec } from './generators/nuspec';
import { generateGitIgnore } from './generators/gitignore';
import { generateGitAttributes } from './generators/gitattributes';
import { generateReadme } from './generators/readme';
import { generateScriptCmdlets } from './generators/script-cmdlet';

const sourceFileCSharp = 'source-file-csharp';
const resources = `${__dirname}/../resources`;

export async function powershell(service: Host) {
  try {
    const project = await new Project(service).init();
    await project.writeFiles(async (filename, content) => project.state.writeFile(filename, applyOverrides(content, project.overrides), undefined, sourceFileCSharp));

    await service.ProtectFiles(project.psd1);
    await service.ProtectFiles(project.readme);
    await service.ProtectFiles(project.customFolder);
    await service.ProtectFiles(project.testFolder);
    await service.ProtectFiles(project.docsFolder);
    await service.ProtectFiles(project.examplesFolder);
    await service.ProtectFiles(project.resourcesFolder);

    // wait for all the generation to be done
    await copyRequiredFiles(project);
    await generateCsproj(project);
    await generatePsd1(project);
    await generatePsm1(project);
    await generatePsm1Custom(project);
    await generatePsm1Internal(project);
    await generateNuspec(project);
    await generateGitIgnore(project);
    await generateGitAttributes(project);
    await generateReadme(project);

    await generateScriptCmdlets(project);

  } catch (E) {
    console.error(`${__filename} - FAILURE  ${JSON.stringify(E)} ${E.stack}`);
    throw E;
  }
}

async function copyRequiredFiles(project: Project) {
  const transformOutput = async (input: string) => { return await project.state.resolveVariables(input); }

  // Project assets
  await copyResources(join(resources, 'assets'), async (fname, content) => project.state.writeFile(fname, content, undefined, 'source-file-other'), undefined, transformOutput);

  // Runtime files
  await copyResources(join(resources, 'runtime'), async (fname, content) => project.state.writeFile(join(project.runtimeFolder, fname), content, undefined, sourceFileCSharp), project.overrides, transformOutput);

  // Modules files
  await copyBinaryResources(join(resources, 'modules'), async (fname, content) => project.state.writeFile(join(project.dependencyModuleFolder, fname), content, undefined, 'binary-file'));

  if (project.azure) {
    // Signing key file
    await copyBinaryResources(join(resources, 'signing'), async (fname, content) => project.state.writeFile(join(project.baseFolder, fname), content, undefined, 'binary-file'));
  }
}

