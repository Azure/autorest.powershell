/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { Class, Namespace } from '@azure-tools/codegen-csharp';

import { State } from '../generator';
import { CallMethod, OperationMethod, ValidationMethod } from '../operation/method';
import { ParameterLocation } from '@azure-tools/codemodel-v3';

export class ApiClass extends Class {

  // protected sender: Property;
  constructor(namespace: Namespace, protected state: State, objectInitializer?: Partial<ApiClass>) {
    super(namespace, state.model.details.csharp.name);
    this.apply(objectInitializer);

    // add basics
    // this.sender = this.add(new Property("Sender", ClientRuntime.ISendAsync));

    // add operations from code model
    for (const { key: operationIndex, value: operation } of items(state.model.http.operations)) {
      // an operation has parameters for parameters, body, callbacks, listener and sender
      // we need to make sure that the parameters for a given operation are consistent between the operation method, the call method, and the validation method.
      // can we generate the common parameters here and just give them to the methods? (ie, can we share the instances between the methods?)
      // code-dom doesn't store references from the child to the parent, so as long as the definitions work without modification, it looks like we can.

      // we'll do that work in the OM and expose them as public properties.
      const operationMethod = new OperationMethod(this, operation, false, state.path('components', 'operations', operationIndex));
      this.addMethod(operationMethod);
      if ([...values(operation.parameters).select(each => each.in === ParameterLocation.Path)].length > 0) {
        // method has parameters in the path, so it could support '...ViaIdentity' 
        const identityMethod = new OperationMethod(this, operation, true, state.path('components', 'operations', operationIndex));
        identityMethod.emitCall(false);
        this.addMethod(identityMethod);

      }

      // check if this exact method is been created before (because _call and _validate have less specific parameters than the api) 
      const cm = new CallMethod(this, operationMethod, state.path('components', 'operations', operationIndex));
      if (!this.hasMethodWithSameDeclaration(cm)) {
        this.addMethod(cm);
      }

      const vm = new ValidationMethod(this, operationMethod, state.path('components', 'operations', operationIndex));
      if (!this.hasMethodWithSameDeclaration(vm)) {
        this.addMethod(vm);
      }
    }
  }
}
