/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, processCodeModel } from '@microsoft.azure/autorest.codemodel-v3';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { values, pascalCase, fixLeadingNumber, deconstruct, where } from '@microsoft.azure/codegen';


let directives: Array<any> = [];

interface WhereCommandDirective {
  where: {
    noun?: string;
    verb?: string;
    variant?: string;
    'parameter-name'?: string;
  };
  set: {
    noun?: string;
    verb?: string;
    variant?: string;
    hidden?: Boolean;
    'parameter-name'?: string;
    'parameter-description'?: string;
  };
}

interface WhereModelDirective {
  where: {
    'model-name'?: string;
    'property-name'?: string;
  };
  set: {
    'model-name'?: string;
    'property-name'?: string;
    'property-description'?: string;
  }
}

function isDirective(it: any): it is WhereCommandDirective {
  return it.where && it.set;
}

function isWhereCommandDirective(it: any): it is WhereCommandDirective {
  const directive = it;
  const where = directive.where;
  const set = directive.set;
  if (where && set) {
    if ((set['parameter-name'] || set.hidden || set.noun || set["parameter-description"] || set.verb || set.variant)
      && (where.noun || where.verb || where.variant || where["parameter-name"])) {
      let error = where['model-name'] ? `Can't select model and command at the same time.` : ``;
      error += where['property-name'] ? `Can't select property and command at the same time.` : ``;
      error = set['property-name'] ? `Can't set a property-name when a command is selected.` : ``;
      error += set['property-description'] ? `Can't set a property-description when a command is selected.` : ``;
      error += set['model-name'] ? `Can't set a model-name when a command is selected.` : ``;
      if (error) {
        throw Error(`Incorrect Directive: ${JSON.stringify(it, null, 2)}. Reason: ${error}.`);
      }

      return true;
    }
  }

  return false;
}


function isWhereModelDirective(it: any): it is WhereModelDirective {
  const directive = it;
  const where = directive.where;
  const set = directive.set;
  if (where && set) {
    if ((set["model-name"] || set["property-description"] || set["property-name"])
      && (where['model-name'] || where['property-name'])) {
      let error = where['noun'] || where['verb'] || where['variant'] ? `Can't select model and command at the same time.` : ``;
      error += where['parameter-name'] ? `Can't select a parameter and command at the same time.` : ``;
      error = set['property-name'] ? `Can't set property-name when a model is selected.` : ``;
      error += set['noun'] ? `Can't set command noun when a model is selected.` : ``;
      error += set['verb'] ? `Can't set command verb when a model is selected.` : ``;
      error += set['variant'] ? `Can't set command variant when a model is selected.` : ``;
      error += set['hidden'] ? `Can't hide a command when a model is selected.` : ``;
      error += set['variant'] ? `Can't set a variant name when a model is selected.` : ``;
      if (error) {
        throw Error(`Incorrect Directive: ${JSON.stringify(it, null, 2)}.Reason: ${error}.`);
      }

      return true;
    }
  }


  return false;
}

export async function cosmeticModifier(service: Host) {
  directives = values(await service.GetValue('directive'))
    .linq.select(directive => directive)
    .linq.where(directive => isWhereCommandDirective(directive) || isWhereModelDirective(directive))
    .linq.toArray();

  return processCodeModel(tweakModel, service);
}

async function tweakModel(model: codemodel.Model): Promise<codemodel.Model> {

  for (const directive of directives) {
    if (isWhereCommandDirective(directive)) {
      const getParsedSelector = (selector: string | undefined): RegExp | undefined => {
        return selector ? isNotRegex(selector) ? new RegExp(`^${selector}$`, 'gi') : new RegExp(selector, 'gi') : undefined;
      }

      const nounRegex = getParsedSelector(directive.where.noun);
      const verbRegex = getParsedSelector(directive.where.verb);
      const variantRegex = getParsedSelector(directive.where.variant);
      const parameterRegex = getParsedSelector(directive.where["parameter-name"]);

      const nounReplacer = directive.set.noun;
      const verbReplacer = directive.set.verb;
      const variantReplacer = directive.set.variant;
      const shouldHide = !!directive.set.hidden;
      const parameterReplacer = directive.set["parameter-name"];
      const paramDescriptionReplacer = directive.set["parameter-description"];

      // select all operations
      let operations = values(model.commands.operations).linq.toArray();
      if (nounRegex) {
        operations = values(operations)
          .linq.where(operation =>
            !!`${operation.details.csharp.noun}`.match(nounRegex))
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

      if (parameterRegex) {
        const parameters = values(operations).linq.selectMany(operation => operation.parameters).linq.where(parameter =>
          !!`${parameter.details.csharp.verb}`.match(parameterRegex));
        for (const parameter of parameters) {
          parameter.details.csharp.name = parameterReplacer ? parameterRegex ? parameter.details.csharp.name.replace(parameterRegex, parameterReplacer) : parameterReplacer : parameter.details.csharp.name;
          parameter.description = paramDescriptionReplacer ? paramDescriptionReplacer : parameter.description;
        }

      } else if (operations) {
        for (const operation of operations) {
          operation.details.csharp.noun = nounReplacer ? nounRegex ? operation.details.csharp.noun.replace(nounRegex, nounReplacer) : nounReplacer : operation.details.csharp.noun;
          operation.details.csharp.verb = verbReplacer ? verbRegex ? operation.details.csharp.verb.replace(verbRegex, verbReplacer) : verbReplacer : operation.details.csharp.verb;
          operation.details.csharp.name = variantReplacer ? variantRegex ? operation.details.csharp.name.replace(variantRegex, variantReplacer) : variantReplacer : operation.details.csharp.name;
          operation.details.csharp.hide = shouldHide;
        }
      }
    }
  }

  //   if (directive['set-name'] !== undefined || directive['set-alias']) {
  //     const parameters = values(model.commands.operations)
  //       .linq.selectMany(operation => values(operation.parameters))
  //       .linq.where(parameter => getPascalName(parameter.details.csharp.name) === getPascalName(directive['where-parameter']))
  //       .linq.toArray();

  //     if (directive['set-name'] !== undefined) {
  //       for (const parameter of parameters) {
  //         parameter.details.csharp.name = directive['set-name'];
  //       }
  //     }

  //     if (directive['set-alias'] !== undefined) {
  //       for (const parameter of parameters) {
  //         parameter.details.csharp.alias = (Array.isArray(directive['set-alias'])) ? getDistinctElements(directive['set-alias']) : [directive['set-alias']];
  //       }
  //     }
  //   }

  //   continue;
  // }
  // if (isWhereParameterDirective(directive)) {
  //   if (directive['set-name'] !== undefined || directive['set-alias']) {
  //     const parameters = values(model.commands.operations)
  //       .linq.selectMany(operation => values(operation.parameters))
  //       .linq.where(parameter => getPascalName(parameter.details.csharp.name) === getPascalName(directive['where-parameter']))
  //       .linq.toArray();

  //     if (directive['set-name'] !== undefined) {
  //       for (const parameter of parameters) {
  //         parameter.details.csharp.name = directive['set-name'];
  //       }
  //     }

  //     if (directive['set-alias'] !== undefined) {
  //       for (const parameter of parameters) {
  //         parameter.details.csharp.alias = (Array.isArray(directive['set-alias'])) ? getDistinctElements(directive['set-alias']) : [directive['set-alias']];
  //       }
  //     }
  //   }

  //   continue;
  // }

  // if (isWherePropertyDirective(directive)) {
  //   if (directive['set-name'] !== undefined || directive['set-alias']) {
  //     const properties = values(model.schemas)
  //       .linq.selectMany(schema => values(schema.properties))
  //       .linq.where(property => getPascalName(property.details.csharp.name) === getPascalName(directive['where-property']))
  //       .linq.toArray();

  //     if (directive['set-name'] !== undefined) {
  //       for (const property of properties) {
  //         property.details.csharp.name = directive["set-name"];
  //       }
  //     }

  //     if (directive['set-alias'] !== undefined) {
  //       for (const property of properties) {
  //         property.details.csharp.alias = (Array.isArray(directive['set-alias'])) ? getDistinctElements(directive['set-alias']) : [directive['set-alias']];
  //       }
  //     }
  //   }

  //   continue;
  // }

  // if (isWhereModelDirective(directive)) {
  //   const whereModelVal = directive['where-model'];
  //   const isRegex = !(/^[a-zA-Z0-9]*$/.test(whereModelVal));
  //   if (isRegex) {
  //     const regex = new RegExp(whereModelVal);
  //     const models = values(model.schemas)
  //       .linq.where(schema => !!schema.details.csharp.name.match(regex))
  //       .linq.toArray();
  //     for (const model of models) {
  //       const replacer = directive['set-name'];
  //       model.details.csharp.name = model.details.csharp.name.replace(regex, replacer);
  //     }
  //   } else {
  //     const models = values(model.schemas)
  //       .linq.where(schema => getPascalName(schema.details.csharp.name) === getPascalName(whereModelVal))
  //       .linq.toArray();
  //     for (const model of models) {
  //       model.details.csharp.name = model.details.csharp.name.replace(whereModelVal, directive['set-name']);
  //     }
  //   }

  //   continue;
  // }


  // if (isWhereCommandDirective(directive)) {
  //   const whereCommandValue = directive['where-command'];
  //   const isRegex = !isCommandNameLiteral(directive['where-command']);
  //   if (isRegex) {
  //     const nounPrefix = model.details.csharp.nounPrefix;
  //     const regex = new RegExp(whereCommandValue);
  //     const operations = values(model.commands.operations)
  //       .linq.where(operation => !!`${operation.details.csharp.verb} -${nounPrefix} ${operation.details.csharp.noun} `.match(regex))
  //       .linq.toArray();
  //     for (const operation of operations) {
  //       const replacer = directive['set-name'];
  //       const newName = getCommandName(operation.verb, nounPrefix, operation.noun).replace(regex, replacer);
  //       if (isCommandNameLiteral(newName)) {
  //         const newCommandName = getCommandNameParts(newName, nounPrefix);
  //         operation.details.csharp.noun = newCommandName.noun;
  //         operation.details.csharp.verb = newCommandName.verb;
  //         operation.details.csharp.nounPrefix = operation.details.csharp.nounPrefix = newCommandName.prefix;;
  //       } else {
  //         throw new Error(`set - name: ${directive['set-name']} value from directive provided is incorrect.
  // It should result in a valid cmdlet name in the form: /^[a-zA-Z]+-[a-zA-Z]+$/`);
  //       }
  //     }
  //   } else {
  //     const nounPrefix = model.details.csharp.nounPrefix;
  //     const operations = values(model.commands.operations)
  //       .linq.where(operation => `${operation.details.csharp.verb} -${nounPrefix} ${operation.details.csharp.noun} `.toLowerCase() === whereCommandValue.toLowerCase())
  //       .linq.toArray();
  //     for (const operation of operations) {
  //       const newName = getCommandName(operation.verb, nounPrefix, operation.noun).replace(whereCommandValue, directive['set-name']);
  //       if (isCommandNameLiteral(newName)) {
  //         const newCommandName = getCommandNameParts(newName, nounPrefix);
  //         operation.details.csharp.noun = newCommandName.noun;
  //         operation.details.csharp.verb = newCommandName.verb;
  //         operation.details.csharp.nounPrefix = newCommandName.prefix;
  //       } else {
  //         throw new Error(`set - name: ${directive['set-name']} value from directive provided is incorrect.
  // It should result in a valid cmdlet name in the form: /^[a-zA-Z]+-[a-zA-Z]+$/`);
  //       }
  //     }
  //   }

  //   continue;
  // }


  return model;
}

function getDistinctElements(elements: Array<string>): Array<string> {
  return [... new Set<string>(elements)];
}

function getPascalName(name: string): string {
  return pascalCase(fixLeadingNumber(deconstruct(name)));
}

function isNotRegex(str: string): boolean {
  return /^[a-zA-Z0-9]+$/.test(str);
}

function getCommandName(verb: string, prefix: string, noun: string): string {
  return `${getPascalName(verb)} -${getPascalName(prefix)} ${getPascalName(noun)} `;
}


function getCommandNameParts(command: string, prefix: string): { noun: string, verb: string, prefix: string } {
  const parts = command.split('-');
  const containsOldPrefix = !!parts[1].match(new RegExp(`^ ${prefix} `, 'gi'));

  return { verb: parts[0], noun: containsOldPrefix ? parts[1].replace(prefix, '') : parts[1], prefix: containsOldPrefix ? prefix : '' };
}