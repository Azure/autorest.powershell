/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@microsoft.azure/autorest-extension-base';
import { Dictionary } from '@microsoft.azure/codegen';
import { Project as codeDomProject } from '@microsoft.azure/codegen-csharp';

import { State } from './generator';
import { ModelsNamespace } from './model/namespace';
import { ApiClass } from './operation/api-class';
import { ServiceNamespace } from './operation/namespace';
import { SupportNamespace } from './support/namespace';

export class Project extends codeDomProject {

  public jsonSerialization: boolean = true;
  public xmlSerialization: boolean = false;
  public defaultPipeline: boolean = true;
  public emitSignals: boolean = true;
  public projectNamespace!: string;
  public overrides!: Dictionary<string>;
  protected state!: State;

  apifolder!: string;
  runtimefolder!: string;
  azure!: boolean;

  constructor(protected service: Host, objectInitializer?: Partial<Project>) {
    super();
    this.apply(objectInitializer);
  }

  public async init(): Promise<this> {
    await super.init();

    this.state = await new State(this.service).init(this);
    this.apifolder = await this.state.getValue('api-folder', '');
    this.runtimefolder = await this.state.getValue('runtime-folder', 'runtime');
    this.azure = await this.state.getValue('azure', false) || await this.state.getValue('azure-arm', false);

    // add project namespace
    this.projectNamespace = this.state.model.details.csharp.namespace;
    this.overrides = {
      'Carbon.Json.Converters': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Internal.Extensions': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Internal': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Json.Parser': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Data': `${this.projectNamespace}.Runtime.Json`,
      'using Converters;': '',
      'using Internal.Extensions;': '',
      'using Data;': '',
      'using Parser;': '',

      'Carbon.Json': `${this.projectNamespace}.Runtime.Json`,
      'Microsoft.Rest.ClientRuntime': `${this.projectNamespace}.Runtime`,
      'Microsoft.Rest': this.projectNamespace
    };



    this.addNamespace(this.serviceNamespace = new ServiceNamespace(this.state));

    // add support namespace
    this.addNamespace(this.supportNamespace = new SupportNamespace(this.serviceNamespace, this.state));

    // add model classes
    this.addNamespace(this.modelsNamespace = new ModelsNamespace(this.serviceNamespace, this.state.model.schemas, this.state.path('components', 'schemas')));

    // create API class
    new ApiClass(this.serviceNamespace, this.state, { description: `Low-level API implementation for the ${this.state.model.info.title} service. \n${this.state.model.info.description || ''}` });

    // abort now if we have any errors.
    this.state.checkpoint();

    return this;
  }

  public serviceNamespace!: ServiceNamespace;
  public modelsNamespace!: ModelsNamespace;
  public supportNamespace!: SupportNamespace;
}
