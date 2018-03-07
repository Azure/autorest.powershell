import { TypeDeclaration } from "#lowlevel-csharp/code-dom/type-declaration";

export class Char implements TypeDeclaration {
  constructor(private choices?: Array<string>) {

  }
  get implementation(): string {
    return '';
  }

  get use(): string {
    return 'char';
  }

  valueRequired(propertyName: string): string {
    return ``
  };

  validation(propertyName: string): string {
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
}
