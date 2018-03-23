import { error } from "./helpers";

export interface Type {
  readonly name: string | null;
}

export function typeEmpty(): Type {
  return { name: null };
}
export function typeNominal(name: string): Type {
  return { name: name };
}
export function typeUnion(a: Type, b: Type): Type {
  return (
    a.name === b.name ? a :
      a.name === null ? b :
        b.name === null ? a :
          error(`cannot build that union type ('${a.name}' and '${b.name}')`));
}

export function typeEquals(a: Type, b: Type): boolean {
  return a.name === b.name;
}