/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, JsonType, ModelState, processCodeModel, VirtualProperty } from '@microsoft.azure/autorest.codemodel-v3';

import { camelCase, deconstruct, Dictionary, excludeXDash, fixLeadingNumber, items, keys, length, pascalCase, values } from '@microsoft.azure/codegen';
import { System } from '@microsoft.azure/codegen-csharp';

import { Host } from '@microsoft.azure/autorest-extension-base';
import { SchemaDetails } from './code-model';
import { SchemaDefinitionResolver } from './schema/schema-resolver';

export async function csnamer(service: Host) {
  return processCodeModel(nameStuffRight, service);
}

function toPascal(txt: string): string {
  return pascalCase(fixLeadingNumber(deconstruct(txt)));
}

async function nameStuffRight(codeModel: codemodel.Model, service: Host): Promise<codemodel.Model> {
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


  const schemaNames = new Set<string>();


  for (const schema of values(codeModel.schemas)) {

    // for each schema, we're going to set the name
    // to the suggested name, unless we have collisions
    // at which point, we're going to add a number (for now?)
    const details = schema.details.default;
    let schemaName = details.name;
    let n = 1;
    while (schemaNames.has(schemaName)) {
      schemaName = `${details.name}_${n++}`;
    }
    schemaNames.add(schemaName);

    // object types.
    if (schema.type === JsonType.Object) {
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(schemaName)])), // objects have an interfaceName
        name: pascalCase(fixLeadingNumber(deconstruct(schemaName))),
        namespace: pascalCase([serviceNamespace, '.', `Models`]),  // objects have a namespace
        fullname: `${pascalCase([serviceNamespace, '.', `Models`])}.${pascalCase(fixLeadingNumber(deconstruct(schemaName)))}`,
      };
    } else if (schema.type === JsonType.String && schema.details.default.enum) {
      // oh, it's an enum type
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(schemaName)])),
        name: pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name))),
        namespace: pascalCase([serviceNamespace, '.', `Support`]),
        fullname: `${pascalCase([serviceNamespace, '.', `Support`])}.${pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name)))}`,
        enum: {
          ...schema.details.default.enum,
          name: pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name))),
          values: schema.details.default.enum.values.map(each => {
            return {
              ...each,
              name: pascalCase(fixLeadingNumber(deconstruct(each.name))),
              description: each.description
            };
          })
        }
      };
    } else {
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: '<INVALID_INTERFACE>',
        name: schemaName,
        namespace: '<INVALID_NAMESPACE>',
        fullname: '<INVALID_FULLNAME>'
      };
    }

    for (const propertySchema of values(schema.properties)) {
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

      if (propertyDetails.isNamedStream) {
        propertySchema.details.csharp.namedStreamPropertyName = pascalCase(fixLeadingNumber([...deconstruct(propertyDetails.name), 'filename']));
      }
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

    for (const responses of values(operation.responses)) {
      // per responseCode
      for (const response of values(responses)) {
        const responseTypeDefinition = response.schema ? resolver.resolveTypeDeclaration(<any>response.schema, true, new ModelState(service, codeModel, `?`, ['schemas', response.schema.details.default.name])) : undefined;
        const headerTypeDefinition = response.headerSchema ? resolver.resolveTypeDeclaration(<any>response.headerSchema, true, new ModelState(service, codeModel, `?`, ['schemas', response.headerSchema.details.default.name])) : undefined;

        const code = (System.Net.HttpStatusCode[response.responseCode].value || '').replace('System.Net.HttpStatusCode', '') || response.responseCode;
        let rawValue = code.replace(/\./, '');
        if (rawValue === 'default') {
          rawValue = `any response code not handled elsewhere`;
        }
        response.details.csharp = {
          ...response.details.default,
          responseType: responseTypeDefinition ? responseTypeDefinition.declaration : '',
          headerType: headerTypeDefinition ? headerTypeDefinition.declaration : '',
          name: (length(responses) <= 1) ?
            camelCase(fixLeadingNumber(deconstruct(`on ${code}`))) : // the common type (or the only one.)
            camelCase(fixLeadingNumber(deconstruct(`on ${code} ${response.mimeTypes[0]}`))),
          description: (length(responses) <= 1) ?
            `a delegate that is called when the remote service returns ${response.responseCode} (${rawValue}).` :
            `a delegate that is called when the remote service returns ${response.responseCode} (${rawValue}) with a Content-Type matching ${response.mimeTypes.join(',')}.`

        };
      }
    }
  }
  /* IN PROGRESS : GS01

    for (const each of values(codeModel.schemas).linq.where(each => !!each.details.csharp.virtualProperties)) {
      // on models that have virtual properties, we're going to set nice c# names for each of them.
      const virtualProperties = <Dictionary<VirtualProperty>>each.details.csharp.virtualProperties;

      const mine = items(virtualProperties).linq.where(each => each.value.kind === 'my-property').linq.toArray();
      const parents = items(virtualProperties).linq.where(each => each.value.kind === 'parent-property').linq.toArray();
      const children = items(virtualProperties).linq.where(each => each.value.kind === 'child-property').linq.toArray();

      // our new virtual properties go here.
      const newVirtualProperties = new Dictionary<VirtualProperty>();

      // my properties (easy)
      for (const kv of values(mine)) {
        // strategy: use the least amount of things from 'propertyName' starting with the end.
        let name = '';
        for (let i = kv.value.propertyName.length; i > 0; i--) {
          name = `${name}${toPascal(kv.value.propertyName[i - 1])}`;
          if (!newVirtualProperties[name]) {
            // we've found a name that's not taken yet.
            newVirtualProperties[name] = {
              ...kv.value,
              implementation: ''
            }
            break;
          }
        }
      }

      // parent properties (easy-ish)
      for (const kv of values(parents)) {
        // strategy: use the least amount of things from 'propertyName' starting with the end.
        let name = '';
        for (let i = kv.value.propertyName.length; i > 0; i--) {
          name = `${name}${toPascal(kv.value.propertyName[i - 1])}`;
          if (!newVirtualProperties[name]) {
            // we've found a name that's not taken yet.
            newVirtualProperties[name] = {
              ...kv.value,
              implementation: '$PARENT.'
            }
          }
        }
      }
    }
   */
  return codeModel;
}
