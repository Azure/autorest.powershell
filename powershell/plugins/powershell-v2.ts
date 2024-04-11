/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

//import { codemodel } from '@azure-tools/codemodel-v3';
import {
  deserialize,
  applyOverrides,
  copyResources,
  copyBinaryResources,
  safeEval,
} from '@azure-tools/codegen';
import { AutorestExtensionHost as Host } from '@autorest/extension-base';
import { join } from 'path';
import { Project } from '../internal/project';
import { generatePsm1 } from '../generators/psm1';
import { generateCsproj } from '../generators/csproj';
import { generatePsm1Custom } from '../generators/psm1.custom';
import { generateInputHandlersCustom } from '../generators/inputhandler.custom';
import { generatePsm1Internal } from '../generators/psm1.internal';
import { generateNuspec } from '../generators/nuspec';
import { generateGitIgnore } from '../generators/gitignore';
import { generateGitAttributes } from '../generators/gitattributes';
import { generateReadme } from '../generators/readme';
import { generateScriptCmdlets } from '../generators/script-cmdlet';

const sourceFileCSharp = 'source-file-csharp';
const resources = `${__dirname}/../../resources`;

async function copyRequiredFiles(project: Project) {
  const transformOutput = async (input: string) => {
    return await project.state.resolveVariables(input);
  };

  // Project assets
  await copyResources(
    join(resources, 'assets'),
    async (fname, content) =>
      project.state.writeFile(fname, content, undefined, 'source-file-other'),
    undefined,
    transformOutput
  );

  // Runtime files
  await copyResources(
    join(resources, 'psruntime'),
    async (fname, content) =>
      project.state.writeFile(
        join(project.runtimeFolder, fname),
        content,
        undefined,
        sourceFileCSharp
      ),
    project.overrides,
    transformOutput
  );

  // utils cmdlets
  await copyResources(
    join(resources, 'utils'),
    async (fname, content) =>
      project.state.writeFile(
        join(project.utilsFolder, fname),
        content,
        undefined,
        sourceFileCSharp
      ),
    project.overrides,
    transformOutput
  );

  // Modules files
  if (project.azure) {
    await copyBinaryResources(
      join(resources, 'modules'),
      async (fname, content) =>
        project.state.writeFile(
          join(project.dependencyModuleFolder, fname),
          content,
          undefined,
          'binary-file'
        )
    );
  }

  if (project.azure) {
    // Signing key file
    await copyBinaryResources(
      join(resources, 'signing'),
      async (fname, content) =>
        project.state.writeFile(
          join(project.baseFolder, fname),
          content,
          undefined,
          'binary-file'
        )
    );
  }
}

export async function powershellV2(service: Host) {
  let debug = false;

  try {
    const project = await new Project(service).init();

    await project.writeFiles(async (filename, content) =>
      project.state.writeFile(
        filename,
        applyOverrides(content, project.overrides),
        undefined,
        sourceFileCSharp
      )
    );
    debug = (await project.state.getValue('debug')) || false;
    await project.state.protectFiles(project.psd1);
    await project.state.protectFiles(project.readme);
    await project.state.protectFiles(project.customFolder);
    await project.state.protectFiles(project.testFolder);
    await project.state.protectFiles(project.docsFolder);
    await project.state.protectFiles(project.examplesFolder);
    await project.state.protectFiles(project.resourcesFolder);
    await project.state.protectFiles(project.uxFolder);

    // wait for all the generation to be done
    await copyRequiredFiles(project);
    await generateCsproj(project);
    await generatePsm1(project);
    await generateInputHandlersCustom(project);
    await generatePsm1Custom(project);
    await generatePsm1Internal(project);
    await generateNuspec(project);
    await generateGitIgnore(project);
    await generateGitAttributes(project);
    await generateReadme(project);

    await generateScriptCmdlets(project);
  } catch (E) {
    if (debug && E instanceof Error) {
      console.error(`${__filename} - FAILURE  ${JSON.stringify(E)} ${E.stack}`);
    }
    throw E;
  }
}
