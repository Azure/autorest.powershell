/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '@microsoft.azure/autorest.codegen';
import { camelCase, deconstruct, nameof } from '@microsoft.azure/autorest.codegen';
import { IsNotNull } from '@microsoft.azure/autorest.codegen-csharp';
import { dotnet, System } from '@microsoft.azure/autorest.codegen-csharp';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from '@microsoft.azure/autorest.codegen-csharp';
import { ForEach } from '@microsoft.azure/autorest.codegen-csharp';
import { If } from '@microsoft.azure/autorest.codegen-csharp';
import { OneOrMoreStatements } from '@microsoft.azure/autorest.codegen-csharp';
import { Ternery } from '@microsoft.azure/autorest.codegen-csharp';
import { LocalVariable, Variable } from '@microsoft.azure/autorest.codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { popTempVar, pushTempVar } from '../schema/primitive';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

export class ArrayOf implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;

  constructor(public schema: Schema, public isRequired: boolean, protected elementType: EnhancedTypeDeclaration, protected minItems: number | undefined, protected maxItems: number | undefined, protected unique: boolean | undefined) {
  }

  protected get isWrapped(): boolean {
    return this.schema.xml && this.schema.xml.wrapped || false;
  }

  protected get wrapperName(): string | undefined {
    return this.schema.xml && this.isWrapped ? this.schema.xml.name : undefined;
  }

  protected get serializedName(): string | undefined {
    return this.schema.xml ? this.schema.xml.name : undefined;
  }
  get declaration(): string {
    return `${this.elementType.declaration}[]`;
  }

  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json: {
        // json array
        const tmp = `__${camelCase(['json', ...deconstruct(serializedName)])}`;
        return toExpression(`If( ${valueOf(container)}?.PropertyT<${ClientRuntime.JsonArray}>("${serializedName}"), out var ${tmp}) ? ${this.deserializeFromNode(mediaType, tmp, toExpression('null'))} : ${defaultValue}`);
      }

      case KnownMediaType.Xml: {
        // XElement/XElement
        const tmp = `__${camelCase(['xml', ...deconstruct(serializedName)])}`;
        if (this.isWrapped) {
          // wrapped xml arrays will have a container around them.
          return toExpression(`${this.deserializeFromNode(mediaType, `${valueOf(container)}?.Element("${this.serializedName || serializedName}")`, defaultValue)}`);
        } else {
          // whereas non-wrapped will have all the elements in the container directly.
          return toExpression(`${this.deserializeFromNode(mediaType, `${valueOf(container)}`, defaultValue)}`);
        }
      }
    }
    return toExpression(`null /* deserializeFromContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    try {
      const tmp = pushTempVar();
      const each = pushTempVar();
      switch (mediaType) {
        case KnownMediaType.Json: {
          const deser = `System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( ${tmp}, (${each})=> ${this.elementType.deserializeFromNode(mediaType, each, toExpression('null'))} ) )`;
          return toExpression(`If( ${valueOf(node)}, out var ${tmp}) ? new System.Func<${this.elementType.declaration}[]>(()=> ${deser} )() : ${defaultValue}`);
        }
        case KnownMediaType.Xml: {
          // XElement should be a container of items, right?
          // if the reference doesn't define an XML schema then use its default name
          const defaultName = this.elementType.schema.details.default.name;
          const deser = `System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( ${tmp}.Elements("${this.elementType.schema.xml ? this.elementType.schema.xml.name || defaultName : defaultName}"), (${each})=> ${this.elementType.deserializeFromNode(mediaType, each, toExpression('null'))} ) )`;

          return toExpression(`If( ${valueOf(node)}, out var ${tmp}) ? new System.Func<${this.elementType.declaration}[]>(()=> ${deser} )() : ${defaultValue}`);
        }
      }
    } finally {
      popTempVar();
      popTempVar();
    }
    return toExpression(`null /* deserializeFromNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    switch (mediaType) {
      case KnownMediaType.Json: {
        return this.deserializeFromNode(mediaType, ClientRuntime.JsonArray.Parse(content), defaultValue);
      }
      case KnownMediaType.Xml: {
        return this.deserializeFromNode(mediaType, `${System.Xml.Linq.XElement}.Parse(${content})`, defaultValue);
      }
    }
    return undefined;
  }
  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    switch (mediaType) {
      case KnownMediaType.Xml:
      case KnownMediaType.Json: {
        return toExpression(`${content}.Content.ReadAsStringAsync().ContinueWith( body => ${this.deserializeFromString(mediaType, 'body.Result', defaultValue)})`);
      }
    }
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {

    try {
      const each = pushTempVar();

      switch (mediaType) {
        case KnownMediaType.Json: {
          const serArray = `System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select(${value}, (${each}) => ${this.elementType.serializeToNode(mediaType, each, serializedName)}))`;
          return toExpression(`null != ${value} ? new ${ClientRuntime.XNodeArray}(${serArray}) : null`);
        }

        case KnownMediaType.Xml: {
          if (this.isWrapped) {
            const name = this.elementType.schema.xml ? this.elementType.schema.xml.name || serializedName : serializedName;
            return toExpression(`null != ${value} ? new System.Xml.Linq.XElement("${name}", System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select(${value}, (${each}) => ${this.elementType.serializeToNode(mediaType, each, name)}))`);
          } else {
            throw new Error('Can\'t set an Xml Array to the document without wrapping it.');
          }
        }
        case KnownMediaType.Cookie:
        case KnownMediaType.QueryParameter:
          return toExpression(`if (${value} != null && ${value}.Length > 0) { queryParameters.Add("${value}=" + System.Uri.EscapeDataString(System.Linq.Enumerable.Aggregate(${value}, (current, each) => current + "," + (string.IsNullOrEmpty(each) ? System.Uri.EscapeDataString(each) : System.String.Empty)))); }`);
        case KnownMediaType.Header:
        case KnownMediaType.Text:
        case KnownMediaType.UriParameter:
          return toExpression(`(null != ${value} ? System.Uri.EscapeDataString(System.Linq.Enumerable.Aggregate(${value}, (current,each)=> current + "," + ${this.elementType.serializeToNode(mediaType, 'each', '')})) : ${System.String.Empty})`);
      }
    } finally {
      popTempVar();
    }
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    try {
      const each = pushTempVar();
      switch (mediaType) {
        case KnownMediaType.Json: {
          return System.Net.Http.StringContent.new(Ternery(
            IsNotNull(value),
            `${ClientRuntime.XNodeArray.new(this.serializeToNode(mediaType, value, ''))}.ToString()`,
            System.String.Empty
          ), System.Text.Encoding.UTF8);
        }
        case KnownMediaType.Xml: {
          // if the reference doesn't define an XML schema then use its default name
          const defaultName = this.elementType.schema.details.default.name;
          return System.Net.Http.StringContent.new(Ternery(
            IsNotNull(value),
            `${this.serializeToNode(mediaType, value, this.schema.xml ? this.schema.xml.name || defaultName : defaultName)}).ToString()`,
            System.String.Empty
          ), System.Text.Encoding.UTF8);
        }

        case KnownMediaType.Cookie:
        case KnownMediaType.QueryParameter:
        case KnownMediaType.Header:
        case KnownMediaType.Text:
        case KnownMediaType.UriParameter:
          return toExpression(`(null != ${value} ? System.Uri.EscapeDataString(System.Linq.Enumerable.Aggregate(${value}, (current,each)=> current + "," + ${this.elementType.serializeToNode(mediaType, 'each', '')})) : ${System.String.Empty})`);
      }

    } finally {
      popTempVar();
    }

    return toExpression(`null /* serializeToContent doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    try {
      const each = pushTempVar();
      const tmp = pushTempVar();
      switch (mediaType) {
        case KnownMediaType.Json:
          const $this = this;
          return If(`null != ${value}`, function* () {
            const t = new LocalVariable(tmp, dotnet.Var, { initializer: `new ${ClientRuntime.XNodeArray}()` });
            yield t.declarationStatement;
            yield ForEach(each, toExpression(value), `AddIf(${$this.elementType.serializeToNode(mediaType, each, '')} ,${tmp}.Add);`);
            yield `${container}.Add("${serializedName}",${tmp});`;
          });

        case KnownMediaType.Xml:
          if (this.isWrapped) {
            return `AddIf( new System.Xml.Linq.XElement("${this.serializedName || serializedName}", ${this.serializeToNode(mediaType, value, this.elementType.schema.xml ? this.elementType.schema.xml.name || '!!!' : serializedName)}):null), ${container}.Add); `;
          } else {
            return If(`null != ${value}`, ForEach(each, toExpression(value), `AddIf(${this.elementType.serializeToNode(mediaType, each, serializedName)}, ${container}.Add);`));
          }
      }
    } finally {
      popTempVar();
      popTempVar();
    }
    return (`/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }

  public validatePresence(eventListener: Variable, property: Variable): OneOrMoreStatements {
    if (this.isRequired) {
      return `await ${eventListener}.AssertNotNull(${nameof(property.value)}, ${property}); `;
    }
    return ``;
  }
  validateValue(eventListener: Variable, property: Variable): OneOrMoreStatements {
    // check if the underlyingType has validation.
    if (!this.elementType.validateValue(eventListener, new LocalVariable(`${property} [{ __i }]`, dotnet.Var))) {
      return '';
    }

    return `
      if (${ property} != null ) {
        for (int __i = 0; __i < ${ property}.Length; __i++) {
          ${ this.elementType.validateValue(eventListener, new LocalVariable(`${property}[__i]`, dotnet.Var))}
        }
      }
      `.trim();
  }
}
