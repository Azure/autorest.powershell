import { ModelState } from "#common/model-state";
import { Host, JsonPath } from "@microsoft.azure/autorest-extension-base";
import { Model } from "remodeler/code-model";
import { Project } from "./project";

export class State extends ModelState<Model> {

  public get project(): Project {
    if (this.prj)
      return this.prj;
    throw new Error();
  }

  public set project(prj: Project) {
    this.prj = prj;
  }
  constructor(service: Host, model: Model, documentName: string, currentPath: JsonPath = new Array<string>(), public prj?: Project) {
    super(service, model, documentName, currentPath);
  }

  public path(...childPath: JsonPath): State {
    return new State(this.service, this.model, this.documentName, [...this.currentPath, ...childPath], this.project);
  }

}