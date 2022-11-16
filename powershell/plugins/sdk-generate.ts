/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { values } from '@azure-tools/linq';
import { Host } from '@azure-tools/autorest-extension-base';
import { join } from 'path';
import { CodeModel, ObjectSchema } from '@azure-tools/codemodel';
import { ModelState } from '../utils/model-state';
import { Project } from '../sdk/project';
import { OperationGroup } from '@azure-tools/codemodel';
import { getAllPublicVirtualProperties } from '@azure-tools/codemodel-v3';

const ejs = require('ejs');

const resources = `${__dirname}/../../resources`;

async function generateModels(project: Project) {
  const path = join(join(resources, 'templates'), 'model.ejs');
  for (const model of values(project.model.schemas.objects)) {
    if (model.extensions && model.extensions['x-ms-client-flatten']) {
      // skip flattened model
      continue;
    }
    const content = await ejs.renderFile(path, { model: model, project: project });
    project.state.writeFile(`${project.baseFolder}\\Models\\${model.language.default.name}.cs`, content, undefined, 'source-file-csharp');
  }
}

async function generateEnums(project: Project) {
  const path = join(join(resources, 'templates'), 'enum.ejs');
  for (const model of values(project.model.schemas.sealedChoices)) {
    const content = await ejs.renderFile(path, { model: model, project: project });
    project.state.writeFile(`${project.baseFolder}\\Models\\${model.language.default.name}.cs`, content, undefined, 'source-file-csharp');
  }
}

async function generateMethodGroups(project: Project) {
  const path = join(join(resources, 'templates'), 'azureMethodGroup.ejs');
  const interfacePath = join(join(resources, 'templates'), 'methodGroupInterface.ejs');
  const extensionPath = join(join(resources, 'templates'), 'extensions.ejs');
  for (const operationGroup of values(project.state.model.operationGroups)) {
    // generate method group class
    const key = operationGroup.$key === 'Operations' ? '' : operationGroup.$key;
    const content = await ejs.renderFile(path, { methodGroup: operationGroup, project: project });
    project.state.writeFile(`${project.baseFolder}\\${key}Operations.cs`, content, undefined, 'source-file-csharp');
    // generate method group interface
    const interfaceContent = await ejs.renderFile(interfacePath, { methodGroup: operationGroup, project: project });
    project.state.writeFile(`${project.baseFolder}\\I${key}Operations.cs`, interfaceContent, undefined, 'source-file-csharp');
    // generate method group extensions
    const extensionContent = await ejs.renderFile(extensionPath, { methodGroup: operationGroup, project: project });
    project.state.writeFile(`${project.baseFolder}\\${key}OperationsExtensions.cs`, extensionContent, undefined, 'source-file-csharp');
  }
}

async function generateClient(project: Project) {
  const path = join(join(resources, 'templates'), 'azureServiceClient.ejs');
  const content = await ejs.renderFile(path, { project: project });
  project.state.writeFile(`${project.baseFolder}\\${project.state.model.info.title}.cs`, content, undefined, 'source-file-csharp');
}

async function generateClientInterface(project: Project) {
  const path = join(join(resources, 'templates'), 'serviceClientInterface.ejs');
  const content = await ejs.renderFile(path, { project: project });
  project.state.writeFile(`${project.baseFolder}\\I${project.state.model.info.title}.cs`, content, undefined, 'source-file-csharp');
}

export async function generate(service: Host) {
  try {
    const project = await new Project(service).init();
    await generateClient(project);
    await generateClientInterface(project);
    await generateMethodGroups(project);
    await generateModels(project);
    await generateEnums(project);
  } catch (E) {
    console.error(`${__filename} - FAILURE  ${JSON.stringify(E)}`);
    throw E;
  }
}
