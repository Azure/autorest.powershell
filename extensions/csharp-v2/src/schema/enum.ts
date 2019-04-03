/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Schema } from '../code-model';
import { String } from './string';

export class EnumImplementation extends String {
  public isXmlAttribute: boolean = false;

  constructor(schema: Schema, isRequired: boolean) {
    super(schema, isRequired);
  }


  get declaration(): string { return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.name}`; }
}
