/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { Class, Namespace } from '@azure-tools/codegen-csharp';

import { State } from '../generator';
import { OperationMethod, CallMethod, ValidationMethod, ResolveResponseType } from '../operation/method';
import { ParameterLocation } from '@azure-tools/codemodel-v3';
import { DeepPartial } from '@azure-tools/codegen';
import { hasValidBodyParameters } from '../../utils/http-operation';
import { EnhancedTypeDeclaration } from '../exports';

export class ApiClass extends Class {

  // protected sender: Property;
  constructor(namespace: Namespace, protected state: State, objectInitializer?: DeepPartial<ApiClass>) {
    super(namespace, state.model.language.csharp?.name || '');
    this.apply(objectInitializer);

    // add basics
    // this.sender = this.add(new Property("Sender", ClientRuntime.ISendAsync));

    // add operations from code model

    // todo
    for (const operationGroup of state.model.operationGroups) {
      for (const operation of operationGroup.operations) {
        const responseType: EnhancedTypeDeclaration | undefined = ResolveResponseType(undefined, operation, state);
        const operationMethod = new OperationMethod(this, operation, false, state);
        const operationMethodWithResult = new OperationMethod(this, operation, false, state, false, true);
        this.addMethod(operationMethod);
        if (responseType) {
          this.addMethod(operationMethodWithResult);
        }
        // Compare with m3, m4 operation has one more parameter called '$host'. We should skip it
        const parameters = operation.parameters?.filter((param) => param.language.default.serializedName !== '$host');
        if ([...values(parameters).select(each => each.protocol.http?.in === ParameterLocation.Path)].length > 0) {
          // method has parameters in the path, so it could support '...ViaIdentity' 
          const identityMethod = new OperationMethod(this, operation, true, state);
          identityMethod.emitCall(false);
          this.addMethod(identityMethod);
          if (responseType) {
            const identityMethodWithResult = new OperationMethod(this, operation, true, state, false, true);
            this.addMethod(identityMethodWithResult);
            identityMethodWithResult.emitCall(false, true);
          }
        }

        if (this.state.project.supportJsonInput && hasValidBodyParameters(operation)) {
          const jsonMethod = new OperationMethod(this, operation, false, state, true);
          jsonMethod.emitCall(false);
          this.addMethod(jsonMethod);
          if (responseType) {
            const jsonMethodWithResult = new OperationMethod(this, operation, false, state, true, true);
            this.addMethod(jsonMethodWithResult);
            jsonMethodWithResult.emitCall(false, true);
          }
        }

        // check if this exact method is been created before (because _call and _validate have less specific parameters than the api) 
        const cm = new CallMethod(this, operationMethod, state);
        if (!this.hasMethodWithSameDeclaration(cm)) {
          this.addMethod(cm);
          if (responseType) {
            const cmWithResult = new CallMethod(this, operationMethodWithResult, state, undefined, true);
            this.addMethod(cmWithResult);
          }
        }

        const vm = new ValidationMethod(this, operationMethod, state);
        if (!this.hasMethodWithSameDeclaration(vm)) {
          this.addMethod(vm);
        }
      }

    }
  }
}