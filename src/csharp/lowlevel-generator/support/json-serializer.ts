import { Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Method } from '#csharp/code-dom/method';

import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { State } from '#csharp/lowlevel-generator/generator';
import { items } from '#common/dictionary';
import { dotnet } from '#csharp/code-dom/dotnet';

export class JsonSerializerClass extends Class {

  constructor(namespace: Namespace, protected state: State, objectInitializer?: Partial<JsonSerializerClass>) {
    super(namespace, "JsonSerialization");
    this.apply(objectInitializer);

    this.partial = true;
    this.isStatic = true;

    const tojson = this.addMethod(new Method("ToJson", ClientRuntime.JsonNode, { static: Modifier.Static }));
    const objP = tojson.addParameter(new Parameter("obj", dotnet.ThisObject));
    const container = tojson.addParameter(new Parameter("container", ClientRuntime.JsonObject, { defaultInitializer: `= null` }));
    tojson.add(`return null;`);

    const schemas = state.model.schemas;

    // iterate thru all the models
    // each model should have a class and an interface.
    // if the class has a discriminator value, tell the parent model that it has children
    for (const { key: schemaName, value: schema } of items(schemas)) {
      const state = this.state.path("components", "schemas", schemaName);
      if (schema.details.csharp && schema.details.csharp.classImplementation) {
        // must be a class.
        // const implData: CSharpSchemaDetails = schema.details.csharp;
      }


      schema.details
      const x = state.project.modelsNamespace.resolveTypeDeclaration(schema, true, state);
    }

    // when we generate DeserializeTo[..](JsonObject json) we should check if we have any children
    // if there are, generate (switch statement) code that matches the discriminator value to the appropriate deserialize function
    // there probably should be a default that if there wasn't a match, fall back to deserializing for this model class.

    // emit the deserialization for a given class


    /*
    // add the json serialize method to each model class
    for (const each in state.model.components.schemas) {
      const schema = state.model.components.schemas[each];

      if (schema.details.privateData.classImplementation) {
        const clss: ModelClass = schema.details.privateData.classImplementation;
        const iface: Interface = schema.details.privateData.interfaceImplementation;

        // make sure the model class is partial.
        clss.partial = true;

        // add partial methods for future customization
        const btj = clss.addMethod(new PartialMethod("BeforeToJson", IL.Void, {
          access: Access.Default,
          parameters: [
            new Parameter("container", JsonObject, { modifier: ParameterModifier.Ref, description: "The JSON container that the serialization result will be placed in." }),
            new Parameter("returnNow", IL.Bool, { modifier: ParameterModifier.Ref, description: "Determines if the rest of the serialization should be processed, or if the method should return instantly." }),
          ]
        }));

        const atj = clss.addMethod(new PartialMethod("AfterToJson", IL.Void, {
          access: Access.Default,
          parameters: [
            new Parameter("container", JsonObject, { modifier: ParameterModifier.Ref, description: "The JSON container that the serialization result will be placed in." }),
          ]
        }))

        const toJsonMethod = clss.addMethod(new Method(tojson.name, JsonNode, ));
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
          yield clss.serializeStatements;


          yield `${atj.name}(ref result);`;
          yield `return result;`;
        });

      }
    }
    */

    // create internal method to find deserializer method
    // ie GetJsonDeserializerFor_INTERFACENAME(JsonNode json)

    // create method to deserialize JsonNode to the target type.
    // ie Deserialize_INTERFACENAME(JsonNode json)

    // add master 'toJson' method

    // add internal method to schema class for bool CanDeserialize(JsonNode json)

    // add internal method to schema class for static IFOO FromJson(JsonNode json)
    // remember two partial methods:
    // static partial void BeforeFromJson(JsonObject json, ref IOtherResource result);
    // static partial void AfterFromJson(JsonObject json, ref IOtherResource result);

    // add internal method to schema class for ToJson(JsonObject container = null)
    // remember two partial methods:
    // partial void BeforeToJson(ref JsonObject container, ref bool returnNow);
    // partial void AfterToJson(ref JsonObject container);

  }
}
