/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Dictionary, items } from '@microsoft.azure/codegen';
import { ImportDirective, Namespace } from '@microsoft.azure/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { State } from '../generator';
import { EnumImplementation } from '../schema/enum';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ObjectImplementation } from '../schema/object';
import { SchemaDefinitionResolver } from '../schema/schema-resolver';
import { EnumClass } from '../support/enum';
import * as validation from '../validations';
import { ModelInterface } from './interface';
import { ModelClass } from './model-class';


class ApiVersionNamespace extends Namespace {
  constructor(namespace: string, objectInitializer?: Partial<ApiVersionNamespace>) {
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

  constructor(parent: Namespace, private schemas: Dictionary<Schema>, private state: State, objectInitializer?: Partial<ModelsNamespace>) {
    super('Models', parent);
    this.subNamespaces[this.fullName] = this;


    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // special case... hook this up before we get anywhere.
    state.project.modelsNamespace = this;

    for (const { key: index, value: schema } of items(schemas)) {
      const state = this.state.path(index);

      // verify that the model isn't in a bad state
      if (validation.objectWithFormat(schema, state)) {
        continue;
      }
      this.resolveTypeDeclaration(schema, true, state);
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

        const mc = schema.details.csharp.classImplementation || new ModelClass(ns, td, this.state, { description: schema.details.csharp.description });

        // this gets implicity created during class creation:
        return <ModelInterface>schema.details.csharp.interfaceImplementation;
      }

      if (td instanceof EnumImplementation) {
        if (schema.details.csharp.enum) {
          const ec = state.project.supportNamespace.findClassByName(schema.details.csharp.enum.name);
          if (ec.length > 0) {
            return schema.details.csharp.typeDeclaration = <EnumClass>ec[0];
          }
        }

        return schema.details.csharp.typeDeclaration = new EnumClass(td, state);
      }
    }
    return td;
  }
}
