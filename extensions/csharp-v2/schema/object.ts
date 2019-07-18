/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { values } from '@microsoft.azure/codegen';
import { KnownMediaType } from '@microsoft.azure/autorest.codemodel-v3';
import { camelCase, deconstruct, EOL, nameof } from '@microsoft.azure/codegen';
import { IsNotNull } from '@microsoft.azure/codegen-csharp';
import { System } from '@microsoft.azure/codegen-csharp';
import { Expression, ExpressionOrLiteral, StringExpression, toExpression, valueOf } from '@microsoft.azure/codegen-csharp';
import { OneOrMoreStatements } from '@microsoft.azure/codegen-csharp';
import { Ternery } from '@microsoft.azure/codegen-csharp';
import { Variable } from '@microsoft.azure/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { popTempVar, pushTempVar } from './primitive';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

export class ObjectImplementation implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;

  get defaultOfType() {
    return toExpression(`null /* object */`);
  }

  get isNullable(): boolean {
    return true;
  }

  get convertObjectMethod() {
    return `${this.schema.details.csharp.fullname}TypeConverter.ConvertFrom`;
  }

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
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json: {
        return toExpression(`${value}?.ToJson(null, ${mode.value})`);
      }
      case KnownMediaType.Xml: {
        return toExpression(`${value}?.ToXml(null, ${mode.value})`);
      }
    }
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral, mode: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json: {
        return System.Net.Http.StringContent.new(
          Ternery(
            IsNotNull(value),
            `${value}.ToJson(null).ToString()`,
            new StringExpression('{}')),
          System.Text.Encoding.UTF8);
      }
      case KnownMediaType.Xml: {
        return System.Net.Http.StringContent.new(
          Ternery(
            IsNotNull(value),
            `${value}.ToXml(null).ToString()`,
            System.String.Empty),
          System.Text.Encoding.UTF8);
      }
      case KnownMediaType.Multipart:
        let contents = '';
        for (const p of values(this.schema.properties)) {
          // to do -- add in a potential support for the filename too.
          contents = `${contents}${EOL}    bodyContent.Add( ${System.Net.Http.StreamContent.new(`${value}.${p.details.csharp.name}`)},"${p.serializedName}");`;
        }
        // bodyContent.Add(new _ystem.Net.Http.StreamContent(body.AudioFile), "audioFile");
        return toExpression(`new ${System.Func(System.Net.Http.MultipartFormDataContent)}(() =>
{
    var bodyContent = ${System.Net.Http.MultipartFormDataContent.new()};
    ${contents}
    return bodyContent;
})()`);

    }
    return toExpression(`null /* serializeToContent doesn't support '${mediaType}' ${__filename}*/`);
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
    }
    return undefined;
  }

  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    switch (mediaType) {
      case KnownMediaType.Json: {
        if (this.schema.details.csharp.hasHeaders) {
          return toExpression(`${content}.Content.ReadAsStringAsync().ContinueWith( body => ${this.deserializeFromString(mediaType, 'body.Result', defaultValue)}.ReadHeaders(_response.Headers))`);
        }
        return toExpression(`${content}.Content.ReadAsStringAsync().ContinueWith( body => ${this.deserializeFromString(mediaType, 'body.Result', defaultValue)})`);
      }
      case KnownMediaType.Xml: {
        return toExpression(`${content}.Content.ReadAsStringAsync().ContinueWith( body => ${this.deserializeFromString(mediaType, 'body.Result', defaultValue)})`);
      }
    }
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    // const v = (<any>value).valuePrivate || value;
    switch (mediaType) {
      case KnownMediaType.Json:
        return `AddIf( null != ${value} ? (${ClientRuntime.JsonNode}) ${value}.ToJson(null,${mode.value}) : null, "${serializedName}" ,${container}.Add );`;

      case KnownMediaType.Xml:
        // prefer specified XML name if available
        return `AddIf( null != ${value} ? ${value}.ToXml(new ${System.Xml.Linq.XElement}("${this.schema.xml ? this.schema.xml.name || serializedName : serializedName}")) : null, ${container}.Add );`;

    }
    return `/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`;
  }

  isRequired = false;

  constructor(public schema: Schema) {
  }

  public validatePresence(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return `await ${eventListener}.AssertNotNull(${nameof(property.value)}, ${property}); `.trim();
  }
  public validateValue(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return `await ${eventListener}.AssertObjectIsValid(${nameof(property.value)}, ${property}); `;
  }

  get declaration(): string { return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.interfaceName}`; }
  get classDeclaration(): string { return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.name}`; }

}
