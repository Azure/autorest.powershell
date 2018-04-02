import { Field } from "#csharp/code-dom/field";
import { Property } from "#csharp/code-dom/property";
import { State } from "../generator";

export class ProxyProperty extends Property {
  constructor(protected backingFieldObject: Field, protected backingFieldProperty: Property, state: State, objectInitializer?: Partial<ProxyProperty>) {
    super(backingFieldProperty.name, backingFieldProperty.type);
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    return `
${this.new} ${this.visibility} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.type.use} ${this.name}
{
    ${this.getter} { return ${this.backingFieldObject.name}.${this.backingFieldProperty.name}; }
    ${this.setter} { ${this.backingFieldObject.name}.${this.backingFieldProperty.name} = value; }
}`.slim();
  }
}