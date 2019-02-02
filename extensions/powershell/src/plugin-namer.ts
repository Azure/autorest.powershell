/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel } from '@microsoft.azure/autorest.codemodel-v3';
import { processCodeModel } from '@microsoft.azure/autorest.codemodel-v3';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { values, pascalCase, fixLeadingNumber, deconstruct } from '@microsoft.azure/codegen';
import { singularize } from './name-inferrer';
import * as linq from '@microsoft.azure/linq';

// well-known parameters to singularize
const parametersToSingularize = new Set<string>([
  'tags'
]);


export async function namer(service: Host) {
  return processCodeModel(tweakModel, service);
}

function populateCSdetails(node: any) {
  if (typeof node === 'object' && node !== null) {
    if (node.details && !node.details.csharp) {
      node.details.csharp = linq.clone(node.details.default);
    } else {
      for (const [key, member] of Object.entries(node)) {
        populateCSdetails(member);
      }
    }
  }
}

async function tweakModel(model: codemodel.Model): Promise<codemodel.Model> {

  // make sure csharp has all the model details
  if (!model.details.csharp) {
    model.details.csharp = linq.clone(model.details.default);
  }

  // make sure recursively that every details field has csharp
  for (const [key, member] of Object.entries(model)) {
    populateCSdetails(member);
  }

  // tweak names for PS
  for (const operations of values(model.commands.operations)) {
    for (const parameter of values(operations.parameters)) {

      const Name = 'Name';
      const parameterNamesLowerCase = operations.parameters.map(each => each.name.toLowerCase());
      // resource name for resource matching cmdlet verb should be 'Name'
      if ((operations.noun + Name).toLowerCase() === parameter.details.csharp.name.toLowerCase() && !parameterNamesLowerCase.includes(Name)) {
        parameter.details.csharp.name = Name;

        // plural Parameters -> singular, for well-known parameters
      } else if (parametersToSingularize.has(parameter.details.csharp.name.toLowerCase())
        && !parameterNamesLowerCase.includes(singularize(parameter.details.csharp.name.toLowerCase()))) {
        parameter.details.csharp.name = singularize(parameter.details.csharp.names);
      }

      // make sure parameters are following naming conventions
      parameter.details.csharp.name = getPascalName(parameter.details.csharp.name);
    }
  }

  // plural Parameters -> singular, for well-known parameters
  for (const schema of values(model.schemas)) {
    for (const property of values(schema.properties)) {
      if (parametersToSingularize.has(property.details.csharp.name.toLocaleLowerCase())) {
        property.details.csharp.name = singularize(property.details.csharp.name);
      }

      // make sure parameters are following naming conventions
      property.details.csharp.name = getPascalName(property.details.csharp.name);
    }
  }

  return model;
}


function getPascalName(name: string): string {
  return pascalCase(fixLeadingNumber(deconstruct(name)));
}
