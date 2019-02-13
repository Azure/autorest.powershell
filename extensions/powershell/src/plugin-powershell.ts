/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, processCodeModel } from '@microsoft.azure/autorest.codemodel-v3';
import { generateFormatPs1xml } from './generators/format-ps1xml';
import { Text, TextWithRegions, deserialize, serialize, applyOverrides, copyResources, indent, setIndentation } from '@microsoft.azure/codegen';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { join } from 'path';
import { Project } from './project';
import { State } from './state';
import { generatePsd1 } from './generators/psd1';
import { generatePsm1 } from './generators/psm1';
import { generateCsproj } from './generators/csproj';

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
    await copyRequiredFiles(service, project);
    await generateCsproj(service, project);
    await generatePsd1(service, project);
    await generatePsm1(service, project);
    await generateFormatPs1xml(service, model, project);

  } catch (E) {
    console.error(`${__filename} - FAILURE  ${JSON.stringify(E)} ${E.stack}`);
    throw E;
  }
}

async function copyRequiredFiles(service: Host, project: Project) {
  // Project assets
  await copyResources(join(resources, 'assets'), async (fname, content) => service.WriteFile(fname, content, undefined, 'source-file-other'));

  // Runtime files
  await copyResources(join(resources, 'runtime'), async (fname, content) => service.WriteFile(join(project.runtimefolder, fname), content, undefined, sourceFileCSharp), project.overrides);
}

