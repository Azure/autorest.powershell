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

  let n = 0;

  // loop thru the operations
  // add an apiversion constant paramter for each api
  for (const operation of values(model.http.operations)) {
    const metadata = operation.pathExtensions ? operation.pathExtensions['x-ms-metadata'] : {};
    const apiversions = metadata.apiVersions;
    const apiversion = apiversions[0];

    const schema = new Schema("apiversionstring", {
      type: JsonType.String,
      enum: [apiversion],
      details: {
        default: {
          skip: false,
        }
      }
    });
    model.schemas[`apv${n++}`] = schema;

    const param = new HttpOperationParameter("api-version", ParameterLocation.Query, ImplementationLocation.Method, {
      details: {
        default: {
          description: "The API version for the call",
          name: 'api-version',
          location: ImplementationLocation.Method,
          constantValue: apiversion
        }
      },
      schema
    });


    operation.parameters.push(param);
  }
  return model;
}