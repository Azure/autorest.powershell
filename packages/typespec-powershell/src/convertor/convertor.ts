// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

import { SdkClient, SdkContext, listOperationsInOperationGroup, listOperationGroups } from "@azure-tools/typespec-client-generator-core";
import { HttpOperation, HttpOperationParameter, HttpOperationRequestBody, getHttpOperation } from "@typespec/http";
import { getDoc, getService, ignoreDiagnostics, Program, Model, Type } from "@typespec/compiler";
import { getServers } from "@typespec/http";
import { join } from "path";
import { PwshModel } from "@autorest/powershell";
// import { CodeModel as PwshModel } from "@autorest/codemodel";
import { constantSchemaForApiVersion, getDefaultService, getSchemaForType, schemaCache, stringSchemaForEnum, numberSchemaForEnum, getSchemaForApiVersion, getEnrichedDefaultApiVersion, delayedModelSet } from "../utils/modelUtils.js";
import { Info, Language, Schemas, AllSchemaTypes, SchemaType, ArraySchema, StringSchema, Languages, ObjectSchema } from "@autorest/codemodel";
import { camelCase, deconstruct, pascalCase, serialize } from "@azure-tools/codegen";
import { PSOptions } from "../types/interfaces.js";
import { Request, ImplementationLocation, OperationGroup, Operation, Parameter, Schema, Protocol, Response, HttpHeader } from "@autorest/codemodel";
import { stat } from "fs";
import { extractPagedMetadataNested } from "../utils/operationUtil.js";
import { parseNextLinkName } from "../utils/operationUtil.js";
import { getLroMetadata } from "@azure-tools/typespec-azure-core";

const GlobalParameter = "global-parameter";

const urlParameters: Parameter[] = [];
let endpoint = '{$host}';

export async function transformPwshModel(
  client: SdkClient,
  psContext: SdkContext,
  emitterOptions: PSOptions
): Promise<PwshModel> {
  const model = new PwshModel(client.name);
  getUrlParameters(psContext.program, psContext);
  model.info = getServiceInfo(psContext.program);
  model.language.default = getLanguageDefault(psContext.program, emitterOptions);
  model.operationGroups = getOperationGroups(psContext.program, client, psContext, model);
  model.schemas = getSchemas(psContext.program, client, psContext, model);
  return model;
}

function handleCircleReference(schemas: Schemas) {
  for (const schema of schemas.objects || []) {
    if (schema.properties) {
      for (const property of schema.properties) {
        if (property.extensions && property.extensions['circle-ref']) {
          const refSchema = (schemas.objects || []).filter(s => property.extensions && s.language.default.name === <string>property.extensions['circle-ref']);
          if (refSchema.length > 0) {
            property.schema = refSchema[0];
          }
        }
      }
    }
  }
  return schemas;
}

function getSchemas(program: Program, client: SdkClient, psContext: SdkContext, model: PwshModel): Schemas {
  for (const eachModel of delayedModelSet) {
    getSchemaForType(psContext, eachModel);
  }
  const schemas = new Schemas();
  const visited = new Set<Schema>;
  for (const schema of schemaCache.values()) {
    if (schema.type === SchemaType.Any) {
      // set name and description for any schema
      schema.language.default.name = "any";
      schema.language.default.description = "Anything";
      schemas["any"] = schemas["any"] || [];
      schemas["any"].push(schema);
    } else {
      if (schema.type === SchemaType.Array && (<any>schema).delayType) {
        (<ArraySchema>schema).elementType = getSchemaForType(psContext, (<any>schema).delayType as Type);
        (<any>schema).delayType = undefined;
      }
      if (!visited.has(schema)) {
        visited.add(schema);
        schemas.add(schema);
      }
    }
  }

  if (stringSchemaForEnum) {
    schemas.add(stringSchemaForEnum);
  }
  if (numberSchemaForEnum) {
    schemas.add(numberSchemaForEnum);
  }
  if (constantSchemaForApiVersion) {
    schemas.add(constantSchemaForApiVersion);
  }
  handleCircleReference(schemas);
  return schemas;
}

function getUrlParameters(program: Program, psContext: SdkContext) {
  const serviceNs = getDefaultService(program)?.type;
  if (serviceNs) {
    const host = getServers(program, serviceNs);
    if (host?.[0]?.url) {
      endpoint = host[0].url;
    }
    if (host && host?.[0] && host?.[0]?.parameters) {
      for (const key of host[0].parameters.keys()) {
        const property = host?.[0]?.parameters.get(key);
        const type = property?.type;

        if (!property || !type) {
          continue;
        }

        const schema = getSchemaForType(psContext, type);
        const newParameter = new Parameter(camelCase(deconstruct(key)), getDoc(program, property) || "", schema)
        newParameter.language.default.serializedName = key;
        newParameter.protocol.http = newParameter.protocol.http ?? new Protocol();
        newParameter.protocol.http.in = "uri";
        // ToDo, we need to support x-ms-client is specified.
        newParameter.implementation = ImplementationLocation.Method;
        newParameter.required = true;
        urlParameters.push(newParameter);
      }
    }
  }
}

function getOperationGroups(program: Program, client: SdkClient, psContext: SdkContext, model: PwshModel): OperationGroup[] {
  const operationGroups: OperationGroup[] = [];
  // list all the operations in the client
  const clientOperations = listOperationsInOperationGroup(psContext, client);
  const newGroup = new OperationGroup("");
  if (clientOperations.length > 0) {
    newGroup.language.default.name = newGroup.$key = "";
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
    newGroup.language.default.name = newGroup.$key = operationGroup.type.name;
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
  // Add Api versions
  newOperation.apiVersions = newOperation.apiVersions || [];
  newOperation.apiVersions.push({ version: getEnrichedDefaultApiVersion(psContext.program, psContext) || "" });
  // Add URl parameters
  if (urlParameters.length > 0) {
    newOperation.parameters = newOperation.parameters || [];
    newOperation.parameters.push(...urlParameters);
  }
  // Add query and path parameters
  const parameters = op.parameters.parameters.filter(p => p.type === "path" || p.type === "query");
  for (const parameter of parameters) {
    const newParameter = createParameter(psContext, parameter, model);
    newOperation.parameters = newOperation.parameters || [];
    newOperation.parameters.push(newParameter);
  }
  // Add request
  newOperation.requests = newOperation.requests || [];
  const newRequest = new Request();
  newOperation.requests.push(newRequest);
  const headerParameters = op.parameters.parameters.filter(p => p.type === "header");
  for (const parameter of headerParameters) {
    const newParameter = createParameter(psContext, parameter, model);
    newRequest.parameters = newRequest.parameters || [];
    newOperation.requests[0].parameters?.push(newParameter);
  }
  // Add host parameter
  if (endpoint === '{$host}') {
    const hostParameter = createHostParameter(psContext, model);
    newOperation.parameters = newOperation.parameters || [];
    newOperation.parameters.push(hostParameter);
  }
  // Add request body if it exists
  if (op.parameters.body && op.parameters.body.bodyKind === "single" && !(op.parameters.body.type.kind === "Intrinsic" && op.parameters.body.type.name === "void")) {
    const newParameter = createBodyParameter(psContext, op.parameters.body, model);
    newRequest.parameters = newRequest.parameters || [];
    newOperation.requests[0].parameters?.push(newParameter);
  }
  const httpProtocol = new Protocol();
  httpProtocol.method = op.verb;
  httpProtocol.path = op.path;
  // hard code the media type to json for the time being by xiaogang.
  httpProtocol.knownMediaType = "json";
  httpProtocol.mediaTypes = ["application/json"];
  httpProtocol.uri = endpoint;
  newOperation.requests[0].protocol.http = httpProtocol;

  // Add responses include exceptions
  addResponses(psContext, op, newOperation, model);
  // Add extensions
  addExtensions(psContext, op, newOperation, model);
  operationGroup.addOperation(newOperation);
}

function addExtensions(psContext: SdkContext, op: HttpOperation, newOperation: Operation, model: PwshModel) {
  // Add extensions for pageable
  const paged = extractPagedMetadataNested(psContext.program, op.responses[0].type as Model);
  if (paged) {
    newOperation.extensions = newOperation.extensions || {};
    //ToDo: add value if it is specified by xiaogang
    newOperation.extensions['x-ms-pageable'] = newOperation.extensions['x-ms-pageable'] || {};
    newOperation.extensions['x-ms-pageable']['nextLinkName'] = parseNextLinkName(paged) ?? "nextLink";
    newOperation.language.default.paging = newOperation.language.default.paging || {};
    newOperation.language.default.paging.nextLinkName = parseNextLinkName(paged) ?? "nextLink";
  }
  // Add extensions for long running operation
  const lro = getLroMetadata(psContext.program, op.operation);
  if (lro) {
    newOperation.extensions = newOperation.extensions || {};
    newOperation.extensions['x-ms-long-running-operation'] = true;
    newOperation.extensions['x-ms-long-running-operation-options'] = newOperation.extensions['x-ms-long-running-operation-options'] || {};
    newOperation.extensions['x-ms-long-running-operation-options']['final-state-via'] = lro.finalStateVia;
  }
}

function addResponses(psContext: SdkContext, op: HttpOperation, newOperation: Operation, model: PwshModel) {
  const responses = op.responses;
  newOperation.responses = newOperation.responses || [];
  newOperation.exceptions = newOperation.exceptions || [];
  if (responses) {
    for (const response of responses) {
      const newResponse = new Response();
      // newOperation.responses[response.statusCode] || newOperation.responses.default;
      // if (!newResponse) {
      //   newOperation.responses[response.statusCode] = newResponse;
      // }
      newResponse.language.default.name = '';
      newResponse.language.default.description = response.description || "";
      const statusCode = response.statusCode;
      // Add schema for response body
      if (response.responses[0].body) {
        const schema = getSchemaForType(psContext, response.responses[0].body.type);
        (<any>newResponse).schema = schema;
      }
      // Add headers
      // we merge headers here, if the same header is defined in multiple responses, we only add it once.
      // This is aligned with the behavior of typescript emitter and typespec-autorest emitter.
      newResponse.protocol.http = newResponse.protocol.http ?? new Protocol();
      const addedKeys: string[] = [];
      for (const innerResponse of response.responses) {
        if (innerResponse.headers) {
          for (const key in innerResponse.headers) {
            if (addedKeys.includes(key)) {
              continue;
            } else {
              addedKeys.push(key);
            }
            newResponse.protocol.http.headers = newResponse.protocol.http.headers || [];
            const header = innerResponse.headers[key];
            const headerSchema = getSchemaForType(psContext, header.type);
            const headerResponse = new HttpHeader(key, headerSchema);
            headerResponse.language = new Languages();
            headerResponse.language.default = new Language();
            headerResponse.language.default.description = getDoc(psContext.program, header) || "";
            headerResponse.language.default.name = pascalCase(deconstruct(key));
            newResponse.protocol.http.headers.push(headerResponse);
          }
        }
      }
      newResponse.protocol.http.statusCodes = statusCode === "*" ? ["default"] : [statusCode];
      newResponse.protocol.http.knownMediaType = "json";
      newResponse.protocol.http.mediaTypes = ["application/json"];
      if (statusCode.startsWith("2")) {
        newOperation.responses.push(newResponse);
      } else {
        newOperation.exceptions.push(newResponse);
      }
    }
  }
}

function createBodyParameter(psContext: SdkContext, parameter: HttpOperationRequestBody, model: PwshModel): Parameter {
  const paramSchema = parameter.parameter?.sourceProperty
    ? getSchemaForType(psContext, parameter.parameter?.sourceProperty?.type)
    : getSchemaForType(psContext, parameter.type)
  const newParameter = new Parameter(parameter.parameter?.name || "", parameter.parameter ? getDoc(psContext.program, parameter.parameter) || "" : "", paramSchema);
  newParameter.protocol.http = newParameter.protocol.http ?? new Protocol();
  newParameter.protocol.http.in = "body";
  // ToDo, we need to support x-ms-client is specified.
  newParameter.implementation = ImplementationLocation.Method;
  newParameter.required = !parameter.parameter?.optional;
  return newParameter;
}

function createHostParameter(psContext: SdkContext, model: PwshModel): Parameter {
  const matchParameters = (model.globalParameters || []).filter(p => p.language.default.serializedName === '$host');
  if (matchParameters.length > 0) {
    return matchParameters[0];
  } else {
    const newParameter = new Parameter('$host', "server parameter", new StringSchema("", "")); //getSchemaForType(psContext, "string")
    newParameter.language.default.serializedName = '$host';
    newParameter.clientDefaultValue = "https://management.azure.com";
    newParameter.protocol.http = newParameter.protocol.http ?? new Protocol();
    newParameter.protocol.http.in = "uri";
    newParameter.implementation = ImplementationLocation.Client;
    newParameter.required = true;
    newParameter.extensions = newParameter.extensions || {};
    newParameter.extensions["x-ms-skip-url-encoding"] = true;
    model.globalParameters = model.globalParameters || [];
    model.globalParameters.push(newParameter);
    return newParameter;
  }
}
function createParameter(psContext: SdkContext, parameter: HttpOperationParameter, model: PwshModel): Parameter {
  if (parameter.type === "query" && parameter.name === "api-version"
    || parameter.type === "path" && parameter.name === "subscriptionId") {
    const matchParameters = (model.globalParameters || []).filter(p => p.language.default.serializedName === parameter.name);
    if (matchParameters.length > 0) {
      return matchParameters[0];
    } else {
      const paramSchema = parameter.name === "api-version" ? getSchemaForApiVersion(psContext, parameter.param.type) : (parameter.param.sourceProperty ? getSchemaForType(psContext, parameter.param.sourceProperty) : getSchemaForType(psContext, parameter.param));
      const newParameter = new Parameter(pascalCase(deconstruct(parameter.name)), getDoc(psContext.program, parameter.param) || "", paramSchema);
      if (newParameter.language.default.name === "ApiVersion") {
        //to align with modelerfour
        newParameter.language.default.name = "apiVersion";
      }
      newParameter.language.default.serializedName = parameter.name;
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
    const paramSchema = parameter.param.sourceProperty ? getSchemaForType(psContext, parameter.param.sourceProperty) : getSchemaForType(psContext, parameter.param);
    const newParameter = new Parameter(parameter.name, getDoc(psContext.program, parameter.param) || "", paramSchema);
    newParameter.language.default.serializedName = parameter.name;
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
