/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { processCodeModel, codemodel, components, command, http, getAllProperties, } from '@microsoft.azure/autorest.codemodel-v3';
import { deconstruct, fixLeadingNumber, pascalCase, items, length, values, EnglishPluralizationService } from '@microsoft.azure/codegen';
import { Schema } from '@microsoft.azure/autorest.csharp-v2';
import { Channel, Host } from '@microsoft.azure/autorest-extension-base';
import { Lazy } from '@microsoft.azure/tasks';
import { clone } from '@microsoft.azure/linq';
import { Project } from './project';

export async function createCommands(service: Host) {

  const x = await service.ListInputs('');
  const y = await service.ListInputs();

  const z = await service.GetValue('configurationFiles');
  try {

    const txt = await service.GetConfigurationFile('readme.powershell.md');

    // spit a configuration file back.
    // service.UpdateConfigurationFile('readme.powershell.md', `${txt}\n\n and more.`);
  } catch (E) {
    // console.error(E);
    console.error(`${__filename} - FAILURE  ${JSON.stringify(E)} ${E.stack}`);
    throw E;
  }

  return processCodeModel(commandCreator, service);
}

async function getIsAzure(service: Host): Promise<boolean> {
  return !!(await Project.getConfigValue(service, 'azure'));
}

async function commonParameters(service: Host): Promise<Array<string>> {
  const isAzure = await getIsAzure(service);
  return isAzure ? [
    // 'resourceGroupName',
    'subscriptionId'
  ] : [];
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

async function commandCreator(model: codemodel.Model, service: Host): Promise<codemodel.Model> {
  const isAzure = await getIsAzure(service);
  const prefix = await Project.getConfigValue(service, 'prefix');
  var serviceName = await Project.getConfigValue(service, 'service-name');
  const subjectPrefix = await Project.getConfigValue(service, 'subject-prefix');

  model.details.default.isAzure = isAzure;
  model.details.default.prefix = prefix;
  service.Message({
    Channel: Channel.Verbose, Text: `[CMDLET-PREFIX] => '${model.details.default.prefix}'`
  });

  model.details.default.serviceName = serviceName;
  service.Message({
    Channel: Channel.Verbose, Text: `[SERVICE-NAME] => '${model.details.default.serviceName}'`
  });

  model.details.default.subjectPrefix = subjectPrefix;
  service.Message({
    Channel: Channel.Verbose, Text: `[SUBJECT-PREFIX] => '${model.details.default.subjectPrefix}'`
  });

  // perform the detection
  model = await detect(model, service);
  return model;
}

async function addVariant(vname: string, body: http.RequestBody | undefined, bodyParameterName: string, parameters: Array<http.HttpOperationParameter>, operation: http.HttpOperation, variant: CommandVariant, model: codemodel.Model, service: Host) {
  const op = await addCommandOperation(vname, parameters, operation, variant, model, service);

  // if this has a body with it, let's add that parameter
  if (body && body.schema) {
    op.details.default.hasBody = true;
    op.parameters.push(new components.IParameter(bodyParameterName, body.schema, {
      details: {
        default: {
          description: body.schema.details.default.description,
          name: getPascalName(bodyParameterName),
          isBodyParameter: true,
        }
      }
    }));

    // let's add a variant where it's expanded out.
    // *IF* the body is an object
    if (body.schema.type === JsonType.Object) {
      const opExpanded = await addCommandOperation(`${vname}Expanded`, parameters, operation, variant, model, service);
      opExpanded.details.default.dropBodyParameter = true;
      opExpanded.parameters.push(new components.IParameter(`${bodyParameterName}Body`, body.schema, {
        details: {
          default: {
            description: body.schema.details.default.description,
            name: getPascalName(`${bodyParameterName}Body`),
            isBodyParameter: true,
          }
        }
      }));
    }
  }

  //
}

function isNameConflict(model: codemodel.Model, vname: string) {
  for (const each of values(model.commands.operations)) {
    if (each.details.default.name === vname) {
      return true;
    }
  }
  return false;
}

async function addCommandOperation(vname: string, parameters: Array<http.HttpOperationParameter>, operation: http.HttpOperation, variant: CommandVariant, model: codemodel.Model, service: Host): Promise<command.CommandOperation> {

  let apiversion = '';

  for (const each of items(operation.responses)) {
    for (const rsp of each.value) {
      if (rsp.schema && rsp.schema.details && rsp.schema.details.default && rsp.schema.details.default.apiversion) {
        console.error(rsp.schema.details.default.apiversion);
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
    for (const each of names) {
      newVName = newVName + each;
      if (newVName.length > 60) {
        break;
      }
    }
    vname = `${newVName}`;
  }

  // if we have an identical vname, let's add 'etc'
  while (isNameConflict(model, vname)) {
    vname = `${vname}Etc`;
  }

  const xmsMetadata = operation.pathExtensions ? operation.pathExtensions['x-ms-metadata'] ? clone(operation.pathExtensions['x-ms-metadata']) : {} : {};

  return model.commands.operations[`${length(model.commands.operations)}`] = new command.CommandOperation(operation.operationId, {
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
        name: getPascalName(each.details.default.name),
        httpParameter
      };
      return each;
    }),
    callGraph: [operation],
  });
}

async function addVariants(parameters: Array<http.HttpOperationParameter>, operation: http.HttpOperation, variant: CommandVariant, model: codemodel.Model, service: Host) {
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
  service.Message({ Channel: Channel.Verbose, Text: `${variant.verb}-${variant.subject} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${bodyPropertyNames} ${polymorphicBodies ? `; Polymorphic bodies: ${polymorphicBodies} ` : ''}` });
  await addVariant(vname, body, bodyParameterName, [...constants, ...requiredParameters], operation, variant, model, service);

  // handle optional parameter variants
  for (const combo of combos) {
    const vname = pascalCase(deconstruct([variant.variant, ...requiredParameters.map(each => each.name), ...combo.map(each => each.name), bodyPropertyNames /*, operation.operationId*/]));
    service.Message({ Channel: Channel.Verbose, Text: `${variant.verb}-${variant.subject} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${combo.joinWith(each => each.name)} ; ${bodyPropertyNames} ${polymorphicBodies ? `; Polymorphic bodies: ${polymorphicBodies} ` : ''}` });
    await addVariant(vname, body, bodyParameterName, [...constants, ...requiredParameters, ...combo], operation, variant, model, service);
  }
}

async function detect(model: codemodel.Model, service: Host): Promise<codemodel.Model> {
  service.Message({ Channel: Channel.Debug, Text: 'detecting high level commands...' });

  // parameter names that are candidates to be changed to pull the value from the common module
  const commonCandidates = await commonParameters(service);

  for (const operation of values(model.http.operations)) {
    for (const variant of await inferCommandNames(operation.operationId, service, model)) {

      // no common parameters (standard variations)
      await addVariants(operation.parameters, operation, variant, model, service);

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
          await addVariants(some, operation, variant, model, service);
        }
      }

      // make some variants where subscriptionId and resourceGroupName are pulled from common module
    }
  }

  return model;
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

const pluralizationService = new Lazy(() => {
  const result = new EnglishPluralizationService();
  result.addWord('Database', 'Databases');
  result.addWord('database', 'databases');
  return result;
});

interface CommandVariant {
  verb: string;
  subject: string;
  subjectPrefix: string;
  variant: string;
}

async function inferCommandNames(operationId: string, service: Host, model: codemodel.Model): Promise<Array<CommandVariant>> {

  const pluralization = pluralizationService.Value;

  let [group, method] = operationId.split('_', 2);
  if (!method) {
    // no group given.
    method = group;
    group = '';

    // todo:  with no group, figure out a strategy for verb/subject-ing the method..
  }

  group = pluralization.singularize(group);
  const operation = deconstruct(method);

  // get verb mappings
  verbMap = await service.GetValue('verb-mapping');
  if (verbMap[method]) {
    return [getVariant(method, group, [], model)];
  } else if (operation.length > 1) {
    // options supported
    // OPERATION or OPERATION2 => OPERATION-GROUP, OPERATION2-GROUP
    // OPERATION by FILTER => OPERATION-GROUP_FILTER
    // OPERATION with FILTER => OPERATION-GROUP_FILTER

    switch (operation[1].toLowerCase()) {
      case 'or':
        // create two operations -- OPERATION and OPERATION2
        // there should be only three things in the collection -- otherwise, we need a better alg.
        if (operation.length !== 3) {
          // throw new Error(`Unable to perform detection form operation '${group}'/'${method}' -- too many values in operation : '${JSON.stringify(operation)}'`);
        }

        return [getVariant(operation[0], group, operation.slice(3), model), getVariant(operation[2], group, operation.slice(3), model)];

      case 'by':
      case 'with':
        // create one operation -- OPERATION-GROUP_filter
        return [getVariant(operation[0], group, operation.slice(2), model)];
    }
    // OPERATION[SUFFIX] => OPERATION-GROUP[SUFFIX]
    return [getVariant(operation[0], [group, ...operation.slice(1)], operation.slice(1), model)];
    // would generate simpler name, but I fear for collisions on things like Registries_ListCredentials => get-credentials or Registries_RegenerateCredential => new-credential
    // return [getVariant(operation[0], `${pascalCase(operation.slice(1))}`, operation.slice(1))];

  } else {
    // for now, the rest should look like:
    // OPERATION => OPERATION-GROUP
    return [getVariant(operation[0], group, [], model)];
  }
}

function getVariant(operation: string, group: string | Array<string>, suffix: Array<string>, model: codemodel.Model): CommandVariant {
  const pluralization = pluralizationService.Value;
  group = !Array.isArray(group) ? [group] : group;
  const verb = getVerb(operation);
  if (verb === 'Invoke') {
    // if the 'operation' name was  "post" -- it's kindof redundant.
    // so, only include the operation name in the group name if it's anything else
    if (operation.toLowerCase() !== 'post') {
      group = [operation, ...group];
    }
  }

  group = group.map(each => pluralization.singularize(each));

  return {
    subject: pascalCase(group),
    variant: pascalCase(suffix),
    verb,
    subjectPrefix: model.details.default.subjectPrefix
  };
}

// operationIdMethod -> psVerb
let verbMap: { [operationIdMethod: string]: string } = {}

function getVerb(operation: string): string {
  if (verbMap[getPascalName(operation)]) {
    return verbMap[getPascalName(operation)];
  } else {
    return 'Invoke';
  }
}

function getPascalName(name: string): string {
  return pascalCase(fixLeadingNumber(deconstruct(name)));
}



