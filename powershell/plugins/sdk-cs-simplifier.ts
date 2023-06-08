/* eslint-disable prefer-const */
/* eslint-disable @typescript-eslint/no-non-null-assertion */
/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@autorest/extension-base';
import { TrieNode } from '../utils/TrieNode';

const predifinedNamespaces: Set<string> = new Set<string>(['Newtonsoft.Json', 'Newtonsoft.Json.Converters', 'System.Collections', 'System.Collections.Generic', 'System.Net', 'System.Net.Http', 'System.Threading', 'System.Threading.Tasks', 'Microsoft.Rest.Serialization', 'System.IO', 'System.Runtime', 'System.Runtime.Serialization', 'Microsoft.Rest', 'Microsoft.Rest.Azure', 'System.Linq', 'Models']);
const exceptionClassNames: Map<string, string> = new Map<string, string>([
  ['JsonTransformation', 'Microsoft'],
  ['SafeJsonConvert', 'Microsoft'],
  ['Formatting', ''],
  ['DateFormatHandling', ''],
  ['DateTimeZoneHandling', ''],
  ['NullValueHandling', ''],
  ['ReferenceLoopHandling', ''],
  ['Headers', '']
]);
const root: TrieNode = initTrie(predifinedNamespaces);
const usingRegex = /\n {4}using .*;/i;
const namespaceRegex = /(?<=using )(.*)(?=[;])/i;
//const thisRegex = /this\.(?![Client])/g;
const thisRegex = /this\./g;
const characterCheckRegex = /(?![a-zA-Z])/i;

export async function simplifierPlugin(service: Host) {
  const files = await service.ListInputs();
  const trimTasks = files.map(async file => {
    let namespacesToAdd: Set<string> = new Set<string>();
    let content: string = await service.ReadFile(file);
    const usings = findUsing(content, namespacesToAdd);
    const beforeUsings: string = content.substring(0, usings[0]);
    let afterUsings: string = content.substring(usings[1]);
    afterUsings = trimNamespace(afterUsings, namespacesToAdd);
    content = removeThis(addUsings(beforeUsings, afterUsings, sortNamespaces([...namespacesToAdd]).join('')));
    service.WriteFile(file, content, undefined, 'source-file-csharp');
  });
  await Promise.all(trimTasks);
}

function removeThis(content: string): string {
  return content.replace(thisRegex, '');
}

function addUsings(beforeUsings: string, afterUsings: string, namespaces: string): string {
  return beforeUsings.concat(namespaces).concat(afterUsings);
}

function findUsing(content: string, namespacesToAdd: Set<string>): [number, number] {
  let index = 0;
  let start = 0;
  let end = 0;
  while (start != -1) {
    let segment: string = content.substring(index);
    start = segment.search(namespaceRegex);
    if (start != -1) {
      end = segment.indexOf(';', start);
      const namespace = segment.substring(start, end);
      findChildNamespace(namespace.split('.'), root, namespacesToAdd);
      index += end;
    }
  }
  return [content.search(usingRegex), index + 1];
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

function trimNamespace(content: string, namespacesToAdd: Set<string>): string {
  root.children.forEach((current: TrieNode, key: string) => {
    let start = 0;
    let end = 0;
    while (start != -1) {
      start = content.indexOf(key, start);
      if (start != -1 && start + key.length < content.length) {
        end = content.indexOf(' ', start + key.length);
        const namespaceToTrim = findChildNamespace(content.substring(start, end).split('.'), root, namespacesToAdd);
        if (namespaceToTrim != '') {
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
  let className: string = segments.pop()!;
  if (className.search(characterCheckRegex) != -1) {
    segments.push(className.substring(0, className.search(characterCheckRegex)));
  }
  let namespaceToTrim = '';
  let currentNamespaces: Array<string> = new Array<string>();
  let i = 0;
  for (; i < segments.length; i++) {
    let segment = segments[i];
    if (!root.hasChild(segment)) {
      break;
    }
    root = root.getChild(segment)!;
    namespaceToTrim += namespaceToTrim == '' ? segment : ('.' + segment);
    if (predifinedNamespaces.has(namespaceToTrim)) {
      currentNamespaces.push(`\n    using ${namespaceToTrim};`);
    }
  }
  if (!predifinedNamespaces.has(namespaceToTrim)) {
    return '';
  }
  if (exceptionClassNames.has(segments[i])) {
    //can't handle this case, have to hard code 'SafeJsonConvert'
    if (segments[i] == 'SafeJsonConvert') {
      return exceptionClassNames.get(segments[i])!;
    }
    namespaceToTrim = exceptionClassNames.get(segments[i])!;
  }
  currentNamespaces.forEach(namespace => namespacesToAdd.add(namespace));
  return namespaceToTrim;
}

function trim(content: string, start: number, end: number): string {
  return content.substring(0, start).concat(content.substring(end));
}

function initTrie(predifinedNamespaces: Set<string>): TrieNode {
  const dummy: TrieNode = new TrieNode('');
  predifinedNamespaces.forEach(namespace => {
    const names: Array<string> = namespace.split('.');
    if (!dummy.hasChild(names[0])) {
      dummy.addChild(names[0]);
    }
    let current: TrieNode = dummy.getChild(names[0])!;
    for (let i = 1; i < names.length; i++) {
      if (!current.hasChild(names[i])) {
        current?.addChild(names[i]);
      }
      current = current.getChild(names[i])!;
      current.isEnd = true;
    }
  });

  return dummy;
}