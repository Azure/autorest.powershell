
let indentation = "    ";

export const lineCommentPrefix = '//';
export const docCommentPrefix = '///';
export const EOL = '\n';
export const CommaChar = ', ';



declare global {
  interface Array<T> {
    joinWith(selector: (t: T) => string, separator?: string): string;
  }

  interface String {
    capitalize(): string;
  }
}

Array.prototype.joinWith = function <T>(selector: (t: T) => string, separator?: string): string {
  return (<Array<T>>this).map(selector).filter(v => v ? true : false).join(separator || CommaChar);
};

String.prototype.capitalize = function (): string {
  const result = <string>this;
  if (result) {
    return `${result.charAt(0).toUpperCase()}${result.substr(1)}`;
  }
  return result;

}

export function joinComma<T>(items: Array<T>, mapFn: (item: T) => string) {
  return join(items.map(mapFn), CommaChar);
}
export function join<T>(items: Array<T>, separator: string) {
  return items.filter(v => v ? true : false).join(separator);
}

export interface IHasName {
  name: string;
}

export function sortByName(a: IHasName, b: IHasName): number {
  return a.name < b.name ? -1 : a.name > b.name ? 1 : 0;
}

export function setIndentation(spaces: number) {
  indentation = ' '.repeat(spaces);
}

export function trimDots(content: string) {
  return content.replace(/^[\.\s]*(.*?)[\.\s]*$/g, "$1");
}

export function toMap<T>(source: Array<T>, eachFn: (item: T) => string): Map<string, Array<T>> {
  const result = new Map<string, Array<T>>();

  for (const each of source) {
    const key = eachFn(each);
    let values = result.get(key);
    if (!values) {
      values = new Array<T>();
      result.set(key, values);
    }
    values.push(each);
  }
  return result;
}
export function docComment(content: string, prefix = docCommentPrefix, factor = 0, maxLength = 120) {
  return comment(content, prefix, factor, maxLength);
}
export function comment(content: string, prefix = lineCommentPrefix, factor = 0, maxLength = 120) {
  const result = new Array<string>();
  let line = '';
  prefix = indent(prefix, factor);

  content = content.trim();
  if (content) {
    for (const word of content.replace(/\n+/g, " » ").split(/\s+/g)) {
      if (word === '»') {
        result.push(line);
        line = prefix;
        continue;
      }

      if (maxLength < line.length) {
        result.push(line);
        line = '';
      }

      if (!line) {
        line = prefix;
      }

      line += ` ${word}`;
    }
    if (line) {
      result.push(line);
    }

    return result.join(EOL);
  }
  return '';
}
export function dotCombine(prefix: string, content: string) {
  return trimDots([trimDots(prefix), trimDots(content)].join("."));
}

export function fixEOL(content: string) {
  return content.replace(/\r\n/g, EOL);
}

export function indent(content: string, factor: number = 1): string {
  const i = indentation.repeat(factor);
  content = i + fixEOL(content.trim());
  return content.split(/\n/g).join(`${EOL}${i}`);
}

export function all<T, U>(array: Array<T>, callbackfn: (value: T, index: number, array: T[]) => Promise<U>, thisArg?: any): Promise<Array<U>> {
  return Promise.all(array.map(callbackfn));
}

export function hasProperties(obj: any) {
  return Object.getOwnPropertyNames(obj).length > 0 ? true : false;
} 