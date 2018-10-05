/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { Host } from '@microsoft.azure/autorest-extension-base';
import { applyOverrides, copyResources, deserialize, serialize, } from '@microsoft.azure/autorest.codegen';
import { join } from 'path';
import { Model } from './code-model';
import { State } from './generator';
import { Project } from './project';

const root = `${__dirname}/../..`;
const resources = `${root}/resources`;

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

    await project.writeFiles(async (fname, content) => service.WriteFile(join(apifolder, fname), applyOverrides(content, project.overrides), undefined, 'source-file-csharp'));

    // recursive copy resources
    await copyResources(join(resources, 'runtime', 'csharp', 'client'), async (fname, content) => service.WriteFile(join(runtimefolder, fname), content, undefined, 'source-file-csharp'), project.overrides);
    if (project.defaultPipeline) {
      await copyResources(join(resources, 'runtime', 'csharp', 'pipeline'), async (fname, content) => service.WriteFile(join(runtimefolder, fname), content, undefined, 'source-file-csharp'), project.overrides);
    }
    if (project.jsonSerialization) {
      // Note:
      // we are using the Carbon.Json library, but we don't *really* want to expose that as public members where we don't have to
      // and I don't want to make code changes in the source repository, so I can keep merging from upstream as simple as possible.
      // so, we're converting as much as possible to internal, and exposing only what must be exposed to make the code compile.

      await copyResources(join(resources, 'runtime', 'csharp', 'Json'), async (fname, content) => service.WriteFile(join(runtimefolder, fname), content, undefined, 'source-file-csharp'), {
        ...project.overrides,
        'public': 'internal',
        'internal (.*) class JsonNumber': 'public $1 class JsonNumber',
        'internal (.*) class JsonObject': 'public $1 class JsonObject',
        'internal (.*) class JsonNode': 'public $1 class JsonNode',
        'internal (.*) class JsonString': 'public $1 class JsonString',
        'internal (.*) class XNodeArray': 'public $1 class XNodeArray',
        'internal (.*) class JsonArray': 'public $1 class JsonArray',
        'internal(.*) class JsonTokenizer': 'public$1 class JsonTokenizer',
        'internal(.*) class JsonParser': 'public$1 class JsonParser',
        'internal(.*) class TokenReader': 'public$1 class TokenReader',
        'internal(.*) class SourceReader': 'public$1 class SourceReader',
        'internal(.*) class (.*)Converter': 'public$1 class $2Converter',
        'internal(.*) interface IJsonSerializable': 'public$1 interface IJsonSerializable',
        'internal override string ToString': 'public override string ToString',
        'internal void Add\\(': 'public void Add(',
        'internal bool ContainsKey\\(': 'public bool ContainsKey(',
        'internal bool Remove\\(': 'public bool Remove(',
        'internal bool TryGetValue\\(': 'public bool TryGetValue(',
        'internal (.*) JsonNode this\\[': 'public $1 JsonNode this[',

        'internal ICollection<JsonNode> Values': 'public ICollection<JsonNode> Values',
        'internal ICollection<string> Keys': 'public ICollection<string> Keys',
        'internal bool IsReadOnly': 'public bool IsReadOnly',
        'internal (.*) int Count': 'public $1 int Count',
        'internal bool Contains\\(': 'public bool Contains(',
        // 'internal (.*) JsonType': 'public $1 JsonType',
        'internal(.*) bool Equals': 'public$1 bool Equals',
        'internal (.*) int GetHashCode': 'public $1 int GetHashCode',
        'internal void Dispose': 'public void Dispose',
        'internal (.*) operator': 'public $1 operator',
        'internal object FromJson\\(': 'public object FromJson(',
        'internal JsonNode ToJson\\(': 'public JsonNode ToJson(',

        // 'internal partial class JsonNumber': 'public partial class JsonNumber'
        // 'internal partial class JsonNumber': 'public partial class JsonNumber'
        // 'internal partial class JsonNumber': 'public partial class JsonNumber'
      });
    }
    if (project.xmlSerialization) {
      await copyResources(join(resources, 'runtime', 'csharp', 'xml'), async (fname, content) => service.WriteFile(join(runtimefolder, fname), content, undefined, 'source-file-csharp'), project.overrides);
    }

    if (azure) {
      await copyResources(join(resources, 'runtime', 'csharp.azure'), async (fname, content) => service.WriteFile(join(runtimefolder, fname), content, undefined, 'source-file-csharp'), project.overrides);
    }

    // debug files...
    service.WriteFile('code-model-v2.csharp.yaml', serialize(model), undefined, 'source-file-other');

  } catch (E) {
    console.error(E);
    throw E;
  }
}
