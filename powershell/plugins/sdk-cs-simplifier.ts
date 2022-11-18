/* eslint-disable prefer-const */
/* eslint-disable @typescript-eslint/no-non-null-assertion */
/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@azure-tools/autorest-extension-base';
import { TrieNode } from '../models/TrieNode';

export async function simplifierPlugin(service: Host) {
  const files = await service.ListInputs();
  const trimTasks = files.map(async file => {
    let namespacesToAdd: Set<string> = new Set<string>();
    const trimmed = await trimNamespace(await service.ReadFile(file), namespacesToAdd);
    const usings = findUsing(trimmed);
    service.WriteFile(file, addUsings(trimmed, usings[0], usings[1], sortNamespaces([...[...namespacesToAdd].map(namespace => `\n    using ${namespace};`), ...usings[2]])), undefined, 'source-file-csharp');
  });
  await Promise.all(trimTasks);
}

function addUsings(content: string, start: number, end: number, namespacesToAdd: Array<string>): string {
  let namespaces: string = namespacesToAdd.join('');
  return content.substring(0, start).concat(namespaces).concat(content.substring(end));
}

function findUsing(content: string): [number, number, Array<string>] {
  let index = 0;
  let start = 0;
  let end = 0;
  let existingUsings: Array<string> = new Array<string>();
  while (start != -1) {
    let segment: string = content.substring(index);
    start = segment.search(usingRegex);
    if (start != -1) {
      end = segment.indexOf(';', start) + 1;
      existingUsings.push(segment.substring(start, end));
      index += end;
    }
  }
  return [content.search(usingRegex), index, existingUsings];
}

function sortNamespaces(namespaces: Array<string>): Array<string> {
  return namespaces.sort((a, b) => {
    const arrA: Array<string> = a.split(';')[0].split('.');
    const arrB: Array<string> = b.split(';')[0].split('.');
    const length: number = arrA.length < arrB.length ? arrA.length : arrB.length;
    for (let i = 0; i < length; i++) {
      if (arrA[i] < arrB[i]) {
        return -1;
      } else if (arrA[i] > arrB[i]) {
        return 1;
      }
    }
    return arrA.length - arrB.length;
  });
}

async function trimNamespace(content: string, namespacesToAdd: Set<string>): Promise<string> {
  roots.forEach((root: TrieNode, key: string) => {
    let start = 0;
    let end = 0;
    while (start != -1) {
      start = content.indexOf(key, start);
      if (start != -1 && start + key.length < content.length) {
        end = content.indexOf(' ', start + key.length);
        const namespaceToTrim = findChildNamespace(content.substring(start + key.length + 1, end).split('.'), root, namespacesToAdd);
        if (namespaceToTrim !== key && predifinedNamespaces.has(namespaceToTrim)) {
          content = trim(content, start, start + namespaceToTrim.length + 1);
        } else {
          start = start + key.length;
        }
      }
    }
  });
  return content;
}

function findChildNamespace(segments: Array<string>, root: TrieNode, namespacesToAdd: Set<string>): string {
  let namespaceToTrim = root.value;
  for (const segment of segments) {
    if (!root.hasChild(segment)) {
      break;
    }
    root = root.getChild(segment)!;
    namespaceToTrim += ('.' + segment);
    if (predifinedNamespaces.has(namespaceToTrim)) {
      namespacesToAdd.add(namespaceToTrim);
    }
  }
  return namespaceToTrim;
}

function trim(content: string, start: number, end: number): string {
  return content.substring(0, start).concat(content.substring(end));
}

const predifinedNamespaces: Set<string> = new Set<string>(['Newtonsoft.Json', 'Newtonsoft.Json.Converters', 'System.Collections', 'System.Collections.Generic', 'System.Net', 'System.Net.Http', 'System.Threading', 'System.Threading.Tasks', 'Microsoft.Rest.Serialization', 'System.IO', 'System.Runtime', 'System.Runtime.Serialization']);
const roots: Map<string, TrieNode> = initTrie(predifinedNamespaces);
const usingRegex = '\n    using .*;';

function initTrie(predifinedNamespaces: Set<string>): Map<string, TrieNode> {
  let namespaceRoots: Map<string, TrieNode> = new Map<string, TrieNode>();
  predifinedNamespaces.forEach(namespace => {
    const names: Array<string> = namespace.split('.');
    if (!namespaceRoots.has(names[0])) {
      namespaceRoots.set(names[0], new TrieNode(names[0]));
    }
    let root: TrieNode = namespaceRoots.get(names[0])!;
    for (let i = 1; i < names.length; i++) {
      if (!root.hasChild(names[i])) {
        root?.addChild(names[i]);
      }
      root = root.getChild(names[i])!;
      root.isEnd = true;
    }
  });
  return namespaceRoots;
}