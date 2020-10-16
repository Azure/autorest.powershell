/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { nameof } from '@azure-tools/codegen';
import { Variable } from '@azure-tools/codegen-csharp';
import { Schema } from '../code-model';
import { StringSchema } from '@azure-tools/codemodel';
import { NewString } from './string';


export class NewUuid extends NewString {
  constructor(schema: StringSchema, isRequired: boolean) {
    super(schema, isRequired);
  }

  get declaration(): string {
    return 'string';
  }
  public validatePresence(eventListener: Variable, property: Variable): string {
    return this.isRequired ? `await ${eventListener}.AssertNotNull(${nameof(property.value)},${property});`.trim() : '';
  }
  validateValue(eventListener: Variable, property: Variable): string {
    return `await ${eventListener}.AssertRegEx(${nameof(property.value)},${property},@"^[0-9a-fA-F]{8}(-[0-9a-fA-F]{4}){3}-[0-9a-fA-F]{12}$");`;
  }
}
