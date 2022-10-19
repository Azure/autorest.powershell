/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Dictionary, values } from '@azure-tools/linq';
import { SchemaDetails, LanguageDetails, EnhancedTypeDeclaration, Boolean, SchemaDefinitionResolver } from '../llcsharp/exports';
import { State } from './state';
import { Project as codeDomProject } from '@azure-tools/codegen-csharp';
import { EnumNamespace } from '../enums/namespace';
import { ModelExtensionsNamespace } from '../models/model-extensions';

import { ModuleNamespace } from '../module/module-namespace';
import { CmdletNamespace } from '../cmdlets/namespace';
import { Host } from '@azure-tools/autorest-extension-base';
import { PropertyDetails, exportedModels as T } from '@azure-tools/codemodel-v3';
import { DeepPartial, comment } from '@azure-tools/codegen';
import { CodeModel } from '@azure-tools/codemodel';
import { SdkModel } from '../utils/SdkModel';
import { Helper } from './utility';
import { ModelState } from '../utils/model-state';
import { BooleanSchema, ChoiceSchema, ConstantSchema, Schema as NewSchema, SchemaType } from '@azure-tools/codemodel';

export type Schema = T.SchemaT<LanguageDetails<SchemaDetails>, LanguageDetails<PropertyDetails>>;

export class Project extends codeDomProject {
  public azure!: boolean;
  public addToString!: boolean;
  public license!: string;
  public commentHeader!: string;
  public cmdletFolder!: string;
  public modelCmdletFolder!: string;
  public endpointResourceIdKeyName!: string;
  public endpointSuffixKeyName!: string;

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
  public rootModuleName!: string;
  public csproj!: string;
  public nuspec!: string;
  public gitIgnore!: string;
  public gitAttributes!: string;
  public readme!: string;
  public dllName!: string;
  public dll!: string;
  public apiFolder!: string;
  public baseFolder!: string;
  public moduleFolder!: string;
  public schemaDefinitionResolver!: SchemaDefinitionResolver;
  public moduleVersion!: string;
  public profiles!: Array<string>;
  public modelCmdlets!: Array<string>;
  public inputHandlers!: Array<string>;

  public namespace!: string;
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
  public state!: State;
  public helpLinkPrefix!: string;
  public helper!: Helper;
  get model() { return <SdkModel>this.state.model; }

  constructor(protected service: Host, objectInitializer?: DeepPartial<Project>) {
    super();
    this.apply(objectInitializer);
  }


  public async init(): Promise<this> {
    await super.init();
    this.state = await new State(this.service).init();


    this.projectNamespace = this.state.model.language.csharp?.namespace || '';


    this.overrides = {
    };

    this.license = await this.state.getValue('header-text', '');

    this.namespace = await this.state.getValue('namespace', 'Microsoft.Azure.Sample');

    this.commentHeader = comment(this.license, '//');
    // Flags
    this.azure = this.model.language.default.isAzure;
    // Names
    this.serviceName = this.model.language.default.serviceName;

    this.rootModuleName = await this.state.getValue('root-module-name', '');

    // Folders
    this.baseFolder = await this.state.getValue('current-folder');
    this.moduleFolder = await this.state.getValue('module-folder');
    this.cmdletFolder = await this.state.getValue('cmdlet-folder');
    this.modelCmdletFolder = await this.state.getValue('model-cmdlet-folder');

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
    this.gitIgnore = `${this.baseFolder}/.gitignore`;
    this.gitAttributes = `${this.baseFolder}/.gitattributes`;
    this.readme = `${this.baseFolder}/README.md`;

    this.helper = new Helper();

    // excluded properties in table view

    // abort now if we have any errors.
    this.state.checkpoint();
    return this;
  }
}
