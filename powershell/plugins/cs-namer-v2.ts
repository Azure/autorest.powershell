/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codeModelSchema, SchemaResponse, CodeModel, Schema, ObjectSchema, GroupSchema, isObjectSchema, SchemaType, GroupProperty, ParameterLocation, Operation, Parameter, VirtualParameter, getAllProperties, ImplementationLocation, OperationGroup, Request, SchemaContext } from '@azure-tools/codemodel';
//import { codemodel, JsonType, ModelState, processCodeModel, VirtualProperty } from '@azure-tools/codemodel-v3';
import { ModelState } from '@azure-tools/codemodel-v3';
import { camelCase, deconstruct, excludeXDash, fixLeadingNumber, pascalCase, lowest, maximum, minimum, getPascalIdentifier, serialize } from '@azure-tools/codegen';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { System } from '@azure-tools/codegen-csharp';

import { Channel, Host, Session, startSession } from '@azure-tools/autorest-extension-base';
import { SchemaDetails } from '../llcsharp/code-model';
import { SchemaDefinitionResolver, NewSchemaDefinitionResolver } from '../llcsharp/schema/schema-resolver';
import { PwshModel } from '../utils/PwshModel';
import { NewModelState } from '../utils/model-state';

type State = NewModelState<PwshModel>;


function setPropertyNames(schema: Schema) {
  // name each property in this schema
  // skip-for-time-being
  // for (const propertySchema of values(schema.properties)) {
  //   const propertyDetails = propertySchema.details.default;

  //   const className = schema.details.csharp.name;

  //   let pname = getPascalIdentifier(propertyDetails.name);
  //   if (pname === className) {
  //     pname = `${pname}Property`;
  //   }

  //   if (pname === 'default') {
  //     pname = '@default';
  //   }

  //   propertySchema.details.csharp = {
  //     ...propertyDetails,
  //     name: pname // and so are the propertyNmaes
  //   };

  //   if (propertyDetails.isNamedStream) {
  //     propertySchema.details.csharp.namedStreamPropertyName = pascalCase(fixLeadingNumber([...deconstruct(propertyDetails.name), 'filename']));
  //   }
  // }

}


function setSchemaNames(schemaGroups: Dictionary<Array<Schema>>, azure: boolean, serviceNamespace: string) {
  const baseNamespace = new Set<string>();
  const subNamespace = new Map<string, Set<string>>();
  // dolauli need to notice this -- schemas in the namespace of the lowest supported api version
  // in Azure Mode, we want to always put schemas into the namespace of the lowest supported apiversion.
  // otherwise, we just want to differientiate with a simple incremental numbering scheme.

  for (const group of values(schemaGroups)) {
    for (const schema of group) {
      let thisNamespace = baseNamespace;
      let thisApiversion = '';

      // create the namespace if required
      if (azure) {
        const metadata = schema.extensions && schema.extensions['x-ms-metadata'];
        if (metadata) {
          const apiVersions = <Array<string> | undefined>metadata.apiVersions;
          if (apiVersions && length(apiVersions) > 0) {
            thisApiversion = minimum(apiVersions);
            thisNamespace = subNamespace.get(thisApiversion) || new Set<string>();
            subNamespace.set(thisApiversion, thisNamespace);
          }
        }
      }

      // for each schema, we're going to set the name
      // to the suggested name, unless we have collisions
      // at which point, we're going to add a number (for now?)
      const details = schema.language.default;
      let schemaName = getPascalIdentifier(details.name);
      const apiName = (!thisApiversion) ? '' : getPascalIdentifier(`Api ${thisApiversion}`);
      const ns = (!thisApiversion) ? [] : ['.', apiName];


      let n = 1;
      while (thisNamespace.has(schemaName)) {
        schemaName = getPascalIdentifier(`${details.name}_${n++}`);
      }
      thisNamespace.add(schemaName);

      // object types.
      if (schema.type === SchemaType.Object) {
        schema.language.csharp = {
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
      } else if (schema.type === SchemaType.String && schema.language.default.enum) {
        // oh, it's an enum type
        // Skip for time-being
        // schema.language.csharp = <SchemaDetails>{
        //   ...details,
        //   interfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(schemaName)])),
        //   name: getPascalIdentifier(schema.language.default.enum.name),
        //   namespace: pascalCase([serviceNamespace, '.', 'Support']),
        //   fullname: `${pascalCase([serviceNamespace, '.', 'Support'])}.${getPascalIdentifier(schema.language.default.enum.name)}`,
        //   enum: {
        //     ...schema.language.default.enum,
        //     name: getPascalIdentifier(schema.language.default.enum.name),
        //     values: schema.language.default.enum.values.map(each => {
        //       return {
        //         ...each,
        //         name: getPascalIdentifier(each.name),
        //         description: each.description
        //       };
        //     })
        //   }
        // };
      } else {
        schema.language.csharp = <SchemaDetails>{
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
      // skip-for-time-being
      // if (schema.details.default.enum) {
      //   schema.details.csharp.enum = {
      //     ...schema.details.default.enum,
      //     name: getPascalIdentifier(schema.details.default.enum.name)
      //   };

      //   // and the value names themselves
      //   for (const value of values(schema.details.csharp.enum.values)) {
      //     value.name = getPascalIdentifier(value.name);
      //   }
      // }
    }
  }

}

async function setOperationNames(state: State, resolver: NewSchemaDefinitionResolver) {
  // keep a list of operation names that we've assigned.
  const operationNames = new Set<string>();
  for (const operationGroup of values(state.model.operationGroups)) {
    for (const operation of values(operationGroup.operations)) {
      const details = operation.language.default;

      // come up with a name
      const oName = getPascalIdentifier(details.name);
      let i = 1;
      let operationName = oName;
      while (operationNames.has(operationName)) {
        // if we have used that name, try again.
        operationName = `${oName}${i++}`;
      }
      operationNames.add(operationName);

      operation.language.csharp = {
        ...details, // inherit
        name: operationGroup.language.default.name + operationName,
      };

      // parameters are camelCased.
      for (const parameter of values(operation.parameters)) {
        const parameterDetails = parameter.language.default;

        let propName = camelCase(fixLeadingNumber(deconstruct(parameterDetails.name)));

        if (propName === 'default') {
          propName = '@default';
        }

        parameter.language.csharp = {
          ...parameterDetails,
          name: propName
        };
      }

      for (const rsp of values(operation.responses)) {
        // per responseCode
        const response = <SchemaResponse>rsp;
        const responseTypeDefinition = response.schema ? resolver.resolveTypeDeclaration(<any>response.schema, true, state) : undefined;
        // const headerTypeDefinition = response.headerSchema ? resolver.resolveTypeDeclaration(<any>response.headerSchema, true, state.path('schemas', response.headerSchema.details.default.name)) : undefined;
        let code = (System.Net.HttpStatusCode[response.protocol.http?.statusCodes[0]] ? System.Net.HttpStatusCode[response.protocol.http?.statusCodes[0]].value : response.protocol.http?.statusCodes[0]).replace('global::System.Net.HttpStatusCode', '');
        let rawValue = code.replace(/\./, '');
        if (response.protocol.http?.statusCodes[0] === 'default' || rawValue === 'default' || '') {
          rawValue = 'any response code not handled elsewhere';
          code = 'default';
        }
        response.language.csharp = {
          ...response.language.default,
          responseType: responseTypeDefinition ? responseTypeDefinition.declaration : '',
          headerType: '',
          name: (length(response.protocol.http?.mimeTypes) <= 1) ?
            camelCase(fixLeadingNumber(deconstruct(`on ${code}`))) : // the common type (or the only one.)
            camelCase(fixLeadingNumber(deconstruct(`on ${code} ${response.protocol.http?.mimeTypes[0]}`))),
          description: (length(response.protocol.http?.mimeTypes) <= 1) ?
            `a delegate that is called when the remote service returns ${response.protocol.http?.statusCodes[0]} (${rawValue}).` :
            `a delegate that is called when the remote service returns ${response.protocol.http?.statusCodes[0]} (${rawValue}) with a Content-Type matching ${response.protocol.http?.mimeTypes.join(',')}.`

        };
      }
    }
  }
}

async function nameStuffRight(state: State): Promise<PwshModel> {
  const resolver = new NewSchemaDefinitionResolver();
  const model = state.model;

  // set the namespace for the service
  const serviceNamespace = await state.getValue('namespace', 'Sample.API');
  const azure = await state.getValue('azure', false) || await state.getValue('azure-arm', false);
  const clientName = getPascalIdentifier(model.language.default.name);

  // dolauli see model.details.csharp for c# related staff
  // set c# client details (name)
  model.language.csharp = {
    ...model.language.default, // copy everything by default
    name: clientName,
    namespace: serviceNamespace,
    fullname: `${serviceNamespace}.${clientName}`
  };

  setSchemaNames(<Dictionary<Array<Schema>>><any>model.schemas, azure, serviceNamespace);
  await setOperationNames(state, resolver);

  return model;
}


export async function csnamerV2(service: Host) {
  // dolauli add names for http operations and schemas
  //return processCodeModel(nameStuffRight, service, 'csnamer');
  //const session = await startSession<PwshModel>(service, {}, codeModelSchema);
  //const result = tweakModelV2(session);
  const state = await new NewModelState<PwshModel>(service).init();
  await service.WriteFile('code-model-v4-csnamer-v2.yaml', serialize(await nameStuffRight(state)), undefined, 'code-model-v4');
}

