import { Property, BackedProperty } from "#csharp/code-dom/property";
import { TypeDeclaration } from "#csharp/code-dom/type-declaration";
import { IParameter } from "#common/code-model/components";

export class CmdletParameter extends BackedProperty {
  public parameterDefinition: IParameter;
  constructor(name: string, type: TypeDeclaration, parameterDefinition: IParameter, objectInitializer?: Partial<CmdletParameter>) {
    super(name, type);
    this.parameterDefinition = parameterDefinition;
    this.apply(objectInitializer);
  }
}