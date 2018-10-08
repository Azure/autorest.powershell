/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { ImplementationDetails, IOperation, IParameter, LanguageDetails } from './components';
import { Extensions } from './extensions';
import { Schema } from './schema';
import { Dictionary } from '@microsoft.azure/codegen';

export interface ProgrammaticOperation extends IOperation<IParameter> {
  responses: Dictionary<Dictionary<Schema>>;
  pure: boolean; // side-effect free? May be helpful for deciding how to generate code.
}

export interface IntrinsicOperation extends ProgrammaticOperation {

}

export class IntrinsicOperation extends Extensions implements IntrinsicOperation {
  public details: LanguageDetails<ProgramaticOperationDetails>;

  public responses = new Dictionary<Dictionary<Schema>>();
  public operationType: 'IntrinsicOperation' = 'IntrinsicOperation';

  constructor(name: string, deprecated: boolean, pure: boolean, initializer?: Partial<IntrinsicOperation>) {
    super();
    this.details = {
      default: {
        description: 'MISSING DESCRIPTION 07',
        name,
      }
    };
    this.deprecated = deprecated;
    this.pure = pure;

    this.apply(initializer);
  }
}

export interface ProgramaticOperationDetails extends ImplementationDetails {
}
