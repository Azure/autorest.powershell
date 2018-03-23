import { TypeDeclaration } from "../type-declaration";

export class Char implements TypeDeclaration {
  constructor(private choices?: Array<string>) {

  }
  get implementation(): string {
    return '';
  }

  get use(): string {
    return 'char';
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }

  valueRequired(propertyName: string): string {
    return ``
  };

  validateValue(propertyName: string): string {
    return `
${this.validateEnum(propertyName)}
    `.trim();
    ;
  }

  private validateEnum(propertyName: string): string {
    if (!this.choices) {
      return '';
    }
    return '// todo validate enum choices';
  }

  jsonserialize(propertyName: string): string {
    return `/* char json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* char json deserialize for ${propertyName} */`;
  }

}
