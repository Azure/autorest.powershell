/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, schema, command } from '@microsoft.azure/autorest.codemodel-v3';
import { values } from '@microsoft.azure/codegen';
import { deserialize, serialize } from '@microsoft.azure/codegen';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { Scheme } from '@microsoft.azure/autorest.codemodel-v3/dist/code-model/security-scheme';
import { triggerAsyncId } from 'async_hooks';


export async function cosmeticModifier(service: Host) {
  return processCodeModel(tweakModel, service);
}

const directivesToFilter = new Set<string>([
  'where-model',
  'where-parameter',
  'where-property',
  'remove-command'
]);

let directives: Array<any> = [];
let nounPrefix = '';

async function processCodeModel(processExtension: (input: codemodel.Model, service: Host) => Promise<codemodel.Model>, service: Host) {
  // Get the list of files
  const files = await service.ListInputs('code-model-v3');

  // get the openapi document
  if (files.length === 0) {
    throw new Error('Inputs missing.');
  }

  const original = await service.ReadFile(files[0]);

  // deserialize
  let codeModel = await deserialize<codemodel.Model>(original, files[0]);
  directives = values(await service.GetValue('directive'))
    .linq.where(directive => values(Object.keys(directive))
      .linq.where(key => directivesToFilter.has(key))
      .linq.any(each => !!each))
    .linq.toArray();

  const azure = await service.GetValue('azure') || await service.GetValue('azure-arm') || false;
  nounPrefix = await service.GetValue('noun-prefix') || azure ? 'Az' : ``;
  codeModel = await processExtension(codeModel, service);

  // output the model
  await service.WriteFile('code-model-v3.yaml', serialize(codeModel), undefined, 'code-model-v3');
}

interface WhereParameterDirective {
  'where-parameter': string;
  'set-name': string
}

interface WherePropertyDirective {
  'where-property': string;
  'set-name': string
}

interface WhereModelDirective {
  'where-model': string;
  'set-name': string
}

interface RemoveCommandDirective {
  'remove-command': string;
}

function isWhereParameterDirective(it: any): it is WhereParameterDirective {
  return it['where-parameter'];
}

function isWherePropertyDirective(it: any): it is WherePropertyDirective {
  return it['where-property'];
}

function isWhereModelDirective(it: any): it is WhereModelDirective {
  return it['where-model'];
}

function isRemoveCommandDirective(it: any): it is RemoveCommandDirective {
  return it['remove-command'];
}

async function tweakModel(model: codemodel.Model): Promise<codemodel.Model> {

  for (const directive of directives) {

    if (isWhereParameterDirective(directive)) {
      const parameters = values(model.commands.operations)
        .linq.selectMany(operation => values(operation.parameters))
        .linq.where(parameter => parameter.details.csharp.name === directive['where-parameter'])
        .linq.toArray();

      parameters.forEach(parameter => {
        parameter.details.csharp.name = directive["set-name"];
      });

      continue;
    }

    if (isWherePropertyDirective(directive)) {
      const properties = values(model.schemas)
        .linq.selectMany(schema => values(schema.properties))
        .linq.where(property => property.details.csharp.name === directive['where-property'])
        .linq.toArray();

      properties.forEach(property => {
        property.details.csharp.name = directive["set-name"];
      });

      continue;
    }

    if (isWhereModelDirective(directive)) {
      const whereModelVal = directive['where-model'];
      const isRegex = !(/^[a-zA-Z0-9]*$/.test(whereModelVal));
      if (isRegex) {
        const regex = new RegExp(whereModelVal);
        const models = values(model.schemas)
          .linq.where(schema => !!schema.details.csharp.name.match(regex))
          .linq.toArray();

        models.forEach(model => {
          const replacer = directive['set-name'];
          model.details.csharp.name = model.details.csharp.name.replace(regex, replacer);
        });
      } else {
        const models = values(model.schemas)
          .linq.where(schema => schema.details.csharp.name === whereModelVal)
          .linq.toArray();

        models.forEach(model => {
          model.details.csharp.name = model.details.csharp.name.replace(whereModelVal, directive['set-name']);
        });
      }

      continue;
    }

    if (isRemoveCommandDirective(directive)) {
      const removeCommandVal = directive['remove-command'];

      // it is regex if it has something other than number, alpha-num or hyphen(-)
      const isRegex = !(/^[a-zA-Z0-9-]*$/.test(removeCommandVal));
      if (isRegex) {
        const regex = new RegExp(removeCommandVal);
        for (const [key, operation] of Object.entries(model.commands.operations)) {
          if (`${operation.verb}-${nounPrefix}${operation.noun}`.match(regex)) {
            delete model.commands.operations[key];
          }
        }
      } else {
        for (const [key, operation] of Object.entries(model.commands.operations)) {
          if (`${operation.verb}-${nounPrefix}${operation.noun}` === removeCommandVal) {
            delete model.commands.operations[key];
          }
        }
      }

      continue;
    }
  }

  return model;
}

