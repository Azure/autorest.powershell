import { TypeDeclaration } from "../type-declaration";

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
if( $VALUE == null ) 
{
  $ERROR;
}`.trim();
  };

  validateValue(propertyName: string): string {
    return `
${this.validateMinLength(propertyName)}
${this.validateMaxLength(propertyName)}
${this.validateRegex(propertyName)}
${this.validateEnum(propertyName)}
    `.trim();
    ;
  }


  public validatePresence(propertyName: string): string {
    return `await listener.AssertNotNull(nameof(${propertyName}),${propertyName});`.trim();
  }

  private validateMinLength(propertyName: string): string {
    if (!this.minLength) {
      return '';
    }
    return `await listener.AssertMinimumLength(nameof(${propertyName}),${propertyName},${this.minLength});`
  }
  private validateMaxLength(propertyName: string): string {
    if (!this.minLength) {
      return '';
    }
    return `await listener.AssertMaximumLength(nameof(${propertyName}),${propertyName},${this.minLength});`
  }
  private validateRegex(propertyName: string): string {
    if (!this.pattern) {
      return '';
    }
    return `await listener.AssertRegEx(nameof(${propertyName}),${propertyName},@"${this.pattern}");`
  }
  private validateEnum(propertyName: string): string {
    if (!this.choices) {
      return '';
    }
    return `await listener.AssertEnum(nameof(${propertyName}),${propertyName},${this.choices.joinWith((v) => `@"${v}"`)});`
  }
  jsonserialize(propertyName: string): string {
    return `/* string json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* string json deserialize for ${propertyName} */`;
  }
}


export class NullableString extends String {
  public validatePresence(propertyName: string): string {
    return ``;
  }
}