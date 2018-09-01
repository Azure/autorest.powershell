/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Import } from '#csharp/code-dom/import';
import { Namespace } from '#csharp/code-dom/namespace';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { State } from '../generator';

export class ServiceNamespace extends Namespace {
  constructor(public state: State, objectInitializer?: Partial<ServiceNamespace>) {
    super(state.model.details.csharp.namespace || 'INVALID.NAMESPACE', state.project);
    this.apply(objectInitializer);
    this.addUsing(new Import(`static ${ClientRuntime.Extensions}`));
  }
}
