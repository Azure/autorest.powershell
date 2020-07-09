/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Components, IParameter, LanguageDetails } from './components';
import { Extensions } from './extensions';
import { HttpOperation } from './http-operation';
import { ProgramaticOperationDetails, ProgrammaticOperation } from './programatic-operation';
import { Schema, VirtualProperty } from './schema';
import { DeepPartial } from '@azure-tools/codegen';

import { uid } from './uid';
import { Dictionary } from '@azure-tools/linq';

export interface VirtualParameters {
  body: Array<VirtualParameter>;
  operation: Array<VirtualParameter>;
}

export interface CommandOperationDetails extends ProgramaticOperationDetails {
  virtualParameters?: VirtualParameters;
}

export interface CompleterInfo {
  script: string;
  name: string;
  description: string;
}

export interface CommandOperation extends ProgrammaticOperation {
  alias: Array<string>;
  verb: string;
  noun: string;
  variant: string;
  category: string;
  asjob: boolean;
  callGraph: Array<HttpOperation>;
}

export interface VirtualParameter {
  name: string;
  description: string;
  required: boolean;
  schema: Schema;
  nameOptions: Array<string>;
  origin: VirtualProperty | IParameter;
  alias: Array<string>;
  completerInfo?: CompleterInfo;
}

export class CommandOperation extends Extensions implements CommandOperation {
  public extensions = new Dictionary<any>();
  public details: LanguageDetails<CommandOperationDetails>;

  public responses = new Dictionary<Dictionary<Schema>>();

  constructor(name: string, initializer?: DeepPartial<CommandOperation>) {
    super();
    this.details = {
      default: {
        uid: `command-operation:${uid()}`,
        description: initializer?.description || '',
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
