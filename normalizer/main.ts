import { Host } from "@microsoft.azure/autorest-extension-base";

export async function process(service: Host) {
  // Get the list of files 
  const files = await service.ListInputs();

  //
  for (const file of files) {
    const openapiDefinitionDocument = await service.ReadFile(file);

  }


  // Get the code model
  // const codeModel: CodeModel = load(await service.GetValue("code-model-v1.yaml"));


}