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

    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.new}${this.access} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.async} ${this.name}(${parameterDeclaration}) 
`.slim();
  }
}