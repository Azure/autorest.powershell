import { Project as codeDomProject } from '#csharp/code-dom/project';

import { Dictionary, items, values } from '#common/dictionary';
import { Modifier } from '#csharp/code-dom/access-modifier';
import { Attribute } from '#csharp/code-dom/attribute';
import { Class } from '#csharp/code-dom/class';
import { LiteralExpression } from '#csharp/code-dom/expression';
import { Import } from '#csharp/code-dom/import';
import { Interface } from '#csharp/code-dom/interface';
import { LambdaMethod, Method } from '#csharp/code-dom/method';
import * as dotnet from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { Else, If, ElseIf } from '#csharp/code-dom/statements/if';
import { Return } from '#csharp/code-dom/statements/return';
import { Catch, Try } from '#csharp/code-dom/statements/try';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { ObjectFeatures } from '#csharp/schema/object';
import { SchemaDefinitionResolver } from '#csharp/schema/schema-resolver';
import { ModuleClass } from '#powershell/module-class';
import { PSObject, PSTypeConverter, TypeConverterAttribute } from '#powershell/powershell-declarations';
import { CmdletClass } from './cmdlet-class';
import { GeneratorSettings, State } from './state';

export class ServiceNamespace extends Namespace {
  public moduleClass: ModuleClass;

  public get outputFolder(): string {
    return this.state.project.moduleFolder;
  }

  constructor(public state: State, objectInitializer?: Partial<ServiceNamespace>) {
    super(state.model.details.csharp.namespace || 'INVALID.NAMESPACE', state.project);
    this.apply(objectInitializer);

    // module class
    this.moduleClass = new ModuleClass(this, state);
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

    for (const { key: schemaName, value: schema } of items(schemas)) {
      if (!schema) {
        continue;
      }
      const td = this.resolver.resolveTypeDeclaration(schema, true, state);
      if (td instanceof ObjectFeatures) {
        // it's a class object.
        const className = td.schema.details.csharp.name;
        const interfaceName = td.schema.details.csharp.interfaceName || '';
        const converterClass = `${className}TypeConverter`;

        // create the model extensions for each object model
        // 2. A partial interface with the type converter attribute
        const modelInterface = new Interface(this, interfaceName, {
          partial: true,
        });
        modelInterface.add(new Attribute(TypeConverterAttribute, { parameters: [new LiteralExpression(`typeof(${converterClass})`)] }));

        // 1. A partial class with the type converter attribute
        const model = new Class(this, className, undefined, {
          partial: true,
        });
        model.add(new Attribute(TypeConverterAttribute, { parameters: [new LiteralExpression(`typeof(${converterClass})`)] }));
        model.add(new LambdaMethod('FromJsonString', modelInterface, new LiteralExpression(`FromJson(${ClientRuntime.JsonNode.declaration}.Parse(jsonText))`), {
          static: Modifier.Static,
          parameters: [new Parameter('jsonText', dotnet.String)]
        }));

        model.add(new LambdaMethod('ToJsonString', dotnet.String, new LiteralExpression(`ToJson(${dotnet.Null}, ${ClientRuntime.JsonMode.IncludeAll})?.ToString()`), {
        }));

        // + static <interfaceType> FromJsonString(string json);
        // + string ToJsonString()

        // 3. A TypeConverter class
        const typeConverter = new Class(this, converterClass, PSTypeConverter);
        typeConverter.add(new LambdaMethod('CanConvertTo', dotnet.Bool, dotnet.False, {
          override: Modifier.Override,
          parameters: [
            new Parameter('sourceValue', dotnet.Object),
            new Parameter('destinationType', dotnet.System.Type)
          ]
        }));
        typeConverter.add(new LambdaMethod('ConvertTo', dotnet.Object, dotnet.Null, {
          override: Modifier.Override,
          parameters: [
            new Parameter('sourceValue', dotnet.Object),
            new Parameter('destinationType', dotnet.System.Type),
            new Parameter('formatProvider', dotnet.System.IFormatProvider),
            new Parameter('ignoreCase', dotnet.Bool),
          ]
        }));
        typeConverter.add(new LambdaMethod('CanConvertFrom', dotnet.Bool, new LiteralExpression(`CanConvertFrom(sourceValue)`), {
          override: Modifier.Override,
          parameters: [
            new Parameter('sourceValue', dotnet.Object),
            new Parameter('destinationType', dotnet.System.Type)
          ]
        }));
        typeConverter.add(new LambdaMethod('ConvertFrom', dotnet.Object, new LiteralExpression('ConvertFrom(sourceValue)'), {
          override: Modifier.Override,
          parameters: [
            new Parameter('sourceValue', dotnet.Object),
            new Parameter('destinationType', dotnet.System.Type),
            new Parameter('formatProvider', dotnet.System.IFormatProvider),
            new Parameter('ignoreCase', dotnet.Bool),
          ]
        }));

        typeConverter.add(new Method('CanConvertFrom', dotnet.Bool, {
          static: Modifier.Static,
          parameters: [
            new Parameter('sourceValue', dotnet.Dynamic),
          ]
        })).add(function* () {
          yield If(`null == sourceValue`, Return(dotnet.True));
          yield Try(function* () {
            yield If(`sourceValue.GetType() == typeof(${PSObject.declaration})`, function* () {
              yield `// does it have the properties we need`;
            });
            yield ElseIf(`sourceValue.GetType() == typeof(${dotnet.System.Collections.Hashtable.declaration})`, function* () {
              yield `// a hashtable?`;
            });

            yield Else(function* () {
              yield `// object `;
            })
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
            new Parameter('sourceValue', dotnet.Dynamic),
          ]
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
              if (memTD instanceof ObjectFeatures) {
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

        // public override bool CanConvertTo(object sourceValue, Type destinationType) => false;
        // public override object ConvertTo(object sourceValue, Type destinationType, IFormatProvider formatProvider, bool ignoreCase) => null;
        // public override bool CanConvertFrom(dynamic sourceValue, Type destinationType) => destinationType == typeof (EventData) && CanConvertFrom(sourceValue);
        // public override object ConvertFrom(dynamic sourceValue, Type destinationType, IFormatProvider formatProvider, bool ignoreCase) => ConvertFrom(sourceValue);

        // public static bool CanConvertFrom(dynamic sv)
        // public static object ConvertFrom(dynamic sv)

      }
    }
  }

}

export class CmdletNamespace extends Namespace {
  public get outputFolder(): string {
    return this.state.project.cmdletFolder;
  }

  constructor(parent: Namespace, private state: State, objectInitializer?: Partial<CmdletNamespace>) {
    super('Cmdlets', parent);
    this.apply(objectInitializer);
    this.addUsing(new Import('static Microsoft.Rest.ClientRuntime.IEventListenerExtensions'));
    // generate cmdlet classes on top of the SDK
    for (const { key: id, value: operation } of items(state.model.commands.operations)) {
      this.addClass(new CmdletClass(this, operation, state.path('commands', 'operations', id)));
    }
  }
}

export class Project extends codeDomProject {
  public azure!: boolean;
  public cmdletFolder!: string;
  public customFolder!: string;
  public runtimefolder!: string;
  public moduleName!: string;
  public csproj!: string;
  public psd1!: string;
  public psm1!: string;
  public apifolder!: string;
  public apiextensionsfolder!: string;
  public moduleFolder!: string;

  constructor(protected state: State) {
    super();
    state.project = this;


  }

  public async init() {
    const service = this.state.service;
    const model = this.state.model;
    const state = this.state;

    this.azure = await service.GetValue('azure') || await service.GetValue('azure-arm') || false;

    this.moduleName = await service.GetValue('module-name') || model.info.title.replace(/client/ig, '')



    this.moduleFolder = await service.GetValue('module-folder') || './private';

    this.cmdletFolder = await service.GetValue('cmdlet-folder') || 'private/cmdlets/generated';
    this.customFolder = await service.GetValue('custom-cmdlet-folder') || 'private/cmdlets/custom';

    this.runtimefolder = await service.GetValue('runtime-folder') || 'private/runtime';

    this.apifolder = await service.GetValue('api-folder') || './private/api';
    this.apiextensionsfolder = await service.GetValue('api-extensions-folder') || 'private/api-extensions';



    this.csproj = await service.GetValue('csproj') || `${this.moduleName}.private.csproj`;
    this.psd1 = await service.GetValue('psd1') || `${this.moduleName}.psd1`;
    this.psm1 = await service.GetValue('psm1') || `${this.moduleName}.psm1`;



    // add project namespace
    this.addNamespace(this.serviceNamespace = new ServiceNamespace(state));

    // add cmdlet namespace
    this.addNamespace(this.cmdlets = new CmdletNamespace(this.serviceNamespace, state));

    this.addNamespace(this.modelsExtensions = new ModelExtensionsNamespace(this.serviceNamespace, <any>state.model.schemas, state.path('components', 'schemas')));
    // abort now if we have any errors.
    state.checkpoint();
    return this;
  }

  public serviceNamespace!: ServiceNamespace;
  public cmdlets!: Namespace;
  public modelsExtensions!: ModelExtensionsNamespace;
}
