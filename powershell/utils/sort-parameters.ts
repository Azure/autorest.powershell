import { Parameter } from '@azure-tools/codemodel';

export function sortPathParameters(path: string | undefined, params: Array<Parameter> | undefined): Array<Parameter> | undefined {
  if (path && params) {
    const map: Map<string, number> = new Map<string, number>();
    for (let i = 0; i < params.length; i++) {
      if (params[i].language.default.serializedName) {
        map.set(`{${params[i].language.default.serializedName}}`, i);
      }
    }

    let index = 0;
    const paths = path.split('/');
    for (let i = 0; i < params.length; i++) {
      if (map.has(paths[i])) {
        // eslint-disable-next-line @typescript-eslint/no-non-null-assertion
        swap(params, index, map.get(paths[i])!);
        map.set(paths[i], index++);
      }
    }
  }
  return params;
}

function swap(params: Array<Parameter>, left: number, right: number) {
  if (!params || left === right) {
    return;
  }
  const tmp = params[left];
  params[left] = params[right];
  params[right] = tmp;
}