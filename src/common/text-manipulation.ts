import { Dictionary, values } from '#common/dictionary';
import { Text, TextPossibilities } from '#common/file-generator';

let indentation = '    ';

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
    uncapitalize(): string;
    slim(): string;
  }
}

/** joins an array by passing thru a selector and uses the separator string (defaults to comma) */
Array.prototype.joinWith = function <T>(selector: (t: T) => string, separator?: string): string {
  return (<Array<T>>this).map(selector).filter(v => v ? true : false).join(separator || CommaChar);
};

String.prototype.capitalize = function (): string {
  const result = <string>this;
  return result ? `${result.charAt(0).toUpperCase()}${result.substr(1)}` : result;
};
String.prototype.uncapitalize = function (): string {
  const result = <string>this;
  return result ? `${result.charAt(0).toLowerCase()}${result.substr(1)}` : result;
};
/** Trims the string and removes multi leading spaces? */
String.prototype.slim = function (): string {
  return this.trim().replace(/([^ ])  +/g, '$1 ');
};

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
  return content.replace(/^[\.\s]*(.*?)[\.\s]*$/g, '$1');
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
    for (const word of content.replace(/\n+/g, ' » ').split(/\s+/g)) {
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
  return trimDots([trimDots(prefix), trimDots(content)].join('.'));
}

export function fixEOL(content: string) {
  return content.replace(/\r\n/g, EOL);
}

export function map<T, U>(dictionary: Dictionary<T>, callbackfn: (key: string, value: T) => U, thisArg?: any): Array<U> {
  return Object.getOwnPropertyNames(dictionary).map((key) => callbackfn(key, dictionary[key]));
}

export function ToMap<T>(dictionary: Dictionary<T>): Map<string, T> {
  const result = new Map<string, T>();
  Object.getOwnPropertyNames(dictionary).map(key => result.set(key, dictionary[key]));
  return result;
}

export function selectMany<T>(multiArray: Array<T>[]): Array<T> {
  const result = new Array<T>();
  multiArray.map(v => result.push(...v));
  return result;
}

export function indent(content: string, factor: number = 1): string {
  const i = indentation.repeat(factor);
  content = i + fixEOL(content.trim());
  return content.split(/\n/g).join(`${EOL}${i}`);
}

export function all<T, U>(array: Array<T>, callbackfn: (value: T, index: number, array: Array<T>) => Promise<U>, thisArg?: any): Promise<Array<U>> {
  return Promise.all(array.map(callbackfn));
}

export function hasProperties(obj: any) {
  return Object.getOwnPropertyNames(obj).length > 0 ? true : false;
}

export function deconstruct(identifier: string | Array<string>): Array<string> {
  if (Array.isArray(identifier)) {
    return [...values(identifier).linq.selectMany(deconstruct)];
  }
  return identifier.replace(/([a-z]+)([A-Z])/g, '$1 $2').replace(/(\d+)([a-z|A-Z]+)/g, '$1 $2').split(/[\W|_]+/);
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
const magnitude = ['thousand', 'million', 'billion', 'trillion', 'quadrillion', 'quintillion', 'septillion', 'octillion'];
const magvalues = [10 ** 3, 10 ** 6, 10 ** 9, 10 ** 12, 10 ** 15, 10 ** 18, 10 ** 21, 10 ** 24, 10 ** 27];

export function* convert(num: number): Iterable<string> {
  if (!num) {
    yield 'zero';
    return;
  }
  if (num > 1e+30) {
    yield 'lots';
    return;
  }

  if (num > 999) {
    for (let i = magvalues.length; i > -1; i--) {
      const c = magvalues[i];
      if (num > c) {
        yield* convert(Math.floor(num / c));
        yield magnitude[i];
        num = num % c;

      }
    }
  }
  if (num > 99) {
    yield ones[Math.floor(num / 100)];
    yield `hundred`;
    num %= 100;
  }
  if (num > 19) {
    yield tens[Math.floor(num / 10)];
    num %= 10;
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
      return identifier[0].uncapitalize();
  }
  return `${identifier[0].uncapitalize()}${pascalCase(identifier.slice(1))}`;
}

export function pascalCase(identifier: Array<string>): string {
  return identifier.map(each => each.capitalize()).join('');
}

export function escapeString(text: string | undefined): string {
  if (text) {
    const q = JSON.stringify(text);
    return q.substr(1, q.length - 2);
  }
  return '';
}

/** emits c# to get the name of a property - uses nameof when it can, and uses a literal when it's an array value. */
export function fixPropertyName(text: string): string {
  if (text.indexOf('[') > -1) {
    return `$"${text.replace(/\[(.*)\]/, '[{$1}]')}"`;
  }
  return `nameof(${text})`;
}

export function setRegion(source: string, region: string, content: TextPossibilities, prepend = true) {
  const ct = new Text(content).text.replace(/[\r?\n]/g, '«').replace(/^«*/, '').replace(/«*$/, '');

  source = source.replace(/[\r?\n]/g, '«');

  const rx = new RegExp(`«(\\s*#\\s*region\\s*${region})\\s*«.*?(«\\s*#\\s*endregion\\s*«?)`, 'g');
  if (rx.test(source)) {
    if (ct.length > 0) {
      source = source.replace(rx, `«$1«${ct}$2`);
    } else {
      source = source.replace(rx, '');
    }
  } else {
    if (ct.length > 0) {
      const text = `«# region ${region}«${ct}«# endregion«`;
      source = prepend ? text + source : source + text;
    }
  }
  source = source.replace(/«««*/g, '««').replace(/«/g, '\n');
  return source;
}
