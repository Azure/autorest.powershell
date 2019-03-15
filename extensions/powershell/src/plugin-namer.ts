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
const parametersToSingularize = new Set<string>([
  'tags'
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
      instance.csharp = linq.clone(instance.default);
    }
  }

  if (shouldSanitize || isAzure) {
    for (const operation of values(model.commands.operations)) {
      for (const parameter of values(operation.parameters)) {
        // save previous name as alias
        parameter.details.csharp.alias = [parameter.details.csharp.name];
        const otherParametersNames = values(operation.parameters)
          .linq.select(each => each.details.csharp.name)
          .linq.where(name => name !== parameter.details.csharp.name)
          .linq.toArray();

        const sanitizedName = removeProhibitedPrefix(
          parameter.details.csharp.name,
          operation.details.csharp.noun,
          otherParametersNames
        );

        if (parameter.details.csharp.name !== sanitizedName) {
          service.Message({ Channel: Channel.Information, Text: `Sanitized name -> Changed parameter from ${parameter.details.csharp.name} to ${sanitizedName} from command ${operation.verb}-${operation.details.csharp.noun}` });

          // sanitize name
          parameter.details.csharp.name = sanitizedName;
        }
      }
    }

    for (const schema of values(model.schemas)) {
      for (const property of values(schema.properties)) {
        // save previous name as alias
        property.details.csharp.alias = [property.details.csharp.name];
        const otherPropertiesNames = values(schema.properties)
          .linq.select(each => each.details.csharp.name)
          .linq.where(name => name !== property.details.csharp.name)
          .linq.toArray();

        const sanitizedName = removeProhibitedPrefix(
          property.details.csharp.name,
          schema.details.csharp.name,
          otherPropertiesNames
        );

        if (property.details.csharp.name !== sanitizedName) {
          service.Message({ Channel: Channel.Verbose, Text: `Sanitized name -> Changed property from ${property.details.csharp.name} to ${sanitizedName} from model ${schema.details.csharp.name}` });

          // sanitize name
          property.details.csharp.name = sanitizedName;
        }
      }
    }
  }

  if (isAzure) {
    // tweak names for PS
    for (const operations of values(model.commands.operations)) {
      for (const parameter of values(operations.parameters)) {
        const parameterNamesLowerCase = operations.parameters.map(each => each.name.toLowerCase());

        // plural Parameters -> singular, for well-known parameters
        if (parametersToSingularize.has(parameter.details.csharp.name.toLowerCase())
          && !parameterNamesLowerCase.includes(singularize(parameter.details.csharp.name.toLowerCase()))) {
          parameter.details.csharp.name = singularize(parameter.details.csharp.names);
        }

        // make sure parameters are following naming conventions
        parameter.details.csharp.name = getPascalIdentifier(parameter.details.csharp.name);
      }
    }

    // plural Parameters -> singular, for well-known parameters
    for (const schema of values(model.schemas)) {
      for (const property of values(schema.properties)) {
        if (parametersToSingularize.has(property.details.csharp.name.toLocaleLowerCase())) {
          property.details.csharp.name = singularize(property.details.csharp.name);
        }

        // make sure parameters are following naming conventions
        property.details.csharp.name = getPascalIdentifier(property.details.csharp.name);
      }
    }
  }

  return model;
}
