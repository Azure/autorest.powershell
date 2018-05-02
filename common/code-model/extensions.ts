import { Dictionary } from '#common/dictionary';
import { Initializer } from '#common/initializer';

export class Extensions extends Initializer implements Extensions {
  extensions = new Dictionary<any>();

  constructor() {
    super();
  }
}

export interface Extensions {
  /** additional metadata extensions */
  extensions: Dictionary<any>;
}