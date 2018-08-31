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
  }
}
