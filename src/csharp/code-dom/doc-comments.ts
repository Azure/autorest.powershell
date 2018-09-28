/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { EOL } from '#common/text-manipulation';

export const summary = (text: string): string => xmlize('summary', text);

export function xmlize(element: string, text: string): string {
  if (text) {
    if (text.length < 80 && text.indexOf(EOL) === -1) {
      return `<${element}>${text.trim()}</${element}>`;
    }
    return `
<${element}>
${text}
</${element}>
`.trim();
  }
  return text;
}
