import { Host } from "@microsoft.azure/autorest-extension-base";

export async function process(service: Host) {
  // Get the list of files 
  const files = await service.ListInputs();

  //
  for (const file of files) {
    const openapiDefinitionDocument = await service.ReadFile(file);
  }

  // get the remodeled openapi document

  // create a abstraction interface for the REST API
  
  // return the abstraction interface 
  await service.WriteFile("foo.txt", "hello world");
}