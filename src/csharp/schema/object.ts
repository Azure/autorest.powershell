import { KnownMediaType } from '#common/media-types';
import { nameof, camelCase, deconstruct } from '#common/text-manipulation';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from '#csharp/code-dom/expression';
import { OneOrMoreStatements, Statement } from '#csharp/code-dom/statements/statement';
import { Variable } from '#csharp/code-dom/variable';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { EnhancedTypeDeclaration } from './extended-type-declaration';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { System } from '#csharp/code-dom/mscorlib';
import { popTempVar, pushTempVar } from '#csharp/schema/primitive';

export class ObjectImplementation implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;

  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json: {
        // JsonObject
        const tmp = `__${camelCase(['json', ...deconstruct(serializedName)])}`;
        return toExpression(`If( ${valueOf(container)}?.PropertyT<${ClientRuntime.JsonObject}>("${serializedName}"), out var ${tmp}) ? ${this.classDeclaration}.FromJson(${tmp}) : ${defaultValue}`);
      }

      case KnownMediaType.Xml: {
        // XElement/XElement or XElement/XAttribute
        const tmp = `__${camelCase(['xml', ...deconstruct(serializedName)])}`;
        // prefer specified XML name if available
        return toExpression(`If( ${valueOf(container)}?.Element("${this.schema.xml ? this.schema.xml.name || serializedName : serializedName}"), out var ${tmp}) ? ${this.classDeclaration}.FromXml(${tmp}) : ${defaultValue}`);
      }
    }
    return toExpression(`${defaultValue} /* deserializeFromContainerMember doesn't support '${mediaType}' ${__filename} */`);
  }
  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    try {
      const tmp = pushTempVar();
      switch (mediaType) {
        case KnownMediaType.Json: {
          // we're always going to go thru FromJson; it'll handle nulls and polymorphism.
          return toExpression(`${this.classDeclaration}.FromJson(${node}) `);
        }
        case KnownMediaType.Xml: {

          return toExpression(`If( ${valueOf(node)}, out var ${tmp}) ? ${this.classDeclaration}.FromXml(${tmp}) : ${defaultValue}`);
        }
      }
    } finally {
      popTempVar();
    }
    return toExpression(`null /* deserializeFromNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    switch (mediaType) {
      case KnownMediaType.Json: {
        return toExpression(`${value}?.ToJson(null)`);
      }
      case KnownMediaType.Xml: {
        return toExpression(`${value}?.ToXml(null)`);
      }
    }
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    switch (mediaType) {
      case KnownMediaType.Json: {
        return toExpression(`new System.Net.Http.StringContent( null != ${value} ? ${value}.ToJson(null).ToString() : "{}", System.Text.Encoding.UTF8);`);
      }
      case KnownMediaType.Xml: {
        return toExpression(`new System.Net.Http.StringContent( null != ${value} ? ${value}.ToXml(null).ToString() : "", System.Text.Encoding.UTF8);`);
      }

    }
    return toExpression(`null /* serializeToContent doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    switch (mediaType) {
      case KnownMediaType.Json: {
        return this.deserializeFromNode(mediaType, `Carbon.Json.JsonNode.Parse(${content})`, defaultValue);
      }
      case KnownMediaType.Xml: {
        return this.deserializeFromNode(mediaType, `${System.Xml.Linq.XElement}.Parse(${content})`, defaultValue);
      }
    }
    return undefined;
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    switch (mediaType) {
      case KnownMediaType.Json:
        return `AddIf( null != ${value} ? (${ClientRuntime.JsonNode}) ${value}.ToJson(null) : null, "${serializedName}" ,${container}.Add );`;

      case KnownMediaType.Xml:
        // prefer specified XML name if available
        return `AddIf( null != ${value} ? ${value}.ToXml(new ${System.Xml.Linq.XElement}("${this.schema.xml ? this.schema.xml.name || serializedName : serializedName}")) : null, ${container}.Add );`;

    }
    return `/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`;
  }

  isRequired = false;

  constructor(public schema: Schema) {
  }

  public validatePresence(property: Variable): OneOrMoreStatements {
    return `await listener.AssertNotNull(${nameof(property.value)}, ${property}); `.trim();
  }
  public validateValue(property: Variable): OneOrMoreStatements {
    return `await listener.AssertObjectIsValid(${nameof(property.value)}, ${property}); `;
  }

  get declaration(): string { return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.interfaceName}`; }
  get classDeclaration(): string { return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.name}`; }
}
