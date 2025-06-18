/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { AutorestExtensionHost as Host, startSession } from '@autorest/extension-base';
import { codeModelSchema } from '@autorest/codemodel';
import { applyOverrides, copyResources, deserialize, serialize, } from '@azure-tools/codegen';
import { join } from 'path';
import { Model } from '../llcsharp/code-model';
import { Project } from '../llcsharp/project';
import { TspHost } from '../utils/tsp-host';
import { ModelState } from '../utils/model-state';
import { PwshModel } from '../utils/PwshModel';

const resources = `${__dirname}/../../resources`;

export async function llcsharpV2(service: Host | TspHost, state?: ModelState<PwshModel>) {
  try {
    const project = await new Project(service).init(state);
    const transformOutput = async (input: string) => {
      return await project.state.resolveVariables(input);
    };

    const projectCLI = await new Project(service).init(state);
    await project.writeFiles(async (fname, content) => project.state.writeFile(join(project.apifolder, fname), applyOverrides(content, project.overrides), undefined, 'source-file-csharp'));
    await projectCLI.writeFiles(async (fname, content) => projectCLI.state.writeFileCLI(join(projectCLI.apifolder, fname), applyOverrides(content, projectCLI.overrides), undefined, 'source-file-csharp'));

    // recursive copy resources
    await copyResources(join(resources, 'runtime', 'csharp', 'client'), async (fname, content) => project.state.writeFile(join(project.runtimefolder, fname), content, undefined, 'source-file-other'), project.overrides);
    await copyResources(join(resources, 'runtime', 'csharp', 'pipeline'), async (fname, content) => project.state.writeFile(join(project.runtimefolder, fname), content, undefined, 'source-file-other'), project.overrides, transformOutput);
    await copyResources(join(resources, 'runtime', 'csharp', 'client'), async (fname, content) => project.state.writeFileCLI(join(project.runtimefolder, fname), content, undefined, 'source-file-other'), project.overrides);
    await copyResources(join(resources, 'runtime', 'csharp', 'pipeline'), async (fname, content) => project.state.writeFileCLI(join(project.runtimefolder, fname), content, undefined, 'source-file-other'), project.overrides, transformOutput);
    // Note:
    // we are using the Carbon.Json library, but we don't *really* want to expose that as public members where we don't have to
    // and I don't want to make code changes in the source repository, so I can keep merging from upstream as simple as possible.
    // so, we're converting as much as possible to internal, and exposing only what must be exposed to make the code compile.

    await copyResources(join(resources, 'runtime', 'csharp', 'json'), async (fname, content) => project.state.writeFile(join(project.runtimefolder, fname), content, undefined, 'source-file-other'), {
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
      'internal(.*) bool Equals': 'public$1 bool Equals',
      'internal (.*) int GetHashCode': 'public $1 int GetHashCode',
      'internal void Dispose': 'public void Dispose',
      'internal (.*) operator': 'public $1 operator',
      'internal object FromJson\\(': 'public object FromJson(',
      'internal JsonNode ToJson\\(': 'public JsonNode ToJson(',

    });

    await copyResources(join(resources, 'runtime', 'csharp', 'json'), async (fname, content) => project.state.writeFileCLI(join(project.runtimefolder, fname), content, undefined, 'source-file-other'), {
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
      'internal(.*) bool Equals': 'public$1 bool Equals',
      'internal (.*) int GetHashCode': 'public $1 int GetHashCode',
      'internal void Dispose': 'public void Dispose',
      'internal (.*) operator': 'public $1 operator',
      'internal object FromJson\\(': 'public object FromJson(',
      'internal JsonNode ToJson\\(': 'public JsonNode ToJson(',

    });

    if (project.xmlSerialization) {
      await copyResources(join(resources, 'runtime', 'csharp', 'xml'), async (fname, content) => project.state.writeFile(join(project.runtimefolder, fname), content, undefined, 'source-file-other'), project.overrides);
    }

    if (project.azure) {
      await copyResources(join(resources, 'runtime', 'csharp.azure'), async (fname, content) => project.state.writeFile(join(project.runtimefolder, fname), content, undefined, 'source-file-other'), project.overrides);
      await copyResources(join(resources, 'runtime', 'csharp.azure'), async (fname, content) => project.state.writeFileCLI(join(project.runtimefolder, fname), content, undefined, 'source-file-other'), project.overrides);
    }

  } catch (E) {
    if (E instanceof Error) {
      console.error(`${__filename} - ${E.stack}/${E.message}`);
    }
    throw E;
  }
}
