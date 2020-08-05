/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { CodeModel, HttpHeader, ObjectSchema, Property } from '@azure-tools/codemodel';
import { serialize } from '@azure-tools/codegen';
import { PwshModel } from '../utils/PwshModel';
import { NewModelState } from '../utils/model-state';
import { StatusCodes } from '../utils/http-definitions';

import { Host } from '@azure-tools/autorest-extension-base';


type State = NewModelState<PwshModel>;

async function tweakModel(state: State): Promise<PwshModel> {
  const model = state.model;

  addResponseHeaderSchema(model);

  return model;
}

function addResponseHeaderSchema(model: CodeModel) {
  // In remodler, each operations response headers will has its own scheam. Each header will be schema's property. But in m4, there won't be a schema for headers.
  // To keep backward compatiable, we will create headers schema here

  model.operationGroups.forEach((group) => {
    group.operations?.forEach((op) => {
      if (!op.responses) {
        return;
      }
      op.responses.forEach((resp) => {
        const headers = resp.protocol.http?.headers as Array<HttpHeader>;
        if (headers === undefined) {
          return;
        }

        const responseCode = resp.protocol.http?.statusCodes?.[0];
        if (responseCode === undefined) {
          return;
        }

        // Follow naming pattern in m3
        const code = ((<any>StatusCodes)[responseCode] || '') || responseCode;
        const schemaName = `${group.language.default.name}_${op.language.default.name} ${code} ResponseHeaders`;

        const newSchema = model.schemas.objects?.find((schema) => schema.language.default.name === schemaName) ||
          new ObjectSchema(schemaName, '');
        newSchema.language.default.isHeaderModel = true;

        if (!model.schemas.objects) {
          model.schemas.objects = [];
        }
        model.schemas.objects.push(newSchema);

        headers.forEach((head) => {
          // We lost description and x-ms-client-name in m4. So newProp's description is empty and use header as serializedName 
          const newProp = new Property(head.header, '', head.schema, {
            readOnly: false,
            required: false,
            serializedName: head.header
          });
          newProp.language.default.HeaderProperty = 'Header';

          if (!newSchema.properties) {
            newSchema.properties = [];
          }
          newSchema.properties.push(newProp);
        });

        // Set response header use new schema
        resp.language.default.headerSchema = newSchema;
      });
    });
  });
}


export async function tweakM4ModelPlugin(service: Host) {
  const state = await new NewModelState<PwshModel>(service).init();
  await service.WriteFile('code-model-v4-tweakm4codemodel.yaml', serialize(await tweakModel(state)), undefined, 'code-model-v4');
}