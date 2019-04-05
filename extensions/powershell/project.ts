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
import { codemodel } from '@microsoft.azure/autorest.codemodel-v3';

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
  public schemaDefinitionResolver!: SchemaDefinitionResolver;
  public moduleVersion!: string;
  public profiles!: string[];
  public skipModelCmdlets!: boolean;
  public prefix!: string;
  public subjectPrefix!: string;
  public projectNamespace!: string;
  public overrides!: Dictionary<string>;
  public serviceNamespace!: ServiceNamespace;
  public supportNamespace!: SupportNamespace;
  public cmdlets!: CmdletNamespace;
  public modelCmdlets!: ModelCmdletNamespace;
  public modelsExtensions!: ModelExtensionsNamespace;
  public accountsVersionMinimum!: string;
  public platyPsVersionMinimum!: string;
  public dependencyModuleFolder!: string;
  public state!: State;
  get model() { return <codemodel.Model>this.state.model };

  constructor(protected service: Host, objectInitializer?: Partial<Project>) {
    super();
    this.apply(objectInitializer);
  }


  public async init(): Promise<this> {
    await super.init();
    this.state = await new State(this.service).init(this);

    this.schemaDefinitionResolver = new SchemaDefinitionResolver();

    this.projectNamespace = this.state.model.details.csharp.namespace;


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

    // Values
    this.moduleVersion = await this.getConfigValue('module-version');
    this.profiles = this.model.info.extensions['x-ms-metadata'].profiles || [];
    this.accountsVersionMinimum = '1.4.0';
    this.platyPsVersionMinimum = '0.14.0';

    // Flags
    this.skipModelCmdlets = await this.getConfigValue('skip-model-cmdlets');
    this.azure = this.model.details.default.isAzure;

    // Names
    this.prefix = this.model.details.default.prefix;
    this.serviceName = this.model.details.default.serviceName;
    this.subjectPrefix = this.model.details.default.subjectPrefix;
    this.moduleName = await this.getConfigValue('module-name');
    this.dllName = await this.getConfigValue('dll-name');

    // Folders
    this.baseFolder = await this.getConfigValue('current-folder');
    this.moduleFolder = await this.getConfigValue('module-folder');
    this.cmdletFolder = await this.getConfigValue('cmdlet-folder');
    this.modelCmdletFolder = await this.getConfigValue('model-cmdlet-folder');
    this.customFolder = await this.getConfigValue('custom-cmdlet-folder');
    this.internalFolder = await this.getConfigValue('internal-cmdlet-folder');
    this.testFolder = await this.getConfigValue('test-folder');
    this.runtimeFolder = await this.getConfigValue('runtime-folder');
    this.apiFolder = await this.getConfigValue('api-folder');
    this.apiExtensionsFolder = await this.getConfigValue('api-extensions-folder');
    this.binFolder = await this.getConfigValue('bin-folder');
    this.objFolder = await this.getConfigValue('obj-folder');
    this.exportsFolder = await this.getConfigValue('exports-folder');
    this.docsFolder = await this.getConfigValue('docs-folder');
    this.dependencyModuleFolder = await this.getConfigValue('dependency-module-folder');
    this.examplesFolder = await this.getConfigValue('examples-folder');

    // File paths
    this.csproj = await this.getConfigValue('csproj');
    this.dll = await this.getConfigValue('dll');
    this.psd1 = await this.getConfigValue('psd1');
    this.psm1 = await this.getConfigValue('psm1');
    this.psm1Custom = await this.getConfigValue('psm1-custom');
    this.psm1Internal = await this.getConfigValue('psm1-internal');
    this.formatPs1xml = await this.getConfigValue('format-ps1xml');
    this.nuspec = await this.getConfigValue('nuspec');
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

  public async getConfigValue<T>(key: string, defaultValue?: T): Promise<T> {
    const value = await this.state.getValue(key);
    // GetValue returns null when values are not found.
    if (defaultValue === undefined && value === null) {
      throw new Error(`No value for configuration key '${key}' was provided`);
    }
    return <T>(value !== null ? value : defaultValue);
  }
}
