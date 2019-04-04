/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { ImportDirective, Namespace, Attribute } from '@microsoft.azure/codegen-csharp';
import { ClientRuntime } from '@microsoft.azure/autorest.csharp-v2';
import { State } from '../state';
import { ModuleClass } from '../module-class';
import { GeneratedAttribute } from '../powershell-declarations';

export class ServiceNamespace extends Namespace {
  public moduleClass: ModuleClass;

  public get outputFolder(): string {
    return this.state.project.moduleFolder;
  }

  constructor(public state: State, objectInitializer?: Partial<ServiceNamespace>) {
    super(state.model.details.csharp.namespace || 'INVALID.NAMESPACE', state.project);
    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // module class
    this.moduleClass = new ModuleClass(this, state);
    this.moduleClass.add(new Attribute(GeneratedAttribute, { parameters: [`"AutoRest"`, `"${state.project.autorestVersion}"`] }));
  }
}