import { Class } from "#csharp/code-dom/class";
import { Namespace } from "#csharp/code-dom/namespace";
import { Property } from "#csharp/code-dom/property";
import * as codemodel from "#remodeler/code-model";
import { ISendAsync } from "../clientruntime";
import { State } from "../generator";
import { OperationMethod, CallMethod, ValidationMethod } from "../operation/method";


export class ApiClass extends Class {

  protected sender: Property;
  constructor(namespace: Namespace, protected state: State, objectInitializer?: Partial<ApiClass>) {
    super(namespace, state.model.details.name);
    this.apply(objectInitializer);
    // add basics
    this.sender = this.addProperty(new Property("Sender", ISendAsync));

    // remember the namespace for this class.
    state.model.details.namespace = namespace.fullName;

    // add operations from code model
    for (const operationName in state.model.components.operations) {
      const operation = state.model.components.operations[operationName];
      if (codemodel.isHttpOperation(operation)) {

        // an operation has parameters for parameters, body, callbacks, listener and sender
        // we need to make sure that the parameters for a given operation are consistent between the operation method, the call method, and the validation method.
        // can we generate the common parameters here and just give them to the methods? (ie, can we share the instances between the methods?)
        // code-dom doesn't store references from the child to the parent, so as long as the definitions work without modification, it looks like we can.


        // we'll do that work in the OM and expose them as public properties.
        const operationMethod = new OperationMethod(this, operation, state.path('components', 'operations', operationName))
        this.addMethod(operationMethod);
        this.addMethod(new CallMethod(this, operationMethod, state.path('components', 'operations', operationName)));
        this.addMethod(new ValidationMethod(this, operationMethod, state.path('components', 'operations', operationName)));
      }
    }
  }

}

