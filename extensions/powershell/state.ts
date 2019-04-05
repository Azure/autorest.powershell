/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, ModelState } from '@microsoft.azure/autorest.codemodel-v3';

import { Host, JsonPath } from '@microsoft.azure/autorest-extension-base';
import { Project } from './project';
import { Dictionary } from '@microsoft.azure/codegen';

export interface GeneratorSettings {
  azure: boolean;
  cmdletFolder: string;
  customFolder: string;
  runtimeFolder: string;
  moduleName: string;
  csproj: string;
  psd1: string;
  psm1: string;
  apiFolder: string;
}

export class State extends ModelState<codemodel.Model> {
  project!: Project;

  public constructor(service: Host, objectInitializer?: Partial<State>) {
    super(service);
    this.apply(objectInitializer);
  }

  async init(project?: Project) {
    if (project) {
      this.project = project;
    }
    return await super.init();
  }

  path(...childPath: JsonPath) {
    const result = new State(this.service, this);
    result.currentPath = [...this.currentPath, ...childPath];
    return result;
  }
}

