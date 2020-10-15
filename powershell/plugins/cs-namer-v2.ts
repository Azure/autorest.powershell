/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codeModelSchema, SchemaResponse, CodeModel, Schema, ObjectSchema, GroupSchema, isObjectSchema, SchemaType, GroupProperty, ParameterLocation, Operation, Parameter, VirtualParameter, getAllProperties, ImplementationLocation, OperationGroup, Request, SchemaContext, StringSchema, ChoiceSchema, SealedChoiceSchema } from '@azure-tools/codemodel';
import { camelCase, deconstruct, excludeXDash, fixLeadingNumber, pascalCase, lowest, maximum, minimum, getPascalIdentifier, serialize } from '@azure-tools/codegen';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { System } from '@azure-tools/codegen-csharp';

import { Channel, Host, Session, startSession } from '@azure-tools/autorest-extension-base';
import { SchemaDetails } from '../llcsharp/code-model';
import { NewSchemaDefinitionResolver } from '../llcsharp/schema/schema-resolver';
import { PwshModel } from '../utils/PwshModel';
import { ModelState } from '../utils/model-state';
import { SchemaDetails as NewSchemaDetails } from '../utils/schema';

type State = ModelState<PwshModel>;


function setPropertyNames(schema: Schema) {
  // name each property in this schema
  // skip-for-time-being
  if (!isObjectSchema(schema)) {
    return;
  }
  for (const propertySchema of values(schema.properties)) {
    const propertyDetails = propertySchema.language.default;
    propertyDetails.required = propertySchema.required ?? false;
    propertyDetails.readOnly = propertySchema.readOnly ?? false;

    const className = schema.language.csharp?.name;

    let pname = getPascalIdentifier(propertyDetails.name);
    if (pname === className) {
      pname = `${pname}Property`;
    }

    if (pname === 'default') {
      pname = '@default';
    }

    propertySchema.language.csharp = {
      ...propertyDetails,
      name: pname // and so are the propertyNmaes
    };

    if (propertyDetails.isNamedStream) {
      propertySchema.language.csharp.namedStreamPropertyName = pascalCase(fixLeadingNumber([...deconstruct(propertyDetails.name), 'filename']));
    }
  }

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
        const versions = [...values(schema.apiVersions).select(v => v.version)];
        if (schema.language.default?.uid !== 'universal-parameter-type') {
          if (versions && length(versions) > 0) {
            thisApiversion = minimum(versions);
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
      if (schema.type === SchemaType.Object || schema.type === SchemaType.Dictionary || schema.type === SchemaType.Any) {
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
      } else if (schema.type === SchemaType.Choice || schema.type === SchemaType.SealedChoice) {
        // oh, it's an enum type
        const choiceSchema = <ChoiceSchema<StringSchema> | SealedChoiceSchema<StringSchema>>schema;
        schema.language.csharp = <SchemaDetails>{
          ...details,
          interfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(schemaName)])),
          name: getPascalIdentifier(schemaName),
          namespace: pascalCase([serviceNamespace, '.', 'Support']),
          fullname: `${pascalCase([serviceNamespace, '.', 'Support'])}.${getPascalIdentifier(schemaName)}`,
          enum: {
            ...schema.language.default.enum,
            name: getPascalIdentifier(schema.language.default.name),
            values: choiceSchema.choices.map(each => {
              return {
                ...each,
                name: getPascalIdentifier(each.language.default.name),
                description: each.language.default.description
              };
            })
          }
        };
      } else {
        schema.language.csharp = <SchemaDetails>{
          ...details,
          interfaceName: '<INVALID_INTERFACE>',
          internalInterfaceName: '<INVALID_INTERFACE>',
          name: schemaName,
          namespace: '<INVALID_NAMESPACE>',
          fullname: '<INVALID_FULLNAME>'
        };
        // xichen: for invalid namespace case, we won't create model class. So we do not need consider dup case
        thisNamespace.delete(schemaName);
      }

      // name each property in this schema
      setPropertyNames(schema);

      // fix enum names
      if (schema.type === SchemaType.Choice || schema.type === SchemaType.SealedChoice) {
        schema.language.csharp.enum.name = getPascalIdentifier(schema.language.default.name);

        // and the value names themselves
        for (const value of values(schema.language.csharp.enum.values)) {
          // In m3, enum.name and enum.value are same. But in m4, enum.name is named by m4.
          // To keep same action as m3, use enum.value here
          (<any>value).name = getPascalIdentifier((<any>value).value);
        }
      }
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
      const oName = getPascalIdentifier(operationGroup.$key + '_' + details.name);
      let i = 1;
      let operationName = oName;
      while (operationNames.has(operationName)) {
        // if we have used that name, try again.
        operationName = `${oName}${i++}`;
      }
      operationNames.add(operationName);

      operation.language.csharp = {
        ...details, // inherit
        name: operationName,
      };

      // parameters are camelCased.
      for (const parameter of values(operation.parameters)) {
        const parameterDetails = parameter.language.default;

        let propName = camelCase(fixLeadingNumber(deconstruct(parameterDetails.serializedName)));

        if (propName === 'default') {
          propName = '@default';
        }

        parameter.language.csharp = {
          ...parameterDetails,
          name: propName
        };
      }

      const responses = [...values(operation.responses), ...values(operation.exceptions)];

      for (const rsp of responses) {
        // per responseCode
        const response = <SchemaResponse>rsp;
        const responseTypeDefinition = response.schema ? resolver.resolveTypeDeclaration(<any>response.schema, true, state) : undefined;
        const headerSchema = response.language.default.headerSchema;
        const headerTypeDefinition = headerSchema ? resolver.resolveTypeDeclaration(<any>headerSchema, true, state.path('schemas', headerSchema.language.default.name)) : undefined;
        let code = (System.Net.HttpStatusCode[response.protocol.http?.statusCodes[0]] ? System.Net.HttpStatusCode[response.protocol.http?.statusCodes[0]].value : response.protocol.http?.statusCodes[0]).replace('global::System.Net.HttpStatusCode', '');
        let rawValue = code.replace(/\./, '');
        if (response.protocol.http?.statusCodes[0] === 'default' || rawValue === 'default' || '') {
          rawValue = 'any response code not handled elsewhere';
          code = 'default';
          response.language.default.isErrorResponse = true;
        }
        response.language.csharp = {
          ...response.language.default,
          responseType: responseTypeDefinition ? responseTypeDefinition.declaration : '',
          headerType: headerTypeDefinition ? headerTypeDefinition.declaration : '',
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
  const state = await new ModelState<PwshModel>(service).init();
  await service.WriteFile('code-model-v4-csnamer-v2.yaml', serialize(await nameStuffRight(state)), undefined, 'code-model-v4');
}

