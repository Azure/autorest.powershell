import { TypeDeclaration } from "./type-declaration";
import { AccessModifier, highestAccess } from "#csharp/code-dom/access-modifier";
import { Property } from "./property";
import { Interface } from "#csharp/code-dom/interface";

export class InterfaceProperty extends Property {
  public readVisibility = AccessModifier.Public;
  public writeVisibility = AccessModifier.Public;

  constructor(name: string, type: TypeDeclaration, objectInitializer?: Partial<InterfaceProperty>) {
    super(name, type);
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    const get = this.readVisibility === AccessModifier.Public ? "get;" : "";
    const set = this.writeVisibility === AccessModifier.Public ? "set;" : "";

    return `${this.type.use} ${this.name} { ${get} ${set} }`
  }
}