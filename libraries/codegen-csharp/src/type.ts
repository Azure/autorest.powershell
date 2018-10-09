/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { EOL, Initializer } from '@microsoft.azure/codegen';
import { Access } from './access-modifier';
import { Attribute } from './attribute';

import { Method } from './method';
import { TypeContainer, IInterface } from './type-container';
import { Property } from './property';
import { TypeDeclaration } from './type-declaration';

export class Type extends Initializer implements TypeDeclaration {
  public description: string = '';
  public methods = new Array<Method>();
  public properties = new Array<Property>();
  public genericParameters = new Array<string>();
  public where?: string;
  public interfaces = new Array<IInterface>();
  public accessModifier = Access.Public;
  public attributes = new Array<Attribute>();
  public partial: boolean = false;

  protected get attributeDeclaration(): string {
    return this.attributes.length > 0 ? `${this.attributes.joinWith(each => `${each.value}`, EOL)}${EOL}` : '';
  }

  constructor(public namespace: TypeContainer, public name: string, objectIntializer?: Partial<Type>) {
    super();
    this.apply(objectIntializer);
  }

  public get fileName(): string {
    return this.name;
  }
  toString(): string {
    return this.fullName;
  }
  public get allProperties(): Array<Property> {
    const result = new Array<Property>(...this.properties);
    for (const parent of this.interfaces) {
      result.push(...parent.allProperties);
    }
    return result;
  }

  public get genericDeclaration(): string {
    return this.genericParameters.length === 0 ? '' : `<${this.genericParameters.join(',')}>`;
  }

  public get fullName(): string {
    return `${this.namespace.fullName}.${this.name}${this.genericDeclaration}`;
  }

  public get declaration(): string {
    throw new Error(`Not Implemented: property 'declaration' in Type subclass `);
  }

  public get definition(): string {
    throw new Error(`Not Implemented: property 'definition' in Type subclass `);
  }

  public validation(propertyName: string): string {
    return '/*VALIDATION*/';
  }

  public addProperty(property: Property): Property {
    this.properties.push(property);
    return property;
  }
  public addMethod(method: Method): Method {
    this.methods.push(method);
    return method;
  }
  public add<T extends object>(item: T & (Method | Property | Attribute)): T {
    if (item instanceof Method) {
      this.methods.push(item);
      return item;
    }
    if (item instanceof Property) {
      this.properties.push(item);
      return item;
    }
    if (item instanceof Attribute) {
      this.attributes.push(item);
      return item;
    }
    throw Error(`FATAL - UNABLE TO ADD UNKNOWN TYPE for '${JSON.stringify(item)}'`);
  }

}
