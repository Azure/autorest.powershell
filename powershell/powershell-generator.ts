import { deserialize, serialize } from '#common/yaml';
import { Model } from '#common/code-model/code-model';
import { Host } from '@microsoft.azure/autorest-extension-base';

export async function process(service: Host) {
  try {
    // Get the list of files
    const files = await service.ListInputs("code-model-v2");

    // get the openapi document
    if (files.length != 1) {
      throw new Error("Inputs missing.");
    }

    const filename = files[0];

    const codeModelText = await service.ReadFile(filename);
    const model = await deserialize<Model>(codeModelText, filename);

    // await service.WriteFile("code-model-v2.powershell.yaml", serialize(model), undefined, "source-file-yaml");
    // await service.WriteFile("code-model-v2.powershell.yaml", serialize(model), undefined, "source-file-yaml");

  } catch (E) {
    console.error(E);
  }
}