/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '@azure-tools/codemodel-v3';
import { camelCase, deconstruct } from '@azure-tools/codegen';
import { IsNotNull } from '@azure-tools/codegen-csharp';
import { ClassType, dotnet, System } from '@azure-tools/codegen-csharp';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from '@azure-tools/codegen-csharp';
import { If } from '@azure-tools/codegen-csharp';
import { OneOrMoreStatements } from '@azure-tools/codegen-csharp';
import { Ternery } from '@azure-tools/codegen-csharp';
import { Variable } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { Schema as NewSchema, PrimitiveSchema } from '@azure-tools/codemodel';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

let tmpVar: number | undefined;
let max = 0;

function numToChars(ch: number): string {
  if (ch < 26) {
    return String.fromCharCode(122 - ch);
  }
  return `_${numToChars(ch - 26)}`;
}

export function pushTempVar() {
  if (!tmpVar) {
    tmpVar = 1;
    max = 1;
  } else {
    tmpVar++;
    max++;
  }

  return `__${numToChars(max)}`;
}

export function popTempVar() {
  if (tmpVar) {
    tmpVar--;
  }
  if (tmpVar === 0) {
    tmpVar = undefined;
    max = 0;
  }
}

export abstract class NewPrimitive implements EnhancedTypeDeclaration {
  abstract isRequired: boolean;
  abstract isXmlAttribute: boolean;
  abstract declaration: string;
  abstract jsonType: ClassType;
  get isNullable(): boolean {
    return !this.isRequired;
  }

  get encode(): string {
    return (this.schema.extensions && this.schema.extensions['x-ms-skip-url-encoding']) ? '' : 'global::System.Uri.EscapeDataString';
  }

  get defaultOfType() {
    return toExpression(`default(${this.declaration})`);
  }

  get convertObjectMethod() {
    const v = pushTempVar();
    const result = `(${v})=> (${this.baseType}) global::System.Convert.ChangeType(${v}, typeof(${this.baseType}))`;
    popTempVar();

    return result;
  }

  constructor(public schema: PrimitiveSchema) {
  }
  /** validatePresence on primitives is generally not required; the nullability determines requiredness... */
  public validatePresence(eventListener: Variable, property: Variable): string {
    return '';
  }

  abstract validateValue(eventListener: Variable, property: Variable): string;
  protected get baseType(): string {
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
        return toExpression(`System.Linq.Enumerable.FirstOrDefault(${serializedName}) is string ${tmp} ? ${this.baseType}.TryParse( ${tmp}, out ${this.baseType} ${tmp}Value ) ? ${tmp}Value : ${defaultValue} : ${defaultValue}`);
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
    } finally {
      popTempVar();
    }
    return toExpression(`null /* deserializeFromContainer doens't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    try {
      const tmp = pushTempVar();

      switch (mediaType) {
        case KnownMediaType.UriParameter: {
          return toExpression(`${this.baseType}.TryParse( ${valueOf(content)}, out ${this.baseType} ${tmp} ) ? ${tmp} : ${defaultValue}`);

        }
      }
    } finally {
      popTempVar();
    }
    return toExpression(`null /* deserializeFromString doesn't support '${mediaType}' ${__filename}`);
  }

  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral, mode: Expression): Expression {
    return toExpression(`null /* serializeToContent doesn't support '${mediaType}' ${__filename}*/`);
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json:
        return this.isRequired ?
          this.jsonType.new(value).Cast(ClientRuntime.JsonNode) :
          Ternery(IsNotNull(value), this.jsonType.new(`(${this.baseType})${value}`).Cast(ClientRuntime.JsonNode), dotnet.Null);

      case KnownMediaType.Xml:
        return this.isRequired ?
          toExpression(`new ${System.Xml.Linq.XElement}("${serializedName}",${value})`) :
          toExpression(`null != ${value} ? new ${System.Xml.Linq.XElement}("${serializedName}",${value}) : null`);

      case KnownMediaType.QueryParameter:
        if (this.isRequired) {
          return toExpression(`"${serializedName}=" + ${this.encode}(${value}.ToString())`);
        } else {
          return toExpression(`(null == ${value} ? ${System.String.Empty} : "${serializedName}=" + ${this.encode}(${value}.ToString()))`);
        }

      // return toExpression(`if (${value} != null) { queryParameters.Add($"${value}={${value}}"); }`);

      case KnownMediaType.Cookie:
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
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    switch (mediaType) {
      case KnownMediaType.Json:
        // container : JsonObject
        return `AddIf( ${this.serializeToNode(mediaType, value, serializedName, mode)}, "${serializedName}" ,${valueOf(container)}.Add );`;

      case KnownMediaType.Xml:
        // container : XElement
        return `AddIf( ${this.serializeToNode(mediaType, value, serializedName, mode)}, ${valueOf(container)}.Add );`;

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
          `{null == ${value} ? ${System.String.Empty}: $"${serializedName}={${value}.ToString()}"}`;
    }
    return (`/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }
}