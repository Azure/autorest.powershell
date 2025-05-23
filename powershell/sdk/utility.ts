/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { getAllPublicVirtualPropertiesForSdkWithoutInherited, getAllPublicVirtualPropertiesForSdk, VirtualProperty, VirtualProperties } from '../utils/schema';
import { ArraySchema, DictionarySchema, ObjectSchema, Schema, isObjectSchema, SchemaType, isNumberSchema, Parameter, ChoiceSchema, ConstantSchema, SealedChoiceSchema, Operation, NumberSchema } from '@autorest/codemodel';
import { Dictionary, values } from '@azure-tools/linq';
import { type } from 'os';
import { schema } from '@azure-tools/codemodel-v3';
import { pascalCase, camelCase } from '@azure-tools/codegen';
import { FinallyStatement, Is, Method } from '@azure-tools/codegen-csharp';
export class Helper {

  useDateTimeOffset: boolean;
  constructor(useDateTimeOffset = false) {
    this.useDateTimeOffset = useDateTimeOffset;
  }

  public HasConstrains(schema: Schema): boolean {
    if ((<any>schema).minimum !== undefined || (<any>schema).maximum !== undefined || (<any>schema).maxLength !== undefined || (<any>schema).minLength !== undefined || (<any>schema).maxItems !== undefined || (<any>schema).minItems !== undefined || (<any>schema).multipleOf !== undefined || (<any>schema).pattern !== undefined || (<any>schema).uniqueItems !== undefined) {
      return true;
    }
    return false;
  }

  public HasConstantProperty(schema: Schema): boolean {
    const virtualProperties = this.GetAllPublicVirtualProperties(schema.language.default.virtualProperties);
    return virtualProperties.filter(p => p.required && (p.property.schema.type === SchemaType.Constant || this.IsConstantEnumProperty(p) || (p.property.schema.type === SchemaType.Object && this.HasConstantProperty(p.property.schema)))).length > 0;
  }

  public GetCsharpType(schema: Schema): string {
    let type = <string>schema.type;
    if (schema.type === SchemaType.Integer || schema.type === SchemaType.Number) {
      type = type + (<NumberSchema>schema).precision;
    }
    const offset = this.useDateTimeOffset ? 'Offset' : '';
    const typeMap = new Map<string, string>([
      ['integer', 'int'],
      ['integer32', 'int'],
      ['integer64', 'long'],
      ['number32', 'double'],
      ['number64', 'double'],
      ['number128', 'decimal'],
      ['boolean', 'bool'],
      ['string', 'string'],
      ['unixtime', 'System.DateTime'],
      ['credential', 'string'],
      ['byte-array', 'byte[]'],
      ['duration', 'System.TimeSpan'],
      ['uuid', 'System.Guid'],
      ['date-time', 'System.DateTime' + offset],
      ['date', 'System.DateTime'],
      ['binary', 'string'],
      ['uri', 'string'],
      ['arm-id', 'string']
    ]);
    if (typeMap.has(type)) {
      return <string>typeMap.get(type);
    }
    return '';
  }
  private isArraySchema(schema: Schema): schema is ArraySchema {
    return schema.type === SchemaType.Array;
  }
  private isDictionarySchema(schema: Schema): schema is DictionarySchema {
    return schema.type === SchemaType.Dictionary;
  }
  private ShouldValidate(schema: Schema): boolean {
    if (!schema) {
      return false;
    }
    const typesToValidate = new Array<Schema>();
    const validatedTypes = new Set<Schema>();
    typesToValidate.push(schema);
    while (typesToValidate.length > 0) {
      const modelToValidate = typesToValidate.pop();
      if (!modelToValidate) {
        continue;
      } else {
        if (validatedTypes.has(modelToValidate)) {
          continue;
        }
        validatedTypes.add(modelToValidate);
        if (this.isArraySchema(modelToValidate) || this.isDictionarySchema(modelToValidate)) {
          typesToValidate.push(modelToValidate.elementType);
        } else if (isObjectSchema(modelToValidate)) {
          const virtualProperties = modelToValidate.extensions && modelToValidate.extensions['x-ms-azure-resource'] ? getAllPublicVirtualPropertiesForSdkWithoutInherited(modelToValidate.language.default.virtualProperties) : getAllPublicVirtualPropertiesForSdk(modelToValidate.language.default.virtualProperties);
          values(virtualProperties).where(p => isObjectSchema(p.property.schema)).forEach(cp => typesToValidate.push(cp.property.schema));
          if (values(virtualProperties).any(p => (p.required && p.property.schema.type !== SchemaType.Constant && !this.IsConstantEnumProperty(p)) || this.HasConstrains(p.property.schema))) {
            return true;
          }
        }
      }
    }
    return false;
  }

  private appendConstraintValidations(valueReference: string, sb: Array<string>, model: Schema) {
    const schema = <any>model;
    if (schema.maximum !== undefined) {
      const rule = schema.exclusiveMaximum ? 'ExclusiveMaximum' : 'InclusiveMaximum';
      const cmp = schema.exclusiveMaximum ? '>=' : '>';
      sb.push(`if (${valueReference} ${cmp} ${schema.maximum})`);
      sb.push('{');
      sb.push(`    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.${rule}, "${valueReference.replace('this.', '')}", ${schema.maximum});`);
      sb.push('}');
    }
    if (schema.minimum !== undefined) {
      const rule = schema.exclusiveMinimum ? 'ExclusiveMinimum' : 'InclusiveMinimum';
      const cmp = schema.exclusiveMinimum ? '<=' : '<';
      sb.push(`if (${valueReference} ${cmp} ${schema.minimum})`);
      sb.push('{');
      sb.push(`    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.${rule}, "${valueReference.replace('this.', '')}", ${schema.minimum});`);
      sb.push('}');
    }
    if (schema.maxItems !== undefined) {
      sb.push(`if (${valueReference}.Count > ${schema.maxItems})`);
      sb.push('{');
      sb.push(`    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MaxItems, "${valueReference.replace('this.', '')}", ${schema.maxItems});`);
      sb.push('}');
    }
    if (schema.maxLength !== undefined) {
      sb.push(`if (${valueReference}.Length > ${schema.maxLength})`);
      sb.push('{');
      sb.push(`    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MaxLength, "${valueReference.replace('this.', '')}", ${schema.maxLength});`);
      sb.push('}');
    }
    if (schema.minLength !== undefined) {
      sb.push(`if (${valueReference}.Length < ${schema.minLength})`);
      sb.push('{');
      sb.push(`    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MinLength, "${valueReference.replace('this.', '')}", ${schema.minLength});`);
      sb.push('}');
    }
    if (schema.minItems !== undefined) {
      sb.push(`if (${valueReference}.Count < ${schema.minItems})`);
      sb.push('{');
      sb.push(`    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MinItems, "${valueReference.replace('this.', '')}", ${schema.minItems});`);
      sb.push('}');
    }
    if (schema.multipleOf !== undefined) {
      sb.push(`if (${valueReference} % ${schema.multipleOf} != 0)`);
      sb.push('{');
      sb.push(`    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MultipleOf, "${valueReference.replace('this.', '')}", ${schema.multipleOf});`);
      sb.push('}');
    }
    if (schema.pattern !== undefined) {
      // eslint-disable-next-line
      const constraintValue = "\"" + schema.pattern.replace(/\\/g, "\\\\").replace(/"/g, "\\\"") + "\"";
      let condition = `!System.Text.RegularExpressions.Regex.IsMatch(${valueReference}, ${constraintValue})`;
      if (schema.type === SchemaType.Dictionary) {
        condition = `!System.Linq.Enumerable.All(${valueReference}.Values, value => System.Text.RegularExpressions.Regex.IsMatch(value, ${constraintValue}))`;
      }
      sb.push(`if (${condition})`);
      sb.push('{');
      sb.push(`    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.Pattern, "${valueReference.replace('this.', '')}", ${constraintValue});`);
      sb.push('}');
    }
    if (schema.uniqueItems !== undefined && 'true' === schema.uniqueItems.toString()) {
      sb.push(`if (${valueReference}.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(${valueReference})))`);
      sb.push('{');
      sb.push(`    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.UniqueItems, "${valueReference.replace('this.', '')}");`);
      sb.push('}');
    }
  }

  private isKindOfString(schema: Schema, required = false): boolean {
    if (schema.type === SchemaType.String) {
      return true;
    } else if (schema.type === SchemaType.Constant && (<ConstantSchema>schema).valueType.type === SchemaType.String) {
      return true;
    } else if (schema.type === SchemaType.Choice && (<ChoiceSchema>schema).choiceType.type === SchemaType.String) {
      return true;
    } else if (schema.type === SchemaType.SealedChoice && (<ChoiceSchema>schema).choiceType.type === SchemaType.String && (schema.extensions?.['x-ms-model-as-string'] === true || (required && (<ChoiceSchema>schema).choices.length === 1))) {
      return true;
    }
    // ToDo: we need to figure how to handle the case when schema type is enum
    // Skip it since there is a bug in IsKindOfString in the csharp generator
    // if (schema.type === SchemaType.Choice && (<ChoiceSchema>schema).choiceType.type === SchemaType.String) {
    //   return true;
    // }
    // if (schema.type === SchemaType.SealedChoice
    //   && (<ChoiceSchema>schema).choiceType.type === SchemaType.String) {
    //   // currently assume modelAsString true
    //   return true;
    // }
    return false;
  }
  public PathParameterString(parameter: Parameter, clientPrefix: string): string {
    if (!['path', 'query'].includes(parameter.protocol.http?.in)) {
      return '';
    }
    const prefix = parameter.implementation === 'Client' ? `this${clientPrefix}.` : '';
    let res = '';
    if (this.isKindOfString(parameter.schema, parameter.required)) {
      res = `${prefix}${parameter.language.default.name}`;
    } else {
      let serializationSettings = `this${clientPrefix}.SerializationSettings`;
      if (this.IsValueType(parameter.schema.type)) {
        if (parameter.schema.type === SchemaType.Date) {
          serializationSettings = 'new Microsoft.Rest.Serialization.DateJsonConverter()';
        } else if (parameter.schema.type === SchemaType.DateTime && (<any>parameter.schema).format === 'date-time-rfc1123') {
          serializationSettings = 'new Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter()';
        } else if (parameter.schema.type === SchemaType.Uri) {
          serializationSettings = 'new Microsoft.Rest.Serialization.Base64UrlJsonConverter()';
        } else if (parameter.schema.type === SchemaType.UnixTime) {
          serializationSettings = 'new Microsoft.Rest.Serialization.UnixTimeJsonConverter()';
        }
      }
      res = `Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(${prefix}${parameter.language.default.name}, ${serializationSettings}).Trim('"')`;
    }
    if (parameter.extensions && parameter.extensions['x-ms-skip-url-encoding']) {
      return res;
    } else {
      return `System.Uri.EscapeDataString(${res})`;
    }
  }
  public ValidateType(schema: Schema, scope: any, valueReference: string, isNullable: boolean, indentation = 3): string {
    const indentationSpaces = '    '.repeat(indentation);
    const sb = new Array<string>();
    if (!scope) {
      throw new Error('scope is null');
    }
    if (!!schema && isObjectSchema(schema) && this.ShouldValidateChain(schema)) {
      sb.push(`${valueReference}.Validate();`);
    }
    if (this.HasConstrains(schema)) {
      this.appendConstraintValidations(valueReference, sb, schema);
    }
    if (schema && this.isArraySchema(schema) && this.ShouldValidateChain(schema)) {
      // ToDo: Should try to get a unique name instead of element
      let elementVar = 'element';
      if (valueReference.startsWith(elementVar)) {
        elementVar = valueReference + '1';
      }
      const innerValidation = this.ValidateType((<ArraySchema>schema).elementType, scope, elementVar, true, 1);
      if (innerValidation) {
        sb.push(`foreach (var ${elementVar} in ${valueReference})`);
        sb.push('{');
        innerValidation.split('\r\n').map(str => sb.push(str));
        sb.push('}');
      }
    } else if (schema && this.isDictionarySchema(schema) && this.ShouldValidateChain(schema)) {
      // ToDo: Should try to get a unique name instead of valueElement
      let valueVar = 'valueElement';
      if (valueReference.startsWith(valueVar)) {
        valueVar = valueReference + '1';
      }
      const innerValidation = this.ValidateType((<DictionarySchema>schema).elementType, scope, valueVar, true, 1);
      if (innerValidation) {
        sb.push(`foreach (var ${valueVar} in ${valueReference}.Values)`);
        sb.push('{');
        innerValidation.split('\r\n').map(str => sb.push(str));
        sb.push('}');
      }
    }
    if (sb.length > 0) {
      if (this.IsValueType(schema.type) && !isNullable) {
        return sb.map(str => indentationSpaces + str).join('\r\n');
      } else {
        return `${indentationSpaces}if (${valueReference} != null)\r\n${indentationSpaces}{\r\n${sb.map(str => indentationSpaces + '    ' + str).join('\r\n')}\r\n${indentationSpaces}}`;
      }
    }
    return '';
  }
  public ShouldValidateChain(schema: Schema): boolean {
    if (!schema) {
      return false;
    }
    const typesToValidate = new Array<Schema>();
    const validatedTypes = new Set<Schema>();
    typesToValidate.push(schema);
    while (typesToValidate.length > 0) {
      const modelToValidate = typesToValidate.pop();
      if (!modelToValidate) {
        continue;
      } else {
        validatedTypes.add(modelToValidate);
        if (this.isArraySchema(modelToValidate) || this.isDictionarySchema(modelToValidate)) {
          typesToValidate.push(modelToValidate.elementType);
        } else if (isObjectSchema(modelToValidate)) {
          if (this.ShouldValidate(modelToValidate)) {
            return true;
          }
          if (modelToValidate.parents && (modelToValidate.parents.immediate.length === 1 && !(modelToValidate.extensions && modelToValidate.extensions['x-ms-azure-resource']))) {
            typesToValidate.push(modelToValidate.parents.immediate[0]);
          }
        }
      }
    }
    return false;
  }

  public GetDeserializationSettings(schema: Schema, ref: string): string {
    if (schema.type === SchemaType.Date) {
      return 'new Microsoft.Rest.Serialization.DateJsonConverter()';
    } else if (schema.type === SchemaType.Uri) {
      return 'new Microsoft.Rest.Serialization.Base64UrlJsonConverter()';
    } else if (schema.type === SchemaType.UnixTime) {
      return 'new Microsoft.Rest.Serialization.UnixTimeJsonConverter()';
    }
    return ref + '.DeserializationSettings';
  }

  public GetSerializationSettings(schema: Schema, ref: string): string {
    if (schema.type === SchemaType.Date) {
      return 'new Microsoft.Rest.Serialization.DateJsonConverter()';
    } else if (schema.type === SchemaType.Uri) {
      return 'new Microsoft.Rest.Serialization.Base64UrlJsonConverter()';
    } else if (schema.type === SchemaType.UnixTime) {
      return 'new Microsoft.Rest.Serialization.UnixTimeJsonConverter()';
    }
    return ref + '.SerializationSettings';
  }

  public IsNullCheckRequiredForVirtualProperty(virtualProperty: VirtualProperty): boolean {
    return !((this.IsValueType(virtualProperty.property.schema.type) || (virtualProperty.property.schema.type === SchemaType.SealedChoice && ((<SealedChoiceSchema>virtualProperty.property.schema).choiceType.type !== SchemaType.String || (virtualProperty.property.schema.extensions && !virtualProperty.property.schema.extensions['x-ms-model-as-string'])))) && (virtualProperty.required || virtualProperty.property.nullable === false));
  }

  public CamelCase(str: string): string {
    // str = str.replace(/(?:^\w|[A-Z]|\b\w)/g, function (word, index) {
    //   return index === 0 ? word.toLowerCase() : word.toUpperCase();
    // }).replace(/\s+/g, '');
    return camelCase(str);
  }
  public PascalCase(str: string): string {
    return pascalCase(str);
  }
  public GetAllPublicVirtualProperties(virtualProperties?: VirtualProperties): Array<VirtualProperty> {
    return getAllPublicVirtualPropertiesForSdk(virtualProperties);
  }
  public GetAllPublicVirtualPropertiesWithoutInherited(virtualProperties?: VirtualProperties): Array<VirtualProperty> {
    return getAllPublicVirtualPropertiesForSdkWithoutInherited(virtualProperties);
  }
  public NeedsTransformationConverter(object: ObjectSchema): boolean {
    for (const property of values(object.properties)) {
      if (property.extensions && property.extensions['x-ms-client-flatten']) {
        return true;
      }
    }
    return false;
  }
  public IsValueType(type: string): boolean {
    if (['boolean', 'integer', 'number', 'unixtime', 'duration', 'uuid', 'date-time', 'date'].includes(type)) {
      return true;
    }
    return false;
  }
  public HandleConstParameters(operation: Operation): string {
    const result = new Array<string>();
    const bodyParameters = operation.requests && operation.requests.length > 0 ? (operation.requests[0].parameters || []).filter(each => each.protocol.http && each.protocol.http.in === 'body' && !(each.extensions && each.extensions['x-ms-client-flatten']) && each.implementation !== 'Client') : [];
    const nonBodyParameters = operation.parameters ? operation.parameters.filter(each => each.implementation !== 'Client') : [];
    const parameters = [...nonBodyParameters, ...bodyParameters].filter(each => this.IsConstantEnumParameter(each));
    for (const parameter of values(parameters)) {
      const quote = (<ChoiceSchema>parameter.schema).choiceType.type === SchemaType.String ? '"' : '';
      const csharpType = this.GetCsharpType((<ChoiceSchema>(parameter.schema)).choiceType);
      result.push(`            ${csharpType} ${parameter.language.default.name} = ${quote}${(<ChoiceSchema>parameter.schema).choices[0].value}${quote};`);
    }
    return result.join('\r\n');
  }
  public IsConstantEnumParameter(parameter: Parameter): boolean {
    if (!parameter.required) {
      // const parameters are always required
      return false;
    }
    // skip parameter.schema.type === SchemaType.Constant, since there is a bug
    if ((parameter.schema.type === SchemaType.SealedChoice && (<SealedChoiceSchema>(parameter.schema)).choices.length === 1)
      || (parameter.schema.type === SchemaType.Choice && (<ChoiceSchema>(parameter.schema)).choices.length === 1)) {
      return true;
    }
    return false;
  }

  public IsConstantParameter(parameter: Parameter): boolean {
    if (this.IsConstantEnumParameter(parameter)) {
      return true;
    }
    if (parameter.schema.type === SchemaType.Constant) {
      return true;
    }
    return false;
  }

  public IsConstantEnumProperty(property: VirtualProperty): boolean {
    if (!property.required) {
      // const parameters are always required
      return false;
    }
    // skip parameter.schema.type === SchemaType.Constant, since there is a bug
    if ((property.property.schema.type === SchemaType.SealedChoice && (<SealedChoiceSchema>(property.property.schema)).choices.length === 1)
      || (property.property.schema.type === SchemaType.Choice && (<ChoiceSchema>(property.property.schema)).choices.length === 1)) {
      return true;
    }
    return false;
  }

  public IsConstantProperty(property: VirtualProperty): boolean {
    if (this.IsConstantEnumProperty(property)) {
      return true;
    }
    if (property.property.schema.type === SchemaType.Constant) {
      return true;
    }
    return false;
  }

  public GetUniqueName(name: string, usedNames: Array<string>): string {
    let uniqueName = name;
    let i = 0;
    while (usedNames.includes(uniqueName)) {
      uniqueName = `${name}${++i}`;
    }
    return uniqueName;
  }

  public GetValidCsharpName(name: string): string {
    let validChars = name.replace(/[^a-zA-Z0-9_]/g, '');

    // prepend '_' if the name starts with a digit
    if (!/^[a-zA-Z_]/.test(validChars)) {
      validChars = '_' + validChars;
    }

    return validChars;
  }

  public IsEnum(schema: Schema): boolean {
    if (schema.type === SchemaType.SealedChoice && (<SealedChoiceSchema>schema).choiceType.type === SchemaType.String && schema.extensions && !schema.extensions['x-ms-model-as-string']) {
      return true;
    }
    return false;
  }

  public ConvertToValidMethodGroupKey(key: string): string {
    return key.replace(/Operations$/, '');
  }

  private isCloudErrorName(name: string): boolean {
    // This is to work around the fact that some CloudError will be generated as CloudErrorAutoGenerated in m4
    const reg = new RegExp('^CloudErrorAutoGenerated\\d{0,1}$');
    if (name === 'CloudError' || reg.test(name)) {
      return true;
    }
    return false;
  }

  public IsCloudErrorException(operation: Operation): boolean {
    return (!operation.exceptions || !(<any>operation.exceptions[0]).schema || this.isCloudErrorName((<any>operation.exceptions[0]).schema.language.default.name));
  }
  public PopulateGroupParameters(parameter: Parameter): string {
    const groupParameter = parameter.language.default.name;
    const result = Array<string>();
    for (const virtualProperty of values(<Array<VirtualProperty>>(parameter.schema.language.default.virtualProperties.owned))) {
      let type = virtualProperty.property.schema.language.csharp?.fullname || '';
      type = (this.IsValueType(virtualProperty.property.schema.type) || (virtualProperty.property.schema.type === SchemaType.SealedChoice && (<ChoiceSchema>virtualProperty.property.schema).choiceType.type === SchemaType.String && virtualProperty.property.schema.extensions && !virtualProperty.property.schema.extensions['x-ms-model-as-string'])) && !virtualProperty.required ? `${type}?` : type;
      const CamelName = camelCase(virtualProperty.name);
      result.push(`            ${type} ${CamelName} = default(${type});`);
      result.push(`            if (${groupParameter} != null)`);
      result.push('            {');
      result.push(`                ${CamelName} = ${groupParameter}.${pascalCase(CamelName)};`);
      result.push('            }');
    }
    if (result.length > 0) {
      return result.join('\r\n');
    }
    return '';
  }

  public wrapComments(indentation: string, prefix: string, comments: string): string {
    const defaultMaximumCommentColumns = 80;

    if (comments === null || comments === undefined || comments.length === 0) {
      return '';
    }

    //cannot predict indentation because we cannot get last line generated
    const length = defaultMaximumCommentColumns - prefix.length - 1;
    const result = this.lineBreak(comments, length);
    for (let i = 0; i < result.length; i++) {
      if (i != 0) {
        result[i] = prefix + result[i];
      }
    }
    return result.join('\n' + indentation);
  }

  private lineBreak(comments: string, length: number): Array<string> {
    const splitter = /\r\n|\r|\n/i;
    const lines = new Array<string>();
    for (const line of comments.split(splitter)) {
      let processedLine = line;
      while (processedLine.length > 0) {
        processedLine = processedLine.trim();
        const whiteSpacePositions = [...new Array(processedLine.length).keys()].filter(i => /\s/.test(processedLine[i])).concat([processedLine.length]);
        let preWidthWrapAt = 0;
        let postWidthWrapAt = 0;
        for (const index of whiteSpacePositions) {
          if (index <= length) {
            preWidthWrapAt = index;
          } else if (postWidthWrapAt === 0) {
            postWidthWrapAt = index;
          }
        }
        const wrapAt = preWidthWrapAt != 0 ? preWidthWrapAt : (postWidthWrapAt != 0 ? postWidthWrapAt : processedLine.length);
        lines.push(processedLine.substring(0, wrapAt));
        processedLine = processedLine.substring(wrapAt);
      }
    }
    return lines;
  }
}