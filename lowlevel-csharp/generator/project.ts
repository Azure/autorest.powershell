import { Project as codeDomProject } from "#csharp-code-dom/project";
import { Model, JsonType } from "#remodeler/code-model";
import { ApiClass } from "./operation/api-class";
import { Namespace } from "#csharp-code-dom/namespace";
import * as message from "./messages";
import { State } from "./generator";
import { ModelClass } from "./model/class";
import { ModelsNamespace } from "./model/namespace";
import { ServiceNamespace } from "./operation/namespace";
import { SupportNamespace } from "./support/namespace";

export class Project extends codeDomProject {

  protected constructor() {
    super();
  }

  private _serviceNamespace?: ServiceNamespace;
  private _modelsNamespace?: ModelsNamespace;
  private _supportNamespace?: SupportNamespace;

  public get serviceNamespace(): ServiceNamespace {
    if (this._serviceNamespace) {
      return this._serviceNamespace;
    }
    throw Error("Missing Service Namespace");
  }

  public get modelsNamespace(): ModelsNamespace {
    if (this._modelsNamespace) {
      return this._modelsNamespace;
    }
    throw Error("Missing Models Namespace");
  }

  public get supportNamespace(): SupportNamespace {
    if (this._supportNamespace) {
      return this._supportNamespace;
    }
    throw Error("Missing Support Namespace");
  }


  public addNamespace(n: Namespace): Namespace {
    if (n instanceof ModelsNamespace) {
      this._modelsNamespace = n;
    }
    if (n instanceof ServiceNamespace) {
      this._serviceNamespace = n;
    }
    if (n instanceof SupportNamespace) {
      this._supportNamespace = n;
    }
    return super.addNamespace(n);
  }

  public static async create(state: State): Promise<Project> {
    const project = new Project();
    state.project = project;
    return await project.init(state);
  }

  private async init(state: State): Promise<Project> {

    // add project namespace
    await ServiceNamespace.create(state);

    // add support namespace
    await SupportNamespace.create(this.serviceNamespace, state);

    // add model classes
    await ModelsNamespace.create(this.serviceNamespace, state.model.components.schemas, state.path('components', 'schemas'));


    // create API class
    await ApiClass.create(this, state);

    // abort now if we have any errors.
    state.checkpoint();

    return this;
  }

}
