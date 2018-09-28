/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Model } from '#common/code-model/code-model';
import { CommandOperation } from '#common/code-model/command-operation';
import { IParameter } from '#common/code-model/components';
import { HttpMethod, HttpOperation, HttpOperationParameter, RequestBody } from '#common/code-model/http-operation';
import { getAllProperties } from '#common/code-model/schema';
import { EnglishPluralizationService } from '#common/english-pluralization-service/pluralization';
import { items, length, values } from '#common/linq';
import { processCodeModel } from '#common/process-code-model';
import { deconstruct, fixLeadingNumber, pascalCase } from '#common/text-manipulation';
import { Schema, } from '#csharp/lowlevel-generator/code-model';
import { Channel, Host } from '@microsoft.azure/autorest-extension-base';
import { Lazy } from '@microsoft.azure/tasks';

export async function process(service: Host) {

  const x = await service.ListInputs('');
  const y = await service.ListInputs();

  const z = await service.GetValue('configurationFiles');
  try {

    const txt = await service.GetConfigurationFile('readme.powershell.md');

    // spit a configuration file back.
    // service.UpdateConfigurationFile('readme.powershell.md', `${txt}\n\n and more.`);
  } catch (E) {
    // console.error(E);
  }

  return processCodeModel(commandCreator, service);
}

async function commonParameters(service: Host): Promise<Array<string>> {
  const isAzure = await service.GetValue('azure') || await service.GetValue('azure-arm') || false;
  return isAzure ? [
    // 'resourceGroupName',
    'subscriptionId'
  ] : [];
}

async function commandCreator(model: Model, service: Host): Promise<Model> {
  // check to see if there are already operations in the configuration that we should load
  // and check to see if we should infer new operations

  // perform the detection
  model = await detect(model, service);
  return model;
}

async function addVariant(vname: string, body: RequestBody | undefined, bodyParameterName: string, parameters: Array<HttpOperationParameter>, operation: HttpOperation, variant: CommandVariant, model: Model, service: Host) {
  const op = await addCommandOperation(vname, parameters, operation, variant, model, service);

  // if this has a body with it, let's add that parameter
  if (body && body.schema) {
    op.details.powershell.hasBody = true;
    op.parameters.push(new IParameter(bodyParameterName, body.schema, {
      details: {
        powershell: {
          description: body.schema.details.default.description,
          name: pascalCase(fixLeadingNumber(deconstruct(bodyParameterName))),
          isBodyParameter: true,
        }
      }
    }));
  }

  //
}

function isNameConflict(model: Model, vname: string) {
  for (const each of values(model.commands.operations)) {
    if (each.details.powershell.name === vname) {
      return true;
    }
  }
  return false;
}

async function addCommandOperation(vname: string, parameters: Array<HttpOperationParameter>, operation: HttpOperation, variant: CommandVariant, model: Model, service: Host): Promise<CommandOperation> {
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
    vname = `${newVName}Etc`;
  }

  // if we have an identical vname, let's add 'etc'
  while (isNameConflict(model, vname)) {
    vname = `${vname}Etc`;
  }

  return model.commands.operations[`${length(model.commands.operations)}`] = new CommandOperation(operation.operationId, {
    asjob: operation.details.default.asjob ? true : false,
    ...variant,
    details: {
      ...operation.details,
      powershell: {
        ...operation.details.csharp,
        name: vname
      }
    },
    operationId: operation.operationId,
    parameters: parameters.map(each => {
      each.details.powershell = {
        ...each.details.csharp,
        name: pascalCase(fixLeadingNumber(deconstruct(each.details.csharp.name)))
      };
      return each;
    }),
    callGraph: [operation],
  });
}

async function addVariants(parameters: Array<HttpOperationParameter>, operation: HttpOperation, variant: CommandVariant, model: Model, service: Host) {
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
  // console.error(`Number of Body Properties ${properties.length}`);

  // smash body property names together
  const bodyPropertyNames = bodyProperties.joinWith(each => each.details.csharp.name);

  // for each polymorphic body, we should do a separate variant that takes the polymorphic body type instead of the base type
  const polymorphicBodies = (body && body.schema && body.schema.details.csharp.polymorphicChildren && body.schema.details.csharp.polymorphicChildren.length) ? (<Array<Schema>>body.schema.details.csharp.polymorphicChildren).joinWith(child => child.details.csharp.name) : '';

  // the variant name
  const vname = pascalCase(deconstruct([variant.variant, ...requiredParameters.map(each => each.name), bodyPropertyNames /*, operation.operationId*/]));

  // given the body property type, expand out body properties into parameters

  // wait! "update" should be "set" if it's a POST
  if (variant.verb === 'Update' && operation.method === HttpMethod.Put) {
    variant.verb = `Set`;
    variant.category = getCategory(`Set`);
  }

  // no optionals:
  service.Message({ Channel: Channel.Verbose, Text: `${variant.verb}-${variant.noun} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${bodyPropertyNames} ${polymorphicBodies ? `; Polymorphic bodies: ${polymorphicBodies} ` : ''}` });
  await addVariant(vname, body, bodyParameterName, [...constants, ...requiredParameters], operation, variant, model, service);

  // handle optional parameter variants
  for (const combo of combos) {
    const vname = pascalCase(deconstruct([variant.variant, ...requiredParameters.map(each => each.name), ...combo.map(each => each.name), bodyPropertyNames /*, operation.operationId*/]));
    service.Message({ Channel: Channel.Verbose, Text: `${variant.verb}-${variant.noun} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${combo.joinWith(each => each.name)} ; ${bodyPropertyNames} ${polymorphicBodies ? `; Polymorphic bodies: ${polymorphicBodies} ` : ''}` });
    await addVariant(vname, body, bodyParameterName, [...constants, ...requiredParameters, ...combo], operation, variant, model, service);
  }
}

async function detect(model: Model, service: Host): Promise<Model> {
  service.Message({ Channel: Channel.Debug, Text: 'detecting high level commands...' });

  // parameter names that are candidates to be changed to pull the value from the common module
  const commonCandidates = await commonParameters(service);

  for (const operation of values(model.http.operations)) {
    for (const variant of inferCommandNames(operation.operationId)) {

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
                    originalParam: param,
                    fromHost: true
                  }
                }
              };
              return <HttpOperationParameter><any>newParam;
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
  noun: string;
  category: string;
  variant: string;
}

function inferCommandNames(operationId: string): Array<CommandVariant> {
  const pluralization = pluralizationService.Value;

  let [group, method] = operationId.split('_', 2);
  if (!method) {
    // no group given.
    method = group;
    group = '';

    // todo:  with no group, figure out a strategy for verb/nouning the method..
  }

  group = pluralization.singularize(group);
  const operation = deconstruct(method);

  if (operation.length > 1) {
    // options supported
    // OPERATION or OPERATION2 => OPERATION-GROUP, OPERATION2-GROUP
    // OPERATION by FILTER => OPERATION-GROUP_FILTER
    // OPERATION with FILTER => OPERATION-GROUP_FILTER

    switch (operation[1].toLowerCase()) {
      case 'or':
        // create two operations -- OPERATION and OPERATION2
        // there should be only three things in the collection -- otherwise, we need a better alg.
        if (operation.length !== 3) {
          throw new Error(`Unable to perform detection form operation '${group}'/'${method}' -- too many values in operation : '${JSON.stringify(operation)}'`);
        }

        return [getVariant(operation[0], group, operation.slice(3)), getVariant(operation[2], group, operation.slice(3))];

      case 'by':
      case 'with':
        // create one operation -- OPERATION-GROUP_filter
        return [getVariant(operation[0], group, operation.slice(2))];
    }
    // OPERATION[SUFFIX] => OPERATION-GROUP[SUFFIX]
    return [getVariant(operation[0], [group, ...operation.slice(1)], operation.slice(1))];
    // would generate simpler name, but I fear for collisions on things like Registries_ListCredentials => get-credentials or Registries_RegenerateCredential => new-credential
    // return [getVariant(operation[0], `${pascalCase(operation.slice(1))}`, operation.slice(1))];

  } else {
    // for now, the rest should look like:
    // OPERATION => OPERATION-GROUP
    return [getVariant(operation[0], group, [])];
  }
}

function getVariant(operation: string, group: string | Array<string>, suffix: Array<string>): CommandVariant {
  const pluralization = pluralizationService.Value;
  group = !Array.isArray(group) ? [group] : group;

  const v = getVerb(operation);
  if (v === 'Invoke') {
    // if the 'operation' name was  "post" -- it's kindof redundant.
    // so, only include the operation name in the group name if it's anything else
    if (operation !== 'post') {
      group = [operation, ...group];
    }
  }

  group = group.map(each => pluralization.singularize(each));
  const noun = pascalCase(group);

  return {
    category: getCategory(v),
    noun,
    variant: pascalCase(suffix),
    verb: v,
  };
}

function fail(message: string): any {
  throw new Error(message);
}

function getVerb(operation: string): string {
  operation = operation.toLowerCase();
  const match = items(verbs).linq.first(item => item.key.toLowerCase() === operation);
  if (match) {
    return match.value;
  }
  const matchDirect = items(category).linq.first(item => item.key.toLowerCase() === operation);
  if (matchDirect) {
    return matchDirect.key;
  }

  return category[operation] ? operation : 'Invoke';
}

function getCategory(verb: string): string {
  const match = items(category).linq.first(item => item.key === verb);
  if (match) {
    return match.value;
  }

  return fail(`Verb '${verb}' has no matching category.`);
}
const Verbs = {
  Common: 'System.Management.Automation.Verbs.Common',
  Data: 'System.Management.Automation.VerbsData',
  Lifecycle: 'System.Management.Automation.VerbsLifecycle',
  Diagnostic: 'System.Management.Automation.VerbsDiagnostic',
  Communications: 'System.Management.Automation.VerbsCommunications',
  Security: 'System.Management.Automation.VerbsSecurity',
  Other: 'System.Management.Automation.VerbsOther'
};

const category: { [verb: string]: string } = {
  'Add': Verbs.Common,
  'Clear': Verbs.Common,
  'Close': Verbs.Common,
  'Copy': Verbs.Common,
  'Enter': Verbs.Common,
  'Exit': Verbs.Common,
  'Find': Verbs.Common,
  'Format': Verbs.Common,
  'Get': Verbs.Common,
  'Hide': Verbs.Common,
  'Join': Verbs.Common,
  'Lock': Verbs.Common,
  'Move': Verbs.Common,
  'New': Verbs.Common,
  'Open': Verbs.Common,
  'Optimize': Verbs.Common,
  'Pop': Verbs.Common,
  'Push': Verbs.Common,
  'Redo': Verbs.Common,
  'Remove': Verbs.Common,
  'Rename': Verbs.Common,
  'Reset': Verbs.Common,
  'Resize': Verbs.Common,
  'Search': Verbs.Common,
  'Select': Verbs.Common,
  'Set': Verbs.Common,
  'Show': Verbs.Common,
  'Skip': Verbs.Common,
  'Split': Verbs.Common,
  'Step': Verbs.Common,
  'Switch': Verbs.Common,
  'Undo': Verbs.Common,
  'Unlock': Verbs.Common,
  'Watch': Verbs.Common,
  'Backup': Verbs.Data,
  'Checkpoint': Verbs.Data,
  'Compare': Verbs.Data,
  'Compress': Verbs.Data,
  'Convert': Verbs.Data,
  'ConvertFrom': Verbs.Data,
  'ConvertTo': Verbs.Data,
  'Dismount': Verbs.Data,
  'Edit': Verbs.Data,
  'Expand': Verbs.Data,
  'Export': Verbs.Data,
  'Group': Verbs.Data,
  'Import': Verbs.Data,
  'Initialize': Verbs.Data,
  'Limit': Verbs.Data,
  'Merge': Verbs.Data,
  'Mount': Verbs.Data,
  'Out': Verbs.Data,
  'Publish': Verbs.Data,
  'Restore': Verbs.Data,
  'Save': Verbs.Data,
  'Sync': Verbs.Data,
  'Unpublish': Verbs.Data,
  'Update': Verbs.Data,
  'Approve': Verbs.Lifecycle,
  'Assert': Verbs.Lifecycle,
  'Complete': Verbs.Lifecycle,
  'Confirm': Verbs.Lifecycle,
  'Deny': Verbs.Lifecycle,
  'Disable': Verbs.Lifecycle,
  'Enable': Verbs.Lifecycle,
  'Install': Verbs.Lifecycle,
  'Invoke': Verbs.Lifecycle,
  'Register': Verbs.Lifecycle,
  'Request': Verbs.Lifecycle,
  'Restart': Verbs.Lifecycle,
  'Resume': Verbs.Lifecycle,
  'Start': Verbs.Lifecycle,
  'Stop': Verbs.Lifecycle,
  'Submit': Verbs.Lifecycle,
  'Suspend': Verbs.Lifecycle,
  'Uninstall': Verbs.Lifecycle,
  'Unregister': Verbs.Lifecycle,
  'Wait': Verbs.Lifecycle,
  'Debug': Verbs.Diagnostic,
  'Measure': Verbs.Diagnostic,
  'Ping': Verbs.Diagnostic,
  'Repair': Verbs.Diagnostic,
  'Resolve': Verbs.Diagnostic,
  'Test': Verbs.Diagnostic,
  'Trace': Verbs.Diagnostic,
  'Connect': Verbs.Communications,
  'Disconnect': Verbs.Communications,
  'Read': Verbs.Communications,
  'Receive': Verbs.Communications,
  'Send': Verbs.Communications,
  'Write': Verbs.Communications,
  'Block': Verbs.Security,
  'Grant': Verbs.Security,
  'Protect': Verbs.Security,
  'Revoke': Verbs.Security,
  'Unblock': Verbs.Security,
  'Unprotect': Verbs.Security,
  'Use': Verbs.Other,
};

const verbs: { [verb: string]: string } = {
  'Access': 'Get',
  'List': 'Get',
  'Cat': 'Get',
  'Type': 'Get',
  'Dir': 'Get',
  'Put': 'Set',
  'Post': 'Invoke',
  'Get': 'Get',
  'Delete': 'Remove',
  'Obtain': 'Get',
  'Dump': 'Get',
  'Acquire': 'Get',
  'Examine': 'Get',
  'Suggest': 'Get',
  'Retrieve': 'Get',
  'Create': 'New',
  'Generate': 'New',
  'Allocate': 'New',
  'Provision': 'New',
  'Make': 'New',
  'Regenerate': 'New', // Alternatives: Redo, Update, Reset
  'Replace': 'Update',
  'Failover': 'Set',
  'Assign': 'Set',
  'Configure': 'Set',
  'Activate': 'Initialize',
  'Build': 'Build',
  'Compile': 'Build',
  'Deploy': 'Deploy',
  'Apply': 'Add',
  'Append': 'Add',
  'Attach': 'Add',
  'Concatenate': 'Add',
  'Insert': 'Add',
  'Cut': 'Remove',
  'Dispose': 'Remove',
  'Discard': 'Remove',
  'Generalize': 'Reset',
  'Patch': 'Update',
  'Refresh': 'Update',
  'Reprocess': 'Update', // Alternatives: Redo
  'Upgrade': 'Update',
  'Reimage': 'Update', // Alternatives: Format, Reset
  'Retarget': 'Update',
  'Validate': 'Test',
  'Check': 'Test',
  'Verify': 'Test',
  'Analyze': 'Test',
  'Is': 'Test',
  'Evaluate': 'Test', // Alternatives: Invoke
  'Power': 'Start',
  'PowerOn': 'Start',
  'Run': 'Start', // Alternatives: Invoke
  'Trigger': 'Start',
  'Pause': 'Suspend',
  'Cancel': 'Stop',
  'PowerOff': 'Stop',
  'End': 'Stop',
  'Shutdown': 'Stop',
  'Reboot': 'Restart',
  'ForceReboot': 'Restart',
  'Finish': 'Complete',
  'Wipe': 'Clear',
  'Purge': 'Clear', // Alternatives: Remove
  'Flush': 'Clear',
  'Erase': 'Clear',
  'Unmark': 'Clear',
  'Unset': 'Clear',
  'Nullify': 'Clear',
  'Recover': 'Restore',
  'Undelete': 'Restore',
  'Synchronize': 'Sync',
  'Synch': 'Sync',
  'Load': 'Import',
  'Capture': 'Export', // Alternatives: Trace
  'Migrate': 'Move', // Alternatives: Export
  'Transfer': 'Move',
  'Name': 'Move',
  'Reassociate': 'Move',
  'Change': 'Rename',
  'Swap': 'Switch', // Alternatives: Move
  'Execute': 'Invoke',
  'Perform': 'Invoke',
  'Discover': 'Find', // Alternatives: Search
  'Locate': 'Find',
  'Release': 'Publish', // Alternatives: Clear, Unlock
  'Resubmit': 'Submit',
  'Duplicate': 'Copy',
  'Clone': 'Copy',
  'Replicate': 'Copy',
  'Into': 'Enter',
  'Combine': 'Join',
  'Unite': 'Join',
  'Associate': 'Join',
  'Restrict': 'Lock',
  'Secure': 'Lock',
  'Unrestrict': 'Unlock',
  'Unsecure': 'Unlock',
  'Display': 'Show',
  'Produce': 'Show',
  'Bypass': 'Skip',
  'Jump': 'Skip',
  'Separate': 'Split',
  'Notify': 'Send',
  'Authorize': 'Grant'
};
