/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Access, InterfaceProperty } from '@microsoft.azure/codegen-csharp';
import { Schema } from '../code-model';
import { State } from '../generator';

/* DEPRECATED, DELETE */
export class ModelInterfaceProperty extends InterfaceProperty {
  constructor(name: string, schema: Schema, isRequired: boolean, state: State, objectInitializer?: Partial<ModelInterfaceProperty>) {
    super(name, state.project.modelsNamespace.resolveTypeDeclaration(schema, isRequired, state.path('schema')));
    if (schema.readOnly) {
      this.setAccess = Access.Internal;
    }
    this.apply(objectInitializer);
  }
}
