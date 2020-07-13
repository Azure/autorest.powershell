/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Schema as NewSchema, Schemas as NewSchemas, Language } from '@azure-tools/codemodel';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { ImportDirective, Namespace } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { State, NewState } from '../generator';
import { EnumImplementation } from '../schema/enum';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ObjectImplementation, NewObjectImplementation } from '../schema/object';
import { SchemaDefinitionResolver, NewSchemaDefinitionResolver } from '../schema/schema-resolver';
import { EnumClass } from '../enums/enum';
import * as validation from '../validations';
import { ModelInterface } from './interface';
import { ModelClass, NewModelClass } from './model-class';
import { DeepPartial } from '@azure-tools/codegen';


class ApiVersionNamespace extends Namespace {
  constructor(namespace: string, objectInitializer?: DeepPartial<ApiVersionNamespace>) {
    super(namespace);
    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));
  }

  get outputFolder() {
    return this.name.replace(/^.*\.Models/g, 'Models').replace(/\./g, '/');
  }
}

export class ModelsNamespace extends Namespace {
  private subNamespaces = new Dictionary<Namespace>();

  resolver = new SchemaDefinitionResolver();
  newResolver = new NewSchemaDefinitionResolver();
  constructor(parent: Namespace, private schemas: Dictionary<Schema> | NewSchemas, private state: State | NewState, objectInitializer?: DeepPartial<ModelsNamespace>) {
    super('Models', parent);
    this.subNamespaces[this.fullName] = this;


    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // special case... hook this up before we get anywhere.
    state.project.modelsNamespace = this;
    if (!(schemas instanceof NewSchemas)) {
      for (const { key: index, value: schema } of items(schemas)) {
        const state = this.state.path(index);

        // verify that the model isn't in a bad state
        if (validation.objectWithFormat(schema, <State>state)) {
          continue;
        }
        this.resolveTypeDeclaration(schema, true, <State>state);
      }
    } else {
      if (schemas.objects) {
        for (const schema of schemas.objects) {
          this.NewResolveTypeDeclaration(schema, true, <NewState>state);
        }
      }
      if (schemas.strings) {
        for (const schema of schemas.strings) {
          this.NewResolveTypeDeclaration(schema, true, <NewState>state);
        }
      }
      //todo, need to add support for other types
    }
  }

  get outputFolder() {
    return 'Models';
  }

  public resolveTypeDeclaration(schema: Schema | undefined, required: boolean, state: State): EnhancedTypeDeclaration {
    if (!schema) {
      throw new Error('SCHEMA MISSING?');
    }

    const td = this.resolver.resolveTypeDeclaration(schema, required, state);

    if (!schema.details.csharp.skip) {
      if (td instanceof ObjectImplementation) {
        // it's a class object.
        // create it if necessary

        const fullname = schema.details.csharp.namespace || this.fullName;

        const ns = this.subNamespaces[fullname] || this.add(new ApiVersionNamespace(fullname));

        const mc = schema.details.csharp.classImplementation || new ModelClass(ns, td, <State>this.state, { description: schema.details.csharp.description });

        // this gets implicity created during class creation:
        return <ModelInterface>schema.details.csharp.interfaceImplementation;
      }

      if (state.project.azure && /^api-?version$/i.exec(schema.details.csharp.name)) {
        return td;
      }

      if (td instanceof EnumImplementation) {
        if (schema.details.csharp.enum) {
          const ec = state.project.supportNamespace.findClassByName(schema.details.csharp.enum.name);
          if (length(ec) === 0) {
            new EnumClass(td, state);
            // return schema.details.csharp.typeDeclaration = <EnumClass>ec[0];
          }
        }

        return schema.details.csharp.typeDeclaration = td;
      }
    }
    return td;
  }
  public NewResolveTypeDeclaration(schema: NewSchema | undefined, required: boolean, state: NewState): EnhancedTypeDeclaration {
    if (!schema) {
      throw new Error('SCHEMA MISSING?');
    }

    const td = this.newResolver.resolveTypeDeclaration(schema, required, state);

    if (!schema.language.csharp?.skip) {
      if (td instanceof NewObjectImplementation) {
        // it's a class object.
        // create it if necessary

        const fullname = schema.language.csharp?.namespace || this.fullName;

        const ns = this.subNamespaces[fullname] || this.add(new ApiVersionNamespace(fullname));

        const mc = schema.language.csharp?.classImplementation || new NewModelClass(ns, td, <NewState>this.state, { description: schema.language.csharp?.description });

        // this gets implicity created during class creation:
        return <ModelInterface>schema.language.csharp?.interfaceImplementation;
      }

      if (state.project.azure && /^api-?version$/i.exec(schema.language.csharp?.name || '')) {
        return td;
      }

      if (td instanceof EnumImplementation) {
        if (schema.language.csharp?.enum) {
          const ec = state.project.supportNamespace.findClassByName(schema.language.csharp.enum.name);
          if (length(ec) === 0) {
            // skip-for-time-being
            //new EnumClass(td, state);
            // return schema.details.csharp.typeDeclaration = <EnumClass>ec[0];
          }
        }
        schema.language.csharp = schema.language.csharp || new Language();
        return schema.language.csharp.typeDeclaration = td;
      }
    }
    return td;
  }
}

export class NewModelsNamespace extends Namespace {
  private subNamespaces = new Dictionary<Namespace>();

  resolver = new SchemaDefinitionResolver();
  newResolver = new NewSchemaDefinitionResolver();
  constructor(parent: Namespace, private schemas: NewSchemas, private state: State | NewState, objectInitializer?: DeepPartial<ModelsNamespace>) {
    super('Models', parent);
    this.subNamespaces[this.fullName] = this;


    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // special case... hook this up before we get anywhere.
    state.project.modelsNamespace = this;

    if (schemas.objects) {
      for (const schema of schemas.objects) {
        this.NewResolveTypeDeclaration(schema, true, <NewState>state);
      }
    }
    if (schemas.strings) {
      for (const schema of schemas.strings) {
        this.NewResolveTypeDeclaration(schema, true, <NewState>state);
      }
    }
    //todo, need to add support for other types

  }

  get outputFolder() {
    return 'Models';
  }

  public NewResolveTypeDeclaration(schema: NewSchema | undefined, required: boolean, state: NewState): EnhancedTypeDeclaration {
    if (!schema) {
      throw new Error('SCHEMA MISSING?');
    }

    const td = this.newResolver.resolveTypeDeclaration(schema, required, state);

    if (!schema.language.csharp?.skip) {
      if (td instanceof NewObjectImplementation) {
        // it's a class object.
        // create it if necessary

        const fullname = schema.language.csharp?.namespace || this.fullName;

        const ns = this.subNamespaces[fullname] || this.add(new ApiVersionNamespace(fullname));

        const mc = schema.language.csharp?.classImplementation || new NewModelClass(ns, td, <NewState>this.state, { description: schema.language.csharp?.description });

        // this gets implicity created during class creation:
        return <ModelInterface>schema.language.csharp?.interfaceImplementation;
      }

      if (state.project.azure && /^api-?version$/i.exec(schema.language.csharp?.name || '')) {
        return td;
      }

      if (td instanceof EnumImplementation) {
        if (schema.language.csharp?.enum) {
          const ec = state.project.supportNamespace.findClassByName(schema.language.csharp.enum.name);
          if (length(ec) === 0) {
            // skip-for-time-being
            //new EnumClass(td, state);
            // return schema.details.csharp.typeDeclaration = <EnumClass>ec[0];
          }
        }
        schema.language.csharp = schema.language.csharp || new Language();
        return schema.language.csharp.typeDeclaration = td;
      }
    }
    return td;
  }
}