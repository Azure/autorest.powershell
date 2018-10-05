/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Class } from './class';
import { Namespace } from './namespace';

export class Struct extends Class {
  constructor(namespace: Namespace, name: string, public parent?: Struct, objectIntializer?: Partial<Struct>) {
    super(namespace, name);
    this.apply(objectIntializer);
    this.classOrStruct = "struct";
  }
}
