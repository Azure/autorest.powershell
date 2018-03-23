import * as codemodel from "#remodeler/code-model";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import * as message from "../messages";
import { Class } from "#csharp/code-dom/class";
import { ModelProperty } from "./property";
import { ModelInterface } from "./interface"

import { State } from "../generator";
import { Schema } from "#remodeler/code-model";
import { Namespace } from "#csharp/code-dom/namespace";
import { Interface } from "#csharp/code-dom/interface";
import { ProxyProperty } from "./proxy-property";
import { Field } from "#csharp/code-dom/field";
import { AccessModifier } from "#csharp/code-dom/access-modifier";
import { IJsonSerializable, EventListener, IValidates } from "#csharp/lowlevel-generator/clientruntime";
import { Statements, OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { PrivateData } from "#csharp/lowlevel-generator/private-data";
import { EOL } from "#common/text-manipulation";
import { Method } from "#csharp/code-dom/method";
import { Parameter } from "#csharp/code-dom/parameter";

export class ModelClass extends Class {

  public serializeStatements = new Statements();
  private validateMethod?: Method;

  constructor(namespace: Namespace, schema: Schema, state: State, objectInitializer?: Partial<ModelClass>) {
    super(namespace, schema.details.name);
    this.apply(objectInitializer);

    const privateData: PrivateData = schema.details.privateData;

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

      // add the interface as a parent to our interface.
      const iface: ModelInterface = aSchema.details.privateData.interfaceImplementation;

      modelInterface.interfaces.push(iface);

      // add a field for the inherited values
      const backingField = this.addField(new Field(`_allof_${allOf}`, td, { visibility: AccessModifier.Private }));

      // now, create proxy properties for the members
      iface.allProperties.map(each => this.addProperty(new ProxyProperty(backingField, each, state)));

      this.serializeStatements.add(`${backingField.value}?.ToJson(result);`)
    }
    // generate a protected backing field for each
    // and then expand the nested properties into this class forwarding to the member.


    // add properties
    for (const propertyName in schema.properties) {
      const property = schema.properties[propertyName];

      const prop = this.addProperty(new ModelProperty(this, property, state.path('properties', propertyName)));

      this.serializeStatements.add(`result.Add("${propertyName}",${prop.name}.ToJson());`);
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
    const statements = new Statements();
    this.properties.map(each => statements.add((<ModelProperty>each).validatePresenceStatement));
    this.properties.map(each => statements.add((<ModelProperty>each).validationStatement));

    // const propVal = this.properties.joinWith(each => (<ModelProperty>each).validationStatement, EOL);
    // const propValPresence = this.properties.joinWith(each => (<ModelProperty>each).validatePresenceStatement, EOL);

    if (statements.count > 0) {
      // we do have something to valdiate!

      // add the IValidates implementation to this object.
      this.interfaces.push(IValidates);
      this.validateMethod = this.addMethod(new Method("Validate", mscorlib.Task, {
        parameters: [new Parameter("listener", EventListener)],
        isAsync: true,
      }));
      this.validateMethod.add(statements);
    }

  }

  validatePresence(propertyName: string): OneOrMoreStatements {
    return `await listener.AssertNotNull(nameof(${propertyName}),${propertyName});`.trim();
  }

  validateValue(propertyName: string): OneOrMoreStatements {
    //if (this.validateMethod) {
    //return `${propertyName}.Validate(listener);`
    //}
    // return `(${propertyName} as Microsoft.Rest.ClientRuntime.IValidates)?.Validate(listener);`;
    return `await listener.AssertObjectIsValid(nameof(${propertyName}), ${propertyName});`;
  }
  jsonserialize(propertyName: string): OneOrMoreStatements {
    return `/* serialize json object  here */`;
  }
  jsondeserialize(propertyName: string): OneOrMoreStatements {
    return `/* deserialize json object here */`;
  }
}