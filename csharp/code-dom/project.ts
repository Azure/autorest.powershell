import { Namespace } from "./namespace";
import { all } from "#common/text-manipulation";
import { Initializer } from "#csharp/code-dom/initializer";

export class Project extends Initializer {
  private namespaces = new Array<Namespace>();
  constructor(objectInitializer?: Partial<Project>) {
    super();
    this.apply(objectInitializer);
  }

  public addNamespace(n: Namespace): Namespace {
    this.namespaces.push(n);
    return n;
  }

  public async writeFiles(writer: (filename: string, content: string) => Promise<void>) {
    await all(this.namespaces, ns => ns.writeFiles(writer));
  }
}