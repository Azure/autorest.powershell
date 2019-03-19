/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { values } from '@microsoft.azure/codegen';
import { EnumDetails } from '@microsoft.azure/autorest.codemodel-v3';
import { If, Parameter, Method, Namespace, System, Struct, Attribute } from '@microsoft.azure/codegen-csharp';
import { State } from '../state';
import { IArgumentCompleter, CompletionResult, CommandAst, CompletionResultType, GeneratedAttribute } from '../powershell-declarations';

export class SupportNamespace extends Namespace {
  public get outputFolder(): string {
    return this.state.project.apiExtensionsFolder;
  }

  constructor(parent: Namespace, public state: State, objectInitializer?: Partial<SupportNamespace>) {
    super('Support', parent);
    this.apply(objectInitializer);

    const enumInfos = values(state.model.schemas)
      .linq.selectMany(s => values(s.properties))
      .linq.where(p => p.schema.details.csharp.enum !== undefined)
      .linq.distinct(p => <EnumDetails>p.schema.details.csharp.enum)
      .linq.select(p => ({ details: <EnumDetails>p.schema.details.csharp.enum, description: p.schema.details.csharp.description }))
      .linq.toArray();
    for (const enumInfo of enumInfos) {
      const enumValues = values(enumInfo.details.values).linq.select(v => <string>v.value).linq.toArray();

      const enumClass = new Struct(this, enumInfo.details.name, undefined, {
        interfaces: [IArgumentCompleter],
        partial: true,
        description: enumInfo.description || `Argument completer implementation for ${enumInfo.details.name}.`
      })

      const commandName = new Parameter("commandName", System.String, { description: "The name of the command that needs argument completion." });
      const parameterName = new Parameter("parameterName", System.String, { description: "The name of the parameter that needs argument completion." });
      const wordToComplete = new Parameter("wordToComplete", System.String, { description: "The (possibly empty) word being completed." });
      const commandAst = new Parameter("commandAst", CommandAst, { description: "The command ast in case it is needed for completion." });
      const fakeBoundParameters = new Parameter("fakeBoundParameters", System.Collections.IDictionary, { description: "This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot or will not attempt to evaluate an argument, in which case you may need to use commandAst." });
      const completeArgumentParams = [commandName, parameterName, wordToComplete, commandAst, fakeBoundParameters];

      enumClass.add(new Method("CompleteArgument", System.Collections.Generic.IEnumerable(CompletionResult), { parameters: completeArgumentParams, description: "Implementations of this function are called by PowerShell to complete arguments.", returnsDescription: "A collection of completion results, most like with ResultType set to ParameterValue." })).add(function* () {
        for (const enumValue of enumValues) {
          yield If(`${System.String.declaration}.IsNullOrEmpty(${wordToComplete.name}) || "${enumValue}".StartsWith(${wordToComplete.name}, ${System.StringComparison.declaration}.InvariantCultureIgnoreCase)`,
            `yield return new ${CompletionResult.declaration}("${enumValue}", "${enumValue}", ${CompletionResultType.declaration}.ParameterValue, "${enumValue}");`);
        }
      });
    }
  }
}