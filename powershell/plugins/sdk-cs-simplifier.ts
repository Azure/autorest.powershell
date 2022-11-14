/* eslint-disable prefer-const */
/* eslint-disable @typescript-eslint/no-non-null-assertion */
/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { ArraySchema, CodeModel, ConstantSchema, DictionarySchema, getAllProperties, HttpHeader, Language, ObjectSchema, Operation, Parameter, Property, Schema, SchemaType } from '@azure-tools/codemodel';
import { deserialize, map, serialize } from '@azure-tools/codegen';
import { PwshModel } from '../utils/PwshModel';
import { SdkModel } from '../utils/SdkModel';
import { ModelState } from '../utils/model-state';
import { StatusCodes } from '../utils/http-definitions';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { SchemaDetails } from '../llcsharp/code-model';
import { Host } from '@azure-tools/autorest-extension-base';
import { codemodel, schema } from '@azure-tools/codemodel-v3';
import { SchemaDefinitionResolver } from '../llcsharp/exports';
import { SchemaT } from '@azure-tools/codemodel-v3/dist/code-model/exports';
import { ServiceNamespace } from '../llcsharp/operation/namespace';
import { promises } from 'dns';

export async function simplifierPlugin(service: Host) {
  const files = await service.ListInputs();
  const trimTasks = files.map(async file => {
    let namespacesToAdd: Set<string> = new Set<string>();
    let model: SdkModel = deserialize<SdkModel>(await trimNamespace(await service.ReadFile(file), namespacesToAdd), file);
    model.usings = [...model.usings, ...namespacesToAdd];
    service.WriteFile(file, serialize(model), undefined, 'code-model-v4');
  });
  await Promise.all(trimTasks);
}

async function trimNamespace (content: string, namespacesToAdd: Set<string>): Promise<string> {
  roots.forEach((root: TrieNode, key: string) => {
    let start = 0;
    let end = 0;
    while (start != -1) {
      start = content.indexOf(key, start);
      if (start != -1 && start+key.length < content.length) {
        end = content.indexOf(' ', start+key.length);
        const namespaceToTrim = findChildNamespace(content.substring(start, end).split('.'), root, namespacesToAdd);
        if (namespaceToTrim !== key) {
          content = trim(content, start, start+namespaceToTrim.length+1);
        } else {
          start = start+key.length;
        }
      }
    }
  });
  return content;
}

function findChildNamespace (segments: Array<string>, root: TrieNode, namespacesToAdd: Set<string>): string {
  let namespaceToTrim = root.value;
  for (const segment in segments) {
    if (!root.hasChild(segment)) {
      break;
    }
    namespaceToTrim += ('.' + segment);
    namespacesToAdd.add(namespaceToTrim);
  }
  return namespaceToTrim;
}

function trim (content: string, start: number, end: number): string {
  return content.substring(0, start).concat(content.substring(end));
}

function isNamespace (content: string, start: number, end: number): boolean {
  return (start == 0 || content.charAt(start-1) == ' ') && (content.length > end && content.charAt(end) == '.');
}

const predifinedNamespaces: Set<string> = new Set<string>(['Newtonsoft.Json', 'Newtonsoft.Json.Converters', 'System.Collections', 'System.Collections.Generic', 'System.Linq', 'System.Net', 'System.Net.Http', 'System.Threading', 'System.Threading.Tasks', 'Microsoft.Rest.Serialization', 'System.IO', 'System.Runtime', 'System.Runtime.Serialization']);
const roots: Map<string, TrieNode> = initTrie(predifinedNamespaces);

class TrieNode {
  value: string;
  private children: Map<string, TrieNode>;
  isEnd: boolean;
  constructor(value: string) {
    this.value = value;
    this.children = new Map<string, TrieNode>();
    this.isEnd = false;
  }

  addChild (child: TrieNode): void
  addChild (child: string): void
  addChild (child: unknown): void {
    if (typeof child === 'string' && !this.children.has(child)) {
      this.children.set(child, new TrieNode(child));
    } else if (child instanceof TrieNode && !this.children.has(child.value)) {
      this.children.set(child.value, child);
    } else {
      throw new Error('invalid trie node or trie node value.');
    }
  }

  hasChild (child: TrieNode): boolean
  hasChild (child: string): boolean
  hasChild (child: unknown): boolean {
    let value: string;
    if (typeof child === 'string') {
      value = child;
    } else if (child instanceof TrieNode) {
      value = child.value;
    } else {
      throw new Error('invalid trie node or trie node value.');
    }
    return this.children.has(value);
  }

  getChild (key: string): TrieNode | undefined {
    return this.children.get(key);
  }
}

function initTrie (predifinedNamespaces: Set<string>): Map<string, TrieNode> {
  let namespaceRoots: Map<string, TrieNode> = new Map<string, TrieNode>();
  predifinedNamespaces.forEach(namespace => {
    const names: Array<string> = namespace.split('.');
    if (!namespaceRoots.has(names[0])) {
      namespaceRoots.set(names[0], new TrieNode(names[0]));
    }
    let root: TrieNode = namespaceRoots.get(names[0])!;
    for (let i = 1; i<names.length; i++) {
      if (!root.hasChild(names[i])) {
        root?.addChild(names[i]);
      }
      root = root.getChild(names[i])!;
      root.isEnd = true;
    }
  });
  return namespaceRoots;
}