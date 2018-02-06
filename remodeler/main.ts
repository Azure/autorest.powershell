import { Host } from "@microsoft.azure/autorest-extension-base";

export async function process(service: Host) {
  // Get the list of files 
  const files = await service.ListInputs();

  //
  for (const file of files) {
    const openapiDefinitionDocument = await service.ReadFile(file);
  }

  await service.WriteFile("foo.txt", "hello world");
}