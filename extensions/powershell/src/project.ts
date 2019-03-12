/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { deconstruct, pascalCase, Dictionary } from '@microsoft.azure/codegen';
import { SchemaDefinitionResolver } from '@microsoft.azure/autorest.csharp-v2';
import { State } from './state';
import { Project as codeDomProject } from '@microsoft.azure/codegen-csharp';
import { SupportNamespace } from './namespaces/support'
import { ModelExtensionsNamespace } from './namespaces/model-extensions'
import { ModelCmdletNamespace } from './namespaces/model-cmdlet'
import { ServiceNamespace } from './namespaces/service'
import { CmdletNamespace } from './namespaces/cmdlet'

export class Project extends codeDomProject {
  public azure!: boolean;
  public cmdletFolder!: string;
  public modelCmdletFolder!: string;
  public customFolder!: string;
  public testFolder!: string;
  public runtimeFolder!: string;
  public binFolder!: string;
  public objFolder!: string;
  public exportsFolder!: string;
  public docsFolder!: string;
  public serviceName!: string;
  public moduleName!: string;
  public csproj!: string;
  public nuspec!: string;
  public dllName!: string;
  public dll!: string;
  public psd1!: string;
  public psm1!: string;
  public psm1Custom!: string;
  public formatPs1xml!: string;
  public apiFolder!: string;
  public apiExtensionsFolder!: string;
  public baseFolder!: string;
  public moduleFolder!: string;
  public schemaDefinitionResolver: SchemaDefinitionResolver;
  public maxInlinedParameters!: number;
  public moduleVersion!: string;
  public skipModelCmdlets!: boolean;
  public prefix!: string;
  public projectNamespace: string;
  public overrides: Dictionary<string>;
  public get model() { return this.state.model; }

  constructor(protected state: State) {
    super();
    this.schemaDefinitionResolver = new SchemaDefinitionResolver();
    state.project = this;
    this.projectNamespace = state.model.details.csharp.namespace;

    this.overrides = {
      'Carbon.Json.Converters': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Internal.Extensions': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Internal': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Data': `${this.projectNamespace}.Runtime.Json`,
      'using Data;': '',
      'using Parser;': '',
      'using Converters;': '',
      'using Internal.Extensions;': '',

      'Carbon.Json.Parser': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Json': `${this.projectNamespace}.Runtime.Json`,
      'Microsoft.Rest.ClientRuntime': `${this.projectNamespace}.Runtime`,
      'Microsoft.Rest': `${this.projectNamespace}`,
    };
  }

  public async init(): Promise<this> {
    await super.init();
    const service = this.state.service;
    const model = this.state.model;
    const state = this.state;

    const mil = await service.GetValue('max-inlined-parameters');
    this.maxInlinedParameters = typeof mil === 'number' ? mil : 4;
    this.moduleVersion = await service.GetValue('module-version') || '1.0.0';

    // Flags
    this.skipModelCmdlets = !!(await service.GetValue('skip-model-cmdlets'));
    this.azure = await service.GetValue('azure') || await service.GetValue('azure-arm') || false;

    // Names
    this.prefix = await service.GetValue('prefix') || this.azure ? 'Az' : ``;
    this.serviceName = await service.GetValue('service-name') || pascalCase(deconstruct(model.info.title.replace(/client/ig, '')));
    this.moduleName = await service.GetValue('module-name') || !!this.prefix ? `${this.prefix}.${this.serviceName}` : this.serviceName;
    this.dllName = await service.GetValue('dll-name') || `${this.moduleName}.private`;

    // Folders
    this.baseFolder = await service.GetValue('base-folder') || '.';
    this.moduleFolder = await service.GetValue('module-folder') || `${this.baseFolder}/generated`;
    this.cmdletFolder = await service.GetValue('cmdlet-folder') || `${this.moduleFolder}/cmdlets`;
    this.modelCmdletFolder = await service.GetValue('model-cmdlet-folder') || `${this.moduleFolder}/model-cmdlets`;
    this.customFolder = await service.GetValue('custom-cmdlet-folder') || `${this.baseFolder}/custom`;
    this.testFolder = await service.GetValue('test-folder') || `${this.baseFolder}/test`;
    this.runtimeFolder = await service.GetValue('runtime-folder') || `${this.moduleFolder}/runtime`;
    this.apiFolder = await service.GetValue('api-folder') || `${this.moduleFolder}/api`;
    this.apiExtensionsFolder = await service.GetValue('api-extensions-folder') || `${this.moduleFolder}/api-extensions`;
    this.binFolder = await service.GetValue('bin-folder') || `${this.baseFolder}/bin`;
    this.objFolder = await service.GetValue('obj-folder') || `${this.baseFolder}/obj`;
    this.exportsFolder = await service.GetValue('exports-folder') || `${this.baseFolder}/exports`;
    this.docsFolder = await service.GetValue('docs-folder') || `${this.baseFolder}/docs`;

    // File paths
    this.csproj = await service.GetValue('csproj') || `${this.baseFolder}/${this.moduleName}.csproj`;
    this.dll = await service.GetValue('dll') || `${this.binFolder}/${this.dllName}.dll`;
    this.psd1 = await service.GetValue('psd1') || `${this.baseFolder}/${this.moduleName}.psd1`;
    this.psm1 = await service.GetValue('psm1') || `${this.baseFolder}/${this.moduleName}.psm1`;
    this.psm1Custom = await service.GetValue('psm1-custom') || `${this.customFolder}/${this.moduleName}.custom.psm1`;
    this.formatPs1xml = await service.GetValue('format-ps1xml') || `${this.baseFolder}/${this.moduleName}.format.ps1xml`;
    this.nuspec = await service.GetValue('nuspec') || `${this.baseFolder}/${this.moduleName}.nuspec`;

    // add project namespace
    this.addNamespace(this.serviceNamespace = new ServiceNamespace(state));
    this.addNamespace(this.supportNamespace = new SupportNamespace(this.serviceNamespace, state));
    this.addNamespace(this.modelCmdlets = new ModelCmdletNamespace(this.serviceNamespace, state));
    // add cmdlet namespace
    this.addNamespace(this.cmdlets = new CmdletNamespace(this.serviceNamespace, state));
    this.addNamespace(this.modelsExtensions = new ModelExtensionsNamespace(this.serviceNamespace, <any>state.model.schemas, state.path('components', 'schemas')));

    if (!this.skipModelCmdlets) {
      this.modelCmdlets.createModelCmdlets();
    }

    // abort now if we have any errors.
    state.checkpoint();
    return this;
  }

  public serviceNamespace!: ServiceNamespace;
  public supportNamespace!: SupportNamespace;
  public cmdlets!: CmdletNamespace;
  public modelCmdlets!: ModelCmdletNamespace;
  public modelsExtensions!: ModelExtensionsNamespace;
}
