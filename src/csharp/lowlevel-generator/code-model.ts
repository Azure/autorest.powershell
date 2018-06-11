import * as codemodel from '#common/code-model/code-model';
import * as command from '#common/code-model/command-operation';
import * as components from '#common/code-model/components';
import * as T from '#common/code-model/exports'
import * as http from '#common/code-model/http-operation';
import * as schema from '#common/code-model/schema';
import { Dictionary } from '#common/dictionary';
import { Serialization } from '#csharp/schema/extended-type-declaration';
import { ModelClass } from '#csharp/lowlevel-generator/model/model-class';
import { ModelInterface } from '#csharp/lowlevel-generator/model/interface';

// C# specific details for components

export interface SchemaDetails extends schema.SchemaDetails {
  typeDeclaration?: Serialization;
  classImplementation?: ModelClass;
  interfaceImplementation?: ModelInterface;
  interfaceName?: string;
}

export interface PropertyDetails extends schema.PropertyDetails {

}

export interface ParameterDetails extends http.HttpParameterDetails {

}

export interface ClientDetails extends codemodel.ClientDetails {

}

export interface HttpOperationDetails extends http.HttpOperationDetails {

}

export interface CommandOperationDetails extends command.CommandOperationDetails {

}

export interface LanguageDetails<T extends components.ImplementationDetails> extends components.LanguageDetails<T> {
  csharp: T;
}

export type Schema = T.SchemaT<LanguageDetails<SchemaDetails>, LanguageDetails<PropertyDetails>>;
export type Property = T.PropertyT<LanguageDetails<SchemaDetails>, LanguageDetails<PropertyDetails>>;
export type HttpOperation = T.HttpOperationT<LanguageDetails<SchemaDetails>, LanguageDetails<PropertyDetails>, LanguageDetails<ParameterDetails>, LanguageDetails<HttpOperationDetails>>;
export type HttpOperationParameter = T.HttpOperationParameterT<LanguageDetails<SchemaDetails>, LanguageDetails<PropertyDetails>, LanguageDetails<ParameterDetails>>;
export type HttpComponents = T.HttpComponentsT<LanguageDetails<SchemaDetails>, LanguageDetails<PropertyDetails>, LanguageDetails<ParameterDetails>, LanguageDetails<HttpOperationDetails>>;
export type Model = T.ModelT<LanguageDetails<SchemaDetails>, LanguageDetails<PropertyDetails>, LanguageDetails<ParameterDetails>, LanguageDetails<HttpOperationDetails>, LanguageDetails<ClientDetails>>;
export type CommandOperation = T.CommandOperationT<LanguageDetails<SchemaDetails>, LanguageDetails<PropertyDetails>, LanguageDetails<ParameterDetails>, LanguageDetails<HttpOperationDetails>, LanguageDetails<CommandOperationDetails>>;

/*
export interface _Schema extends schema.Schema {
  details: LanguageDetails<SchemaDetails>;
  properties: Dictionary<Property>;
  not?: Schema;
  allOf: Array<Schema>;
  oneOf: Array<Schema>;
  anyOf: Array<Schema>;
  items?: Schema;
  additionalProperties?: boolean | Schema;
}


export interface _Property extends schema.Property {
  details: LanguageDetails<PropertyDetails>;
  schema: Schema;
}
export interface _HttpOperation extends http.HttpOperation {
  details: LanguageDetails<OperationDetails>;
  parameters: Array<HttpOperationParameter>;
}
export interface _HttpOperationParameter extends http.HttpOperationParameter {
  details: LanguageDetails<http.HttpParameterDetails>;
  schema: Schema;
}


export interface HttpComponents extends http.HttpComponents {
  operations: Dictionary<HttpOperation>;
  parameters: Dictionary<HttpOperationParameter>;
}

export interface Model extends codemodel.Model {
  schemas: Dictionary<Schema>;
  details: LanguageDetails<ClientDetails>;

  http: HttpComponents;
}

*/

/*
// move to common

export interface SchemaT<TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>> extends schema.Schema {
  details: TLanguageDetailsForSchema;
  properties: Dictionary<Property>;
  not?: SchemaT<TLanguageDetailsForSchema>;
  allOf: Array<SchemaT<TLanguageDetailsForSchema>>;
  oneOf: Array<SchemaT<TLanguageDetailsForSchema>>;
  anyOf: Array<SchemaT<TLanguageDetailsForSchema>>;
  items?: SchemaT<TLanguageDetailsForSchema>;
  additionalProperties?: boolean | SchemaT<TLanguageDetailsForSchema>;
}


export interface PropertyT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForProperty extends components.LanguageDetails<schema.PropertyDetails>
  > extends schema.Property {
  details: TLanguageDetailsForProperty;
  schema: SchemaT<TLanguageDetailsForSchema>;
}


export interface HttpOperationParameterT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForParameter extends components.LanguageDetails<http.HttpParameterDetails>
  > extends http.HttpOperationParameter {
  details: TLanguageDetailsForParameter;
  schema: SchemaT<TLanguageDetailsForSchema>;
}

export interface HttpOperationT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForParameter extends components.LanguageDetails<http.HttpParameterDetails>,
  TLanguageDetailsForHttpOperation extends components.LanguageDetails<http.HttpOperationDetails>, 
  > extends http.HttpOperation{
  details: TLanguageDetailsForHttpOperation;
  parameters: Array<HttpOperationParameterT<TLanguageDetailsForSchema,TLanguageDetailsForParameter>>;
}

export interface HttpComponentsT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForParameter extends components.LanguageDetails<http.HttpParameterDetails>,
  TLanguageDetailsForHttpOperation extends components.LanguageDetails<http.HttpOperationDetails>, 
> extends http.HttpComponents {
  operations: Dictionary<HttpOperationT<TLanguageDetailsForSchema, TLanguageDetailsForParameter, TLanguageDetailsForParameter>>;
  parameters: Dictionary<HttpOperationParameterT<TLanguageDetailsForSchema, TLanguageDetailsForParameter>>;
}

export interface ModelT<
  TLanguageDetailsForSchema extends components.LanguageDetails<schema.SchemaDetails>,
  TLanguageDetailsForParameter extends components.LanguageDetails<http.HttpParameterDetails>,
  TLanguageDetailsForHttpOperation extends components.LanguageDetails<http.HttpOperationDetails>, 
  TLanguageDetailsForClient extends components.LanguageDetails<codemodel.ClientDetails>, 
> extends codemodel.Model {
  schemas: Dictionary<SchemaT<TLanguageDetailsForSchema>>;
  details: TLanguageDetailsForClient;

  http: HttpComponentsT<TLanguageDetailsForSchema,TLanguageDetailsForParameter,TLanguageDetailsForHttpOperation>;
}
*/