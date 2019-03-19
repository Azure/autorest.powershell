/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { components } from '@microsoft.azure/autorest.codemodel-v3';
import { BackedProperty, TypeDeclaration } from '@microsoft.azure/codegen-csharp';

export class CmdletParameter extends BackedProperty {
  public parameterDefinition: components.IParameter;
  constructor(name: string, type: TypeDeclaration, parameterDefinition: components.IParameter, objectInitializer?: Partial<CmdletParameter>) {
    super(name, type);
    this.parameterDefinition = parameterDefinition;
    this.apply(objectInitializer);
  }
}
