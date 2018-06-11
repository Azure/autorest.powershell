import { Property, Schema } from '#csharp/lowlevel-generator/code-model';
import { InterfaceProperty } from '#csharp/code-dom/interface-property';
import { State } from '../generator';
import { ModelInterface } from './interface';

export class ModelInterfaceProperty extends InterfaceProperty {
  constructor(parent: ModelInterface, property: Property, state: State, objectInitializer?: Partial<ModelInterfaceProperty>) {
    super(property.details.csharp.name, state.project.modelsNamespace.resolveTypeDeclaration(property.schema, property.details.csharp.required, state.path('schema')));
    this.apply(objectInitializer);
  }
}
