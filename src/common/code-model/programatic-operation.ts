import { ImplementationDetails, IOperation, IOperationBase, IParameter, LanguageDetails } from '#common/code-model/components';
import { Extensions } from '#common/code-model/extensions';
import { Schema } from '#common/code-model/schema';
import { Dictionary } from '#common/dictionary';

export interface ProgrammaticOperation extends IOperation<IParameter> {
  responses: Dictionary<Dictionary<Schema>>;
  pure: boolean; // side-effect free? May be helpful for deciding how to generate code.
}


export interface IntrinsicOperation extends ProgrammaticOperation {

}

export class IntrinsicOperation extends Extensions implements IntrinsicOperation {
  public details: LanguageDetails<ProgramaticOperationDetails>;

  public responses = new Dictionary<Dictionary<Schema>>();
  public operationType: 'IntrinsicOperation' = 'IntrinsicOperation';

  constructor(name: string, deprecated: boolean, pure: boolean, initializer?: Partial<IntrinsicOperation>) {
    super();
    this.details = {
      default: {
        description: 'MISSING DESCRIPTION 07',
        name,
      }
    };
    this.deprecated = deprecated;
    this.pure = pure;

    this.apply(initializer);
  }
}

export interface ProgramaticOperationDetails extends ImplementationDetails {
}
