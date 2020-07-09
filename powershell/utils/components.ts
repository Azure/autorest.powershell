/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { DeepPartial } from '@azure-tools/codegen';
import { Dictionary } from '@azure-tools/linq';
import { Schema as NewSchema } from '@azure-tools/codemodel';
import { Extensions } from './extensions';
import { Schema } from './schema';
import { uid } from './uid';

export interface IOperationBase {

}

export interface IParameter extends Extensions {
  name: string;
  schema: Schema;
  description: string;

  allowEmptyValue: boolean;
  deprecated: boolean;
  required: boolean;
  details: LanguageDetails<ParameterDetails>;
}

export class IParameter extends Extensions {
  constructor(public name: string, public schema: Schema, initializer?: DeepPartial<IParameter>) {
    super();
    this.description = '';
    this.deprecated = false;
    this.required = false;
    this.details = {
      default: {
        uid: `parameter:${uid()}`,
        description: this.description,
        name,
      }
    };
    this.allowEmptyValue = false;
    this.apply(initializer);
  }
}

export class IParameterPwsh extends IParameter {
  constructor(public name: string, public schema: Schema, public newSchema: NewSchema, initializer?: DeepPartial<IParameter>) {
    super(name, schema);
  }
}
export interface IOperation<TParameterType extends IParameter> extends IOperationBase {
  operationId: string;
  description: string;

  summary?: string;
  deprecated: boolean;

  parameters: Array<TParameterType>;
}

export interface Components<TOperation extends IOperation<TParameter>, TParameter extends IParameter> extends Extensions {
  operations: Dictionary<TOperation>;
  parameters: Dictionary<TParameter>;
}

export class Components<TOperation extends IOperation<TParameter>, TParameter extends IParameter> extends Extensions implements Components<TOperation, TParameter> {
  /**
   * Dictionary of Operations in this model.
   *
   * This is intended to invert the original PathItems in the OAI model, and focus on operations, not endpoints.
   */
  public operations = new Dictionary<TOperation>();

  constructor(initializer?: DeepPartial<Components<TOperation, TParameter>>) {
    super();
    this.apply(initializer);
  }
}

export interface ParameterDetails extends ImplementationDetails {

}

export interface ResponseDetails extends ImplementationDetails {
  isErrorResponse: boolean;
}

/** LanguageDetails contains a map of languages to details for a given node in the code-model  */
export interface LanguageDetails<T extends ImplementationDetails> extends Dictionary<T> {
  default: T;

}

export interface ImplementationDetails extends Dictionary<any> {
  /** a unique id for correlation between cloned objects */
  uid: string;

  /** name used in actual implementation */
  name: string;

  /** description text */
  description: string;

  /** message used to go along with deprecation */
  deprecationMessage?: string;
}

export enum ImplementationLocation {
  Method = 'Method',
  Client = 'Client',
}

export class Example extends Extensions implements Example {
  extensions = new Dictionary<any>();

  constructor(initializer?: DeepPartial<Example>) {
    super();
    this.apply(initializer);
  }
}

export class ExternalDocumentation extends Extensions implements ExternalDocumentation {
  extensions = new Dictionary<any>();

  constructor(public url: string, initializer?: DeepPartial<ExternalDocumentation>) {
    super();
    this.apply(initializer);
  }
}

export class Link extends Extensions implements Link {
  extensions = new Dictionary<any>();
  parameters = new Dictionary<string>();

  constructor(initializer?: DeepPartial<Link>) {
    super();
    this.apply(initializer);
  }
}

export class Server extends Extensions implements Server {
  extensions = new Dictionary<any>();
  variables = new Dictionary<ServerVariable>();

  constructor(public url: string, initializer?: DeepPartial<Server>) {
    super();
    this.apply(initializer);
  }
}

export class ServerVariable extends Extensions implements ServerVariable {
  extensions = new Dictionary<any>();
  enum = new Array<string>();

  constructor(defaultValue: string, initializer?: DeepPartial<ServerVariable>) {
    super();
    this.default = defaultValue;
    this.apply(initializer);
  }
}

export class Tag extends Extensions implements Tag {
  extensions = new Dictionary<any>();

  constructor(public name: string, initializer?: DeepPartial<Tag>) {
    super();
    this.apply(initializer);
  }
}

/**
 * @description common ways of serializing simple parameters
 * @see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.1.md#style-values
 */

export interface SecurityRequirement extends Dictionary<string> {
}

export interface Example extends Extensions {
  summary?: string;
  description?: string;
  value?: any;
  externalValue?: string; // uriref
}

export interface ExternalDocumentation extends Extensions {
  description?: string;
  url: string; // uriref
}

export interface Link extends Extensions {
  operationRef?: string; // uriref
  operationId?: string;
  parameters: Dictionary<string>;
  requestBody?: any;
  description?: string;
  server?: Server;
}

export interface Server extends Extensions {

  url: string;
  description?: string;
  variables: Dictionary<ServerVariable>;
}

export interface ServerVariable extends Extensions {
  enum: Array<string>;
  default: string;
  description?: string;
}

export interface Tag extends Extensions {

  name: string;
  description?: string;
  externalDocs?: ExternalDocumentation;
}

