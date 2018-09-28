/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import * as codemodel from '#common/code-model/code-model';
import * as command from '#common/code-model/command-operation';
import * as components from '#common/code-model/components';
import * as http from '#common/code-model/http-operation';
import * as schema from '#common/code-model/schema';

import { Dictionary } from '#common/linq';

export interface SchemaT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>
  > extends schema.Schema {
  details: TLanguageDetailsForSchema;
  properties: Dictionary<PropertyT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>>;
  not?: SchemaT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>;
  allOf: Array<SchemaT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>>;
  oneOf: Array<SchemaT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>>;
  anyOf: Array<SchemaT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>>;
  items?: SchemaT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>;
  additionalProperties?: boolean | SchemaT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>;
}

export interface PropertyT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>
  > extends schema.Property {
  details: TLanguageDetailsForProperty;
  schema: SchemaT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>;
}

export interface HttpOperationParameterT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>,
  TLanguageDetailsForParameter extends components.LanguageDetails<http.HttpParameterDetails>
  > extends http.HttpOperationParameter {
  details: TLanguageDetailsForParameter;
  schema: SchemaT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>;
}

export interface MediaTypeT<TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>,> extends http.MediaType {
  schema?: SchemaT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>;
}

/*
export interface ResponseT<TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>> extends http.Response {
  content: Dictionary<MediaTypeT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>>;
}
*/

export interface RequestBodyT<TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>> extends http.RequestBody {

}

export interface HttpOperationT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>,
  TLanguageDetailsForParameter extends components.LanguageDetails<http.HttpParameterDetails>,
  TLanguageDetailsForHttpOperation extends components.LanguageDetails<http.HttpOperationDetails>,
  > extends http.HttpOperation {
  details: TLanguageDetailsForHttpOperation;
  parameters: Array<HttpOperationParameterT<TLanguageDetailsForSchema, TLanguageDetailsForProperty, TLanguageDetailsForParameter>>;
  // responses: Dictionary<ResponseT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>>;
  requestBody?: RequestBodyT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>;
}

export interface HttpComponentsT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>,
  TLanguageDetailsForParameter extends components.LanguageDetails<http.HttpParameterDetails>,
  TLanguageDetailsForHttpOperation extends components.LanguageDetails<http.HttpOperationDetails>,
  > extends http.HttpComponents {
  operations: Dictionary<HttpOperationT<TLanguageDetailsForSchema, TLanguageDetailsForProperty, TLanguageDetailsForParameter, TLanguageDetailsForParameter>>;
  parameters: Dictionary<HttpOperationParameterT<TLanguageDetailsForSchema, TLanguageDetailsForProperty, TLanguageDetailsForParameter>>;
}

export interface ModelT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>,
  TLanguageDetailsForParameter extends components.LanguageDetails<http.HttpParameterDetails>,
  TLanguageDetailsForHttpOperation extends components.LanguageDetails<http.HttpOperationDetails>,
  TLanguageDetailsForClient extends components.LanguageDetails<codemodel.ClientDetails>,
  > extends codemodel.Model {
  schemas: Dictionary<SchemaT<TLanguageDetailsForSchema, TLanguageDetailsForProperty>>;
  details: TLanguageDetailsForClient;

  http: HttpComponentsT<TLanguageDetailsForSchema, TLanguageDetailsForProperty, TLanguageDetailsForParameter, TLanguageDetailsForHttpOperation>;
}

export interface CommandOperationT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>,
  TLanguageDetailsForParameter extends components.LanguageDetails<http.HttpParameterDetails>,
  TLanguageDetailsForHttpOperation extends components.LanguageDetails<http.HttpOperationDetails>,
  TLanguageDetailsForCommandOperation extends components.LanguageDetails<command.CommandOperationDetails>,
  > extends command.CommandOperation {
  callGraph: Array<HttpOperationT<TLanguageDetailsForSchema, TLanguageDetailsForProperty, TLanguageDetailsForParameter, TLanguageDetailsForHttpOperation>>;
  details: TLanguageDetailsForCommandOperation;
}
