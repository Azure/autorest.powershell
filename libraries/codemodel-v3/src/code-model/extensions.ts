/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Initializer, Dictionary } from '@microsoft.azure/codegen';

export class Extensions extends Initializer implements Extensions {
  extensions = new Dictionary<any>();

  constructor() {
    super();
  }
}

export interface Extensions {
  /** additional metadata extensions */
  extensions: Dictionary<any>;
}
