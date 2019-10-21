/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { components } from '@azure-tools/codemodel-v3';
import { BackedProperty, TypeDeclaration } from '@azure-tools/codegen-csharp';
import { DeepPartial } from '@azure-tools/codegen';

export class CmdletParameter extends BackedProperty {
  public parameterDefinition: components.IParameter;
  constructor(name: string, type: TypeDeclaration, parameterDefinition: components.IParameter, objectInitializer?: DeepPartial<CmdletParameter>) {
    super(name, type);
    this.parameterDefinition = parameterDefinition;
    this.apply(objectInitializer);
  }
}
