/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { DeepPartial } from '@azure-tools/codegen';
import { Dictionary } from '@azure-tools/linq';
import { components, Schema } from '@azure-tools/codemodel-v3';
import { Schema as NewSchema } from '@azure-tools/codemodel';


export class IParameterPwsh extends components.IParameter {
  constructor(public name: string, public schema: Schema, public newSchema: NewSchema, initializer?: DeepPartial<components.IParameter>) {
    super(name, schema);
  }
}
// export class IParameter extends Extensions {
//   constructor(public name: string, public schema: Schema, initializer?: DeepPartial<IParameter>) {
//     super();
//     this.description = '';
//     this.deprecated = false;
//     this.required = false;
//     this.details = {
//       default: {
//         uid: `parameter:${uid()}`,
//         description: this.description,
//         name,
//       }
//     };
//     this.allowEmptyValue = false;
//     this.apply(initializer);
//   }
// }

