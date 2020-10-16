/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { nameof } from '@azure-tools/codegen';
import { Variable } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { NumberSchema } from '@azure-tools/codemodel';
import { NewPrimitive } from './primitive';


export class Numeric extends NewPrimitive {
  public isXmlAttribute = false;
  public jsonType = ClientRuntime.JsonNumber;

  constructor(schema: NumberSchema, public isRequired: boolean, protected numericType: string) {
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
    return (<NumberSchema>this.schema).minimum && !(<NumberSchema>this.schema).exclusiveMinimum ? `await ${eventListener}.AssertIsGreaterThanOrEqual(${nameof(property.value)},${property},${(<NumberSchema>this.schema).minimum});` : '';
  }
  protected validateMaximum(eventListener: Variable, property: Variable): string {
    return (<NumberSchema>this.schema).maximum && !(<NumberSchema>this.schema).exclusiveMaximum ? `await ${eventListener}.AssertIsLessThanOrEqual(${nameof(property.value)},${property},${(<NumberSchema>this.schema).maximum});` : '';
  }
  protected validateExclusiveMinimum(eventListener: Variable, property: Variable): string {
    return (<NumberSchema>this.schema).minimum && (<NumberSchema>this.schema).exclusiveMinimum ? `await ${eventListener}.AssertIsGreaterThan(${nameof(property.value)},${property},${(<NumberSchema>this.schema).minimum});` : '';
  }
  protected validateExclusiveMaximum(eventListener: Variable, property: Variable): string {
    return (<NumberSchema>this.schema).maximum && (<NumberSchema>this.schema).exclusiveMaximum ? `await ${eventListener}.AssertIsLessThan(${nameof(property.value)},${property},${(<NumberSchema>this.schema).maximum});` : '';
  }
  protected validateMultipleOf(eventListener: Variable, property: Variable): string {
    return (<NumberSchema>this.schema).multipleOf ? `await ${eventListener}.AssertIsMultipleOf(${nameof(property.value)},${property},${(<NumberSchema>this.schema).multipleOf});` : '';
  }

}