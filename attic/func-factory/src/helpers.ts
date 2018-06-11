import { safeDump, safeLoad } from 'js-yaml';
import { ScriptTarget } from 'typescript';

export type Obj<T> = { [id: string]: T };

export function deepEquals<T>(a: T, b: T) {
  if (a === b) return true;
  return safeDump(a, { sortKeys: true, skipInvalid: true }) === safeDump(b, { sortKeys: true, skipInvalid: true });
}

export type Diff<A, B> = A extends B ? never : A;

export function objMap<T, U>(f: (key: string, arg: Diff<T, undefined>) => U, o: { [key: string]: T }): { [key: string]: U } {
  const result: { [key: string]: U } = {};
  for (const entry of Object.entries(o)) if (entry[1] !== undefined) result[entry[0]] = f(entry[0], entry[1] as any);
  return result;
}

export function error(message: string): never {
  throw new Error(message);
}
export function errorUnreachable(): never {
  debugger;
  return error("unreachable");
}

export function setIsEqual<T>(a: Iterable<T>, b: Iterable<T>): boolean {
  return setIsSubset(a, b) && setIsSubset(b, a);
}

export function setIsSubset<T>(a: Iterable<T>, b: Iterable<T>): boolean {
  return setIsEmpty(setExcept<T>(a, b));
}
export function setExcept<T>(a: Iterable<T>, b: Iterable<T>): Iterable<T> {
  const tmp = new Set<T>(a);
  for (const x of b) tmp.delete(x);
  return tmp;
}
export function setIntersect<T>(a: Iterable<T>, b: Iterable<T>): Iterable<T> {
  const tmp = new Set<T>(a);
  return [...b].filter(x => tmp.has(x));
}
export function setIsEmpty<T>(a: Iterable<T>): boolean {
  for (const _ of a) return false;
  return true;
}

export function clone<T>(x: T): T {
  return safeLoad(safeDump(x, { skipInvalid: true }));
}

export function lundef<T, U>(x: T | undefined, f: (x: T) => U | undefined): U | undefined {
  return x && f(x);
}
export function trycatch<T>(x: () => T, y: (error: any) => T): T {
  try {
    return x();
  } catch (e) {
    return y(e);
  }
}

export type DeepMutable<T> =
  T extends Array<infer A> ? DeepMutableArray<A> :
  T extends ReadonlyArray<infer A> ? DeepMutableArray<A> :
  T extends ReadonlyMap<infer A, infer B> ? DeepMutableMap<A, B> :
  T extends ReadonlySet<infer A> ? DeepMutableSet<A> :
  T extends object ? DeepMutableObject<T, keyof T> :
  T;
export interface DeepMutableMap<T, U> extends Map<DeepMutable<T>, DeepMutable<U>> { }
export interface DeepMutableSet<T> extends Set<DeepMutable<T>> { }
export interface DeepMutableArray<T> extends Array<DeepMutable<T>> { }
export type DeepMutableObject<T extends { [x: string]: any }, K extends string> =
  { [P in K]?: DeepMutable<T[P]>; };


import * as tscs from 'typescript-simple';
export function tsc(code: string): string {
  return tscs(code, { lib: ["es2017"], target: ScriptTarget.ES2017, strict: true });
}


function objReplaceInternal<T, U>(x: T, map: Set<{ src: any, dst: any }>, seen: Set<any>): T {
  for (const m of map) if (x === m.src) return m.dst;
  if (typeof x !== "object") return x;

  if (seen.has(x)) return x;
  seen.add(x);

  if (Array.isArray(x)) {
    const potentialResult: any[] = [];
    const newMap = { src: x, dst: potentialResult };
    map.add(newMap);

    let change = false;
    for (const y of x) {
      const res = objReplaceInternal(y, map, seen);
      if (res !== y) change = true;
      potentialResult.push(res);
    }
    if (change) return potentialResult as any;
    map.delete(newMap);
    return x;
  }
  if (x instanceof Set) {
    const potentialResult: Set<any> = new Set();
    const newMap = { src: x, dst: potentialResult };
    map.add(newMap);

    let change = false;
    for (const y of x) {
      const res = objReplaceInternal(y, map, seen);
      if (res !== y) change = true;
      potentialResult.add(res);
    }
    if (change) return potentialResult as any;
    map.delete(newMap);
    return x;
  }
  if (x instanceof Map) {
    const potentialResult: Map<any, any> = new Map();
    const newMap = { src: x, dst: potentialResult };
    map.add(newMap);

    let change = false;
    for (const y of x) {
      const res = objReplaceInternal(y, map, seen);
      if (res !== y) change = true;
      potentialResult.set(res[0], res[1]);
    }
    if (change) return potentialResult as any;
    map.delete(newMap);
    return x;
  }
  {
    const potentialResult: { [key: string]: any } = {};
    const newMap = { src: x, dst: potentialResult };
    map.add(newMap);

    let change = false;
    for (const key of Object.keys(x)) {
      const y: [any, any] = [key, (x as any)[key]];
      const res = objReplaceInternal(y, map, seen);
      if (res !== y) change = true;
      potentialResult[res[0]] = res[1];
    }
    if (change) return potentialResult as any;
    map.delete(newMap);
    return x;
  }
}

export function objReplace<T, U>(x: T, a: U, b: U): T {
  return objReplaceInternal<T, U>(x, new Set([{ src: a, dst: b }]), new Set());
}