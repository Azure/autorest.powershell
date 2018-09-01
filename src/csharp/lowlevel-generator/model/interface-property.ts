/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Access } from '#csharp/code-dom/access-modifier';
import { InterfaceProperty } from '#csharp/code-dom/interface-property';
import { Property, Schema } from '#csharp/lowlevel-generator/code-model';
import { State } from '../generator';
import { ModelInterface } from './interface';

export class ModelInterfaceProperty extends InterfaceProperty {
  constructor(parent: ModelInterface, property: Property, state: State, objectInitializer?: Partial<ModelInterfaceProperty>) {
    super(property.details.csharp.name, state.project.modelsNamespace.resolveTypeDeclaration(property.schema, property.details.csharp.required, state.path('schema')));
    if (property.schema.readOnly) {
      this.setAccess = Access.Internal;
    }
    this.apply(objectInitializer);
  }
}
