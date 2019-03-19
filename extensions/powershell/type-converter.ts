/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Class, Namespace } from '@microsoft.azure/codegen-csharp';

import { State } from './state';

export class TypeConverter extends Class {
  constructor(name: string, namespace: Namespace, private state: State, objectInitializer?: Partial<TypeConverter>) {
    super(namespace, name);
    this.apply(objectInitializer);
  }
}
