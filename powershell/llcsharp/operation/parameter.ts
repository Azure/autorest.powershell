/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Method } from '@azure-tools/codegen-csharp';
import { Parameter as NewHttpOperationParameter } from '@azure-tools/codemodel';
import { KnownMediaType } from '@azure-tools/codemodel-v3';
import { System } from '@azure-tools/codegen-csharp';
import { Expression, ExpressionOrLiteral } from '@azure-tools/codegen-csharp';

import { Parameter } from '@azure-tools/codegen-csharp';
import { OneOrMoreStatements } from '@azure-tools/codegen-csharp';
import { Variable } from '@azure-tools/codegen-csharp';

import { HttpOperationParameter, Schema } from '../code-model';
import { EnhancedVariable } from '../extended-variable';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { State, NewState } from '../generator';
import { DeepPartial } from '@azure-tools/codegen';

/** represents a method parameter for an http operation (header/cookie/query/path) */
export class OperationParameter extends Parameter implements EnhancedVariable {
  public typeDeclaration: EnhancedTypeDeclaration;

  public param: HttpOperationParameter;

  constructor(parent: Method, param: HttpOperationParameter, state: State, objectInitializer?: DeepPartial<OperationParameter>) {
    const typeDeclaration = state.project.modelsNamespace.resolveTypeDeclaration(param.schema, param.required, state.path('schema'));
    super(param.details.csharp.name, typeDeclaration);
    this.param = param;
    this.typeDeclaration = typeDeclaration;
    this.apply(objectInitializer);
    this.description = param.details.csharp.description || '';
  }

  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string): Expression {
    // return this.assign(this.typeDeclaration.deserializeFromContainerMember(mediaType, container, serializedName, this))
    return this.typeDeclaration.deserializeFromContainerMember(mediaType, container, serializedName, this);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral): Expression {
    return this.typeDeclaration.deserializeFromNode(mediaType, node, this);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, serializedName: string, mode: Expression): Expression {
    return this.typeDeclaration.serializeToNode(mediaType, this, serializedName, mode);
  }
  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, mode: Expression): Expression {
    return this.typeDeclaration.serializeToContent(mediaType, this, mode);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    return this.typeDeclaration.serializeToContainerMember(mediaType, this, container, serializedName, mode);
  }

  public validatePresenceStatement(eventListener: Variable): OneOrMoreStatements {
    return this.typeDeclaration.validatePresence(eventListener, this);
  }
  public validationStatement(eventListener: Variable): OneOrMoreStatements {
    return this.typeDeclaration.validateValue(eventListener, this);
  }
}

export class NewOperationParameter extends Parameter implements EnhancedVariable {
  public typeDeclaration: EnhancedTypeDeclaration;

  public param: NewHttpOperationParameter;

  constructor(parent: Method, param: NewHttpOperationParameter, state: NewState, objectInitializer?: DeepPartial<OperationParameter>) {
    const typeDeclaration = state.project.modelsNamespace.NewResolveTypeDeclaration(param.schema, !!param.required, state);
    super(param.language.csharp?.name || '', typeDeclaration);
    this.param = param;
    this.typeDeclaration = typeDeclaration;
    this.apply(objectInitializer);
    this.description = param.language.csharp?.description || '';
  }

  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string): Expression {
    // return this.assign(this.typeDeclaration.deserializeFromContainerMember(mediaType, container, serializedName, this))
    return this.typeDeclaration.deserializeFromContainerMember(mediaType, container, serializedName, this);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral): Expression {
    return this.typeDeclaration.deserializeFromNode(mediaType, node, this);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, serializedName: string, mode: Expression): Expression {
    return this.typeDeclaration.serializeToNode(mediaType, this, serializedName, mode);
  }
  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, mode: Expression): Expression {
    return this.typeDeclaration.serializeToContent(mediaType, this, mode);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    return this.typeDeclaration.serializeToContainerMember(mediaType, this, container, serializedName, mode);
  }

  public validatePresenceStatement(eventListener: Variable): OneOrMoreStatements {
    return this.typeDeclaration.validatePresence(eventListener, this);
  }
  public validationStatement(eventListener: Variable): OneOrMoreStatements {
    return this.typeDeclaration.validateValue(eventListener, this);
  }
}

/** represents a method parameter for an http operation (body) */
export class OperationBodyParameter extends Parameter implements EnhancedVariable {
  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string): Expression {
    // return this.assign(this.typeDeclaration.deserializeFromContainerMember(mediaType, container, serializedName, this));
    return this.typeDeclaration.deserializeFromContainerMember(mediaType, container, serializedName, this);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral): Expression {
    // return this.assign(this.typeDeclaration.deserializeFromNode(mediaType, node, this));
    return this.typeDeclaration.deserializeFromNode(mediaType, node, this);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, serializedName: string, mode: Expression): Expression {
    return this.typeDeclaration.serializeToNode(mediaType, this, serializedName, mode);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, mode: Expression): Expression {
    return this.typeDeclaration.serializeToContent(mediaType, this, mode);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    return this.typeDeclaration.serializeToContainerMember(mediaType, this, container, serializedName, mode);
  }

  public validatePresenceStatement(eventListener: Variable): OneOrMoreStatements {
    return this.typeDeclaration.validatePresence(eventListener, this);
  }
  public validationStatement(eventListener: Variable): OneOrMoreStatements {
    return this.typeDeclaration.validateValue(eventListener, this);
  }
  public mediaType: KnownMediaType;
  public contentType: string;

  public typeDeclaration: EnhancedTypeDeclaration;

  constructor(parent: Method, name: string, description: string, schema: Schema, required: boolean, state: State, objectInitializer?: DeepPartial<OperationBodyParameter>) {
    const typeDeclaration = state.project.modelsNamespace.resolveTypeDeclaration(schema, required, state.path('schema'));
    super(name, typeDeclaration);
    this.typeDeclaration = typeDeclaration;
    this.mediaType = KnownMediaType.Json;
    this.contentType = KnownMediaType.Json;

    this.apply(objectInitializer);
    this.description = description || schema.details.csharp.description;
  }

  public get jsonSerializationStatement(): OneOrMoreStatements {
    // get the body serialization from the typeDeclaration.

    return '/* body parameter */';//  (<TypeDeclaration>this.type).jsonserialize(this.name);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return '/* body parameter */';// (<TypeDeclaration>this.type).jsonDeserializationImplementation(this.name);
  }
}

export class CallbackParameter extends Parameter {
  responseType: (EnhancedTypeDeclaration) | null;
  headerType: (EnhancedTypeDeclaration) | null;

  constructor(name: string, responseType: (EnhancedTypeDeclaration) | null, headerType: (EnhancedTypeDeclaration) | null, state: State, objectInitializer?: DeepPartial<CallbackParameter>) {
    // regular pipeline style. (callback happens after the pipline is called)
    if (responseType) {
      if (headerType) {
        // both
        super(name, System.Func(System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task(responseType), System.Threading.Tasks.Task(headerType), System.Threading.Tasks.Task()));
      } else {
        // just response
        super(name, System.Func(System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task(responseType), System.Threading.Tasks.Task()));
      }
    } else {
      if (headerType) {
        // just headers
        super(name, System.Func(System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task(headerType), System.Threading.Tasks.Task()));
      } else {
        // no content?
        super(name, System.Func(System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task()));
      }
    }

    this.responseType = responseType;
    this.headerType = headerType;
    this.apply(objectInitializer);
  }
}

export class NewCallbackParameter extends Parameter {
  responseType: (EnhancedTypeDeclaration) | null;
  headerType: (EnhancedTypeDeclaration) | null;

  constructor(name: string, responseType: (EnhancedTypeDeclaration) | null, headerType: (EnhancedTypeDeclaration) | null, state: NewState, objectInitializer?: DeepPartial<CallbackParameter>) {
    // regular pipeline style. (callback happens after the pipline is called)
    if (responseType) {
      if (headerType) {
        // both
        super(name, System.Func(System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task(responseType), System.Threading.Tasks.Task(headerType), System.Threading.Tasks.Task()));
      } else {
        // just response
        super(name, System.Func(System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task(responseType), System.Threading.Tasks.Task()));
      }
    } else {
      if (headerType) {
        // just headers
        super(name, System.Func(System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task(headerType), System.Threading.Tasks.Task()));
      } else {
        // no content?
        super(name, System.Func(System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task()));
      }
    }

    this.responseType = responseType;
    this.headerType = headerType;
    this.apply(objectInitializer);
  }
}