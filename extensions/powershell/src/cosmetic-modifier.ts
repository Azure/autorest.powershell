/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, processCodeModel } from '@microsoft.azure/autorest.codemodel-v3';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { values, pascalCase, fixLeadingNumber, deconstruct, nameof } from '@microsoft.azure/codegen';
const directivesToFilter = new Set<string>([
  'where-model',
  'where-parameter',
  'where-property',
  'where-command'
]);

let directives: Array<any> = [];
let nounPrefix = '';

interface WhereParameterDirective {
  'where-parameter': string;
  'set-name'?: string;
  'set-alias'?: Array<string> | string;
}

interface WherePropertyDirective {
  'where-property': string;
  'set-name'?: string;
  'set-alias'?: Array<string> | string;
}

interface WhereModelDirective {
  'where-model': string;
  'set-name': string;
}

interface WhereModelDirective {
  'where-model': string;
  'set-name': string;
}

interface WhereCommandDirective {
  'where-command': string;
  'set-name': string;
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

function isWhereCommandDirective(it: any): it is WhereCommandDirective {
  return it['where-command'];
}

export async function cosmeticModifier(service: Host) {
  directives = values(await service.GetValue('directive'))
    .linq.where(directive => values(Object.keys(directive))
      .linq.where(key => directivesToFilter.has(key))
      .linq.any(each => !!each))
    .linq.toArray();
  const azure = await service.GetValue('azure') || await service.GetValue('azure-arm') || false;
  nounPrefix = await service.GetValue('noun-prefix') || azure ? 'Az' : ``;
  return processCodeModel(tweakModel, service);
}

async function tweakModel(model: codemodel.Model): Promise<codemodel.Model> {

  for (const directive of directives) {

    if (isWhereParameterDirective(directive)) {
      if (directive['set-name'] !== undefined || directive['set-alias']) {
        const parameters = values(model.commands.operations)
          .linq.selectMany(operation => values(operation.parameters))
          .linq.where(parameter => getPascalName(parameter.details.csharp.name) === getPascalName(directive['where-parameter']))
          .linq.toArray();

        if (directive['set-name'] !== undefined) {
          for (const parameter of parameters) {
            parameter.details.csharp.name = directive['set-name'];
          }
        }

        if (directive['set-alias'] !== undefined) {
          for (const parameter of parameters) {
            parameter.details.csharp.alias = (Array.isArray(directive['set-alias'])) ? getDistinctElements(directive['set-alias']) : [directive['set-alias']];
          }
        }
      }

      continue;
    }

    if (isWherePropertyDirective(directive)) {
      if (directive['set-name'] !== undefined || directive['set-alias']) {
        const properties = values(model.schemas)
          .linq.selectMany(schema => values(schema.properties))
          .linq.where(property => getPascalName(property.details.csharp.name) === getPascalName(directive['where-property']))
          .linq.toArray();

        if (directive['set-name'] !== undefined) {
          for (const property of properties) {
            property.details.csharp.name = directive["set-name"];
          }
        }

        if (directive['set-alias'] !== undefined) {
          for (const property of properties) {
            property.details.csharp.alias = (Array.isArray(directive['set-alias'])) ? getDistinctElements(directive['set-alias']) : [directive['set-alias']];
          }
        }
      }

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
        for (const model of models) {
          const replacer = directive['set-name'];
          model.details.csharp.name = model.details.csharp.name.replace(regex, replacer);
        }
      } else {
        const models = values(model.schemas)
          .linq.where(schema => getPascalName(schema.details.csharp.name) === getPascalName(whereModelVal))
          .linq.toArray();
        for (const model of models) {
          model.details.csharp.name = model.details.csharp.name.replace(whereModelVal, directive['set-name']);
        }
      }

      continue;
    }


    if (isWhereCommandDirective(directive)) {
      const whereCommandValue = directive['where-command'];
      const isRegex = !isCommandNameLiteral(directive['where-command']);
      if (isRegex) {
        const regex = new RegExp(whereCommandValue);
        const operations = values(model.commands.operations)
          .linq.where(operation => !!`${operation.verb}-${nounPrefix}${operation.noun}`.match(regex))
          .linq.toArray();
        for (const operation of operations) {
          const replacer = directive['set-name'];
          const newName = getCommandName(operation.verb, nounPrefix, operation.noun).replace(regex, replacer);
          if (isCommandNameLiteral(newName)) {
            const newNameParts = getCommandNameParts(newName, nounPrefix);
            operation.noun = newNameParts.noun;
            operation.verb = newNameParts.verb
          } else {
            throw new Error(`set-name: ${directive['set-name']} value from directive provided is incorrect. 
                          It should result in a string in the form: /^[a-zA-Z]+-[a-zA-Z]+$/`);
          }
        }
      } else {
        const operations = values(model.commands.operations)
          .linq.where(operation => `${operation.verb}-${nounPrefix}${operation.noun}`.toLowerCase() === whereCommandValue.toLowerCase())
          .linq.toArray();
        for (const operation of operations) {
          const newName = getCommandName(operation.verb, nounPrefix, operation.noun).replace(whereCommandValue, directive['set-name']);
          if (isCommandNameLiteral(newName)) {
            const newCommandName = getCommandNameParts(newName, nounPrefix);
            operation.noun = newCommandName.noun;
            operation.verb = newCommandName.verb

          } else {
            throw new Error(`set-name: ${directive['set-name']} value from directive provided is incorrect. 
                            It should result in a string in the form: /^[a-zA-Z]+-[a-zA-Z]+$/`);
          }
        }
      }

      continue;
    }
  }

  return model;
}

function getDistinctElements(elements: Array<string>): Array<string> {
  return [... new Set<string>(elements)];
}

function getPascalName(name: string): string {
  return pascalCase(fixLeadingNumber(deconstruct(name)));
}

function isCommandNameLiteral(str: string): boolean {
  return /^[a-zA-Z]+-[a-zA-Z]+$/.test(str);
}

function getCommandName(verb: string, prefix: string, noun: string): string {
  return `${getPascalName(verb)}-${getPascalName(prefix)}${getPascalName(noun)}`;
}


function getCommandNameParts(command: string, prefix: string): { noun: string, verb: string } {
  command = command.replace(prefix, '');
  const parts = command.split('-');
  return { verb: parts[0], noun: parts[1] };
}