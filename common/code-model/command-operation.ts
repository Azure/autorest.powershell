import { Components, IOperationBase, IParameter } from "#common/code-model/components";
import { Extensions } from "#common/code-model/extensions";
import { Dictionary } from "#common/dictionary";
import { Schema } from "#common/code-model/schema";
import { ProgramaticOperationDetails, ProgrammaticOperation } from "#common/code-model/programatic-operation";

export function isCommandOperation(operation: IOperationBase): operation is CommandOperation {
  if ((<any>operation).operationType && (<any>operation).operationType === 'CommandOperation') {
    return true;
  }
  return false;
}

export interface CommandOperation extends ProgrammaticOperation {
  operationType: "CommandOperation";
  verb: string;
  noun: string;
  variant: string;
  asjob: boolean;
  "call-graph": Array<string>;
}

export class CommandOperation extends Extensions implements CommandOperation {
  extensions = new Dictionary<any>();
  details: ProgramaticOperationDetails;

  responses = new Dictionary<Dictionary<Schema>>();
  operationType: "CommandOperation" = "CommandOperation";

  constructor(name: string, initializer?: Partial<CommandOperation>) {
    super();
    this.details = {
      name: name,
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