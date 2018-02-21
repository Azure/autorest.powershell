import { safeLoad, safeDump, dump, DEFAULT_FULL_SCHEMA, DEFAULT_SAFE_SCHEMA } from "js-yaml"

const propertyPriority = [
  "schemas",
  "name",
  "type",
  "format",
  "schema",
  "description"
];

function sortWithPriorty(a: any, b: any): number {
  if (a == b) {
    return 0;
  }
  const ia = propertyPriority.indexOf(a);
  const ib = propertyPriority.indexOf(b);
  if (ia != -1) {
    return ib != -1 ? ia - ib : -1;
  }

  return ib != -1 || a > b ? 1 : a < b ? -1 : 0;
}

export async function deserialize<T>(text: string, filename: string) {
  return <T>safeLoad(await text, {
    filename: filename,
  });
}

export function serialize<T>(model: T): string {
  return dump(model, { sortKeys: sortWithPriorty, schema: DEFAULT_SAFE_SCHEMA, skipInvalid: true });
}

