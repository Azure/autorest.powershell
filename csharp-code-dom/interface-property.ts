import { TypeDeclaration } from "./type-declaration";
import { AccessModifier, highestAccess } from "#csharp-code-dom/access-modifier";
import { Property } from "./property";

export class InterfaceProperty extends Property {
  public readVisibility = AccessModifier.Public;
  public writeVisibility = AccessModifier.Public;

  constructor(name: string, type: TypeDeclaration) {
    super(name, type);
  }

  public get declaration(): string {
    const get = this.readVisibility === AccessModifier.Public ? "get;" : "";
    const set = this.writeVisibility === AccessModifier.Public ? "set;" : "";

    return `${this.type.use} ${this.name} { ${get} ${set} };`
  }
}