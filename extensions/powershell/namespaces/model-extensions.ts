/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { items, values, Dictionary } from '@microsoft.azure/codegen';
import { Catch, Try, Else, ElseIf, If, Interface, Attribute, Parameter, Modifier, dotnet, Class, LambdaMethod, LiteralExpression, Method, Namespace, System, Return, LocalVariable, Constructor, IsAssignableFrom, ImportDirective } from '@microsoft.azure/codegen-csharp';
import { Schema, ClientRuntime, SchemaDefinitionResolver, ObjectImplementation, DeserializerPartialClass } from '@microsoft.azure/autorest.csharp-v2';
import { State } from '../state';
import { PSObject, PSTypeConverter, TypeConverterAttribute } from '../powershell-declarations';
import { join } from 'path';

import { Variable } from '@microsoft.azure/codegen-csharp/exports';

class ApiVersionModelExtensionsNamespace extends Namespace {
  public get outputFolder(): string {
    return `${this.baseFolder}/${this.apiVersion.replace(/.*\./g, '')}`;
  }
  constructor(private baseFolder: string, private readonly apiVersion: string, objectInitializer?: Partial<ModelExtensionsNamespace>) {
    super(apiVersion);
    this.apply(objectInitializer);
    this.add(new ImportDirective(`${ClientRuntime.name}.PowerShell`));
  }
}

export class ModelExtensionsNamespace extends Namespace {
  private subNamespaces = new Dictionary<Namespace>();

  public get outputFolder(): string {
    return join(this.state.project.apiFolder, 'Models');
  }
  resolver = new SchemaDefinitionResolver();

  constructor(parent: Namespace, private schemas: Dictionary<Schema>, private state: State, objectInitializer?: Partial<ModelExtensionsNamespace>) {
    super('Models', parent);
    this.apply(objectInitializer);
    this.add(new ImportDirective(`${ClientRuntime.name}.PowerShell`));
    this.subNamespaces[this.fullName] = this;

    const $this = this;
    const resolver = (s: Schema) => this.resolver.resolveTypeDeclaration(s, true, state)

    // Add typeconverters to model classes (partial)
    for (const schema of values(schemas)) {
      if (!schema || schema.details.csharp.skip) {
        continue;
      }

      const td = this.resolver.resolveTypeDeclaration(schema, true, state);
      if (td instanceof ObjectImplementation) {

        // it's a class object.
        const className = td.schema.details.csharp.name;
        const interfaceName = td.schema.details.csharp.interfaceName || '';
        const converterClass = `${className}TypeConverter`;

        if (this.findClassByName(className).length > 0) {
          continue;
        }

        // get the actual full namespace for the schema
        const fullname = schema.details.csharp.namespace || this.fullName;
        const ns = this.subNamespaces[fullname] || this.add(new ApiVersionModelExtensionsNamespace(this.outputFolder, fullname));

        // create the model extensions for each object model
        // 2. A partial interface with the type converter attribute
        const modelInterface = new Interface(ns, interfaceName, {
          partial: true,
          description: td.schema.details.csharp.description,
          fileName: `${interfaceName}.PowerShell` // make sure that the interface ends up in the same file as the class.
        });
        modelInterface.add(new Attribute(TypeConverterAttribute, { parameters: [new LiteralExpression(`typeof(${converterClass})`)] }));



        // 1. A partial class with the type converter attribute
        const model = new Class(ns, className, undefined, {
          partial: true,
          description: td.schema.details.csharp.description,
          fileName: `${className}.PowerShell`
        });
        model.add(new Attribute(TypeConverterAttribute, { parameters: [new LiteralExpression(`typeof(${converterClass})`)] }));
        model.add(new LambdaMethod('FromJsonString', modelInterface, new LiteralExpression(`FromJson(${ClientRuntime.JsonNode.declaration}.Parse(jsonText))`), {
          static: Modifier.Static,
          parameters: [new Parameter('jsonText', dotnet.String, { description: 'a string containing a JSON serialized instance of this model.' })],
          description: `Creates a new instance of <see cref="${td.schema.details.csharp.name}" />, deserializing the content from a json string.`,
          returnsDescription: `an instance of the <see cref="className" /> model class.`
        }));

        model.add(new LambdaMethod('ToJsonString', dotnet.String, new LiteralExpression(`ToJson(${dotnet.Null}, ${ClientRuntime.SerializationMode.IncludeAll})?.ToString()`), {
          description: `Serializes this instance to a json string.`,
          returnsDescription: `a <see cref="System.String" /> containing this model serialized to JSON text.`
        }));

        const hashDeseralizer = new DeserializerPartialClass(model, modelInterface, System.Collections.IDictionary, 'Dictionary', schema, resolver).init();
        const psDeseralizer = new DeserializerPartialClass(model, modelInterface, PSObject, 'PSObject', schema, resolver).init();

        // + static <interfaceType> FromJsonString(string json);
        // + string ToJsonString()

        // 3. A TypeConverter class
        const typeConverter = new Class(ns, converterClass, PSTypeConverter, {
          description: `A PowerShell PSTypeConverter to support converting to an instance of <see cref="${className}" />`,
          fileName: `${className}.TypeConverter`
        });
        typeConverter.add(new LambdaMethod('CanConvertTo', dotnet.Bool, dotnet.False, {
          override: Modifier.Override,
          parameters: [
            new Parameter('sourceValue', dotnet.Object, { description: `the <see cref="System.Object"/> to convert from` }),
            new Parameter('destinationType', System.Type, { description: `the <see cref="System.Type" /> to convert to` })
          ],
          description: `Determines if the <see cref="sourceValue" /> parameter can be converted to the <see cref="destinationType" /> parameter`,
          returnsDescription: `<c>true</c> if the converter can convert the <see cref="sourceValue" /> parameter to the <see cref="destinationType" /> parameter, otherwise <c>false</c>`,
        }));
        typeConverter.add(new LambdaMethod('ConvertTo', dotnet.Object, dotnet.Null, {
          override: Modifier.Override,
          parameters: [
            new Parameter('sourceValue', dotnet.Object, { description: `the <see cref="System.Object"/> to convert from` }),
            new Parameter('destinationType', System.Type, { description: `the <see cref="System.Type" /> to convert to` }),
            new Parameter('formatProvider', System.IFormatProvider, { description: `not used by this TypeConverter.` }),
            new Parameter('ignoreCase', dotnet.Bool, { description: `when set to <c>true</c>, will ignore the case when converting.` }),
          ], description: `NotImplemented -- this will return <c>null</c>`,
          returnsDescription: `will always return <c>null</c>.`
        }));
        typeConverter.add(new LambdaMethod('CanConvertFrom', dotnet.Bool, new LiteralExpression(`CanConvertFrom(sourceValue)`), {
          override: Modifier.Override,
          parameters: [
            new Parameter('sourceValue', dotnet.Object, { description: `the <see cref="System.Object"/> to convert from` }),
            new Parameter('destinationType', System.Type, { description: `the <see cref="System.Type" /> to convert to` })
          ],
          description: `Determines if the converter can convert the <see cref="sourceValue"/> parameter to the <see cref="destinationType" /> parameter.`,
          returnsDescription: `<c>true</c> if the converter can convert the <see cref="sourceValue"/> parameter to the <see cref="destinationType" /> parameter, otherwise <c>false</c>.`,
        }));
        typeConverter.add(new LambdaMethod('ConvertFrom', dotnet.Object, new LiteralExpression('ConvertFrom(sourceValue)'), {
          override: Modifier.Override,
          parameters: [
            new Parameter('sourceValue', dotnet.Object, { description: `the <see cref="System.Object"/> to convert from` }),
            new Parameter('destinationType', System.Type, { description: `the <see cref="System.Type" /> to convert to` }),
            new Parameter('formatProvider', System.IFormatProvider, { description: `not used by this TypeConverter.` }),
            new Parameter('ignoreCase', dotnet.Bool, { description: `when set to <c>true</c>, will ignore the case when converting.` }),
          ],
          description: `Converts the <see cref="sourceValue" /> parameter to the <see cref="destinationType" /> parameter using <see cref="formatProvider" /> and <see cref="ignoreCase" /> `,
          returnsDescription: `an instance of <see cref="${className}" />, or <c>null</c> if there is no suitable conversion.`
        }));

        typeConverter.add(new Method('CanConvertFrom', dotnet.Bool, {
          static: Modifier.Static,
          parameters: [
            new Parameter('sourceValue', dotnet.Dynamic, { description: `the <see cref="System.Object" /> instance to check if it can be converted to the <see cref="${className}" /> type.` }),
          ],
          description: `Determines if the converter can convert the <see cref="sourceValue"/> parameter to the <see cref="destinationType" /> parameter.`,
          returnsDescription: `<c>true</c> if the instance could be converted to a <see cref="${className}" /> type, otherwise <c>false</c> `
        })).add(function* () {
          yield If(`null == sourceValue`, Return(dotnet.True));

          const t = new LocalVariable("type", System.Type, { initializer: `sourceValue.GetType()` });
          yield t.declarationStatement;

          if (schema.details.default.uid === 'universal-parameter-type') {
            yield `// for 'universal-parameter-type' we allow string conversion too.`
            yield If(`${t.value} == typeof(${System.String})`, Return(dotnet.True))
          }

          yield If(IsAssignableFrom(PSObject, t), function* () {
            yield `// we say yest to PSObjects`;
            yield Return(dotnet.True);
          });
          yield If(IsAssignableFrom(System.Collections.IDictionary, t), function* () {
            yield `// we say yest to Hashtables/dictionaries`;
            yield Return(dotnet.True);
          });

          yield Try(If(`null != sourceValue.ToJsonString()`, Return(dotnet.True)));
          yield Catch(undefined, `// Not one of our objects`);

          yield Try(function* () {
            const t = new LocalVariable('text', dotnet.String, { initializer: `sourceValue.ToString()?.Trim()` });
            yield t.declarationStatement;
            yield Return(`${dotnet.True} == ${t.value}?.StartsWith("{") && ${dotnet.True} == ${t.value}?.EndsWith("}") && ${ClientRuntime.JsonNode.Parse(t)}.Type == ${ClientRuntime.JsonType.Object}`);
          });
          yield Catch(undefined, `// Doesn't look like it can be treated as JSON`);

          yield Return(dotnet.False);
        });

        typeConverter.add(new Method('ConvertFrom', dotnet.Object, {
          static: Modifier.Static,
          parameters: [
            new Parameter('sourceValue', dotnet.Dynamic, {
              description: `the value to convert into an instance of <see cref="${className}" />.`
            }),
          ],
          description: `Converts the <see cref="sourceValue" /> parameter to the <see cref="destinationType" /> parameter using <see cref="formatProvider" /> and <see cref="ignoreCase" />`,
          returnsDescription: `an instance of <see cref="${className}" />, or <c>null</c> if there is no suitable conversion.`
        })).add(function* () {
          // null begets null
          yield If(`null == sourceValue`, Return(dotnet.Null));

          const t = new LocalVariable("type", System.Type, { initializer: `sourceValue.GetType()` });
          yield t.declarationStatement;

          if (schema.details.default.uid === 'universal-parameter-type') {
            yield `// for 'universal-parameter-type' support direct string to id type conversion.`
            yield If(`${t.value} == typeof(${System.String})`, function* () {
              yield Return(`new ${className} { Id = sourceValue }`);
            });
          }

          // if the type can be assigned directly, do that 
          yield If(IsAssignableFrom(td, t), Return(`sourceValue`));


          // try using json first (either from string or toJsonString())
          yield Try(Return(`${className}.FromJsonString(typeof(string) == sourceValue.GetType() ? sourceValue : sourceValue.ToJsonString());`));
          yield Catch(undefined, `// Unable to use JSON pattern`);

          yield If(IsAssignableFrom(PSObject, t), Return(`${className}.DeserializeFromPSObject(sourceValue)`));
          yield If(IsAssignableFrom(System.Collections.IDictionary, t), Return(`${className}.DeserializeFromDictionary(sourceValue)`));

          // null if not successful
          yield Return(dotnet.Null);
        }
        );
      }
    }


  }
}