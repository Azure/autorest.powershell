/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Namespace } from '@azure/codegen-csharp';
import { State } from '../generator';

export class SupportNamespace extends Namespace {
  constructor(parent: Namespace, private state: State, objectInitializer?: Partial<SupportNamespace>) {
    super('Support', parent);
    this.apply(objectInitializer);
  }

  get outputFolder() {
    return 'Support';
  }
}
