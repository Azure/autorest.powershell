/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutorestExtensionHost as Host } from '@autorest/extension-base';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { Project as codeDomProject } from '@azure-tools/codegen-csharp';

import { State } from './generator';
import { ModelsNamespace } from './model/namespace';
import { ApiClass } from './operation/api-class';
import { ServiceNamespace } from './operation/namespace';
import { SupportNamespace } from './enums/namespace';
import { DeepPartial } from '@azure-tools/codegen';
import { PropertyFormat } from '../utils/schema';

export class Project extends codeDomProject {

  public jsonSerialization = true;
  public xmlSerialization = false;
  public defaultPipeline = true;
  public emitSignals = true;
  public enableApiRetry = true;
  public exportPropertiesForDict!: boolean;
  public projectNamespace!: string;
  public overrides!: Dictionary<string>;
  public state!: State;

  apifolder!: string;
  runtimefolder!: string;
  azure!: boolean;
  license!: string;
  identityCorrection!: boolean;
  resourceGroupAppend!: boolean;
  supportJsonInput!: boolean;
  formats!: Dictionary<PropertyFormat>;

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
    this.identityCorrection = await this.state.getValue('identity-correction-for-post', this.azure ? true : false);
    this.resourceGroupAppend = await this.state.getValue('resourcegroup-append', this.azure ? true : false);
    this.license = await this.state.getValue('header-text', '');
    this.exportPropertiesForDict = await this.state.getValue('export-properties-for-dict', this.azure ? true : false);
    this.formats = await this.state.getValue('formats', {});
    if (this.azure) {
      this.supportJsonInput = await this.state.getValue('support-json-input', true);
    }
    else {
      this.supportJsonInput = await this.state.getValue('support-json-input', false);
    }
    this.enableApiRetry = await this.state.getValue('enable-api-retry', true);


    // add project namespace
    this.projectNamespace = this.state.model.language.csharp?.namespace;
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
      'Microsoft.RestClient': `${this.projectNamespace}.${this.state.model.language.csharp?.name}`,
      'Microsoft.Rest': this.projectNamespace,
      '#define DICT_PROPERTIES': this.exportPropertiesForDict ? '#define DICT_PROPERTIES' : '#define NO_DICT_PROPERTIES'
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