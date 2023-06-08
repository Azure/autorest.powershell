/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { values } from '@azure-tools/linq';
import { Host } from '@autorest/extension-base';
import { join } from 'path';
import { CodeModel, ObjectSchema } from '@autorest/codemodel';
import { ModelState } from '../utils/model-state';
import { Project } from '../sdk/project';
import { OperationGroup } from '@autorest/codemodel';
import { getAllPublicVirtualProperties } from '@azure-tools/codemodel-v3';
import { wrapComments } from '../utils/WrapComments';

const ejs = require('ejs');

const resources = `${__dirname}/../../resources`;

async function generateModels(project: Project) {
  const path = join(join(resources, 'templates'), 'model.ejs');
  for (const model of values(project.model.schemas.objects)) {
    if (model.extensions && (model.extensions['x-ms-client-flatten'] || model.extensions['x-ms-external']) || model.language.default.pagable) {
      // skip flattened model and pageble model
      continue;
    }
    const content = await ejs.renderFile(path, { model: model, project: project, wrapComments: wrapComments });
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

async function generatePageClasses(project: Project) {
  for (const [key, value] of Object.entries(project.state.model.language.default.pageClasses)) {
    const path = join(join(resources, 'templates'), 'page.ejs');
    const className = value;
    const nextLinkName = key.split(' ')[0];
    const itemName = key.split(' ')[1];
    const page = { className: className, nextLinkName: nextLinkName, itemName: itemName };
    const content = await ejs.renderFile(path, { project: project, page: page });
    project.state.writeFile(`${project.baseFolder}\\Models\\${page.className}.cs`, content, undefined, 'source-file-csharp');

  }
}

async function generateExceptions(project: Project) {
  const processedException = new Set();
  const path = join(join(resources, 'templates'), 'exception.ejs');
  for (const operationGroup of values(project.state.model.operationGroups)) {
    for (const operation of values(operationGroup.operations)) {
      if (operation.exceptions && (<any>operation.exceptions[0]).schema) {
        const exception = operation.exceptions[0];
        if (processedException.has((<any>exception).schema) || ((<any>exception).schema.extensions && (<any>exception).schema.extensions['x-ms-external'])) {
          continue;
        } else {
          processedException.add((<any>exception).schema);
        }
        const content = await ejs.renderFile(path, { project: project, exception: exception });
        project.state.writeFile(`${project.baseFolder}\\Models\\${(<any>exception).schema.language.default.name}Exception.cs`, content, undefined, 'source-file-csharp');
      }
    }
  }
}

export async function generate(service: Host) {
  try {
    const project = await new Project(service).init();
    await generateClient(project);
    await generateClientInterface(project);
    await generateMethodGroups(project);
    await generateModels(project);
    await generateEnums(project);
    await generatePageClasses(project);
    await generateExceptions(project);
  } catch (E) {
    console.error(`${__filename} - FAILURE  ${JSON.stringify(E)}`);
    throw E;
  }
}
