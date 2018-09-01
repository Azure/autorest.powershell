/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

export function includeXDash<T>(dictionary: Dictionary<T>) {
  return Object.keys(dictionary).filter((v, i, a) => v.startsWith('x-'));
}
export function excludeXDash<T>(dictionary: Dictionary<T>) {
  return Object.keys(dictionary).filter((v, i, a) => !v.startsWith('x-'));
}

export interface Index<T> {
  [key: number]: T;
}

export interface Dictionary<T> {
  [key: string]: T;
}

export class Dictionary<T> implements Dictionary<T> {
}

export function ToDictionary<T>(keys: Array<string>, each: (index: string) => T) {
  const result = new Dictionary<T>();
  keys.map((v, i, a) => result[v] = each(v));
  return result;
}

export function CopyDictionary<TSource, TDestination>(dictionary: Dictionary<TSource>, each: (index: string) => TDestination) {
  return ToDictionary(excludeXDash(dictionary), each);
}

export type IndexOf<T> = T extends Map<T, infer V> ? V : T extends Array<infer V> ? number : string;

/** returns an Linqable<> for keys in the collection */
export function keys<K, T, TSrc extends (Array<T> | Dictionary<T> | Map<K, T>)>(source: (Array<T> | Dictionary<T> | Map<K, T>)): Linqable<IndexOf<TSrc>> {
  if (Array.isArray(source)) {
    return <Linqable<IndexOf<TSrc>>>linqify(source.keys());
  }
  if (source instanceof Map) {
    return <Linqable<IndexOf<TSrc>>><any>linqify(source.keys());
  }
  if (source) {
    return <Linqable<IndexOf<TSrc>>>linqify((Object.getOwnPropertyNames(source)));
  }
  return linqify([]);
}

/** returns an Linqable<> for values in the collection */
export function values<K, T, TSrc extends (Array<T> | Dictionary<T> | Map<K, T>)>(source: (Array<T> | Dictionary<T> | Map<K, T>)): Linqable<T> {
  if (Array.isArray(source)) {
    return linqify(function* () { for (const v of source) { yield v; } }());
  }
  if (source instanceof Map) {
    return linqify(source.values());
  }
  if (source) {
    return linqify(function* () { for (const key of keys(source)) { const value = source[key]; if (typeof value !== 'function') { yield value; } } }());
  }
  return linqify([]);
}

/** returns an Linqable<{key,value}> for the Collection */
export function items<K, T, TSrc extends (Array<T> | Dictionary<T> | Map<K, T>)>(source: TSrc & (Array<T> | Dictionary<T> | Map<K, T>)): Linqable<{ key: IndexOf<TSrc>; value: T }> {
  if (Array.isArray(source)) {
    return <Linqable<{ key: IndexOf<TSrc>; value: T }>>linqify(function* () { for (let i = 0; i < source.length; i++) { yield { key: i, value: source[i] }; } }());
  }
  if (source instanceof Map) {
    return <Linqable<{ key: IndexOf<TSrc>; value: T }>><any>linqify(function* () { for (const [key, value] of source.entries()) { yield { key, value }; } }());
  }
  if (source) {
    return <Linqable<{ key: IndexOf<TSrc>; value: T }>>linqify(function* () { for (const key of keys(source)) { const value = source[key]; if (typeof value !== 'function') { yield { key, value: source[key] }; } } }());
  }
  return linqify([]);
}

export function length<T, K>(source?: Dictionary<T> | Array<T> | Map<K, T>): number {
  if (Array.isArray(source)) {
    return source.length;
  }
  if (source instanceof Map) {
    return source.size;
  }
  return source ? Object.getOwnPropertyNames(source).length : 0;
}

export function any<T>(this: Iterable<T>, predicate: (each: T) => boolean): boolean {
  for (const each of this) {
    if (predicate(each)) {
      return true;
    }
  }
  return false;
}

export function all<T>(this: Iterable<T>, predicate: (each: T) => boolean): boolean {
  for (const each of this) {
    if (!predicate(each)) {
      return false;
    }
  }
  return true;
}

export function select<T, V>(this: Iterable<T>, selector: (each: T) => V): Linqable<V> {
  return linqify(function* (this: Iterable<T>) {
    for (const each of this) {
      yield selector(each);
    }
  }.bind(this)());
}

export function selectMany<T, V>(this: Iterable<T>, selector: (each: T) => Iterable<V>): Linqable<V> {
  return linqify(function* (this: Iterable<T>) {
    for (const each of this) {
      for (const item of selector(each)) {
        yield item;
      }
    }
  }.bind(this)());
}

export function where<T>(this: Iterable<T>, predicate: (each: T) => boolean): Linqable<T> {
  return linqify(function* (this: Iterable<T>) {
    for (const each of this) {
      if (predicate(each)) {
        yield each;
      }
    }
  }.bind(this)());
}

export function selectNonNullable<T, V>(this: Iterable<T>, selector: (each: T) => V): Linqable<NonNullable<V>> {
  return linqify(function* (this: Iterable<T>) {
    for (const each of this) {
      const value = selector(each);
      if (value) {
        yield value;
      }
    }
  }.bind(this)());
}

export function nonNullable<T>(this: Iterable<T>): Linqable<NonNullable<T>> {
  return linqify(function* (this: Iterable<T>) {
    for (const each of this) {
      if (each) {
        yield each;
      }
    }
  }.bind(this)());
}

export function first<T>(this: Iterable<T>, predicate?: (each: T) => boolean): T | undefined {
  for (const each of this) {
    if (!predicate || predicate(each)) {
      return each;
    }
  }
  return undefined;
}

export function toArray<T>(this: Iterable<T>): Array<T> {
  return [...this];
}

export function bifurcate<T>(this: Iterable<T>, predicate: (each: T) => boolean): Array<Array<T>> {
  const result = [new Array<T>(), new Array<T>()];
  for (const each of this) {
    result[predicate(each) ? 0 : 1].push(each);
  }
  return result;
}

function distinct<T>(this: Iterable<T>, selector?: (each: T) => any): Linqable<T> {
  const hash = new Dictionary<boolean>();
  return linqify(function* (this: Iterable<T>) {

    if (!selector) {
      selector = i => i;
    }
    for (const each of this) {
      const k = JSON.stringify(selector(each));
      if (!hash[k]) {
        hash[k] = true;
        yield each;
      }
    }
  }.bind(this)());
}

export interface Linqable<T> extends Iterable<T> {
  linq: {
    any(predicate: (each: T) => boolean): boolean;
    all(predicate: (each: T) => boolean): boolean;
    bifurcate(predicate: (each: T) => boolean): Array<Array<T>>;
    distinct(selector?: (each: T) => any): Linqable<T>;
    first(predicate?: (each: T) => boolean): T | undefined;
    selectNonNullable<V>(selector: (each: T) => V): Linqable<NonNullable<V>>;
    select<V>(selector: (each: T) => V): Linqable<V>;
    selectMany<V>(selector: (each: T) => Iterable<V>): Linqable<V>;
    where(predicate: (each: T) => boolean): Linqable<T>;
    toArray(): Array<T>;
  };
}

function linqify<T>(iterable: Iterable<T>): Linqable<T> {
  return Object.defineProperty(iterable, 'linq', {
    get: () => {
      return {
        all: all.bind(iterable),
        any: any.bind(iterable),
        bifurcate: bifurcate.bind(iterable),
        distinct: distinct.bind(iterable),
        first: first.bind(iterable),
        select: select.bind(iterable),
        selectMany: selectMany.bind(iterable),
        selectNonNullable: selectNonNullable.bind(iterable),
        toArray: toArray.bind(iterable),
        where: where.bind(iterable),
      };
    }
  });
}
