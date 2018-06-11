import { Components, IOperationBase, IParameter, LanguageDetails } from '#common/code-model/components';
import { Extensions } from '#common/code-model/extensions';
import { ProgramaticOperationDetails, ProgrammaticOperation } from '#common/code-model/programatic-operation';
import { Schema } from '#common/code-model/schema';
import { Dictionary } from '#common/dictionary';
import { HttpOperation } from '#common/code-model/http-operation';

export interface CommandOperationDetails  extends ProgramaticOperationDetails {
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

  constructor(name: string, initializer?: Partial<CommandOperation>) {
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
