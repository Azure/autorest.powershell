/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { EnumDetails } from '@azure-tools/codemodel-v3';
import { If, Parameter, Method, Namespace, System, Struct } from '@azure-tools/codegen-csharp';
import { State } from '../state';
import { IArgumentCompleter, CompletionResult, CommandAst, CompletionResultType } from '../powershell-declarations';
import { join } from 'path';

export class SupportNamespace extends Namespace {
  public get outputFolder(): string {
    return join(this.state.project.apiFolder, 'Support');
  }

  constructor(parent: Namespace, public state: State, objectInitializer?: Partial<SupportNamespace>) {
    super('Support', parent);
    this.apply(objectInitializer);

    const enumInfos = values(state.model.schemas)
      .linq.where(each => each.details.csharp.enum !== undefined && !each.details.csharp.skip)
      .linq.select(each => ({ details: <EnumDetails>each.details.csharp.enum, description: each.details.csharp.description }))
      .linq.toArray();

    const done = new Set<string>();


    for (const enumInfo of enumInfos) {
      if (done.has(enumInfo.details.name)) {
        continue;
      }

      done.add(enumInfo.details.name);

      if (state.project.azure && /^api-?version$/i.exec(enumInfo.details.name)) {
        continue;
      }


      const enumValues = values(enumInfo.details.values).linq.select(v => <string>v.value).linq.toArray();
      const enumClass = new Struct(this, enumInfo.details.name, undefined, {
        interfaces: [IArgumentCompleter],
        partial: true,
        description: enumInfo.description || `Argument completer implementation for ${enumInfo.details.name}.`,
        fileName: `${enumInfo.details.name}.Completer`
      });
      const commandName = new Parameter('commandName', System.String, { description: 'The name of the command that needs argument completion.' });
      const parameterName = new Parameter('parameterName', System.String, { description: 'The name of the parameter that needs argument completion.' });
      const wordToComplete = new Parameter('wordToComplete', System.String, { description: 'The (possibly empty) word being completed.' });
      const commandAst = new Parameter('commandAst', CommandAst, { description: 'The command ast in case it is needed for completion.' });
      const fakeBoundParameters = new Parameter('fakeBoundParameters', System.Collections.IDictionary, { description: 'This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot or will not attempt to evaluate an argument, in which case you may need to use commandAst.' });
      const completeArgumentParams = [commandName, parameterName, wordToComplete, commandAst, fakeBoundParameters];

      enumClass.add(new Method('CompleteArgument', System.Collections.Generic.IEnumerable(CompletionResult), { parameters: completeArgumentParams, description: 'Implementations of this function are called by PowerShell to complete arguments.', returnsDescription: 'A collection of completion results, most like with ResultType set to ParameterValue.' })).add(function* () {
        for (const enumValue of enumValues) {
          yield If(`${System.String.declaration}.IsNullOrEmpty(${wordToComplete.name}) || "${enumValue}".StartsWith(${wordToComplete.name}, ${System.StringComparison.declaration}.InvariantCultureIgnoreCase)`,
            `yield return new ${CompletionResult.declaration}("${enumValue}", "${enumValue}", ${CompletionResultType.declaration}.ParameterValue, "${enumValue}");`);
        }
      });
    }
  }
}