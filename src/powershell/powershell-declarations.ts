
import { Expression, LiteralExpression } from '#csharp/code-dom/expression';
import { LibraryType } from '#csharp/code-dom/dotnet';
import { Namespace } from '#csharp/code-dom/namespace';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { intersect } from '#common/intersect';
import { Class } from '#csharp/code-dom/class';

const sma = new Namespace(`System.Management.Automation`);


export const PSCmdlet: TypeDeclaration = new LibraryType(sma, `PSCmdlet`);
export const PSCredential: TypeDeclaration = new LibraryType(sma, `PSCredential`);

export const PSObject: TypeDeclaration = new LibraryType(sma, `PSObject`);
export const CmdletAttribute: TypeDeclaration = new LibraryType(sma, `Cmdlet`);
export const ParameterAttribute: TypeDeclaration = new LibraryType(sma, `Parameter`);
export const PSTypeConverter: Class = new Class(sma, `PSTypeConverter`);
export const ValidateNotNull: TypeDeclaration = new LibraryType(sma, `ValidateNotNull`);
export const Alias: TypeDeclaration = new LibraryType(sma, `Alias`);
export const AliasAttribte: TypeDeclaration = new LibraryType(sma, `Alias`);
export const TypeConverterAttribute: TypeDeclaration = new LibraryType('System.ComponentModel', `TypeConverter`);
export const ResourceGroupCompleter: TypeDeclaration = new LibraryType(sma, `ResourceGroupCompleter`);
export const OutputTypeAttribute: TypeDeclaration = new LibraryType(sma, `OutputType`);
export const ErrorRecord: TypeDeclaration = new LibraryType(sma, `ErrorRecord`);
export const SwitchParameter: TypeDeclaration = new LibraryType(sma, 'SwitchParameter');

export const AsyncCommandRuntime = new LibraryType(ClientRuntime, `PowerShell.AsyncCommandRuntime`);
export const AsyncJob = new LibraryType(ClientRuntime, `PowerShell.AsyncJob`);

export function ErrorCategory(category: string): Expression {
  return new LiteralExpression(`${sma}.ErrorCategory.${category}`);
}

export function verbEnum(category: string, verb: string): Expression {
  return new LiteralExpression(`${category}.${verb}`);
}


export const Events = intersect(ClientRuntime.Events, {
  CmdletProcessRecordStart: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletProcessRecordStart`),
  CmdletException: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletException`),
  CmdletGetPipeline: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletGetPipeline`),
  CmdletBeforeAPICall: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletBeforeAPICall`),
  CmdletAfterAPICall: new LiteralExpression(`${ClientRuntime.Events.declaration}.CmdletAfterAPICall`),
  FollowingNextLink: new LiteralExpression(`${ClientRuntime.Events.declaration}.FollowingNextLink`),
  Verbose: new LiteralExpression(`${ClientRuntime.Events.declaration}.Verbose`),
  Debug: new LiteralExpression(`${ClientRuntime.Events.declaration}.Debug`),
  Information: new LiteralExpression(`${ClientRuntime.Events.declaration}.Information`),
  Error: new LiteralExpression(`${ClientRuntime.Events.declaration}.Error`),
  Warning: new LiteralExpression(`${ClientRuntime.Events.declaration}.Warning`),
});