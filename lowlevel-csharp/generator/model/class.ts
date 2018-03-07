import * as codemodel from "#remodeler/code-model";
import * as mscorlib from "../../code-dom/mscorlib";
import * as message from "../messages";
import { Class } from "../../code-dom/class";
import { ModelProperty } from "./property";
import { ModelInterface } from "./interface"

import { State } from "../generator";
import { Schema } from "#remodeler/code-model";
import { Namespace } from "../../code-dom/namespace";
import { Interface } from "../../code-dom/interface";
import { BackingField } from "./backing-field";
import { ProxyProperty } from "./proxy-property";

export class ModelClass extends Class {

  protected constructor(name: string, state: State) {
    super(name);
  }

  public static async create(parent: Namespace, schema: Schema, state: State): Promise<ModelClass> {
    if (schema.details.privateData["class-implementation"]) {
      // if we've already created this type, return the implementation of it.
      return schema.details.privateData["class-implementation"];
    }
    const modelClass = new ModelClass(schema.details.name, state);

    // mark the code-model with the class we're creating.
    schema.details.privateData["class-implementation"] = modelClass;

    // track the namespace we've used.
    schema.details.namespace = parent.fullName;

    // add this to parent namespace
    parent.addClass(modelClass);

    // create an interface for this model class
    const modelInterface = await ModelInterface.create(parent, schema, state);
    modelClass.interfaces.push(modelInterface);

    // handle <allOf>s 
    // add an 'implements' for the interface for the allOf.
    for (const allOf in schema.allOf) {
      const aSchema = schema.allOf[allOf];
      const aState = state.path("allOf");

      const td = await state.project.modelsNamespace.resolveTypeDeclaration(aSchema, aState);

      // add the interface as a parent to our interface.
      const iface: ModelInterface = aSchema.details.privateData["interface-implementation"];

      modelInterface.interfaces.push(iface);

      // add a field for the inherited values
      const backingField = await BackingField.create(modelClass, `_${td.use.toLowerCase()}`, td, aState);

      // now, create proxy properties for the members
      for (const each of iface.properties) {
        await ProxyProperty.create(modelClass, backingField, each, state);
      }
    }
    // generate a protected backing field for each
    // and then expand the nested properties into this class forwarding to the member.


    // add properties
    for (const each in schema.properties) {
      const property = schema.properties[each];

      ModelProperty.create(modelClass, property, state.path('properties', each));
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


    // add constructors 

    // add serialization 


    return modelClass;
  }
}