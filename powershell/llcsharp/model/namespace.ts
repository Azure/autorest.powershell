/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Schema as NewSchema, Schemas as NewSchemas, Language } from '@autorest/codemodel';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { ImportDirective, Namespace } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { State } from '../generator';
import { EnumImplementation } from '../schema/enum';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ObjectImplementation } from '../schema/object';
import { SchemaDefinitionResolver } from '../schema/schema-resolver';
import { EnumClass } from '../enums/enum';
import * as validation from '../validations';
import { ModelInterface } from './interface';
import { ModelClass } from './model-class';
import { DeepPartial } from '@azure-tools/codegen';
import { isEnumImplementation } from '../../cmdlets/class';


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

  resolver = new SchemaDefinitionResolver(this.state.project.fixedArray);
  newResolver = new SchemaDefinitionResolver(this.state.project.fixedArray);
  constructor(parent: Namespace, private schemas: NewSchemas, private state: State, objectInitializer?: DeepPartial<ModelsNamespace>) {
    super('Models', parent);
    this.subNamespaces[this.fullName] = this;


    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // special case... hook this up before we get anywhere.
    state.project.modelsNamespace = this;

    if (schemas.objects) {
      for (const schema of schemas.objects) {
        this.NewResolveTypeDeclaration(schema, true, <State>state);
      }
    }
    if (schemas.dictionaries) {
      for (const schema of schemas.dictionaries) {
        this.NewResolveTypeDeclaration(schema, true, <State>state);
      }
    }

    if (schemas.any) {
      for (const schema of schemas.any) {
        this.NewResolveTypeDeclaration(schema, true, <State>state);
      }
    }

    if (schemas.strings) {
      for (const schema of schemas.strings) {
        this.NewResolveTypeDeclaration(schema, true, <State>state);
      }
    }
    if (schemas.sealedChoices) {
      for (const schema of schemas.sealedChoices) {
        this.NewResolveTypeDeclaration(schema, true, <State>state);
      }
    }
    //todo, need to add support for other types

  }

  get outputFolder() {
    return 'Models';
  }

  public NewResolveTypeDeclaration(schema: NewSchema | undefined, required: boolean, state: State): EnhancedTypeDeclaration {
    if (!schema) {
      throw new Error('SCHEMA MISSING?');
    }

    const td = this.newResolver.resolveTypeDeclaration(schema, required, state, state.project.fixedArray);

    if (!schema.language.csharp?.skip) {
      if (td instanceof ObjectImplementation) {
        // it's a class object.
        // create it if necessary

        const fullname = schema.language.csharp?.namespace || this.fullName;

        const ns = this.subNamespaces[fullname] || this.add(new ApiVersionNamespace(fullname));

        ns.header = this.state.project.license;

        const mc = schema.language.csharp?.classImplementation || new ModelClass(ns, td, <State>this.state, { description: schema.language.csharp?.description });

        // this gets implicity created during class creation:
        return <ModelInterface>schema.language.csharp?.interfaceImplementation;
      }

      if (state.project.azure && /^api-?version$/i.exec(schema.language.csharp?.name || '')) {
        return td;
      }

      if (isEnumImplementation(schema)) {
        schema.language.csharp = schema.language.csharp || new Language();
        return schema.language.csharp.typeDeclaration = td;
      }
    }
    return td;
  }
}