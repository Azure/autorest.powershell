import { Modifier } from "#csharp/code-dom/access-modifier";
import { Class } from "#csharp/code-dom/class";
import { Method } from "#csharp/code-dom/method";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import { Namespace } from "#csharp/code-dom/namespace";
import { Parameter } from "#csharp/code-dom/parameter";
import { JsonNode, JsonObject } from "#csharp/lowlevel-generator/clientruntime";
import { State } from "#csharp/lowlevel-generator/generator";

export class JsonSerializerClass extends Class {

  constructor(namespace: Namespace, protected state: State, objectInitializer?: Partial<JsonSerializerClass>) {
    super(namespace, "JsonSerialization");
    this.apply(objectInitializer);

    this.partial = true;
    this.isStatic = true;

    const tojson = this.addMethod(new Method("ToJson", JsonNode, { static: Modifier.Static }));
    const objP = tojson.addParameter(new Parameter("obj", mscorlib.ThisObject));
    const container = tojson.addParameter(new Parameter("container", JsonObject, { defaultInitializer: `= null` }));
    tojson.add(`return null;`);

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
        const btj = clss.addMethod(new PartialMethod("BeforeToJson", mscorlib.Void, {
          access: Access.Default,
          parameters: [
            new Parameter("container", JsonObject, { modifier: ParameterModifier.Ref, description: "The JSON container that the serialization result will be placed in." }),
            new Parameter("returnNow", mscorlib.Bool, { modifier: ParameterModifier.Ref, description: "Determines if the rest of the serialization should be processed, or if the method should return instantly." }),
          ]
        }));

        const atj = clss.addMethod(new PartialMethod("AfterToJson", mscorlib.Void, {
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
