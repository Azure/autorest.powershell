/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Model } from '#common/code-model/code-model';
import { JsonType } from '#common/code-model/schema';
import { items, length, values } from '#common/linq';
import { ModelState } from '#common/model-state';
import { processCodeModel } from '#common/process-code-model';
import { camelCase, deconstruct, fixLeadingNumber, pascalCase } from '#common/text-manipulation';
import { System } from '#csharp/code-dom/dotnet';

import { SchemaDetails } from '#csharp/lowlevel-generator/code-model';
import { SchemaDefinitionResolver } from '#csharp/schema/schema-resolver';
import { Host } from '@microsoft.azure/autorest-extension-base';

export async function process(service: Host) {
  return processCodeModel(nameStuffRight, service);
}

async function nameStuffRight(codeModel: Model, service: Host): Promise<Model> {
  const resolver = new SchemaDefinitionResolver();

  // set the namespace for the service
  const serviceNamespace = await service.GetValue('namespace') || 'Sample.API';
  const clientName = pascalCase(fixLeadingNumber(deconstruct(codeModel.details.default.name)));

  // set c# client details (name)
  codeModel.details.csharp = {
    ...codeModel.details.default, // copy everything by default
    name: clientName,
    namespace: serviceNamespace,
    fullname: `${serviceNamespace}.${clientName}`
  };

  for (const { key: schemaName, value: schema } of items(codeModel.schemas)) {
    const details = schema.details.default;

    // object types.
    if (schema.type === JsonType.Object) {
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(details.name)])), // objects have an interfaceName
        name: pascalCase(fixLeadingNumber(deconstruct(schema.details.default.name))),
        namespace: pascalCase([serviceNamespace, '.', `Models`]),  // objects have a namespace
        fullname: `${pascalCase([serviceNamespace, '.', `Models`])}.${pascalCase(fixLeadingNumber(deconstruct(schema.details.default.name)))}`,
      };
    } else if (schema.type === JsonType.String && schema.details.default.enum) {
      // oh, it's an enum type
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(details.name)])),
        name: pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name))),
        namespace: pascalCase([serviceNamespace, '.', `Support`]),
        fullname: `${pascalCase([serviceNamespace, '.', `Support`])}.${pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name)))}`,
        enum: {
          ...schema.details.default.enum,
          name: pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name))),
          values: schema.details.default.enum.values.map(each => {
            return {
              ...each,
              name: pascalCase(fixLeadingNumber(deconstruct(each.name)))
            };
          })
        }
      };

    } else {
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: '<INVALID>',
        name: schemaName,
        namespace: '<INVALID>',
        fullname: '<INVALID>'
      };
    }

    for (const { key: propertyName, value: propertySchema } of items(schema.properties)) {
      const propertyDetails = propertySchema.details.default;

      const className = schema.details.csharp.name;

      let pname = pascalCase(fixLeadingNumber(deconstruct(propertyDetails.name)));
      if (pname === className) {
        pname = `${pname}Property`;
      }

      if (pname === 'default') {
        pname = '@default';
      }

      propertySchema.details.csharp = {
        ...propertyDetails,
        name: pname // and so are the propertyNmaes
      };
    }

    // fix enum names
    if (schema.details.default.enum) {
      schema.details.csharp.enum = {
        ...schema.details.default.enum,
        name: pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name)))
      };

      // and the value names themselves
      for (const value of values(schema.details.csharp.enum.values)) {
        value.name = pascalCase(fixLeadingNumber(deconstruct(value.name)));
      }
    }
  }

  for (const operation of values(codeModel.http.operations)) {
    const details = operation.details.default;

    operation.details.csharp = {
      ...details, // inherit
      name: pascalCase(fixLeadingNumber(deconstruct(details.name))), // operations have pascal cased names
    };

    // parameters are camelCased.
    for (const parameter of values(operation.parameters)) {
      const parameterDetails = parameter.details.default;

      let propName = camelCase(fixLeadingNumber(deconstruct(parameterDetails.name)));

      if (propName === 'default') {
        propName = '@default';
      }

      parameter.details.csharp = {
        ...parameterDetails,
        name: propName
      };
    }

    for (const { key: responseCode, value: responses } of items(operation.responses_new)) {
      // per responseCode
      for (const response of values(responses)) {
        const responseTypeDefinition = response.schema ? resolver.resolveTypeDeclaration(<any>response.schema, true, new ModelState(service, codeModel, `?`, ['schemas', response.schema.details.default.name])) : undefined;
        const headerTypeDefinition = response.headerSchema ? resolver.resolveTypeDeclaration(<any>response.headerSchema, true, new ModelState(service, codeModel, `?`, ['schemas', response.headerSchema.details.default.name])) : undefined;

        const code = (System.Net.HttpStatusCode[response.responseCode].value || '').replace('System.Net.HttpStatusCode', '') || response.responseCode;

        response.details.csharp = {
          ...response.details.default,
          responseType: responseTypeDefinition ? responseTypeDefinition.declaration : '',
          headerType: headerTypeDefinition ? headerTypeDefinition.declaration : '',
          name: (length(responses) <= 1) ?
            camelCase(fixLeadingNumber(deconstruct(`on ${code}`))) : // the common type (or the only one.)
            camelCase(fixLeadingNumber(deconstruct(`on ${code} ${response.mimeTypes[0]}`)))
        };
      }
    }
  }

  return codeModel;
}
