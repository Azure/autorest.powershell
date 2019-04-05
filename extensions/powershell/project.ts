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
import { Host } from '@microsoft.azure/autorest-extension-base';
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
    this.moduleVersion = await Project.getConfigValue(this.service, 'module-version');
    this.profiles = this.model.info.extensions['x-ms-metadata'].profiles || [];
    this.accountsVersionMinimum = '1.4.0';
    this.platyPsVersionMinimum = '0.14.0';

    // Flags
    this.skipModelCmdlets = await Project.getConfigValue(this.service, 'skip-model-cmdlets');
    this.azure = this.model.details.default.isAzure;

    // Names
    this.prefix = this.model.details.default.prefix;
    this.serviceName = this.model.details.default.serviceName;
    this.subjectPrefix = this.model.details.default.subjectPrefix;
    this.moduleName = await Project.getConfigValue(this.service, 'module-name');
    this.dllName = await Project.getConfigValue(this.service, 'dll-name');

    // Folders
    this.baseFolder = await Project.getConfigValue(this.service, 'current-folder');
    this.moduleFolder = await Project.getConfigValue(this.service, 'module-folder');
    this.cmdletFolder = await Project.getConfigValue(this.service, 'cmdlet-folder');
    this.modelCmdletFolder = await Project.getConfigValue(this.service, 'model-cmdlet-folder');
    this.customFolder = await Project.getConfigValue(this.service, 'custom-cmdlet-folder');
    this.internalFolder = await Project.getConfigValue(this.service, 'internal-cmdlet-folder');
    this.testFolder = await Project.getConfigValue(this.service, 'test-folder');
    this.runtimeFolder = await Project.getConfigValue(this.service, 'runtime-folder');
    this.apiFolder = await Project.getConfigValue(this.service, 'api-folder');
    this.apiExtensionsFolder = await Project.getConfigValue(this.service, 'api-extensions-folder');
    this.binFolder = await Project.getConfigValue(this.service, 'bin-folder');
    this.objFolder = await Project.getConfigValue(this.service, 'obj-folder');
    this.exportsFolder = await Project.getConfigValue(this.service, 'exports-folder');
    this.docsFolder = await Project.getConfigValue(this.service, 'docs-folder');
    this.dependencyModuleFolder = await Project.getConfigValue(this.service, 'dependency-module-folder');
    this.examplesFolder = await Project.getConfigValue(this.service, 'examples-folder');

    // File paths
    this.csproj = await Project.getConfigValue(this.service, 'csproj');
    this.dll = await Project.getConfigValue(this.service, 'dll');
    this.psd1 = await Project.getConfigValue(this.service, 'psd1');
    this.psm1 = await Project.getConfigValue(this.service, 'psm1');
    this.psm1Custom = await Project.getConfigValue(this.service, 'psm1-custom');
    this.psm1Internal = await Project.getConfigValue(this.service, 'psm1-internal');
    this.formatPs1xml = await Project.getConfigValue(this.service, 'format-ps1xml');
    this.nuspec = await Project.getConfigValue(this.service, 'nuspec');
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

  public static async getConfigValue<T>(service: Host, key: string, defaultValue?: T): Promise<T> {
    const value = await service.GetValue(key);
    // GetValue returns null when values are not found.
    if (defaultValue === undefined && value === null) {
      throw new Error(`No value for configuration key '${key}' was provided`);
    }
    return <T>(value !== null ? value : defaultValue);
  }
}
