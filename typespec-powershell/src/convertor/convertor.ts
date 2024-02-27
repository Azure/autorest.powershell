// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

import { SdkClient, SdkContext } from "@azure-tools/typespec-client-generator-core";

import { getDoc, Program } from "@typespec/compiler";
import { getServers } from "@typespec/http";
import { join } from "path";
import { PwshModel } from "@autorest/powershell";
// import { CodeModel as PwshModel } from "@autorest/codemodel";
import { getDefaultService } from "../utils/modelUtils.js";
import { Info } from "@autorest/codemodel";

export async function transformPwshModel(
  client: SdkClient,
  psContext: SdkContext
): Promise<PwshModel> {
  const model = new PwshModel(client.name);
  model.info = getServiceInfo(psContext.program);
  return model;
}

function getServiceInfo(program: Program): Info {
  const defaultService = getDefaultService(program);
  const info = new Info(defaultService?.title || "");
  info.description = defaultService && getDoc(program, defaultService.type);
  return info;
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
