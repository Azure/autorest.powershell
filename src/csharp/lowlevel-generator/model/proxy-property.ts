import { Field } from '#csharp/code-dom/field';
import { Property, ImplementedProperty } from '#csharp/code-dom/property';
import { State } from '../generator';
import { Statements } from '#csharp/code-dom/statements/statement';

export class ProxyProperty extends ImplementedProperty {
  constructor(protected backingFieldObject: Field, protected backingFieldProperty: Property, state: State, objectInitializer?: Partial<ProxyProperty>) {
    super(backingFieldProperty.name, backingFieldProperty.type);
    this.apply(objectInitializer);
    this.getterStatements = new Statements(`return ${this.backingFieldObject.name}.${this.backingFieldProperty.name};`);
    this.setterStatements = new Statements(`${this.backingFieldObject.name}.${this.backingFieldProperty.name} = value;`);
  }
}