import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { deserialize, serialize } from "#common/yaml";
import { ModelState } from "#common/model-state";
import { Model } from "remodeler/code-model";
import { deconstruct, fixLeadingNumber, pascalCase, camelCase } from "#common/text-manipulation";

export async function process(service: Host) {
  try {
    // Get the list of files 
    const files = await service.ListInputs();

    // get the openapi document
    if (files.length != 1) {
      throw new Error("Inputs missing.");
    }

    const original = await service.ReadFile(files[0]);

    // deserialize
    const codeModel = await deserialize<Model>(await service.ReadFile(files[0]), files[0]);

    for (const each in codeModel.components.operations) {
      const op = codeModel.components.operations[each];
      const details = op.details;

      // operations have pascal cased names
      details.name = pascalCase(fixLeadingNumber(deconstruct(details.name)));

      // parameters are camelCased.
      for (const p of op.parameters) {
        p.details.name = camelCase(fixLeadingNumber(deconstruct(p.details.name)));
      }
    }

    for (const schemaName in codeModel.components.schemas) {
      const schema = codeModel.components.schemas[schemaName];
      // schema names are pascalCased
      schema.details.name = pascalCase(fixLeadingNumber(deconstruct(schema.details.name)));;

      // and so are the propertyNmaes
      for (const propertyName in schema.properties) {
        const d = schema.properties[propertyName].details
        d.name = pascalCase(fixLeadingNumber(deconstruct(d.name)));
      }
    }

    // output the model 
    await service.WriteFile("code-model-v2.yaml", serialize(codeModel), undefined/*,"code-model-v2"*/);

  } catch (E) {
    console.error(E);
  }
}