
import { Model } from '#common/code-model/code-model';
import { CommandOperation } from '#common/code-model/command-operation';
import { IParameter } from '#common/code-model/components';
import { HttpOperation, HttpOperationParameter, MediaType } from '#common/code-model/http-operation';
import { getAllProperties } from '#common/code-model/schema';
import { Dictionary, items, keys, length, values } from '#common/dictionary';
import { EnglishPluralizationService } from '#common/english-pluralization-service/pluralization';
import { processCodeModel } from '#common/process-code-model';
import { deconstruct, fixLeadingNumber, pascalCase } from '#common/text-manipulation';
import { deserialize, serialize } from '#common/yaml';
import { Schema, } from '#csharp/lowlevel-generator/code-model';
import { Channel, Host } from '@microsoft.azure/autorest-extension-base';
import { Lazy } from '@microsoft.azure/tasks';

export async function process(service: Host) {

  const x = await service.ListInputs('');
  // console.error(x);
  const y = await service.ListInputs();
  // console.error(y);

  const z = await service.GetValue('configurationFiles');
  // console.error(z);
  // await service.ProtectFiles("obj/test.txt");
  try {

    const txt = await service.GetConfigurationFile('readme.powershell.md');
    // console.error(txt);

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

async function addVariant(vname: string, body: MediaType | undefined, bodyParameterName: string, parameters: Array<HttpOperationParameter>, operation: HttpOperation, variant: CommandVariant, model: Model, service: Host) {
  // const body = operation.requestBody && values(operation.requestBody.content).linq.first();
  // const bodyParameterName = operation.requestBody ? operation.requestBody.extensions["x-ms-requestBody-name"] || "bodyParameter" : "";

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

async function addCommandOperation(vname: string, parameters: Array<HttpOperationParameter>, operation: HttpOperation, variant: CommandVariant, model: Model, service: Host): Promise<CommandOperation> {
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
  const body = operation.requestBody && values(operation.requestBody.content).linq.first();
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

  // no optionals:
  service.Message({ Channel: Channel.Verbose, Text: `${variant.verb}-${variant.noun} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${bodyPropertyNames} ${polymorphicBodies ? '; Polymorphic bodies: ${polymorphicBodies} ' : ''}` });
  await addVariant(vname, body, bodyParameterName, [...constants, ...requiredParameters], operation, variant, model, service);

  // handle optional parameter variants
  for (const combo of combos) {
    const vname = pascalCase(deconstruct([variant.variant, ...requiredParameters.map(each => each.name), ...combo.map(each => each.name), bodyPropertyNames /*, operation.operationId*/]));
    service.Message({ Channel: Channel.Verbose, Text: `${variant.verb}-${variant.noun} //  ${operation.operationId} => ${JSON.stringify(variant)} taking ${requiredParameters.joinWith(each => each.name)}; ${constantParameters} ; ${combo.joinWith(each => each.name)} ; ${bodyPropertyNames} ${polymorphicBodies ? '; Polymorphic bodies: ${polymorphicBodies} ' : ''}` });
    await addVariant(vname, body, bodyParameterName, [...constants, ...requiredParameters, ...combo], operation, variant, model, service);
  }
}

async function detect(model: Model, service: Host): Promise<Model> {
  service.Message({ Channel: Channel.Debug, Text: 'detecting high level commands...' });
  // let count = 0;

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
  result.AddWord('Database', 'Databases');
  result.AddWord('database', 'databases');
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
    group = 'service';

    // todo:  with no group, figure out a strategy for verb/nouning the method..
  }

  group = pluralization.Singularize(group);
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
    group = [operation, ...group];
  }

  group = group.map(each => pluralization.Singularize(each));
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

const category: { [verb: string]: string } = {
  'Add': 'System.Management.Automation.VerbsCommon',
  'Clear': 'System.Management.Automation.VerbsCommon',
  'Close': 'System.Management.Automation.VerbsCommon',
  'Copy': 'System.Management.Automation.VerbsCommon',
  'Enter': 'System.Management.Automation.VerbsCommon',
  'Exit': 'System.Management.Automation.VerbsCommon',
  'Find': 'System.Management.Automation.VerbsCommon',
  'Format': 'System.Management.Automation.VerbsCommon',
  'Get': 'System.Management.Automation.VerbsCommon',
  'Hide': 'System.Management.Automation.VerbsCommon',
  'Join': 'System.Management.Automation.VerbsCommon',
  'Lock': 'System.Management.Automation.VerbsCommon',
  'Move': 'System.Management.Automation.VerbsCommon',
  'New': 'System.Management.Automation.VerbsCommon',
  'Open': 'System.Management.Automation.VerbsCommon',
  'Optimize': 'System.Management.Automation.VerbsCommon',
  'Pop': 'System.Management.Automation.VerbsCommon',
  'Push': 'System.Management.Automation.VerbsCommon',
  'Redo': 'System.Management.Automation.VerbsCommon',
  'Remove': 'System.Management.Automation.VerbsCommon',
  'Rename': 'System.Management.Automation.VerbsCommon',
  'Reset': 'System.Management.Automation.VerbsCommon',
  'Resize': 'System.Management.Automation.VerbsCommon',
  'Search': 'System.Management.Automation.VerbsCommon',
  'Select': 'System.Management.Automation.VerbsCommon',
  'Set': 'System.Management.Automation.VerbsCommon',
  'Show': 'System.Management.Automation.VerbsCommon',
  'Skip': 'System.Management.Automation.VerbsCommon',
  'Split': 'System.Management.Automation.VerbsCommon',
  'Step': 'System.Management.Automation.VerbsCommon',
  'Switch': 'System.Management.Automation.VerbsCommon',
  'Undo': 'System.Management.Automation.VerbsCommon',
  'Unlock': 'System.Management.Automation.VerbsCommon',
  'Watch': 'System.Management.Automation.VerbsCommon',
  'Backup': 'System.Management.Automation.VerbsData',
  'Checkpoint': 'System.Management.Automation.VerbsData',
  'Compare': 'System.Management.Automation.VerbsData',
  'Compress': 'System.Management.Automation.VerbsData',
  'Convert': 'System.Management.Automation.VerbsData',
  'ConvertFrom': 'System.Management.Automation.VerbsData',
  'ConvertTo': 'System.Management.Automation.VerbsData',
  'Dismount': 'System.Management.Automation.VerbsData',
  'Edit': 'System.Management.Automation.VerbsData',
  'Expand': 'System.Management.Automation.VerbsData',
  'Export': 'System.Management.Automation.VerbsData',
  'Group': 'System.Management.Automation.VerbsData',
  'Import': 'System.Management.Automation.VerbsData',
  'Initialize': 'System.Management.Automation.VerbsData',
  'Limit': 'System.Management.Automation.VerbsData',
  'Merge': 'System.Management.Automation.VerbsData',
  'Mount': 'System.Management.Automation.VerbsData',
  'Out': 'System.Management.Automation.VerbsData',
  'Publish': 'System.Management.Automation.VerbsData',
  'Restore': 'System.Management.Automation.VerbsData',
  'Save': 'System.Management.Automation.VerbsData',
  'Sync': 'System.Management.Automation.VerbsData',
  'Unpublish': 'System.Management.Automation.VerbsData',
  'Update': 'System.Management.Automation.VerbsData',
  'Approve': 'System.Management.Automation.VerbsLifecycle',
  'Assert': 'System.Management.Automation.VerbsLifecycle',
  'Complete': 'System.Management.Automation.VerbsLifecycle',
  'Confirm': 'System.Management.Automation.VerbsLifecycle',
  'Deny': 'System.Management.Automation.VerbsLifecycle',
  'Disable': 'System.Management.Automation.VerbsLifecycle',
  'Enable': 'System.Management.Automation.VerbsLifecycle',
  'Install': 'System.Management.Automation.VerbsLifecycle',
  'Invoke': 'System.Management.Automation.VerbsLifecycle',
  'Register': 'System.Management.Automation.VerbsLifecycle',
  'Request': 'System.Management.Automation.VerbsLifecycle',
  'Restart': 'System.Management.Automation.VerbsLifecycle',
  'Resume': 'System.Management.Automation.VerbsLifecycle',
  'Start': 'System.Management.Automation.VerbsLifecycle',
  'Stop': 'System.Management.Automation.VerbsLifecycle',
  'Submit': 'System.Management.Automation.VerbsLifecycle',
  'Suspend': 'System.Management.Automation.VerbsLifecycle',
  'Uninstall': 'System.Management.Automation.VerbsLifecycle',
  'Unregister': 'System.Management.Automation.VerbsLifecycle',
  'Wait': 'System.Management.Automation.VerbsLifecycle',
  'Debug': 'System.Management.Automation.VerbsDiagnostic',
  'Measure': 'System.Management.Automation.VerbsDiagnostic',
  'Ping': 'System.Management.Automation.VerbsDiagnostic',
  'Repair': 'System.Management.Automation.VerbsDiagnostic',
  'Resolve': 'System.Management.Automation.VerbsDiagnostic',
  'Test': 'System.Management.Automation.VerbsDiagnostic',
  'Trace': 'System.Management.Automation.VerbsDiagnostic',
  'Connect': 'System.Management.Automation.VerbsCommunications',
  'Disconnect': 'System.Management.Automation.VerbsCommunications',
  'Read': 'System.Management.Automation.VerbsCommunications',
  'Receive': 'System.Management.Automation.VerbsCommunications',
  'Send': 'System.Management.Automation.VerbsCommunications',
  'Write': 'System.Management.Automation.VerbsCommunications',
  'Block': 'System.Management.Automation.VerbsSecurity',
  'Grant': 'System.Management.Automation.VerbsSecurity',
  'Protect': 'System.Management.Automation.VerbsSecurity',
  'Revoke': 'System.Management.Automation.VerbsSecurity',
  'Unblock': 'System.Management.Automation.VerbsSecurity',
  'Unprotect': 'System.Management.Automation.VerbsSecurity',
  'Use': 'System.Management.Automation.VerbsOther',
};

const verbs: { [verb: string]: string } = {
  'Access': 'Get',
  'List': 'Get',
  'Cat': 'Get',
  'Type': 'Get',
  'Dir': 'Get',
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
  'Delete': 'Remove',
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

