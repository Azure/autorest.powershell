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
import { Channel } from '@microsoft.azure/autorest-extension-base';
import { Model } from '@microsoft.azure/autorest.codemodel-v3/dist/code-model/code-model';
import { IAutoRestPluginInitiator } from '@microsoft.azure/autorest-extension-base/dist/lib/extension-base';

export class Project extends codeDomProject {
  public azure!: boolean;
  public cmdletFolder!: string;
  public modelCmdletFolder!: string;
  public customFolder!: string;
  public internalFolder!: string;
  public testFolder!: string;
  public runtimeFolder!: string;
  public binFolder!: string;
  public objFolder!: string;
  public exportsFolder!: string;
  public docsFolder!: string;
  public examplesFolder!: string;
  public serviceName!: string;
  public moduleName!: string;
  public csproj!: string;
  public nuspec!: string;
  public gitIgnore!: string;
  public gitAttributes!: string;
  public dllName!: string;
  public dll!: string;
  public psd1!: string;
  public psm1!: string;
  public psm1Custom!: string;
  public psm1Internal!: string;
  public formatPs1xml!: string;
  public apiFolder!: string;
  public apiExtensionsFolder!: string;
  public baseFolder!: string;
  public moduleFolder!: string;
  public schemaDefinitionResolver: SchemaDefinitionResolver;
  public maxInlinedParameters!: number;
  public moduleVersion!: string;
  public profiles!: string[];
  public skipModelCmdlets!: boolean;
  public prefix!: string;
  public subjectPrefix!: string;
  public projectNamespace: string;
  public overrides: Dictionary<string>;
  public serviceNamespace!: ServiceNamespace;
  public supportNamespace!: SupportNamespace;
  public cmdlets!: CmdletNamespace;
  public modelCmdlets!: ModelCmdletNamespace;
  public modelsExtensions!: ModelExtensionsNamespace;
  public accountsVersionMinimum!: string;
  public platyPsVersionMinimum!: string;
  public dependencyModuleFolder!: string;

  private model!: Model;
  private service!: IAutoRestPluginInitiator;

  constructor(protected state: State) {
    super();
    this.schemaDefinitionResolver = new SchemaDefinitionResolver();
    state.project = this;
    this.projectNamespace = state.model.details.csharp.namespace;
    this.service = state.service;
    this.model = state.model;

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

    // Values
    this.maxInlinedParameters = await this.getConfigValue('max-inlined-parameters', 4);
    this.moduleVersion = await this.getConfigValue('module-version', '0.1.0');
    this.profiles = await this.getConfigValue('profile', <string[]>[]);
    this.accountsVersionMinimum = '1.4.0';
    this.platyPsVersionMinimum = '0.13.1';

    // Flags
    this.skipModelCmdlets = await this.getConfigValue('skip-model-cmdlets', false);
    this.azure = this.model.details.default.isAzure;

    // Names
    this.prefix = this.model.details.default.prefix;
    this.serviceName = this.model.details.default.serviceName;
    this.subjectPrefix = this.model.details.default.subjectPrefix;

    // Add subjectPrefix to the model so it can be used by the plugin-create-commands plugin.
    this.model.details.default.subjectPrefix = this.subjectPrefix;

    this.moduleName = await this.getConfigValue('module-name', !!this.prefix ? `${this.prefix}.${this.serviceName}` : this.serviceName);
    this.dllName = await this.getConfigValue('dll-name', `${this.moduleName}.private`);

    // Folders
    this.baseFolder = await this.getConfigValue('base-folder', '.');
    this.moduleFolder = await this.getConfigValue('module-folder', `${this.baseFolder}/generated`);
    this.cmdletFolder = await this.getConfigValue('cmdlet-folder', `${this.moduleFolder}/cmdlets`);
    this.modelCmdletFolder = await this.getConfigValue('model-cmdlet-folder', `${this.moduleFolder}/model-cmdlets`);
    this.customFolder = await this.getConfigValue('custom-cmdlet-folder', `${this.baseFolder}/custom`);
    this.internalFolder = await this.getConfigValue('internal-cmdlet-folder', `${this.baseFolder}/internal`);
    this.testFolder = await this.getConfigValue('test-folder', `${this.baseFolder}/test`);
    this.runtimeFolder = await this.getConfigValue('runtime-folder', `${this.moduleFolder}/runtime`);
    this.apiFolder = await this.getConfigValue('api-folder', `${this.moduleFolder}/api`);
    this.apiExtensionsFolder = await this.getConfigValue('api-extensions-folder', `${this.moduleFolder}/api-extensions`);
    this.binFolder = await this.getConfigValue('bin-folder', `${this.baseFolder}/bin`);
    this.objFolder = await this.getConfigValue('obj-folder', `${this.baseFolder}/obj`);
    this.exportsFolder = await this.getConfigValue('exports-folder', `${this.baseFolder}/exports`);
    this.docsFolder = await this.getConfigValue('docs-folder', `${this.baseFolder}/docs`);
    this.dependencyModuleFolder = await this.getConfigValue('dependency-module-folder', `${this.moduleFolder}/modules`);
    this.examplesFolder = await this.getConfigValue('examples-folder', `${this.baseFolder}/examples`);

    // File paths
    this.csproj = await this.getConfigValue('csproj', `${this.baseFolder}/${this.moduleName}.csproj`);
    this.dll = await this.getConfigValue('dll', `${this.binFolder}/${this.dllName}.dll`);
    this.psd1 = await this.getConfigValue('psd1', `${this.baseFolder}/${this.moduleName}.psd1`);
    this.psm1 = await this.getConfigValue('psm1', `${this.baseFolder}/${this.moduleName}.psm1`);
    this.psm1Custom = await this.getConfigValue('psm1-custom', `${this.customFolder}/${this.moduleName}.custom.psm1`);
    this.psm1Internal = await this.getConfigValue('psm1-internal', `${this.internalFolder}/${this.moduleName}.internal.psm1`);
    this.formatPs1xml = await this.getConfigValue('format-ps1xml', `${this.baseFolder}/${this.moduleName}.format.ps1xml`);
    this.nuspec = await this.getConfigValue('nuspec', `${this.baseFolder}/${this.moduleName}.nuspec`);
    this.gitIgnore = `${this.baseFolder}/.gitignore`;
    this.gitAttributes = `${this.baseFolder}/.gitattributes`;

    // add project namespace
    this.addNamespace(this.serviceNamespace = new ServiceNamespace(this.state));
    this.addNamespace(this.supportNamespace = new SupportNamespace(this.serviceNamespace, this.state));
    this.addNamespace(this.modelCmdlets = new ModelCmdletNamespace(this.serviceNamespace, this.state));
    // add cmdlet namespace
    this.addNamespace(this.cmdlets = new CmdletNamespace(this.serviceNamespace, this.state));
    this.addNamespace(this.modelsExtensions = new ModelExtensionsNamespace(this.serviceNamespace, <any>this.state.model.schemas, this.state.path('components', 'schemas')));

    if (!this.skipModelCmdlets) {
      this.modelCmdlets.createModelCmdlets();
    }

    // abort now if we have any errors.
    this.state.checkpoint();
    return this;
  }

  private async getConfigValue<T>(key: string, defaultValue: T): Promise<T> {
    // GetValue returns null when values are not found.
    const value = await this.service.GetValue(key);
    return value !== null ? <T>value : defaultValue;
  }
}
