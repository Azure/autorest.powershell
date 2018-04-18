import { ModelClass } from "#csharp/lowlevel-generator/model/class";
import { ModelInterface } from "#csharp/lowlevel-generator/model/interface";
import { PropertyType } from "#csharp/lowlevel-generator/type-declaration";
import { Dictionary } from "#remodeler/common";

export interface CSharpData extends Dictionary<any> {
  typeDeclaration?: PropertyType;
  classImplementation?: ModelClass;
  interfaceImplementation?: ModelInterface;
}