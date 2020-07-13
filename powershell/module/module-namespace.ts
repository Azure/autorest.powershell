/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { ImportDirective, Namespace } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../llcsharp/exports';
import { State, NewState } from '../internal/state';
import { ModuleClass, NewModuleClass } from './module-class';
import { DeepPartial } from '@azure-tools/codegen';

export class ModuleNamespace extends Namespace {
  public moduleClass: ModuleClass;

  public get outputFolder(): string {
    return this.state.project.moduleFolder;
  }

  constructor(public state: State, objectInitializer?: DeepPartial<ModuleNamespace>) {
    super(state.model.details.csharp.namespace || 'INVALID.NAMESPACE', state.project);
    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // module class
    this.moduleClass = new ModuleClass(this, state);
  }
}

export class NewModuleNamespace extends Namespace {
  public moduleClass: NewModuleClass;

  public get outputFolder(): string {
    return this.state.project.moduleFolder;
  }

  constructor(public state: NewState, objectInitializer?: DeepPartial<ModuleNamespace>) {
    super(state.model.language.csharp?.namespace || 'INVALID.NAMESPACE', state.project);
    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // module class
    this.moduleClass = new NewModuleClass(this, state);
  }
}