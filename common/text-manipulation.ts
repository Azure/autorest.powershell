
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

export function deconstruct(identifier: string): Array<string> {
  return identifier.replace(/([a-z]+)([A-Z])/g, "$1 $2").replace(/(\d+)([a-z|A-Z]+)/g, "$1 $2").split(/[\W|_]+/);
}

export function fixLeadingNumber(identifier: Array<string>): Array<string> {
  if (identifier.length > 0 && /^\d+/.exec(identifier[0])) {
    return [...convert(parseInt(identifier[0])), ...identifier.slice(1)];
  }
  return identifier;
}

const ones = ['', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];
const teens = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];
const tens = ['', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];
const magnitude = ['thousand', 'million', 'billion', 'trillion', 'quadrillion', 'quintillion', 'septillion', 'octillion']
const magvalues = [10 ** 3, 10 ** 6, 10 ** 9, 10 ** 12, 10 ** 15, 10 ** 18, 10 ** 21, 10 ** 24, 10 ** 27];

export function* convert(num: number): Iterable<string> {
  if (!num) {
    yield 'zero';
    return;
  }
  if (num > 1e+30) {
    yield 'lots';
    return;;
  }

  if (num > 999) {
    for (let i = magvalues.length; i > -1; i--) {
      const c = magvalues[i];
      if (num > c) {
        yield* convert(Math.floor(num / c))
        yield magnitude[i];
        num = num % c

      }
    }
  }
  if (num > 99) {
    yield ones[Math.floor(num / 100)];
    yield `hundred`;
    num %= 100
  }
  if (num > 19) {
    yield tens[Math.floor(num / 10)];
    num %= 10
  }
  if (num) {
    yield ones[num];
  }
}

export function camelCase(identifier: Array<string>): string {
  switch (identifier.length) {
    case 0:
      return '';
    case 1:
      return identifier[0];
  }
  return `${identifier[0]}${pascalCase(identifier.slice(1))}`;
}

export function pascalCase(identifier: Array<string>): string {
  return identifier.map(each => each.capitalize()).join("");
}