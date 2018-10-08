/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { comment, docCommentPrefix, EOL, indent, sortByName } from '@microsoft.azure/codegen';
import { Namespace } from './namespace';
import { Type } from './type';

export class Interface extends Type {
  constructor(parent: Namespace, name: string, objectIntializer?: Partial<Interface>) {
    super(parent, name);
    this.apply(objectIntializer);
    parent.addInterface(this);

    if (!this.description.trim()) {
      this.description = `FIXME: Interface ${name} is MISSING DESCRIPTION`;
    }
  }

  public get fileName(): string {
    return this.name;
  }

  public get definition(): string {
    const colon = this.interfaces.length > 0 ? ' : ' : '';
    const implementsInterfaces = this.interfaces.map(v => v.fullName).join(', ');
    const description = comment(this.description, docCommentPrefix);
    const methods = this.methods.sort(sortByName).map(m => m.interfaceDeclaration).join(EOL);
    const properties = this.properties.sort(sortByName).map(m => m.declaration).join(EOL);
    const partial = this.partial ? 'partial ' : '';

    return `
${description}
${this.attributeDeclaration}${this.accessModifier} ${partial}interface ${this.name}${colon}${implementsInterfaces} {
${indent(properties, 1)}
${indent(methods, 1)}
}
`.trim();
  }

  public get declaration(): string {
    return this.fullName;
  }

}
