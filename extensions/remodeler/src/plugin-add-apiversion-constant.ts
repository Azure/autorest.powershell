/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { codemodel, JsonType, processCodeModel, HttpOperationParameter, ParameterLocation, Schema, schema } from '@microsoft.azure/autorest.codemodel-v3';
import { keys, length, values } from '@microsoft.azure/codegen';

import { Host } from '@microsoft.azure/autorest-extension-base';
import { ImplementationLocation } from '@microsoft.azure/autorest.codemodel-v3/dist/code-model/components';


export async function addApiVersionConstant(service: Host) {
  return processCodeModel(tweakModel, service);
}

async function tweakModel(model: codemodel.Model, service: Host): Promise<codemodel.Model> {
  /*
    let n = 0;
  
    const versions = new Map<string, Schema>();
    const parameters = new Map<string, HttpOperationParameter>();
  
    // loop thru the operations
    // add an apiversion constant paramter for each api
    for (const operation of values(model.http.operations)) {
      const metadata = operation.pathExtensions ? operation.pathExtensions['x-ms-metadata'] : {};
      const apiversions = metadata.apiVersions;
      const apiversion = apiversions[0];
  
      let vSchema = versions.get(apiversion);
      const name = `ApiVersion${apiversion}`
  
      if (!vSchema) {
  
        vSchema = new Schema(name, {
          type: JsonType.String,
          / * enum: [apiversion],
           extensions: {
             "x-ms-enum": {
               name,
               modelAsString: true
             }
           },
           * /
          details: {
            default: {
              skip: false,
            }
          }
        });
        model.schemas[name] = vSchema;
      }
  
      let vParameter = parameters.get(apiversion);
      if (!vParameter) {
        vParameter = new HttpOperationParameter("api-version", ParameterLocation.Query, ImplementationLocation.Method, {
          details: {
            default: {
              description: "The API version for the call",
              name: 'api-version',
              location: ImplementationLocation.Method,
              constantValue: apiversion
            }
          },
          schema: vSchema
        });
  
        model.http.parameters[name] = vParameter;
      }
  
      operation.parameters.push(vParameter);
    }
    */
  return model;
}