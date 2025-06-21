/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

const reservedWords = new Set([
  'abstract', 'as', 'async', 'await', 'base',
  'bool', 'break', 'byte', 'case', 'catch',
  'char', 'checked', 'class', 'const', 'continue',
  'decimal', 'default', 'delegate', 'do', 'double',
  'dynamic', 'else', 'enum', 'event', 'explicit',
  'extern', 'false', 'finally', 'fixed', 'float',
  'for', 'foreach', 'from', 'global', 'goto',
  'if', 'implicit', 'in', 'int', 'interface',
  'internal', 'is', 'lock', 'long', 'namespace',
  'new', 'null', 'object', 'operator', 'out',
  'override', 'params', 'private', 'protected', 'public',
  'readonly', 'ref', 'return', 'sbyte', 'sealed',
  'short', 'sizeof', 'stackalloc', 'static', 'string',
  'struct', 'switch', 'this', 'throw', 'true',
  'try', 'typeof', 'uint', 'ulong', 'unchecked',
  'unsafe', 'ushort', 'using', 'virtual', 'void',
  'volatile', 'while', 'yield', 'var'
]);

export function getEscapedReservedName(name: string, appendValue: string): string {
  if (isReserved(name)) {
    return name + appendValue;
  }
  return name;
}

export function isReserved(name: string): boolean {
  return reservedWords.has(name.toLowerCase());
}

/**
 * Converts PascalCase or camelCase strings to kebab-case with singular words (words separated by hyphens)
 * @param input The input string in PascalCase or camelCase
 * @returns The converted string in kebab-case with singular words
 * @example
 * toKebabCase('ResourceGroups') => 'resource-group'
 * toKebabCase('virtualMachines') => 'virtual-machine'
 * toKebabCase('MyLongVariableNames') => 'my-long-variable-name'
 */
export function toKebabCase(input: string): string {
  if (!input) return input;

  /**
   * Convert a word to singular form
   * @param word The word to convert to singular
   * @returns The singular form of the word
   */
  function toSingular(word: string): string {
    if (!word) return word;

    const lowerWord = word.toLowerCase();

    // Common irregular plurals
    const irregularPlurals: { [key: string]: string } = {
      'children': 'child',
      'people': 'person',
      'men': 'man',
      'women': 'woman',
      'feet': 'foot',
      'teeth': 'tooth',
      'mice': 'mouse',
      'geese': 'goose'
    };

    if (irregularPlurals[lowerWord]) {
      return irregularPlurals[lowerWord];
    }

    // Words ending in 'ies' -> 'y'
    if (lowerWord.endsWith('ies') && lowerWord.length > 3) {
      return lowerWord.slice(0, -3) + 'y';
    }

    // Words ending in 'ves' -> 'f' or 'fe'
    if (lowerWord.endsWith('ves')) {
      if (lowerWord.endsWith('ives')) {
        return lowerWord.slice(0, -4) + 'ife';
      }
      return lowerWord.slice(0, -3) + 'f';
    }

    // Words ending in 'ses', 'xes', 'zes', 'ches', 'shes' -> remove 'es'
    if (lowerWord.endsWith('ses') || lowerWord.endsWith('xes') || lowerWord.endsWith('zes') ||
      lowerWord.endsWith('ches') || lowerWord.endsWith('shes')) {
      return lowerWord.slice(0, -2);
    }

    // Words ending in 's' but not 'ss' -> remove 's'
    if (lowerWord.endsWith('s') && !lowerWord.endsWith('ss') && lowerWord.length > 1) {
      return lowerWord.slice(0, -1);
    }

    return lowerWord;
  }

  return input
    // Insert a hyphen before any uppercase letter that follows a lowercase letter or number
    .replace(/([a-z0-9])([A-Z])/g, '$1-$2')
    // Insert a hyphen before any uppercase letter that is followed by a lowercase letter
    .replace(/([A-Z])([A-Z][a-z])/g, '$1-$2')
    // Convert to lowercase
    .toLowerCase()
    // Split by hyphens, convert each word to singular, then join back
    .split('-')
    .map(word => toSingular(word))
    .join('-');
}