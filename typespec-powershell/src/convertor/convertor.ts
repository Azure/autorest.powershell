// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

import { SdkClient, SdkContext, listOperationsInOperationGroup, listOperationGroups } from "@azure-tools/typespec-client-generator-core";
import { HttpOperation, HttpOperationParameter, getHttpOperation } from "@typespec/http";
import { getDoc, getService, ignoreDiagnostics, Program } from "@typespec/compiler";
import { getServers } from "@typespec/http";
import { join } from "path";
import { PwshModel } from "@autorest/powershell";
// import { CodeModel as PwshModel } from "@autorest/codemodel";
import { getDefaultService, getSchemaForType } from "../utils/modelUtils.js";
import { Info, Language } from "@autorest/codemodel";
import { deconstruct, pascalCase, } from "@azure-tools/codegen";
import { PSOptions } from "../types/interfaces.js";
import { ImplementationLocation, OperationGroup, Operation, Parameter, Schema, Protocol } from "@autorest/codemodel";

const GlobalParameter = "global-parameter";

export async function transformPwshModel(
  client: SdkClient,
  psContext: SdkContext,
  emitterOptions: PSOptions
): Promise<PwshModel> {
  const model = new PwshModel(client.name);
  model.info = getServiceInfo(psContext.program);
  model.language.default = getLanguageDefault(psContext.program, emitterOptions);
  model.operationGroups = getOperationGroups(psContext.program, client, psContext, model);
  return model;
}

function getOperationGroups(program: Program, client: SdkClient, psContext: SdkContext, model: PwshModel): OperationGroup[] {
  const operationGroups: OperationGroup[] = [];
  // list all the operations in the client
  const clientOperations = listOperationsInOperationGroup(psContext, client);
  const newGroup = new OperationGroup("");
  if (clientOperations.length > 0) {
    newGroup.$key = "";
    operationGroups.push(newGroup);
  }
  for (const clientOperation of clientOperations) {
    const op = ignoreDiagnostics(getHttpOperation(program, clientOperation));
    if (op.overloads && op.overloads.length > 0) {
      continue
    }
    addOperation(psContext, op, newGroup, model);
    // const operationGroup = new OperationGroup(operation.name);
    // operationGroup.language.default.name = operation.name;
    // operationGroup.language.default.description = operation.description;
    // operationGroup.operations.push(operation);
    // operationGroups.push(operationGroup);
  }
  const opGroups = listOperationGroups(psContext, client, true);
  for (const operationGroup of opGroups) {
    const newGroup = new OperationGroup("");
    newGroup.$key = operationGroup.type.name;
    operationGroups.push(newGroup);
    const operations = listOperationsInOperationGroup(
      psContext,
      operationGroup
    );
    for (const operation of operations) {
      const op = ignoreDiagnostics(getHttpOperation(program, operation));
      // ignore overload base operation
      if (op.overloads && op.overloads?.length > 0) {
        continue;
      }
      addOperation(psContext, op, newGroup, model);
    }
  }
  return operationGroups;
}

function addOperation(psContext: SdkContext, op: HttpOperation, operationGroup: OperationGroup, model: PwshModel) {
  const newOperation = new Operation(pascalCase(op.operation.name), getDoc(psContext.program, op.operation) ?? "");
  newOperation.operationId = operationGroup.$key + "_" + pascalCase(op.operation.name);
  // Add query and path parameters
  const parameters = op.parameters.parameters.filter(p => p.type === "path" || p.type === "query");
  for (const parameter of parameters) {
    const newParameter = createParameter(psContext, parameter, model);
    newOperation.parameters = newOperation.parameters || [];
    newOperation.parameters.push(newParameter);
  }
  operationGroup.addOperation(newOperation);
}

function createParameter(psContext: SdkContext, parameter: HttpOperationParameter, model: PwshModel): Parameter {
  if (parameter.type === "query" && parameter.name === "api-version"
    || parameter.type === "path" && parameter.name === "subscriptionId") {
    const matchParameters = (model.globalParameters || []).filter(p => p.language.default.name === parameter.name);
    if (matchParameters.length > 0) {
      return matchParameters[0];
    } else {
      const paramSchema = parameter.param.sourceProperty
        ? getSchemaForType(psContext, parameter.param.sourceProperty?.type)
        : getSchemaForType(psContext, parameter.param.type)
      const newParameter = new Parameter(parameter.name, getDoc(psContext.program, parameter.param) || "", paramSchema);
      newParameter.protocol.http = newParameter.protocol.http ?? new Protocol();
      newParameter.protocol.http.in = parameter.type;
      newParameter.implementation = ImplementationLocation.Client;
      newParameter.required = !parameter.param.optional;
      model.globalParameters = model.globalParameters || [];
      model.globalParameters.push(newParameter);
      return newParameter;
    }
  } else {
    // always create the parameter
    const paramSchema = parameter.param.sourceProperty
      ? getSchemaForType(psContext, parameter.param.sourceProperty?.type)
      : getSchemaForType(psContext, parameter.param.type)
    const newParameter = new Parameter(parameter.name, getDoc(psContext.program, parameter.param) || "", paramSchema);
    newParameter.protocol.http = newParameter.protocol.http ?? new Protocol();
    newParameter.protocol.http.in = parameter.type;
    // ToDo, we need to support x-ms-client is specified.
    newParameter.implementation = ImplementationLocation.Method;
    newParameter.required = !parameter.param.optional;
    return newParameter;
  }
}

// function addGlobalParameter(parameter: Parameter, model: PwshModel) {
//   if ((parameter.protocol?.http?.in == "query" && parameter.language.default.name === "api-version")
//     || (parameter.protocol?.http?.in == "path" && parameter.language.default.name === "subscriptionId")) {
//     model.globalParameters = model.globalParameters || [];
//     model.globalParameters.push(parameter);
//   }
// }
function getServiceInfo(program: Program): Info {
  const defaultService = getDefaultService(program);
  const info = new Info(defaultService?.title || "");
  info.description = defaultService && getDoc(program, defaultService.type);
  return info;
}

function getLanguageDefault(program: Program, emitterOptions: PSOptions): Language {
  const defaultLanguage: Language = {
    name:
      emitterOptions.packageDetails?.name ??
      // Todo: may need to normalize the name
      pascalCase(deconstruct(emitterOptions?.title ?? getDefaultService(program)?.title ?? "")),
    description: ''
  };
  return defaultLanguage;
}
// export function transformUrlInfo(dpgContext: SdkContext): UrlInfo | undefined {
//   const program = dpgContext.program;
//   const serviceNs = getDefaultService(program)?.type;
//   let endpoint = undefined;
//   const urlParameters: PathParameter[] = [];
//   if (serviceNs) {
//     const host = getServers(program, serviceNs);
//     if (host?.[0]?.url) {
//       endpoint = host[0].url;
//     }
//     if (host && host?.[0] && host?.[0]?.parameters) {
//       // Currently we only support one parameter in the servers definition
//       for (const key of host[0].parameters.keys()) {
//         const property = host?.[0]?.parameters.get(key);
//         const type = property?.type;

//         if (!property || !type) {
//           continue;
//         }

//         const schema = getSchemaForType(dpgContext, type, {
//           usage: [SchemaContext.Exception, SchemaContext.Input],
//           needRef: false,
//           relevantProperty: property
//         });
//         urlParameters.push({
//           oriName: key,
//           name: normalizeName(key, NameType.Parameter, true),
//           type: getTypeName(schema),
//           description:
//             (getDoc(program, property) &&
//               getFormattedPropertyDoc(program, property, schema, " ")) ??
//             getFormattedPropertyDoc(program, type, schema, " " /* sperator*/),
//           value: predictDefaultValue(dpgContext, host?.[0]?.parameters.get(key))
//         });
//       }
//     }
//   }
//   if (endpoint && urlParameters.length > 0) {
//     for (const param of urlParameters) {
//       if (param.oriName) {
//         const regexp = new RegExp(`{${param.oriName}}`, "g");
//         endpoint = endpoint.replace(regexp, `{${param.name}}`);
//       }
//     }
//   }
//   // Set the default value if missing endpoint parameter
//   if (endpoint == undefined && urlParameters.length === 0) {
//     endpoint = "{endpoint}";
//     urlParameters.push({
//       name: "endpoint",
//       type: "string"
//     });
//   }
//   return { endpoint, urlParameters };
// }
