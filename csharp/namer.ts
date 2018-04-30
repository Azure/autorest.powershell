import { processCodeModel } from "#common/process-code-model";
import { ModelState } from "#common/model-state";
import { Model } from "#common/code-model/code-model";
import { deconstruct, fixLeadingNumber, pascalCase, camelCase } from "#common/text-manipulation";
import { Host } from "@microsoft.azure/autorest-extension-base";
import { isHttpOperation } from "#common/code-model/http-operation";

export async function process(service: Host) {
  return await processCodeModel(nameStuffRight, service);
}

async function nameStuffRight(codeModel: Model, service: Host): Promise<Model> {

  // set the namespace for the service
  const serviceNamespace = await service.GetValue("namespace") || "Sample.API";
  codeModel.details.namespace = serviceNamespace;

  // fix client name
  codeModel.details.name = pascalCase(fixLeadingNumber(deconstruct(codeModel.details.name)));

  for (const op of Object.values(codeModel.http.operations).filter(isHttpOperation)) {
    const details = op.details;

    // operations have pascal cased names
    details.name = pascalCase(fixLeadingNumber(deconstruct(details.name)));

    // parameters are camelCased.
    for (const p of op.parameters) {
      p.details.name = camelCase(fixLeadingNumber(deconstruct(p.details.name)));
    }
  }

  for (const schemaName in codeModel.schemas) {
    const schema = codeModel.schemas[schemaName];
    // schema names are pascalCased
    schema.details.name = pascalCase(fixLeadingNumber(deconstruct(schema.details.name)));;

    // and so are the propertyNmaes
    for (const propertyName in schema.properties) {
      const d = schema.properties[propertyName].details
      d.name = pascalCase(fixLeadingNumber(deconstruct(d.name)));
    }

    // fix enum names
    if (schema.details.enum) {
      schema.details.enum.name = pascalCase(fixLeadingNumber(deconstruct(schema.details.enum.name)));

      // and the value names themselves
      for (const value of schema.details.enum.values) {
        value.name = pascalCase(fixLeadingNumber(deconstruct(value.name)));
      }
    }
  }

  return codeModel;
}