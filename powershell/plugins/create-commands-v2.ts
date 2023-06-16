/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { HttpMethod, codeModelSchema, CodeModel, ObjectSchema, GroupSchema, isObjectSchema, SchemaType, GroupProperty, ParameterLocation, Operation, Parameter, VirtualParameter, getAllProperties, ImplementationLocation, OperationGroup, Request, SchemaContext, SchemaResponse } from '@autorest/codemodel';
import { deconstruct, fixLeadingNumber, pascalCase, EnglishPluralizationService, fail, removeSequentialDuplicates, serialize, includeXDash } from '@azure-tools/codegen';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { Schema } from '../llcsharp/exports';
import { Channel, AutorestExtensionHost as Host, Session, startSession } from '@autorest/extension-base';
import { Lazy } from '@azure-tools/tasks';
import { clone } from '@azure-tools/linq';
import { verbs } from '../internal/verbs';
import { PwshModel } from '../utils/PwshModel';
import { IParameter } from '../utils/components';
import { ModelState } from '../utils/model-state';
//import { Schema as SchemaV3 } from '../utils/schema';
import { CommandOperation, CommandOperationType, VirtualParameter as CommandVirtualParameter } from '../utils/command-operation';
import { OperationType } from '../utils/command-operation';
import { Schema as SchemaModel } from '@autorest/codemodel';
import { getResourceNameFromPath } from '../utils/resourceName';
import { hasValidBodyParameters } from '../utils/http-operation';

type State = ModelState<PwshModel>;

const specialWords: { [key: string]: Array<string> } = { in: <Array<string>>['sign'] };

// UNUSED: Moved to plugin-tweak-model.ts in remodeler
// For now, we are not dynamically changing the service-name. Instead, we would figure out a method to change it during the creation of service readme's.
export function titleToAzureServiceName(title: string): string {
  const titleCamelCase = pascalCase(deconstruct(title)).trim();
  const serviceName = titleCamelCase
    // Remove: !StartsWith(Management)AndContains(Management), Client, Azure, Microsoft, APIs, API, REST
    .replace(/(?!^Management)(?=.*)Management|Client|Azure|Microsoft|APIs|API|REST/g, '')
    // Remove: EndsWith(ServiceResourceProvider), EndsWith(ResourceProvider), EndsWith(DataPlane), EndsWith(Data)
    .replace(/ServiceResourceProvider$|ResourceProvider$|DataPlane$|Data$/g, '');
  return serviceName || titleCamelCase;
}

const pluralizationService = new EnglishPluralizationService();
pluralizationService.addWord('Database', 'Databases');
pluralizationService.addWord('database', 'databases');
pluralizationService.addWord('Premise', 'Premises');
pluralizationService.addWord('premise', 'premises');


interface CommandVariant {
  alias: Array<string>;
  verb: string;
  subject: string;
  subjectPrefix: string;
  variant: string;
  action: string;
}

function fn<T>(active: Array<T>, remaining: Array<T>, result: Array<Array<T>>): Array<Array<T>> {
  if (length(active) || length(remaining)) {
    if (length(remaining)) {
      fn([...active, remaining[0]], remaining.slice(1), result);
      fn(active, remaining.slice(1), result);
    } else {
      result.push(active);
    }
  }
  return result;
}
function combinations<T>(elements: Array<T>) {
  return fn([], elements, []);
}

function filterSpecialWords(preposition: string, parts: Array<string>) {
  let start = 0;
  let idx = -1;
  if (specialWords[preposition] !== undefined) {
    do {
      idx = parts.indexOf(preposition, start);
      if (idx <= 0 || !specialWords[preposition].includes(parts[idx - 1])) {
        return idx;
      } else {
        start = idx + 1;
      }
      // eslint-disable-next-line no-constant-condition
    } while (true);
  }
  return parts.indexOf(preposition);
}

function splitOnPreposition(preposition: string, parts: Array<string>) {
  const i = filterSpecialWords(preposition, parts);
  if (i > 0) {
    return [
      parts.slice(0, i),
      parts.slice(i + 1)
    ];
  }
  return undefined;
}

function splitOnAnyPreposition(parts: Array<string>) {
  for (const p of ['with', 'at', 'by', 'for', 'in', 'of']) {
    const result = splitOnPreposition(p, parts);
    if (result && result[0].length > 0) {
      // we found it, let's give it back.
      return result;
    }
  }
  return undefined;
}


export /* @internal */ class Inferrer {
  commonParameters = new Array<string>();
  verbMap!: { [operationIdMethod: string]: string };
  prefix!: string;
  serviceName!: string;
  subjectPrefix!: string;
  isAzure!: boolean;
  supportJsonInput!: boolean;

  constructor(private state: State) {
  }
  async init() {
    this.commonParameters = await this.state.getValue('azure', false) ? [
      // 'resourceGroupName',
      'subscriptionId'
    ] : [];

    this.verbMap = await this.state.getValue('verb-mapping') || {};
    this.isAzure = await this.state.getValue('azure', false);
    this.prefix = await this.state.getValue('prefix');
    this.serviceName = titleToAzureServiceName(await this.state.getValue('service-name'));
    if (this.isAzure) {
      this.supportJsonInput = await this.state.getValue('support-json-input', true);
    }
    else {
      this.supportJsonInput = await this.state.getValue('support-json-input', false);
    }
    this.state.setValue('service-name', this.serviceName);

    this.subjectPrefix = await this.state.getValue('subject-prefix');

    this.state.setValue('isAzure', this.isAzure);
    this.state.setValue('prefix', this.prefix);

    const model = this.state.model;

    this.state.message({
      Channel: Channel.Debug, Text: `[CMDLET-PREFIX] => '${model.language.default.prefix}'`
    });

    model.language.default.serviceName = this.serviceName;
    this.state.message({
      Channel: Channel.Debug, Text: `[SERVICE-NAME] => '${model.language.default.serviceName}'`
    });

    model.language.default.subjectPrefix = this.subjectPrefix;
    this.state.message({
      Channel: Channel.Debug, Text: `[SUBJECT-PREFIX] => '${model.language.default.subjectPrefix}'`
    });

    return this;
  }

  async createCommands() {
    const model = this.state.model;
    this.state.model.commands = <any>{
      operations: new Dictionary<any>(),
      parameters: new Dictionary<any>(),
    };

    this.state.message({ Channel: Channel.Debug, Text: 'detecting high level commands...' });
    for (const operationGroup of values(model.operationGroups)) {
      let hasPatch = false;
      let getOperation: Operation | undefined, putOperation: Operation | undefined;
      let pathLength = -1;
      for (const operation of values(operationGroup.operations)) {
        if (operation.requests?.[0]?.protocol?.http?.method.toLowerCase() === 'patch') {
          hasPatch = true;
        } else if (operation.requests?.[0]?.protocol?.http?.method.toLowerCase() === 'get' && operation.requests?.[0]?.protocol?.http?.path?.length > pathLength) {
          //assign get operation with longest path (make sure it's get not list to getOperation)
          pathLength = operation.requests?.[0]?.protocol?.http?.path?.length;
          getOperation = operation;
        } else if (operation.requests?.[0]?.protocol?.http?.method.toLowerCase() === 'put') {
          putOperation = operation;
        }
        for (const variant of await this.inferCommandNames(operation, operationGroup.$key, this.state)) {
          await this.addVariants(operation.parameters, operation, variant, '', this.state);
        }
      }
      /*
        generate variants for Update(Get+Put) for subjects only if:
        - there is no patch operation
        - there is a get operation
        - there is a put operation
        - get operation path is the same as put operation path
        - there is only one put reqeust schema
        - get operation response schema type is the same as put operation request schema type
      */
      if (!hasPatch
        && getOperation
        && putOperation
        && getOperation.requests?.[0]?.protocol?.http?.path === putOperation?.requests?.[0]?.protocol?.http?.path
        && putOperation.requests?.length == 1) {
        //parameter.protocal.http.in === 'body' probably only applies to open api 2.0
        const schema = putOperation?.requests?.[0]?.parameters?.find(p => p.protocol.http?.in === 'body')?.schema;
        if (schema && [...values(getOperation?.responses), ...values(getOperation?.exceptions)].filter(each => each.protocol?.http?.StatusCode !== 'default' && (<SchemaResponse>each).schema !== schema).length === 0) {
          await this.addVariants(putOperation.parameters, putOperation, this.createCommandVariant('create', [operationGroup.$key], [], this.state.model), '', this.state, [getOperation], CommandOperationType.GetPut);
        }
      }
    }
    // for (const operation of values(model.http.operations)) {
    //   for (const variant of await this.inferCommandNames(operation, this.state)) {
    //     // no common parameters (standard variations)
    //     await this.addVariants(operation.parameters, operation, variant, '', this.state);
    //   }
    // }
    return model;
  }

  inferCommand(operation: Array<string>, group: string, suffix: Array<string> = []): Array<CommandVariant> {
    operation = operation.filter(each => each !== 'all');
    // no instant match 
    switch (length(operation)) {
      case 0:
        throw new Error('Missing operation id?');

      case 1:
        // simple operation, just an id with a single value
        // OPERATION => OPERATION-GROUP
        return [
          this.createCommandVariant(operation[0], [group], suffix, this.state.model)
        ];

      case 2:
        // should try to infer [SUBJECT] and [ACTION] from operation
        if (verbs.has(operation[0])) {
          // [ACTION][SUBJECT]
          return [
            this.createCommandVariant(operation[0], [group, operation[1]], suffix, this.state.model)
          ];
        }
        if (verbs.has(operation[1])) {
          // [SUBJECT][ACTION]
          return [
            this.createCommandVariant(operation[1], [group, operation[0]], suffix, this.state.model)
          ];

        }
        // can't tell which is the [ACTION] -- let's return it the way we used to, 
        // but now let's mention that we are doing that.
        this.state.warning(`Operation ${operation[0]}/${operation[1]} is inferred without finding action.`, [], {});
        return [
          this.createCommandVariant(operation[0], [group, operation[1]], suffix, this.state.model)
        ];

    }
    // three or more words.
    // first, see if it's an 'or'
    const either = splitOnPreposition('or', operation);
    if (either) {
      // looks like we got two sets of operations from this.
      return [
        ...this.inferCommand([...either[0], ...either[1].slice(1)], group, suffix),
        ...this.inferCommand(either[1], group, suffix),
      ];
    }

    // any other preposition?
    const parts = splitOnAnyPreposition(operation);
    if (parts) {
      // so this is something like DoActionWithStyle
      return [...this.inferCommand(parts[0], group, parts[1])];
    }

    // if not, then seek out a verb from there.
    for (let i = 0; i < length(operation); i++) {
      if (verbs.has(operation[i])) {
        // if the action is first
        if (i === 0) {
          // everything else is the subject
          return [this.createCommandVariant(operation[i], group ? [group, ...operation.slice(i + 1)] : operation.slice(i + 1), suffix, this.state.model)];
        }
        if (i === length(operation) - 1) {
          // if it's last, the subject would be the first thing
          return [this.createCommandVariant(operation[i], group ? [group, ...operation.slice(0, i)] : operation.slice(0, i), suffix, this.state.model)];
        }

        // otherwise          
        // things before are part of the subject
        // things after the verb should be part of the suffix
        return [this.createCommandVariant(operation[i], group ? [group, ...operation.slice(i, i)] : operation.slice(i, i), [...suffix, ...operation.slice(i + 1)], this.state.model)];
      }
    }

    // so couldn't tell what the action was.
    // fallback to the original behavior with a warning.
    this.state.warning(`Operation ${operation[0]}/${operation[1]} is inferred without finding action.`, [], {});
    return [this.createCommandVariant(operation[0], group ? [group, ...operation.slice(1)] : operation.slice(1), [...suffix, ...operation.slice(1)], this.state.model)];
  }

  async inferCommandNames(op: Operation, group: string, state: State): Promise<Array<CommandVariant>> {

    const method = op.language.default.name;
    // skip-for-time-being
    // if (!method) {
    //   if (!group) {
    //     // no operation id at all?
    //     const path = op.path.replace(/{.*?}/g, '').replace(/\/+/g, '/').replace(/\/$/g, '');
    //     method = path.split('/').last;
    //   } else {
    //     // no group given, use string as method
    //     method = group;
    //   }
    //   group = pascalCase(op.tags) || '';

    // }

    const groupWords = [...removeSequentialDuplicates(deconstruct(group))];
    groupWords[groupWords.length - 1] = pluralizationService.singularize(groupWords.last);

    group = pascalCase(groupWords);
    const operation = deconstruct(method);

    // instant match
    if (this.verbMap[method]) {
      return [this.createCommandVariant(method, [group], [], state.model)];
    }

    // dig deeper.
    return this.inferCommand(operation, group);
  }

  async addVariant(vname: string, body: Parameter | null, bodyParameterName: string, parameters: Array<Parameter>, operation: Operation, variant: CommandVariant, state: State, preOperations: Array<Operation> | undefined, commandOperationType?: CommandOperationType): Promise<CommandOperation> {
    // beth: filter command description for New/Update command
    const createOrUpdateRegex = /creates? or updates?/gi;
    operation.language.default.description = operation.language.default.description.replace(createOrUpdateRegex, `${variant.action.capitalize()}`);
    const op = await this.addCommandOperation(vname, parameters, operation, variant, state, preOperations, commandOperationType);

    // if this has a body with it, let's add that parameter
    if (body && body.schema) {
      op.details.default.hasBody = true;
      op.parameters.push(new IParameter(bodyParameterName, body.schema, {
        details: {
          default: {
            description: body.schema.language.default.description,
            name: pascalCase(bodyParameterName),
            isBodyParameter: true,
          }
        }
      }));

      // let's add a variant where it's expanded out.
      // *IF* the body is an object or dictionary
      if (body.schema.type === SchemaType.Object || body.schema.type === SchemaType.Dictionary || body.schema.type === SchemaType.Any) {
        const opExpanded = await this.addCommandOperation(`${vname}Expanded`, parameters, operation, variant, state, preOperations, commandOperationType);
        opExpanded.details.default.dropBodyParameter = true;
        opExpanded.parameters.push(new IParameter(`${bodyParameterName}Body`, body.schema, {
          details: {
            default: {
              description: body.schema.language.default.description,
              name: pascalCase(`${bodyParameterName}Body`),
              isBodyParameter: true,
            }
          }
        }));
      }
    }

    return op;
  }

  // skip-for-time-being
  // isNameConflict(model: codemodel.Model, variant: CommandVariant, vname: string) {
  //   for (const each of values(model.commands.operations)) {
  //     if (each.details.default.name === vname) {
  //       return true;
  //     }
  //   }
  //   return false;
  // }

  // for tracking unique operation identities 
  operationIdentities = new Set<string>();

  async addCommandOperation(vname: string, parameters: Array<Parameter>, operation: Operation, variant: CommandVariant, state: State, preOperations: Array<Operation> | undefined, commandOperationType?: CommandOperationType): Promise<CommandOperation> {
    // skip-for-time-being following code seems redundant -----
    // let apiversion = '';

    // for (const each of items(operation.responses)) {
    //   for (const rsp of items(each)) {
    //     if (rsp.schema && rsp.schema.details && rsp.schema.details.default && rsp.schema.details.default.apiversion) {
    //       apiversion = rsp.schema.details.default.apiversion;
    //       break;
    //     }
    //   }
    // }
    // ----------------------------------------------------------

    // if vname is > 64 characters, let's trim it
    // after trimming it, make sure there aren't any other operation with a name that's exactly the same
    if (length(vname) > 64) {
      const names = deconstruct(vname);
      let newVName = '';
      for (let i = 0; i < length(names); i++) {
        newVName = pascalCase(names.slice(0, i));
        if (length(newVName) > 60) {
          break;
        }
      }
      vname = newVName;
    }

    // if we have an identical vname, let's add 'etc'
    let fname = `${variant.verb}-${variant.subject}-${vname}`;
    let n = 1;
    while (this.operationIdentities.has(fname)) {
      vname = `${vname.replace(/\d*$/g, '')}${n++}`;
      fname = `${variant.verb}-${variant.subject}-${vname}`;
    }
    this.operationIdentities.add(fname);

    variant.variant = vname;
    vname = pascalCase(vname);

    let commandName = operation.language.default.name;
    let operations = [operation];
    const language = { default: { ...operation.language.default } };
    //handle when there are pre operataions
    if (preOperations && preOperations.length > 0) {
      commandName = 'Update';
      language.default.name = 'Update';
      operations = [...preOperations, ...operations];
    }

    // skip-for-time-being x-ms-metadata looks not supported any more.
    //const xmsMetadata = operation.pathExtensions ? operation.pathExtensions['x-ms-metadata'] ? clone(operation.pathExtensions['x-ms-metadata']) : {} : {};
    // Add operation type to support x-ms-mutability
    let operationType = OperationType.Other;
    if (operation.requests) {
      if (operation.requests[0].protocol.http?.method === 'put' && variant.action.toLowerCase() === 'create') {
        operationType = OperationType.Create;
      } else if (operation.requests[0].protocol.http?.method === 'patch' || operation.requests[0].protocol.http?.method === 'put' && variant.action.toLowerCase() === 'update') {
        operationType = OperationType.Update;
      }
    }
    return state.model.commands.operations[`${length(state.model.commands.operations)}`] = new CommandOperation(commandName,
      {
        asjob: language.default.asjob ? true : false,
        operationType: operationType,
        extensions: {

        },
        ...variant,
        details: {
          ...language,
          default: {
            ...language.default,
            subject: variant.subject,
            subjectPrefix: variant.subjectPrefix,
            verb: variant.verb,
            name: vname,
            alias: variant.alias,
            externalDocs: operation.externalDocs
          }
        },
        // operationId is not needed any more
        operationId: '',
        parameters: parameters.map(httpParameter => {
          // make it's own copy of the parameter since after this, 
          // the parameter can be altered for each operation individually.
          const each = clone(httpParameter, false, undefined, undefined, ['schema', 'origin']);
          each.language.default = {
            ...each.language.default,
            name: pascalCase(each.language.default.name),
            httpParameter
          };
          each.details = {};
          each.details.default = {
            ...each.language.default,
            name: pascalCase(each.language.default.name),
            httpParameter
          };
          each.name = each.language.default.serializedName;
          return each;
        }),
        // skip-for-time-being, this callGraph is used in the header comments
        callGraph: operations
      },
      commandOperationType);
  }

  async addVariants(parameters: Array<Parameter> | undefined, operation: Operation, variant: CommandVariant, vname: string, state: State, preOperations?: Array<Operation>, commandOperationType?: CommandOperationType) {
    // now synthesize parameter set variants multiplexed by the variants.
    const [constants, requiredParameters] = values(parameters).bifurcate(parameter => parameter.language.default.constantValue || parameter.language.default.fromHost ? true : false);
    const constantParameters = constants.map(each => `'${each.language.default.constantValue}'`);

    // the body parameter
    // xichen: How to handle if has multiple requests?
    const body = operation.requests?.[0].parameters?.find((p) => !p.origin || p.origin.indexOf('modelerfour:synthesized') < 0) || null;
    // skip-for-time-being, looks x-ms-requestBody-name is not supported any more
    //const bodyParameterName = (operation.requestBody && operation.requestBody.extensions) ? operation.requestBody.extensions['x-ms-requestBody-name'] || 'bodyParameter' : '';
    const bodyParameterName = body ? body.language.default.name : '';

    // all the properties in the body parameter
    const bodyProperties = (body && body.schema && isObjectSchema(body.schema)) ? values(getAllProperties(body.schema)).where(property => !property.language.default.readOnly).toArray() : [];

    // smash body property names together
    const bodyPropertyNames = bodyProperties.joinWith(each => each.language.default.name);

    // for each polymorphic body, we should do a separate variant that takes the polymorphic body type instead of the base type
    // skip-for-time-being, this is for polymorphism
    //const polymorphicBodies = (body && body.schema && body.schema.details.default.polymorphicChildren && length(body.schema.details.default.polymorphicChildren)) ? (<Array<Schema>>body.schema.details.default.polymorphicChildren).joinWith(child => child.details.default.name) : '';

    // wait! "update" should be "set" if it's a PUT
    if (variant.verb === 'Update' && operation.requests && operation.requests[0].protocol?.http?.method === HttpMethod.Put) {
      variant.verb = 'Set';
    }
    //for operations which has pre operations (only support GET+PUT for now), change it's action to update
    if (preOperations && preOperations.length > 0) {
      variant.action = variant.verb = 'Update';
    }
    // create variant 
    // skip-for-time-being, since operationId looks not included in m4.
    //state.message({ Channel: Channel.Debug, Text: `${variant.verb}-${variant.subject} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${bodyPropertyNames} ${polymorphicBodies ? `; Polymorphic bodies: ${polymorphicBodies} ` : ''}` });
    await this.addVariant(pascalCase([variant.action, vname]), body, bodyParameterName, [...constants, ...requiredParameters], operation, variant, state, preOperations, commandOperationType);

    if (await state.getValue('disable-via-identity', false)) {
      return;
    }

    // eslint-disable-next-line prefer-const
    let [pathParams, otherParams] = values(requiredParameters).bifurcate(each => each?.protocol?.http?.in === ParameterLocation.Path);
    //exclude subscriptionId and resourceGroupName from path parameters
    pathParams = pathParams.filter(pathParam => !this.reservedPathParam.has(pathParam.language.default.name));
    //if parent pipline input is disabled, only generate identity for current resource itself
    if (!await state.getValue('enable-parent-pipeline-input', this.isAzure)) {
      if (length(pathParams) > 0 && variant.action.toLowerCase() != 'list') {
        await this.addVariant(pascalCase([variant.action, vname, 'via-identity']), body, bodyParameterName, [...constants, ...otherParams], operation, variant, state, preOperations, commandOperationType);
      }
      return;
    }

    const disableGetEnableList = await this.state.getValue('enable-parent-pipeline-input-for-list', true);
    /*
      for resource /A1/A2/.../An-1/An, generate variants that take
        ViaIdentity: An as identity
        ViaIdentity{An-1}: An-1 as identity + An Name
        ...
        ViaIdentity{A1}: A1 as identity + [A2 + A3 + ... + An-1 + An] Names
    */
    for (let i = pathParams.length - 1; i >= 0; i--) {
      if ((!disableGetEnableList && variant.action.toLowerCase() === 'list') || (disableGetEnableList && i === pathParams.length - 1 && variant.action.toLowerCase() === 'get')) {
        continue;
      }
      let resourceName = getResourceNameFromPath(operation.requests?.[0].protocol.http?.path, pathParams[i].language.default.name, true);
      //cannot get resource name from path, give up generate ViaIdentity variant
      if (!resourceName) {
        break;
      }

      //variant for current resource is simply named ViaIdentity otherwise ViaIdentity${resourceName}
      if (i === pathParams.length - 1 && variant.action.toLowerCase() !== 'list') {
        resourceName = '';
      }
      await this.addVariant(pascalCase([variant.action, vname, `via-identity${resourceName}`]), body, bodyParameterName, [...constants, ...otherParams, ...pathParams.slice(i + 1)], operation, variant, state, preOperations, commandOperationType);
    }

    if (this.supportJsonInput && hasValidBodyParameters(operation) && !commandOperationType) {
      const createStringParameter = (name: string, description: string, serializedName: string): IParameter => {
        const schema = new SchemaModel(name, description, SchemaType.String);
        const language = {
          default: {
            name: name,
            description: description,
            serializedName: serializedName,
          },
        };
        schema.language = language;
        const httpParameter = {
          implementation: 'Method',
          language: language,
          schema: schema,
          required: true,
        };
        const parameter = new IParameter(name, schema, {
          description: description,
          required: true,
          details: {
            default: {
              description: description,
              name: name,
              isBodyParameter: false,
              httpParameter: httpParameter,
            },
          },
          schema: schema,
          allowEmptyValue: false,
          deprecated: false,
        });
        (<any>parameter).httpParameter = httpParameter;
        return parameter;
      };
      const jsonVariant = pascalCase([variant.action, vname]);
      const parameter = new IParameter(`${bodyParameterName}Body`, body!.schema, {
        details: {
          default: {
            description: body!.schema.language.default.description,
            name: pascalCase(`${bodyParameterName}Body`),
            isBodyParameter: true,
          }
        }
      });
      const opJsonString = await this.addVariant(`${jsonVariant}ViaJsonString`, null, '', [...constants, ...requiredParameters], operation, variant, state, preOperations, commandOperationType);
      opJsonString.details.default.dropBodyParameter = true;
      opJsonString.parameters = opJsonString.parameters.filter(each => each.details.default.isBodyParameter !== true);
      opJsonString.parameters.push(createStringParameter('JsonString', `Json string supplied to the ${jsonVariant} operation`, 'jsonString'));
      opJsonString.parameters.push(parameter);
      opJsonString.details.default.dropBodyParameter = true;

      const opJsonFilePath = await this.addVariant(`${jsonVariant}ViaJsonFilePath`, null, '', [...constants, ...requiredParameters], operation, variant, state, preOperations, commandOperationType);
      opJsonFilePath.details.default.dropBodyParameter = true;
      opJsonFilePath.parameters = opJsonFilePath.parameters.filter(each => each.details.default.isBodyParameter !== true);
      opJsonFilePath.parameters.push(createStringParameter('JsonFilePath', `Path of Json file supplied to the ${jsonVariant} operation`, 'jsonFilePath'));
      opJsonFilePath.parameters.push(parameter);
      opJsonFilePath.details.default.dropBodyParameter = true;
    }
  }

  reservedPathParam = new Set<string>(['SubscriptionId', 'resourceGroupName']);

  createCommandVariant(action: string, subject: Array<string>, variant: Array<string>, model: PwshModel): CommandVariant {
    const verb = this.getPowerShellVerb(action);
    if (verb === 'Invoke') {
      // if the 'operation' name was  "post" -- it's kindof redundant.
      // so, only include the operation name in the group name if it's anything else
      if (action.toLowerCase() !== 'post') {
        subject = [action, ...subject];
      }
    }

    return {
      alias: [],
      subject: pascalCase([...removeSequentialDuplicates(subject.map(each => pluralizationService.singularize(each)))]),
      variant: pascalCase(variant),
      verb,
      subjectPrefix: model.language.default.subjectPrefix,
      action
    };
  }

  getPowerShellVerb(action: string): string {
    const verb = this.verbMap[pascalCase(action)];
    if (verb) {
      return verb;
    } else {
      return 'Invoke';
    }
  }
}


export async function createCommandsV2(service: Host) {
  // return processCodeModel(commandCreator, service);
  //const session = await startSession<PwshModel>(service, {}, codeModelSchema);
  //const result = tweakModelV2(session);
  const state = await new ModelState<PwshModel>(service).init();
  await service.writeFile({ filename: 'code-model-v4-createcommands-v2.yaml', content: serialize(await (await new Inferrer(state).init()).createCommands()), sourceMap: undefined, artifactType: 'code-model-v4' });

  // return processCodeModel(async (state) => {
  //   return await (await new Inferrer(state).init()).createCommands();
  // }, service, 'createCommands-v2');
}