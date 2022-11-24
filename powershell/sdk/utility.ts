/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { getAllPublicVirtualPropertiesForSdkWithoutInherited, getAllPublicVirtualPropertiesForSdk, VirtualProperty, VirtualProperties } from '../utils/schema';
import { ArraySchema, DictionarySchema, ObjectSchema, Schema, isObjectSchema, SchemaType, isNumberSchema } from '@azure-tools/codemodel';
import { Dictionary, values } from '@azure-tools/linq';
import { type } from 'os';
import { schema } from '@azure-tools/codemodel-v3';
export class Helper {
  constructor() { }

  public HasConstrains(virtualProperty: VirtualProperty): boolean {
    const schema = <any>virtualProperty.property.schema;
    if (!!schema.minium || !!schema.maximum || !!schema.maxLength || !!schema.minLength || !!schema.maxItems || !!schema.minItems || !!schema.multipleOf || !!schema.pattern || !!schema.uniqueItems) {
      return true;
    }
    return false;
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
          const virtualProperties = getAllPublicVirtualPropertiesForSdk(modelToValidate.language.default.virtualProperties);
          values(virtualProperties).where(p => isObjectSchema(p.property.schema)).forEach(cp => typesToValidate.push(cp.property.schema));
          if (values(virtualProperties).any(p => (p.required && p.property.schema.type !== SchemaType.Constant) || this.HasConstrains(p))) {
            return true;
          }
        }
      }
    }
    return false;
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
          if (modelToValidate.parents && modelToValidate.parents.immediate.length === 1) {
            typesToValidate.push(modelToValidate.parents.immediate[0]);
          }
        }
      }
    }
    return false;
  }

  public CamelCase(str: string): string {
    str = str.replace(/(?:^\w|[A-Z]|\b\w)/g, function (word, index) {
      return index === 0 ? word.toLowerCase() : word.toUpperCase();
    }).replace(/\s+/g, '');
    return str;
  }
  public PascalCase(str: string): string {
    str.replace(/(\w)(\w*)/g,
      function (g0, g1, g2) { return g1.toUpperCase() + g2.toLowerCase(); });
    return str;
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
}