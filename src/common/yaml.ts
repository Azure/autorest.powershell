import { safeLoad, safeDump, dump, DEFAULT_FULL_SCHEMA, DEFAULT_SAFE_SCHEMA } from 'js-yaml'

const propertyPriority = [
  "schemas",
  "name",
  "type",
  "format",
  "schema",
  "operationId",
  "path",
  "method",
  "description"
];

const propertyNegativePriority = [
  "callbacks",
  "http",
  "commands",
  "operations",
  "extensions",
  "details"
];

function sortWithPriorty(a: any, b: any): number {
  if (a == b) {
    return 0;
  }
  const ia = propertyPriority.indexOf(a);
  const ib = propertyPriority.indexOf(b);
  const na = propertyNegativePriority.indexOf(a);
  const nb = propertyNegativePriority.indexOf(b);

  const dota = `${a}`.startsWith(".");
  const dotb = `${b}`.startsWith(".");

  if (dota) {
    if (!dotb) {
      return 1;
    }
  } else {
    if (dotb) {
      return -1;
    }
  }

  if (na > -1) {
    if (nb > -1) {
      return na - nb;
    }
    return 1;
  }

  if (nb > -1) {
    return -1;
  }


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

