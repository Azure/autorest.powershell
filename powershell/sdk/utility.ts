/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { getAllPublicVirtualPropertiesForSdkWithoutInherited, getAllPublicVirtualPropertiesForSdk, VirtualProperty, VirtualProperties } from '../utils/schema';
import { ObjectSchema } from '@azure-tools/codemodel';
import { values } from '@azure-tools/linq';
export class Helper {
  constructor() { }
  public CamelCase(str: string): string {
    return str.replace(/(?:^\w|[A-Z]|\b\w)/g, function (word, index) {
      return index === 0 ? word.toLowerCase() : word.toUpperCase();
    }).replace(/\s+/g, '');
  }
  public PascalCase(str: string): string {
    return str = str.replace(/(\w)(\w*)/g,
      function (g0, g1, g2) { return g1.toUpperCase() + g2.toLowerCase(); });
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
  public IsPrimitiveType(type: string): boolean {
    const primitives = ['boolean', 'integer', 'number', 'unixtime', 'duration', 'uuid', 'date-time', 'date'];
    if (primitives.includes(type)) {
      return true;
    }
    return false;
  }
}