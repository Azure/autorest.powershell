import { Method } from "./method";
import { docComment, EOL, CommaChar, indent } from "#common/text-manipulation";
import { Class } from "./class";

export class Operator extends Method {
  constructor(name: string, objectIntializer?: Partial<Method>) {
    super(name);
    this.apply(objectIntializer);
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);
    const overrideOrNew = this.isOverride ? " override " : this.isNew ? " new " : " ";
    const stat = this.isStatic ? " static" : "";
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.accessModifier}${stat}${overrideOrNew} ${this.name}(${parameterDeclaration}) 
`.trim();
  }
}