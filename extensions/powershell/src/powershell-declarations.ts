/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { intersect } from '@microsoft.azure/codegen';
import { Expression, TypeDeclaration, Parameter, ParameterModifier, Access, Modifier, dotnet, ClassType, Class, Constructor, Field, LambdaMethod, PartialMethod, LiteralExpression, StringExpression, valueOf, InitializedField, Method, Namespace, ImplementedProperty, Statements, MemberVariable, Variable, System, LocalVariable, Using, Return, LambdaProperty, LazyProperty, Property } from '@microsoft.azure/codegen-csharp';

import { ClientRuntime } from '@microsoft.azure/autorest.csharp-v2';

const sma = new Namespace(`System.Management.Automation`);

export const PSCmdlet = new Class(new Namespace('System.Management.Automation'), 'PSCmdlet');
export const PSCredential: TypeDeclaration = new ClassType(sma, `PSCredential`);

export const PSObject: TypeDeclaration = new ClassType(sma, `PSObject`);
export const CmdletAttribute: TypeDeclaration = new ClassType(sma, `Cmdlet`);
export const ParameterAttribute: TypeDeclaration = new ClassType(sma, `Parameter`);
export const InvocationInfo: TypeDeclaration = new ClassType(sma, `InvocationInfo`);
export const PSTypeConverter: Class = new Class(sma, `PSTypeConverter`);
export const ValidateNotNull: TypeDeclaration = new ClassType(sma, `ValidateNotNull`);
export const Alias: TypeDeclaration = new ClassType(sma, `Alias`);
export const AliasAttribte: TypeDeclaration = new ClassType(sma, `Alias`);
export const TypeConverterAttribute: TypeDeclaration = new ClassType('System.ComponentModel', `TypeConverter`);
export const ResourceGroupCompleter: TypeDeclaration = new ClassType(sma, `ResourceGroupCompleter`);
export const OutputTypeAttribute: TypeDeclaration = new ClassType(sma, `OutputType`);
export const ErrorRecord: TypeDeclaration = new ClassType(sma, `ErrorRecord`);
export const SwitchParameter: TypeDeclaration = new ClassType(sma, 'SwitchParameter');

export const AsyncCommandRuntime = new ClassType(ClientRuntime, `PowerShell.AsyncCommandRuntime`);
export const AsyncJob = new ClassType(ClientRuntime, `PowerShell.AsyncJob`);

export function ErrorCategory(category: string): Expression {
  return new LiteralExpression(`${sma}.ErrorCategory.${category}`);
}

export function verbEnum(category: string, verb: string): Expression {
  return new LiteralExpression(`${category}.${verb}`);
}

export const Events = intersect(ClientRuntime.Events, {
  CmdletProcessRecordStart: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletProcessRecordStart`),
  CmdletProcessRecordAsyncStart: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletProcessRecordAsyncStart`),
  CmdletException: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletException`),
  CmdletGetPipeline: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletGetPipeline`),
  CmdletBeforeAPICall: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletBeforeAPICall`),
  CmdletAfterAPICall: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletAfterAPICall`),
  CmdletBeginProcessing: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletBeginProcessing`),
  CmdletEndProcessing: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletEndProcessing`),
  CmdletProcessRecordEnd: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletProcessRecordEnd`),
  CmdletProcessRecordAsyncEnd: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletProcessRecordAsyncEnd`),
  FollowingNextLink: new LiteralExpression(`${ClientRuntime.Events.declaration}.FollowingNextLink`),
  Verbose: new LiteralExpression(`${ClientRuntime.Events.declaration}.Verbose`),
  Debug: new LiteralExpression(`${ClientRuntime.Events.declaration}.Debug`),
  Information: new LiteralExpression(`${ClientRuntime.Events.declaration}.Information`),
  Error: new LiteralExpression(`${ClientRuntime.Events.declaration}.Error`),
  Warning: new LiteralExpression(`${ClientRuntime.Events.declaration}.Warning`),
});
