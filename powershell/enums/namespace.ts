/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { EnumDetails } from '@azure-tools/codemodel-v3';
import { If, Parameter, Method, Namespace, System, Struct, Attribute, Class, dotnet, LambdaMethod, LiteralExpression, Modifier } from '@azure-tools/codegen-csharp';
import { State } from '../internal/state';
import { IArgumentCompleter, CompletionResult, CommandAst, CompletionResultType, TypeConverterAttribute, PSTypeConverter } from '../internal/powershell-declarations';
import { join } from 'path';
import { DeepPartial } from '@azure-tools/codegen';

import { EnumDetails as NewEnumDetails } from '../utils/schema';

export class EnumNamespace extends Namespace {
  public get outputFolder(): string {
    return join(this.state.project.apiFolder, 'Support');
  }

  constructor(parent: Namespace, public state: State, objectInitializer?: DeepPartial<EnumNamespace>) {
    super('Support', parent);
    this.apply(objectInitializer);
    //const enumInfos = [...state.model.schemas.sealedChoices ?? [], ...state.model.schemas.choices ?? []]
    const enumInfos = [...state.model.schemas.sealedChoices ?? []]
      .filter((choice) => !choice.language.csharp?.skip)
      .map((choice) => {
        return {
          details: <NewEnumDetails>choice.language.csharp?.enum,
          description: choice.language.csharp?.description
        };
      });

    const done = new Set<string>();

    for (const enumInfo of enumInfos) {
      if (done.has(enumInfo.details.name)) {
        continue;
      }

      done.add(enumInfo.details.name);

      if (state.project.azure && /^api-?version$/i.exec(enumInfo.details.name)) {
        continue;
      }

      // generate a typeconverter for the enum class too.

      const enumValues = values(enumInfo.details.values).select(v => <string>v.value).toArray();
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
            `yield return new ${CompletionResult.declaration}("'${enumValue}'", "${enumValue}", ${CompletionResultType.declaration}.ParameterValue, "${enumValue}");`);
        }
      });


      // generate a typeconverter for the enum class too.

      const converterClass = new Class(this, `${enumInfo.details.name}TypeConverter`, undefined, {
        interfaces: [PSTypeConverter],
        partial: true,
        description: enumInfo.description || `TypeConverter implementation for ${enumInfo.details.name}.`,
        fileName: `${enumInfo.details.name}.TypeConverter`
      });

      converterClass.add(new LambdaMethod('CanConvertFrom', dotnet.Bool, dotnet.True, {
        override: Modifier.Override,
        parameters: [
          new Parameter('sourceValue', dotnet.Object, { description: 'the <see cref="System.Object"/> to convert from' }),
          new Parameter('destinationType', System.Type, { description: 'the <see cref="System.Type" /> to convert to' })
        ],
        description: 'Determines if the converter can convert the <paramref name="sourceValue"/> parameter to the <paramref name="destinationType" /> parameter.',
        returnsDescription: '<c>true</c> if the converter can convert the <paramref name="sourceValue"/> parameter to the <paramref name="destinationType" /> parameter, otherwise <c>false</c>.',
      }));

      converterClass.add(new LambdaMethod('CanConvertTo', dotnet.Bool, dotnet.False, {
        override: Modifier.Override,
        parameters: [
          new Parameter('sourceValue', dotnet.Object, { description: 'the <see cref="System.Object"/> to convert from' }),
          new Parameter('destinationType', System.Type, { description: 'the <see cref="System.Type" /> to convert to' })
        ],
        description: 'Determines if the converter can convert the <paramref name="sourceValue"/> parameter to the <paramref name="destinationType" /> parameter.',
        returnsDescription: '<c>true</c> if the converter can convert the <paramref name="sourceValue"/> parameter to the <paramref name="destinationType" /> parameter, otherwise <c>false</c>.',
      }));

      converterClass.add(new LambdaMethod('ConvertFrom', dotnet.Object, new LiteralExpression(`${enumInfo.details.name}.CreateFrom(sourceValue)`), {
        override: Modifier.Override,
        parameters: [
          new Parameter('sourceValue', dotnet.Object, { description: 'the <see cref="System.Object"/> to convert from' }),
          new Parameter('destinationType', System.Type, { description: 'the <see cref="System.Type" /> to convert to' }),
          new Parameter('formatProvider', System.IFormatProvider, { description: 'not used by this TypeConverter.' }),
          new Parameter('ignoreCase', dotnet.Bool, { description: 'when set to <c>true</c>, will ignore the case when converting.' }),
        ],
        description: 'Converts the <paramref name="sourceValue" /> parameter to the <paramref name="destinationType" /> parameter using <paramref name="formatProvider" /> and <paramref name="ignoreCase" /> ',
        returnsDescription: `an instance of <see cref="${enumInfo.details.name}" />, or <c>null</c> if there is no suitable conversion.`
      }));

      converterClass.add(new LambdaMethod('ConvertTo', dotnet.Object, dotnet.Null, {
        override: Modifier.Override,
        parameters: [
          new Parameter('sourceValue', dotnet.Object, { description: 'the <see cref="System.Object"/> to convert from' }),
          new Parameter('destinationType', System.Type, { description: 'the <see cref="System.Type" /> to convert to' }),
          new Parameter('formatProvider', System.IFormatProvider, { description: 'not used by this TypeConverter.' }),
          new Parameter('ignoreCase', dotnet.Bool, { description: 'when set to <c>true</c>, will ignore the case when converting.' }),
        ], description: 'NotImplemented -- this will return <c>null</c>',
        returnsDescription: 'will always return <c>null</c>.'
      }));

      enumClass.add(new Attribute(TypeConverterAttribute, { parameters: [new LiteralExpression(`typeof(${converterClass})`)] }));

    }
  }
}