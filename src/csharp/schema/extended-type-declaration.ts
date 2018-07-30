import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';
import { Variable } from '#csharp/code-dom/variable';
import { ExpressionOrLiteral } from '#csharp/code-dom/expression';

/** Abstraction for a type that can be used as a Property (supports validation and serialization) */
export interface Serialization extends TypeDeclaration {
  // validatePresence(propertyName: string): OneOrMoreStatements;
  // validateValue(propertyName: string): OneOrMoreStatements;
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements;
  serializeInstanceToJson(instance: string): OneOrMoreStatements;
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements;
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements;

  xmlSerializeToContainer(container: Variable, property: Variable, serializedName: string): OneOrMoreStatements;
  xmlSerializeInstance(instance: Variable): OneOrMoreStatements;
  xmlDeserializeProperty(container: Variable, property: Variable, serializedName: string): OneOrMoreStatements;
  xmlDeserializeNode(nodeExpression: ExpressionOrLiteral): OneOrMoreStatements;
}

export interface Validation extends TypeDeclaration {
  validatePresence(propertyName: string): OneOrMoreStatements;
  validateValue(propertyName: string): OneOrMoreStatements;
}
