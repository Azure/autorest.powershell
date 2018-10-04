/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Class } from '#csharp/code-dom/class';
import { Namespace } from '#csharp/code-dom/namespace';
import { State } from '#powershell/state';

export class TypeConverter extends Class {
  constructor(name: string, namespace: Namespace, private state: State, objectInitializer?: Partial<TypeConverter>) {
    super(namespace, name);
    this.apply(objectInitializer);
  }
}
