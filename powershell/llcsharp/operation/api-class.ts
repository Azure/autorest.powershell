/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { Class, Namespace } from '@azure-tools/codegen-csharp';

import { State, NewState } from '../generator';
import { CallMethod, OperationMethod, NewOperationMethod, ValidationMethod, NewCallMethod, NewValidationMethod } from '../operation/method';
import { ParameterLocation } from '@azure-tools/codemodel-v3';
import { DeepPartial } from '@azure-tools/codegen';

export class ApiClass extends Class {

  // protected sender: Property;
  constructor(namespace: Namespace, protected state: State | NewState, objectInitializer?: DeepPartial<ApiClass>) {
    super(namespace, (state instanceof NewState) ? state.model.language.csharp?.name || '' : state.model.details.csharp.name);
    this.apply(objectInitializer);

    // add basics
    // this.sender = this.add(new Property("Sender", ClientRuntime.ISendAsync));

    // add operations from code model
    if (!(state instanceof NewState)) {
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
    } else {
      // todo
      for (const operationGroup of state.model.operationGroups) {
        for (const operation of operationGroup.operations) {
          const operationMethod = new NewOperationMethod(this, operation, false, state);
          this.addMethod(operationMethod);
          // Compare with m3, m4 operation has one more parameter called '$host'. We should skip it
          const parameters = operation.parameters?.filter((param) => param.language.default.serializedName !== '$host');
          if ([...values(parameters).select(each => each.protocol.http?.in === ParameterLocation.Path)].length > 0) {
            // method has parameters in the path, so it could support '...ViaIdentity' 
            const identityMethod = new NewOperationMethod(this, operation, true, state);
            identityMethod.emitCall(false);
            this.addMethod(identityMethod);

          }

          // check if this exact method is been created before (because _call and _validate have less specific parameters than the api) 
          const cm = new NewCallMethod(this, operationMethod, state);
          if (!this.hasMethodWithSameDeclaration(cm)) {
            this.addMethod(cm);
          }

          const vm = new NewValidationMethod(this, operationMethod, state);
          if (!this.hasMethodWithSameDeclaration(vm)) {
            this.addMethod(vm);
          }
        }
      }
    }
  }
}
