import { TypeDeclaration } from "./type-declaration";
import { Access, highestAccess } from "#csharp/code-dom/access-modifier";
import { Property } from "./property";
import { Interface } from "#csharp/code-dom/interface";

export class InterfaceProperty extends Property {
  public getAccess = Access.Public;
  public setAccess = Access.Public;

  constructor(name: string, type: TypeDeclaration, objectInitializer?: Partial<InterfaceProperty>) {
    super(name, type);
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    const get = this.getAccess === Access.Public ? "get;" : "";
    const set = this.setAccess === Access.Public ? "set;" : "";

    return `${this.type.use} ${this.name} { ${get} ${set} }`
  }
}