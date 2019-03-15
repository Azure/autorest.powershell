/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host, Channel } from '@microsoft.azure/autorest-extension-base';
import { codemodel, processCodeModel } from '@microsoft.azure/autorest.codemodel-v3';
import { deconstruct, fixLeadingNumber, pascalCase, values, removeProhibitedPrefix, getPascalIdentifier } from '@microsoft.azure/codegen';
import * as linq from '@microsoft.azure/linq';
import { singularize } from './name-inferrer';

// well-known parameters to singularize
const namesToSingularize = new Set<string>([
  'Tags'
]);

export async function namer(service: Host) {
  return processCodeModel(tweakModel, service);
}

async function tweakModel(model: codemodel.Model, service: Host): Promise<codemodel.Model> {
  // get the value 
  const isAzure = !!await service.GetValue('azure') || !!await service.GetValue('azure-arm') || false;
  const shouldSanitize = !!await service.GetValue('sanitize-names');

  // make sure recursively that every details field has csharp
  for (const { index, instance } of linq.visitor(model)) {
    if (index === 'details' && instance.default && !instance.csharp) {
      instance.csharp = linq.clone(instance.default, false, undefined, undefined, ['schema']);
    }
  }

  if (shouldSanitize || isAzure) {
    for (const operation of values(model.commands.operations)) {
      const virtualParameters = values(operation.details.csharp.virtualParameters)
        .linq.selectMany(virtualParameters => virtualParameters)
        .linq.select(parameter => parameter)
        .linq.toArray();
      for (const parameter of virtualParameters) {
        // save previous name as alias
        const prevName = parameter.name;
        const otherParametersNames = values(virtualParameters)
          .linq.select(each => each.name)
          .linq.where(name => name !== parameter.name)
          .linq.toArray();

        const sanitizedName = removeProhibitedPrefix(
          parameter.name,
          operation.details.csharp.noun,
          otherParametersNames
        );

        if (prevName !== sanitizedName) {
          if (parameter.alias === undefined) {
            parameter.alias = [];
          }

          parameter.alias.push(parameter.name);

          // change name
          parameter.name = sanitizedName;
          service.Message({ Channel: Channel.Information, Text: `Sanitized name -> Changed parameter-name ${prevName} to ${parameter.name} from command ${operation.verb}-${operation.details.csharp.noun}` });
        } else if (namesToSingularize.has(parameter.name) && isAzure) {
          if (parameter.alias === undefined) {
            parameter.alias = [];
          }

          parameter.alias.push(parameter.name);

          // change name
          parameter.name = singularize(parameter.name);
          service.Message({ Channel: Channel.Verbose, Text: `Well-Know Azure parameter rename ->  Changed parameter-name ${prevName} to ${parameter.name} from command ${operation.verb}-${operation.details.csharp.noun}` });
        }
      }
    }

    for (const schema of values(model.schemas)) {
      const virtualProperties = values(schema.details.csharp.virtualProperties)
        .linq.selectMany(virtualProperties => virtualProperties)
        .linq.select(property => property)
        .linq.toArray();
      for (const property of virtualProperties) {
        // save previous name as alias
        const otherPropertiesNames = values(virtualProperties)
          .linq.select(each => each.name)
          .linq.where(name => name !== property.name)
          .linq.toArray();

        const sanitizedName = removeProhibitedPrefix(
          property.name,
          schema.details.csharp.name,
          otherPropertiesNames
        );

        if (property.name !== sanitizedName) {
          // apply alias
          const prevName = property.name
          if (property.alias === undefined) {
            property.alias = [];
          }

          property.alias.push(property.name);

          // change name
          property.name = sanitizedName;
          service.Message({ Channel: Channel.Verbose, Text: `Sanitized name -> Changed property-name ${prevName} to ${property.name} from model ${schema.details.csharp.name}` });
        } else if (namesToSingularize.has(property.name) && isAzure) {
          // apply alias
          const prevName = property.name
          if (property.alias === undefined) {
            property.alias = [];
          }

          property.alias.push(prevName);

          // change name
          property.name = singularize(property.name);
          service.Message({ Channel: Channel.Verbose, Text: `Well-Know Azure property rename -> Changed property-name ${prevName} to ${property.name} from model ${schema.details.csharp.name}` });
        }
      }
    }
  }

  return model;
}
