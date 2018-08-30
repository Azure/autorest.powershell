import { KnownMediaType } from '#common/media-types';
import { camelCase, deconstruct, nameof } from '#common/text-manipulation';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from '#csharp/code-dom/expression';
import { System } from '#csharp/code-dom/dotnet';
import { If } from '#csharp/code-dom/statements/if';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Variable } from '#csharp/code-dom/variable';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { popTempVar, pushTempVar } from '#csharp/schema/primitive';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

/** A ETD for the c# string type. */
export class String implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;

  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json: {
        // container should be a JsonObject
        const tmpVar = `__${camelCase(['json', ...deconstruct(serializedName)])}`;
        return toExpression(`If( ${valueOf(container)}?.PropertyT<${ClientRuntime.JsonString}>("${serializedName}"), out var ${tmpVar}) ? (string)${tmpVar} : (string)${defaultValue}`);
      }
      case KnownMediaType.Xml: {
        const xTmp = `__${camelCase(['xml', ...deconstruct(serializedName)])}`;
        return toExpression(`If( ${valueOf(container)}?.Element("${serializedName}"), out var ${xTmp}) ? (string)${xTmp} : (string)${defaultValue}`);
      }
      case KnownMediaType.Header: {
        // HttpResponseHeaders
        const tmp = `__${camelCase(['header', ...deconstruct(serializedName)])}`;
        return toExpression(`System.Linq.Enumerable.FirstOrDefault(${serializedName}) is string ${tmp} ? ${tmp} : (string)${defaultValue}`);
      }
    }
    return toExpression(`${defaultValue} /* deserializeFromContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }

  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    try {
      const tmp = pushTempVar();
      switch (mediaType) {
        case KnownMediaType.Json:
          // node should be a JsonString
          return toExpression(`${node} is ${ClientRuntime.JsonString} ${tmp} ? (string)${tmp} : ${defaultValue}`);

        case KnownMediaType.Xml:
          return toExpression(`${node} is ${System.Xml.Linq.XElement} ${tmp} ? (string)${tmp} : ${defaultValue}`);
      }
    } finally {
      popTempVar();
    }
    return toExpression(`null /* deserializeFromContainer doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    return toExpression(`null /* serializeToContent doesn't support '${mediaType}' ${__filename}*/`);
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    switch (mediaType) {
      case KnownMediaType.Json:
        return toExpression(`null != ${value} ? (${ClientRuntime.JsonNode}) new ${ClientRuntime.JsonString}(${value}) : null`);

      case KnownMediaType.Xml:
        return toExpression(`null != ${value} ? new ${System.Xml.Linq.XElement}("${serializedName}",${value}) : null`);

      case KnownMediaType.QueryParameter:
        if (this.isRequired) {
          return toExpression(`"${serializedName}=" + System.Uri.EscapeDataString(${value})`);
        } else {
          return toExpression(`string.IsNullOrEmpty(${value}) ? ${System.String.Empty} : "${serializedName}=" + System.Uri.EscapeDataString(${valueOf(value)})`);
        }

      // return toExpression(`if (!string.IsNullOrEmpty(${value})) { queryParameters.Add($"${value}={System.Uri.EscapeDataString(${value})}"); }`);

      case KnownMediaType.Cookie:
      case KnownMediaType.Header:
      case KnownMediaType.Text:
      case KnownMediaType.UriParameter:
        if (this.isRequired) {
          return toExpression(`System.Uri.EscapeDataString(${value})`);
        }
        return toExpression(`(string.IsNullOrEmpty(${value}) ? ${System.String.Empty} : System.Uri.EscapeDataString(${value}) )`);

    }
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(``);
  }

  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    switch (mediaType) {
      case KnownMediaType.Json:
        return `AddIf( ${this.serializeToNode(mediaType, value, serializedName)}, "${serializedName}" ,${container}.Add );`;

      case KnownMediaType.Xml:
        return `AddIf( ${this.serializeToNode(mediaType, value, serializedName)}, ${container}.Add );`;

      case KnownMediaType.Header:
        // container : HttpRequestHeaders
        return this.isRequired ?
          `${valueOf(container)}.Add("${serializedName}",${value}.ToString());` :
          If(`null != ${value}`, `${valueOf(container)}.Add("${serializedName}",${value});`);

      case KnownMediaType.QueryParameter:
        // gives a name=value for use inside a c# template string($"foo{someProperty}") as a query parameter
        return this.isRequired ?
          `${serializedName}={${value}.ToString()}` :
          `{null == ${value} ? ${System.String.Empty} : $"${serializedName}={${value}.ToString()}"}`;

      case KnownMediaType.UriParameter:
        // gives a name=value for use inside a c# template string($"foo{someProperty}") as a query parameter
        return this.isRequired ?
          `(${serializedName}={${value}.ToString()})` :
          `(null == ${value} ? ${System.String.Empty}: $"${serializedName}={${value}.ToString()}")`;
    }
    return (`/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }

  constructor(public schema: Schema, public isRequired: boolean) {
  }

  get declaration(): string {
    return 'string';
  }

  validateValue(property: Variable): string {
    return `
${this.validateMinLength(property)}
${this.validateMaxLength(property)}
${this.validateRegex(property)}
${this.validateEnum(property)}
    `.trim();

  }



  public validatePresence(property: Variable): string {
    return `await listener.AssertNotNull(${nameof(property.value)},${property});`.trim();
  }

  private validateMinLength(property: Variable): string {
    if (!this.schema.minLength) {
      return '';
    }
    return `await listener.AssertMinimumLength(${nameof(property.value)},${property},${this.schema.minLength});`;
  }
  private validateMaxLength(property: Variable): string {
    if (!this.schema.maxLength) {
      return '';
    }
    return `await listener.AssertMaximumLength(${nameof(property.value)},${property},${this.schema.maxLength});`;
  }
  private validateRegex(property: Variable): string {
    if (!this.schema.pattern) {
      return '';
    }
    return `await listener.AssertRegEx(${nameof(property.value)},${property},@"${this.schema.pattern}");`;
  }
  private validateEnum(property: Variable): string {
    if (!this.schema.enum || this.schema.enum.length === 0) {
      return '';
    }
    return `await listener.AssertEnum(${nameof(property.value)},${property},${this.schema.enum.joinWith((v) => `@"${v}"`)});`;
  }
}
