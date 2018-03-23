import { Property } from "#csharp/code-dom/property";
import { TypeDeclaration } from "#csharp/code-dom/type-declaration";
import { ModelClass } from "./class";
import { State } from "../generator";
import { Field } from "#csharp/code-dom/field";

export class ProxyProperty extends Property {
  constructor(protected backingFieldObject: Field, protected backingFieldProperty: Property, state: State, objectInitializer?: Partial<ProxyProperty>) {
    super(backingFieldProperty.name, backingFieldProperty.type);
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    return `
${this.visibility} ${this.type.use} ${this.name} { 
    ${this.getter} { return ${this.backingFieldObject.name}.${this.backingFieldProperty.name}; } 
    ${this.setter} { ${this.backingFieldObject.name}.${this.backingFieldProperty.name} = value; } 
}`
  }
}