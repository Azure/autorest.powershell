import { Expression } from '#csharp/code-dom/expression';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Variable } from '#csharp/code-dom/variable';
import { Serialization, Validation } from '#csharp/schema/extended-type-declaration';

export interface ExtendedVariable extends Variable {
  typeDeclaration: Serialization & Validation;

  validatePresenceStatement: OneOrMoreStatements;
  validationStatement: OneOrMoreStatements;
  jsonSerializationStatement: OneOrMoreStatements;
  jsonDeserializationStatement: OneOrMoreStatements;
}
