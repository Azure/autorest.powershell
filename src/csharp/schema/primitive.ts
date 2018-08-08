import { KnownMediaType } from '#common/media-types';
import { camelCase, deconstruct } from '#common/text-manipulation';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from '#csharp/code-dom/expression';
import { System } from '#csharp/code-dom/mscorlib';
import { If } from '#csharp/code-dom/statements/if';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';
import { Variable } from '#csharp/code-dom/variable';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { EnhancedTypeDeclaration } from './extended-type-declaration';
import { Schema } from '#csharp/lowlevel-generator/code-model';


let __tmpVar: number | undefined;
let __max: number = 0;

export function pushTempVar() {
  if (!__tmpVar) {
    __tmpVar = 1;
    __max = 1;
  } else {
    __tmpVar++;
    __max++;
  }
  return `__${String.fromCharCode(123 - __max)}`;
}

export function popTempVar() {
  if (__tmpVar) {
    __tmpVar--;
  }
  if (__tmpVar === 0) {
    __tmpVar = undefined;
    __max = 0;
  }
}

export abstract class Primitive implements EnhancedTypeDeclaration {
  abstract isRequired: boolean;
  abstract isXmlAttribute: boolean;
  abstract declaration: string;
  abstract jsonType: TypeDeclaration;

  constructor(public schema: Schema) {
  }
  /** validatePresence on primitives is generally not required; the nullability determines requiredness... */
  public validatePresence(property: Variable): string {
    return ``;
  }

  abstract validateValue(property: Variable): string;
  private get baseType(): string {
    return this.declaration.replace('?', '');
  }

  protected castJsonTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `(${this.declaration})${tmpValue}`;
  }

  protected castXmlTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `(${this.declaration})${tmpValue}`;
  }

  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json: {
        // JsonObject
        const tmp = `__${camelCase(['json', ...deconstruct(serializedName)])}`;
        return toExpression(`If( ${valueOf(container)}?.PropertyT<${this.jsonType}>("${serializedName}"), out var ${tmp}) ? ${this.castJsonTypeToPrimitive(tmp, defaultValue.value)} : ${defaultValue}`);
      }

      case KnownMediaType.Xml: {
        // XElement/XElement or XElement/XAttribute
        const tmp = `__${camelCase(['xml', ...deconstruct(serializedName)])}`;

        return toExpression(this.isXmlAttribute ?
          `If( ${valueOf(container)}?.Attribute("${serializedName}"), out var ${tmp}) ? ${this.castXmlTypeToPrimitive(tmp, defaultValue.value)} : ${defaultValue}` :
          `If( ${valueOf(container)}?.Element("${serializedName}"), out var ${tmp}) ? ${this.castXmlTypeToPrimitive(tmp, defaultValue.value)} : ${defaultValue}`);
      }

      case KnownMediaType.Header: {
        // HttpResponseHeaders
        const tmp = `__${camelCase(['header', ...deconstruct(serializedName)])}`;
        return toExpression(`System.Linq.Enumerable.FirstOrDefault(${valueOf(container)}.GetValues("${serializedName}")) is string ${tmp} ? ${this.baseType}.TryParse( ${tmp}, out ${this.baseType} ${tmp}Value ) ? ${tmp}Value :${defaultValue}:${defaultValue}`);
      }
    }
    return toExpression(`${defaultValue} /* deserializeFromContainerMember doesn't support '${mediaType}' ${__filename} */`);
  }

  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    try {
      const tmp = pushTempVar();
      switch (mediaType) {
        case KnownMediaType.Json:
          // node should be a json type
          return toExpression(`${node} is ${this.jsonType} ${tmp} ? ${this.castJsonTypeToPrimitive(tmp, defaultValue.value)} : ${defaultValue}`);

        case KnownMediaType.Xml:
          // XElement or XAttribute
          return toExpression(
            this.isXmlAttribute ?
              `${node} is ${System.Xml.Linq.XAttribute} ${tmp} ? ${this.castXmlTypeToPrimitive(tmp, defaultValue.value)} : ${defaultValue}` :
              `${node} is ${System.Xml.Linq.XElement} ${tmp} ? ${this.castXmlTypeToPrimitive(tmp, defaultValue.value)}: ${defaultValue}`);
      }
    }
    finally {
      popTempVar();
    }
    return toExpression(`null /* deserializeFromContainer doens't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(``);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    return toExpression(`null /* serializeToContent doesn't support '${mediaType}' ${__filename}*/`);
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    switch (mediaType) {
      case KnownMediaType.Json:
        return this.isRequired ?
          toExpression(`(${ClientRuntime.JsonNode}) new ${this.jsonType}(${value})`) :
          toExpression(`null != ${value} ? (${ClientRuntime.JsonNode}) new ${this.jsonType}((${this.baseType})${value}) : null`);

      case KnownMediaType.Xml:
        return this.isRequired ?
          toExpression(`new ${System.Xml.Linq.XElement}("${serializedName}",${value})`) :
          toExpression(`null != ${value} ? new ${System.Xml.Linq.XElement}("${serializedName}",${value}) : null`);

      case KnownMediaType.Cookie:
      case KnownMediaType.QueryParameter:
      case KnownMediaType.Header:
      case KnownMediaType.Text:
      case KnownMediaType.UriParameter:
        return toExpression(this.isRequired ?
          `(${value}.ToString())` :
          `(null == ${value} ? ${System.String.Empty} : ${value}.ToString())`
        );
    }
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    switch (mediaType) {
      case KnownMediaType.Json:
        // container : JsonObject
        return `AddIf( ${this.serializeToNode(mediaType, value, serializedName)}, "${serializedName}" ,${valueOf(container)}.Add );`;

      case KnownMediaType.Xml:
        // container : XElement
        return `AddIf( ${this.serializeToNode(mediaType, value, serializedName)}, ${valueOf(container)}.Add );`;

      case KnownMediaType.Header:
        // container : HttpRequestHeaders
        return this.isRequired ?
          `${valueOf(container)}.Add("${serializedName}",${value}.ToString());` :
          If(`null != ${value}`, `${valueOf(container)}.Add("${serializedName}",${value}.ToString());`);

      case KnownMediaType.QueryParameter:
        // gives a name=value for use inside a c# template string($"foo{someProperty}") as a query parameter
        return this.isRequired ?
          `${serializedName}={${value}.ToString()}` :
          `{null == ${value} ? ${System.String.Empty} : $"${serializedName}={${value}.ToString()}"}`;

      case KnownMediaType.UriParameter:
        // gives a name=value for use inside a c# template string($"foo{someProperty}") as a query parameter
        return this.isRequired ?
          `${serializedName}={${value}.ToString()}` :
          `{null == ${value} ? "": $"${serializedName}={${value}.ToString()}"}`;
    }
    return (`/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }
}
