/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { HttpMethod, codeModelSchema, CodeModel, ObjectSchema, GroupSchema, isObjectSchema, SchemaType, GroupProperty, ParameterLocation, Operation, Parameter, VirtualParameter, getAllProperties, ImplementationLocation, OperationGroup, Request, SchemaContext } from '@azure-tools/codemodel';
//import { JsonType, processCodeModel, codemodel, components, command, http, getAllProperties, ModelState, ParameterLocation, } from '@azure-tools/codemodel-v3';
import { deconstruct, fixLeadingNumber, pascalCase, EnglishPluralizationService, fail, removeSequentialDuplicates, serialize } from '@azure-tools/codegen';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { Schema } from '../llcsharp/exports';
import { Channel, Host, Session, startSession } from '@azure-tools/autorest-extension-base';
import { Lazy } from '@azure-tools/tasks';
import { clone } from '@azure-tools/linq';
import { verbs } from '../internal/verbs';
import { PwshModel } from '../utils/PwshModel';
import { IParameter } from '../utils/components';
import { NewModelState } from '../utils/model-state';
//import { Schema as SchemaV3 } from '../utils/schema';
import { CommandOperation } from '../utils/command-operation';

type State = NewModelState<PwshModel>;


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

function splitOnPreposition(preposition: string, parts: Array<string>) {
  const i = parts.indexOf(preposition);
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
      for (const operation of values(operationGroup.operations)) {
        for (const variant of await this.inferCommandNames(operation, operationGroup.$key, this.state)) {
          await this.addVariants(operation.parameters, operation, variant, '', this.state);
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
          this.createCommandVariant(operation[0], deconstruct(group), suffix, this.state.model)
        ];

      case 2:
        // should try to infer [SUBJECT] and [ACTION] from operation
        if (verbs.has(operation[0])) {
          // [ACTION][SUBJECT]
          return [
            this.createCommandVariant(operation[0], [...deconstruct(group), operation[1]], suffix, this.state.model)
          ];
        }
        if (verbs.has(operation[1])) {
          // [SUBJECT][ACTION]
          return [
            this.createCommandVariant(operation[1], [...deconstruct(group), operation[0]], suffix, this.state.model)
          ];

        }
        // can't tell which is the [ACTION] -- let's return it the way we used to, 
        // but now let's mention that we are doing that.
        this.state.warning(`Operation ${operation[0]}/${operation[1]} is inferred without finding action.`, [], {});
        return [
          this.createCommandVariant(operation[0], [...deconstruct(group), operation[1]], suffix, this.state.model)
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
          return [this.createCommandVariant(operation[i], group ? [...deconstruct(group), ...operation.slice(i + 1)] : operation.slice(i + 1), suffix, this.state.model)];
        }
        if (i === length(operation) - 1) {
          // if it's last, the subject would be the first thing
          return [this.createCommandVariant(operation[i], group ? [...deconstruct(group), ...operation.slice(0, i)] : operation.slice(0, i), suffix, this.state.model)];
        }

        // otherwise          
        // things before are part of the subject
        // things after the verb should be part of the suffix
        return [this.createCommandVariant(operation[i], group ? [...deconstruct(group), ...operation.slice(i, i)] : operation.slice(i, i), [...suffix, ...operation.slice(i + 1)], this.state.model)];
      }
    }

    // so couldn't tell what the action was.
    // fallback to the original behavior with a warning.
    this.state.warning(`Operation ${operation[0]}/${operation[1]} is inferred without finding action.`, [], {});
    return [this.createCommandVariant(operation[0], group ? [...deconstruct(group), ...operation.slice(1)] : operation.slice(1), [...suffix, ...operation.slice(1)], this.state.model)];
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

    const groupWords = deconstruct(group);
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

  async addVariant(vname: string, body: Parameter | null, bodyParameterName: string, parameters: Array<Parameter>, operation: Operation, variant: CommandVariant, state: State) {
    const op = await this.addCommandOperation(vname, parameters, operation, variant, state);

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
      if (body.schema.type === SchemaType.Object || body.schema.type === SchemaType.Dictionary) {
        const opExpanded = await this.addCommandOperation(`${vname}Expanded`, parameters, operation, variant, state);
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

  async addCommandOperation(vname: string, parameters: Array<Parameter>, operation: Operation, variant: CommandVariant, state: State): Promise<CommandOperation> {
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
    // skip-for-time-being x-ms-metadata looks not supported any more.
    //const xmsMetadata = operation.pathExtensions ? operation.pathExtensions['x-ms-metadata'] ? clone(operation.pathExtensions['x-ms-metadata']) : {} : {};

    return state.model.commands.operations[`${length(state.model.commands.operations)}`] = new CommandOperation(operation.language.default.name, {
      asjob: operation.language.default.asjob ? true : false,
      extensions: {

      },
      ...variant,
      details: {
        ...operation.language,
        default: {
          ...operation.language.default,
          subject: variant.subject,
          subjectPrefix: variant.subjectPrefix,
          verb: variant.verb,
          name: vname,
          alias: variant.alias
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
      callGraph: [operation],
    });
  }

  async addVariants(parameters: Array<Parameter> | undefined, operation: Operation, variant: CommandVariant, vname: string, state: State) {
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

    // wait! "update" should be "set" if it's a POST
    if (variant.verb === 'Update' && operation.requests && operation.requests[0].protocol?.http?.method === HttpMethod.Put) {
      variant.verb = 'Set';
    }

    // create variant 
    // skip-for-time-being, since operationId looks not included in m4.
    //state.message({ Channel: Channel.Debug, Text: `${variant.verb}-${variant.subject} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${bodyPropertyNames} ${polymorphicBodies ? `; Polymorphic bodies: ${polymorphicBodies} ` : ''}` });
    await this.addVariant(pascalCase([variant.action, vname]), body, bodyParameterName, [...constants, ...requiredParameters], operation, variant, state);

    const [pathParams, otherParams] = values(requiredParameters).bifurcate(each => each?.protocol?.http?.in === ParameterLocation.Path);
    const dvi = await state.getValue('disable-via-identity', false);

    if (!dvi && length(pathParams) > 0 && variant.action.toLowerCase() != 'list') {
      // we have an operation that has path parameters, a good canididate for piping for identity.
      await this.addVariant(pascalCase([variant.action, vname, 'via-identity']), body, bodyParameterName, [...constants, ...otherParams], operation, variant, state);
    }

  }

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
  const state = await new NewModelState<PwshModel>(service).init();
  await service.WriteFile('code-model-v4-createcommands-v2.yaml', serialize(await (await new Inferrer(state).init()).createCommands()), undefined, 'code-model-v4');

  // return processCodeModel(async (state) => {
  //   return await (await new Inferrer(state).init()).createCommands();
  // }, service, 'createCommands-v2');
}