import { Model } from '#common/code-model/code-model';
import { isHttpOperation } from '#common/code-model/http-operation';
import { isSchemaObject, JsonType, Property } from '#common/code-model/schema';
import { items, length, values } from '#common/dictionary';
import { ModelState } from '#common/model-state';
import { processCodeModel } from '#common/process-code-model';
import { map } from '#common/text-manipulation';
import { deserialize, serialize } from '#common/yaml';
import { ArtifactMessage, Channel, Host } from '@microsoft.azure/autorest-extension-base';

// Azure version -
// Additional tweaks the code model to adjust things so that the code will generate better.

export async function process(service: Host) {
  return processCodeModel(tweakModel, service);
}

async function tweakModel(model: Model, service: Host): Promise<Model> {
  // service.Message({ Channel: Channel.Debug, Text: "THIS IS THE AZURE TWEAKER" });

  // TODO: 
  // look at models, and extract out any case that has an IRESOURCE, IPROXYRESOURCE, etc.
  // and use the common versions of those models.



  return model;
}
