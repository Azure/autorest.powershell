/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutorestExtensionHost as Host, Channel } from '@autorest/extension-base';
import { pascalCase, serialize, safeEval } from '@azure-tools/codegen';
import { VirtualParameter } from '@autorest/codemodel';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { stat } from 'fs';
import common = require('mocha/lib/interfaces/common');
import { CommandOperation, isWritableCmdlet } from '../utils/command-operation';
import { ModelState } from '../utils/model-state';
import { SdkModel } from '../utils/SdkModel';
import { allVirtualParameters, allVirtualProperties } from '../utils/resolve-conflicts';
import { EnumValue, PropertyFormat } from '../utils/schema';

type State = ModelState<SdkModel>;

let directives: Array<any> = [];


function hasSpecialChars(str: string): boolean {
  return !/^[a-zA-Z0-9]+$/.test(str);
}

function getFilterError(whereObject: any, prohibitedFilters: Array<string>, selectionType: string): string {
  let error = '';
  for (const each of values(prohibitedFilters)) {
    if (whereObject[each] !== undefined) {
      error += `Can't filter by ${each} when selecting command. `;
    }
  }

  return error;
}

function getSetError(setObject: any, prohibitedSetters: Array<string>, selectionType: string): string {
  let error = '';
  for (const each of values(prohibitedSetters)) {
    if (setObject[each] !== undefined) {
      error += `Can't set ${each} when a ${selectionType} is selected. `;
    }
  }

  return error;
}

interface WhereModelDirective {
  select?: string;
  where: {
    'model-name'?: string;
    'property-name'?: string;
  };
  set: {
    'model-name'?: string;
    'property-name'?: string;
  };
}

function isWhereModelDirective(it: any): it is WhereModelDirective {
  const directive = it;
  const where = directive.where;
  const set = directive.set;


  if (where && set && (where['model-name'] || where['property-name'] || directive.select === 'model')) {

    return true;

  }
  return false;
}

async function tweakModel(state: State): Promise<SdkModel> {
  // only look at directives without the `transform` node.
  for (const directive of directives.filter(each => !each.transform)) {
    const getPatternToMatch = (selector: string | undefined): RegExp | undefined => {
      return selector ? !hasSpecialChars(selector) ? new RegExp(`^${selector}$`, 'gi') : new RegExp(selector, 'gi') : undefined;
    };

    if (isWhereModelDirective(directive)) {
      const selectType = directive.select;
      const modelNameRegex = getPatternToMatch(directive.where['model-name']);
      const propertyNameRegex = getPatternToMatch(directive.where['property-name']);

      const modelNameReplacer = directive.set['model-name'];
      const propertyNameReplacer = directive.set['property-name'];

      // select all models
      let models = [...state.model.schemas.objects ?? []];
      // let models = values(state.model.schemas).toArray();
      if (modelNameRegex) {
        models = values(models)
          .where(model =>
            !!`${model.language.csharp?.name}`.match(modelNameRegex))
          .toArray();
      }

      if (propertyNameRegex && selectType === 'model') {
        models = values(models)
          .where(model => values(allVirtualProperties(model.language.csharp?.virtualProperties))
            .any(property => !!`${property.name}`.match(propertyNameRegex)))
          .toArray();
      }

      if (propertyNameRegex && (selectType === undefined || selectType === 'property')) {
        const properties = values(models)
          .selectMany(model => allVirtualProperties(model.language.csharp?.virtualProperties))
          .where(property => !!`${property.name}`.match(propertyNameRegex))
          .toArray();
        for (const property of values(properties)) {
          const prevName = property.name;
          property.name = propertyNameReplacer ? propertyNameRegex ? property.name.replace(propertyNameRegex, propertyNameReplacer) : propertyNameReplacer : property.name;

          if (!property.name) {
            state.message({ Channel: Channel.Error, Text: `Directive '${directive.where['model-name']}/${directive.where['property-name']}' attempted to change '${prevName}' to '' ` });
          }
          if (propertyNameRegex) {
            state.message({
              Channel: Channel.Debug, Text: `[DIRECTIVE] Changed property-name from ${prevName} to ${property.name}.`
            });
          }
        }

      } else if (models) {
        for (const model of values(models)) {
          const prevName = model.language.csharp?.name;
          if (model.language.csharp) {
            model.language.default.fullname = model.language.csharp.fullname = model.language.default.name = model.language.csharp.name = modelNameReplacer ? modelNameRegex ? model.language.csharp.name.replace(modelNameRegex, modelNameReplacer) : modelNameReplacer : model.language.csharp.name;
          }
          state.message({
            Channel: Channel.Debug, Text: `[DIRECTIVE] Changed model-name from ${prevName} to ${model.language.csharp?.name}.`
          });
        }
      }

      continue;
    }
  }

  return state.model;
}

export async function applyModifiersSdk(service: Host) {
  // dolauli implement directives
  const allDirectives = await service.getValue<any>('directive');
  directives = values(allDirectives)
    // .select(directive => directive)
    .where(directive => isWhereModelDirective(directive))
    .toArray();

  const state = await new ModelState<SdkModel>(service).init();
  const result = await tweakModel(state);

  await service.writeFile({ filename: 'code-model-v4-modifiers-sdk.yaml', content: serialize(result), sourceMap: undefined, artifactType: 'code-model-sdk' });
}
