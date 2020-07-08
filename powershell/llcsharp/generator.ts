/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { ModelState } from '@azure-tools/codemodel-v3';
import { codeModelSchema } from '@azure-tools/codemodel';
import { Model } from './code-model';
import { Host, JsonPath, Session, startSession } from '@azure-tools/autorest-extension-base';

import { Project, NewProject } from './project';
import { Dictionary } from '@azure-tools/linq';
import { DeepPartial } from '@azure-tools/codegen';
import { PwshModel } from '../utils/PwshModel';
import { NewModelState } from '../utils/model-state';

export class State extends ModelState<Model> {
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

export class NewState extends NewModelState<PwshModel> {
  project!: NewProject;

  public constructor(service: Host, objectInitializer?: DeepPartial<State>) {
    super(service);
    this.apply(objectInitializer);
  }

  async init(project?: NewProject) {
    if (project) {
      this.project = project;
    }
    //const session = await startSession<PwshModel>(this.service, {}, codeModelSchema);
    return await super.init(project);
    //return await super.init(project);
  }

  path(...childPath: JsonPath) {
    // const result = new State(this.service, this);
    // result.currentPath = [...this.currentPath, ...childPath];
    //return result;
    return this;
  }
}