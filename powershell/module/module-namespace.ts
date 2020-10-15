/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { ImportDirective, Namespace } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../llcsharp/exports';
import { NewState } from '../internal/state';
import { NewModuleClass } from './module-class';
import { DeepPartial } from '@azure-tools/codegen';

export class NewModuleNamespace extends Namespace {
  public moduleClass: NewModuleClass;

  public get outputFolder(): string {
    return this.state.project.moduleFolder;
  }

  constructor(public state: NewState, objectInitializer?: DeepPartial<NewModuleNamespace>) {
    super(state.model.language.csharp?.namespace || 'INVALID.NAMESPACE', state.project);
    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // module class
    this.moduleClass = new NewModuleClass(this, state);
  }
}