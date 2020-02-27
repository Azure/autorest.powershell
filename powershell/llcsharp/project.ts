/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@azure-tools/autorest-extension-base';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { Project as codeDomProject } from '@azure-tools/codegen-csharp';

import { State } from './generator';
import { ModelsNamespace } from './model/namespace';
import { ApiClass } from './operation/api-class';
import { ServiceNamespace } from './operation/namespace';
import { SupportNamespace } from './enums/namespace';
import { DeepPartial } from '@azure-tools/codegen';

export class Project extends codeDomProject {

  public jsonSerialization = true;
  public xmlSerialization = false;
  public defaultPipeline = true;
  public emitSignals = true;
  public projectNamespace!: string;
  public overrides!: Dictionary<string>;
  protected state!: State;

  apifolder!: string;
  runtimefolder!: string;
  azure!: boolean;
  license!: string;
  identityCorrection!: boolean;

  constructor(protected service: Host, objectInitializer?: DeepPartial<Project>) {
    super();
    this.apply(objectInitializer);
  }

  public async init(): Promise<this> {
    await super.init();

    this.state = await new State(this.service).init(this);
    this.apifolder = await this.state.getValue('api-folder', '');
    this.runtimefolder = await this.state.getValue('runtime-folder', 'runtime');
    this.azure = await this.state.getValue('azure', false) || await this.state.getValue('azure-arm', false);
    this.identityCorrection = await this.state.getValue('identity-correction-for-post', false);
    this.license = await this.state.getValue('header-text', '');


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

    this.serviceNamespace = new ServiceNamespace(this.state);
    this.serviceNamespace.header = this.license;
    this.addNamespace(this.serviceNamespace);

    // add support namespace
    this.supportNamespace = new SupportNamespace(this.serviceNamespace, this.state);
    this.supportNamespace.header = this.license;
    this.addNamespace(this.supportNamespace);

    // add model classes
    this.modelsNamespace = new ModelsNamespace(this.serviceNamespace, this.state.model.schemas, this.state.path('components', 'schemas'));
    this.modelsNamespace.header = this.license;
    this.addNamespace(this.modelsNamespace);

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
