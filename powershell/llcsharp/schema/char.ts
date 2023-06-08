/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Variable } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { Schema as NewSchema, SchemaType, ChoiceSchema, ChoiceValue } from '@autorest/codemodel';
import { NewPrimitive } from './primitive';
import { length } from '@azure-tools/linq';


export class Char extends NewPrimitive {
  public isXmlAttribute = false;
  private choices?: Array<ChoiceValue>;
  jsonType = ClientRuntime.JsonString;

  constructor(schema: NewSchema, public isRequired: boolean) {
    super(schema);
    this.choices = schema.type === SchemaType.Choice ? (<ChoiceSchema>schema).choices : undefined;
  }

  get declaration(): string {
    return `char${this.isRequired ? '' : ' ?'}`;
  }

  get convertObjectMethod() {
    return 'global::System.Convert.Char';
  }

  validateValue(eventListener: Variable, property: Variable): string {
    return `
${this.validateEnum(property)}
    `.trim();
  }

  private validateEnum(property: Variable): string {
    if (!this.choices) {
      return '';
    }
    return '// todo validate enum choices';
  }
}