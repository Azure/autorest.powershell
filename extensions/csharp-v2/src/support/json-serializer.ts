/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Modifier, Attribute } from '@microsoft.azure/codegen-csharp';
import { Class } from '@microsoft.azure/codegen-csharp';
import { Method } from '@microsoft.azure/codegen-csharp';

import { items } from '@microsoft.azure/codegen';
import { dotnet } from '@microsoft.azure/codegen-csharp';
import { Namespace } from '@microsoft.azure/codegen-csharp';
import { Parameter } from '@microsoft.azure/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { State } from '../generator';
import { GeneratedAttribute } from '../csharp-declarations';

export class JsonSerializerClass extends Class {

  constructor(namespace: Namespace, protected state: State, objectInitializer?: Partial<JsonSerializerClass>) {
    super(namespace, 'JsonSerialization');
    this.apply(objectInitializer);
    this.add(new Attribute(GeneratedAttribute, { parameters: [`"AutoRest"`, `"${state.project.autorestVersion}"`] }));

    this.partial = true;
    this.isStatic = true;

    const tojson = this.addMethod(new Method('ToJson', ClientRuntime.JsonNode, { static: Modifier.Static }));
    const objP = tojson.addParameter(new Parameter('obj', dotnet.ThisObject));
    const container = tojson.addParameter(new Parameter('container', ClientRuntime.JsonObject, { defaultInitializer: `= null` }));
    tojson.add(`return null;`);

    const schemas = state.model.schemas;

    // iterate thru all the models
    // each model should have a class and an interface.
    // if the class has a discriminator value, tell the parent model that it has children
    for (const { key: index, value: schema } of items(schemas)) {
      const state = this.state.path('components', 'schemas', index);
      if (schema.details.csharp && schema.details.csharp.classImplementation) {
        // must be a class.
        // const implData: CSharpSchemaDetails = schema.details.csharp;
      }

      schema.details;
      const x = state.project.modelsNamespace.resolveTypeDeclaration(schema, true, state);
    }
  }
}
