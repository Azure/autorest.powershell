/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { codeModelSchema, CodeModel, Schema, ObjectSchema, GroupSchema, isObjectSchema, SchemaType, GroupProperty, ParameterLocation, Operation, Parameter, VirtualParameter, getAllProperties, ImplementationLocation, OperationGroup, Request, SchemaContext } from '@azure-tools/codemodel';
import { CommandComponents } from '@azure-tools/codemodel-v3/dist/code-model/command-operation';
import { DeepPartial } from '@azure-tools/codegen';

export class PwshModel extends CodeModel {
  public commands = new CommandComponents();
  constructor(title: string, sourceTracking = false, initializer?: DeepPartial<PwshModel>) {
    super(title, sourceTracking);

    this.apply(initializer);
  }
}