/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Components, IParameter, LanguageDetails } from './components';
import { Extensions } from './extensions';
import { HttpOperation } from './http-operation';
import { ProgramaticOperationDetails, ProgrammaticOperation } from './programatic-operation';
import { Schema } from './schema';
import { DeepPartial, Dictionary } from '@microsoft.azure/codegen';


export interface CommandOperationDetails extends ProgramaticOperationDetails {
}

export interface CommandOperation extends ProgrammaticOperation {
  verb: string;
  noun: string;
  variant: string;
  category: string;
  asjob: boolean;
  callGraph: Array<HttpOperation>;
}

export class CommandOperation extends Extensions implements CommandOperation {
  public extensions = new Dictionary<any>();
  public details: LanguageDetails<CommandOperationDetails>;

  public responses = new Dictionary<Dictionary<Schema>>();

  constructor(name: string, initializer?: DeepPartial<CommandOperation>) {
    super();
    this.details = {
      default: {
        description: 'MISSING DESCRIPTION 01',
        name,
      }
    };
    this.deprecated = false;
    this.pure = true;

    this.apply(initializer);
  }
}

export interface CommandComponents extends Components<CommandOperation, IParameter> {

}

export class CommandComponents extends Components<CommandOperation, IParameter> {
}
