import { Namespace } from "./namespace";
import { all } from "#common/text-manipulation";

export class Project {
  private namespaces = new Array<Namespace>();
  constructor() {
  }

  public addNamespace(n: Namespace): Namespace {
    this.namespaces.push(n);
    return n;
  }

  public async writeFiles(writer: (filename: string, content: string) => Promise<void>) {
    await all(this.namespaces, ns => ns.writeFiles(writer));
  }
}