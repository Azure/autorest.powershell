/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, JsonType, ModelState, processCodeModel, VirtualProperty } from '@azure-tools/codemodel-v3';

import { camelCase, deconstruct, excludeXDash, fixLeadingNumber, pascalCase, lowest, maximum, minimum, getPascalIdentifier } from '@azure-tools/codegen';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { System } from '@azure-tools/codegen-csharp';

import { Host } from '@azure-tools/autorest-extension-base';
import { Schema, SchemaDetails } from './code-model';
import { SchemaDefinitionResolver } from './schema/schema-resolver';

type State = ModelState<codemodel.Model>;


function setPropertyNames(schema: Schema) {
  // name each property in this schema
  for (const propertySchema of values(schema.properties)) {
    const propertyDetails = propertySchema.details.default;

    const className = schema.details.csharp.name;

    let pname = getPascalIdentifier(propertyDetails.name);
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

}


function setSchemaNames(schemas: Dictionary<Schema>, azure: boolean, serviceNamespace: string) {
  const baseNamespace = new Set<string>();
  const subNamespace = new Map<string, Set<string>>();

  // in Azure Mode, we want to always put schemas into the namespace of the lowest supported apiversion.
  // otherwise, we just want to differientiate with a simple incremental numbering scheme.

  for (const schema of values(schemas)) {
    let thisNamespace = baseNamespace;
    let thisApiversion = '';

    // create the namespace if required
    if (azure) {
      const metadata = schema.extensions['x-ms-metadata'];
      if (metadata) {
        const apiVersions = <Array<string> | undefined>metadata.apiVersions;
        if (apiVersions && apiVersions.length > 0) {
          thisApiversion = minimum(apiVersions);
          thisNamespace = subNamespace.get(thisApiversion) || new Set<string>();
          subNamespace.set(thisApiversion, thisNamespace);
        }
      }
    }

    // for each schema, we're going to set the name
    // to the suggested name, unless we have collisions
    // at which point, we're going to add a number (for now?)
    const details = schema.details.default;
    let schemaName = getPascalIdentifier(details.name);
    const apiName = (!thisApiversion) ? '' : getPascalIdentifier(`Api ${thisApiversion}`);
    const ns = (!thisApiversion) ? [] : ['.', apiName];


    let n = 1;
    while (thisNamespace.has(schemaName)) {
      schemaName = getPascalIdentifier(`${details.name}_${n++}`);
    }
    thisNamespace.add(schemaName);

    // object types.
    if (schema.type === JsonType.Object) {
      schema.details.csharp = <SchemaDetails>{
        ...details,
        apiversion: thisApiversion,
        apiname: apiName,
        interfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(schemaName)])), // objects have an interfaceName
        internalInterfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(schemaName), 'Internal'])), // objects have an ineternal interfaceName for setting private members. 
        fullInternalInterfaceName: `${pascalCase([serviceNamespace, '.', 'Models', ...ns])}.${pascalCase(fixLeadingNumber(['I', ...deconstruct(schemaName), 'Internal']))}`,
        name: getPascalIdentifier(schemaName),
        namespace: pascalCase([serviceNamespace, '.', 'Models', ...ns]),  // objects have a namespace
        fullname: `${pascalCase([serviceNamespace, '.', 'Models', ...ns])}.${getPascalIdentifier(schemaName)}`,
      };
    } else if (schema.type === JsonType.String && schema.details.default.enum) {
      // oh, it's an enum type
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(schemaName)])),
        name: getPascalIdentifier(schema.details.default.enum.name),
        namespace: pascalCase([serviceNamespace, '.', 'Support']),
        fullname: `${pascalCase([serviceNamespace, '.', 'Support'])}.${getPascalIdentifier(schema.details.default.enum.name)}`,
        enum: {
          ...schema.details.default.enum,
          name: getPascalIdentifier(schema.details.default.enum.name),
          values: schema.details.default.enum.values.map(each => {
            return {
              ...each,
              name: getPascalIdentifier(each.name),
              description: each.description
            };
          })
        }
      };
    } else {
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: '<INVALID_INTERFACE>',
        internalInterfaceName: '<INVALID_INTERFACE>',
        name: schemaName,
        namespace: '<INVALID_NAMESPACE>',
        fullname: '<INVALID_FULLNAME>'
      };
    }

    // name each property in this schema
    setPropertyNames(<Schema><any>schema);

    // fix enum names
    if (schema.details.default.enum) {
      schema.details.csharp.enum = {
        ...schema.details.default.enum,
        name: getPascalIdentifier(schema.details.default.enum.name)
      };

      // and the value names themselves
      for (const value of values(schema.details.csharp.enum.values)) {
        value.name = getPascalIdentifier(value.name);
      }
    }
  }

}

async function setOperationNames(state: State, resolver: SchemaDefinitionResolver) {
  // keep a list of operation names that we've assigned.
  const operationNames = new Set<string>();

  for (const operation of values(state.model.http.operations)) {
    const details = operation.details.default;

    // come up with a name
    const oName = getPascalIdentifier(details.name);
    let i = 1;
    let operationName = oName;
    while (operationNames.has(operationName)) {
      // if we have used that name, try again.
      operationName = `${oName}${i++}`;
    }
    operationNames.add(operationName);

    operation.details.csharp = {
      ...details, // inherit
      name: operationName,
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
        const responseTypeDefinition = response.schema ? resolver.resolveTypeDeclaration(<any>response.schema, true, state.path('schemas', response.schema.details.default.name)) : undefined;
        const headerTypeDefinition = response.headerSchema ? resolver.resolveTypeDeclaration(<any>response.headerSchema, true, state.path('schemas', response.headerSchema.details.default.name)) : undefined;
        let code = (System.Net.HttpStatusCode[response.responseCode] ? System.Net.HttpStatusCode[response.responseCode].value : response.responseCode).replace('global::System.Net.HttpStatusCode', '');
        let rawValue = code.replace(/\./, '');
        if (response.responseCode === 'default' || rawValue === 'default' || '') {
          rawValue = 'any response code not handled elsewhere';
          code = 'default';
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
}

async function nameStuffRight(state: State): Promise<codemodel.Model> {
  const resolver = new SchemaDefinitionResolver();
  const model = state.model;

  // set the namespace for the service
  const serviceNamespace = await state.getValue('namespace', 'Sample.API');
  const azure = await state.getValue('azure', false) || await state.getValue('azure-arm', false);
  const clientName = getPascalIdentifier(model.details.default.name);

  // set c# client details (name)
  model.details.csharp = {
    ...model.details.default, // copy everything by default
    name: clientName,
    namespace: serviceNamespace,
    fullname: `${serviceNamespace}.${clientName}`
  };

  setSchemaNames(<Dictionary<Schema>><any>model.schemas, azure, serviceNamespace);
  await setOperationNames(state, resolver);

  return model;
}


export async function csnamer(service: Host) {
  return processCodeModel(nameStuffRight, service, 'csnamer');
}

