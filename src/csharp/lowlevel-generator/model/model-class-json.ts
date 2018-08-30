

import { any, items, keys, values } from '#common/dictionary';
import { camelCase, deconstruct, EOL, fixLeadingNumber, nameof, indent, pascalCase } from '#common/text-manipulation';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Constructor } from '#csharp/code-dom/constructor';
import { Is, IsDeclaration, LiteralExpression } from '#csharp/code-dom/expression';
import { InitializedField } from '#csharp/code-dom/field';
import { Method, PartialMethod } from '#csharp/code-dom/method';
import * as dotnet from '#csharp/code-dom/dotnet';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { ParameterModifier } from '#csharp/code-dom/parameter-modifier';
import { Case, TerminalCase } from '#csharp/code-dom/statements/case';
import { ForEach } from '#csharp/code-dom/statements/for';
import { If, Not } from '#csharp/code-dom/statements/if';
import { Return } from '#csharp/code-dom/statements/return';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';
import { Switch } from '#csharp/code-dom/statements/switch';
import { Ternery } from '#csharp/code-dom/ternery';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';

import { Schema } from '#csharp/lowlevel-generator/code-model';
import { ModelClass } from '#csharp/lowlevel-generator/model/model-class';
import { EnhancedTypeDeclaration } from '#csharp/schema/extended-type-declaration';
import { ObjectImplementation } from '#csharp/schema/object';
import { HeaderProperty, HeaderPropertyType } from '#remodeler/tweak-model';
import { State } from '../generator';
import { ModelInterface } from './interface';
import { ModelProperty } from './property';
import { ProxyProperty } from './proxy-property';
import { Property } from '#csharp/code-dom/property';
import { MediaType } from '#common/code-model/http-operation';
import { KnownMediaType } from '#common/media-types';
import { popTempVar, pushTempVar } from '#csharp/schema/primitive';

export class JsonSerializableClass extends Class {
  private btj!: Method;
  private atj!: Method;
  private bfj!: Method;
  private afj!: Method;

  constructor(protected modelClass: ModelClass, objectInitializer?: Partial<JsonSerializableClass>) {
    super(modelClass.namespace, modelClass.name);
    this.apply(objectInitializer);
    this.partial = true;

    this.addPartialMethods();

    // set up the declaration for the toJson method.
    const container = new Parameter('container', ClientRuntime.JsonObject);
    const mode = new Parameter('serializationMode', ClientRuntime.SerializationMode);

    const toJsonMethod = this.addMethod(new Method('ToJson', ClientRuntime.JsonNode, {
      parameters: [container, mode],
    }));

    // setup the declaration for the json deserializer constructor
    const jsonParameter = new Parameter('json', ClientRuntime.JsonObject);
    const deserializerConstructor = this.addMethod(new Constructor(this, { parameters: [jsonParameter], access: Access.Internal }));

    const serializeStatements = new Statements();
    const deserializeStatements = new Statements();


    for (const each of values(modelClass.backingFields)) {
      serializeStatements.add(`${each.field.value}?.ToJson(result, ${mode.use});`);
      deserializeStatements.add(`${each.field.value} = new ${each.className}(json);`);
    }

    pushTempVar();
    for (const { key: propertyName, value: property } of items(modelClass.schema.properties)) {
      const prop = modelClass.$<ModelProperty>(property.details.csharp.name);
      const serializeStatement = (<EnhancedTypeDeclaration>prop.type).serializeToContainerMember(KnownMediaType.Json, prop, container, prop.serializedName);

      if (property.details.csharp[HeaderProperty] === HeaderPropertyType.Header) {
        // it's a header only property. Don't serialize unless the mode has Microsoft.Rest.ClientRuntime.SerializationMode.IncludeHeaders enabled
        serializeStatements.add(If({ value: `${mode.use}.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeHeaders)` }, serializeStatement));
      } else {
        if (property.schema.readOnly) {
          serializeStatements.add(If({ value: `${mode.use}.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly)` }, serializeStatement));
        } else {
          serializeStatements.add(serializeStatement);
        }
      }
      deserializeStatements.add(prop.assignPrivate((<EnhancedTypeDeclaration>prop.type).deserializeFromContainerMember(KnownMediaType.Json, jsonParameter, prop.serializedName, prop)));
    }
    popTempVar();

    const $this = this;

    // generate the implementation for toJson
    toJsonMethod.add(function* () {
      yield `${container} = ${container} ?? new ${ClientRuntime.JsonObject.declaration}();`;
      yield EOL;

      yield `bool returnNow = false;`;
      yield `${$this.btj.name}(ref ${container}, ref returnNow);`;

      yield If({ value: `returnNow` }, `return ${container};`);

      // get serialization statements
      yield serializeStatements;

      yield `${$this.atj.name}(ref ${container});`;
      yield Return(container);
    });

    // and let's fill in the deserializer constructor statements now.
    deserializerConstructor.add(function* () {
      yield `bool returnNow = false;`;
      yield `${$this.bfj.name}(json, ref returnNow);`;
      yield If({ value: `returnNow` }, `return;`);

      yield deserializeStatements;
      yield `${$this.afj.name}(json);`;
    });
  }

  public get definition(): string {
    const $this = this.modelClass;
    // gotta write this just before we write out the class, since we had to wait until everyone had reported to their parents.
    const d = this.modelClass.discriminators;
    const isp = this.modelClass.isPolymorphic;
    // create the FromJson method
    const node = new Parameter('node', ClientRuntime.JsonNode);
    const fromJson = this.addMethod(new Method('FromJson', this.modelClass.modelInterface, { parameters: [node], static: Modifier.Static }));
    fromJson.add(function* () {

      const json = IsDeclaration(node, ClientRuntime.JsonObject, 'json');

      if (isp) {
        yield If(Not(json.check), Return(dotnet.Null));
        yield '// Polymorphic type -- select the appropriate constructor using the discriminator';
        /** go thru the list of polymorphic values for the discriminator, and call the target class's constructor for that */

        if ($this.schema.discriminator) {
          yield Switch({ value: `json.StringProperty("${$this.schema.discriminator.propertyName}")` }, function* () {
            for (const { key, value } of items(d)) {
              yield TerminalCase(`"${key}"`, function* () {
                yield Return(value.newInstance(json));
              });
            }
          });
        }
        yield Return($this.newInstance(json));
      } else {
        // just tell it to create the instance (providing that it's a JSonObject)
        yield Return(Ternery(json.check, $this.newInstance(json), dotnet.Null));
      }
    });

    return super.definition;
  }


  public get fileName(): string {
    return `${super.fileName}.json`;
  }

  protected addPartialMethods() {
    // add partial methods for future customization
    this.btj = this.addMethod(new PartialMethod('BeforeToJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('container', ClientRuntime.JsonObject, { modifier: ParameterModifier.Ref, description: 'The JSON container that the serialization result will be placed in.' }),
        new Parameter('returnNow', dotnet.Bool, { modifier: ParameterModifier.Ref, description: 'Determines if the rest of the serialization should be processed, or if the method should return instantly.' }),
      ],
    }));

    this.atj = this.addMethod(new PartialMethod('AfterToJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('container', ClientRuntime.JsonObject, { modifier: ParameterModifier.Ref, description: 'The JSON container that the serialization result will be placed in.' }),
      ],
    }));

    this.bfj = this.addMethod(new PartialMethod('BeforeFromJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('json', ClientRuntime.JsonObject, { description: 'The JsonNode that should be deserialized into this object.' }),
        new Parameter('returnNow', dotnet.Bool, { modifier: ParameterModifier.Ref, description: 'Determines if the rest of the deserialization should be processed, or if the method should return instantly.' }),
      ],
    }));

    this.afj = this.addMethod(new PartialMethod('AfterFromJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('json', ClientRuntime.JsonObject, { description: 'The JsonNode that should be deserialized into this object.' }),
      ],
    }));
  }

}
