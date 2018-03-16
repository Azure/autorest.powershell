import { Method } from "./method";
import { docComment, EOL, CommaChar, indent } from "#common/text-manipulation";
import { Class } from "./class";

export class Constructor extends Method {
  constructor(protected containingClass: Class, objectIntializer?: Partial<Method>) {
    super(containingClass.name);
    this.apply(objectIntializer);
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);

    return ` 
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.accessModifier} ${this.name}(${parameterDeclaration})
`.trim();
  }
}