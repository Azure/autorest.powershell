/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Variable } from '@microsoft.azure/autorest.codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { Primitive } from './primitive';

export class Boolean extends Primitive {
  isXmlAttribute: boolean = false;
  jsonType = ClientRuntime.JsonBoolean;

  constructor(schema: Schema, public isRequired: boolean) {
    super(schema);
  }

  get declaration(): string {
    return `bool${this.isRequired ? '' : '?'}`;
  }

  validateValue(eventListener: Variable, property: Variable): string {
    return ``;
  }
}
