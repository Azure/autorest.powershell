import { TypeDeclaration } from "#csharp/code-dom/type-declaration";

export class String implements TypeDeclaration {
  constructor(private minLength?: number, private maxLength?: number, private pattern?: string, private choices?: Array<string>) {

  }
  get implementation(): string {
    return '';
  }
  get use(): string {
    return 'string';
  }

  valueRequired(propertyName: string): string {
    return `
if( $VALUE == null ) {
  $ERROR;
}`.trim();
  };

  validation(propertyName: string): string {
    return `
${this.validateMinLength(propertyName)}
${this.validateMaxLength(propertyName)}
${this.validateRegex(propertyName)}
${this.validateEnum(propertyName)}
    `.trim();
    ;
  }

  private validateMinLength(propertyName: string): string {
    if (!this.minLength) {
      return '';
    }
    return `
if( ${propertyName}.Length < ${this.minLength}) {
  throw new Exception("${propertyName} length is less than ${this.minLength}");
}`.trim();
  }
  private validateMaxLength(propertyName: string): string {
    if (!this.minLength) {
      return '';
    }
    return `
if( ${propertyName}.Length > ${this.maxLength}) {
  throw new Exception("${propertyName} length is greatere than ${this.maxLength}");
}`.trim();
  }
  private validateRegex(propertyName: string): string {
    if (!this.pattern) {
      return '';
    }
    return `
if( !System.Text.RegularExpressions.Regex.Match(${propertyName}, "${this.pattern}") ) {}
  throw new Exception("${propertyName} does not validate against patter '${this.pattern}'");
}`.trim();
  }
  private validateEnum(propertyName: string): string {
    if (!this.choices) {
      return '';
    }
    return '// todo validate enum choices';
  }
}
