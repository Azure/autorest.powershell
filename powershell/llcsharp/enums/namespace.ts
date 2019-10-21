/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Namespace } from '@azure-tools/codegen-csharp';
import { State } from '../generator';
import { DeepPartial } from '@azure-tools/codegen';

export class SupportNamespace extends Namespace {
  constructor(parent: Namespace, private state: State, objectInitializer?: DeepPartial<SupportNamespace>) {
    super('Support', parent);
    this.apply(objectInitializer);
  }

  get outputFolder() {
    return 'Support';
  }
}
