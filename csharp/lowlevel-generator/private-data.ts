import { ModelClass } from "#csharp/lowlevel-generator/model/class";
import { ModelInterface } from "#csharp/lowlevel-generator/model/interface";
import { TypeDeclaration } from "#csharp/lowlevel-generator/type-declaration";
import { Dictionary } from "#remodeler/common";

export interface CSharpData extends Dictionary<any> {
  typeDeclaration?: TypeDeclaration;
  classImplementation?: ModelClass;
  interfaceImplementation?: ModelInterface;
}