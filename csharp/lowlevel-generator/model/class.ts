import * as codemodel from "#remodeler/code-model";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import * as message from "../messages";
import { Class } from "#csharp/code-dom/class";
import { ModelProperty } from "./property";
import { ModelInterface } from "./interface";

import { State } from "../generator";
import { Schema } from "#remodeler/code-model";
import { Namespace } from "#csharp/code-dom/namespace";
import { Interface } from "#csharp/code-dom/interface";
import { ProxyProperty } from "./proxy-property";
import { Field, InitializedField } from "#csharp/code-dom/field";
import { Access, Modifier } from "#csharp/code-dom/access-modifier";
import { IJsonSerializable, EventListener, IValidates } from "#csharp/lowlevel-generator/clientruntime";
import { Statements, OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { PrivateData } from "#csharp/lowlevel-generator/private-data";
import { EOL, camelCase, deconstruct, fixPropertyName } from "#common/text-manipulation";
import { Method, PartialMethod } from "#csharp/code-dom/method";
import { Parameter } from "#csharp/code-dom/parameter";
import { JsonNode, JsonObject } from "#csharp/lowlevel-generator/clientruntime";
import { ParameterModifier } from "#csharp/code-dom/parameter-modifier";

export class ModelClass extends Class {

  //  public serializeStatements = new Statements();
  private validateMethod?: Method;

  constructor(namespace: Namespace, schema: Schema, state: State, objectInitializer?: Partial<ModelClass>) {
    super(namespace, schema.details.name);
    this.apply(objectInitializer);
    this.partial = true;
    const serializeStatements = new Statements();

    const privateData: PrivateData = schema.details.privateData;
    const validationStatements = new Statements();

    // mark the code-model with the class we're creating.
    privateData.classImplementation = this;

    // track the namespace we've used.
    schema.details.namespace = namespace.fullName;

    // mark it as json serializable
    this.interfaces.push(IJsonSerializable);

    // create an interface for this model class
    const modelInterface = privateData.interfaceImplementation || new ModelInterface(namespace, schema, this, state);
    this.interfaces.push(modelInterface);

    // handle <allOf>s 
    // add an 'implements' for the interface for the allOf.
    for (let allOf = 0; allOf < schema.allOf.length; allOf++) {
      const aSchema = schema.allOf[allOf];
      const aState = state.path("allOf");

      const td = state.project.modelsNamespace.resolveTypeDeclaration(aSchema, true, aState);
      const className = aSchema.details.privateData.classImplementation.fullName;
      const fieldName = camelCase(deconstruct(className.replace(/^.*\./, '')));

      // add the interface as a parent to our interface.
      const iface: ModelInterface = aSchema.details.privateData.interfaceImplementation;

      modelInterface.interfaces.push(iface);

      // add a field for the inherited values
      const backingField = this.addField(new InitializedField(`_${fieldName}`, td, { value: `new ${className}()` }, { access: Access.Private }));

      // now, create proxy properties for the members
      iface.allProperties.map(each => this.addProperty(new ProxyProperty(backingField, each, state)));

      serializeStatements.add(`${backingField.value}?.ToJson(result);`);

      validationStatements.add(td.validatePresence(backingField.name));
      validationStatements.add(td.validateValue(backingField.name));
    }
    // generate a protected backing field for each
    // and then expand the nested properties into this class forwarding to the member.


    // add properties
    for (const propertyName in schema.properties) {
      const property = schema.properties[propertyName];

      const prop = new ModelProperty(this, property, propertyName, state.path('properties', propertyName));
      this.addProperty(prop);

      // this.serializeStatements.add(`result.Add("${propertyName}",${prop.name}.ToJson());`);
      serializeStatements.add(prop.jsonSerializationStatement);
    }

    if (schema.additionalProperties) {
      if (schema.additionalProperties === true) {
        // we should generate an additionalProperties property that catches all extra properties as object
        const valueSchema = {};
      } else {
        // we should generate an additionalProperties property that catches all extra properties as the type specified by 
        const valueSchema = schema.additionalProperties;
      }
    }

    // add validation function

    this.properties.map(each => validationStatements.add((<ModelProperty>each).validatePresenceStatement));
    this.properties.map(each => validationStatements.add((<ModelProperty>each).validationStatement));

    if (validationStatements.count > 0) {
      // we do have something to valdiate!

      // add the IValidates implementation to this object.
      this.interfaces.push(IValidates);
      this.validateMethod = this.addMethod(new Method("Validate", mscorlib.Task, {
        parameters: [new Parameter("listener", EventListener)],
        async: Modifier.Async,
      }));
      this.validateMethod.add(validationStatements);
    }


    // add partial methods for future customization
    const btj = this.addMethod(new PartialMethod("BeforeToJson", mscorlib.Void, {
      access: Access.Default,
      parameters: [
        new Parameter("container", JsonObject, { modifier: ParameterModifier.Ref, description: "The JSON container that the serialization result will be placed in." }),
        new Parameter("returnNow", mscorlib.Bool, { modifier: ParameterModifier.Ref, description: "Determines if the rest of the serialization should be processed, or if the method should return instantly." }),
      ]
    }));

    const atj = this.addMethod(new PartialMethod("AfterToJson", mscorlib.Void, {
      access: Access.Default,
      parameters: [
        new Parameter("container", JsonObject, { modifier: ParameterModifier.Ref, description: "The JSON container that the serialization result will be placed in." }),
      ]
    }));

    const toJsonMethod = this.addMethod(new Method("ToJson", JsonNode));
    const container = toJsonMethod.addParameter(new Parameter("container", JsonObject));
    toJsonMethod.add(function* () {
      yield `var result = container ?? new ${JsonObject.use}();`
      yield EOL;

      yield `bool returnNow = false;`;
      yield `${btj.name}(ref result, ref returnNow);`;
      yield `
if( returnNow )
{
    return result;
}`.trim();

      // get serialization statements
      yield serializeStatements;

      yield `${atj.name}(ref result);`;
      yield `return result;`;
    });
  }

  validatePresence(propertyName: string): OneOrMoreStatements {
    return `await listener.AssertNotNull(${fixPropertyName(propertyName)}, ${propertyName}); `.trim();
  }
  validateValue(propertyName: string): OneOrMoreStatements {
    return `await listener.AssertObjectIsValid(${fixPropertyName(propertyName)}, ${propertyName}); `;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): OneOrMoreStatements {
    return `/* deserialize json object here */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `${instance}?.ToJson()`;
  }
}