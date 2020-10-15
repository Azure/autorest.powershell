/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Schema as NewSchema, Schemas as NewSchemas, Language } from '@azure-tools/codemodel';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { ImportDirective, Namespace } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { NewState } from '../generator';
import { EnumImplementation, NewEnumImplementation } from '../schema/enum';
import { EnhancedTypeDeclaration, NewEnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ObjectImplementation, NewObjectImplementation } from '../schema/object';
import { NewSchemaDefinitionResolver } from '../schema/schema-resolver';
import { NewEnumClass } from '../enums/enum';
import * as validation from '../validations';
import { NewModelInterface } from './interface';
import { NewModelClass } from './model-class';
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

export class NewModelsNamespace extends Namespace {
  private subNamespaces = new Dictionary<Namespace>();

  resolver = new NewSchemaDefinitionResolver();
  newResolver = new NewSchemaDefinitionResolver();
  constructor(parent: Namespace, private schemas: NewSchemas, private state: NewState, objectInitializer?: DeepPartial<NewModelsNamespace>) {
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
    if (schemas.dictionaries) {
      for (const schema of schemas.dictionaries) {
        this.NewResolveTypeDeclaration(schema, true, <NewState>state);
      }
    }

    if (schemas.any) {
      for (const schema of schemas.any) {
        this.NewResolveTypeDeclaration(schema, true, <NewState>state);
      }
    }

    if (schemas.strings) {
      for (const schema of schemas.strings) {
        this.NewResolveTypeDeclaration(schema, true, <NewState>state);
      }
    }
    if (schemas.sealedChoices) {
      for (const schema of schemas.sealedChoices) {
        this.NewResolveTypeDeclaration(schema, true, <NewState>state);
      }
    }
    //todo, need to add support for other types

  }

  get outputFolder() {
    return 'Models';
  }

  public NewResolveTypeDeclaration(schema: NewSchema | undefined, required: boolean, state: NewState): NewEnhancedTypeDeclaration {
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
        return <NewModelInterface>schema.language.csharp?.interfaceImplementation;
      }

      if (state.project.azure && /^api-?version$/i.exec(schema.language.csharp?.name || '')) {
        return td;
      }

      if (td instanceof NewEnumImplementation) {
        if (schema.language.csharp?.enum) {
          const ec = state.project.supportNamespace.findClassByName(schema.language.csharp.enum.name);
          if (length(ec) === 0) {
            new NewEnumClass(td, state);
            // return schema.language.csharp.typeDeclaration = <NewEnumClass>ec[0];
          }
        }
        schema.language.csharp = schema.language.csharp || new Language();
        return schema.language.csharp.typeDeclaration = td;
      }
    }
    return td;
  }
}