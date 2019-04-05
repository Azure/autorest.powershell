/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '@microsoft.azure/autorest.codemodel-v3';
import { camelCase, deconstruct, nameof } from '@microsoft.azure/codegen';
import { System } from '@microsoft.azure/codegen-csharp';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from '@microsoft.azure/codegen-csharp';
import { If } from '@microsoft.azure/codegen-csharp';
import { OneOrMoreStatements } from '@microsoft.azure/codegen-csharp';
import { Variable } from '@microsoft.azure/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { popTempVar, pushTempVar } from './primitive';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

/** A ETD for the c# string type. */
export class String implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;

  get defaultOfType() {
    return toExpression(`null`);
  }

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
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral, mode: Expression): Expression {
    return toExpression(`null /* serializeToContent doesn't support '${mediaType}' ${__filename}*/`);
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json:
        return toExpression(`null != (((object)${value})?.ToString()) ? (${ClientRuntime.JsonNode}) new ${ClientRuntime.JsonString}(${value}.ToString()) : null`);

      case KnownMediaType.Xml:
        return toExpression(`null != (${value}?.ToString()) ? new ${System.Xml.Linq.XElement}("${serializedName}",${value}) : null`);

      case KnownMediaType.QueryParameter:
        if (this.isRequired) {
          return toExpression(`"${serializedName}=" + System.Uri.EscapeDataString(${value})`);
        } else {
          return toExpression(`(string.IsNullOrEmpty(${value}) ? ${System.String.Empty} : "${serializedName}=" + System.Uri.EscapeDataString(${valueOf(value)}))`);
        }

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

    switch (mediaType) {
      case KnownMediaType.Json: {
        return this.deserializeFromNode(mediaType, ClientRuntime.JsonNode.Parse(content), defaultValue);
      }
      case KnownMediaType.Xml: {
        return this.deserializeFromNode(mediaType, `${System.Xml.Linq.XElement}.Parse(${content})`, defaultValue);
      }
      case KnownMediaType.UriParameter: {
        return toExpression(content);
      }
    }
    return toExpression(`null /* deserializeFromString doesn't support '${mediaType}' ${__filename}`);
  }

  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    switch (mediaType) {
      case KnownMediaType.Json:
        return toExpression(`${content}.Content.ReadAsStringAsync().ContinueWith( body => ${this.deserializeFromString(mediaType, 'body.Result', defaultValue)})`);

    }
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }

  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    switch (mediaType) {
      case KnownMediaType.Json:
        return `AddIf( ${this.serializeToNode(mediaType, value, serializedName, mode)}, "${serializedName}" ,${container}.Add );`;

      case KnownMediaType.Xml:
        return `AddIf( ${this.serializeToNode(mediaType, value, serializedName, mode)}, ${container}.Add );`;

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

  validateValue(eventListener: Variable, property: Variable): string {
    return `
${this.validateMinLength(eventListener, property)}
${this.validateMaxLength(eventListener, property)}
${this.validateRegex(eventListener, property)}
${this.validateEnum(eventListener, property)}
    `.trim();

  }

  public validatePresence(eventListener: Variable, property: Variable): string {
    return `await ${eventListener}.AssertNotNull(${nameof(property.value)},${property});`.trim();
  }

  private validateMinLength(eventListener: Variable, property: Variable): string {
    if (!this.schema.minLength) {
      return '';
    }
    return `await ${eventListener}.AssertMinimumLength(${nameof(property.value)},${property},${this.schema.minLength});`;
  }
  private validateMaxLength(eventListener: Variable, property: Variable): string {
    if (!this.schema.maxLength) {
      return '';
    }
    return `await ${eventListener}.AssertMaximumLength(${nameof(property.value)},${property},${this.schema.maxLength});`;
  }
  private validateRegex(eventListener: Variable, property: Variable): string {
    if (!this.schema.pattern) {
      return '';
    }
    return `await ${eventListener}.AssertRegEx(${nameof(property.value)},${property},@"${this.schema.pattern}");`;
  }
  private validateEnum(eventListener: Variable, property: Variable): string {
    if (!this.schema.enum || this.schema.enum.length === 0) {
      return '';
    }
    return `await ${eventListener}.AssertEnum(${nameof(property.value)},${property},${this.schema.enum.joinWith((v) => `@"${v}"`)});`;
  }
}
