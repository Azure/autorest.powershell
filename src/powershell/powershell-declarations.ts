
import { Expression, LiteralExpression } from '#csharp/code-dom/expression';
import { LibraryType } from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';

export const SMA = new Namespace(`System.Management.Automation`);

export const PSCmdlet: TypeDeclaration = new LibraryType(`${SMA}.PSCmdlet`);
export const CmdletAttribute: TypeDeclaration = new LibraryType(`${SMA}.Cmdlet`);
export const ParameterAttribute: TypeDeclaration = new LibraryType(`${SMA}.Parameter`);
export const ValidateNotNull: TypeDeclaration = new LibraryType(`${SMA}.ValidateNotNull`);
export const AliasAttribte: TypeDeclaration = new LibraryType(`${SMA}.Alias`);
export const ResourceGroupCompleter: TypeDeclaration = new LibraryType(`${SMA}.ResourceGroupCompleter`);
export const OutputTypeAttribute: TypeDeclaration = new LibraryType(`${SMA}.OutputType`);
export const ErrorRecord: TypeDeclaration = new LibraryType(`${SMA}.ErrorRecord`);

export const AsyncCommandRuntime = new LibraryType(`${ClientRuntime}.PowerShell.AsyncCommandRuntime`);

export function ErrorCategory(category: string): Expression {
  return new LiteralExpression(`${SMA}.ErrorCategory.${category}`);
}

export function verbEnum(category: string, verb: string): Expression {
  return new LiteralExpression(`${category}.${verb}`);
}
