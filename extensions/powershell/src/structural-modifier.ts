/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, processCodeModel } from '@microsoft.azure/autorest.codemodel-v3';
import { values } from '@microsoft.azure/codegen';
import { Host } from '@microsoft.azure/autorest-extension-base';

const directivesToFilter = new Set<string>([
  'remove-command'
]);

interface RemoveCommandDirective {
  'remove-command': string;
}

let directives: Array<any> = [];
let nounPrefix = '';

export async function structuralModifier(service: Host) {
  directives = values(await service.GetValue('directive'))
    .linq.where(directive => values(Object.keys(directive))
      .linq.where(key => directivesToFilter.has(key))
      .linq.any(each => !!each))
    .linq.toArray();
  const azure = await service.GetValue('azure') || await service.GetValue('azure-arm') || false;
  nounPrefix = await service.GetValue('noun-prefix') || azure ? 'Az' : ``;
  return processCodeModel(tweakModel, service);
}

function isRemoveCommandDirective(it: any): it is RemoveCommandDirective {
  return it['remove-command'];
}

async function tweakModel(model: codemodel.Model): Promise<codemodel.Model> {

  for (const directive of directives) {

    if (isRemoveCommandDirective(directive)) {
      const removeCommandVal = directive['remove-command'];

      for (const [key, operation] of Object.entries(model.commands.operations)) {
        const isRegex = !isCommandNameLiteral(removeCommandVal);
        if (isRegex) {
          const regex = new RegExp(removeCommandVal);
          if (`${operation.verb}-${nounPrefix}${operation.noun}`.match(regex)) {
            delete model.commands.operations[key];
          }
        } else {
          if (`${operation.verb}-${nounPrefix}${operation.noun}`.toLowerCase() === removeCommandVal.toLowerCase()) {
            delete model.commands.operations[key];
          }
        }
      }

      continue;
    }
  }

  return model;
}

function isCommandNameLiteral(str: string): boolean {
  return /^[a-zA-Z]+-[a-zA-Z]+$/.test(str);
}