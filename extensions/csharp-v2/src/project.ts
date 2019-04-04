/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Dictionary } from '@microsoft.azure/codegen';

import { Project as codeDomProject } from '@microsoft.azure/codegen-csharp';

import { State } from './generator';
import { ModelsNamespace } from './model/namespace';
import { ApiClass } from './operation/api-class';
import { ServiceNamespace } from './operation/namespace';
import { SupportNamespace } from './support/namespace';

export class Project extends codeDomProject {
  public autorestVersion!: string;
  public storagePipeline: boolean = false;
  public jsonSerialization: boolean = true;
  public xmlSerialization: boolean = false;
  public defaultPipeline: boolean = true;
  public emitSignals: boolean = true;
  public projectNamespace: string;
  public overrides: Dictionary<string>;

  constructor(protected state: State) {
    super();
    state.project = this;
    // add project namespace
    this.projectNamespace = state.model.details.csharp.namespace;
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
  }

  public async init(): Promise<this> {
    await super.init();

    const service = this.state.service;
    this.storagePipeline = await service.GetValue('use-storage-pipeline') || false;
    if (this.storagePipeline) {
      this.emitSignals = false;
      this.jsonSerialization = false;
      this.xmlSerialization = true;
      this.defaultPipeline = false;
    }

    // used for GeneratedCodeAttribute
    this.autorestVersion = await service.GetValue('autorest-version');

    this.addNamespace(this.serviceNamespace = new ServiceNamespace(this.state));

    // add support namespace
    this.addNamespace(this.supportNamespace = new SupportNamespace(this.serviceNamespace, this.state));

    // add model classes
    this.addNamespace(this.modelsNamespace = new ModelsNamespace(this.serviceNamespace, this.state.model.schemas, this.state.path('components', 'schemas')));

    // create API class
    new ApiClass(this.serviceNamespace, this.state, { description: `Low-level API implementation for the ${this.state.model.info.title} service. \n${this.state.model.info.description || ''}` });

    // if (this.jsonSerialization) {
    // create serialization support
    // new JsonSerializerClass(this.supportNamespace, this.state);
    // }
    // this.modelsNamespace.add(new ImportDirective(this.supportNamespace.fullName));

    // abort now if we have any errors.
    this.state.checkpoint();

    return this;
  }

  public serviceNamespace!: ServiceNamespace;
  public modelsNamespace!: ModelsNamespace;
  public supportNamespace!: SupportNamespace;
}
