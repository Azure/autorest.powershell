import { KnownMediaType } from '#common/media-types';
import { Expression, ExpressionOrLiteral, StringExpression, toExpression, LiteralExpression, valueOf } from '#csharp/code-dom/expression';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Variable } from '#csharp/code-dom/variable';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { Primitive } from '#csharp/schema/primitive';
import { EnhancedTypeDeclaration } from './extended-type-declaration';
import { System } from '#csharp/code-dom/mscorlib';
import { If } from '#csharp/code-dom/statements/if';
import { Schema } from '#csharp/lowlevel-generator/code-model';

export class DateTime extends Primitive {
  public isXmlAttribute: boolean = false;
  public jsonType = ClientRuntime.JsonString;
  // public DateFormat = new StringExpression('yyyy-MM-dd');
  public DateTimeFormat = new StringExpression('yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK');


  get declaration(): string {
    return `System.DateTime${this.isRequired ? '' : '?'}`;
  }
  protected castJsonTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `System.DateTime.TryParse((string)${tmpValue}, out var ${tmpValue}Value) ?${tmpValue}Value : ${defaultValue}`;
  }
  protected castXmlTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `System.DateTime.TryParse((string)${tmpValue}, out var ${tmpValue}Value) ?${tmpValue}Value : ${defaultValue}`;
  }
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    switch (mediaType) {
      case KnownMediaType.Json:
        return this.isRequired ?
          toExpression(`(${ClientRuntime.JsonNode}) new ${this.jsonType}(${value}.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture))`) :
          toExpression(`null != ${value} ? (${ClientRuntime.JsonNode}) new ${this.jsonType}(${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture)) : null`);

      case KnownMediaType.Xml:
        return this.isRequired ?
          toExpression(`new ${System.Xml.Linq.XElement}("${serializedName}",${value}.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture))`) :
          toExpression(`null != ${value} ? new ${System.Xml.Linq.XElement}("${serializedName}",${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture)) : null`);

      case KnownMediaType.Cookie:
      case KnownMediaType.QueryParameter:
      case KnownMediaType.Header:
      case KnownMediaType.Text:
      case KnownMediaType.UriParameter:
        return toExpression(this.isRequired ?
          `${value}.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture)` :
          `null == ${value} ? ${System.String.Empty} : "${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture)"`
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
          `${valueOf(container)}.Add("${serializedName}",${value}.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture));` :
          If(`null != ${value}`, `${valueOf(container)}.Add("${serializedName}",${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture));`);

      case KnownMediaType.QueryParameter:
        // gives a name=value for use inside a c# template string($"foo{someProperty}") as a query parameter
        return this.isRequired ?
          `${serializedName}={${value}..ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture)}` :
          `{null == ${value} ? ${System.String.Empty} : $"${serializedName}={${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture)}"}`;

      case KnownMediaType.UriParameter:
        // gives a name=value for use inside a c# template string($"foo{someProperty}") as a query parameter
        return this.isRequired ?
          `${serializedName}={${value}.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture)}` :
          `{null == ${value} ? "": $"${serializedName}={${value}?.ToString(${this.DateTimeFormat},System.Globalization.CultureInfo.CurrentCulture)}"}`;
    }
    return (`/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }
  constructor(schema: Schema, public isRequired: boolean) {
    super(schema);
  }
  // public static string DateFormat = "yyyy-MM-dd";
  // public static string DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
  // public static string DateTimeRfc1123Format = "R";
  // public static JsonString CreateDate(DateTime? value) => value is DateTime date ? new JsonString(date.ToString(DateFormat, CultureInfo.CurrentCulture)) : null;
  // public static JsonString CreateDateTime(DateTime? value) => value is DateTime date ? new JsonString(date.ToString(DateTimeFormat, CultureInfo.CurrentCulture)) : null;
  // public static JsonString CreateDateTimeRfc1123(DateTime ? value) => value is DateTime date ? new JsonString(date.ToString(DateTimeRfc1123Format, CultureInfo.CurrentCulture)) : null;

  validateValue(property: Variable): string {
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
  private EpochDate = new LiteralExpression('new System.DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)')

  protected castJsonTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `long.TryParse((string)${tmpValue}, out var ${tmpValue}Value) ? ${this.EpochDate}.AddSeconds(${tmpValue}Value) : ${defaultValue}`;
  }
  protected castXmlTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `long.TryParse((string)${tmpValue}, out var ${tmpValue}Value) ? ${this.EpochDate}.AddSeconds(${tmpValue}Value) : ${defaultValue}`;
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    return super.serializeToNode(mediaType, new LiteralExpression(`(long)${value}.Subtract(EpochDate).TotalSeconds`), serializedName);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    return super.serializeToContainerMember(mediaType, new LiteralExpression(`(long)${value}.Subtract(EpochDate).TotalSeconds`), container, serializedName);
  }

  constructor(schema: Schema, public isRequired: boolean) {
    super(schema);
  }

  validateValue(property: Variable): string {
    return ``;
  }

  get declaration(): string {
    return `System.DateTime${this.isRequired ? '' : '?'}`;
  }
}

