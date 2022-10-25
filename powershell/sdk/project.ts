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
import { Host } from '@azure-tools/autorest-extension-base';
import { PropertyDetails, exportedModels as T } from '@azure-tools/codemodel-v3';
import { DeepPartial, comment } from '@azure-tools/codegen';
import { CodeModel } from '@azure-tools/codemodel';
import { SdkModel } from '../utils/SdkModel';
import { Helper } from './utility';

export type Schema = T.SchemaT<LanguageDetails<SchemaDetails>, LanguageDetails<PropertyDetails>>;

export class Project extends codeDomProject {
  public azure!: boolean;
  public addToString!: boolean;
  public license!: string;
  public commentHeader!: string;

  public serviceName!: string;
  public csproj!: string;
  public nuspec!: string;
  public gitIgnore!: string;
  public gitAttributes!: string;
  public readme!: string;
  public dllName!: string;
  public dll!: string;
  public apiFolder!: string;
  public baseFolder!: string;
  public schemaDefinitionResolver!: SchemaDefinitionResolver;

  public namespace!: string;
  public projectNamespace!: string;
  public overrides!: Dictionary<string>;
  public serviceNamespace!: ModuleNamespace;
  public supportNamespace!: EnumNamespace;

  public modelsExtensions!: ModelExtensionsNamespace;
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


    // Folders
    this.baseFolder = await this.state.getValue('current-folder');

    // File paths
    this.gitIgnore = `${this.baseFolder}/.gitignore`;
    this.gitAttributes = `${this.baseFolder}/.gitattributes`;
    this.readme = `${this.baseFolder}/README.md`;

    this.helper = new Helper();


    // abort now if we have any errors.
    this.state.checkpoint();
    return this;
  }
}
