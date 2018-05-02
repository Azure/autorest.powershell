import { TypeDeclaration as BaseTypeDeclaration } from '#csharp/code-dom/type-declaration';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';

/** Abstraction for a type that can be used as a Property (supports validation and serialization) */
export interface PropertyType extends BaseTypeDeclaration {
  validatePresence(propertyName: string): OneOrMoreStatements;
  validateValue(propertyName: string): OneOrMoreStatements;
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements;
  serializeInstanceToJson(instance: string): OneOrMoreStatements;
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements;
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements;
}
