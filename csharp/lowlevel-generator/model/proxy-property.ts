import { Property } from "#csharp/code-dom/property";
import { TypeDeclaration } from "#csharp/code-dom/type-declaration";
import { ModelClass } from "./class";
import { State } from "../generator";
import { BackingField } from "./backing-field";

export class ProxyProperty extends Property {
  protected constructor(name: string, type: TypeDeclaration, protected backingField: BackingField, protected property: Property) {
    super(name, type);
  }

  public static async create(parent: ModelClass, backingField: BackingField, property: Property, state: State): Promise<ProxyProperty> {
    const pp = new ProxyProperty(property.name, property.type, backingField, property);
    parent.addProperty(pp);
    return pp;
  }

  public get declaration(): string {
    return `
${this.visibility} ${this.type.use} ${this.name} { 
    ${this.getter} { return ${this.backingField.name}.${this.property.name}; } 
    ${this.setter} { ${this.backingField.name}.${this.property.name} = value; } 
}`
  }
}