export class Using {
  constructor(private namespace: string) {

  }

  public get implementation(): string {
    return `using ${this.namespace};`
  }
}