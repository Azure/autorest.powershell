/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { Schema as NewSchema, ObjectSchema, SchemaType } from '@autorest/codemodel';
import { KnownMediaType, HeaderProperty, HeaderPropertyType, getAllProperties } from '@azure-tools/codemodel-v3';
import { getAllProperties as newGetAllProperties } from '@autorest/codemodel';
import { EOL, DeepPartial, } from '@azure-tools/codegen';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { Access, Modifier, StringExpression, Expression, System, LiteralExpression } from '@azure-tools/codegen-csharp';
import { Class } from '@azure-tools/codegen-csharp';
import { Constructor } from '@azure-tools/codegen-csharp';
import { IsDeclaration, toExpression } from '@azure-tools/codegen-csharp';
import { Method, PartialMethod } from '@azure-tools/codegen-csharp';

import { Parameter } from '@azure-tools/codegen-csharp';
import { ParameterModifier } from '@azure-tools/codegen-csharp';
import { TerminalCase } from '@azure-tools/codegen-csharp';
import { If, Not } from '@azure-tools/codegen-csharp';
import { Return } from '@azure-tools/codegen-csharp';
import { Statements } from '@azure-tools/codegen-csharp';
import { Switch } from '@azure-tools/codegen-csharp';
import { Ternery } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';

import { dotnet } from '@azure-tools/codegen-csharp';
import { ModelClass } from './model-class';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { popTempVar, pushTempVar } from '../schema/primitive';

import { ObjectImplementation } from '../schema/object';
import { ModelInterface } from './interface';


export class JsonSerializableClass extends Class {
  private btj!: Method;
  private atj!: Method;
  private bfj!: Method;
  private afj!: Method;
  private excludes: string;

  constructor(protected modelClass: ModelClass, objectInitializer?: DeepPartial<JsonSerializableClass>) {
    super(modelClass.namespace, modelClass.name);
    this.apply(objectInitializer);
    this.partial = true;
    this.description = modelClass.description;
    this.addPartialMethods();

    // set up the declaration for the toJson method.
    const container = new Parameter('container', ClientRuntime.JsonObject, { description: `The <see cref="${ClientRuntime.JsonObject}"/> container to serialize this object into. If the caller passes in <c>null</c>, a new instance will be created and returned to the caller.` });
    const mode = new Parameter('serializationMode', ClientRuntime.SerializationMode, { description: `Allows the caller to choose the depth of the serialization. See <see cref="${ClientRuntime.SerializationMode}"/>.` });

    const toJsonMethod = this.addMethod(new Method('ToJson', ClientRuntime.JsonNode, {
      parameters: [container, mode],
      description: `Serializes this instance of <see cref="${this.name}" /> into a <see cref="${ClientRuntime.JsonNode}" />.`,
      returnsDescription: `a serialized instance of <see cref="${this.name}" /> as a <see cref="${ClientRuntime.JsonNode}" />.`
    }));

    // setup the declaration for the json deserializer constructor
    const jsonParameter = new Parameter('json', ClientRuntime.JsonObject, { description: `A ${ClientRuntime.JsonObject} instance to deserialize from.` });
    const deserializerConstructor = this.addMethod(new Constructor(this, {
      parameters: [jsonParameter], access: Access.Internal,
      description: `Deserializes a ${ClientRuntime.JsonObject} into a new instance of <see cref="${this.name}" />.`
    }));


    const serializeStatements = new Statements();
    const deserializeStatements = new Statements();
    this.excludes = '';

    if (this.modelClass.dictionaryImpl) {
      const vType = this.modelClass.dictionaryImpl.valueType;
      // we have to ensure that all the known wire-names are excluded on deserialization.
      const exclusions = new Parameter('exclusions', System.Collections.Generic.HashSet(dotnet.String), { defaultInitializer: dotnet.Null });
      deserializerConstructor.parameters.push(exclusions);

      this.excludes = [...values(newGetAllProperties(<ObjectSchema>this.modelClass.schema)).select(each => each.serializedName).select(each => new StringExpression(each))].join();
      this.excludes = this.excludes ? `,${System.Collections.Generic.HashSet(dotnet.String).new()}{ ${this.excludes} }` : '';

      const ap = `((${ClientRuntime}.IAssociativeArray<${vType.declaration}>)this).AdditionalProperties`;

      if (this.modelClass.dictionaryImpl.ownsDictionary) {
        // we have to implement the deserializer for it.

        serializeStatements.push(new Statements(`${ClientRuntime.JsonSerializable}.ToJson( ${ap}, ${container});`));

        if (vType === System.Object) {
          // wildcard style
          deserializeStatements.push(new Statements(`${ClientRuntime.JsonSerializable}.FromJson( json, ${ap}, ${ClientRuntime.JsonSerializable}.DeserializeDictionary(()=>${System.Collections.Generic.Dictionary(System.String, System.Object).new()}),${exclusions.value} );`));

        } else if (vType instanceof ModelInterface) {
          // use the class of the dictionary value to deserialize values
          deserializeStatements.push(new Statements(`${ClientRuntime.JsonSerializable}.FromJson( json, ${ap}, (j) => ${vType.classImplementation.fullName}.FromJson(j) ,${exclusions.value} );`));
        } else {
          deserializeStatements.push(new Statements(`${ClientRuntime.JsonSerializable}.FromJson( json, ${ap}, null ,${exclusions.value} );`));
        }
      }
    }


    for (const each of values(modelClass.backingFields)) {
      serializeStatements.add(`${each.field.value}?.ToJson(${container}, ${mode.use});`);
      const sch = (<EnhancedTypeDeclaration>each.typeDeclaration).schema;
      const dictSchema = sch.type === SchemaType.Dictionary ? sch :
        sch.type === SchemaType.Object ? (<ObjectSchema>sch).parents?.immediate.find((s) => s.type === SchemaType.Dictionary) :
          undefined;
      if (dictSchema) {
        deserializeStatements.add(`${each.field.value} = new ${each.className}(json${this.excludes});`);
      } else {
        deserializeStatements.add(`${each.field.value} = new ${each.className}(json);`);
      }
    }

    pushTempVar();
    for (const prop of values(modelClass.ownedProperties)) {
      if (prop.language.csharp.HeaderProperty === 'Header') {
        continue;
      }
      const serializeStatement = (<EnhancedTypeDeclaration>prop.type).serializeToContainerMember(KnownMediaType.Json, prop.valuePrivate, container, prop.serializedName, mode);

      if (!prop.language.csharp.read && !prop.language.csharp.create && !prop.language.csharp.update) {
        continue;
      } else if (!(prop.language.csharp.read && prop.language.csharp.create && prop.language.csharp.update)) {
        const accessControlArray = new Array<string>();
        if (prop.language.csharp.read) {
          accessControlArray.push(ClientRuntime.SerializationMode.IncludeRead.toString());
        }
        if (prop.language.csharp.update) {
          accessControlArray.push(ClientRuntime.SerializationMode.IncludeUpdate.toString());
        }
        if (prop.language.csharp.create) {
          accessControlArray.push(ClientRuntime.SerializationMode.IncludeCreate.toString());
        }
        if (accessControlArray.length > 0) {
          for (let i = 0; i < accessControlArray.length; i++) {
            accessControlArray[i] = `${mode.use}.HasFlag(${accessControlArray[i]})`;
          }
          const accessControl = accessControlArray.join('||');
          serializeStatements.add(If(accessControl, serializeStatement));
        }
      } else {
        serializeStatements.add(serializeStatement);
      }

      if (prop.language.csharp.read) {
        deserializeStatements.add(prop.assignPrivate((<EnhancedTypeDeclaration>prop.type).deserializeFromContainerMember(KnownMediaType.Json, jsonParameter, prop.serializedName, new LiteralExpression(prop.backingName))));
      }
    }
    popTempVar();

    const $this = this;

    // generate the implementation for toJson
    toJsonMethod.add(function* () {
      yield `${container} = ${container} ?? new ${ClientRuntime.JsonObject.declaration}();`;
      yield EOL;

      yield 'bool returnNow = false;';
      yield `${$this.btj.name}(ref ${container}, ref returnNow);`;

      yield If(toExpression('returnNow'), `return ${container};`);

      // get serialization statements
      yield serializeStatements;

      yield `${$this.atj.name}(ref ${container});`;
      yield Return(container);
    });

    // and let's fill in the deserializer constructor statements now.
    deserializerConstructor.add(function* () {
      yield 'bool returnNow = false;';
      yield `${$this.bfj.name}(json, ref returnNow);`;
      yield If(toExpression('returnNow'), 'return;');

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
    const node = new Parameter('node', ClientRuntime.JsonNode, { description: `a <see cref="${ClientRuntime.JsonNode}" /> to deserialize from.` });
    const fromJson = this.addMethod(new Method('FromJson', this.modelClass.modelInterface, {
      parameters: [node], static: Modifier.Static,
      description: `Deserializes a <see cref="${ClientRuntime.JsonNode}"/> into an instance of ${this.modelClass.modelInterface}.`,
      returnsDescription: `an instance of ${this.modelClass.modelInterface}.`
    }));

    if (isp) {
      fromJson.description = fromJson.description + `\n Note: the ${this.modelClass.modelInterface} interface is polymorphic, and the precise model class that will get deserialized is determined at runtime based on the payload.`;
    }
    const $excludes = this.excludes;
    fromJson.add(function* () {

      const json = IsDeclaration(node, ClientRuntime.JsonObject, 'json');

      if (isp) {
        yield If(Not(json.check), Return(dotnet.Null));
        yield '// Polymorphic type -- select the appropriate constructor using the discriminator';
        /** go thru the list of polymorphic values for the discriminator, and call the target class's constructor for that */
        if ($this.schema.discriminator) {
          yield Switch(toExpression(`json.StringProperty("${$this.schema.discriminator.property.serializedName}")`), function* () {
            for (const { key, value } of items(d)) {
              yield TerminalCase(`"${key}"`, function* () {
                yield Return(value.new(json));
              });
            }
          });
        }
        yield Return($this.new(json, toExpression($excludes.substring(1))));
      } else {
        // just tell it to create the instance (providing that it's a JSonObject)
        yield Return(Ternery(json.check, $this.new(json, toExpression($excludes.substring(1))), dotnet.Null));
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
      description: `<c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the object before it is serialized.
      If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output parameter.
      Implement this method in a partial class to enable this behavior.`
    }));

    this.atj = this.addMethod(new PartialMethod('AfterToJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('container', ClientRuntime.JsonObject, { modifier: ParameterModifier.Ref, description: 'The JSON container that the serialization result will be placed in.' }),
      ],
      description: `<c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="${ClientRuntime.JsonObject}" /> before it is returned. Implement this method in a partial class to enable this behavior `
    }));

    this.bfj = this.addMethod(new PartialMethod('BeforeFromJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('json', ClientRuntime.JsonObject, { description: 'The JsonNode that should be deserialized into this object.' }),
        new Parameter('returnNow', dotnet.Bool, { modifier: ParameterModifier.Ref, description: 'Determines if the rest of the deserialization should be processed, or if the method should return instantly.' }),
      ],
      description: `<c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of the object before it is deserialized.
      If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" /> output parameter.
      Implement this method in a partial class to enable this behavior.`
    }));

    this.afj = this.addMethod(new PartialMethod('AfterFromJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('json', ClientRuntime.JsonObject, { description: 'The JsonNode that should be deserialized into this object.' }),
      ],
      description: '<c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object before it is returned. Implement this method in a partial class to enable this behavior '
    }));
  }
}