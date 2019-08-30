/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { nameof } from '@azure/codegen';
import { Variable } from '@azure/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { Primitive } from './primitive';

export class Numeric extends Primitive {
  public isXmlAttribute = false;
  public jsonType = ClientRuntime.JsonNumber;

  constructor(schema: Schema, public isRequired: boolean, protected numericType: string) {
    super(schema);
  }
  get declaration(): string {
    return `${this.numericType}`;
  }
  validateValue(eventListener: Variable, property: Variable): string {
    return `
${this.validateMinimum(eventListener, property)}
${this.validateMaximum(eventListener, property)}
${this.validateExclusiveMinimum(eventListener, property)}
${this.validateExclusiveMaximum(eventListener, property)}
${this.validateMultipleOf(eventListener, property)}
`.trim();
  }
  protected validateMinimum(eventListener: Variable, property: Variable): string {
    return this.schema.minimum && !this.schema.exclusiveMinimum ? `await ${eventListener}.AssertIsGreaterThanOrEqual(${nameof(property.value)},${property},${this.schema.minimum});` : '';
  }
  protected validateMaximum(eventListener: Variable, property: Variable): string {
    return this.schema.maximum && !this.schema.exclusiveMaximum ? `await ${eventListener}.AssertIsLessThanOrEqual(${nameof(property.value)},${property},${this.schema.maximum});` : '';
  }
  protected validateExclusiveMinimum(eventListener: Variable, property: Variable): string {
    return this.schema.minimum && this.schema.exclusiveMinimum ? `await ${eventListener}.AssertIsGreaterThan(${nameof(property.value)},${property},${this.schema.minimum});` : '';
  }
  protected validateExclusiveMaximum(eventListener: Variable, property: Variable): string {
    return this.schema.maximum && this.schema.exclusiveMaximum ? `await ${eventListener}.AssertIsLessThan(${nameof(property.value)},${property},${this.schema.maximum});` : '';
  }
  protected validateMultipleOf(eventListener: Variable, property: Variable): string {
    return this.schema.multipleOf ? `await ${eventListener}.AssertIsMultipleOf(${nameof(property.value)},${property},${this.schema.multipleOf});` : '';
  }

}
