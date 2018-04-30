import {excludeXDash} from "#remodeler/common";

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