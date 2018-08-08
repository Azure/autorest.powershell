import { Header } from '#common/code-model/http-operation';
import { Dictionary, items } from '#common/dictionary';
import { Import } from '#csharp/code-dom/import';
import { Namespace } from '#csharp/code-dom/namespace';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { ModelInterface } from '#csharp/lowlevel-generator/model/interface';
import { EnumImplementation } from '#csharp/schema/enum';
import { ObjectImplementation } from '#csharp/schema/object';
import { SchemaDefinitionResolver } from '#csharp/schema/schema-resolver';
import { EnhancedTypeDeclaration } from '../../schema/extended-type-declaration';
import { State } from '../generator';
import { EnumClass } from '../support/enum';
import * as validation from '../validations';
import { ModelClass } from './model-class';

export class ModelsNamespace extends Namespace {

  resolver = new SchemaDefinitionResolver();

  constructor(parent: Namespace, private schemas: Dictionary<Schema>, private state: State, objectInitializer?: Partial<ModelsNamespace>) {
    super('Models', parent);
    this.apply(objectInitializer);
    if (state.project.defaultPipeline) {
      this.addUsing(new Import('static Microsoft.Rest.ClientRuntime.IEventListenerExtensions'));
      this.addUsing(new Import('static Microsoft.Rest.ClientRuntime.HttpRequestMessageExtensions'));
    }
    this.addUsing(new Import('static Microsoft.Rest.ClientRuntime.Extensions'));

    // special case... hook this up before we get anywhere.
    state.project.modelsNamespace = this;

    for (const { key: schemaName, value: schema } of items(schemas)) {
      const state = this.state.path(schemaName);

      // verify that the model isn't in a bad state
      if (validation.objectWithFormat(schema, state)) {
        continue;
      }
      this.resolveTypeDeclaration(schema, true, state);
    }
  }

  private static INVALID = <any>null;

  public resolveTypeDeclaration(schema: Schema | undefined, required: boolean, state: State): EnhancedTypeDeclaration {
    if (!schema) {
      throw new Error('SCHEMA MISSING?');
    }

    const td = this.resolver.resolveTypeDeclaration(schema, required, state);
    if (td instanceof ObjectImplementation) {
      // it's a class object.
      // create it if necessary
      const mc = schema.details.csharp.classImplementation || new ModelClass(this, td, this.state);

      // this gets implicity created during class creation:
      return <ModelInterface>schema.details.csharp.interfaceImplementation;
    }

    if (td instanceof EnumImplementation) {
      const ec = state.project.supportNamespace.findClassByName(schema.extensions['x-ms-enum'].name);
      if (ec.length > 0) {
        return schema.details.csharp.typeDeclaration = <EnumClass>ec[0];
      }
      return schema.details.csharp.typeDeclaration = new EnumClass(td, state);
    }

    return td;
  }
}