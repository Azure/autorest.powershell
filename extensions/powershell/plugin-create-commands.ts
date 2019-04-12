/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { JsonType, processCodeModel, codemodel, components, command, http, getAllProperties, ModelState, } from '@microsoft.azure/autorest.codemodel-v3';
import { deconstruct, fixLeadingNumber, pascalCase, items, length, values, EnglishPluralizationService, fail, removeSequentialDuplicates } from '@microsoft.azure/codegen';
import { Schema } from '@microsoft.azure/autorest.csharp-v2';
import { Channel, Host } from '@microsoft.azure/autorest-extension-base';
import { Lazy } from '@microsoft.azure/tasks';
import { clone } from '@microsoft.azure/linq';
import { verbs } from './verbs';

type State = ModelState<codemodel.Model>;


const pluralizationService = new EnglishPluralizationService();
pluralizationService.addWord('Database', 'Databases');
pluralizationService.addWord('database', 'databases');


interface CommandVariant {
  verb: string;
  subject: string;
  subjectPrefix: string;
  variant: string;
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
    ]
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

export async function createCommands(service: Host) {
  // return processCodeModel(commandCreator, service);
  return processCodeModel(async (state) => {
    return await (await new Inferrer(state).init()).createCommands();
  }, service);
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
    this.serviceName = await this.state.getValue('service-name');
    this.subjectPrefix = await this.state.getValue('subject-prefix');

    this.state.setValue('isAzure', this.isAzure);
    this.state.setValue('prefix', this.prefix);

    const model = this.state.model;

    this.state.message({
      Channel: Channel.Verbose, Text: `[CMDLET-PREFIX] => '${model.details.default.prefix}'`
    });

    model.details.default.serviceName = this.serviceName;
    this.state.message({
      Channel: Channel.Verbose, Text: `[SERVICE-NAME] => '${model.details.default.serviceName}'`
    });

    model.details.default.subjectPrefix = this.subjectPrefix;
    this.state.message({
      Channel: Channel.Verbose, Text: `[SUBJECT-PREFIX] => '${model.details.default.subjectPrefix}'`
    });

    return this;
  }

  async createCommands() {
    const model = this.state.model;

    this.state.message({ Channel: Channel.Debug, Text: 'detecting high level commands...' });

    // parameter names that are candidates to be changed to pull the value from the common module
    const commonCandidates = this.commonParameters;

    for (const operation of values(model.http.operations)) {
      for (const variant of await this.inferCommandNames(operation.operationId, this.state)) {

        // no common parameters (standard variations)
        await this.addVariants(operation.parameters, operation, variant, this.state);

        // now see if we have parameters that can be made common
        const possibleCommon = values(operation.parameters).linq.where(parameter => commonCandidates.includes(parameter.name)).linq.toArray();
        if (possibleCommon.length > 0) {
          // yes! make some combos that include the common parameters
          const combos = combinations(possibleCommon);
          for (const combo of combos) {
            // now, take the operation parameters, and find the ones where that are in our set of combo,
            const some = operation.parameters.map(param => {
              if (combo.includes(param)) {
                const newParam = {
                  ...param,
                  details: {
                    ...param.details,
                    default: {
                      ...param.details.default,
                      originalHttpParameter: param,
                      fromHost: true
                    }
                  }
                };
                return <http.HttpOperationParameter><any>newParam;
              }
              return param;
            });
            // and shallow copy the parameter, into a new one, and overw
            await this.addVariants(some, operation, variant, this.state);
          }
        }
        // make some variants where subscriptionId and resourceGroupName are pulled from common module
      }
    }
    return model;
  }

  inferCommand(operation: Array<string>, group: string, suffix: Array<string> = []): Array<CommandVariant> {
    operation = operation.filter(each => each !== 'all');
    // no instant match 
    switch (operation.length) {
      case 0:
        throw new Error("Missing operation id?");

      case 1:
        // simple operation, just an id with a single value
        // OPERATION => OPERATION-GROUP
        return [
          this.getVariant(operation[0], deconstruct(group), suffix, this.state.model)
        ];

      case 2:
        // should try to infer [SUBJECT] and [ACTION] from operation
        if (verbs.has(operation[0])) {
          // [ACTION][SUBJECT]
          return [
            this.getVariant(operation[0], [...deconstruct(group), operation[1]], suffix, this.state.model)
          ];
        }
        if (verbs.has(operation[1])) {
          // [SUBJECT][ACTION]
          return [
            this.getVariant(operation[1], [...deconstruct(group), operation[0]], suffix, this.state.model)
          ];

        }
        // can't tell which is the [ACTION] -- let's return it the way we used to, 
        // but now let's mention that we are doing that.
        this.state.warning(`Operation ${operation[0]}/${operation[1]} is inferred without finding action.`, [], {});
        return [
          this.getVariant(operation[0], [...deconstruct(group), operation[1]], suffix, this.state.model)
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
          return [this.getVariant(operation[i], group ? [...deconstruct(group), ...operation.slice(i + 1)] : operation.slice(i + 1), suffix, this.state.model)]
        }
        if (i === operation.length - 1) {
          // if it's last, the subject would be the first thing
          return [this.getVariant(operation[i], group ? [...deconstruct(group), ...operation.slice(0, i)] : operation.slice(0, i), suffix, this.state.model)]
        }

        // otherwise          
        // things before are part of the subject
        // things after the verb should be part of the suffix
        return [this.getVariant(operation[i], group ? [...deconstruct(group), ...operation.slice(i, i)] : operation.slice(i, i), [...suffix, ...operation.slice(i + 1)], this.state.model)]
      }
    }

    // so couldn't tell what the action was.
    // fallback to the original behavior with a warning.
    this.state.warning(`Operation ${operation[0]}/${operation[1]} is inferred without finding action.`, [], {});
    return [this.getVariant(operation[0], group ? [...deconstruct(group), ...operation.slice(1)] : operation.slice(1), [...suffix, ...operation.slice(1)], this.state.model)];

  }

  async inferCommandNames(operationId: string, state: State): Promise<Array<CommandVariant>> {
    let [group, method] = operationId.split('_', 2);
    if (!method) {
      // no group given.
      method = group;
      group = '';
    }

    let groupWords = deconstruct(group);
    groupWords[groupWords.length - 1] = pluralizationService.singularize(groupWords.last);

    group = pascalCase(groupWords);
    const operation = deconstruct(method);

    // instant match
    if (this.verbMap[method]) {
      return [this.getVariant(method, [group], [], state.model)];
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

  isNameConflict(model: codemodel.Model, vname: string) {
    for (const each of values(model.commands.operations)) {
      if (each.details.default.name === vname) {
        return true;
      }
    }
    return false;
  }

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

    vname = `${apiversion}${vname}`;

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
    while (this.isNameConflict(state.model, vname)) {
      vname = `${vname}Etc`;
    }

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
          name: vname
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

  async addVariants(parameters: Array<http.HttpOperationParameter>, operation: http.HttpOperation, variant: CommandVariant, state: State) {
    // now synthesize parameter set variants multiplexed by the variants.

    const [constants, params] = values(parameters).linq.bifurcate(parameter => parameter.details.default.constantValue || parameter.details.default.fromHost ? true : false);
    const [requiredParameters, optionalParameters] = values(params).linq.bifurcate(parameter => parameter.required);

    const constantParameters = constants.map(each => `'${each.details.default.constantValue}'`);

    const combos = combinations(optionalParameters);

    // the body parameter
    const body = operation.requestBody;
    const bodyParameterName = operation.requestBody ? operation.requestBody.extensions['x-ms-requestBody-name'] || 'bodyParameter' : '';

    // all the properties in the body parameter
    const bodyProperties = (body && body.schema) ? values(getAllProperties(body.schema)).linq.where(property => !property.schema.readOnly).linq.toArray() : [];

    // smash body property names together
    const bodyPropertyNames = bodyProperties.joinWith(each => each.details.default.name);

    // for each polymorphic body, we should do a separate variant that takes the polymorphic body type instead of the base type
    const polymorphicBodies = (body && body.schema && body.schema.details.default.polymorphicChildren && body.schema.details.default.polymorphicChildren.length) ? (<Array<Schema>>body.schema.details.default.polymorphicChildren).joinWith(child => child.details.default.name) : '';

    // the variant name
    const vname = pascalCase(deconstruct([variant.variant, ...requiredParameters.map(each => each.name), bodyPropertyNames /*, operation.operationId*/]));

    // given the body property type, expand out body properties into parameters

    // wait! "update" should be "set" if it's a POST
    if (variant.verb === 'Update' && operation.method === http.HttpMethod.Put) {
      variant.verb = `Set`;
    }

    // no optionals:
    state.message({ Channel: Channel.Verbose, Text: `${variant.verb}-${variant.subject} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${bodyPropertyNames} ${polymorphicBodies ? `; Polymorphic bodies: ${polymorphicBodies} ` : ''}` });
    await this.addVariant(vname, body, bodyParameterName, [...constants, ...requiredParameters], operation, variant, state);

    // handle optional parameter variants
    for (const combo of combos) {
      const vname = pascalCase(deconstruct([variant.variant, ...requiredParameters.map(each => each.name), ...combo.map(each => each.name), bodyPropertyNames /*, operation.operationId*/]));
      state.message({ Channel: Channel.Verbose, Text: `${variant.verb}-${variant.subject} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${combo.joinWith(each => each.name)} ; ${bodyPropertyNames} ${polymorphicBodies ? `; Polymorphic bodies: ${polymorphicBodies} ` : ''}` });
      await this.addVariant(vname, body, bodyParameterName, [...constants, ...requiredParameters, ...combo], operation, variant, state);
    }
  }

  getVariant(action: string, subject: Array<string>, suffix: Array<string>, model: codemodel.Model): CommandVariant {

    const verb = this.getVerb(action);
    if (verb === 'Invoke') {
      // if the 'operation' name was  "post" -- it's kindof redundant.
      // so, only include the operation name in the group name if it's anything else
      if (action.toLowerCase() !== 'post') {
        subject = [action, ...subject];
      }
    }

    subject = [...removeSequentialDuplicates(subject.map(each => pluralizationService.singularize(each)))];

    return {
      subject: pascalCase(subject),
      variant: pascalCase(suffix),
      verb,
      subjectPrefix: model.details.default.subjectPrefix
    };
  }

  getVerb(operation: string): string {
    const verb = this.verbMap[pascalCase(operation)];
    if (verb) {
      return verb;
    } else {
      return 'Invoke';
    }
  }
}

// UNUSED
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

