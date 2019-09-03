/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { JsonType, processCodeModel, codemodel, components, command, http, getAllProperties, ModelState, ParameterLocation, } from '@azure-tools/codemodel-v3';
import { deconstruct, fixLeadingNumber, pascalCase, EnglishPluralizationService, fail, removeSequentialDuplicates } from '@azure-tools/codegen';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { Schema } from './llcsharp/exports';
import { Channel, Host } from '@azure-tools/autorest-extension-base';
import { Lazy } from '@azure-tools/tasks';
import { clone } from '@azure-tools/linq';
import { verbs } from './verbs';

type State = ModelState<codemodel.Model>;


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
  if (active.length || remaining.length) {
    if (remaining.length) {
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
      Channel: Channel.Debug, Text: `[CMDLET-PREFIX] => '${model.details.default.prefix}'`
    });

    model.details.default.serviceName = this.serviceName;
    this.state.message({
      Channel: Channel.Debug, Text: `[SERVICE-NAME] => '${model.details.default.serviceName}'`
    });

    model.details.default.subjectPrefix = this.subjectPrefix;
    this.state.message({
      Channel: Channel.Debug, Text: `[SUBJECT-PREFIX] => '${model.details.default.subjectPrefix}'`
    });

    return this;
  }

  async createCommands() {
    const model = this.state.model;

    this.state.message({ Channel: Channel.Debug, Text: 'detecting high level commands...' });

    for (const operation of values(model.http.operations)) {
      for (const variant of await this.inferCommandNames(operation, this.state)) {
        // no common parameters (standard variations)
        await this.addVariants(operation.parameters, operation, variant, '', this.state);


      }
    }
    return model;
  }

  inferCommand(operation: Array<string>, group: string, suffix: Array<string> = []): Array<CommandVariant> {
    operation = operation.filter(each => each !== 'all');
    // no instant match 
    switch (operation.length) {
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
    for (let i = 0; i < operation.length; i++) {
      if (verbs.has(operation[i])) {
        // if the action is first
        if (i === 0) {
          // everything else is the subject
          return [this.createCommandVariant(operation[i], group ? [...deconstruct(group), ...operation.slice(i + 1)] : operation.slice(i + 1), suffix, this.state.model)];
        }
        if (i === operation.length - 1) {
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

  async inferCommandNames(op: http.HttpOperation, state: State): Promise<Array<CommandVariant>> {
    const operationId = op.operationId;

    let [group, method] = operationId.split('_', 2);
    if (!method) {
      // no group given.
      method = group;
      group = pascalCase(op.tags) || '';
    }

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

  async addVariant(vname: string, body: http.RequestBody | undefined, bodyParameterName: string, parameters: Array<http.HttpOperationParameter>, operation: http.HttpOperation, variant: CommandVariant, state: State) {
    const op = await this.addCommandOperation(vname, parameters, operation, variant, state);

    // if this has a body with it, let's add that parameter
    if (body && body.schema) {
      op.details.default.hasBody = true;
      op.parameters.push(new components.IParameter(bodyParameterName, body.schema, {
        details: {
          default: {
            description: body.schema.details.default.description,
            name: pascalCase(bodyParameterName),
            isBodyParameter: true,
          }
        }
      }));

      // let's add a variant where it's expanded out.
      // *IF* the body is an object
      if (body.schema.type === JsonType.Object) {
        const opExpanded = await this.addCommandOperation(`${vname}Expanded`, parameters, operation, variant, state);
        opExpanded.details.default.dropBodyParameter = true;
        opExpanded.parameters.push(new components.IParameter(`${bodyParameterName}Body`, body.schema, {
          details: {
            default: {
              description: body.schema.details.default.description,
              name: pascalCase(`${bodyParameterName}Body`),
              isBodyParameter: true,
            }
          }
        }));
      }
    }
  }


  isNameConflict(model: codemodel.Model, variant: CommandVariant, vname: string) {
    for (const each of values(model.commands.operations)) {
      if (each.details.default.name === vname) {
        return true;
      }
    }
    return false;
  }

  // for tracking unique operation identities 
  operationIdentities = new Set<string>();

  async addCommandOperation(vname: string, parameters: Array<http.HttpOperationParameter>, operation: http.HttpOperation, variant: CommandVariant, state: State): Promise<command.CommandOperation> {
    let apiversion = '';

    for (const each of items(operation.responses)) {
      for (const rsp of each.value) {
        if (rsp.schema && rsp.schema.details && rsp.schema.details.default && rsp.schema.details.default.apiversion) {
          apiversion = rsp.schema.details.default.apiversion;
          break;
        }
      }
    }

    // if vname is > 64 characters, let's trim it
    // after trimming it, make sure there aren't any other operation with a name that's exactly the same
    if (vname.length > 64) {
      const names = deconstruct(vname);
      let newVName = '';
      for (let i = 0; i < names.length; i++) {
        newVName = pascalCase(names.slice(0, i));
        if (newVName.length > 60) {
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
    const xmsMetadata = operation.pathExtensions ? operation.pathExtensions['x-ms-metadata'] ? clone(operation.pathExtensions['x-ms-metadata']) : {} : {};

    return state.model.commands.operations[`${length(state.model.commands.operations)}`] = new command.CommandOperation(operation.operationId, {
      asjob: operation.details.default.asjob ? true : false,
      extensions: {
        ...operation.pathExtensions,
        'x-ms-metadata': xmsMetadata
      },
      ...variant,
      details: {
        ...operation.details,
        default: {
          ...operation.details.default,
          subject: variant.subject,
          subjectPrefix: variant.subjectPrefix,
          verb: variant.verb,
          name: vname,
          alias: variant.alias
        }
      },
      operationId: operation.operationId,
      parameters: parameters.map(httpParameter => {
        // make it's own copy of the parameter since after this, 
        // the parameter can be altered for each operation individually.
        const each = clone(httpParameter, false, undefined, undefined, ['schema', 'origin']);
        each.details.default = {
          ...each.details.default,
          name: pascalCase(each.details.default.name),
          httpParameter
        };
        return each;
      }),
      callGraph: [operation],
    });
  }

  async addVariants(parameters: Array<http.HttpOperationParameter>, operation: http.HttpOperation, variant: CommandVariant, vname: string, state: State) {
    // now synthesize parameter set variants multiplexed by the variants.
    const [constants, requiredParameters] = values(parameters).linq.bifurcate(parameter => parameter.details.default.constantValue || parameter.details.default.fromHost ? true : false);
    const constantParameters = constants.map(each => `'${each.details.default.constantValue}'`);

    // the body parameter
    const body = operation.requestBody;
    const bodyParameterName = operation.requestBody ? operation.requestBody.extensions['x-ms-requestBody-name'] || 'bodyParameter' : '';

    // all the properties in the body parameter
    const bodyProperties = (body && body.schema) ? values(getAllProperties(body.schema)).linq.where(property => !property.details.default.readOnly).linq.toArray() : [];

    // smash body property names together
    const bodyPropertyNames = bodyProperties.joinWith(each => each.details.default.name);

    // for each polymorphic body, we should do a separate variant that takes the polymorphic body type instead of the base type
    const polymorphicBodies = (body && body.schema && body.schema.details.default.polymorphicChildren && body.schema.details.default.polymorphicChildren.length) ? (<Array<Schema>>body.schema.details.default.polymorphicChildren).joinWith(child => child.details.default.name) : '';

    // wait! "update" should be "set" if it's a POST
    if (variant.verb === 'Update' && operation.method === http.HttpMethod.Put) {
      variant.verb = 'Set';
    }

    // create variant 
    state.message({ Channel: Channel.Debug, Text: `${variant.verb}-${variant.subject} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${bodyPropertyNames} ${polymorphicBodies ? `; Polymorphic bodies: ${polymorphicBodies} ` : ''}` });
    await this.addVariant(pascalCase([variant.action, vname]), body, bodyParameterName, [...constants, ...requiredParameters], operation, variant, state);

    const [pathParams, otherParams] = values(requiredParameters).linq.bifurcate(each => each.in === ParameterLocation.Path);
    const dvi = await state.getValue('disable-via-identity', false);

    if (!dvi && pathParams.length > 0 && variant.action.toLowerCase() != 'list') {
      // we have an operation that has path parameters, a good canididate for piping for identity.
      await this.addVariant(pascalCase([variant.action, vname, 'via-identity']), body, bodyParameterName, [...constants, ...otherParams], operation, variant, state);
    }

  }

  createCommandVariant(action: string, subject: Array<string>, variant: Array<string>, model: codemodel.Model): CommandVariant {
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
      subjectPrefix: model.details.default.subjectPrefix,
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


export async function createCommands(service: Host) {
  // return processCodeModel(commandCreator, service);
  return processCodeModel(async (state) => {
    return await (await new Inferrer(state).init()).createCommands();
  }, service, 'createCommands');
}