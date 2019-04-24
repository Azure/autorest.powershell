/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, processCodeModel, ModelState, allVirtualParameters } from '@microsoft.azure/autorest.codemodel-v3';
import { values, items } from '@microsoft.azure/codegen';
import { Host, Channel } from '@microsoft.azure/autorest-extension-base';
import { CommandOperation } from '@microsoft.azure/autorest.codemodel-v3/dist/code-model/command-operation';
type State = ModelState<codemodel.Model>;


interface RemoveCommandDirective {
  select?: string;
  where: {
    'subject'?: string;
    'subject-prefix'?: string;
    'verb'?: string;
    'variant'?: string;
    'parameter-name'?: string;
  };
  remove: Boolean;
}

let directives: Array<any> = [];

function isRemoveCommandDirective(it: any): it is RemoveCommandDirective {
  const directive = <RemoveCommandDirective>it;
  const where = directive.where;
  const remove = directive.remove;
  if (where && remove && (where.subject || where.verb || where.variant || where["subject-prefix"] || where["parameter-name"])) {
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

async function tweakModel(state: State): Promise<codemodel.Model> {

  for (const directive of directives) {
    const getPatternToMatch = (selector: string | undefined): RegExp | undefined => {
      return selector ? isNotRegex(selector) ? new RegExp(`^${selector}$`, 'gi') : new RegExp(selector, 'gi') : undefined;
    }

    if (isRemoveCommandDirective(directive)) {
      const selectType = directive.select;
      const subjectRegex = getPatternToMatch(directive.where.subject);
      const subjectPrefixRegex = getPatternToMatch(directive.where["subject-prefix"]);
      const verbRegex = getPatternToMatch(directive.where.verb);
      const variantRegex = getPatternToMatch(directive.where.variant);
      const parameterRegex = getPatternToMatch(directive.where["parameter-name"]);

      // select all operations
      const operations: Array<CommandOperation> = values(state.model.commands.operations).linq.toArray();
      let operationsToRemoveKeys = new Set<number>();
      if (subjectRegex) {
        const matchingKeys = new Set(items(operations).linq.where(operation => !!`${operation.value.details.default.subject}`.match(subjectRegex))
          .linq.select(operation => operation.key)
          .linq.toArray());

        operationsToRemoveKeys = matchingKeys;
      }

      if (subjectPrefixRegex) {
        const matchingKeys = new Set(items(operations).linq.where(operation => !!`${operation.value.details.default.subjectPrefix}`.match(subjectPrefixRegex))
          .linq.select(operation => operation.key)
          .linq.toArray());

        operationsToRemoveKeys = operationsToRemoveKeys.size !== 0 ? new Set([...operationsToRemoveKeys].filter(key => matchingKeys.has(key))) : matchingKeys;
      }

      if (verbRegex) {
        const matchingKeys = new Set(items(operations)
          .linq.where(operation => !!`${operation.value.details.default.verb}`.match(verbRegex))
          .linq.select(operation => operation.key)
          .linq.toArray());

        operationsToRemoveKeys = operationsToRemoveKeys.size !== 0 ? new Set([...operationsToRemoveKeys].filter(key => matchingKeys.has(key))) : matchingKeys;
      }

      if (variantRegex) {
        const matchingKeys = new Set(items(operations)
          .linq.where(operation => !!`${operation.value.details.default.name}`.match(variantRegex))
          .linq.select(operation => operation.key)
          .linq.toArray());

        operationsToRemoveKeys = operationsToRemoveKeys.size !== 0 ? new Set([...operationsToRemoveKeys].filter(key => matchingKeys.has(key))) : matchingKeys;
      }

      if (parameterRegex && selectType === 'command') {
        const matchingKeys = new Set(items(operations)
          .linq.where(operation => values(allVirtualParameters(operation.value.details.csharp.virtualParameters))
            .linq.any(parameter => !!`${parameter.name}`.match(parameterRegex)))
          .linq.select(operation => operation.key)
          .linq.toArray());

        operationsToRemoveKeys = operationsToRemoveKeys.size !== 0 ? new Set([...operationsToRemoveKeys].filter(key => matchingKeys.has(key))) : matchingKeys;
      }

      for (const key of operationsToRemoveKeys) {
        const operationInfo = state.model.commands.operations[key].details.default;
        state.message({
          Channel: Channel.Verbose, Text: `[DIRECTIVE] Removed command ${operationInfo.verb}-${operationInfo.subjectPrefix}${operationInfo.subject}${operationInfo.name ? `_${operationInfo.name}` : ``}`
        });

        delete state.model.commands.operations[key];
      }
      continue;
    }
  }

  return state.model;
}

function isNotRegex(str: string): boolean {
  return /^[a-zA-Z0-9]+$/.test(str);
}
