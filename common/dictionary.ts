import { excludeXDash } from '#remodeler/common';

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


export interface Pair<KEY, VALUETYPE> {
  key: KEY;
  value: VALUETYPE;
}

function* itemsa<V>(array: Array<V>): Iterable<Pair<number, V>> {
  for (let key = 0; key < array.length; key++) {
    yield { key, value: array[key] };
  }
}

function* itemsd<V>(dictionary: Dictionary<V>): Iterable<Pair<string, V>> {
  if (dictionary) {
    for (const key of Object.getOwnPropertyNames(dictionary)) {
      yield { key, value: dictionary[key] };
    }
  }
}

export function items<V, T extends (Array<V> | Dictionary<V>)>(dictionary?: T & (Array<V> | Dictionary<V>)): T extends Dictionary<V> ? Iterable<Pair<string, V>> : Iterable<Pair<number, V>> {
  return Array.isArray(dictionary) ?
    <T extends Dictionary<V> ? Iterable<Pair<string, V>> : Iterable<Pair<number, V>>>itemsa(dictionary) :
    <T extends Dictionary<V> ? Iterable<Pair<string, V>> : Iterable<Pair<number, V>>>itemsd(<Dictionary<V>>dictionary);
}

export function* values<T>(dictionary?: Dictionary<T> | Array<T>): Iterable<T> {
  if (Array.isArray(dictionary)) {
    for (let key = 0; key < dictionary.length; key++) {
      yield dictionary[key];
    }
    return;
  }

  if (dictionary) {
    for (const key of Object.getOwnPropertyNames(dictionary)) {
      yield dictionary[key];
    }
  }
}

function* akeys<V>(array: Array<V>): Iterable<number> {
  for (let key = 0; key < array.length; key++) {
    yield key;
  }
}

function* dkeys<V>(dictionary?: Dictionary<V>): Iterable<string> {
  if (dictionary) {
    for (const key of Object.getOwnPropertyNames(dictionary)) {
      yield key;
    }
  }
}

export function keys<V, T extends (Dictionary<V> | Array<V>)>(dictionary?: T): T extends Dictionary<V> ? Iterable<string> : Iterable<number> {
  return Array.isArray(dictionary) ?
    <T extends Dictionary<V> ? Iterable<string> : Iterable<number>>akeys(dictionary) :
    <T extends Dictionary<V> ? Iterable<string> : Iterable<number>>dkeys((<Dictionary<V>>dictionary));
}

export function length<T>(dictionary?: Dictionary<T> | Array<T>): number {
  if (Array.isArray(dictionary)) {
    return dictionary.length;
  }
  return dictionary ? Object.getOwnPropertyNames(dictionary).keys.length : 0;
}