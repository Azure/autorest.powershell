/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Dictionary, includeXDash, ToDictionary } from '#common/linq';

export interface PathReference<T> {
  $ref: string;
}

export interface Dereferenced<T> {
  instance: T;
  name?: string;
}

export type Reference<T> = T;

export type Refable<T> = T | PathReference<T>;
export type Optional<T> = T | undefined;

export function typeOf(obj: any) {
  const t = typeof (obj);
  return t === 'object' ?
    Array.isArray(obj) ?
      'array' :
      'object' :
    t;
}

/** identifies if a given refable is a reference or an instance */
export function isReference<T>(item: Refable<T>): item is PathReference<T> {
  return (<PathReference<T>>item).$ref ? true : false;
}

/** gets an object instance for the item, regardless if it's a reference or not. */
export function dereference<T>(document: any, item: Refable<T>, stack = new Array<string>()): Dereferenced<T> {
  let name: string | undefined;

  if (isReference(item)) {
    let node = document;
    const path = item.$ref;
    if (stack.indexOf(path) > -1) {
      throw new Error(`Circular $ref in Model -- ${path} :: ${JSON.stringify(stack)} `);
    }
    stack.push(path);

    const parts = path.replace('#/', '').split('/');

    for (name of parts) {
      if (!node[name]) {
        throw new Error(`Invalid Reference ${name} -- ${path}`);
      }
      node = node[name];
    }

    if (isReference(node)) {
      // it's a ref to a ref.
      return dereference(document, node, stack);
    }
    return { instance: node, name };
  }
  return { instance: item, name: undefined };
}

export function clone(object: any) {
  return object ? JSON.parse(JSON.stringify(object)) : undefined;
}

export function getExtensionProperties(dictionary: Dictionary<any>): Dictionary<any> {
  return ToDictionary(includeXDash(dictionary), each => dictionary[each]);
}
