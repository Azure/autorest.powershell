export class Initializer {

  protected apply<T>(initializer?: Partial<T>) {
    if (initializer) {
      for (const i in (<any>initializer)) {
        //if ((<any>initializer)[i]) {
        (<any>this)[i] = (<any>initializer)[i]
        //};
      }
    }
  }
}