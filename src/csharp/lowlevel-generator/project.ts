import { Project as codeDomProject } from '#csharp/code-dom/project';
import { Model } from '#common/code-model/code-model';
import { ApiClass } from './operation/api-class';
import { Namespace } from '#csharp/code-dom/namespace';
import * as message from './messages';
import { State } from './generator';
import { ModelClass } from './model/model-class';
import { ModelsNamespace } from './model/namespace';
import { ServiceNamespace } from './operation/namespace';
import { SupportNamespace } from './support/namespace';
import { JsonSerializerClass } from '#csharp/lowlevel-generator/support/json-serializer';
import { Import } from '#csharp/code-dom/import';
import { JsonType } from '#common/code-model/schema';

export class Project extends codeDomProject {
  public storagePipeline: boolean = false;
  public jsonSerialization: boolean = true;
  public xmlSerialization: boolean = false;
  public defaultPipeline: boolean = true;
  public emitSignals: boolean = true;

  constructor(protected state: State) {
    super();
    state.project = this;
    // add project namespace

  }

  public async init(): Promise<this> {
    await super.init();

    const service = this.state.service;
    this.storagePipeline = await service.GetValue('use-storage-pipeline') || false;
    if (this.storagePipeline) {
      this.emitSignals = false;
      this.jsonSerialization = false;
      this.xmlSerialization = true;
      this.defaultPipeline = false;
    }


    this.addNamespace(this.serviceNamespace = new ServiceNamespace(this.state));

    // add support namespace
    this.addNamespace(this.supportNamespace = new SupportNamespace(this.serviceNamespace, this.state));

    // add model classes
    this.addNamespace(this.modelsNamespace = new ModelsNamespace(this.serviceNamespace, this.state.model.schemas, this.state.path('components', 'schemas')));

    // create API class
    new ApiClass(this.serviceNamespace, this.state);

    if (this.jsonSerialization) {
      // create serialization support
      new JsonSerializerClass(this.supportNamespace, this.state)
    }
    this.modelsNamespace.addUsing(new Import(this.supportNamespace.fullName));

    // abort now if we have any errors.
    this.state.checkpoint();

    return this;
  }

  public serviceNamespace!: ServiceNamespace;
  public modelsNamespace!: ModelsNamespace;
  public supportNamespace!: SupportNamespace;
}
