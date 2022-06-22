/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

export function pwshHeaderText(type: string, definitions: any): string {
  switch (type.toLowerCase()) {

    case 'microsoft_mit_no_version':
      return `${definitions.microsoft}\n${definitions.mit}\n${definitions['no-version']}\n${definitions.warning}`;

    case 'microsoft_apache_no_version':
      return `${definitions.microsoft}\n${definitions.apache}\n${definitions['no-version']}${definitions.warning}`;

    case 'microsoft_apache_no_codegen':
      return `${definitions.microsoft}\n${definitions.mit}\n${definitions['no-version']}`;

    case 'none':
      return '';

    case 'microsoft_mit_small_no_codegen':
      return `${definitions.microsoft}\n${definitions['mit-small']}\n${definitions['no-version']}`;

    default:
      // if none is matched, we will assume type is the license content
      return `${type}`;
  }
}