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

export class ModelClass extends Class {

  constructor(namespace: Namespace, schema: Schema, state: State, objectInitializer?: Partial<ModelClass>) {
    super(namespace, schema.details.name);
    this.apply(objectInitializer);

    // mark the code-model with the class we're creating.
    schema.details.privateData["class-implementation"] = this;

    // track the namespace we've used.
    schema.details.namespace = namespace.fullName;

    // create an interface for this model class
    const modelInterface = schema.details.privateData["interface-implementation"] || new ModelInterface(namespace, schema, state);
    this.interfaces.push(modelInterface);

    // handle <allOf>s 
    // add an 'implements' for the interface for the allOf.
    for (let allOf = 0; allOf < schema.allOf.length; allOf++) {
      const aSchema = schema.allOf[allOf];
      const aState = state.path("allOf");

      const td = state.project.modelsNamespace.resolveTypeDeclaration(aSchema, aState);

      // add the interface as a parent to our interface.
      const iface: ModelInterface = aSchema.details.privateData["interface-implementation"];

      modelInterface.interfaces.push(iface);

      // add a field for the inherited values
      const backingField = this.addField(new Field(`_allof_${allOf}`, td, { visibility: AccessModifier.Private }));

      // now, create proxy properties for the members
      iface.allProperties.map(each => this.addProperty(new ProxyProperty(backingField, each, state)));
    }
    // generate a protected backing field for each
    // and then expand the nested properties into this class forwarding to the member.


    // add properties
    for (const propertyName in schema.properties) {
      const property = schema.properties[propertyName];

      this.addProperty(new ModelProperty(this, property, state.path('properties', propertyName)));
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


  }
}