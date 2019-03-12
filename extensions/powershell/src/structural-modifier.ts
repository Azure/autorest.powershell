/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, processCodeModel } from '@microsoft.azure/autorest.codemodel-v3';
import { values, items } from '@microsoft.azure/codegen';
import { Host, Channel } from '@microsoft.azure/autorest-extension-base';
import { CommandOperation } from '@microsoft.azure/autorest.codemodel-v3/dist/code-model/command-operation';

interface RemoveCommandDirective {
  where: {
    noun?: string;
    verb?: string;
    variant?: string;
  };
  remove: Boolean;
}

let directives: Array<any> = [];

function isRemoveCommandDirective(it: any): it is RemoveCommandDirective {
  const directive = <RemoveCommandDirective>it;
  const where = directive.where;
  const remove = directive.remove;
  if (where && remove && (where.noun || where.verb || where.variant)) {
    return true;
  }

  return false;
}

export async function structuralModifier(service: Host) {
  directives = values(await service.GetValue('directive'))
    .linq.select(directive => directive)
    .linq.where(directive => isRemoveCommandDirective(directive))
    .linq.toArray();

  return processCodeModel(tweakModel, service);
}

async function tweakModel(model: codemodel.Model, service: Host): Promise<codemodel.Model> {

  for (const directive of directives) {
    const getParsedSelector = (selector: string | undefined): RegExp | undefined => {
      return selector ? isNotRegex(selector) ? new RegExp(`^${selector}$`, 'gi') : new RegExp(selector, 'gi') : undefined;
    }

    if (isRemoveCommandDirective(directive)) {
      const nounRegex = getParsedSelector(directive.where.noun);
      const verbRegex = getParsedSelector(directive.where.verb);
      const variantRegex = getParsedSelector(directive.where.variant);

      // select all operations
      const operations: Array<CommandOperation> = values(model.commands.operations).linq.toArray();
      let operationsToRemoveKeys = new Set<number>();
      if (nounRegex) {
        const matchingKeys = new Set(items(operations)
          .linq.where(operation => !!`${operation.value.details.csharp.noun}`.match(nounRegex))
          .linq.select(operation => operation.key)
          .linq.toArray());

        operationsToRemoveKeys = matchingKeys;
      }

      if (verbRegex) {
        const matchingKeys = new Set(items(operations)
          .linq.where(operation => !!`${operation.value.details.csharp.verb}`.match(verbRegex))
          .linq.select(operation => operation.key)
          .linq.toArray());

        operationsToRemoveKeys = operationsToRemoveKeys.size !== 0 ? new Set([...operationsToRemoveKeys].filter(key => matchingKeys.has(key))) : matchingKeys;
      }

      if (variantRegex) {
        const matchingKeys = new Set(items(operations)
          .linq.where(operation => !!`${operation.value.details.csharp.name}`.match(variantRegex))
          .linq.select(operation => operation.key)
          .linq.toArray());

        operationsToRemoveKeys = operationsToRemoveKeys.size !== 0 ? new Set([...operationsToRemoveKeys].filter(key => matchingKeys.has(key))) : matchingKeys;
      }

      for (const key of operationsToRemoveKeys) {
        const operationInfo = model.commands.operations[key].details.csharp;
        service.Message({
          Channel: Channel.Verbose, Text: `Removed command ${operationInfo.verb}-${operationInfo.name ? `${operationInfo.noun}_${operationInfo.name}` : operationInfo.noun}`
        });

        delete model.commands.operations[key];
      }
      continue;
    }
  }

  return model;
}

function isNotRegex(str: string): boolean {
  return /^[a-zA-Z0-9]+$/.test(str);
}
