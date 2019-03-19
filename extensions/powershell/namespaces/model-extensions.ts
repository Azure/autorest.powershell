/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { items, values, Dictionary } from '@microsoft.azure/codegen';
import { Catch, Try, Else, ElseIf, If, Interface, Attribute, Parameter, Modifier, dotnet, Class, LambdaMethod, LiteralExpression, Method, Namespace, System, Return } from '@microsoft.azure/codegen-csharp';
import { Schema, ClientRuntime, SchemaDefinitionResolver, ObjectImplementation } from '@microsoft.azure/autorest.csharp-v2';
import { State } from '../state';
import { PSObject, PSTypeConverter, TypeConverterAttribute } from '../powershell-declarations';

class ApiVersionModelExtensionsNamespace extends Namespace {
  public get outputFolder(): string {
    return `${this.baseFolder}/${this.apiVersion.replace(/.*\./g, '')}`;
  }
  constructor(private baseFolder: string, private readonly apiVersion: string, objectInitializer?: Partial<ModelExtensionsNamespace>) {
    super(apiVersion);
    this.apply(objectInitializer);
  }
}

export class ModelExtensionsNamespace extends Namespace {
  private subNamespaces = new Dictionary<Namespace>();

  public get outputFolder(): string {
    return this.state.project.apiExtensionsFolder;
  }
  resolver = new SchemaDefinitionResolver();

  constructor(parent: Namespace, private schemas: Dictionary<Schema>, private state: State, objectInitializer?: Partial<ModelExtensionsNamespace>) {
    super('Models', parent);
    this.apply(objectInitializer);
    const $this = this;

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
        const ns = this.subNamespaces[fullname] || this.add(new ApiVersionModelExtensionsNamespace(this.state.project.apiExtensionsFolder, fullname));

        // create the model extensions for each object model
        // 2. A partial interface with the type converter attribute
        const modelInterface = new Interface(ns, interfaceName, {
          partial: true,
          description: td.schema.details.csharp.description
        });
        modelInterface.add(new Attribute(TypeConverterAttribute, { parameters: [new LiteralExpression(`typeof(${converterClass})`)] }));

        // 1. A partial class with the type converter attribute
        const model = new Class(ns, className, undefined, {
          partial: true,
          description: td.schema.details.csharp.description
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

        // + static <interfaceType> FromJsonString(string json);
        // + string ToJsonString()

        // 3. A TypeConverter class
        const typeConverter = new Class(ns, converterClass, PSTypeConverter, {
          description: `A PowerShell PSTypeConverter to support converting to an instance of <see cref="${className}" />`,
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
          yield Try(function* () {
            yield If(`sourceValue.GetType() == typeof(${PSObject.declaration})`, function* () {
              yield `// does it have the properties we need`;
            });
            yield ElseIf(`sourceValue.GetType() == typeof(${System.Collections.Hashtable.declaration})`, function* () {
              yield `// a hashtable?`;
            });

            yield Else(function* () {
              yield `// object `;
            });
            // is the source a PSType or a hashtable?

            // is the source a string? has a ToJson?
            // try deserializing, and validate. if successful, return true

            // does it have the same members as I do?

          });
          yield Catch(undefined, `// Unable to use JSON pattern`);
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

          // try using json first (either from string or toJsonString())
          yield Try(`${className}.FromJsonString(typeof(string) == sourceValue.GetType() ? sourceValue : sourceValue.ToJsonString());`);
          yield Catch(undefined, `// Unable to use JSON pattern`);

          yield Try(function* () {
            yield `return new ${className}`;
            yield `{`;
            const props = td.schema.details.csharp.virtualProperties || {
              owned: [],
              inlined: [],
              inherited: []
            };
            const all = [...props.owned, ...props.inherited];
            // loop thru members...
            for (const member of values(all)) {
              // if it's a primitive field
              const memTD = $this.resolver.resolveTypeDeclaration(<Schema>member.property.schema, true, state);
              if (memTD instanceof ObjectImplementation) {
                // it's an object, try the typeconverter
                // todo: fix this! We don't have the proper acess to generate the right code for this at this point.
                // yield `${member.accessViaMember} = ${member.property.schema.details.csharp.fullname}TypeConverter.ConvertFrom(sourceValue.${member.accessViaMember}),`;
              } else {
                // just assign it.
                // yield `${member.accessViaMember} = sourceValue.${member.accessViaMember},`;
              }
              // otherwise use the field's typeconverter

            }
            yield `};`;
          });
          yield Catch(undefined, ``);

          // null if not successful
          yield Return(dotnet.Null);
        }
        );
      }
    }
  }
}