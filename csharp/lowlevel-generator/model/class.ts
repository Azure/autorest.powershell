import { EOL, camelCase, deconstruct, fixPropertyName, pascalCase, fixLeadingNumber, indent } from "#common/text-manipulation";
import { Access, Modifier } from "#csharp/code-dom/access-modifier";
import { Class } from "#csharp/code-dom/class";
import { InitializedField } from "#csharp/code-dom/field";
import { Method, PartialMethod } from "#csharp/code-dom/method";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import { Namespace } from "#csharp/code-dom/namespace";
import { Parameter } from "#csharp/code-dom/parameter";
import { ParameterModifier } from "#csharp/code-dom/parameter-modifier";
import { OneOrMoreStatements, Statements } from "#csharp/code-dom/statements/statement";
import { EventListener, IJsonSerializable, IValidates, JsonNode, JsonObject } from "#csharp/lowlevel-generator/clientruntime";
import { CSharpData } from "#csharp/lowlevel-generator/private-data";
import { Schema } from "#remodeler/code-model";
import { State } from "../generator";
import { ModelInterface } from "./interface";
import { ModelProperty } from "./property";
import { ProxyProperty } from "./proxy-property";
import { Constructor } from "#csharp/code-dom/constructor";
import { Switch } from "#csharp/code-dom/statements/switch";
import { Case, TerminalCase } from "#csharp/code-dom/statements/case";
import { If } from "#csharp/code-dom/statements/if";

export class ModelClass extends Class {

  //  public serializeStatements = new Statements();
  private validateMethod?: Method;
  public isPolymorphic: boolean;
  private discriminators: Map<string, ModelClass>;
  private parentModelClasses: Array<ModelClass>;
  private modelInterface: ModelInterface;
  private schema: Schema;

  constructor(namespace: Namespace, schema: Schema, state: State, objectInitializer?: Partial<ModelClass>) {
    const implData: CSharpData = (schema.details.csharp = schema.details.csharp || {});
    super(namespace, schema.details.name);
    this.isPolymorphic = false;
    this.discriminators = new Map<string, ModelClass>();
    this.parentModelClasses = new Array<ModelClass>();
    this.schema = schema;

    this.apply(objectInitializer);
    this.partial = true;

    if (schema.discriminator) {
      // this has a discriminator property.
      // our children are expected to tell us who they are 
      this.isPolymorphic = true;
      // we'll add a deserializer factory method a bit later..
    }

    if (schema.extensions["x-ms-discriminator-value"]) {
      // we have a discriminator value, and we should tell our parent who we are so that they can build a proper deserializer method.
      // um. just how do we *really* know which allOf is polymorphic? 
      // that's really sad.
      for (let allOf = 0; allOf < schema.allOf.length; allOf++) {
        const parentSchema = schema.allOf[allOf];
        const aState = state.path("allOf", allOf);
        const parentDecl = state.project.modelsNamespace.resolveTypeDeclaration(parentSchema, true, aState);

        const parentClass = parentSchema.details.csharp.classImplementation;
        if (parentClass.isPolymorphic) {
          // remember this class for later. 
          this.parentModelClasses.push(parentClass);

          // tell that parent who we are.
          parentClass.addDiscriminator(schema.extensions["x-ms-discriminator-value"], this);
        }
      }
    }

    const defaultConstructor = this.addMethod(new Constructor(this)); // default constructor for fits and giggles.

    const serializeStatements = new Statements();
    const deserializeStatements = new Statements();

    const validationStatements = new Statements();

    // mark the code-model with the class we're creating.
    implData.classImplementation = this;

    // track the namespace we've used.
    schema.details.namespace = namespace.fullName;



    // create an interface for this model class
    const modelInterface = implData.interfaceImplementation || new ModelInterface(namespace, schema, this, state);
    this.interfaces.push(modelInterface);
    this.modelInterface = modelInterface;

    // handle <allOf>s
    // add an 'implements' for the interface for the allOf.
    for (let allOf = 0; allOf < schema.allOf.length; allOf++) {
      // gs01: Critical -- pull thru parent allOf's!
      const aSchema = schema.allOf[allOf];
      const aState = state.path("allOf");

      const td = state.project.modelsNamespace.resolveTypeDeclaration(aSchema, true, aState);
      const className = aSchema.details.csharp.classImplementation.fullName;
      const fieldName = camelCase(deconstruct(className.replace(/^.*\./, '')));

      // add the interface as a parent to our interface.
      const iface: ModelInterface = aSchema.details.csharp.interfaceImplementation;

      modelInterface.interfaces.push(iface);

      // add a field for the inherited values
      const backingField = this.addField(new InitializedField(`_${fieldName}`, td, { value: `new ${className}()` }, { access: Access.Private }));

      // now, create proxy properties for the members
      iface.allProperties.map(each => this.addProperty(new ProxyProperty(backingField, each, state)));

      serializeStatements.add(`${backingField.value}?.ToJson(result);`);

      deserializeStatements.add(`${backingField.value} = new ${className}(json);`);


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

      deserializeStatements.add(prop.jsonDeserializationStatement);
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

    const bfj = this.addMethod(new PartialMethod("BeforeFromJson", mscorlib.Void, {
      access: Access.Default,
      parameters: [
        new Parameter("json", JsonObject, { description: "The JsonNode that should be deserialized into this object." }),
        new Parameter("returnNow", mscorlib.Bool, { modifier: ParameterModifier.Ref, description: "Determines if the rest of the deserialization should be processed, or if the method should return instantly." }),
      ]
    }));

    const afj = this.addMethod(new PartialMethod("AfterFromJson", mscorlib.Void, {
      access: Access.Default,
      parameters: [
        new Parameter("json", JsonObject, { description: "The JsonNode that should be deserialized into this object." }),
      ]
    }));


    const toJsonMethod = this.addMethod(new Method("ToJson", JsonNode));
    const container = toJsonMethod.addParameter(new Parameter("container", JsonObject));
    toJsonMethod.add(function* () {
      yield `var result = container ?? new ${JsonObject.use}();`
      yield EOL;

      yield `bool returnNow = false;`;
      yield `${btj.name}(ref result, ref returnNow);`;

      yield new If({ value: `returnNow` }, `return result;`);

      // get serialization statements
      yield serializeStatements;

      yield `${atj.name}(ref result);`;
      yield `return result;`;
    });


    if (this.isPolymorphic) {
      // ok, let's build the polymorphic deserializer method now.

    }

    // and let's fill in the deserializer constructor statements now.
    const deserializerConstructor = this.addMethod(new Constructor(this, { parameters: [new Parameter("json", JsonObject)], access: Access.Internal })); // deserialization constructor
    deserializerConstructor.add(function* () {
      yield `bool returnNow = false;`;
      yield `${bfj.name}(json, ref returnNow);`;
      yield new If({ value: `returnNow` }, `return;`);

      yield deserializeStatements;
      yield `${afj.name}(json);`;
    });
  }

  public get implementation(): string {
    // gotta write this just before we write out the class, since we had to wait until everyone had reported to their parents.
    const d = this.discriminators;
    const isp = this.isPolymorphic;
    // create the FromJson method 
    const fromJson = this.addMethod(new Method("FromJson", this.modelInterface, { parameters: [new Parameter("node", JsonNode)], static: Modifier.Static, }));
    fromJson.add(function* () {
      yield new If({ value: `!(node is ${JsonObject.use} json )` }, `return null;`);
      if (isp) {
        yield "// Polymorphic type -- select the appropriate constructor using the discriminator";
        /** go thru the list of polymorphic values for the discriminator, and call the target class's constructor for that */

        yield new Switch({ value: `json.StringProperty("${this.schema.discriminator.propertyName}")` }, function* () {
          for (const v of d) {
            yield new TerminalCase(`"${v[0]}"`, function* () {
              yield `return new ${v[1].use}(json);`
            });
          }
        })
      }
      yield `return new ${this.use}(json);`
    }.bind(this));

    return super.implementation;
  }

  validatePresence(propertyName: string): OneOrMoreStatements {
    return `await listener.AssertNotNull(${fixPropertyName(propertyName)}, ${propertyName}); `.trim();
  }
  validateValue(propertyName: string): OneOrMoreStatements {
    return `await listener.AssertObjectIsValid(${fixPropertyName(propertyName)}, ${propertyName}); `;
  }
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    // we're always going to go thru FromJson; it'll handle nulls and polymorphism.
    return `${propertyName} = ${this.use}.FromJson(${containerName}.Property("${serializedName}"));`.trim();
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `${this.use}.FromJson(${nodeExpression})`
  }


  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `${instance}?.ToJson()`;
  }

  addDiscriminator(discriminatorValue: string, modelClass: ModelClass) {
    this.discriminators.set(discriminatorValue, modelClass);

    // tell any polymorphic parents incase we're doing subclass of a subclass.
    for (const each of this.parentModelClasses) {
      each.addDiscriminator(discriminatorValue, modelClass);
    }

  }
}