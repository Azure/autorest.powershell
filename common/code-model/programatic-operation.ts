import { Dictionary } from '#common/dictionary';
import { Schema } from '#common/code-model/schema';
import { Extensions } from '#common/code-model/extensions';
import { Details, IOperation, IOperationBase, IParameter } from '#common/code-model/components';

export interface ProgrammaticOperation extends IOperation<IParameter> {
  responses: Dictionary<Dictionary<Schema>>;
  pure: boolean; // side-effect free? May be helpful for deciding how to generate code.
}

export function isIntrinsicOperation(operation: IOperationBase): operation is IntrinsicOperation {
  if ((<any>operation).operationType && (<any>operation).operationType === 'IntrinsicOperation') {
    return true;
  }
  return false;
}

export interface IntrinsicOperation extends ProgrammaticOperation {
  operationType: "IntrinsicOperation";
}

export class IntrinsicOperation extends Extensions implements IntrinsicOperation {
  details: ProgramaticOperationDetails;

  responses = new Dictionary<Dictionary<Schema>>();
  operationType: "IntrinsicOperation" = "IntrinsicOperation";

  constructor(name: string, deprecated: boolean, pure: boolean, initializer?: Partial<IntrinsicOperation>) {
    super();
    this.details = {
      name: name,
    };
    this.deprecated = deprecated;
    this.pure = pure;

    this.apply(initializer);
  }
}

export interface ProgramaticOperationDetails extends Details {
}