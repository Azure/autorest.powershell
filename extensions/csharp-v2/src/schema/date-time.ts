/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '@microsoft.azure/autorest.codemodel-v3';
import { System } from '@microsoft.azure/codegen-csharp';
import { Expression, ExpressionOrLiteral, LiteralExpression, StringExpression, toExpression, valueOf } from '@microsoft.azure/codegen-csharp';
import { If } from '@microsoft.azure/codegen-csharp';
import { OneOrMoreStatements } from '@microsoft.azure/codegen-csharp';
import { Variable } from '@microsoft.azure/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { Primitive } from './primitive';

export class DateTime extends Primitive {
  public isXmlAttribute: boolean = false;
  public jsonType = ClientRuntime.JsonString;
  // public DateFormat = new StringExpression('yyyy-MM-dd');
  public DateTimeFormat = new StringExpression('yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.fffffffK');

  get declaration(): string {
    return `System.DateTime${this.isRequired ? '' : '?'}`;
  }
  protected castJsonTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `System.DateTime.TryParse((string)${tmpValue}, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var ${tmpValue}Value) ? ${tmpValue}Value : ${defaultValue}`;
  }
  protected castXmlTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `System.DateTime.TryParse((string)${tmpValue}, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var ${tmpValue}Value) ? ${tmpValue}Value : ${defaultValue}`;
  }
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    switch (mediaType) {
      case KnownMediaType.Json:
        return this.isRequired ?
          toExpression(`(${ClientRuntime.JsonNode}) new ${this.jsonType}(${value}.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture))`) :
          toExpression(`null != ${value} ? (${ClientRuntime.JsonNode}) new ${this.jsonType}(${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture)) : null`);

      case KnownMediaType.Xml:
        return this.isRequired ?
          toExpression(`new ${System.Xml.Linq.XElement}("${serializedName}",${value}.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture))`) :
          toExpression(`null != ${value} ? new ${System.Xml.Linq.XElement}("${serializedName}",${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture)) : null`);

      case KnownMediaType.Cookie:
      case KnownMediaType.QueryParameter:
      case KnownMediaType.Header:
      case KnownMediaType.Text:
      case KnownMediaType.UriParameter:
        return toExpression(this.isRequired ?
          `${value}.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture)` :
          `(null == ${value} ? ${System.String.Empty} : ${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture))`
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
          `${valueOf(container)}.Add("${serializedName}",${value}.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture));` :
          If(`null != ${value}`, `${valueOf(container)}.Add("${serializedName}",${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture));`);

      case KnownMediaType.QueryParameter:
        // gives a name=value for use inside a c# template string($"foo{someProperty}") as a query parameter
        return this.isRequired ?
          `${serializedName}={${value}..ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture)}` :
          `{null == ${value} ? ${System.String.Empty} : $"${serializedName}={${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture)}"}`;

      case KnownMediaType.UriParameter:
        // gives a name=value for use inside a c# template string($"foo{someProperty}") as a query parameter
        return this.isRequired ?
          `${serializedName}={${value}.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture)}` :
          `{null == ${value} ? ${System.String.Empty}: $"${serializedName}={${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.InvariantCulture)}"}`;
    }
    return (`/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }
  constructor(schema: Schema, public isRequired: boolean) {
    super(schema);
  }
  // public static string DateFormat = "yyyy-MM-dd";
  // public static string DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";
  // public static string DateTimeRfc1123Format = "R";
  // public static JsonString CreateDate(DateTime? value) => value is DateTime date ? new JsonString(date.ToString(DateFormat, CultureInfo.InvariantCulture)) : null;
  // public static JsonString CreateDateTime(DateTime? value) => value is DateTime date ? new JsonString(date.ToString(DateTimeFormat, CultureInfo.InvariantCulture)) : null;
  // public static JsonString CreateDateTimeRfc1123(DateTime ? value) => value is DateTime date ? new JsonString(date.ToString(DateTimeRfc1123Format, CultureInfo.InvariantCulture)) : null;

  validateValue(eventListener: Variable, property: Variable): string {
    return ``;
  }
}

export class DateTime1123 extends DateTime {
  public DateTimeFormat = new StringExpression('R');
  constructor(schema: Schema, isRequired: boolean) {
    super(schema, isRequired);
  }
}

export class UnixTime extends Primitive {
  public isXmlAttribute: boolean = false;
  public jsonType = ClientRuntime.JsonNumber;

  private EpochDate = System.DateTime.new('1970', '1', '1', '0', '0', '0', System.DateTimeKind.Utc);

  protected castJsonTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `long.TryParse((string)${tmpValue}, out var ${tmpValue}Value) ? ${this.EpochDate}.AddSeconds(${tmpValue}Value) : ${defaultValue}`;
  }
  protected castXmlTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `long.TryParse((string)${tmpValue}, out var ${tmpValue}Value) ? ${this.EpochDate}.AddSeconds(${tmpValue}Value) : ${defaultValue}`;
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    return super.serializeToNode(mediaType, new LiteralExpression(`((long)${value}.Subtract(${valueOf(this.EpochDate)}).TotalSeconds)`), serializedName);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    return super.serializeToContainerMember(mediaType, new LiteralExpression(`((long)${value}.Subtract(${valueOf(this.EpochDate)}).TotalSeconds)`), container, serializedName);
  }

  constructor(schema: Schema, public isRequired: boolean) {
    super(schema);
  }

  validateValue(eventListener: Variable, property: Variable): string {
    return ``;
  }

  get declaration(): string {
    return `System.DateTime${this.isRequired ? '' : '?'}`;
  }
}
