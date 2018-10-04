/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { IParameter } from '#common/code-model/components';
import { BackedProperty } from '#csharp/code-dom/property';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';

export class CmdletParameter extends BackedProperty {
  public parameterDefinition: IParameter;
  constructor(name: string, type: TypeDeclaration, parameterDefinition: IParameter, objectInitializer?: Partial<CmdletParameter>) {
    super(name, type);
    this.parameterDefinition = parameterDefinition;
    this.apply(objectInitializer);
  }
}
