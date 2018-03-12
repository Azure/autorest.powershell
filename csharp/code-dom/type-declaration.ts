/** a declaritive use of a Type */
export interface TypeDeclaration {
  implementation: string;
  use: string;
  validation(propertyName: string): string;
}
