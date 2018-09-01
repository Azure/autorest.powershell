/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '#common/media-types';
import { nameof } from '#common/text-manipulation';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from '#csharp/code-dom/expression';
import { ForEach } from '#csharp/code-dom/statements/for';
import { If } from '#csharp/code-dom/statements/if';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Variable } from '#csharp/code-dom/variable';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { popTempVar, pushTempVar } from '#csharp/schema/primitive';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

export class Wildcard implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;

  constructor(public schema: Schema, protected leafType: EnhancedTypeDeclaration) {
  }

  get declaration(): string {
    return `System.Collections.Generic.IDictionary<string,${this.leafType.declaration}>`;
  }

  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json:

        break;
      case KnownMediaType.Xml:
        return toExpression(`System.Linq.Enumerable.ToDictionary( ${valueOf(container)}?.Elements() ?? System.Linq.Enumerable.Empty<System.Xml.Linq.XElement>(), element => element.Name.ToString(), element => ${this.leafType.deserializeFromNode(mediaType, 'element', toExpression('null'))} )`);

      case KnownMediaType.Header: {
        const prefix = this.schema.extensions['x-ms-header-collection-prefix'];
        if (prefix) {
          // this is a catch for a specific set of headers
          return toExpression(`System.Linq.Enumerable.ToDictionary(System.Linq.Enumerable.Where(${valueOf(container)}, header => header.Key.StartsWith("${serializedName}")), header => header.Key.Substring(${serializedName.length}), header => System.Linq.Enumerable.FirstOrDefault(header.Value))`);
        }
        return toExpression(`System.Linq.Enumerable.ToDictionary( ${valueOf(container)}?.Elements() ?? System.Linq.Enumerable.Empty<System.Xml.Linq.XElement>(), element => element.Name.ToString(), element => ${this.leafType.deserializeFromNode(mediaType, 'element', toExpression('null'))} )`);
      }
    }
    return toExpression(`null /* deserializeFromContainerMember (wildcard) doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    return toExpression(`null /* deserializeFromNode (wildcard) doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    return toExpression(`null /* serializeToNode (wildcard) doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression serialize this to the value required by the container */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    return toExpression(`null /* serializeToContent (wildcard) doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(`null /* deserializeFromString (wildcard)doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    try {
      const each = pushTempVar();

      switch (mediaType) {
        case KnownMediaType.Json:

          break;
        case KnownMediaType.Xml:
          return If(`null != ${value}`, ForEach(each, toExpression(value), `AddIf( ${this.leafType.serializeToNode(mediaType, `${each}.Value`, `$$$`)},${container}.Add );`.replace('"$$$"', `${each}.Key`)));

        case KnownMediaType.Header:
          const prefix = this.schema.extensions['x-ms-header-collection-prefix'];
          if (prefix) {
            return If(`null != ${value}`, ForEach(each, toExpression(value), `${valueOf(container)}.Add("${prefix}"+${each}.Key,${each}.Value);`));
          }
        // return If(`null != ${value} `, ForEach(each, toExpression(value), `${valueOf(container)}.Add("${serializedName}",${each}););`.replace('"$$$"', `${each}.Key`)));
      }
    } finally {
      popTempVar();
    }
    return `/* serializeToContainerMember (wildcard) doesn't support '${mediaType}' ${__filename}*/`;
  }
  /** is the value of this type permitted to be NULL */
  isRequired = false;

  public validatePresence(eventListener: Variable, property: Variable): string {
    return ``;
  }
  validateValue(eventListener: Variable, property: Variable): string {
    return ``;
  }
}

export class UntypedWildcard implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;

  constructor(public schema: Schema) {
  }

  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {

    return toExpression(`null /* deserializeFromContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    return toExpression(`null /* deserializeFromNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression serialize this to the value required by the container */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    return toExpression(`null /* serializeToContent doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(`null /* deserializeFromString doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    return `/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`;
  }

  /** is the value of this type permitted to be NULL */
  isRequired = false;

  get declaration(): string {
    return `System.Collections.Generic.Dictionary<string,object>`;
  }
  public validatePresence(eventListener: Variable, property: Variable): string {
    return `await ${eventListener}.AssertNotNull(${nameof(property.value)},${property});`.trim();
  }
  validateValue(eventListener: Variable, property: Variable): string {
    return `/* untyped wildcard validate value for ${property} */`;
  }
}
