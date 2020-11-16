/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, command, components, exportedModels as T, http, schema } from '@azure-tools/codemodel-v3';
import { ModelInterface } from './model/interface';
import { ModelClass } from './model/model-class';
import { EnhancedTypeDeclaration } from './schema/extended-type-declaration';


// C# specific details for components

export interface SchemaDetails extends schema.SchemaDetails {
  typeDeclaration?: EnhancedTypeDeclaration;
  classImplementation?: ModelClass;
  interfaceImplementation?: ModelInterface;
  internalInterfaceImplementation?: ModelInterface;
  interfaceName?: string;
  internalInterfaceName?: string;
  fullInternalInterfaceName?: string;
  fullname?: string;
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
