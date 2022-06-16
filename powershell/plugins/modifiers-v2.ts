/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host, Channel } from '@azure-tools/autorest-extension-base';
import { pascalCase, serialize, safeEval } from '@azure-tools/codegen';
import { VirtualParameter } from '@azure-tools/codemodel';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { stat } from 'fs';
import common = require('mocha/lib/interfaces/common');
import { CommandOperation } from '../utils/command-operation';
// import { CommandOperation } from '@azure-tools/codemodel-v3/dist/code-model/command-operation';
import { ModelState } from '../utils/model-state';
import { PwshModel } from '../utils/PwshModel';
import { allVirtualParameters, allVirtualProperties } from '../utils/resolve-conflicts';
import { EnumValue, PropertyFormat } from '../utils/schema';

type State = ModelState<PwshModel>;

let directives: Array<any> = [];

interface ParameterDirective {
  name: string;
  type: string;
  required?: boolean;
  completer?: {
    name: string;
    description: string;
    script: string;
  };
  default?: {
    name: string;
    description: string;
    script: string;
  };
  description: string
}
interface WhereCommandDirective {
  select?: string;
  where: {
    'subject'?: string;
    'subject-prefix'?: string;
    'verb'?: string;
    'variant'?: string;
    'parameter-name'?: string;
  };
  set?: {
    'alias': Array<string> | string;
    'subject'?: string;
    'subject-prefix'?: string;
    'verb'?: string;
    'variant'?: string;
    'parameter-name'?: string;
    'parameter-description'?: string;
    'completer'?: {
      name: string;
      description: string;
      script: string;
    };
    'breaking-change'?: {
      // for cmdlet breaking change
      'replacement-cmdlet'?: string;
      // for cmdlet output type breaking change
      'deprecated-cmdlet-output-type'?: string;
      'replacement-cmdlet-output-type'?: string;
      'deprecated-output-properties'?: Array<string>;
      'new-output-properties'?: Array<string>;
      // for parameter breaking change
      'replacement-parameter'?: string;
      'old-parameter-type'?: string;
      'new-parameter-type'?: string;
      'become-mandatory'?: boolean;
      // for all breaking changes
      'change-description'?: string;
      'deprecated-by-version'?: string;
      'change-effective-date'?: string;
    };
    'preview-message'?: string;
    'default'?: {
      name: string;
      description: string;
      script: string;
    };
    'clientside-pagination'?: boolean;
  };
  add?: {
    parameters?: Array<ParameterDirective>
  };
  'clear-alias': boolean;
  hide?: boolean;
}
interface RemoveCommandDirective {
  select?: string;
  where: {
    'subject'?: string;
    'subject-prefix'?: string;
    'verb'?: string;
    'variant'?: string;
    'parameter-name'?: string;
  };
  remove: boolean;
}


function hasSpecialChars(str: string): boolean {
  return !/^[a-zA-Z0-9]+$/.test(str);
}

function addParameters(operations: CommandOperation[], parameters: Array<ParameterDirective>): void {
  for (const parameter of values(parameters)) {
    const vp = <any>{};
    vp.name = parameter.name;
    vp.description = parameter.description;
    if (parameter.default) {
      vp.defaultInfo = <any>{};
      vp.defaultInfo = parameter.default;
      // vp.defaultInfo.script = parameter.default.script;
      // vp.defaultInfo.name = parameter.default.name ?? "";
      // vp.defaultInfo.description = parameter.default.description ?? "";
    }
    if (parameter.completer) {
      vp.completerInfo = <any>{};
      vp.completerInfo = parameter.completer;
      // vp.completerInfo.script = parameter.completer.script;
      // vp.completerInfo.name = parameter.completer.name ?? "";
      // vp.completerInfo.description = parameter.completer.description ?? "";
    }
    vp.required = !!parameter.required;
    vp.type = parameter.type;
    for (const operation of values(operations)) {
      operation.details.csharp.virtualParameters?.operation.push(vp);
      //operation.details.csharp.virtualParameters?.operation
    }
  }
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

function isWhereCommandDirective(it: any): it is WhereCommandDirective {
  const directive = it;
  const select = directive.select;
  const where = directive.where;
  const set = directive.set;
  if (directive.remove === undefined && where && (where.verb || where.variant || where['parameter-name'] || where.subject || where['subject-prefix'] || directive.hide || select === 'command' || select === 'parameter' || directive['clear-alias'])) {
    const prohibitedFilters = ['model-name', 'property-name', 'enum-name', 'enum-value-name'];
    let error = getFilterError(where, prohibitedFilters, 'command');

    if (set !== undefined) {
      const prohibitedSetters = ['property-name', 'property-description', ' model-name', 'enum-name', 'enum-value-name'];
      error += getSetError(set, prohibitedSetters, 'command');
    }
    
    if (error) {
      throw Error(`Incorrect Directive: ${JSON.stringify(it, null, 2)}. Reason: ${error}.`);
    }

    return true;
  }

  return false;
}

function isRemoveCommandDirective(it: any): it is RemoveCommandDirective {
  const directive = <RemoveCommandDirective>it;
  const where = directive.where;
  const remove = directive.remove;
  if (where && remove && (where.subject || where.verb || where.variant || where['subject-prefix'] || where['parameter-name'] || directive.select === 'command') && directive.select !== 'parameter') {
    return true;
  }

  return false;
}


interface WhereModelDirective {
  select?: string;
  where: {
    'model-name'?: string;
    'model-fullname'?: string;
    'model-namespace'?: string;
    'property-name'?: string;
  };
  set: {
    'suppress-format'?: boolean;
    'format-table'?: {
      'properties'?: Array<string>;
      'exclude-properties'?: Array<string>;
      'labels'?: { [name: string]: string };
      'width'?: { [name: string]: number };
    };
    'model-name'?: string;
    'property-name'?: string;
    'property-description'?: string;
  };
}

function isWhereModelDirective(it: any): it is WhereModelDirective {
  const directive = it;
  const where = directive.where;
  const set = directive.set;


  if (where && set && (where['model-name'] || where['model-fullname'] || where['model-namespace'] || where['property-name'] || directive.select === 'model')) {
    const prohibitedFilters = ['enum-name', 'enum-value-name', 'subject', 'subject-prefix', 'verb', 'variant', 'parameter-name'];
    let error = getFilterError(where, prohibitedFilters, 'enum');
    const prohibitedSetters = ['enum-name', 'enum-value-name', 'subject', 'subject-prefix', 'verb', 'variant', 'parameter-name', 'parameter-description', 'completer', 'default'];
    error += getSetError(set, prohibitedSetters, 'enum');
    const modelSelectNameConflict = [];
    let modelSelectNameType = '';
    if (where['model-name']) {
      modelSelectNameType = 'model-name';
      if (where['model-fullname']) {
        modelSelectNameConflict.push('model-fullname');
      }

      if (where['model-namespace']) {
        modelSelectNameConflict.push('model-namespace');
      }
    } else if (where['model-fullname']) {
      modelSelectNameType = 'model-fullname';
      if (where['model-name']) {
        modelSelectNameConflict.push('model-name');
      }

      if (where['model-namespace']) {
        modelSelectNameConflict.push('model-namespace');
      }
    } else if (where['model-namespace']) {
      modelSelectNameType = 'model-namespace';
      if (where['model-fullname']) {
        modelSelectNameConflict.push('model-fullname');
      }

      if (where['model-name']) {
        modelSelectNameConflict.push('model-name');
      }
    }

    if (length(modelSelectNameConflict) > 0) {
      error += `Can't select ${modelSelectNameType} and ${modelSelectNameConflict} at the same time`;
    }

    if (error) {
      throw Error(`Incorrect Directive: ${JSON.stringify(it, null, 2)}.Reason: ${error}.`);
    }

    return true;

  }
  return false;
}

interface WhereEnumDirective {
  select?: string;
  where: {
    'enum-name'?: string;
    'enum-value-name'?: string;
  };
  set: {
    'enum-name'?: string;
    'enum-value-name'?: string;
  };
}

function isWhereEnumDirective(it: any): it is WhereEnumDirective {
  const directive = it;
  const where = directive.where;
  const set = directive.set;
  if (where && set && (where['enum-name'] || where['enum-value-name'] || directive.select === 'enum')) {
    const prohibitedFilters = ['model-name', 'property-name', 'subject', 'subject-prefix', 'verb', 'variant', 'parameter-name'];
    let error = getFilterError(where, prohibitedFilters, 'enum');
    const prohibitedSetters = ['model-name', 'property-name', 'subject', 'subject-prefix', 'verb', 'variant', 'parameter-name', 'parameter-description', 'completer', 'default'];
    error += getSetError(set, prohibitedSetters, 'enum');
    if (error) {
      throw Error(`Incorrect Directive: ${JSON.stringify(it, null, 2)}. Reason: ${error}.`);
    }

    return true;
  }
  return false;
}

async function tweakModel(state: State): Promise<PwshModel> {

  // only look at directives without the `transform` node.
  // dolauli for directives with transform are implemented in autorest core
  for (const directive of directives.filter(each => !each.transform)) {
    const getPatternToMatch = (selector: string | undefined): RegExp | undefined => {
      return selector ? !hasSpecialChars(selector) ? new RegExp(`^${selector}$`, 'gi') : new RegExp(selector, 'gi') : undefined;
    };

    if (isWhereCommandDirective(directive)) {
      const selectType = directive.select;
      const clearAlias = directive['clear-alias'];
      const subjectRegex = getPatternToMatch(directive.where['subject']);
      const subjectPrefixRegex = getPatternToMatch(directive.where['subject-prefix']);
      const verbRegex = getPatternToMatch(directive.where.verb);
      const variantRegex = getPatternToMatch(directive.where.variant);
      const parameterRegex = getPatternToMatch(directive.where['parameter-name']);

      const alias =
        (directive.set !== undefined) ?
          (directive.set.alias !== undefined) ?
            !Array.isArray(directive.set.alias) ?
              [directive.set.alias]
              : directive.set.alias
            : undefined
          : undefined;
      const breakingChange = (directive.set !== undefined) ? directive.set['breaking-change'] : undefined;
      const previewMessage = (directive.set !== undefined) ? directive.set['preview-message'] : undefined;
      const subjectReplacer = (directive.set !== undefined) ? directive.set['subject'] : undefined;
      const subjectPrefixReplacer = (directive.set !== undefined) ? directive.set['subject-prefix'] : undefined;
      const verbReplacer = (directive.set !== undefined) ? directive.set.verb : undefined;
      const variantReplacer = (directive.set !== undefined) ? directive.set.variant : undefined;
      const parameterReplacer = (directive.set !== undefined) ? directive.set['parameter-name'] : undefined;
      const paramDescriptionReplacer = (directive.set !== undefined) ? directive.set['parameter-description'] : undefined;
      const paramCompleterReplacer = (directive.set !== undefined) ? directive.set['completer'] : undefined;
      const paramDefaultReplacer = (directive.set !== undefined) ? directive.set['default'] : undefined;
      const cliensidePagination = (directive.set !== undefined) ? directive.set['clientside-pagination'] : undefined;

      // select all operations
      let operations: Array<CommandOperation> = values(state.model.commands.operations).toArray();
      if (subjectRegex) {
        operations = values(operations)
          .where(operation =>
            !!`${operation.details.csharp.subject}`.match(subjectRegex))
          .toArray();
      }

      if (subjectPrefixRegex) {
        operations = values(operations)
          .where(operation =>
            !!`${operation.details.csharp.subjectPrefix}`.match(subjectPrefixRegex))
          .toArray();
      }

      if (verbRegex) {
        operations = values(operations)
          .where(operation =>
            !!`${operation.details.csharp.verb}`.match(verbRegex))
          .toArray();
      }

      if (variantRegex) {
        operations = values(operations)
          .where(operation =>
            !!`${operation.details.csharp.name}`.match(variantRegex))
          .toArray();
      }

      if (parameterRegex && selectType === 'command') {
        operations = values(operations)
          .where(operation => values(allVirtualParameters(operation.details.csharp.virtualParameters))
            .any(parameter => !!`${parameter.name}`.match(parameterRegex)))
          .toArray();
      }
      if (directive.add !== undefined && directive.add.parameters !== undefined) {
        // we need to handle adding parameters before other parameter related directives, e.g. adding breaking changes
        addParameters(operations, directive.add.parameters);
      }
      if (parameterRegex && (selectType === undefined || selectType === 'parameter')) {
        const parameters = values(operations)
          .selectMany(operation => allVirtualParameters(operation.details.csharp.virtualParameters))
          .where(parameter => !!`${parameter.name}`.match(parameterRegex))
          .toArray();
        for (const p of values(parameters)) {
          const parameter = <any>p;
          const prevName = parameter.name;
          parameter.name = parameterReplacer ? parameterRegex ? parameter.name.replace(parameterRegex, parameterReplacer) : parameterReplacer : parameter.name;
          parameter.description = paramDescriptionReplacer ? paramDescriptionReplacer : parameter.description;
          parameter.completerInfo = paramCompleterReplacer ? paramCompleterReplacer : parameter.completerInfo;
          parameter.defaultInfo = paramDefaultReplacer ? paramDefaultReplacer : parameter.defaultInfo;

          // handle parameter breaking change for parameter
          if (breakingChange) {
            parameter.breakingChange = <any>{}
            parameter.breakingChange.parameterName = parameter.name
            parameter.breakingChange.replacement = (breakingChange && breakingChange['replacement-parameter']) ? breakingChange['replacement-parameter'] : undefined
            parameter.breakingChange.isBecomingMandatory = (breakingChange && breakingChange['become-mandatory']) ? breakingChange['become-mandatory'] : undefined
            parameter.breakingChange.oldParamaterType = (breakingChange && breakingChange['old-parameter-type']) ? breakingChange['old-parameter-type'] : undefined
            parameter.breakingChange.newParameterType = (breakingChange && breakingChange['new-parameter-type']) ? breakingChange['new-parameter-type'] : undefined
            parameter.breakingChange.deprecateByVersion = (breakingChange && breakingChange['deprecated-by-version']) ? breakingChange['deprecated-by-version'] : undefined
            parameter.breakingChange.changeInEfectByDate = (breakingChange && breakingChange['change-effective-date']) ? breakingChange['change-effective-date'] : undefined
            parameter.breakingChange.changeDescription = (breakingChange && breakingChange['change-description']) ? breakingChange['change-description'] : undefined
          }
          // handle preview message for parameter
          parameter.previewMessage = previewMessage ? previewMessage : undefined
          if (clearAlias) {
            parameter.alias = [];
            state.message({
              Channel: Channel.Debug, Text: `[DIRECTIVE] Cleared aliases from parameter ${parameter.name}.`
            });
          }

          // handle hiding parameters
          if (directive.hide) {
            if (p.required && !paramDefaultReplacer) {
              throw new Error(
                `Please add a default value when hiding the mandatory parameter ${p.name}.
See https://github.com/Azure/autorest.powershell/blob/main/docs/directives.md#default-values`
              );
            }
            p.hidden = true;
            state.message({
              Channel: Channel.Debug,
              Text: `[DIRECTIVE] Hide parameter ${p.name}.`,
            });
          }

          if (alias) {
            const parsedAlias = new Array<string>();
            for (const each of values(alias)) {
              parsedAlias.push(hasSpecialChars(each) ? prevName.replace(parameterRegex, each) : each);
            }

            parameter.alias = [...new Set(values(parameter.alias, parsedAlias).toArray())];
            state.message({
              Channel: Channel.Debug, Text: `[DIRECTIVE] Added alias ${parsedAlias} to parameter ${parameter.name}.`
            });
          }

          if (parameterReplacer) {
            state.message({
              Channel: Channel.Debug, Text: `[DIRECTIVE] Changed parameter-name from ${prevName} to ${parameter.name}.`
            });
          }

          if (paramDescriptionReplacer) {
            state.message({
              Channel: Channel.Debug, Text: `[DIRECTIVE] Set parameter-description from parameter ${parameter.name}.`
            });
          }
        }

      } else if (operations) {
        for (const operation of values(operations)) {
          const getCmdletName = (verb: string, subjectPrefix: string, subject: string, variantName: string): string => {
            return `${verb}-${subjectPrefix}${subject}${variantName ? `_${variantName}` : ''}`;
          };

          const prevSubject = operation.details.csharp.subject;
          const prevSubjectPrefix = operation.details.csharp.subjectPrefix;
          const prevVerb = operation.details.csharp.verb;
          const prevVariantName = operation.details.csharp.name;
          const oldCommandName = getCmdletName(prevVerb, prevSubjectPrefix, prevSubject, prevVariantName);

          // set values
          operation.details.csharp.subject = subjectReplacer ? subjectRegex ? prevSubject.replace(subjectRegex, subjectReplacer) : subjectReplacer : prevSubject;
          operation.details.csharp.subjectPrefix = subjectPrefixReplacer !== undefined ? subjectPrefixRegex ? prevSubjectPrefix.replace(subjectPrefixRegex, subjectPrefixReplacer) : subjectPrefixReplacer : prevSubjectPrefix;
          operation.details.csharp.verb = verbReplacer ? verbRegex ? prevVerb.replace(verbRegex, verbReplacer) : verbReplacer : prevVerb;
          operation.details.csharp.name = variantReplacer ? variantRegex ? prevVariantName.replace(variantRegex, variantReplacer) : variantReplacer : prevVariantName;
          operation.details.csharp.hidden = (directive.hide !== undefined) ? !!directive.hide : operation.details.csharp.hidden;

          const newSubject = operation.details.csharp.subject;
          const newSubjectPrefix = operation.details.csharp.subjectPrefix;
          const newVerb = operation.details.csharp.verb;
          const newVariantName = operation.details.csharp.name;
          const newCommandName = getCmdletName(newVerb, newSubjectPrefix, newSubject, newVariantName);

          if (cliensidePagination) {
            operation.details.csharp.clientsidePagination = cliensidePagination;
          }
          if (breakingChange) {
            operation.details.csharp.breakingChange = operation.details.csharp.breakingChange ? operation.details.csharp.breakingChange : <any>{}
            if (variantRegex) {
              // handle parameter breaking change for variant
              operation.details.csharp.breakingChange.variant = <any>{}
              operation.details.csharp.breakingChange.variant.deprecateByVersion = (breakingChange && breakingChange['deprecated-by-version']) ? breakingChange['deprecated-by-version'] : undefined;
              operation.details.csharp.breakingChange.variant.changeInEfectByDate = (breakingChange && breakingChange['change-effective-date']) ? breakingChange['change-effective-date'] : undefined;
              operation.details.csharp.breakingChange.variant.changeDescription = (breakingChange && breakingChange['change-description']) ? breakingChange['change-description'] : undefined;

              operation.details.csharp.breakingChange.variant.name = newVariantName

            } else {
              //handle breaking change for output type
              if (breakingChange['new-output-properties']) {
                operation.details.csharp.breakingChange.output = <any>{}
                operation.details.csharp.breakingChange.output.deprecatedCmdLetOutputType = breakingChange['deprecated-cmdlet-output-type'];
                operation.details.csharp.breakingChange.output.replacement = (breakingChange && breakingChange['replacement-cmdlet-output-type']) ? breakingChange['replacement-cmdlet-output-type'] : undefined;
                operation.details.csharp.breakingChange.output.deprecatedOutputProperties = (breakingChange && breakingChange['deprecated-output-properties']) ? breakingChange['deprecated-output-properties'] : undefined;
                operation.details.csharp.breakingChange.output.newOutputProperties = (breakingChange && breakingChange['new-output-properties']) ? breakingChange['new-output-properties'] : undefined;
                operation.details.csharp.breakingChange.output.deprecateByVersion = (breakingChange && breakingChange['deprecated-by-version']) ? breakingChange['deprecated-by-version'] : undefined;
                operation.details.csharp.breakingChange.output.changeInEfectByDate = (breakingChange && breakingChange['change-effective-date']) ? breakingChange['change-effective-date'] : undefined;
                operation.details.csharp.breakingChange.output.changeDescription = (breakingChange && breakingChange['change-description']) ? breakingChange['change-description'] : undefined;
              } else {
                // handle parameter breaking change for cmdlet
                operation.details.csharp.breakingChange.cmdlet = <any>{}
                operation.details.csharp.breakingChange.cmdlet.replacement = (breakingChange && breakingChange['replacement-cmdlet']) ? breakingChange['replacement-cmdlet'] : undefined
                if (operation.details.csharp.breakingChange.cmdlet.replacement && operation.details.csharp.breakingChange.cmdlet.replacement.startsWith("$.")) {
                  operation.details.csharp.breakingChange.cmdlet.replacement = safeEval(operation.details.csharp.breakingChange.cmdlet.replacement.replace("$", `"${newCommandName.split('_')[0]}"`))
                }
                operation.details.csharp.breakingChange.cmdlet.deprecateByVersion = (breakingChange && breakingChange['deprecated-by-version']) ? breakingChange['deprecated-by-version'] : undefined
                operation.details.csharp.breakingChange.cmdlet.changeInEfectByDate = (breakingChange && breakingChange['change-effective-date']) ? breakingChange['change-effective-date'] : undefined
                operation.details.csharp.breakingChange.cmdlet.changeDescription = (breakingChange && breakingChange['change-description']) ? breakingChange['change-description'] : undefined
                operation.details.csharp.breakingChange.cmdlet.name = newCommandName.split('_')[0];
              }
            }

          }
          // handle preview message for cmdlet
          operation.details.csharp.previewMessage = previewMessage ? previewMessage : undefined

          // just the subject prefix can be an empty string
          if (subjectPrefixReplacer !== undefined || subjectReplacer || verbReplacer || variantReplacer) {
            const modificationMessage = `[DIRECTIVE] Changed command from ${oldCommandName} to ${newCommandName}. `;
            state.message({
              Channel: Channel.Debug, Text: modificationMessage
            });
          }

          if (clearAlias) {
            operation.details.csharp.alias = [];
            state.message({
              Channel: Channel.Debug, Text: `[DIRECTIVE] Cleared aliases from command ${newCommandName}.`
            });
          }

          if (alias) {
            const getParsedAlias = (rawAlias: string) => {
              return rawAlias.replace('${verb}', operation.details.csharp.verb)
                .replace('${subject-prefix}', operation.details.csharp.subjectPrefix)
                .replace('${subject}', operation.details.csharp.subject)
                .replace('${variant}', operation.details.csharp.name);
            };

            const parsedAlias = new Array<string>();
            for (const each of values(alias)) {
              parsedAlias.push(getParsedAlias(each));
            }

            operation.details.csharp.alias = [...new Set(values(operation.details.csharp.alias, parsedAlias).toArray())];
            state.message({
              Channel: Channel.Debug, Text: `[DIRECTIVE] Added alias ${parsedAlias} to command ${newCommandName}.`
            });
          }
        }
      }

      continue;
    }

    if (isWhereModelDirective(directive)) {
      const selectType = directive.select;
      const modelNameRegex = getPatternToMatch(directive.where['model-name']);
      const modelFullNameRegex = getPatternToMatch(directive.where['model-fullname']);
      const modelNamespaceRegex = getPatternToMatch(directive.where['model-namespace']);
      const propertyNameRegex = getPatternToMatch(directive.where['property-name']);

      const modelNameReplacer = directive.set['model-name'];
      const propertyNameReplacer = directive.set['property-name'];
      const propertyDescriptionReplacer = directive.set['property-description'];
      const formatTable = directive.set['format-table'];
      const suppressFormat = directive.set['suppress-format'];

      // select all models
      let models = [...state.model.schemas.objects ?? []];
      // let models = values(state.model.schemas).toArray();
      if (modelNameRegex) {
        models = values(models)
          .where(model =>
            !!`${model.language.csharp?.name}`.match(modelNameRegex))
          .toArray();
      }

      if (modelFullNameRegex) {
        models = values(models)
          .where(model =>
            !!`${model.language.csharp?.fullname}`.match(modelFullNameRegex))
          .toArray();
      }

      if (modelNamespaceRegex) {
        models = values(models)
          .where(model =>
            !!`${model.language.csharp?.namespace}`.match(modelNamespaceRegex))
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
          property.description = propertyDescriptionReplacer ? propertyDescriptionReplacer : property.description;

          if (!property.name) {
            state.message({ Channel: Channel.Error, Text: `Directive '${directive.where['model-name'] || directive.where['model-fullname']}/${directive.where['property-name']}' attempted to change '${prevName}' to '' ` });
          }
          if (propertyNameRegex) {
            state.message({
              Channel: Channel.Debug, Text: `[DIRECTIVE] Changed property-name from ${prevName} to ${property.name}.`
            });
          }
        }

      } else if (models) {
        for (const model of values(models)) {

          if (suppressFormat && model.language.csharp) {
            model.language.csharp.suppressFormat = true;
          }

          if (formatTable !== undefined && !suppressFormat) {
            var resourceGroupFormat: PropertyFormat = {};
            var ResourceGroupNameInclude = false;
            const resourceGroupName = 'resourcegroupname';
            const properties = allVirtualProperties(model.language.csharp?.virtualProperties);
            const propertiesToExclude = formatTable['exclude-properties'];
            const propertiesToInclude = formatTable.properties;
            const labels = formatTable.labels;
            const widths = formatTable.width;

            for (const property of values(properties)) {
              if (property.name.toLowerCase() == resourceGroupName) {
                ResourceGroupNameInclude = true;
              }
            }

            if (labels) {
              const parsedLabels = new Dictionary<string>();
              for (const label of items(labels)) {
                parsedLabels[label.key.toLowerCase()] = label.value;
              }

              for (const property of values(properties)) {
                if (Object.keys(parsedLabels).includes(property.name.toLowerCase())) {
                  if (property.format === undefined) {
                    property.format = {};
                  }

                  property.format.label = parsedLabels[property.name.toLowerCase()];
                }
              }

              if (!ResourceGroupNameInclude) {
                resourceGroupFormat.label = parsedLabels[resourceGroupName];
              }
            }

            if (widths) {
              const parsedWidths = new Dictionary<number>();
              for (const w of items(widths)) {
                parsedWidths[w.key.toLowerCase()] = w.value;
              }

              for (const property of values(properties)) {
                if (Object.keys(parsedWidths).includes(property.name.toLowerCase())) {
                  if (property.format === undefined) {
                    property.format = {};
                  }

                  property.format.width = parsedWidths[property.name.toLowerCase()];
                }
              }

              if (!ResourceGroupNameInclude) {
                resourceGroupFormat.width = parsedWidths[resourceGroupName];
              }
            }

            if (propertiesToInclude) {
              const indexes = new Dictionary<number>();
              for (const item of items(propertiesToInclude)) {
                indexes[item.value.toLowerCase()] = item.key;
              }
              var ResourceGroupNameInclude = false;
              for (const property of values(properties)) {
                if (property.name.toLowerCase() == 'resourcegroupname') {
                  ResourceGroupNameInclude = true;
                }
                if (propertiesToInclude.map(x => x.toLowerCase()).includes(property.name.toLowerCase())) {
                  if (property.format === undefined) {
                    property.format = {};
                  }

                  property.format.index = indexes[property.name.toLowerCase()];
                } else {
                  property.format = { suppressFormat: true };
                }
              }

              if (!ResourceGroupNameInclude) {
                resourceGroupFormat.index = indexes[resourceGroupName];
                if (indexes[resourceGroupName] == undefined) {
                  resourceGroupFormat.suppressFormat = true;
                }
              }

            }

            if (propertiesToExclude) {
              for (const property of values(properties)) {
                if (propertiesToExclude.map(x => x.toLowerCase()).includes(property.name.toLowerCase())) {
                  property.format = { suppressFormat: true };
                }
              }

              if (!ResourceGroupNameInclude && propertiesToExclude.map(x => x.toLowerCase()).includes(resourceGroupName)) {
                resourceGroupFormat.suppressFormat = true;
              }
            }

            if (!ResourceGroupNameInclude && await state.getValue("azure", false)) {
              // Keep the format info for ResourceGroupName and we will need it later if resourcegroup-append is set
              var formats = await state.getValue<Dictionary<PropertyFormat>>("formats", {});
              formats[`${model.language.csharp?.name}`] = resourceGroupFormat;
              await state.setValue("formats", formats);
            }
          }

          const prevName = model.language.csharp?.name;
          if (model.language.csharp) {
            model.language.csharp.name = modelNameReplacer ? modelNameRegex ? model.language.csharp.name.replace(modelNameRegex, modelNameReplacer) : modelNameReplacer : model.language.csharp.name;
          }
          state.message({
            Channel: Channel.Debug, Text: `[DIRECTIVE] Changed model-name from ${prevName} to ${model.language.csharp?.name}.`
          });
        }
      }

      continue;
    }

    if (isWhereEnumDirective(directive)) {
      const enumNameRegex = getPatternToMatch(directive.where['enum-name']);
      const enumValueNameRegex = getPatternToMatch(directive.where['enum-value-name']);

      const enumNameReplacer = directive.set['enum-name'];
      const enumValueNameReplacer = directive.set['enum-value-name'];

      let enums = [...state.model.schemas.sealedChoices ?? [], ...state.model.schemas.choices ?? []];
      // let enums = values(state.model.schemas)
      //   .where(each => each.details.csharp.enum !== undefined)
      //   .toArray();

      if (enumNameRegex) {
        enums = values(enums)
          .where(each => !!`${each.language.csharp?.name}`.match(enumNameRegex))
          .toArray();
      }

      if (enumValueNameRegex) {
        const enumsValues = values(enums)
          .selectMany(each => each.language.csharp?.enum ? each.language.csharp.enum.values : [])
          .where(each => !!`${(<EnumValue>each).name}`.match(enumValueNameRegex))
          .toArray();
        for (const enumValue of values(enumsValues)) {
          const prevName = (<EnumValue>enumValue).name;
          (<EnumValue>enumValue).name = enumValueNameReplacer ? enumNameRegex ? (<EnumValue>enumValue).name.replace(enumValueNameRegex, enumValueNameReplacer) : enumValueNameReplacer : prevName;
          if (enumValueNameRegex) {
            const enumNames = values(enums)
              .select(each => each.language.csharp?.name)
              .toArray();
            state.message({
              Channel: Channel.Debug, Text: `[DIRECTIVE] Changed enum-value-name from ${prevName} to ${(<EnumValue>enumValue).name}. Enum: ${JSON.stringify(enumNames, null, 2)}`
            });
          }
        }
      } else {
        for (const each of values(enums)) {
          const prevName = each.language.csharp?.name ?? '';
          if (each.language.csharp) {
            each.language.csharp.name = enumNameReplacer ? enumNameRegex ? each.language.csharp.name.replace(enumNameRegex, enumNameReplacer) : enumNameReplacer : prevName;
            state.message({
              Channel: Channel.Debug, Text: `[DIRECTIVE] Changed enum-name from ${prevName} to ${each.language.csharp?.name}.`
            });
          }
        }
      }

      continue;
    }


    if (isRemoveCommandDirective(directive)) {
      const selectType = directive.select;
      const subjectRegex = getPatternToMatch(directive.where.subject);
      const subjectPrefixRegex = getPatternToMatch(directive.where['subject-prefix']);
      const verbRegex = getPatternToMatch(directive.where.verb);
      const variantRegex = getPatternToMatch(directive.where.variant);
      const parameterRegex = getPatternToMatch(directive.where['parameter-name']);

      if (subjectRegex || subjectPrefixRegex || verbRegex || variantRegex || (parameterRegex && selectType === 'command')) {
        // select all operations first then reduce by finding the intersection with selectors
        let operationsToRemoveKeys = new Set(items(state.model.commands.operations)
          .select(operation => operation.key)
          .toArray());

        if (subjectRegex) {
          operationsToRemoveKeys = new Set(items(state.model.commands.operations)
            .where(operation => !!`${operation.value.details.csharp.subject}`.match(subjectRegex) && operationsToRemoveKeys.has(operation.key))
            .select(operation => operation.key)
            .toArray());
        }

        if (subjectPrefixRegex && operationsToRemoveKeys.size > 0) {
          operationsToRemoveKeys = new Set(items(state.model.commands.operations)
            .where(operation => !!`${operation.value.details.csharp.subjectPrefix}`.match(subjectPrefixRegex) && operationsToRemoveKeys.has(operation.key))
            .select(operation => operation.key)
            .toArray());
        }

        if (verbRegex && operationsToRemoveKeys.size > 0) {
          operationsToRemoveKeys = new Set(items(state.model.commands.operations)
            .where(operation => !!`${operation.value.details.csharp.verb}`.match(verbRegex) && operationsToRemoveKeys.has(operation.key))
            .select(operation => operation.key)
            .toArray());
        }

        if (variantRegex && operationsToRemoveKeys.size > 0) {
          operationsToRemoveKeys = new Set(items(state.model.commands.operations)
            .where(operation => !!`${operation.value.details.csharp.name}`.match(variantRegex) && operationsToRemoveKeys.has(operation.key))
            .select(operation => operation.key)
            .toArray());
        }

        if (parameterRegex && selectType === 'command' && operationsToRemoveKeys.size > 0) {
          operationsToRemoveKeys = new Set(items(state.model.commands.operations)
            .where(operation => values(allVirtualParameters(operation.value.details.csharp.virtualParameters))
              .any(parameter => !!`${parameter.name}`.match(parameterRegex)))
            .where(operation => operationsToRemoveKeys.has(operation.key))
            .select(operation => operation.key)
            .toArray());
        }

        for (const key of values(operationsToRemoveKeys)) {
          const operationInfo = state.model.commands.operations[key].details.csharp;
          state.message({
            Channel: Channel.Debug, Text: `[DIRECTIVE] Removed command ${operationInfo.verb}-${operationInfo.subjectPrefix}${operationInfo.subject}${operationInfo.name ? `_${operationInfo.name}` : ''}`
          });

          delete state.model.commands.operations[key];
        }
      }

      continue;
    }
  }

  const operationIdentities = new Set<string>();
  for (const operation of values(state.model.commands.operations)) {
    const details = operation.details.csharp;

    let fname = `${details.verb} -${details.subject} -${details.name} `;
    let n = 1;

    while (operationIdentities.has(fname)) {
      details.name = pascalCase(`${details.name.replace(/\d*$/g, '')} ${n++}`);
      fname = pascalCase(`${details.verb} -${details.subject} -${details.name}`);
    }
    operationIdentities.add(fname);
  }

  return state.model;
}

export async function applyModifiersV2(service: Host) {
  // dolauli implement directives
  const allDirectives = await service.GetValue('directive');
  directives = values(allDirectives)
    // .select(directive => directive)
    .where(directive => isWhereCommandDirective(directive) || isWhereModelDirective(directive) || isWhereEnumDirective(directive) || isRemoveCommandDirective(directive))
    .toArray();

  const state = await new ModelState<PwshModel>(service).init();
  const result = await tweakModel(state);

  await service.WriteFile('code-model-v4-modifiers-v2.yaml', serialize(result), undefined, 'code-model-v4');
}
