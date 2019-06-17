/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, processCodeModel, allVirtualParameters, allVirtualProperties, ModelState, command } from '@microsoft.azure/autorest.codemodel-v3';
import { Host, Channel } from '@microsoft.azure/autorest-extension-base';
import { values, items, Dictionary, pascalCase } from '@microsoft.azure/codegen';
import { CommandOperation } from '@microsoft.azure/autorest.codemodel-v3/dist/code-model/command-operation';

type State = ModelState<codemodel.Model>;

let directives: Array<any> = [];

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
  remove: Boolean;
}

function isWhereCommandDirective(it: any): it is WhereCommandDirective {
  const directive = it;
  const select = directive.select;
  const where = directive.where;
  const set = directive.set;
  if (directive.remove === undefined && where && (where.verb || where.variant || where["parameter-name"] || where.subject || where['subject-prefix'] || directive.hide || select === 'command' || select === 'parameter' || directive['clear-alias'])) {
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
  if (where && remove && (where.subject || where.verb || where.variant || where["subject-prefix"] || where["parameter-name"] || directive.select === 'command') && directive.select !== 'parameter') {
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
    const prohibitedSetters = ['enum-name', 'enum-value-name', 'subject', 'subject-prefix', 'verb', 'variant', 'parameter-name', 'parameter-description'];
    error += getSetError(set, prohibitedSetters, 'enum');
    let modelSelectNameConflict = [];
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

    if (modelSelectNameConflict.length > 0) {
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
    const prohibitedSetters = ['model-name', 'property-name', 'subject', 'subject-prefix', 'verb', 'variant', 'parameter-name', 'parameter-description'];
    error += getSetError(set, prohibitedSetters, 'enum');
    if (error) {
      throw Error(`Incorrect Directive: ${JSON.stringify(it, null, 2)}. Reason: ${error}.`);
    }

    return true;
  }
  return false;
}

function getFilterError(whereObject: any, prohibitedFilters: Array<string>, selectionType: string): string {
  let error = '';
  for (const each of prohibitedFilters) {
    if (whereObject[each] !== undefined) {
      error += `Can't filter by ${each} when selecting command. `
    }
  }

  return error;
}

function getSetError(setObject: any, prohibitedSetters: Array<string>, selectionType: string): string {
  let error = '';
  for (const each of prohibitedSetters) {
    if (setObject[each] !== undefined) {
      error += `Can't set ${each} when a ${selectionType} is selected. `
    }
  }

  return error;
}

export async function applyModifiers(service: Host) {
  const allDirectives = await service.GetValue('directive');
  directives = values(allDirectives)
    .linq.select(directive => directive)
    .linq.where(directive => isWhereCommandDirective(directive) || isWhereModelDirective(directive) || isWhereEnumDirective(directive) || isRemoveCommandDirective(directive))
    .linq.toArray();

  return processCodeModel(tweakModel, service, 'modifiers');
}

async function tweakModel(state: State): Promise<codemodel.Model> {

  for (const directive of directives) {
    const getPatternToMatch = (selector: string | undefined): RegExp | undefined => {
      return selector ? !hasSpecialChars(selector) ? new RegExp(`^${selector}$`, 'gi') : new RegExp(selector, 'gi') : undefined;
    }

    if (isWhereCommandDirective(directive)) {
      const selectType = directive.select;
      const clearAlias = directive["clear-alias"];
      const subjectRegex = getPatternToMatch(directive.where['subject']);
      const subjectPrefixRegex = getPatternToMatch(directive.where['subject-prefix']);
      const verbRegex = getPatternToMatch(directive.where.verb);
      const variantRegex = getPatternToMatch(directive.where.variant);
      const parameterRegex = getPatternToMatch(directive.where["parameter-name"]);

      const alias =
        (directive.set !== undefined) ?
          (directive.set.alias !== undefined) ?
            !Array.isArray(directive.set.alias) ?
              [directive.set.alias]
              : directive.set.alias
            : undefined
          : undefined;
      const subjectReplacer = (directive.set !== undefined) ? directive.set['subject'] : undefined;
      const subjectPrefixReplacer = (directive.set !== undefined) ? directive.set["subject-prefix"] : undefined;
      const verbReplacer = (directive.set !== undefined) ? directive.set.verb : undefined;
      const variantReplacer = (directive.set !== undefined) ? directive.set.variant : undefined;;
      const parameterReplacer = (directive.set !== undefined) ? directive.set["parameter-name"] : undefined;;
      const paramDescriptionReplacer = (directive.set !== undefined) ? directive.set["parameter-description"] : undefined;;

      // select all operations
      let operations: Array<CommandOperation> = values(state.model.commands.operations).linq.toArray();
      if (subjectRegex) {
        operations = values(operations)
          .linq.where(operation =>
            !!`${operation.details.csharp.subject}`.match(subjectRegex))
          .linq.toArray();
      }

      if (subjectPrefixRegex) {
        operations = values(operations)
          .linq.where(operation =>
            !!`${operation.details.csharp.subjectPrefix}`.match(subjectPrefixRegex))
          .linq.toArray();
      }

      if (verbRegex) {
        operations = values(operations)
          .linq.where(operation =>
            !!`${operation.details.csharp.verb}`.match(verbRegex))
          .linq.toArray();
      }

      if (variantRegex) {
        operations = values(operations)
          .linq.where(operation =>
            !!`${operation.details.csharp.name}`.match(variantRegex))
          .linq.toArray();
      }

      if (parameterRegex && selectType === 'command') {
        operations = values(operations)
          .linq.where(operation => values(allVirtualParameters(operation.details.csharp.virtualParameters))
            .linq.any(parameter => !!`${parameter.name}`.match(parameterRegex)))
          .linq.toArray();
      }

      if (parameterRegex && (selectType === undefined || selectType === 'parameter')) {
        const parameters = values(operations)
          .linq.selectMany(operation => allVirtualParameters(operation.details.csharp.virtualParameters))
          .linq.where(parameter => !!`${parameter.name}`.match(parameterRegex))
          .linq.toArray();
        for (const parameter of parameters) {
          const prevName = parameter.name;
          parameter.name = parameterReplacer ? parameterRegex ? parameter.name.replace(parameterRegex, parameterReplacer) : parameterReplacer : parameter.name;
          parameter.description = paramDescriptionReplacer ? paramDescriptionReplacer : parameter.description;
          if (clearAlias) {
            parameter.alias = [];
            state.message({
              Channel: Channel.Verbose, Text: `[DIRECTIVE] Cleared aliases from parameter ${parameter.name}.`
            });
          }

          if (alias) {
            const parsedAlias = new Array<string>();
            for (const each of alias) {
              parsedAlias.push(hasSpecialChars(each) ? prevName.replace(parameterRegex, each) : each);
            }

            parameter.alias = [...new Set([...parameter.alias, ...parsedAlias])];
            state.message({
              Channel: Channel.Verbose, Text: `[DIRECTIVE] Added alias ${parsedAlias} to parameter ${parameter.name}.`
            });
          }

          if (parameterReplacer) {
            state.message({
              Channel: Channel.Verbose, Text: `[DIRECTIVE] Changed parameter-name from ${prevName} to ${parameter.name}.`
            });
          }

          if (paramDescriptionReplacer) {
            state.message({
              Channel: Channel.Verbose, Text: `[DIRECTIVE] Set parameter-description from parameter ${parameter.name}.`
            });
          }
        }

      } else if (operations) {
        for (const operation of operations) {
          const getCmdletName = (verb: string, subjectPrefix: string, subject: string, variantName: string): string => {
            return `${verb}-${subjectPrefix}${subject}${variantName ? `_${variantName}` : ``}`
          }

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

          // just the subject prefix can be an empty string
          if (subjectPrefixReplacer !== undefined || subjectReplacer || verbReplacer || variantReplacer) {
            let modificationMessage = `[DIRECTIVE] Changed command from ${oldCommandName} to ${newCommandName}. `
            state.message({
              Channel: Channel.Verbose, Text: modificationMessage
            });
          }

          if (clearAlias) {
            operation.details.csharp.alias = [];
            state.message({
              Channel: Channel.Verbose, Text: `[DIRECTIVE] Cleared aliases from command ${newCommandName}.`
            });
          }

          if (alias) {
            const getParsedAlias = (rawAlias: string) => {
              return rawAlias.replace('${verb}', operation.details.csharp.verb)
                .replace('${subject-prefix}', operation.details.csharp.subjectPrefix)
                .replace('${subject}', operation.details.csharp.subject)
                .replace('${variant}', operation.details.csharp.name);
            }

            const parsedAlias = new Array<string>();
            for (const each of alias) {
              parsedAlias.push(getParsedAlias(each));
            }

            operation.details.csharp.alias = [...new Set([...operation.details.csharp.alias, ...parsedAlias])];
            state.message({
              Channel: Channel.Verbose, Text: `[DIRECTIVE] Added alias ${parsedAlias} to command ${newCommandName}.`
            });
          }
        }
      }

      continue;
    }

    if (isWhereModelDirective(directive)) {
      const selectType = directive.select;
      const modelNameRegex = getPatternToMatch(directive.where["model-name"]);
      const modelFullNameRegex = getPatternToMatch(directive.where["model-fullname"]);
      const modelNamespaceRegex = getPatternToMatch(directive.where["model-namespace"]);
      const propertyNameRegex = getPatternToMatch(directive.where["property-name"]);

      const modelNameReplacer = directive.set["model-name"];
      const propertyNameReplacer = directive.set["property-name"];
      const propertyDescriptionReplacer = directive.set["property-description"];
      const formatTable = directive.set["format-table"];
      const suppressFormat = directive.set["suppress-format"];

      // select all models
      let models = values(state.model.schemas).linq.toArray();
      if (modelNameRegex) {
        models = values(models)
          .linq.where(model =>
            !!`${model.details.csharp.name}`.match(modelNameRegex))
          .linq.toArray();
      }

      if (modelFullNameRegex) {
        models = values(models)
          .linq.where(model =>
            !!`${model.details.csharp.fullname}`.match(modelFullNameRegex))
          .linq.toArray();
      }

      if (modelNamespaceRegex) {
        models = values(models)
          .linq.where(model =>
            !!`${model.details.csharp.namespace}`.match(modelNamespaceRegex))
          .linq.toArray();
      }

      if (propertyNameRegex && selectType === 'model') {
        models = values(models)
          .linq.where(model => values(allVirtualProperties(model.details.csharp.virtualProperties))
            .linq.any(property => !!`${property.name}`.match(propertyNameRegex)))
          .linq.toArray();
      }

      if (propertyNameRegex && (selectType === undefined || selectType === 'property')) {
        const properties = values(models)
          .linq.selectMany(model => allVirtualProperties(model.details.csharp.virtualProperties))
          .linq.where(property => !!`${property.name}`.match(propertyNameRegex))
          .linq.toArray();
        for (const property of properties) {
          const prevName = property.name;
          property.name = propertyNameReplacer ? propertyNameRegex ? property.name.replace(propertyNameRegex, propertyNameReplacer) : propertyNameReplacer : property.name;
          property.description = propertyDescriptionReplacer ? propertyDescriptionReplacer : property.description;

          if (propertyNameRegex) {
            state.message({
              Channel: Channel.Verbose, Text: `[DIRECTIVE] Changed property-name from ${prevName} to ${property.name}.`
            });
          }
        }

      } else if (models) {
        for (const model of models) {

          if (suppressFormat) {
            model.details.csharp.suppressFormat = true;
          }

          if (formatTable !== undefined && !suppressFormat) {
            const properties = allVirtualProperties(model.details.csharp.virtualProperties);
            const propertiesToExclude = formatTable["exclude-properties"];
            const propertiesToInclude = formatTable.properties;
            const labels = formatTable.labels;
            const widths = formatTable.width;
            if (labels) {
              const parsedLabels = new Dictionary<string>();
              for (const label of items(labels)) {
                parsedLabels[label.key.toLowerCase()] = pascalCase(label.value);
              }

              for (const property of properties) {
                if (Object.keys(parsedLabels).includes(property.name.toLowerCase())) {
                  if (property.format === undefined) {
                    property.format = {};
                  }

                  property.format.label = parsedLabels[property.name.toLowerCase()];
                }
              }
            }

            if (widths) {
              const parsedWidths = new Dictionary<number>();
              for (const w of items(widths)) {
                parsedWidths[w.key.toLowerCase()] = w.value;
              }

              for (const property of properties) {
                if (Object.keys(parsedWidths).includes(property.name.toLowerCase())) {
                  if (property.format === undefined) {
                    property.format = {};
                  }

                  property.format.width = parsedWidths[property.name.toLowerCase()];
                }
              }
            }

            if (propertiesToInclude) {
              const indexes = new Dictionary<number>();
              for (const item of items(propertiesToInclude)) {
                indexes[item.value.toLowerCase()] = item.key;
              }

              for (const property of properties) {
                if (propertiesToInclude.map(x => x.toLowerCase()).includes(property.name.toLowerCase())) {
                  if (property.format === undefined) {
                    property.format = {};
                  }

                  property.format.index = indexes[property.name.toLowerCase()];
                } else {
                  property.format = { suppressFormat: true };
                }
              }
            }

            if (propertiesToExclude) {
              for (const property of properties) {
                if (propertiesToExclude.map(x => x.toLowerCase()).includes(property.name.toLowerCase())) {
                  property.format = { suppressFormat: true };
                }
              }
            }
          }

          const prevName = model.details.csharp.name;
          model.details.csharp.name = modelNameReplacer ? modelNameRegex ? model.details.csharp.name.replace(modelNameRegex, modelNameReplacer) : modelNameReplacer : model.details.csharp.name;
          state.message({
            Channel: Channel.Verbose, Text: `[DIRECTIVE] Changed model-name from ${prevName} to ${model.details.csharp.name}.`
          });
        }
      }

      continue;
    }

    if (isWhereEnumDirective(directive)) {
      const enumNameRegex = getPatternToMatch(directive.where["enum-name"]);
      const enumValueNameRegex = getPatternToMatch(directive.where["enum-value-name"]);

      const enumNameReplacer = directive.set["enum-name"];
      const enumValueNameReplacer = directive.set["enum-value-name"];

      let enums = values(state.model.schemas)
        .linq.where(each => each.details.csharp.enum !== undefined)
        .linq.toArray();

      if (enumNameRegex) {
        enums = values(enums)
          .linq.where(each => !!`${each.details.csharp.name}`.match(enumNameRegex))
          .linq.toArray();
      }

      if (enumValueNameRegex) {
        const enumsValues = values(enums)
          .linq.selectMany(each => each.details.csharp.enum ? each.details.csharp.enum.values : [])
          .linq.where(each => !!`${each.name}`.match(enumValueNameRegex))
          .linq.toArray();
        for (const enumValue of enumsValues) {
          const prevName = enumValue.name;
          enumValue.name = enumValueNameReplacer ? enumNameRegex ? enumValue.name.replace(enumValueNameRegex, enumValueNameReplacer) : enumValueNameReplacer : prevName;
          if (enumValueNameRegex) {
            const enumNames = values(enums)
              .linq.select(each => each.details.csharp.name)
              .linq.toArray();
            state.message({
              Channel: Channel.Verbose, Text: `[DIRECTIVE] Changed enum-value-name from ${prevName} to ${enumValue.name}. Enum: ${JSON.stringify(enumNames, null, 2)}`
            });
          }
        }
      } else {
        for (const each of enums) {
          const prevName = each.details.csharp.name;
          each.details.csharp.name = enumNameReplacer ? enumNameRegex ? each.details.csharp.name.replace(enumNameRegex, enumNameReplacer) : enumNameReplacer : prevName;
          state.message({
            Channel: Channel.Verbose, Text: `[DIRECTIVE] Changed enum-name from ${prevName} to ${each.details.csharp.name}.`
          });
        }
      }

      continue;
    }


    if (isRemoveCommandDirective(directive)) {
      const selectType = directive.select;
      const subjectRegex = getPatternToMatch(directive.where.subject);
      const subjectPrefixRegex = getPatternToMatch(directive.where["subject-prefix"]);
      const verbRegex = getPatternToMatch(directive.where.verb);
      const variantRegex = getPatternToMatch(directive.where.variant);
      const parameterRegex = getPatternToMatch(directive.where["parameter-name"]);

      if (subjectRegex || subjectPrefixRegex || verbRegex || variantRegex || (parameterRegex && selectType === 'command')) {
        // select all operations first then reduce by finding the intersection with selectors
        let operationsToRemoveKeys = new Set(items(state.model.commands.operations)
          .linq.select(operation => operation.key)
          .linq.toArray());

        if (subjectRegex) {
          operationsToRemoveKeys = new Set(items(state.model.commands.operations)
            .linq.where(operation => !!`${operation.value.details.csharp.subject}`.match(subjectRegex) && operationsToRemoveKeys.has(operation.key))
            .linq.select(operation => operation.key)
            .linq.toArray());
        }

        if (subjectPrefixRegex && operationsToRemoveKeys.size > 0) {
          operationsToRemoveKeys = new Set(items(state.model.commands.operations)
            .linq.where(operation => !!`${operation.value.details.csharp.subjectPrefix}`.match(subjectPrefixRegex) && operationsToRemoveKeys.has(operation.key))
            .linq.select(operation => operation.key)
            .linq.toArray());
        }

        if (verbRegex && operationsToRemoveKeys.size > 0) {
          operationsToRemoveKeys = new Set(items(state.model.commands.operations)
            .linq.where(operation => !!`${operation.value.details.csharp.verb}`.match(verbRegex) && operationsToRemoveKeys.has(operation.key))
            .linq.select(operation => operation.key)
            .linq.toArray());
        }

        if (variantRegex && operationsToRemoveKeys.size > 0) {
          operationsToRemoveKeys = new Set(items(state.model.commands.operations)
            .linq.where(operation => !!`${operation.value.details.csharp.name}`.match(variantRegex) && operationsToRemoveKeys.has(operation.key))
            .linq.select(operation => operation.key)
            .linq.toArray());
        }

        if (parameterRegex && selectType === 'command' && operationsToRemoveKeys.size > 0) {
          operationsToRemoveKeys = new Set(items(state.model.commands.operations)
            .linq.where(operation => values(allVirtualParameters(operation.value.details.csharp.virtualParameters))
              .linq.any(parameter => !!`${parameter.name}`.match(parameterRegex)))
            .linq.where(operation => operationsToRemoveKeys.has(operation.key))
            .linq.select(operation => operation.key)
            .linq.toArray());
        }

        for (const key of operationsToRemoveKeys) {
          const operationInfo = state.model.commands.operations[key].details.csharp;
          state.message({
            Channel: Channel.Verbose, Text: `[DIRECTIVE] Removed command ${operationInfo.verb}-${operationInfo.subjectPrefix}${operationInfo.subject}${operationInfo.name ? `_${operationInfo.name}` : ``}`
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
      details.name = `${details.name.replace(/\d*$/g, '')} ${n++} `;
      fname = `${details.verb} -${details.subject} -${details.name} `;
    }
    operationIdentities.add(fname);
  }

  return state.model;
}

function hasSpecialChars(str: string): boolean {
  return !/^[a-zA-Z0-9]+$/.test(str);
}
