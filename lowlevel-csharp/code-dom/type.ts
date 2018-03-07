import { Interface } from "./interface";
import { Method } from "./method";
import { Property } from "./property";
import { TypeDeclaration } from "./type-declaration";
import { AccessModifier } from "#lowlevel-csharp/code-dom/access-modifier";

export class Type implements TypeDeclaration {
  public description: string = "";
  public methods = new Array<Method>();
  public properties = new Array<Property>();
  public accessModifier = AccessModifier.Public;

  constructor(public name: string, public interfaces = new Array<Interface>(), public genericParameters = new Array<string>(), public where?: string) {

  }

  public get allProperties(): Array<Property> {
    const result = new Array<Property>(...this.properties);
    for (const parent of this.interfaces) {
      result.push(...parent.allProperties);
    }
    return result;
  }

  public get genericDeclaration(): string {
    return this.genericParameters.length == 0 ? '' : `<${this.genericParameters.join(',')}>`;
  }

  public get fullName(): string {
    return `${this.name}${this.genericDeclaration}`;
  }

  public get use(): string {
    return '/*USE*/';
  }

  public get implementation(): string {
    return '/*IMPL*/';
  }

  public validation(propertyName: string): string {
    return '/*VALIDATION*/';
  }

  public addProperty(property: Property): Property {
    this.properties.push(property);
    return property;
  }
  public addMethod(method: Method): Method {
    this.methods.push(method);
    return method;
  }

}
