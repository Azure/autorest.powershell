import { Project as codeDomProject } from '#csharp/code-dom/project';

import { Namespace } from '#csharp/code-dom/namespace';
import { State, GeneratorSettings } from './state';

import { Import } from '#csharp/code-dom/import';
import { values, items } from '#common/dictionary';
import { CmdletClass } from './cmdlet-class';
import { ModuleClass } from '#powershell/module-class';

export class ServiceNamespace extends Namespace {
  public moduleClass: ModuleClass;

  public get outputFolder(): string {
    return this.state.project.configuration.apifolder;
  }

  constructor(public state: State, objectInitializer?: Partial<ServiceNamespace>) {
    super(state.model.details.csharp.namespace || "INVALID.NAMESPACE", state.project);
    this.apply(objectInitializer);

    // module class 
    this.moduleClass = new ModuleClass(this, state);
  }
}

export class CmdletNamespace extends Namespace {
  public get outputFolder(): string {
    return this.state.project.configuration.cmdletFolder;
  }

  constructor(parent: Namespace, private state: State, objectInitializer?: Partial<CmdletNamespace>) {
    super("Cmdlets", parent);
    this.apply(objectInitializer);
    this.addUsing(new Import("static Microsoft.Rest.ClientRuntime.IEventListenerExtensions"));
    // generate cmdlet classes on top of the SDK
    for (const { key: id, value: operation } of items(state.model.commands.operations)) {
      this.addClass(new CmdletClass(this, operation, state.path("commands", "operations", id)));
    }
  }
}

export class Project extends codeDomProject {
  public configuration: GeneratorSettings;

  constructor(protected state: State, cfg: GeneratorSettings) {
    super();
    state.project = this;
    this.configuration = cfg;

    // add project namespace
    this.addNamespace(this.serviceNamespace = new ServiceNamespace(state));

    // add cmdlet namespace
    this.addNamespace(this.cmdlets = new CmdletNamespace(this.serviceNamespace, state));

    // abort now if we have any errors.
    state.checkpoint();
  }

  public serviceNamespace: ServiceNamespace;
  public cmdlets: Namespace;
}
