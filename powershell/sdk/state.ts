/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { CodeModel } from '@azure-tools/codemodel';

import { Host, JsonPath, Session } from '@azure-tools/autorest-extension-base';
import { Project } from './project';
import { DeepPartial } from '@azure-tools/codegen';
import { PwshModel } from '../utils/PwshModel';
import { ModelState } from '../utils/model-state';


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

export class State extends ModelState<CodeModel> {
  project!: Project;

  public constructor(service: Host, objectInitializer?: DeepPartial<State>) {
    super(service);
    this.apply(objectInitializer);
  }

  async init(project?: Project) {
    if (project) {
      this.project = project;
    }
    return await super.init(project);
  }

  path(...childPath: JsonPath) {
    // const result = new State(this.service, this);
    // result.currentPath = [...this.currentPath, ...childPath];
    //return result;
    return this;
  }
}