import { Project as codeDomProject } from '#csharp/code-dom/project';
import { Model } from '#common/code-model/code-model';
import { ApiClass } from './operation/api-class';
import { Namespace } from '#csharp/code-dom/namespace';
import * as message from './messages';
import { State } from './generator';
import { ModelClass } from './model/class';
import { ModelsNamespace } from './model/namespace';
import { ServiceNamespace } from './operation/namespace';
import { SupportNamespace } from './support/namespace';
import { JsonSerializerClass } from '#csharp/lowlevel-generator/support/json-serializer';
import { Import } from '#csharp/code-dom/import';
import { JsonType } from '#common/code-model/schema';

export class Project extends codeDomProject {

  constructor(protected state: State) {
    super();
    state.project = this;
    // add project namespace
    this.addNamespace(this.serviceNamespace = new ServiceNamespace(state));

    // add support namespace
    this.addNamespace(this.supportNamespace = new SupportNamespace(this.serviceNamespace, state));

    // add model classes
    this.addNamespace(this.modelsNamespace = new ModelsNamespace(this.serviceNamespace, state.model.schemas, state.path('components', 'schemas')));

    // create API class
    new ApiClass(this.serviceNamespace, state);

    // create serialization support
    new JsonSerializerClass(this.supportNamespace, state)
    this.modelsNamespace.addUsing(new Import(this.supportNamespace.fullName));



    // abort now if we have any errors.
    state.checkpoint();
  }

  public serviceNamespace: ServiceNamespace;
  public modelsNamespace: ModelsNamespace;
  public supportNamespace: SupportNamespace;
}
