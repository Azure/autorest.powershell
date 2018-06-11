/** a declaritive use of a Type */
export interface TypeDeclaration {
  /** The full type name */
  declaration: string;
}

/** an interface supporting the definition of a type. (Used in generated classes) */
export interface TypeDefinition {
  /** The complete definition of the type (ie, the whole class or interface)  */
  definition: string;
}