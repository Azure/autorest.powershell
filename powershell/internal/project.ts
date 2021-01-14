/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Dictionary } from '@azure-tools/linq';
import { SchemaDetails, LanguageDetails, EnhancedTypeDeclaration, Boolean, SchemaDefinitionResolver } from '../llcsharp/exports';
import { State } from './state';
import { Project as codeDomProject } from '@azure-tools/codegen-csharp';
import { EnumNamespace } from '../enums/namespace';
import { ModelExtensionsNamespace } from '../models/model-extensions';

import { ModuleNamespace } from '../module/module-namespace';
import { CmdletNamespace } from '../cmdlets/namespace';
import { Host } from '@azure-tools/autorest-extension-base';
import { codemodel, PropertyDetails, exportedModels as T } from '@azure-tools/codemodel-v3';
import { DeepPartial } from '@azure-tools/codegen';
import { PwshModel } from '../utils/PwshModel';
import { ModelState } from '../utils/model-state';
import { BooleanSchema, ChoiceSchema, ConstantSchema, Schema as NewSchema, SchemaType } from '@azure-tools/codemodel';

export type Schema = T.SchemaT<LanguageDetails<SchemaDetails>, LanguageDetails<PropertyDetails>>;

export interface Metadata {
  authors: string;
  owners: string;
  requireLicenseAcceptance: boolean;
  description: string;
  copyright: string;
  tags: string;
  companyName: string;
  licenseUri: string;
  projectUri: string;
  manifest: Manifest;
}

export interface Manifest {
  requiredModules: PsRequiredModule[];
  requiredModulesAsString: string;
  requiredAssemblies: string[];
  requiredAssembliesAsString: string;
  nestedModules: string[];
  nestedModulesAsString: string;
  formatsToProcess: string[];
  formatsToProcessAsString: string;
  typesToProcess: string[];
  typesToProcessAsString: string;
  scriptsToProcess: string[];
  scriptsToProcessAsString: string;
  functionsToExport: string[];
  functionsToExportAsString: string;
  cmdletsToExport: string[];
  cmdletsToExportAsString: string;
  aliasesToExport: string[];
  aliasesToExportAsString: string;
}

export interface PsRequiredModule {
  name: string;
  version: string;
}

export class NewPSSwitch extends Boolean {
  get declaration(): string {
    return `global::System.Management.Automation.SwitchParameter${this.isRequired ? '' : '?'}`;
  }

}
export class PSSchemaResolver extends SchemaDefinitionResolver {
  inResolve = false;
  resolveTypeDeclaration(schema: NewSchema | undefined, required: boolean, state: ModelState<PwshModel>): EnhancedTypeDeclaration {
    const before = this.inResolve;
    try {
      if (!this.inResolve) {
        this.inResolve = true;
        if (schema && (schema.type === SchemaType.Boolean
          || (schema.type === SchemaType.Constant && (<ConstantSchema>schema).valueType.type === SchemaType.Boolean)
          || (schema.type === SchemaType.Choice && (<any>schema).choiceType.type === SchemaType.Boolean))) {
          return new NewPSSwitch(<BooleanSchema>schema, required);
        }
      }

      return super.resolveTypeDeclaration(schema, required, state);
    } finally {
      this.inResolve = before;
    }
  }
}


export class Project extends codeDomProject {
  public azure!: boolean;
  public license!: string;
  public cmdletFolder!: string;

  public customFolder!: string;
  public utilsFolder!: string;
  public internalFolder!: string;
  public testFolder!: string;
  public runtimeFolder!: string;
  public binFolder!: string;
  public objFolder!: string;
  public exportsFolder!: string;
  public docsFolder!: string;
  public examplesFolder!: string;
  public resourcesFolder!: string;
  public serviceName!: string;
  public moduleName!: string;
  public csproj!: string;
  public nuspec!: string;
  public gitIgnore!: string;
  public gitAttributes!: string;
  public readme!: string;
  public dllName!: string;
  public dll!: string;
  public psd1!: string;
  public psm1!: string;
  public psm1Custom!: string;
  public psm1Internal!: string;
  public formatPs1xml!: string;
  public apiFolder!: string;
  public baseFolder!: string;
  public moduleFolder!: string;
  public schemaDefinitionResolver!: SchemaDefinitionResolver;
  public moduleVersion!: string;
  public profiles!: Array<string>;

  public prefix!: string;
  public subjectPrefix!: string;
  public projectNamespace!: string;
  public overrides!: Dictionary<string>;
  public serviceNamespace!: ModuleNamespace;
  public supportNamespace!: EnumNamespace;
  public cmdlets!: CmdletNamespace;

  public modelsExtensions!: ModelExtensionsNamespace;
  public accountsVersionMinimum!: string;
  public dependencyModuleFolder!: string;
  public metadata!: Metadata;
  public state!: State;
  public helpLinkPrefix!: string;
  get model() { return <PwshModel>this.state.model; }

  constructor(protected service: Host, objectInitializer?: DeepPartial<Project>) {
    super();
    this.apply(objectInitializer);
  }


  public async init(): Promise<this> {
    await super.init();
    this.state = await new State(this.service).init(this);

    this.schemaDefinitionResolver = new PSSchemaResolver();

    this.projectNamespace = this.state.model.language.csharp?.namespace || '';


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
    this.moduleVersion = await this.state.getValue('module-version');
    // skip-for-time-being
    //this.profiles = this.model.info.extensions['x-ms-metadata'].profiles || [];
    this.profiles = [];
    this.accountsVersionMinimum = '1.8.1';
    this.helpLinkPrefix = await this.state.getValue('help-link-prefix');
    this.metadata = await this.state.getValue<Metadata>('metadata');
    this.preprocessMetadata();
    this.license = await this.state.getValue('header-text', '');

    // Flags
    this.azure = this.model.language.default.isAzure;

    // Names
    this.prefix = this.model.language.default.prefix;
    this.serviceName = this.model.language.default.serviceName;
    this.subjectPrefix = this.model.language.default.subjectPrefix;
    this.moduleName = await this.state.getValue('module-name');
    this.dllName = await this.state.getValue('dll-name');

    // Folders
    this.baseFolder = await this.state.getValue('current-folder');
    this.moduleFolder = await this.state.getValue('module-folder');
    this.cmdletFolder = await this.state.getValue('cmdlet-folder');

    this.customFolder = await this.state.getValue('custom-cmdlet-folder');
    this.utilsFolder = await this.state.getValue('utils-cmdlet-folder');
    this.internalFolder = await this.state.getValue('internal-cmdlet-folder');
    this.testFolder = await this.state.getValue('test-folder');
    this.runtimeFolder = await this.state.getValue('runtime-folder');
    this.apiFolder = await this.state.getValue('api-folder');

    this.binFolder = await this.state.getValue('bin-folder');
    this.objFolder = await this.state.getValue('obj-folder');
    this.exportsFolder = await this.state.getValue('exports-folder');
    this.docsFolder = await this.state.getValue('docs-folder');
    this.dependencyModuleFolder = await this.state.getValue('dependency-module-folder');
    this.examplesFolder = await this.state.getValue('examples-folder');
    this.resourcesFolder = await this.state.getValue('resources-folder');

    // File paths
    this.csproj = await this.state.getValue('csproj');
    this.dll = await this.state.getValue('dll');
    this.psd1 = await this.state.getValue('psd1');
    this.psm1 = await this.state.getValue('psm1');
    this.psm1Custom = await this.state.getValue('psm1-custom');
    this.psm1Internal = await this.state.getValue('psm1-internal');
    this.formatPs1xml = await this.state.getValue('format-ps1xml');
    this.nuspec = await this.state.getValue('nuspec');
    this.gitIgnore = `${this.baseFolder}/.gitignore`;
    this.gitAttributes = `${this.baseFolder}/.gitattributes`;
    this.readme = `${this.baseFolder}/readme.md`;

    // add project namespace
    this.serviceNamespace = new ModuleNamespace(this.state);
    this.serviceNamespace.header = this.license;
    this.addNamespace(this.serviceNamespace);

    this.supportNamespace = new EnumNamespace(this.serviceNamespace, this.state);
    this.supportNamespace.header = this.license;
    this.addNamespace(this.supportNamespace);

    this.modelsExtensions = new ModelExtensionsNamespace(this.serviceNamespace, <any>this.state.model.schemas, this.state.path('components', 'schemas'));
    this.modelsExtensions.header = this.license;
    this.addNamespace(this.modelsExtensions);

    // add cmdlet namespace
    this.cmdlets = await new CmdletNamespace(this.serviceNamespace, this.state).init();
    this.cmdlets.header = this.license;
    this.addNamespace(this.cmdlets);


    // abort now if we have any errors.
    this.state.checkpoint();
    return this;
  }

  private preprocessMetadata() {
    this.metadata.manifest = {
      ...this.metadata.manifest,
      requiredModulesAsString: this.metadata.manifest.requiredModules.map(m => `@{ModuleName = '${m.name}'; ModuleVersion = '${m.version}'}`).join(', '),
      requiredAssembliesAsString: this.convertToPsListAsString(this.metadata.manifest.requiredAssemblies) || '',
      nestedModulesAsString: this.convertToPsListAsString(this.metadata.manifest.nestedModules) || '',
      formatsToProcessAsString: this.convertToPsListAsString(this.metadata.manifest.formatsToProcess) || '',
      typesToProcessAsString: this.convertToPsListAsString(this.metadata.manifest.typesToProcess) || '',
      scriptsToProcessAsString: this.convertToPsListAsString(this.metadata.manifest.scriptsToProcess) || '',
      functionsToExportAsString: this.convertToPsListAsString(this.metadata.manifest.functionsToExport) || '',
      cmdletsToExportAsString: this.convertToPsListAsString(this.metadata.manifest.cmdletsToExport) || '',
      aliasesToExportAsString: this.convertToPsListAsString(this.metadata.manifest.aliasesToExport) || ''
    }
  }

  private convertToPsListAsString(items: string[]): string {
    return items.map(i => `'${i}'`).join(', ');
  }
}
