export class Initializer {
  private applyTo(source: any, target: any) {
    for (const i in source) {
      switch (typeof source[i]) {
        case 'function':
          // don't copy functions.
          continue;

        case 'object':
          // merge objects
          if (source[i] != null && source[i] != undefined && typeof target[i] === 'object') {
            this.applyTo(source[i], target[i])
            continue;
          }

        default:
          // everything else just replace.
          target[i] = source[i];
          continue;
      }
    }
  }
  protected apply<T>(initializer?: Partial<T>) {
    if (initializer) {
      this.applyTo(initializer, this);
    }
  }
}