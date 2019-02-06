/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { deconstruct, pascalCase, items, length, values, Dictionary } from '@microsoft.azure/codegen';
import { JsonType, EnumDetails } from '@microsoft.azure/autorest.codemodel-v3';

import { Catch, Try, Else, ElseIf, If, Interface, ImportDirective, ImportStatic, Attribute, Parameter, ParameterModifier, Access, Modifier, dotnet, ClassType, Alias, Class, Constructor, Field, LambdaMethod, PartialMethod, LiteralExpression, StringExpression, valueOf, InitializedField, Method, Namespace, ImplementedProperty, Statements, MemberVariable, Variable, System, LocalVariable, Using, Return, LambdaProperty, LazyProperty, Property } from '@microsoft.azure/codegen-csharp';

import { Schema, ClientRuntime, SchemaDefinitionResolver, ObjectImplementation } from '@microsoft.azure/autorest.csharp-v2';

import { State } from './state';
import { Project as codeDomProject } from '@microsoft.azure/codegen-csharp';
import { ModelCmdlet } from './model-cmdlet';
import { ModuleClass } from './module-class';
import { PSObject, PSTypeConverter, TypeConverterAttribute, IArgumentCompleter, CompletionResult, CommandAst, CompletionResultType } from './powershell-declarations';
import { CmdletClass } from './cmdlet-class';


export class ServiceNamespace extends Namespace {
  public moduleClass: ModuleClass;

  public get outputFolder(): string {
    return this.state.project.moduleFolder;
  }

  constructor(public state: State, objectInitializer?: Partial<ServiceNamespace>) {
    super(state.model.details.csharp.namespace || 'INVALID.NAMESPACE', state.project);
    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // module class
    this.moduleClass = new ModuleClass(this, state);
  }
}

export class SupportNamespace extends Namespace {
  public get outputFolder(): string {
    return this.state.project.apiextensionsfolder;
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

      const enumClass = new Class(this, enumInfo.details.name, undefined, {
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

export class ModelExtensionsNamespace extends Namespace {
  public get outputFolder(): string {
    return this.state.project.apiextensionsfolder;
  }
  resolver = new SchemaDefinitionResolver();

  constructor(parent: Namespace, private schemas: Dictionary<Schema>, private state: State, objectInitializer?: Partial<ModelExtensionsNamespace>) {
    super('Models', parent);
    this.apply(objectInitializer);
    const $this = this;

    // Add typeconverters to model classes (partial)
    for (const { key: schemaName, value: schema } of items(schemas)) {
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

        // create the model extensions for each object model
        // 2. A partial interface with the type converter attribute
        const modelInterface = new Interface(this, interfaceName, {
          partial: true,
          description: td.schema.details.csharp.description
        });
        modelInterface.add(new Attribute(TypeConverterAttribute, { parameters: [new LiteralExpression(`typeof(${converterClass})`)] }));

        // 1. A partial class with the type converter attribute
        const model = new Class(this, className, undefined, {
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
        const typeConverter = new Class(this, converterClass, PSTypeConverter, {
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
            // loop thru members...
            for (const member of values(td.schema.properties)) {
              // if it's a primitive field
              const memTD = $this.resolver.resolveTypeDeclaration(member.schema, true, state);
              if (memTD instanceof ObjectImplementation) {
                // it's an object, try the typeconverter
                yield `${member.details.csharp.name} = ${member.schema.details.csharp.name}TypeConverter.ConvertFrom(sourceValue.${member.details.csharp.name}),`;
              } else {
                // just assign it.
                yield `${member.details.csharp.name} = sourceValue.${member.details.csharp.name},`;
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

export class ModelCmdletNamespace extends Namespace {
  inputModels = new Array<Schema>();
  public get outputFolder(): string {
    return this.state.project.modelCmdletFolder;
  }

  constructor(parent: Namespace, private state: State, objectInitializer?: Partial<ModelCmdletNamespace>) {
    super('ModelCmdlets', parent);
    this.apply(objectInitializer);
    this.add(ImportStatic(ClientRuntime.Extensions));
  }

  public createModelCmdlets() {
    // generate the model cmdlets unless they dont want them.
    if (!this.state.project.skipModelCmdlets) {
      for (const { key: id, value: schema } of items(this.state.model.schemas)) {
        if (schema.type !== JsonType.Object) {
          continue;
        }
        let found = false;

        // check if a cmdlet uses this as a parameter
        for (const sch of values(this.inputModels)) {
          if (sch === schema) {
            found = true;
            break;
          }
        }

        if (found) {
          this.addClass(new ModelCmdlet(this, <Schema>schema, this.state.path('schemas', id)));
        }
      }
    }
  }

  public addInputSchema(schema: Schema) {
    if (schema.type === JsonType.Object) {
      if (this.inputModels.indexOf(schema) === -1) {
        this.inputModels.push(schema);
        for (const p of values(schema.properties)) {
          if (!p.schema.readOnly && !p.details.csharp.HeaderProperty && !p.schema.additionalProperties) {
            this.addInputSchema(p.schema);
          }
        }
      }
    }
  }
}

export class CmdletNamespace extends Namespace {
  inputModels = new Array<Schema>();
  public get outputFolder(): string {
    return this.state.project.cmdletFolder;
  }

  constructor(parent: Namespace, private state: State, objectInitializer?: Partial<CmdletNamespace>) {
    super('Cmdlets', parent);
    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // generate cmdlet classes on top of the SDK
    for (const { key: id, value: operation } of items(state.model.commands.operations)) {
      this.addClass(new CmdletClass(this, operation, state.path('commands', 'operations', id)));

      /* if (operation.details.powershell.hasBody) {
        // make a copy that doesn't use the body parameter
        this.addClass(new CmdletClass(this, operation, state.path('commands', 'operations', id), true));
      } */

      for (const p of operation.parameters) {
        state.project.modelCmdlets.addInputSchema(<Schema>p.schema);
      }
    }
  }
}

export class Project extends codeDomProject {
  public azure!: boolean;
  public cmdletFolder!: string;
  public modelCmdletFolder!: string;
  public customFolder!: string;
  public testFolder!: string;
  public runtimefolder!: string;
  public moduleName!: string;
  public csproj!: string;
  public psd1!: string;
  public psm1!: string;
  public apifolder!: string;
  public apiextensionsfolder!: string;
  public moduleFolder!: string;
  public schemaDefinitionResolver: SchemaDefinitionResolver;
  public maxInlinedParameters!: number;
  public skipModelCmdlets!: boolean;
  public nounPrefix!: string;
  public projectNamespace: string;
  public overrides: Dictionary<string>;

  constructor(protected state: State) {
    super();
    this.schemaDefinitionResolver = new SchemaDefinitionResolver();
    state.project = this;
    this.projectNamespace = state.model.details.csharp.namespace;

    this.overrides = {
      'Carbon.Json.Converters': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Internal.Extensions': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Internal': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Data': `${this.projectNamespace}.Runtime.Json`,
      'using Data;': '',
      'using Parser;': '',
      'using Converters;': '',
      'using Internal.Extensions;': '',

      'Carbon.Json.Parser': `${this.projectNamespace}.Runtime.Json`,
      'Carbon.Json': `${this.projectNamespace}.Runtime.Json`,
      'Microsoft.Rest.ClientRuntime': `${this.projectNamespace}.Runtime`,
    };
  }

  public async init(): Promise<this> {
    await super.init();
    const service = this.state.service;
    const model = this.state.model;
    const state = this.state;

    const mil = await service.GetValue('max-inlined-parameters');
    this.maxInlinedParameters = typeof mil === 'number' ? mil : 4;

    const smc = await service.GetValue('skip-model-cmdlets');
    this.skipModelCmdlets = smc ? true : false;

    this.azure = await service.GetValue('azure') || await service.GetValue('azure-arm') || false;

    this.moduleName = pascalCase(deconstruct(await service.GetValue('module-name') || model.info.title.replace(/client/ig, '')));

    this.moduleFolder = await service.GetValue('module-folder') || './private';

    this.cmdletFolder = await service.GetValue('cmdlet-folder') || `${this.moduleFolder}/cmdlets/generated`;
    this.modelCmdletFolder = await service.GetValue('model-cmdlet-folder') || `${this.moduleFolder}/cmdlets/models`;
    this.customFolder = await service.GetValue('custom-cmdlet-folder') || `${this.moduleFolder}/custom/`;
    this.testFolder = await service.GetValue('test-folder') || `${this.moduleFolder}/Tests`;

    this.runtimefolder = await service.GetValue('runtime-folder') || `${this.moduleFolder}/runtime`;

    this.apifolder = await service.GetValue('api-folder') || `${this.moduleFolder}/api`;
    this.apiextensionsfolder = await service.GetValue('api-extensions-folder') || `${this.moduleFolder}/api-extensions`;

    this.csproj = await service.GetValue('csproj') || `${this.moduleName}.private.csproj`;
    this.psd1 = await service.GetValue('psd1') || `${this.moduleName}.psd1`;
    this.psm1 = await service.GetValue('psm1') || `${this.moduleName}.psm1`;

    this.nounPrefix = await service.GetValue('noun-prefix') || this.azure ? 'Az' : ``;

    // add project namespace
    this.addNamespace(this.serviceNamespace = new ServiceNamespace(state));

    this.addNamespace(this.supportNamespace = new SupportNamespace(this.serviceNamespace, state))

    this.addNamespace(this.modelCmdlets = new ModelCmdletNamespace(this.serviceNamespace, state));
    // add cmdlet namespace
    this.addNamespace(this.cmdlets = new CmdletNamespace(this.serviceNamespace, state));

    this.addNamespace(this.modelsExtensions = new ModelExtensionsNamespace(this.serviceNamespace, <any>state.model.schemas, state.path('components', 'schemas')));

    if (!this.skipModelCmdlets) {
      this.modelCmdlets.createModelCmdlets();
    }

    // abort now if we have any errors.
    state.checkpoint();
    return this;
  }

  public serviceNamespace!: ServiceNamespace;
  public supportNamespace!: SupportNamespace;
  public cmdlets!: CmdletNamespace;
  public modelCmdlets!: ModelCmdletNamespace;
  public modelsExtensions!: ModelExtensionsNamespace;
}
