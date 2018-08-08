import { resources } from "#common/locations"
import { copyResources } from '#common/utility';
import { deserialize, serialize } from '#common/yaml';
import { Model } from "#csharp/lowlevel-generator/code-model"
import { Host } from '@microsoft.azure/autorest-extension-base';
import { join } from 'path';
import { State } from './generator';
import { Project } from './project';

export async function process(service: Host) {
  try {
    // Get the list of files
    const files = await service.ListInputs();
    const apifolder = await service.GetValue('api-folder') || '';
    const runtimefolder = await service.GetValue('runtime-folder') || 'runtime';
    const azure = await service.GetValue('azure') || await service.GetValue('azure-arm') || false;

    // get the openapi document
    if (files.length === 0) {
      throw new Error('Inputs missing.');
    }

    const filename = files[0];

    const codeModelText = await service.ReadFile(filename);
    const model = await deserialize<Model>(codeModelText, filename);

    const modelState = new State(service, model, filename);

    const project = new Project(modelState);
    await project.init();

    await project.writeFiles(async (fname, content) => service.WriteFile(join(apifolder, fname), content, undefined, 'source-file-csharp'));

    // recursive copy resources
    await copyResources(join(resources, 'runtime', 'csharp', 'client'), async (fname, content) => service.WriteFile(join(runtimefolder, fname), content, undefined, 'source-file-csharp'));
    if (project.defaultPipeline) {
      await copyResources(join(resources, 'runtime', 'csharp', 'pipeline'), async (fname, content) => service.WriteFile(join(runtimefolder, fname), content, undefined, 'source-file-csharp'));
    }
    if (project.jsonSerialization) {
      await copyResources(join(resources, 'runtime', 'csharp', 'json'), async (fname, content) => service.WriteFile(join(runtimefolder, fname), content, undefined, 'source-file-csharp'));
    }
    if (project.xmlSerialization) {
      await copyResources(join(resources, 'runtime', 'csharp', 'xml'), async (fname, content) => service.WriteFile(join(runtimefolder, fname), content, undefined, 'source-file-csharp'));
    }

    if (azure) {
      await copyResources(join(resources, 'runtime', 'csharp.azure'), async (fname, content) => service.WriteFile(join(runtimefolder, fname), content, undefined, 'source-file-csharp'));
    }

    // debug files...
    service.WriteFile('code-model-v2.csharp.yaml', serialize(model), undefined, 'source-file-other');

  } catch (E) {
    console.error(E);
  }
}
