/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { CodeModel, DictionarySchema, getAllProperties, HttpHeader, ObjectSchema, Property, Schema, SchemaType } from '@azure-tools/codemodel';
import { serialize } from '@azure-tools/codegen';
import { PwshModel } from '../utils/PwshModel';
import { NewModelState } from '../utils/model-state';
import { StatusCodes } from '../utils/http-definitions';

import { Host } from '@azure-tools/autorest-extension-base';

type State = NewModelState<PwshModel>;

async function tweakModel(state: State): Promise<PwshModel> {
  const model = state.model;

  addResponseHeaderSchema(model);

  addDictionaryApiVersion(model);

  removeDictionaryDefaultDescription(model);

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

function addDictionaryApiVersion(model: CodeModel) {
  // If object has dictionary property, this property's schema does not have api version information in m4. We should add this back.

  model.schemas.objects?.forEach((schema) => {
    if (!schema.apiVersions) {
      return;
    }

    for (const prop of getAllProperties(schema)) {
      if ((prop.schema.type !== SchemaType.Dictionary && prop.schema.type !== SchemaType.Any) || prop.schema.apiVersions) {
        continue;
      }
      const dictSchema = prop.schema as DictionarySchema;
      if (dictSchema.elementType && dictSchema.elementType.apiVersions) {
        dictSchema.apiVersions = JSON.parse(JSON.stringify(dictSchema.elementType.apiVersions));
      } else {
        dictSchema.apiVersions = JSON.parse(JSON.stringify(schema.apiVersions));
      }
    }
  })
}

function removeDictionaryDefaultDescription(model: CodeModel) {
  // For dictionary schema and property, if there is no description assigned, m4 will set a default description like: Dictionary of <type>
  // To keep same action as m3, we will set it to empty string

  const visited = new Set<Schema>();
  [...model.schemas.objects ?? [], ...model.schemas.dictionaries ?? []].forEach((schema) => {
    recursiveRemoveDefaultDescription(schema, visited);
  })
}

function recursiveRemoveDefaultDescription(schema: Schema, visited: Set<Schema>) {
  if (visited.has(schema) || (schema.type !== SchemaType.Object && schema.type !== SchemaType.Dictionary)) {
    return;
  }
  // Default description pattern in m4
  const defaultDescPattern = /Dictionary of <.*>$/;
  visited.add(schema);
  if (schema.type === SchemaType.Dictionary) {
    const dictSchema = schema as DictionarySchema;
    recursiveRemoveDefaultDescription(dictSchema.elementType, visited);
    if (defaultDescPattern.test(dictSchema.language.default.description)) {
      dictSchema.language.default.description = '';
    }
  } else if (schema.type === SchemaType.Object) {
    const objSchema = schema as ObjectSchema;
    for (const prop of getAllProperties(objSchema)) {
      recursiveRemoveDefaultDescription(prop.schema, visited);
      if (prop.schema.type === SchemaType.Dictionary && defaultDescPattern.test(prop.language.default.description)) {
        prop.language.default.description = '';
      }
    }
  }
}


export async function tweakM4ModelPlugin(service: Host) {
  const state = await new NewModelState<PwshModel>(service).init();
  service.WriteFile('code-model-v4-tweakm4codemodel.yaml', serialize(await tweakModel(state)), undefined, 'code-model-v4');
}
