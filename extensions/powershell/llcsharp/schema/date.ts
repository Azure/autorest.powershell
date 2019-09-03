/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { StringExpression } from '@azure-tools/codegen-csharp';
import { Schema } from '../code-model';
import { DateTime } from './date-time';

export class Date extends DateTime {
  public DateTimeFormat = new StringExpression('yyyy-MM-dd');
  constructor(schema: Schema, isRequired: boolean) {
    super(schema, isRequired);
  }
}
