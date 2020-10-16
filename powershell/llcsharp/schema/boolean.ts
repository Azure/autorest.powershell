/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Variable } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { Schema as NewSchema, BooleanSchema } from '@azure-tools/codemodel';
import { NewPrimitive } from './primitive';

export class NewBoolean extends NewPrimitive {
  isXmlAttribute = false;
  jsonType = ClientRuntime.JsonBoolean;

  constructor(schema: BooleanSchema, public isRequired: boolean) {
    super(schema);
  }

  get declaration(): string {
    return `bool${this.isRequired ? '' : '?'}`;
  }

  validateValue(eventListener: Variable, property: Variable): string {
    return '';
  }
}
