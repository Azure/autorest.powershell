/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { keys } from './linq';

export type DeepPartial<T> = {
  [P in keyof T]?:
  T[P] extends Array<infer U> ?                                 // if it is an array
  Array<DeepPartial<U>> :                                       // then use an Array of DeepPartial
  T[P] extends ReadonlyArray<infer V> ?                         // if it's an ReadOnly Array,
  ReadonlyArray<DeepPartial<V>> :                               // use a ReadOnly of DeepPartial
  T[P] extends string | number | boolean | null | undefined ?   // if it's a primitive
  T[P] :                                                        // use that
  DeepPartial<T[P]>                                             // otherwise, it's a DeepPartial of the type.
};

/** inheriting from Initializer adds an apply<T> method to the class, allowing you to accept an object initalizer, and applying it to the class in the constructor. */
export class Initializer {
  private applyTo(source: any, target: any) {
    for (const i of keys(source)) {
      switch (typeof source[i]) {
        // case 'function':
        // don't copy functions.
        // continue;

        case 'object':
          // merge objects
          if (source[i] != null && source[i] != undefined && typeof target[i] === 'object') {
            this.applyTo(source[i], target[i]);
            continue;
          }

        default:
          // everything else just replace.
          target[i] = source[i];
          continue;
      }
    }
  }
  protected apply<T>(initializer?: Partial<T>) {
    if (initializer) {
      this.applyTo(initializer, this);
    }
  }
}
